
Aşağıda, **Etkinlik 2: Microsoft Copilot ile API Kodunda Hata Ayıklama** (Kullanıcı Yönetimi API’si) için **kullanıma hazır Yanıt Anahtarı / “ne yapmalı + neyi belgelendirmeli”** yer alıyor. *Etkinlik 1* API’nizin tipik bir *minimal API* veya *controller API* olduğu ve *in-memory* depolama ( *List/Dictionary* ) kullandığı varsayılmıştır. Bu yanıt anahtarı her iki stil için de uygundur.

---

## 🐞 Adım 2 — Hataları Belirle (Copilot’un bulması gerekenler)

### 🧾 Hata A — Doğrulama eksik (kötü veriyle kullanıcı ekleniyor)

**Belirtiler**

* `POST /users` boş ad, geçersiz e-posta, negatif yaş vb. kabul eder.
* Daha sonra endpoint’ler “tuhaf” davranır veya depolanan veri geçersiz olduğu için çöker.

**Copilot’a ne sorulmalı**

> “İşte User Management API kodum. POST ve PUT içinde eksik doğrulamaları tespit et. Sağlam bir doğrulama yaklaşımı öner (DataAnnotations veya manuel doğrulama) ve düzeltilmiş kodu göster.”

**Beklenen bulgular**

* `Name` için boşluk/uzunluk kontrolleri yok
* E-posta format doğrulaması yok
* İstek gövdesi için null kontrolü yok
* Kısıtlar eksik (Age >= 0, Name max length vb.)

---

### 🔎 Hata B — Mevcut olmayan kullanıcıları getirmek hataya yol açıyor

**Belirtiler**

* `GET /users/{id}` 500 / exception döndürür veya 200 ile null döndürür.
* Eksik ID’ler için `PUT/DELETE` çöker veya yanlış durum kodu döndürür.

**Copilot’a ne sorulmalı**

> “Id ile kullanıcıya eriştiğim tüm yerleri bul. Eksik kullanıcılar exception yerine net bir mesajla 404 dönsün.”

**Beklenen düzeltmeler**

* Eksik ID’ler için `Results.NotFound()` / `return NotFound()` kullan
* Kontrol yapmadan `First(...)` kullanma; `FirstOrDefault(...)` kullan
* `List` üzerinde sınır kontrolü olmadan index erişimi yapma

---

### 💥 Hata C — Yakalanmayan exception’lar + eşzamanlılık sorunları nedeniyle ara sıra çökme

**Belirtiler**

* Hızlı tekrarlanan çağrılarda uygulama çöker veya tutarsız sonuçlar döndürür.
* Yakalanmayan exception’lar dışarı taşar.

**Copilot’a ne sorulmalı**

> “Yakalanmayan exception oluşabilecek yerleri göster ve global exception handling + eşzamanlı erişim için daha güvenli bir veri yapısı öner.”

**Beklenen düzeltmeler**

* Global exception handler middleware ekle
* Thread-safe store kullan (`ConcurrentDictionary<int, User>`) veya `List/Dictionary` etrafında lock uygula
* Endpoint’lerin duplicate ID veya eksik key durumlarında throw etmemesini sağla

---

### 🚦 Hata D — GET /users içinde performans darboğazı

**Belirtiler**

* `GET /users` her istekte tekrar tekrar doğrusal tarama yapabilir
* Verimsiz lookup’lar (her seferinde liste aramak)

**Copilot’a ne sorulmalı**

> “GET /users ve GET /users/{id} endpoint’lerini optimize et. Id ile O(1) lookup ve minimum allocation istiyorum.”

**Beklenen düzeltmeler**

* Kullanıcıları `Id` ile anahtarlanmış `ConcurrentDictionary<int, User>` içinde tut
* LINQ taramaları yerine `TryGetValue` kullan
* Sayfalama opsiyonel (belgelendirmek için güzel bir iyileştirme)

---

## 🛠️ Adım 3 — Hataları Düzelt (Referans Uygulama)

### ✅ Seçenek 1: Minimal API (Lab için önerilir)

Şunları içeren “drop-in” örnek:

* doğrulama
* doğru 400/404 yanıtları
* thread-safe depolama
* global exception handling
* temel logging

```csharp
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseExceptionHandler(exceptionApp =>
{
    exceptionApp.Run(async context =>
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        await context.Response.WriteAsJsonAsync(new { error = "Beklenmeyen bir hata oluştu." });
    });
});

app.UseSwagger();
app.UseSwaggerUI();

var users = new ConcurrentDictionary<int, User>();
var nextId = 0;

app.MapGet("/users", () =>
{
    // Hızlı: dictionary values snapshot
    return Results.Ok(users.Values.OrderBy(u => u.Id));
});

app.MapGet("/users/{id:int}", (int id) =>
{
    return users.TryGetValue(id, out var user)
        ? Results.Ok(user)
        : Results.NotFound(new { error = $"User {id} bulunamadı." });
});

app.MapPost("/users", (CreateUserRequest request) =>
{
    var errors = Validate(request);
    if (errors.Count > 0) return Results.BadRequest(new { errors });

    var id = Interlocked.Increment(ref nextId);
    var user = new User
    {
        Id = id,
        Name = request.Name.Trim(),
        Email = request.Email.Trim(),
        Age = request.Age
    };

    users[id] = user;
    return Results.Created($"/users/{id}", user);
});

app.MapPut("/users/{id:int}", (int id, UpdateUserRequest request) =>
{
    if (!users.TryGetValue(id, out var existing))
        return Results.NotFound(new { error = $"User {id} bulunamadı." });

    var errors = Validate(request);
    if (errors.Count > 0) return Results.BadRequest(new { errors });

    existing.Name = request.Name.Trim();
    existing.Email = request.Email.Trim();
    existing.Age = request.Age;

    users[id] = existing;
    return Results.Ok(existing);
});

app.MapDelete("/users/{id:int}", (int id) =>
{
    return users.TryRemove(id, out _)
        ? Results.NoContent()
        : Results.NotFound(new { error = $"User {id} bulunamadı." });
});

app.Run();

static List<string> Validate(CreateUserRequest req)
{
    var errors = new List<string>();
    if (string.IsNullOrWhiteSpace(req.Name)) errors.Add("Name zorunludur.");
    if (req.Name?.Trim().Length > 100) errors.Add("Name <= 100 karakter olmalıdır.");
    if (string.IsNullOrWhiteSpace(req.Email)) errors.Add("Email zorunludur.");
    else if (!new EmailAddressAttribute().IsValid(req.Email)) errors.Add("Email geçersizdir.");
    if (req.Age is < 0 or > 130) errors.Add("Age 0 ile 130 arasında olmalıdır.");
    return errors;
}

static List<string> Validate(UpdateUserRequest req)
{
    // Bu lab için create ile aynı kurallar
    var errors = new List<string>();
    if (string.IsNullOrWhiteSpace(req.Name)) errors.Add("Name zorunludur.");
    if (req.Name?.Trim().Length > 100) errors.Add("Name <= 100 karakter olmalıdır.");
    if (string.IsNullOrWhiteSpace(req.Email)) errors.Add("Email zorunludur.");
    else if (!new EmailAddressAttribute().IsValid(req.Email)) errors.Add("Email geçersizdir.");
    if (req.Age is < 0 or > 130) errors.Add("Age 0 ile 130 arasında olmalıdır.");
    return errors;
}

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public int Age { get; set; }
}

public record CreateUserRequest(string Name, string Email, int Age);
public record UpdateUserRequest(string Name, string Email, int Age);
```

**Bu neden senaryoyu karşılar**

* Doğrulama, kötü kullanıcıların eklenmesini engeller (Hata A)
* Mevcut olmayan kullanıcılar için 404 döner (Hata B)
* Global exception handler, çökme ve detay sızıntısını engeller (Hata C)
* `ConcurrentDictionary`, güvenli erişim ve O(1) lookup sağlar (Hata D)

---

## 🧪 Adım 4 — Test Et & Düzeltmeleri Doğrula (Edge-case kontrol listesi)

Postman/*curl* kullanın.

### ✅ Doğrulama testleri

* Boş ad ile `POST /users` → **400**
* `"abc"` gibi geçersiz email → **400**
* yaş `-5` → **400**

### 🕵️ Mevcut olmayan kullanıcı testleri

* `GET /users/999` → **404**
* `PUT /users/999` → **404**
* `DELETE /users/999` → **404**

### 🧯 Stabilite testleri

* Hızlı `POST` (10–20 adet peş peşe) → çökme olmamalı
* `POST` atarken hızlı `GET` → exception olmamalı

### 🎯 Başarılı senaryo (Happy path)

* Kullanıcı oluştur → **201** ve Location `/users/{id}`
* Kullanıcı getir → **200**
* Kullanıcı güncelle → **200**
* Kullanıcı sil → **204**

---

## 📝 Adım 5 — Dokümantasyon (“Copilot yardımcı oldu…” kısmında ne yazmalı)

Gönderiminizde şu yapıyı kullanın:

### 🧩 Düzeltilen Hatalar

1. **Doğrulama eksikliği**
   * Sorun: API boş/geçersiz alanları kabul ediyordu
   * Düzeltme: Name/Email/Age doğrulama kontrolleri eklendi; hata listesiyle 400 döner
2. **Mevcut olmayan ID yönetimi**
   * Sorun: Eksik kullanıcılar için GET/PUT/DELETE hata veriyor veya yanlış durum kodu dönüyordu
   * Düzeltme: `TryGetValue` / `NotFound` yanıtları eklendi; tutarlı JSON error payload sağlandı
3. **Yakalanmayan exception’lar**
   * Sorun: Ara sıra çökme / 500 stack trace’leri
   * Düzeltme: Generic 500 yanıtı döndüren global exception handler middleware eklendi
4. **Performans darboğazı**
   * Sorun: Her istekte liste taraması ve LINQ kullanımı
   * Düzeltme: O(1) id lookup için `ConcurrentDictionary<int, User>`’a geçildi

### ⚡ Copilot Hata Ayıklamayı Nasıl Hızlandırdı

* Riskli kalıpları tespit etti (`First`, index erişimi, eksik null kontrolleri)
* En iyi uygulama HTTP durum kodlarını önerdi (400/404/201/204)
* Thread-safe depolama ve error-handling middleware önerdi
* Refactor edilmiş kodu hızlıca üretti; ben de edge-case’lerle inceleyip test ettim

---

Eğer  *Etkinlik 1* ’deki gerçek **Program.cs** (ve varsa controller/model dosyaları) içeriğinizi yapıştırırsanız, **satır satır “Copilot tarzı” bir hata denetimi** yapıp, sizin sürümünüzü tamamen yeniden yazmadan beklenen davranışa yaklaştıran **minimal bir patch** ( *diff-like* ) üretebilirim.

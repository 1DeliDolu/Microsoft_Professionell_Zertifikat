## 🧩 Custom Middleware

.NET’in sağladığı yerleşik ( *built-in* ) *middleware* çoğu zaman ihtiyaçlarınızı karşılar, ancak bu her zaman geçerli değildir. Gerçekten benzersiz bir yazılım geliştirirken, çoğu zaman kendi  *middleware* ’inizi oluşturmanız gerekir. Bu videoda ASP.NET Core’da **custom middleware** uygulayacağız.

---

## 🧱 Basit CRUD API ile Başlangıç

Bu kursta daha önce oluşturduğumuz basit bir CRUD API ile başlayalım.  **C-R-U-D** ,  *Create* ,  *Read* , *Update* ve *Delete* anlamına gelir. Adından da anlaşılacağı gibi, veri oluşturma, silme, ekleme ve güncelleme gibi işlemler için route’larımız var.

Bu örnekte veri, *blog posts* sınıfından oluşuyor. Bunu, bilgisayar belleği içinde post ekleyip çıkarabildiğimiz basit bir liste kullanarak saklıyoruz.

Bu yüzden uygulamayı sıfırlarsak, bu iki orijinal blog post’una geri döneceğini unutmayın.

---

## 🧩 `app.Use()` ile Middleware Ekleme

Bir middleware ekleme şeklimiz şu: **`app.Use()`** ile başlayacağız ve iki argüman alan bir fonksiyon geçeceğiz. Birincisine  **`context`** , ikincisine **`next`** diyeceğiz.

Burada iki farklı türde bilgi geçiyoruz:

* **`context`** : request ve response hakkında bazı bilgiler içeren bir nesnedir.
* **`next`** : aslında başka bir  *request delegate* ’dir.

Bunu geçmemizin nedeni, oluşturduğumuz *request delegate* içinden onu çağırabilmemizdir. Bunu *async* yapmak istiyorum, bu yüzden **`next.Invoke`** diyeceğim. Ve şimdi o fonksiyonu çağırıyoruz.

Bu,  *middleware* ’leri birbirine zincirlememizi sağlar. Bu yüzden buna *pipeline* diyoruz. Bir  *middleware* ’den diğerine, diğerine, diğerine geçersiniz; ta ki sonunda bir route handler’a (ya da *terminal middleware* olarak bilinen şeye) ulaşana kadar. Sonra da,  *middleware* ’lerinizin ek kodlarını çağırmak için zincir boyunca geriye doğru bir nevi geri “kabarcıklanır” ( *bubble back* ).

---

## 🛑 Terminal Middleware Davranışı

Onları *terminal* yapabilme davranışı şu şekildedir: bir şeyi terminal yapmak için tek yapmanız gereken,  **bu `Invoke` ifadesini çağırmamaktır** . Bu, middleware’i terminal yapar.

Bu durumda zinciri sonlandırır ve geriye doğru *bubble back* eder.

---

## ⏮️ Önce / Sonra Kod Çalıştırma Mantığı

Şimdi, “önce” kodunu yukarıda, “sonra” kodunu aşağıda çalıştırabileceğinizi söylüyorum. Daha önce bunun hakkında konuştuk, ama bu çok önemli bir kavram.

Özetle:

* Bu kod, `Invoke` çağrılmadan önce çalışır.
* Sonra bir sonraki middleware’e geçilir.
* Bir şey terminal olduğunda, “sonra” kodları çalışmaya başlar ve zincir boyunca geriye doğru devam eder.

Yani:

* “Önce” kodları ilk middleware’den son middleware’e kadar çalışır.
* Sonra “sonra” kodları son route delegate’ten ilk route delegate’e kadar çalışır.

---

## 🧾 `context` Bilgisini Kullanma

Şimdi `context`’teki bilgileri nasıl kullanabileceğimizi gösterelim.

```csharp
app.Use(async (context, next) =>
{
    Console.WriteLine(context.Request.Path);

    await next.Invoke();

    Console.WriteLine(context.Response.StatusCode);
});
```

---

## ▶️ Sunucuyu Çalıştırma

Şimdi bunu kaydedip sunucumu başlatırsam:

```bash
dotnet watch run
```

Sonra isteklerim için yeni bir dosya oluşturacağım.

Ve şimdi şöyle diyebiliriz:

```http
GET http://localhost:5228/blogs
```

Bunu çalıştırdığımda ek bir çıktı görmeliyim. Sayfayı ilk yüklediğini, path ve status code verdiğini ve sonra tekrar path ve status code aldığımızı görebilirsiniz. Bu şu anda çalışan tüm middleware’imiz; aslında sadece tek bir middleware.

---

## ⏱️ İstek Süresini Ölçen Middleware

Şimdi biraz daha ilginç bir şey yapan bir uygulama gösterelim. Bu middleware tamamen faydalı; ben böyle middleware’i sürekli yazarım çünkü hızlıca bir şey loglamak isterim ve resmi logging middleware’ini kullanmak istemem; o ayrıntı seviyesine ihtiyacım olmaz.

Şimdi istek yapmanın ne kadar sürdüğünü söyleyen bir middleware oluşturalım. Bu gerçekten çok faydalı.

Yine **`app.Use()`** diyeceğiz. Burada da *async* gerekiyor çünkü fonksiyonu asenkron çalıştıracağız. Argümanlarımız yine **`Context`** ve **`Next`** olacak; ardından yine  **`next.Invoke`** .

Bir isteğin çalışmasının ne kadar sürdüğünü loglamak istiyorum. Bu yüzden `next` delegate çalışmadan önce zamanı alabilirim. Pipeline’ın başında zamanı kaydedip, tüm delegate’ler bittikten sonra güncel zamanı alır ve farkı hesaplarım; böylece tüm pipeline’ın toplam süresini elde ederim.

```csharp
app.Use(async (context, next) =>
{
    var startTime = DateTime.UtcNow;

    await next.Invoke();

    var duration = DateTime.UtcNow - startTime;
    Console.WriteLine($"Duration was {duration}");
});
```

Bu size bir log verir.

Buradaki önemli bir nokta şudur: Middleware’ler zincir halinde bağlandığı için, bu middleware diğer middleware’den önce çalışır. Yani bu kod çalışır, sonra diğer kod çalışır, sonra geriye döneriz. Böylece bu kod, sonra diğer kod çalışır.

Eğer pipeline’ın tüm uzunluğunu loglamak istiyorsak, bunu logging kodumuzdan önce koymamız gerekir. Belki bir sebepten istemeyiz, ama bilin ki birden fazla middleware kullanırken, uygulamanız için anlamlı bir sıraya göre yerleştirin.

---

## 🧩 `app.UseWhen()` ile Koşullu Middleware

Şimdi çok daha karmaşık bir middleware oluşturacağız. Bunun gerçekten güzel bir demo olduğunu düşünüyorum.

**`app.UseWhen()`** diyelim. `UseWhen`, `useMiddleware`’den farklı çalışır. `useMiddleware` tüm route’lar üzerinde “blanket” şekilde çalışır; ama `UseWhen` kullanarak bunu koşullu çalıştırabiliriz.

Bir *Boolean* dönen bir fonksiyon alır. Bunu her zaman `true` döndürecek şekilde yazarsak normal middleware gibi çalışır ve her zaman çalıştırır, ama bunu istemiyoruz. Koşullu olmasını istiyoruz.

---

## 🔒 GET Olmayan İsteklerde API Key Kontrolü

Benim yapmak istediğim şey: Route’un bir **GET** isteği olup olmadığını kontrol eden bir middleware.

Eğer GET isteği yaptıysa, “tamam, devam et” diyeceğiz.

Ama eğer bir blog post’u güncellemek, silmek veya eklemek isterse, bu durumda “secret password” gerekecek; bu örnekte buna bir **API key** diyeceğiz. Bu, API’ye “elevated access” sağlar.

Bunu yapmak için, GET olmayan istekleri yakalayacağız:

```csharp
app.UseWhen(context => context.Request.Method != "GET", appBuilder =>
{
    appBuilder.Use(async (context, next) =>
    {
        var extractedPassword = context.Request.Headers["XAPIKey"];

        if (extractedPassword == "thisIsABadPassword")
        {
            await next.Invoke();
        }
        else
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Invalid APi key");
        }
    });
});
```

Burada şifreyi **headers** üzerinden alıyoruz.

Headers, payload ile doğrudan ilişkili olmayan bilgilerin gönderildiği özel veri alanlarıdır. Buna *metadata* denir. Örneğin bir POST yapıyorsanız, blog body payload’dur; şifre ise o veriyi göndermenize izin veren bilgidir. Yani bu metadata’dır ve bu örnekte header biçimindedir.

Headers, key-value şeklinde bir dictionary gibi saklanır. Bu yüzden header adını **`XAPIKey`** olarak veriyoruz.

---

## 🧪 POST İsteği ile 401 Testi

Şimdi sunucumuzu yeniden başlatalım.

Bir GET isteği sorunsuz geçmelidir. Şimdi bir **POST** isteği deneyelim.

Content type:

* **`application/json`**

Payload:

* `title`: `"my title"`
* `body`: `"my body"`

Şunu gönderirsek, **401** hatası görmeliyiz:

```http
POST http://localhost:5228/blogs
Content-Type: application/json

{
  "title": "my title",
  "body": "my body"
}
```

---

## ✅ Header Ekleyerek Yetkilendirme

Şimdi header eklemek için aynı isteği tekrar yapalım ve **`xAPIKey`** ekleyelim; bu, yukarıda kullandığımız şifreyle aynı olacak:  **`thisIsABadPassword`** .

Tırnak işaretlerini almamaya dikkat edin; bu çalışmaz.

```http
POST http://localhost:5228/blogs
Content-Type: application/json
xAPIKey: thisIsABadPassword

{
  "title": "my title",
  "body": "my body"
}
```

Teoride bunu çalıştırdığımızda blog post’un oluşturulması gerekir. Bunu yazarsam üçüncü blog’u eklediğimizi göreceksiniz.

Ve tekrar **xAPIKey** olmadan denersem çalışmaz.

Test ettiğimiz bir diğer şey: Birisi yanlış bir **xAPIKey** girerse ne olur?

Örneğin:

```http
xAPIKey: thisIsAGoodPassword
```

Bu bizim gerçek şifremiz olmadığı için yine reddedilir.

---

## ✅ Kapanış

Şimdi çok faydalı olabilecek üç harika middleware oluşturduk; bunları gerçek bir uygulamada da kullanabilirsiniz.

Yine: Böyle bir şifreyi bu şekilde uygulamak isterseniz, bir Bing araması yapıp environment variables’ı araştırmanızı öneririm; bunu kodda string olarak tutmak pek güvenli değildir. Çünkü biri kodunuza erişirse, bu API key’i de ele geçirir ve tam erişim kazanır.

Ama bunun dışında, tüm bu mantık tamamen geçerlidir.

Bu, *xAPIKey* ile blog post’larınızın  *posting* ,  *putting* , *deleting* işlemlerine erişebilen bir administrative interface oluşturmanıza izin verir; fakat tüm tüketicileriniz yalnızca veriyi alabilir, böylece blog’unuza gidebilirler.

Ve her zaman olduğu gibi, bu kodun bir kopyasını alıp her şeyin nasıl çalıştığını anlamak için onunla oynamanızı şiddetle tavsiye ederim. Daha fazla mantık ekleyin, başka bir middleware ekleyin, middleware sırasını değiştirin ve bunun nasıl etkileştiğine dair bir his edinmeye çalışın.

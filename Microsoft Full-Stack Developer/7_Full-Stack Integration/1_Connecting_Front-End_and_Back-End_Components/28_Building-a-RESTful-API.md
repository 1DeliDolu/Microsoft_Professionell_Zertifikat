## 🧪 Building a RESTful API

Bu guided lab için template’ten bir web API kullanacağız. Bu komutu kullanıyorum: **dotnet new webapi -o** ve proje adını veriyorum. Projeyi ben zaten kurdum ama şu şekilde kurdum:  **GL RESTful API** . Enter’a basarsınız ve proje sizin için oluşturulur.

Mac’te `code` komutunu ve proje adını kullanabilirsiniz. Yani:

`code GL-RESTfulAPI`

Enter’a bastığınızda proje ayrı bir pencerede açılır.

---

## 🧩 Step 1: Program.cs İçine Bağımlılıkları Eklemek

Projenin step one’ında `Program.cs` dosyasına bazı bağımlılıklar ekliyoruz.

En üstte `builder.Services.AddControllers` satırını görüyorsunuz. Eklenmesi gereken ilk öğe bu.

Ardından template’te zaten bulunması gereken `app = builder.Build()` var.

`app.UseRouting` komutunu ekleyin. **Dikkat:** `app.UseRouting`, `app` tanımından sonra gelmek zorunda. Yani `var app` satırından sonra.

Sonra `app.UseEndpoints` ekliyorum; bu da `app` tanımından sonra gelmek zorunda.

Ve lab’i kurarken, bu eklemelerin tamamının `app.Run` satırının üstünde olduğundan emin olmanız gerekiyor.

---

## 📄 Step 2: Counter.cs Dosyası Oluşturma

Step two’da bir **Counter.cs** dosyası oluşturacaksınız.

Bu küçük butona tıklayın; yeni bir dosya oluşturma imkânı verir. Dosya adını **counter.cs** yapın.

İçine class’ı ekleyeceksiniz. Yani class’ı kopyalayıp yapıştırın.

---

## 🔌 Step 3: Endpoints’i Uygulama

Step three’de endpoint’leri implement edeceğiz.

Şimdi tekrar `Program.cs` dosyasına döneceğiz ve endpoint’ler burada. Ben `UseEndpoints`’in altına koydum ve iyi çalışıyor.

Bu arada, eğer `app.UseHttpsRedirection` varsa ve bunu gerçekten çalıştırmak istiyorsanız, bunu comment’lemek zorundasınız; çünkü HTTPS kullanır ama bunun için bir sertifikaya ihtiyacınız var ve bizde yok. Bu yüzden comment’leyin; sorun olmaz.

Şimdi şunları ekleyeceksiniz:

* `var counters = new List<Counter>()`
* İki adet route: `app.MapPost("/counters", ...)`
* Üçüncü route: `app.MapGet("/counters", ...)`
* Ve `app.MapPost("/counters/{name}/increment", ...)`

Bunlar `app.Run` satırından önce gelmeli. Yani uygulamanın route’larını orada kuruyorsunuz.

---

## ▶️ Çalıştırma

Çalıştırmak ve test etmek için:

```bash
dotnet run
```

Belirli bir portta çalışacak, örneğin:

`http://localhost:512...`

---

## 🧪 Postman ile Test Etme

Şimdi Postman’a geçip test edeceğim.

İlk olarak `localhost/counter`’a POST atacağız. Postman’da **POST** seçtim.

Sonra **Body** sekmesini seçtim ve  **raw** ’ı seçtim. Buraya JSON’u girmeniz gerekiyor.

Çok basit bir örnek kullanıyorum: `name` alanı **sample** ve gönderiyorum… ve **not found** alıyor.

Muhtemelen route’u yanlış girdim. Bir saniye.

Route **counter** değil  **counters** .

Tamam, bunu yaptığımda sample oluşturuldu.

Şimdi ikinci bir sample gönderebilirim. Tamam, artık iki sample var ve ID güncelleniyor.

---

## 📥 GET /counters ile Listeleme

Şimdi başka bir sekmede GET route’u var. Burada da yine route’a **counters** yazmanız gerekiyor ve gönderdiğiniz iki sample’ı döndürmesi gerekir.

Artık `sample1` ve `sample2` görünüyor; bu GET çağrısının route’u.

---

## ➕ POST /counters//increment ile Count Artırma

Bu işin özü, counter’ı o çağrı ile güncellemek.

Üçüncü sekmeye geçiyorum; bu da bir  **POST** .

Yine counters yazmayı unutmuşum; route’a ekleyelim.

Burada `sample1`, eklediğim sample’lardan birinin adı. `sample1` ve `sample2` eklemiştim. İkisinden birini kullanabilirsiniz.

Sonuna da `increment` geliyor.

Gönderdiğimde count’u 1’e güncellediğini görebilirsiniz.

Send’e tıklamaya devam edersem, uygulama count’u sürekli artırmaya devam eder.

Bu guided lab için kurulumun ve testin özü budur.

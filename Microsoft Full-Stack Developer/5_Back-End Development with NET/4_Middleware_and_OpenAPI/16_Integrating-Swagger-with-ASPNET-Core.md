## 🧩 Integrating Swagger with ASP.NET Core

Bir back-end geliştirici olarak API’nizi insanların kullanabilmesi için dokümante etmek, en önemli ve en zaman alan işlerden biridir. Dokümantasyonun alttaki işlevsellik ile senkron kalması kritiktir; çünkü yanlış dokümantasyon çoğu zaman hiç dokümantasyon olmamasından daha kötüdür.

*Swagger* ile çalışmanın en büyük faydalarından biri, dokümantasyonunuzun alttaki kodu otomatik olarak yansıtmasıdır. Şimdi bunu CRUD uygulamamıza entegre edelim. Bu videoda Swagger’ı ASP.NET Core kodumuza nasıl entegre edeceğimizi açıklayacağız.

---

## 🏷️ İsimlendirme: OpenAPI, Swagger, Swashbuckle

Önce bazı isimlendirme kurallarını netleştirmek istiyorum.  *OpenAPI* , *Swagger* ve *Swashbuckle* var.

* *OpenAPI* , API’leri dokümante etmek için bir standarttır. Bunu özel bir sözdizimi ( *syntax* ) gibi düşünebilirsiniz.
* *Swagger* , bu standartla çalışan ve bu standardı üreten API’ler için oluşturulmuş araçlardır.
* *OpenAPI* birkaç yıl önce *Swagger* ile birleşti, bu yüzden sıklıkla birbirlerinin yerine kullanıldıklarını duyarsınız; ama teknik olarak bir fark vardır.
* *Swashbuckle* ise .NET dünyasında Swagger’ı içeren bir  *namespace* ’tir. Burada yukarıda görüyorsunuz.

Swagger’ı etkinleştiren bazı kritik paketleri barındırır.

---

## 📦 Gerekli Paketleri Kurma

Şimdi bunları anladığınıza göre, API’mize Swagger eklemeye başlayalım.

İlk yapmamız gereken, gerekli bağımlılıkları kurmak; ben bunu bu videodan önce yaptım. Bunlardan biri  **`Microsoft.AspNetCore.OpenApi`** , diğeri ise  **`Swashbuckle.AspNetCore`** .

Bu iki bağımlılığı yansıtmak için en üste `using` ifadelerini ekledim. Bunları kurmak için Command Palette ve NuGet’i kullanabileceğinizi unutmayın.

---

## ✅ Swagger Eklemek İçin Yapılacak 4 Şey

Paketler kurulduktan sonra temelde dört şey yapmamız gerekiyor.

---

## 🧰 1) Endpoint Explorer Servisini Ekleme

İlk olarak  **builder** ’ı alıp bir servis ekleyeceğiz:

**`builder.Services.AddEndpointsApiExplorer()`**

Bu, tüm farklı route’larımıza bakacak ve onları dokümante etmekte kullanılacak bir servis ekler.

---

## 📘 2) SwaggerGen Servisini Ekleme

Sonra şunu ekleyeceğiz:

**`builder.Services.AddSwaggerGen()`**

 *SwaggerGen* ,  *Endpoints API Explorer* ’ın yaptığı şeyi alır ve  *OpenAPI standard* ’ını karşılayacak şekilde dönüştürür.

Yani API’nizin yaptığı her şeyi dokümante eden bir JSON dokümanı üretir.

---

## 🧩 3) Middleware Eklemek ve Sadece Development’ta Çalıştırmak

Sonra middleware eklemek istiyoruz. Bunun için önce bir **if** ifadesi oluşturacağız.

Bunu yapmamızın nedeni, ortamın development olup olmadığını kontrol etmek istememiz. Bu, bu kodun sadece kendi makinemizdeki development server’da çalışmasını ve production’da çalışmamasını sağlar.

Bunun önemli olmasının nedeni şudur: Swagger ile API’niz hakkında çok fazla bilgi dışarı veriyorsunuz ve bunu API’nize erişebilen herkese körü körüne açmak istemezsiniz.

Bu yüzden, çok önemli bir sebebiniz yoksa bunu bu şekilde kullanmanızı öneririm. Bunu sadece kendi geliştirme sürecinizde dahili olarak kullanabilirsiniz.

Burada önce şu middleware’i ekleyeceğiz:

* **`app.UseSwagger()`**
* **`app.UseSwaggerUI()`**

`UseSwagger`, üretilmiş Swagger dokümanını belirli bir URL’de açığa çıkaran bir route oluşturur.

`UseSwaggerUI` ise bu JSON’u alır ve onun etrafında çalışması keyifli, tam bir kullanıcı arayüzü oluşturur.

---

## ▶️ Uygulamayı Çalıştırma

Şimdi bunu kaydedebiliriz. Terminali açıp şunu çalıştıracağım:

```bash
dotnet watch run
```

Build tamamlanınca tarayıcıyı açacaktır.

---

## 🧾 Swagger JSON Dokümanını Görme

Şimdi şuraya gidebilirim:

`/swagger/v1/swagger.json`

Harika. Bu bizim OpenAPI standard’ına uygun Swagger dokümanımız.

Bunu incelerseniz, biraz “obtuse” görünüyor; çok fazla bilgi var. Ama içine baktığınızda şunları görebilirsiniz:

* root path
* blogs path
* GET
* POST
* blogs.id için GET
* DELETE
* PUT
* aldığı parametreler
* dönecek body
* response’ların ne olacağı

Yani API’nin tüm işlevselliğini anlamak için ihtiyacınız olan her şey burada.

Teknik olarak bunu anlıyorsanız her şeyi anlıyorsunuz, ama okunabilir değil; işte burada Swagger UI devreye giriyor.

---

## 🧭 Swagger UI

Şimdi path’i geri alıp `/swagger`’a gidersem, şöyle bir ekran görürüz.

Bu aynı bilgi, ama çok daha okunabilir bir şekilde sunulur.

Örneğin  **blogs.get** ’e gidelim:

* blogs route’u burada
* parametre almadığını görürsünüz
* hangi response’ları döndürebileceğini görürsünüz
* return’ün nasıl görünebileceğini görürsünüz

Bunu bilmesinin nedeni, aşağıda *blog object* için schema’yı görmenizdir:

* nullable string
* nullable string

Buradan “Try it out” ve “Execute” diyebiliriz ve bu, blog endpoint’ine bir çağrı yapar.

Daha önce  *curl* ’dan bahsetmiştik; bu bir CLI aracıdır. Buradaki komutu kopyalayıp komut satırına yapıştırırsanız, doğrudan terminalinizden request atar.

Burada:

* URL
* headers

gibi birçok faydalı bilgi vardır.

Yani şimdiye kadar kullandığımız `requests.http` dosyası hâlâ işe yarar, ama bunun gibi otomatik dokümantasyon üreten bir araca sahip olmak çok kullanışlıdır.

---

## 🧪 POST Route’u ile Deneme

POST route’una geldiğimizde, hangi datayı beklediğini bilir.

“Try it out” deriz, prompt çıkar:

* “this is my title”
* “this is my body”

Sonra execute ederiz; “typo ve hepsiyle” bile çalışır.

Burada 201 response aldığımızı görürüz.

Sonra geri dönüp blogs get yaparız ve tüm blog’larımızın geldiğini görürüz.

Görünüşe göre yanlışlıkla iki kez execute ettim, ama kesinlikle çalıştığını görüyoruz.

---

## ✨ 4 Satır Kod ile Arayüz

Bir adım geri atıp şunu belirtmek istiyorum: Bu güzel arayüzü almak için yalnızca dört satır kod ekledim.

Eskiden tüm geliştirme ekipleri bu tip dokümantasyon işi için ayrılırdı; hâlâ da birçok durumda ayrılıyorlar, haklı sebeplerle. Ancak birçok senaryoda bu yaklaşım sizi çok ileri taşır.

Çoğu zaman yalnızca buraya kadar gitmek bile yeterlidir. Ama bir adım daha ileri gidebiliriz.

---

## 🧩 `WithOpenApi` ile Route Açıklamalarını Zenginleştirme

Uygulamaya geri dönebilir ve route’larda bunu daha ilginç hâle getirecek şeyler yapabiliriz.

Bir route’a bir method call daha ekleyelim ve **`WithOpenApi`** diyelim.

Bu bir *operation* alacak ve sonunda  *operation* ’ı döndürecek; ama önce operation üzerinde değişiklikler yapacağız.

Örneğin:

* operation’ın parametrelerini alabiliriz
* ilk parametre olan ID için bir description verebiliriz

Daha önce ID’nin ne olduğuna dair açıklama yoktu; şöyle diyebiliriz:

“ID of the blog to retrieve.”

Sonra:

* `operation.Summary = "Get single blog"`
* `operation.Description = "Returns a single blog"`

---

## 🔄 Yeniden Yükleme ve Sonuç

Kaydedip dokümantasyona geri döndüğümüzde, muhtemelen server reset gerekecek. `Ctrl+R` ile yenileyebiliriz.

Şimdi:

* “Get single blog” summary olarak görünür
* daha uzun description’ı görebiliriz
* ID’nin açıklamasını görebiliriz

Bu tek `WithOpenApi` çağrısıyla çok faydalı bilgiler sağlayabiliriz. Bing aramasıyla bununla neler yapılabildiğine bakabilirsiniz; değiştirilebilecek birçok başka özellik vardır.

---

## ⚠️ Response Kodlarının Dokümantasyonla Senkronu

Şu an dokümantasyona bakarsak, yalnızca 200 OK döndürebildiğini söylüyor. Ama aslında *not found* da döndürebilir.

Yani bu teknik olarak doğru değil.

Bunu düzeltmenin ilk yolu (ve ben bunu pek önermiyorum) şudur:

* `Produces<Blog>(StatusCodes.Status200OK)`
* `Produces(StatusCodes.Status404NotFound)`

Kaydedip yeniden yükleyince, UI’da artık 200 veya 404 döndürebileceğini görürüz.

Ama sorun şu: Bu iki şeyi manuel olarak yazdık. Eğer kodumu değiştirip üçüncü bir seçenek eklersem ve burayı güncellemezsem, dokümantasyon artık yalan söyler; yani kodun gerçeğini yansıtmaz.

Bu yüzden ben bunları kaldırıp daha iyi bir yaklaşıma geçiyorum.

---

## ✅ `Results` Yerine `TypedResults` Kullanma

Bunun yerine  *Results* ’u daha faydalı bir şeyle değiştirebiliriz.

Yapacağım şey: *Results* yerine **`TypedResults`** kullanmak.

Bu, bu tarz API’lerle çalışırken best practice kabul edilir.

Çoğu zaman *typed results* kullanmak, *results* kullanmaktan daha iyidir. Sadece üretmesi biraz daha fazla kod ister.

Burada ne döneceğini tanımlamamız gerekir:

* `Ok<Blog>`
* `NotFound`

Bir hata alıyorum; çünkü `HttpResults` eklemem gerekiyor. Bunu ekleyince düzeliyor.

Kaydedip restart ettikten sonra dokümantasyona döneriz.

Artık, başka bir typed result eklersem dokümantasyon otomatik olarak uyumlu kalır.

Kod ile dokümantasyon artık senkron dışı kalmaz.

Bu yüzden API’nizin döndürebileceği tipleri doğru şekilde belirtmek için *typed results* kullanmanızı kesinlikle öneririm.

Bunu ilk öğrendiğimde biraz sihir gibi gelmişti. Dokümantasyonu çok daha kolay ve çok daha sağlam yapıyor. Bunu bozmak gerçekten zorlaşıyor; eğer her zaman typed results kullanırsanız.

---

## 🙈 Bazı Route’ları Dokümantasyondan Gizleme

Son olarak: Bazen göstermemek istediğiniz bir route olabilir.

Şu anda root route’u gösteriyoruz. Belki bunu istemiyorum.

Bu durumda:

**`ExcludeFromDescription()`** metodunu çağırabilirim.

Bunu yaptığımda bu route Swagger dokümantasyonunda görünmez.

---

## ✅ Kapanış

Bu süreci takip ederek Swagger’ı ASP.NET Core projenize entegre etmiş olacaksınız.

Bu, API’niz için açık, dinamik ve etkileşimli dokümantasyon sağlar ve bunu hem sizin hem de sizden sonra kullanacak geliştiriciler için API’yi kullanmayı ve anlamayı çok daha kolay hâle getirir.

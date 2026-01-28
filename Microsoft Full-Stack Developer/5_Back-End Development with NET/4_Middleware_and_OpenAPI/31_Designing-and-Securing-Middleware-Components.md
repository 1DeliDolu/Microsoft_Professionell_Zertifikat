## 🛡️ Designing and Securing Middleware Components

Bu lab’de, ASP.NET uygulamamızı middleware kullanarak güvenli hâle getireceğiz. Her şey “simüle” olacak; ancak bu, çeşitli middleware bileşenleriyle bir ASP.NET uygulamasını nasıl güvence altına alabileceğimize dair iyi bir fikir verecek.

---

## 🧱 Step 1: Uygulamayı Kurma

İlk adımda uygulamamızı kuruyoruz.

---

## ⚙️ Step 2: Configuration Seçenekleri

İkinci adımda bazı configuration seçenekleri yapacağız.

Uygulamayı **HTTP only** olacak şekilde ayarlayacağız. Gerçek bir uygulamada HTTPS kullanmak isterdik, ancak bu örnek sadece web server’ı çeşitli seçeneklerle nasıl yapılandırabileceğimizi gösteriyor.

Web application için **create builder** metodunun çıktısını **builder** değişkenine atadığımızda, birçok farklı özelliği build edebilme imkânı elde ederiz.

İlk ekleyeceğimiz şey web server configuration olacak. Burada:

**`builder.WebHost.ConfigureKestrel`**

Kestrel, kullanacağımız ASP.NET’in altında çalışan hafif web server’dır.

Burada bazı option’lar set edeceğiz. **options** değişkenini kullanarak uygulamaya şunu söylüyoruz:

Uygulama yalnızca **localhost** üzerinde **5294** portunu dinlesin.

Bu bir HTTP portu. Yani web server’a sadece bu portu dinlemesini söylüyoruz.

Bu web server ayarını yaptıktan sonra bir **app** değişkeni oluşturuyoruz ve bunu web builder’ın **Build** metodunun çıktısına atıyoruz.

Artık hazırız.

Dosyanın en altında (bu koddaki detaylara sonra bakacağız) **`app.Run`** var. Bu da uygulamayı çalıştırır ve birazdan oluşturacağımız tüm middleware’leri devreye sokar.

Bu, dosyanın en üstünde yapılan temel kurulum.

---

## 🛡️ Step 3: İlk Middleware Security Component

Şimdi ilk middleware güvenlik bileşenimizi kuruyoruz.

Buradaki **`app.Use(async (context, next) => { ... })`** bloğu eklediğimiz middleware parçasıdır.

Middleware’in kendisi, `app.Use` bloğunun içindeki her şeydir.

**context** ve  **next** , uygulamaya şunu söyler: Bu middleware çalıştıktan sonra sıradaki middleware’e geç.

Bu örnekte birden fazla middleware’i zincirleyeceğiz ve her biri bir güvenlik kontrolü olacak. Her biri API’ye gelen request’te çok spesifik bir şeyi kontrol edecek.

İlk satır olan **`context.Request.Query`** kontrolü query string’i inceler.

Bu, tarayıcının address bar’ına yazdığınız URL’deki query string’i kontrol eder ve belirli şeyleri arar.

Bu örnekte query string içinde **secure** kelimesini arıyor ve değerinin **true** olup olmadığını kontrol ediyor.

Eğer true değilse:

* Response status code’u **400** yapıyoruz
* Tarayıcıya “simulated HTTPS required” yazıyoruz

Bu “güvenli bir bağlantı değil” anlamına gelir.

Buradaki ünlem işareti `!` “not true” demektir; yani secure değil.

Tekrar: Bu simülasyon. Gerçek dünyada bunu daha ciddi şekilde ele alır ve kullanıcının ilerlemesine izin vermezsiniz.

Sonra `await next()` ile bir sonraki middleware’e geçiyoruz.

---

## ✅ Step 4: Input Validation Middleware

Step two’da bir başka `app.Use` bloğumuz var; bu ikinci middleware.

Burada request’ten gelen **input** değerini alıyoruz. Bu input, query string içindeki `input` parametresinden geliyor.

Sonra **`IsValidInput`** adlı metodla bu input’u kontrol ediyoruz.

Aşağıda yer alan:

**`static bool IsValidInput(...)`**

metodu şu kontrolleri yapıyor:

* input null veya empty mi?
* input’ta harf veya rakam var mı?
* input `<script>` tag’ini içeriyor mu?

Bunun amacı, gerçek dünyada query string üzerinden gelebilecek kötü amaçlı kodları engellemektir.

Bu örnekte sadece şunları kontrol ediyoruz:

* null/empty değil
* harf/rakam içeriyor
* `script` içermiyor

Hepsi doğruysa  **true** , değilse **false** döner.

Middleware içinde:

Eğer input geçerli değilse (`!IsValidInput`):

* Status code’u **400** set ederiz
* Response’a “invalid input” yazarız
* Kullanıcının ilerlemesine izin vermeyiz

Bu ikinci middleware’imiz.

---

## 🚫 Step 5: Authorization ve Authentication Middleware

Step three’de authorization kontrolü yapan bir middleware yazıyoruz.

Burada query string içinde **unauthorized** path’ini arıyoruz.

Tarayıcı URL’i örneğin:

`localhost:5000/unauthorized`

gibi olabilir.

Eğer bunu görürsek:

* Response’a “unauthorized access” yazarız
* `return` ile çıkarız

Sonra `await next()` ile bir sonraki middleware’e geçiş sağlanır.

Bir sonraki blokta ise **authentication** kontrolü var.

Bir önceki blok authorization idi; bu blok authentication.

Burada query string içinde **authenticated** keyword’ünü arıyoruz ve true olup olmadığına bakıyoruz.

Bu da simüle: query string üzerinden true/false yapıyoruz.

Eğer authenticated false ise (`if (!isAuthenticated)`):

* Status code’u **403** yapıyoruz (security response)
* “access denied” yazarız
* Devam etmeyiz

Eğer authenticated true ise:

* Secure cookie gönderiyoruz
* Cookie içinde `secure data` var
* Cookie options:
  * `HttpOnly = true`
  * `Secure = true`

Sonra kullanıcı devam edebilir.

Bu middleware gerçek dünyada çok iş yapmıyor ama gerçek dünyada daha robust hâle getirilebilir.

Ve kullanıcıya secure bağlantı sonrasında belirli işlemleri yapma izni tanıma gibi seçenekler içerir.

---

## ⏳ Step 6: Asynchronous Processing Middleware

Son middleware, asenkron işlemeyi simüle ediyor.

Burada:

* **`await Task.Delay(100)`** ile çok kısa bir gecikme
* Sonra response’a “we processed the response asynchronously” yazdırma

Bu, asenkron bir testin simülasyonudur.

---

## 🔁 Middleware Akışı

Middleware süreci burada şöyle işler:

Pipeline en üstten başlar ve middleware’den middleware’e ilerler; her birinde belirli koşulları kontrol eder.

* Koşullar true ise, kullanıcı devam edebilir.
* Koşullar false ise, akış durdurulur ve ilgili güvenlik yanıtı döndürülür.

Bu şekilde, query string üzerinde çeşitli kontroller yaparak ve kullanıcının geçerli bir kullanıcı olduğunu doğrulayarak çok güvenli bir ASP.NET site oluşturmak için middleware seçeneklerini kullanabilirsiniz.

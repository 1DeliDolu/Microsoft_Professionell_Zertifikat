## 🧩 Integrating Swagger and Generating API Clients

API dokümantasyonu üretmek ve API’nin nasıl çalıştığını çok fazla manuel iş yapmadan görebilmek için Swagger API kullanarak bir console application kuracağız. Bu hedeflerin bir kısmını Swagger ile gerçekleştireceğiz.

---

## 🖥️ Step 1: Console Application Kurulumu

Step one’da Console application’ımızı kuruyoruz. Sonra uygulamaya tüm paketlerimizi ekliyoruz.

Swagger kurulumunun bir parçası olan  **Swashbuckle.AspNetCore** ’u ekliyoruz ve ardından **NSwag** adlı bu aracı kullanıyoruz.

Şu paketleri ekliyoruz:

* **NSwag.Core**
* **NSwag.CodeGeneration.CSharp**
* **NSwag.ApiDescription.Client**

Bu paketlerin tamamı, uygulamamız içinde Swagger kullanarak API dokümantasyonu ve açıklamalar üretmemizi sağlar.

---

## 🧰 Step 2: Uygulamada Swagger Yapılandırması

Step two’da, uygulamada Swagger’ı yapılandırıyoruz.

En üstte ASP.NET Core Builder’ı ekliyoruz; bu ASP.NET Core uygulama yapılandırmasının bir parçasıdır.

Ayrıca burada *dependency injection* kullanıyoruz. *Dependency injection* kullanmamızı sağlayan bir extension library var; bu sayede Swagger dokümantasyonunu uygulamamıza enjekte edebiliyoruz.

İlk satır, ihtiyaç duyduğumuz tüm servisleri oluşturabilmemizi sağlayan  **`WebApplication.CreateBuilder`** ’dır. **Builder** adında bir değişkeni bu metodun çıktısına eşitliyoruz.

Sonraki iki satırda controller’larımızı ve endpoint’lerimizi ekliyoruz. Bunlar API’de ihtiyaç duyacağımız genel parçalar.

Sonra Swagger araçlarını ekliyoruz. **`Builder.Services.AddSwaggerGen`** satırını görüyorsunuz. Bu, uygulamayı kurmak için ihtiyaç duyduğumuz tüm Swagger kodunu üretir.

Ardından **app** değişkenini kullanarak tüm bu bileşenleri build ediyoruz. **app** değişkenini **Builder.Build** metoduna eşitliyoruz; böylece uygulama için ihtiyaç duyacağımız servisleri almış oluyoruz.

Sonra bir sonraki satırda uygulamaya Swagger’ı kullanmasını söylüyoruz:  **`App.UseSwagger`** .

 **`App.UseSwagger`** , uygulamaya tüm Swagger servislerini kullanmasını söyler.

**`App.UseSwaggerUI`** ise dokümantasyonun üretildiği kısımdır; böylece URL’de  **`/swagger/v1/swagger.json`** ’a gittiğinizde, uygulamanız için üretilen tüm API dokümantasyonunu alırsınız.

Swagger burada çok zaman kazandırır; çünkü dokümantasyonu sizin üretmenize gerek kalmaz, Swagger bunu sizin için yapar.

Son olarak controller’ların hepsini map ediyoruz. Bu, uygulamanın ihtiyaç duyduğu controller’ları eşleyen başka bir ASP.NET metodudur.

En altta uygulamayı **`App.Run`** ile çalıştırırız.

Birazdan bu koda geri döneceğim. Bu Step two’yu tamamlar.

---

## 🗺️ Step 3: ASP Specification Tanımlama

Step three’de ASP specification’ı tanımlıyoruz.

Bunun için controllers klasöründeki **UserController** dosyasını kullanıyoruz. Bu dosya route’umuzu kurar.

**`[ApiController]`** ve **`[Route]`** gibi keyword’leri kullandığımızda, uygulamaya şunu söylüyoruz:

Kullanıcı **`/api/`** + controller adı ile bir endpoint’e giderse, belirli bir çıktı alacak; bir sonuç döneceğiz. Burada bunu tanımlıyoruz.

Şimdi route’un bir **GET** route olduğunu söylüyoruz. CRUD işlemlerini hatırlayın: GET bilgi çeker.

Bu, JSON üretir. Bu action’ın sonucu, bir user object oluşturmak olacak. Kullanıcıyı **id** ile alıyoruz; fonksiyonumuza bunu parametre olarak geçiriyoruz.

Bu, id ile user’ı getirir ve **OK** döndürür. Yani aslında işlemin başarılı olduğunu döndürüyoruz.

User object ise yukarıda tanımlı.

Bu dosyada esasen **User** adlı bir class oluşturuyoruz ve şunları içeriyor:

* `int Id`
* `string Name`

User object’in tamamı bu.

Dolayısıyla bu controller’ı bu route üzerinden çağırdığımızda, user’ı bu objeye koyacağız ve JSON olarak çıktı vereceğiz.

Bu aslında uygulamanın gövdesidir; çünkü uygulamanın bir iş yapması gerekir ve bunu bir yerde tanımlamalıyız. Biz de **UserController.cs** içinde tanımladık.

Bu Step three.

---

## 🧰 Step 4: NSwag ile API Client Üretme

Step four’da artık NSwag kullanarak API client bilgisi üreteceğiz.

**ClientGenerator** dosyasına gideceğiz. Bu bir utility dosyasıdır; yani bu dosyayı “iş yapmak” için kullanırız. Uygulamanın çekirdek bir parçası değildir.

Birazdan nasıl çalıştığını göreceksiniz.

Bu dosyada NSwag kütüphanelerini kullanıyoruz:

* NSwag (genel)
* NSwag.CodeGeneration.CSharp (C# kod üretmek için özel)

**ClientGenerator** adlı bir class tanımlıyoruz ve içinde tüm işi yapan **GenerateClient** adlı async bir metodumuz var.

İlk satırlarda HTTP client tanımlıyoruz; bu, HTTP protokolünü kullanarak iş yapacağımız anlamına gelir.

**swaggerJson** adında bir değişken oluşturuyoruz; bu değişken, şu URL’den alınır:

`http://localhost:5000/swagger/v1/swagger.json`

Kullanıcı bu adrese gidebilir ve dokümantasyon orada üretilir.

Sonra **document** adında başka bir değişken ayarlıyoruz; bu, JSON formatını kullanarak OpenAPI dokümantasyonunu üretir.

Ardından settings ayarlarını yapıyoruz; bu settings değişkeni, namespace’i ve gerekli dokümantasyonu o namespace’e göre üretmek için kullanılır.

Son üç satırda iş gerçekleşir:

* **`new CSharpClientGenerator`** oluştururuz (NSwag’in parçası)
* Yukarıda oluşturduğumuz document’i ve ayarları (settings) geçiririz
* Sonra **GenerateFile** metoduyla kodu üretiriz
* Üretilen kodu **generatedApiClient.cs** dosyasına yazarız

Bu kod çalıştırıldığında, uygulamamızın kullanabileceği yeni bir C dosyası üretir; bu dosya, uygulamamızın tanımladığı API için kullanıcıya gerekli dokümantasyonu sağlayacak şekilde istemci kodunu üretir.

Swagger bunu sizin yerinize yapar ve API’nizi her değiştirdiğinizde ya da güncellediğinizde bu metodu çağırabilirsiniz. Bu metod, Swagger kullanarak tüm dokümantasyonu sizin için yeniden üretir.

Şu an bu metodu çağırmadık. Sadece dosyayı yazdık ki ana uygulamadan çağırabilelim.

---

## 🏷️ Step 5: Class Name ve Namespace Ayarlama

Step five’da class isimlerini ayarlıyoruz.

Burada **OctoberApiClient** ve **MyClientNamespace** görüyorsunuz; bunları istediğimiz şeye çevirebiliriz.

Yani **GenerateClient** metodunun içinde class name ve namespace’i uygulamamız için uygun olacak şekilde özelleştiriyoruz.

Bu, uygulamanızla eşleşecek şekilde düzenlemek için bir fırsattır.

---

## 🔌 Step 6: Üretilen Client’ı Entegre Etme

Step six’da üretilen client’ı entegre ediyoruz.

Program.cs dosyasına döndüğümüzde, bir **HttpClient** değişkeni tanımladığımızı görürsünüz; bunu HTTP çağrıları yapmamızı sağlayan internal bir HttpClient’e eşitliyoruz.

Sonra client’ı, oluşturduğumuz custom API client namespace üzerinden `localhost` domain’inde `5000` portuna set ediyoruz ve HttpClient’i içeri geçiriyoruz.

Bu, Swagger ile ürettiğimiz custom client üzerinden HTTP çağrıları yapmamızı sağlar.

Burada ayrıca comment edilmiş bir async task görüyoruz. Bu task, önceki adımda yazdığımız client generator kodunu çağırır.

Bunu comment ettim çünkü bunu yalnızca API’yi güncellediğimizde veya yeni bir API oluşturduğumuzda çalıştırmak istiyoruz. Çünkü yaptığı şey, API’nizi alıp dokümantasyonu üretmektir.

Ben bunu zaten çalıştırdım ve Swagger’ın ürettiği **GeneratedApiClient.cs** dosyasının oluştuğunu görebilirsiniz.

Bu dosyaya girmeyeceğim; çünkü çok karmaşık ve şu anki amaçlarımız için gerekli değil.

Ama yaptığımız şey şu:

* `ClientGenerator.GenerateClient()` çalıştırılır
* `GeneratedApiClient.cs` dosyası üretilir
* sonra bu dosya kullanılarak API dokümantasyonu ve istemci çağrıları yapılır

Bu dosyayı zaten ürettiğim için, o kod bloğunu comment ettim ve şimdi HttpClient ile üretilmiş custom client’ı kullanarak çağrılar yaptığım yeni bloğu çalıştırıyorum.

En üstte ayrıca ayarladığım namespace’i kullanmam gerekiyor.

Benim client namespace’im, **ClientGenerator.cs** dosyasında ayarladığım namespace ve bunun tutarlı olması şart.

Yani o dosyada hangi namespace’i kullandıysam, burada da uygulamada onu kullanmalıyım.

Bu Step six, ve program için hepsi bu.

Swagger’ı API dokümantasyonu üretmek için bu şekilde kullanıyoruz.

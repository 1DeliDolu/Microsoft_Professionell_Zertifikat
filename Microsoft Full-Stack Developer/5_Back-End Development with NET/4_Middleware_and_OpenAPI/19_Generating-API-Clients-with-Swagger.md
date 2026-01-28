## 🧩 Generating API Clients with Swagger

Şu ana kadar API sunucumuzda çalışacak kodları nasıl oluşturacağımızı öğrendik. Ancak bu back-end kodunun tüm amacı, bir istemci ( *client* ) için faydalı bir araç sağlamaktır. Bunun gerçekleşmesi için istemcinin sunucumuza *requests* göndermesi ve gelen *responses* ile çalışması gerekir.

Bu işlemleri ele almak için kodu manuel yazmak hem zaman alıcıdır hem de inanılmaz derecede hataya açıktır. Ama bunun böyle olması gerekmiyor. Bu videoda, Swagger kullanarak API istemcilerinin ( *API clients* ) nasıl üretildiğini açıklayacağız.

---

## 🧰 Swagger Nedir?

Swagger kullanarak, sunucumuzla front-end iletişimini yöneten fonksiyonları ve aktarılacak tüm veri tiplerini içeren istemci kodunu otomatik olarak üretebiliriz.

Bu koda genellikle bir *software developer kit* ya da **SDK** denir. Front-end geliştiricisinin back-end ile haberleşen istemci uygulamalarını oluşturmak için kullanabileceği “yapı taşları” gibidir.

Bu yaklaşım, geliştiricilerin front-end’in temel işlevlerine odaklanmasını sağlarken, projeler genelinde tutarlı ve güvenilir API etkileşimlerini garanti eder.

Swagger, API planını ( *blueprint* ) etkileşimli ve kullanıcı dostu bir deneyime dönüştüren bir araç setidir. Geliştiricilerin REST API’leri tasarlamasına, inşa etmesine, dokümante etmesine ve tüketmesine yardımcı olur.

Ayrıca, geliştiricilerin normalde manuel yapmak zorunda kalacağı işleri otomatikleştirir.

Swagger’ın faydalı olmasının nedeni, API’nin  *endpoints* ’lerini ve veri formatlarını tanımlayan *OpenAPI Specification* kullanarak istemci kodu üretimini otomatikleştirmesidir. Bu, zaman kazandırır, tutarlılık sağlar ve API’lerle etkileşimde hataları azaltır.

---

## 🗺️ OpenAPI ile API Specification Oluşturma

İstemci kodu üretmeden önce bu sürecin kilit kısmını gözden geçirelim: OpenAPI ile API specification oluşturma.

İlk adım, OpenAPI formatını kullanarak API specification oluşturmaktır. Bu specification, API’nizin  *endpoints* ’lerini, parametrelerini ve  *responses* ’larını tanımlar.

Bu, API’nizin nasıl çalıştığına dair bir plan ( *blueprint* ) görevi görür ve API ile diğer sistemler arasında tutarlı iletişimi sağlar.

Örneğin, kullanıcı detaylarını getiren bir  *get-user-id endpoint* ’ini dokümante edebilirsiniz; burada kullanıcı ID’si bir parametredir ve beklenen yanıt JSON formatında tanımlanır.

---

## 🧩 Swagger Middleware ile JSON Olarak Sunma

İkinci adımda, Swagger Middleware kullanarak bu API specification’ını belirli bir route üzerinde JSON olarak yayınlayabilirsiniz.

Bu, API specification’ını dışarıya açar; böylece kodunuz, diğer yazılımlar ve hatta diğer geliştiriciler bunu kullanabilir.

---

## 🧰 NSwag ile Client Code Üretme

Üçüncü adım, API isteklerini ve yanıtlarını yöneten istemci kodunu üretmek için **NSwag** kullanmaktır.

Bu, API ile etkileşim kurmak için gereken mantığı manuel olarak yazmaktan sizi kurtarır; çünkü her şey API’nizin beklediği şekilde veri gönderip alacak biçimde hazır gelir.

---

## 🔌 Üretilen Client Kodunu Projeye Entegre Etme

Son adımda, üretilen istemci kodunu herhangi bir harici kütüphane gibi C# projenize entegre edersiniz.

Eklendikten sonra, düşük seviyeli iletişim ayrıntılarıyla uğraşmadan API’den veri almak için metotları kolayca çağırabilirsiniz.

---

## 🧪 Pratik Örnek

Her şeyi pratik bir örnekle birleştirelim.

Dış bir API’den kullanıcı bilgilerini yöneten bir web uygulaması geliştirdiğinizi hayal edin.

Önce şu işlemleri yapan API route’larını tanımlarsınız:

* tüm kullanıcıları getirmek
* bir kullanıcıyı silmek
* kullanıcı izinlerini değiştirmek

Sonra Swagger Middleware kullanarak bu veriyi belirli bir path’te yayınlarsınız. Genellikle bu şöyle olur:

`/swagger/v1/swagger.json`

Ardından NSwag kullanarak aşağıdaki gibi istemci fonksiyonlarını üretirsiniz:

* get users
* delete users
* update user permissions

Bu istemciyi:

* NSwag CLI ile,
* NSwag desktop application ile,
* veya NSwag C# libraries ile

üretebilirsiniz.

Son olarak istemci kodunu uygulamanıza entegre edersiniz.

Tüm istemci metotları, route’ların hangi veriyi beklediğini ve ne döndürmesi gerektiğini tam olarak bilir. Kod uygun tiplere sahiptir; böylece *IntelliSense* ile server kodunu anlamak zorunda kalmadan API ile tam olarak nasıl etkileşime gireceğinizi hızlıca görebilirsiniz.

API’nizde her değişiklik yaptığınızda, istemci kodunu yeniden üretebilir ve yeniden ekleyebilirsiniz.

---

## ✅ Özet

Bu videoda Swagger kullanarak API istemcilerinin nasıl üretildiğini öğrendiniz.

Swagger’ın  *OpenAPI specification* ’ı kullanarak API endpoint’lerini nasıl dokümante ettiğini ve NSwag’ın istemci kodu üretimini nasıl otomatikleştirdiğini ele aldık.

Ayrıca üretilen kodun bir projeye nasıl entegre edildiğini ve bunun API isteklerini daha kolay ve daha güvenilir hâle getirerek zaman kazandırıp hataları azalttığını incelediniz.



## 🧩 Generating API Clients with Swagger

---

## 📌 Introduction

Swagger ile API client üretmek, istemci kodunu otomatik üreterek API etkileşimlerini geliştirmeyi ve sürdürmeyi kolaylaştırır. Bu yaklaşım geliştirme süresinden tasarruf sağlar, hataları azaltır ve istemci-sunucu iletişiminde tutarlılığı garanti eder.

---

## 🧩 Key Points

---

## 🧰 Swagger Overview

Swagger, API etkileşimleri için istemci kodu üretimini *OpenAPI Specification* kullanarak otomatikleştirir. Bu specification, API  *endpoints* ’lerini, parametrelerini ve veri formatlarını detaylandırır.

Bu dokümantasyon, tutarlı API entegrasyonları oluşturmak için bir plan ( *blueprint* ) görevi görür.

---

## 🔄 Process of Client Code Generation

---

## 🗺️ Create API Specification

API’nin  *endpoints* ’lerini, parametrelerini ve  *responses* ’larını OpenAPI formatında tanımlayın; bu, istemci-sunucu etkileşimleri için net bir yapı oluşturur.

---

## 🧾 Serve Swagger JSON

API specification’ını JSON olarak dışa açın; bu, diğer yazılımların veya geliştiricilerin specification’a programatik olarak referans verebilmesini sağlar.

---

## 🧰 Generate Client Code with NSwag

API’nin specification’ına uygun şekilde *requests* ve *responses* işlemlerini yöneten istemci kodunu otomatik üretmek için **NSwag** kullanın.

---

## 🔌 Integrate Client Code

Üretilen kodu projeye ekleyerek istemci uygulaması ile sunucu API’si arasında sorunsuz iletişim sağlayın.

İstemci kodu üreterek geliştiriciler, API etkileşimlerini manuel kodlamaktan kaçınabilir; böylece geliştirme süreci sadeleşir, doğruluk artar ve gerektiğinde API güncellemeleri kolayca desteklenir.

---

## ✅ Conclusion

Swagger kullanarak API client üretimi, API etkileşimlerine verimlilik ve güvenilirlik kazandırır. Bu sayede geliştiriciler temel işlevlere odaklanırken, back-end servisleriyle tutarlı ve güncel iletişimi koruyabilir.

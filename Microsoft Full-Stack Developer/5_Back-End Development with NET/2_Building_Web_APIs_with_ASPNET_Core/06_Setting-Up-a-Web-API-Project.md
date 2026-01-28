## 🧩 Bir Web API Projesi Kurulumu

API’ler, uygulamaların işlevsel ve bağlantıda kalmasında kritik bir rol oynar. Verimli API’ler oluşturmak için kullanılan araçlarda ustalaşmak, duyarlı ve ölçeklenebilir yazılımlar geliştirmenin anahtarıdır.

Bu videoda, *ASP.NET Core* ile basit bir web API oluşturma sürecini açıklayacağız.

---

## 📄 Proje Kurulumu İçin Temel Dosyalar

Bir web API projesi kurarken iki önemli dosyayı anlamanız gerekir: `program.cs` ve `startup.cs`.

### ⚙️ `program.cs`

`program.cs`, uygulamanın yaşam döngüsünü yönetmek için uygulama yapılandırmasının, servislerin ve host’un ayarlandığı giriş noktası (entry point) olarak görev yapan bir dosyadır.

Temel olarak, gerekli servislerin, middleware’in ve host’un ayarlanması da dahil olmak üzere uygulama için bir temel oluşturur.

Host, sunucu başlatma ve kapatma, dependency injection ve configuration yükleme dahil olmak üzere uygulamanın yaşam döngüsünü yönetir.

---

### 🧰 `startup.cs`

Bir sonraki dosya `startup.cs`’dir. Bu dosya, middleware ve servisleri yapılandırarak uygulamanın yöneticisi (manager) rolünü üstlenir.

İsteklerin nasıl ele alındığını tanımlar, gelen istekleri yönlendirmek için routing’i ayarlar ve middleware bileşenlerini, güvenliği ve daha fazlasını yöneterek uygulamanın sorunsuz çalışmasını sağlar.

Step-by-step istekleri işleyen pipeline’daki her middleware bileşeni burada yapılandırılır.

Bu, `startup.cs` dosyasını istek işleme ve uygulama başlangıcı için merkezi bir merkez (central hub) hâline getirir.

---

## 🧭 Controllers ile Başlamak

Artık `program.cs` ve `startup.cs` dosyalarını anladığımıza göre, controllers ile başlayarak bir web API projesinin nasıl kurulup geliştirileceğini inceleyelim.

 *ASP.NET Core* ’da controller’lar `controllers` klasöründe saklanır ve HTTP isteklerini ele alan mantığı burada tanımlarız.

Controller’ları, gelen istekler ile bu isteklerin talep ettiği veri ya da eylemler arasında bir köprü olarak düşünebilirsiniz.

API’mizi oluşturmaya başlamak için bir controller eklememiz gerekir; bu önemlidir çünkü API’nizin gelen isteklere nasıl yanıt vereceğini tanımlar.

Bir API controller, HTTP isteklerini işleyen ve yanıtları geri gönderen bir sınıftır.

Uygulamanızın verisi veya işlevselliği ile etkileşim kurmak için ana giriş noktasıdır. Her controller, belirli istekleri ele almaktan ve uygun yanıtı döndürmekten sorumludur.

Örneğin, bir e-ticaret API’sinde bir controller ürünlerle ilgili istekleri ele alabilir. Buna tüm ürünleri listelemek, belirli bir ürünün detaylarını getirmek ve envantere ürün ekleme, güncelleme veya kaldırma gibi eylemleri gerçekleştirmek dahildir.

---

## 🔗 API Endpoints Tanımlama

Controller kurulduktan sonra bir sonraki adım API endpoint’lerini tanımlamaktır.

Bu, API’nin gelen istekleri nasıl ele alacağını belirler.

Bu işlem, controller içinde belirli bir route’a erişildiğinde hangi aksiyonun alınacağını belirleyen metotlar oluşturularak yapılır.

Tanımladığınız her metot, benzersiz bir API endpoint’ine bağlanır ve API’nizin ilgili URL çağrıldığında uygun şekilde yanıt vermesini sağlar.

Bir API endpoint, istemcilerin sunucunuzla etkileşim kurması için bir adres görevi gören belirli bir URL’dir.

API endpoint, isteklerin gönderildiği konumu tanımlar.

İstemcilerin veri almasına, bilgi göndermesine veya API’niz üzerinden sunucuda eylemler gerçekleştirmesine olanak tanır.

---

## 🧭 Routing Yapılandırma

Peki  *ASP.NET Core* , bir istek geldiğinde hangi metodu çağıracağını nasıl bilir?

Burada routing yapılandırması devreye girer.

 *ASP.NET Core* ’da routing, HTTP isteğini API’nizdeki uygun endpoint’e eşler.

Varsayılan olarak  *ASP.NET Core* , convention-based routing kullanır.

Bu, istekleri adlarına göre otomatik olarak controller action’larına eşlediği anlamına gelir.

Örneğin, `/api/products` endpoint’ine yapılan bir istek, uygun controller’a yönlendirilir; burada HTTP istek tipine (örneğin bir GET isteği için `get products`) uyan bir metot çalıştırılır.

Bu routing, `startup.cs` dosyasında yapılandırılır ve isteğe göre doğru controller ve action’ın tetiklenmesini sağlar.

---

## 🏷️ Attribute Routing ile Daha Fazla Kontrol

Convention-based routing iyi çalışsa da bazen routing istekleri üzerinde daha fazla kontrole ihtiyaç duyarsınız.

 *ASP.NET Core* , route’ları doğrudan controller içinde attribute routing kullanarak özelleştirmenize izin verir.

Bu, URL’nin tam olarak nasıl görünmesi gerektiğini ve hangi metoda eşleneceğini tanımlamanızı sağlar.

Örneğin, ID’sine göre bir ürün getiren bir route oluşturmak istediğinizi varsayalım.

Bu durumda controller metodunuzda route’u şu attribute ile tanımlayabilirsiniz:

```csharp
[HttpGet("products/{id}")]
```

Bu, URL’yi `/api/products/{id}` şeklinde metoda eşler ve metodun belirli bir ürün için GET isteklerini ele almasını sağlar.

Bu yaklaşım, `{id}` kısmının istekte gönderilen gerçek ürün ID’si ile değiştirildiği temiz ve açıklayıcı bir URL üretir.

---

## 🌐 HTTP Metotlarını Anlamak

Bir endpoint oluşturmadan önce HTTP metotlarını anlamak önemlidir.

API’ler, farklı eylemleri gerçekleştirmek için farklı HTTP metotları kullanır.

En yaygın HTTP metotları şunlardır: veri almak için `get`, yeni veri oluşturmak için `post`, veriyi güncellemek için `put` ve veriyi kaldırmak için `delete`.

---

## 🧪 API’yi Test Etme

Routing ve endpoint’ler ayarlandıktan sonra API’yi test etme zamanı gelir.

Bunu yapmak için uygulamayı geliştirme ortamınızdan veya terminalden başlatın.

Proje çalıştığında, bir tarayıcı açılır ve oluşturduğunuz endpoint’lere giderek basit `get` isteklerini test edebilirsiniz.

`post` veya `put` gibi daha karmaşık istekler için, farklı istekler göndermenize ve detaylı yanıtları görmenize olanak tanıyan harici araçlar kullanabilirsiniz.

Bu araçlar, canlıya (go live) almadan önce API’nizi kapsamlı şekilde test etmek ve debug etmek için gereklidir; böylece beklediğiniz gibi çalıştığından emin olabilirsiniz.

---

## ✅ Kapanış

Bu videoda, *ASP.NET Core* ile basit bir web API’nin nasıl oluşturulacağını öğrendiniz.

`program.cs` ve `startup.cs` gibi temel dosyaları ve bunların API’nizin temelini nasıl oluşturduğunu ele aldık.

Ayrıca bir controller eklemeyi, endpoint’leri ayarlamayı ve istekleri yönetmek için routing kullanmayı öğrendiniz.

Bununla birlikte,  *ASP.NET Core* ’un özelliklerini kullanarak kendi API’nizi oluşturup test etmeye hazırsınız.

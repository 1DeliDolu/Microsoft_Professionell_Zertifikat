## 🧩 Microsoft Copilot ile Entegrasyon Kodunu Geliştirme ve İyileştirme

İstemci (client) ve sunucu (server) uygulaması oluştururken, istemci ile sunucunun doğru şekilde iletişim kurduğundan emin olmak istersiniz: doğru parametreler, doğru çağrılar ve benzeri tüm detaylar. Bunu bilmek ve her şeyin hizalandığını doğrulamak zorlayıcı olabilir; ancak **Microsoft Copilot** gibi bir araçla bu zorlukları aşabilir ve en azından doğru iletişim kuran client–server uygulamalarını yazmaya başlayabilirsiniz.

Bu ekran kaydında Copilot’u tam olarak bunun için kullanacağım. Bir sunucu uygulamam var: bir web API uygulaması. Bir de Blazor istemci uygulamam var. Şu an burada, .NET framework’ün verdiği şablon kod dışında pek bir şey yok. Bu yüzden Copilot’u kullanarak işe başlayacağım ve bu iki uygulamayı birlikte çalışır hâle getireceğim.

---

## 🧱 Başlangıç: Çözüm, Client ve Server Projeleri

Bir çözümüm var; içinde istemci ve sunucu projeleri bulunuyor. Bir **Blazor API projesi** var (web API uygulaması) ve bir de WASM şablonu ile geliştirdiğim **Blazor Client** var.

Bu iki uygulamayla etkileşime geçebilmek için bir terminal açıyorum.

---

## 🛠️ Copilot ile CRUD Web API Controller Üretme

İlk adım olarak Copilot’tan bir **C# ASP.NET Core Web API controller** üretmesini isteyeceğim. Bu controller’ın uygulamam için gerekli tüm **CRUD** işlemlerini içermesini istiyorum.

CRUD şu anlama gelir:

* *Create*
* *Read*
* *Update*
* *Delete*

Blazor uygulamamızın API ile etkileşime girebilmesi için bu işlemlerin tamamının API’de olması gerekir.

Copilot’a geçiyorum ve uygulamam için henüz fazla bağlam vermeden controller’ı istemeye başlıyorum. İstediğim isim net:  **ProductController** . Controller’ın ne yapmasını istediğimi de söylüyorum.

Uygulama şu an çok basit olduğu için bu bilgi, başlamak için yeterli. Copilot, bunun C# ile yazılması gerektiğini, bir ASP.NET Core web API olduğunu ve hangi operasyonları istediğimi bildiğinden, temel kodu üretecek kadar bilgiye sahip.

---

## 📦 Copilot’un Ürettikleri: Model + Controller

Copilot’un yaptığı ilk şey, uygulamada kullanabileceğim bir model vermek: `Product`.

Sonra da bu modeli kullanan `ProductController`’ı üretiyor. Yani CRUD operasyonları için ihtiyacım olan temel kodun tamamı elimde.

Ancak şunu fark ediyorum: Bu dosyaları doğru yere koyduğumdan emin değilim. Copilot bana bir `ProductController` ve `Product` modeli verdi ama bunları projede nereye koyacağımı söylemiyor.

Bunun üzerine Copilot’a basit bir soru soruyorum: “Dosyaları nereye koymalıyım?”

Copilot bu sefer net talimatlar veriyor:

* `Models` adında bir klasör oluştur,
* `Product.cs` adında bir sınıf ekle ve modeli buraya koy,
* Controller için de `Controllers` klasörü oluştur ve `ProductController.cs` dosyasını oraya koy.

---

## 🗂️ Projede Klasörleri ve Dosyaları Oluşturma

Uygulamaya geri dönüyorum ve Blazor API projesinde `Models` ve `Controllers` klasörlerinin olup olmadığına bakıyorum. Yok.

Bu yüzden ikisini de oluşturuyorum. Klasörlerin root’a eklendiğinden emin oluyorum; çünkü VS Code, klasörü imlecin bulunduğu yere ekleyebiliyor.

Artık `Models` ve `Controllers` klasörleri hazır.

Copilot’a geri dönüyorum ve:

* `Models` içine `Product.cs` dosyasını oluşturup model kodunu yapıştırıyorum,
* `Controllers` içine `ProductController.cs` dosyasını oluşturup controller kodunu yapıştırıyorum.

Artık iki C# dosyam da var: Kullanacağımız `Product` sınıfı ve çağıracağımız `ProductController`.

Controller içinde bir `Product` listesi oluşturulduğunu görüyorsunuz; yani birden fazla ürün tutulacak.

Copilot, `Product` nesnesini doğru algıladı çünkü hepsi aynı uygulama içinde. Eğer önce `Product` sınıfını oluşturmamış olsaydık, kod hata verecekti ve modeli ayrıca eklememiz gerekecekti.

Şu anda uygulamanın başlangıç kısmı hazır: CRUD operasyonları var ve front-end tarafına geçebiliriz.

---

## 🖥️ Copilot ile Blazor Front-End Sayfası Üretme

Şimdi Blazor istemci uygulamasına geçiyorum ve `Pages` klasörünü açıyorum.

Amacım: CRUD operasyonlarını çağırabilecek bir sayfa oluşturmak.

Copilot artık uygulama hakkında biraz bağlama sahip. Bu yüzden Copilot’tan şu istekte bulunuyorum:

* WebAssembly component: `ProductList.razor`
* `HttpClient` ile API’den veri çeksin
* Ürünleri bir unordered list içinde göstersin
* Listede ürünün `Name` ve `Price` alanı görünsün

Controller’da `Name` ve `Price` var mı diye kontrol ediyorum. Var. Yani doğru alanlar elimizde.

Copilot bana `ProductList.razor` bileşen kodunu veriyor. Ayrıca bazı şeyleri değiştirmem gerektiğini de söylüyor:

* Endpoint’in server’ı gösterecek şekilde ayarlanması gerekir.
* JSON verisini deserialize etmek için `Product` sınıfı kullanılacak.
* `OnInitializedAsync` lifecycle metodu API’den ürünleri alacak.
* Program.cs içinde `HttpClient`’ın `scoped` olarak register edildiğinden emin olunması gerekir.

---

## 📄 ProductList.razor Dosyasını Eklemek

Ön yüze dönüyorum, `Pages` klasöründe `ProductList.razor` dosyasını oluşturuyorum ve Copilot’un verdiği kodu yapıştırıyorum.

Şimdi HTTP client satırını da eklemek için Copilot’un önerdiği satıra bakıyorum. Fakat `Program.cs`’e gidince görüyorum ki bu satır zaten template ile eklenmiş:

`AddScoped` ile `HttpClient` zaten register edilmiş. Yani ekstra eklemeye gerek yok.

---

## ▶️ Uygulamaları Çalıştırma ve Endpoint’i Ayarlama

Şimdi iki uygulamayı çalıştırıp birbirleriyle konuşabiliyorlar mı test edeceğiz.

Terminalde:

* bir terminali client için,
* bir terminali API için

kullanıyorum.

Önce API projesini build alıyorum; sorun yok. Sonra run ediyorum.

API’nin `http://localhost:510...` gibi bir port üzerinden çalıştığını görüyorum. Bu URL’yi kopyalıyorum, çünkü client tarafında API’nin adresini doğru vermem gerekiyor.

`ProductList.razor` dosyasına dönüp API’nin çalıştığı adresi yapıştırıyorum. Böylece client, ürün listesini `localhost:510...` üzerinden `api/product` route’undan çekecek.

Şimdi client terminaline geçip build alıyorum; warning’ler var ama şimdilik sorun değil. Sonra run ediyorum.

Uygulama çalışıyor.

Tarayıcıda client uygulamasını açıyorum. `ProductList` sayfası `productlist` route’unda olduğu için o sayfaya gidiyorum.

Sayfa açıldı ve API’den veriyi çekti:

* iki ürün listelenmiş
* API’deki `Product 1: $10` ve `Product 2: $20` değerlerini alıp Blazor sayfasında gösterdi

---

## ✅ Kapanış

Copilot kullanarak client–server uygulamasının iki parçasını da geliştirebildik. Bu örnek çok basit ve sadece bir iskelet; ama üzerine inşa etmek için güçlü bir başlangıç sağlıyor.

Copilot ile neredeyse tüm geliştirmeyi yaptık. Özellikle uygulamanın ilk mimarisini kurarken, client–server taraflarının hizalanmasını sağlamakta ve birbirleriyle konuşur hâle getirmekte Copilot çok faydalı bir araç olabilir.

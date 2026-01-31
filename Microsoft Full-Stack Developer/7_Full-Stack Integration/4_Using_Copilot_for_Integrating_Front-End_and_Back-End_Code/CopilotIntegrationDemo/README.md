## 🧠 Copilot ile Entegrasyon Kodu Üretme

Bir API ile entegre olabilen bir uygulama yazmaya başlamak biraz göz korkutucu olabilir; ancak **Microsoft Copilot** ile bu işi biraz daha kolay hâle getirebiliriz. Bu ekran kaydında temel bir **Blazor** uygulaması oluşturacağım ve ardından Copilot’u kullanarak harici bir API ile entegre olabilmem için ilk kodu yazdıracağım.

---

## 🧱 Basit Bir Blazor WASM Uygulaması Oluşturma

İlk yapacağım şey basit bir WASM uygulaması oluşturmak. `.NET new Blazor Wasm` şablonunu kullanacağım ve uygulamama **Copilot integration demo** adını vereceğim. Bu bana temel uygulamayı verecek ve sonra bunu tek bir örnekte açacağım.

Tamam, artık uygulamamız hazır.

Uygulamayla daha kolay etkileşime girebilmek için bir terminal penceresi açacağım.

---

## 🛠️ Copilot ile API Service Oluşturma

İlk olarak Copilot’a, kullanmak istediğimiz API servisinin oluşturulması için bir istek ileteceğim.

Bu uygulamada yapmak istediğim şey şu: Bir URL verebileceğim bir servis dosyam olsun; bu URL harici bir API’nin URL’si olacak ve servis sınıfı da API’den çağrıldığı veriyi geri döndürecek.

Bu çok basit bir uygulama olacak:

* Servis sınıfı isteği yapacak.
* Ön yüz (kullanıcı arayüzü) sadece URL’yi servis sınıfına geçecek.
* Servis sınıfı da istediğimiz veriyi geri döndürecek.

Copilot’u açıp önceden hazırladığım bir prompt’u yapıştıracağım. Şunu söylüyorum: Bir Blazor uygulaması oluşturdum, bir web API çağrısını entegre etmek istiyorum, **API service** adında yeni bir sınıf oluşturmak istiyorum. Bu sınıf URL’yi kabul edecek ve yanıtı onu çağıran koda geri döndürecek.

Bunun **C#** ile, temel **.NET** kütüphanelerini kullanarak yazılmasını istiyorum ve mümkünse ek kütüphane kurmak istemiyorum. Yani çok temel bir şey olmasını belirtiyorum ve uygulamada kullanabileceğim bir metodla birlikte sınıfı oluşturmasını istiyorum.

Prompt’umda ne istediğimi çok spesifik talimatlarla söylüyorum. İlk adımda ne oluşturmak istediğimi önceden düşünmem gerekti; sonra Copilot’u detaylarla yönlendirdim. Ama kodun kendisini yazmam gerekmedi. Umarım Copilot, uygulamamda kullanabileceğim bir cevap verir.

---

## ✅ Copilot’un Döndürdüğü Servis Sınıfını Projeye Eklemek

Copilot’un döndürdüğü şeye bakalım. API çağrısını yapabileceğim bir C# sınıfı veriyor. İstediğimi yapmış:

* `GetAPIResponseAsync` adında bir metodu var.
* Bir URL veriyorum.
* Sonra `HttpClient` kullanarak harici API’den veri istiyor.
* Bir `response` alıyor.
* Ve bunu çağıran fonksiyona geri döndürüyor.

Bunu kopyalayacağım ve uygulamaya geri döneceğim. Dosya adını `APIService.cs` yapacağım.

Artık sınıf dosyam var ve Copilot’un verdiği kodu içine yapıştırıyorum. Böylece sınıf hazır ve uygulamanın bir sonraki kısmına geçebilirim.

---

## 🧩 Program.cs İçine Servisi Entegre Etme

Bunu uygulamanın `Program.cs` dosyasına entegre etmem gerektiğini biliyorum. Bu yüzden bir singleton örneği oluşturacağım ve bunu `Program.cs` dosyasına ekleyeceğim.

`Program.cs` içine gidiyorum ve bir singleton ekliyorum. Küçük bir yardımcı metin vardı, o da bana destek oldu. `builder.services` ile `AddScoped` ve ardından `APIService` ekledim.

Bu, uygulama boyunca `APIService`’i kullanabilmemi sağlayacak.

---

## 🧪 Derleme ve Kontrol

Yeni kod eklediğimde, derlenip derlenmediğini ve sorun olup olmadığını kontrol etmeyi severim. Bu yüzden:

```bash
dotnet build
```

Derleme sürecinden geçiyor ve build’in başarılı olduğunu söylüyor.

Şu ana kadar bug yok; en azından derleme hatası yok. Ama kodun gerçekten çalışıp çalışmadığını uygulamada görünce anlayacağız.

---

## 🧾 Bir Razor Sayfası Oluşturma

Şimdi `APIService` sınıfım var. Bir sonraki adım, uygulamada kullanıp etkileşime girebileceğim bir Razor sayfası oluşturmak.

Tekrar Copilot’a döneceğim. Copilot zaten ne yapmak istediğimin bağlamına sahip; nasıl bir uygulama yazmak istediğimi söyledim ve o da bu sınıfı verdi.

Bu bağlamla, yeni bir prompt veriyorum: Çok basit bir Razor dosyası istiyorum; çağrı yapabileyim ve belirli bir API çağrısını geçebileyim.

Bu, test amaçlı kullanabileceğim bir API; uygulamaya sahte/dummy veri döndürecek. Çağırmak istediğim URL’yi spesifik olarak veriyorum ve bu API çağrısının sonucunu ekranda göstermesini istiyorum. Ayrıca dosya adını ve uygulamayı açtığımda kullanmak istediğim route’u da belirtiyorum.

Copilot’a bu isteği gönderiyorum ve bana bir kod dönüyor.

Kodda, `APIService` içindeki `GetAPIResponseAsync` çağrılıyor. Metodu zaten kendisi oluşturduğu için ne olduğunu biliyor. İstediğim URL’yi içeri geçiyor ve üst tarafta HTML kısmında response verisini işleyip ekranda göstermeye çalışıyor.

Ayrıca yanıtında, bu çağrı için `FetchData.razor` adında bir Razor dosyası oluşturmam gerektiğini söylüyor ve route’u da veriyor: `/fetch`.

İstediğim her şeyi yapmış gibi görünüyor. Kodu kopyalama özelliğiyle kopyalayıp uygulamaya geri dönüyorum.

---

## 📄 FetchData.razor Oluşturma ve Kodun Yapıştırılması

`Pages` klasöründe `FetchData.razor` adında yeni bir sayfa oluşturuyorum ve Copilot’un verdiği kodu yapıştırıyorum.

Artık ihtiyacım olan her şeye sahip olmalıyım; fakat bir hata görüyorum:

> Adın, onu saran tür (enclosing type) ile aynı olamaz.

Bu ne demek? `FetchData.razor` diye bir dosyam var ve içeride de `FetchData` adında bir isim var.

Bu yüzden dosya adını `FetchDataPage` olarak değiştiriyorum ve bu hatayı çözmesi gerekiyor. Copilot burada task adını sayfayla aynı yapmaması gerektiğini fark edecek kadar bağlama sahip değildi; ama bu bug’ı hızlıca düzeltebildik.

İsteseydim Copilot’a geri dönüp aldığım hatayı açıklayabilir, çözüm konusunda yardım alabilirdim.

Şimdi tekrar derliyorum ki her şey sorunsuz compile edilsin.

---

## ✅ Tekrar Derleme ve Çalıştırma

Şimdi tekrar build alıyoruz; bir warning var ama şimdilik görmezden gelebiliriz. Bunlar zamanla düzeltilebilir; ama şu an uygulama derleniyor.

Şimdi test edebiliriz. Şunu çalıştırıyorum:

```bash
dotnet run
```

Uygulama `localhost:5170` üzerinde çalışıyor. `Ctrl + click` ile açıp tarayıcıda görebilirim.

Uygulama açıldı; bu WASM template’in temel yapısı.

Şimdi `/fetch` sayfasına gitmemiz gerekiyor. Bu, Copilot’a söylediğimiz route.

`/fetch`’e gidiyorum ve her şey doğru çalışıyorsa `Fetch Data` butonuna tıkladığımda veri gelmeli—ve geldi. API çağrısından dönen kodu gösteriyor.

---

## 🔄 Çağrının Uçtan Uca Akışı

`Fetch Data` butonuna tıkladığımda uygulama, harici bir URL’yi `AppServices.cs` dosyasına gönderdi ve `GetAPIResponseAsync` metodunu çağırdı.

* URL’yi içeri verdik.
* Ardından `HttpClientGetAsync` ile internete çıkıp API yanıtını bekledi.
* Yanıtı `response body` içine aldı.
* Sonra bunu `Fetch Data` Razor sayfasına geri döndürdü.
* API’den dönünce `response data` değeri doldu.
* Bu değer dolunca da HTML bölümündeki `response data` alanında ekrana basıldı.

Bu, Copilot ve Copilot’un sağladığı kodla bir entegrasyon uygulamasına başlamanın çok basit bir yolu.

Bazen boş bir kod tabanıyla başlamak çok zor olabilir; ama Copilot bu ilk kod yazım bariyerini aşmanızı sağlar. Artık ben de bunu değiştirmeye devam edebilir ve Copilot’u kullanarak uygulamayı daha ilginç hâle getirebilirim.

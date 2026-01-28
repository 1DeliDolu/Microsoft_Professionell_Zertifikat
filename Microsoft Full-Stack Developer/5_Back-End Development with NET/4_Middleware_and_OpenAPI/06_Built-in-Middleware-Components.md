## 🧰 Built-in Middleware Components

 *Middleware* , web uygulamalarının istekleri nasıl ele aldığı ve yanıtladığının temel bir bileşenidir. Peki bir istek uygulamanıza geldiğinde, uygulamanızın içinde gerçekte neler olur hiç düşündünüz mü?

 *Middleware* ’i anlamak, her isteğin ve yanıtın uygulamanız içinde nasıl hareket ettiğini yönetmek için önemlidir; bu da uygulamanızın verimli ve güvenli çalışmasına yardımcı olur. Bu videoda ASP.NET Core’daki yaygın yerleşik ( *built-in* ) *middleware* bileşenlerini açıklayacağız.

Her  *middleware component* ’in uygulamanızdaki rolünü ve bunu adım adım kod örnekleriyle nasıl uygulayacağınızı anlayarak başlayalım.

---

## 🧩 Built-in Middleware Components Nedir?

Yerleşik  *middleware components* ,  *logging* , güvenlik kontrolleri ve hata yönetimi gibi görevleri yerine getiren hazır araçlardır.

Bu bileşenler temel işleri sizin yerinize üstlenir; böylece siz uygulamanızı geliştirmeye odaklanabilirsiniz.

---

## 🗂️ Middleware Nerede Konfigüre Edilir?

Yerleşik *middleware* bileşenlerini incelemeden önce, uygulamanız içinde nerede konumlandıklarını anlamanız gerekir. İşte burada **`Startup.cs`** dosyası devreye girer.

 **`Startup.cs`** , uygulamanızın yapılandırmasının kalbidir; istek ve yanıt akışını kontrol etmek için  *middleware components* ’leri burada kaydedersiniz.

**`Startup.cs`** dosyası, ASP.NET Core projenizin kök dizininde bulunur ve uygulamanızın  *middleware* ’lerini ve servislerini yapılandırır. Bu dosya:

* isteklerin nasıl işlendiğini,
* hangi servislerin kullanıldığını,
* uygulamanın nasıl başlatıldığını

tanımlar.

---

## 🧯 Exception Handling Middleware

İlk bileşen  **exception handling middleware** ’dir. Bu bileşen, uygulamanız çalışırken oluşan hataları algılamak ve yönetmekten sorumludur.

Kullanıcıları kafa karıştırabilecek veya hassas bilgileri açığa çıkarabilecek teknik hata mesajlarını göstermek yerine, bu *middleware* hatayı yakalar ve kullanıcıları özel bir hata sayfasına yönlendirir.

Bu, daha iyi bir kullanıcı deneyimi sağlarken, hatayı geliştiricilerin inceleyip düzeltmesi için *logging* etmeye devam eder.

Exception handling eklemek için **`app.UseExceptionHandler`** metodunu kullanın.

```csharp
app.UseExceptionHandler("/Error");
```

Bu metot tek bir parametre alır: hata sayfasının yolu. Bir hata oluştuğunda kullanıcıları bu sayfaya yönlendirecek şekilde exception handling middleware’ini yapılandırır.

Bu, kullanıcıların hassas teknik ayrıntıları görmesini engeller ve bunun yerine kullanıcı dostu bir hata mesajı sunar.

**`UseExceptionHandler`** metodu, üretim ortamları ( *production environments* ) için önerilir; çünkü hassas bilgileri ifşa etmeden hataları zarif biçimde yönetir.

Buna karşılık, geliştirme aşamasında ( *development phase* ) ayrıntılı hata bilgilerini (örneğin *stack traces* ve hata mesajları) göstermek için **`app.UseDeveloperExceptionPage`** kullanın; bu, *debugging* sürecine yardımcı olur.

Mevcut ortam, **`env.IsDevelopment`** kullanılarak kontrol edilir; böylece yalnızca geliştirme ortamında ayrıntılı hata gösterimi koşullu olarak etkinleştirilir.

```csharp
if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
}
```

---

## 🔐 Authentication Middleware

İkinci bileşen  **authentication middleware** ’dir. Bu bileşen, kullanıcıların kimliğini doğrulamaktan sorumludur; böylece kullanıcı profilleri veya hesap ayarları gibi uygulamanızın belirli alanlarına erişmeden önce kullanıcı doğrulanır.

 *Authentication* ’ı etkinleştirmek için **`Startup.cs`** içinde şu satırı ekleyin:

```csharp
app.UseAuthentication();
```

Bu, authentication middleware’ini uygulamanızın request pipeline’ına ekler; böylece kullanıcı güvenli bir bölüme erişmeye çalıştığında oturum açıp açmadığı doğrulanır.

---

## 🛡️ Authorization Middleware

Üçüncü bileşen  **authorization middleware** ’dir. Bu bileşen, oturum açmış kullanıcıların hangi eylemleri gerçekleştirebileceğini ve uygulamanın hangi bölümlerine erişebileceğini kontrol eder.

Authorization middleware eklemek için şu satırı ekleyin:

```csharp
app.UseAuthorization();
```

Bu, kullanıcılar doğrulandıktan sonra ( *authenticated* ) yetkilerini ( *permissions* ) kontrol eder ve yalnızca yetkili oldukları bölümlere erişmelerini sağlar.

---

## 🧾 Logging Middleware

Son bileşen  **logging middleware** ’dir. Bu bileşen, uygulamanızdaki önemli olayları ve hataları kaydeder ve uygulamanızın davranışı hakkında değerli içgörüler sağlar.

Aşağıdaki gibi bilgileri yakalar:

* istek bilgileri ( *request information* )
* kullanıcı aktiviteleri ( *user activities* )
* sistem sorunları ( *system issues* )

Bunlar  *debugging* , *troubleshooting* ve performans izleme ( *performance monitoring* ) için kritiktir.

Logging middleware’i eklemek için şu satırı ekleyin:

```csharp
app.UseHttpLogging();
```

Bazı *middleware* bileşenleri ek kurulum gerektirir ve bu da onlardan biridir. Logging’i etkinleştirmek için ayrıca builder üzerinde HTTP logging servislerini de eklemeniz gerekir:

```csharp
builder.Services.AddHttpLogging(options => { });
```

Bu metot tek bir parametre alır. Bu örnekte, varsayılan yapılandırmayı kullanmak için boş bir inline function geçtik.

Ayrıca **`appsettings.json`** dosyanızı şu satırı ekleyerek güncellemeniz gerekir:

```json
"Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware": "Information"
```

Artık API sunucunuza her HTTP request yapıldığında console’da log’ları göreceksiniz.

---

## ✅ Özet

Bu videoda ASP.NET Core’daki yaygın yerleşik *middleware* bileşenlerini öğrendiniz. Buna şunlar dahildir:

* **exception handling** : kullanıcıları kullanıcı dostu bir hata sayfasına yönlendirir
* **authentication** : kullanıcı kimliğini doğrular
* **authorization** : kullanıcıların neye erişebileceğini kontrol eder
* **logging middleware** : izleme ve hata ayıklama için istekleri takip eder

Bu bileşenler birlikte çalışarak güvenli ve güvenilir bir web uygulaması oluşturur.

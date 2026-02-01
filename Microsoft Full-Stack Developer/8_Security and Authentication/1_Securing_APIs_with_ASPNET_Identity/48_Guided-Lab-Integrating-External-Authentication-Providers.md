## 🧩 Arka Plan Bilgisi

Google hesaplarıyla giriş yapmalarına izin veren bir web uygulaması geliştiriyorsunuz. Bu, istemci kimlik bilgilerini ayarlamayı, API erişim kapsamlarını tanımlamayı ve kimlik doğrulama sürecini başlatmak için bir uç nokta (endpoint) oluşturmayı gerektirir.

---

## 🧱 Arka Plan Bilgisi

Başlamak için uygulamayı HTTP isteklerini işleyecek şekilde yapılandırmanız gerekir. Gerekli servisleri kaydederek, kimlik doğrulama ve yönlendirme gibi özellikler eklemek için temel yapıyı oluşturursunuz.

---

## 🔐 Arka Plan Bilgisi

Şimdi, uygulamayı Google’ın kimlik doğrulama sistemiyle güvenli şekilde iletişim kurabilmesi için ihtiyaç duyduğu kimlik bilgileriyle yapılandıracaksınız. Bunlar şunları içerir:

* **ClientId ve ClientSecret:** Bu değerler Google Cloud Console kurulumu sırasında üretilir ve uygulamanızı benzersiz şekilde tanımlar.
* **userinfo.profile Scope:** Bu kapsam (scope), uygulamanın kullanıcı profil verilerine erişmesine izin verir.
* **Data Storage Path:** Kullanıcı kimlik bilgileri için geçici depolama, kimlik doğrulama süreci boyunca güvenli işleme sağlamak amacıyla **ApplicationData** klasöründe yapılandırılır.

---

## 💻 Kod

```csharp
var clientSecrets = new ClientSecrets
{
    ClientId = builder.Configuration["Authentication:Google:ClientId"],
    ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"]
};

var scopes = new[] { "https://www.googleapis.com/auth/userinfo.profile" };

var dataStorePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
    "DesktopAuth"
);

var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
    clientSecrets,
    scopes,
    "user",
    CancellationToken.None,
    new FileDataStore(dataStorePath)
);
```

---

## 🚪 Arka Plan Bilgisi

Son olarak, Google kimlik doğrulama sürecini başlatmak için bir endpoint oluşturacaksınız. Bu endpoint, kullanıcıların kimlik doğrulama için Google’a yönlendirilerek giriş akışını başlatmasını sağlar. Süreç tamamlandıktan sonra endpoint, başarılı giriş yapıldığını belirten bir onay mesajı gönderir.

---

## 🔗 Endpoint Kodu

```csharp
app.MapGet("/login", async context =>
{
    await context.Response.WriteAsync("Authentication");
});
```

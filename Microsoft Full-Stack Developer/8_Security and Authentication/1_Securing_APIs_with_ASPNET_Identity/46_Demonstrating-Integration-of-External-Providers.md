## 🌐 Harici Sağlayıcı Entegrasyonunu Gösterme

Bu noktaya kadar uygulamalarımızda kimlik doğrulama ve yetkilendirmeyi yönetmek için Identity kullandık. Peki ya bir üçüncü tarafı, örneğin **Microsoft** veya  **Google** ’ı kullanmak istersek; böylece bir kişi mevcut hesabını kullanarak kimlik doğrulaması yapabilsin ve bu servisler uygulamamıza “bu kullanıcı giriş yaptı, onu uygulamana al” diyebilsin? .NET kullanarak bunu kesinlikle yapabiliriz. Bu videoda, harici kimlik doğrulama sağlayıcılarının **OAuth 2.0** kullanılarak bir ASP.NET uygulamasına nasıl entegre edildiğini açıklayacağım.

Bu videoda **Google** entegrasyon sürecini adım adım inceleyeceğiz. Google, web genelindeki uygulamalar için en yaygın harici giriş sağlayıcılarından biridir.

---

## 🧩 Basit Uygulama Başlangıcı

Burada gerçekten basit bir uygulama ile başlıyoruz. Root route var ve aşağıda güvence altına almak istediğimiz bir route var. Başka bir şey yok.

Dikkat edin: burada Identity’yi uygulamayacağız, bu yüzden:

* veritabanına ihtiyacımız yok,
* identity servislerine ihtiyacımız yok,
* identity API endpoint’lerine ihtiyacımız yok,

ama kimlik doğrulama ve yetkilendirmeye ihtiyacımız var.

Bu yüzden `app`’in üstünde:

* `builder.services.addAuthorization`
* ve ondan önce `addAuthentication`

ekleyeceğiz.

---

## 🔐 Authentication ve Authorization Eklemek

Şimdi authentication ve authorization var, ancak bunları Google kullanacak şekilde değiştirmemiz gerekiyor.

İlk yaptığım şey, authentication içine girip bir fonksiyon geçmek; bu fonksiyon options alacak ve birkaç yeni option ayarlayacağım.

* `options.defaultScheme` değerini ayarlayacağım; bunu `CookieAuthenticationDefaults.AuthenticationScheme` yapacağız.
* sonra `options.defaultChallengeScheme` ayarlayacağız; burada Google’ı kuracağız: `GoogleDefaults.AuthenticationScheme`.

Bu `GoogleDefaults` değerleri otomatik gelmiyor; bu yüzden paketi eklememiz gerekiyor.

---

## 📦 Google Authentication Paketini Kurmak

Paket eklemek için:

```bash
dotnet add package Microsoft.AspNetCore.Authentication.Google
```

Paket düzgün kurulduktan sonra, eksik `using` ifadelerini *quick fix* ile ekleyebiliriz.

Şimdi bu kısım çalışır hâle gelir.

---

## 🍪 Cookie Auth + Google Auth Eklemek

Varsayılan scheme cookie olduğu için cookie auth eklememiz gerekir. Çünkü burada harici bir sağlayıcıyı default provider olarak kullanamayız.

Bu yüzden:

* cookie auth ekleriz
* ardından Google’ı ekleriz

Google’ı eklediğimiz yer “asıl sihrin” olduğu yer.

Google ayarlarını eklemek için yine options alan bir yapılandırma ekleyeceğiz.

Burada Google hesabınızdan alınacak bazı özel bilgilere ihtiyacımız var:

* `options.clientId`
* `options.clientSecret`

Şimdilik boş string koyuyoruz.

Bu değerler çok gizli tutulmalıdır. Eğer açığa çıkarırsanız, birisi uygulamanızı suistimal edip sizinmiş gibi davranabilir. Bu yüzden çok ama çok gizli tutulmaları gerekir.

Bunu yönetmenin birçok yolu var: environment variables, user secrets vb. Bu demo için appsettings içine koyacağız.

Ayrıca bu dosyayı version control’da ignore edebilirsiniz; böylece hiçbir zaman repoya commit edilmez ve kod ile secret’lar aynı yerde bulunmaz.

---

## ⚙️ appsettings.json İçinde Google Ayarları

Şimdi secret’ları appsettings içinde bir bölüm altında tutacağız.

Bunu örneğin `authorization` altında, `Google` altında tutacağız:

* `clientId`
* `clientSecret`

Şimdilik değerleri paste edeceğim çünkü bunları Google console’da zaten oluşturdum. Daha sonra bunların nasıl alınacağını da göstereceğiz.

Sonra bu değerleri uygulamaya şu şekilde bağlarız:

* `builder.configuration["authorization:Google:clientId"]`
* `builder.configuration["authorization:Google:clientSecret"]`

Burada squiggly’ler görünebilir; çünkü bu değerler yoksa hata verebilir. En iyi uygulama, eksikse hata fırlatmak olur; ama şimdilik bunu yapmayacağız.

---

## 🧪 Uygulamayı Çalıştırma ve Test

Uygulamayı çalıştırıyoruz.

Bir hata alırsak, genelde appsettings içinde typo vardır. Bu örnekte:

* `appsettings` yazımı yanlış
* ya da key path’inde yanlışlık (ör. ekstra karakter)

Düzeltip yeniden başlatıyoruz.

Şimdi root route’a sorun yok; authentication gerekmiyor.

Ama `secure` route’una gittiğimizde authentication gerekiyor.

Bu route’a gittiğimizde bizi Google sign-in sayfasına yönlendiriyor.

Google ile giriş yaptıktan sonra secure route’a erişebiliyoruz.

Bu, .NET’te Google gibi harici bir kimlik doğrulama servisini kullanarak uygulamaya giriş yapmanın yoludur.

---

## 🧾 Google Client ID ve Client Secret Alma Süreci

Şimdi clientId ve clientSecret değerlerini nasıl alacağımızı inceleyelim.

Bu değerleri oluşturmak için:

* `console.cloud.google.com/apis` adresine gidilir.
* **Credentials** bölümüne tıklanır ve yeni credential’lar oluşturulur.
* OAuth 2.0 client IDs altında credential’lar görünür.

Yeni credential oluşturmak için:

* önce consent screen’i yapılandırmanız gerekir.
* “external” olarak kullanacağınız için bunu seçip create yaparsınız.
* uygulamaya isim verirsiniz (örn. `MyTestApp`)
* support email girersiniz
* sonra save and continue
* default scopes bırakılır
* testing user eklenir
* consent screen tamamlanır

Sonra tekrar credentials ekranına dönülür:

* Create Credentials → OAuth Client ID
* Application type: Web application

Burada iki şey ekleyebilirsiniz:

* JavaScript origins
* Redirect URIs

Bu uygulamada browser’dan request yapmıyoruz; backend üzerinden yapıyoruz. Bu yüzden Redirect URIs kullanacağız.

Redirect URI’lar, uygulamanın request yaptığı adres olmalıdır.

İki redirect URI ekleyeceğiz; HTTP ve HTTPS için.

Redirect path genellikle sağlayıcıya göre değişir.

Google için .NET’in varsayılan path’i:

* `/signin-google`

Bu path uygulamada değiştirilebilir ama .NET’in default’u budur.

Örnek olarak:

* `http://localhost:xxxx/signin-google`
* `https://localhost:xxxx/signin-google`

Sonra create dediğimizde:

* client ID
* client secret

üretilir.

Bu değerleri uygulamaya geri dönüp `clientId` ve `clientSecret` alanlarına yerleştiririz ve artık yeni credential’larınızla çalışır.

---

## ✅ Kapanış

Ve böylece OAuth 2.0 kullanarak ASP.NET’te bir harici kimlik doğrulama sağlayıcısı entegre etmiş olduk. Artık kullanıcıların Google ile .NET uygulamanıza giriş yapmasına izin verebilirsiniz.

## 🔐 ASP.NET Core’ta JWT Kimlik Doğrulamasını Uygulamak için Adım Adım Rehber

## 🧭 Giriş

Bu rehber, *ASP.NET Core* uygulamasında JWT kimlik doğrulamasını yapılandırmak için pratik adımlar sunar. Uygulama güvenliğini artırmak amacıyla middleware kurulumu, token üretimi ve API uç noktalarının güvence altına alınmasını içerir.

---

## ✅ Adım 1: Projeyi Yapılandırma

Proje yapısını kurun:

* Klasörleri oluşturun: Veritabanı mantığı için `Data`, veri yapıları için `Models`.

Hassas verileri güvenceye alın:

* `Jwt__Key`, `Jwt__Issuer` ve `Jwt__Audience` gibi anahtarları saklamak için bir `.env` dosyası oluşturun.
* Dosyanın sürüm kontrolüne dahil edilmediğinden emin olun (ör. `.gitignore` içine ekleyin).

---

## ✅ Adım 2: Middleware’i Yapılandırma

Veritabanı Context’i:

* SQL Server veritabanıyla etkileşime girmek için `Data` klasöründe `AppDbContext` tanımlayın.

Kimlik Doğrulama Middleware’i:

* Uygulamanın Bearer token’ları tanıması için `AddAuthentication("Bearer")` ekleyin.
* Token’ları doğrulamak için `AddJwtBearer` kullanın ve şunları belirtin:
  * `.env` dosyasından Issuer ve Audience
  * `Jwt__Key` üzerinden üretilen simetrik güvenlik anahtarıyla signing credentials

---

## ✅ Adım 3: API Uç Noktalarını Oluşturma

Kayıt Uç Noktası (`/register`):

* E-posta benzersizliğini doğrulayın.
* Parolaları *SHA256* kullanarak hash’leyin ve kullanıcı verisini veritabanına kaydedin.
* `201 Created` yanıtı döndürün.

Giriş Uç Noktası (`/login`):

* Kullanıcı kimlik bilgilerini doğrulayın.
* Kullanıcıya özel claim’ler (ör. e-posta, rol) içeren bir JWT üretin.
* Bir sona erme süresi belirleyin (ör. 1 saat).
* Token’ı `200 OK` yanıtında döndürün.

---

## ✅ Adım 4: API Route’larını Güvenceye Alma

Authorization Policy’leri ekleyin:

* *Student* ve *Instructor* gibi roller için policy’ler tanımlayın.

Middleware’i uygulayın:

* Middleware hattında `app.UseAuthentication()` ve `app.UseAuthorization()` kullanın.

Endpoint’leri kısıtlayın:

* Rol tabanlı erişimi zorunlu kılmak için endpoint’lerde `RequireAuthorization` kullanın (ör. `StudentPolicy` veya `InstructorPolicy`).

---

## ✅ Adım 5: Endpoint’leri Test Etme

Postman veya benzeri bir araç kullanın:

* Geçerli JSON payload’larla `/register` ve `/login` endpoint’lerini test edin.
* `Authorization` header’ında geçerli bir JWT ile korunan route’ları test edin.

Yanıtları doğrulayın:

* Doğru yanıtları aldığınızdan emin olun (ör. başarı için `200 OK`, geçersiz token için `401 Unauthorized`).

---

## 🧾 Sonuç

Bu kurulum, JWT kimlik doğrulaması ve rol tabanlı erişim denetiminden yararlanarak *ASP.NET Core* API’leriniz için sağlam bir güvenlik sağlar. Token sona erme politikaları ve hassas anahtarların güvenli saklanması dahil olmak üzere güvenlik uygulamalarını düzenli olarak gözden geçirin.

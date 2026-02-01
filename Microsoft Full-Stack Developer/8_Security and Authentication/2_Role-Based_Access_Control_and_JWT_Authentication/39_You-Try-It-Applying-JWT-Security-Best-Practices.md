## 🧪 You Try It! JWT Güvenlik En İyi Uygulamalarını Uygulama

### 🎯 Amaç

JWT kimlik doğrulaması için güvenlik en iyi uygulamalarını uygulayın: basit bir *ASP.NET Core* uygulaması oluşturacak, kullanıcıları güvenli şekilde doğrulayacak ve rolleri in-memory depolama ile yöneteceksiniz. Token expiration, refresh token ve doğru imzalama pratiklerini uygulayacaksınız.

---

## 🧱 Adım 1: Uygulama için Hazırlık

JWT authentication’ı güvenli şekilde gösteren küçük bir *ASP.NET Core Web API* uygulaması oluşturacaksınız. Bu; user login, token üretimi ve rol tabanlı erişim kontrolünü içerecek.

### 📝 Talimatlar

1. *Visual Studio Code* ’u açın.
2. Yeni bir ASP.NET Core Web API uygulaması oluşturun:

```bash
dotnet new webapi -n JwtAuthExample
```

3. Proje klasörüne gidin:

```bash
cd JwtAuthExample
```

4. JWT authentication için gerekli NuGet paketlerini ekleyin:

```bash
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.1
dotnet add package Microsoft.IdentityModel.Tokens --version 7.2.0
dotnet add package System.Text.Json
```

5. **Program.cs** dosyasını açın ve mevcut kodu kaldırın. Sonraki adımlarda JWT fonksiyonelliğini ekleyeceksiniz.

---

## ⚙️ Adım 2: JWT Authentication’ı Yapılandırma

Uygulamada JWT authentication’ı kurun.

### 📝 Talimatlar

**Program.cs** içinde JWT authentication ekleyin:

* İmzalama anahtarını ( *signing key* ) ve token validation parameters’ı tanımlayın.
* Authentication middleware’i yapılandırın.
* **appsettings.json** içinde secret konfigürasyonunun environment variables üzerinden alındığından emin olun.

### ✅ Checklist

* Signing key ekle
* Token expiration yapılandır
* Token validation parameters ekle

---

## 🔑 Adım 3: Kullanıcı Authentication’ını Uygulama

Login ve token üretimini yönetecek temel bir controller oluşturun.

### 📝 Talimatlar

1. **Controllers** klasörü oluşturun ve **AuthController.cs** dosyasını ekleyin.
2. Username ve password alan bir **Login** endpoint’i tanımlayın.
3. Kullanıcıyı hardcoded in-memory kullanıcı listesine göre doğrulayın.
4. Login başarılı olursa JWT üretin.

### ✅ Checklist

* Kullanıcı kimlik bilgilerini doğrula
* JWT üret ve aşağıdakileri claim olarak ekle:
  * User ID
  * Role
  * Expiration date
* JWT’yi güvenli bir key ile imzala

---

## 🔁 Adım 4: Refresh Token Fonksiyonelliği Ekleme

Refresh token ile güvenliği artırın.

### 📝 Talimatlar

* Refresh token’ları basit bir in-memory dictionary’de saklayın.
* AuthController’da token yenileme endpoint’i oluşturun.
* Refresh token geçerliyse ve süresi dolmamışsa yeni bir access token verin.

### ✅ Checklist

* Access token ile birlikte refresh token üret
* Yeni access token vermeden önce refresh token’ı doğrula
* Token’ları HTTP-only cookie kullanarak güvenli şekilde sakla

---

## 🛡️ Adım 5: API Endpoint’lerini Korumak

Role-based access control ile API endpoint’lerini güvenceye alın.

### 📝 Talimatlar

1. **Controllers/SecureController.cs** dosyasını oluşturun.
2. Endpoint’leri `[Authorize]` ve role/policy bazlı erişim ile koruyun.
3. Farklı rollerin token’larıyla farklı senaryoları test edin.

### ✅ Checklist

* `[Authorize]` ile endpoint’leri koru
* Role-based authorization uygula
* Kullanıcıların yalnızca yetkili kaynaklara erişebildiğini doğrula

---

## 🧪 Adım 6: Uygulamayı Test Etme ve Debug Etme

Her şeyin beklenen gibi çalıştığından emin olun.

### 📝 Talimatlar

Uygulamayı çalıştırın:

```bash
dotnet run
```

Postman gibi bir araç kullanarak:

* Login ile JWT almayı test edin.
* JWT ile secure endpoint’lere erişin.
* Refresh token ile access token yenilemeyi test edin.
* Sorunları debug edin ve güvenli pratiklerin doğru uygulandığından emin olun.

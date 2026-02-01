## 🧪 You Try It! ASP.NET’te JWT Kimlik Doğrulamasını Uygulama

### 🎯 Amaç

Bu etkinliğin sonunda, Visual Studio Code kullanarak bir *ASP.NET Core* uygulamasında JWT kimlik doğrulamasını uygulayabileceksiniz. Bellek içi ( *in-memory* ) bir kullanıcı deposu oluşturacak, kimlik doğrulama middleware’ini yapılandıracak ve API uç noktalarını yerelde güvence altına alacaksınız.

---

## 🧰 Adım 1: Uygulama için Hazırlık

JWT kullanarak kullanıcı kimlik doğrulamasını yönetmek için küçük bir *ASP.NET Core Web API* uygulaması oluşturacaksınız. Uygulamayı kurarak başlayın.

1. Visual Studio Code’u açın ve yeni bir proje kurun.
   ```bash
   dotnet new webapi -n JwtAuthDemo
   cd JwtAuthDemo
   ```
2. Gerekli NuGet paketlerini yükleyin:
   ```bash
   dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
   dotnet add package System.IdentityModel.Tokens.Jwt
   ```
3. Yeni bir `Controllers/UserController.cs` dosyası oluşturun.

---

## ⚙️ Adım 2: Startup’ta JWT Kimlik Doğrulamasını Yapılandırma

Bu adımda, **Program.cs** dosyasını değiştirerek uygulamayı JWT kimlik doğrulaması kullanacak şekilde yapılandıracaksınız.

1. `appsettings.json` dosyanıza `JwtSettings` yapılandırmasını ekleyin. Secret key, issuer, audience ve expiration time değerlerini tanımlayın.
2. `Program.cs` içinde:
   * Servis konteynerında `JwtBearer` kimlik doğrulamasını kaydedin.
   * Secret key’i kullanarak JWT token’larını doğrulamak için authentication middleware’ini yapılandırın.
   * Uygulamanın authentication ve authorization middleware’ini kullandığından emin olun.

---

## 🧱 Adım 3: User Modelini ve Token Üretimini Uygulama

Şimdi, token üretimini yönetmek için bir `User` modeli ve bir `TokenService` oluşturacaksınız.

**Talimatlar:**

1. `Models` adlı yeni bir klasör oluşturun ve `User.cs` dosyasını ekleyin:
   * `Username` ve `Password` alanlarını string özellikler olarak tanımlayın.
2. `Services` adlı yeni bir klasör oluşturun ve `TokenService.cs` dosyasını ekleyin:
   * Yapılandırmadan `JwtSettings` değerlerini okuyun.
   * Bir JWT oluşturmak ve imzalamak için `System.IdentityModel.Tokens.Jwt` namespace’ini kullanın.
   * İmzalı bir JWT döndürmek için `GenerateToken(string username)` metodunu uygulayın.

---

## 🗃️ Adım 4: Bellek İçi Kullanıcı Deposu Oluşturma

Giriş isteklerini doğrulamak için `UserController` içinde hardcoded bir kullanıcı listesi kullanın.

1. `UserController` içinde `User` nesnelerinden oluşan statik bir liste oluşturun.
2. Bir `POST /login` endpoint’i uygulayın:
   * Sağlanan `Username` ve `Password` değerlerini kullanıcı deposuna karşı doğrulayın.
   * Geçerliyse, bir JWT üretmek ve döndürmek için `TokenService` kullanın.
   * Geçersizse, bir HTTP 401 Unauthorized yanıtı döndürün.

---

## 🛡️ Adım 5: API Route’larını Güvenceye Alma

Yalnızca kimliği doğrulanmış kullanıcıların erişebilmesini sağlamak için API route’larınıza authorization ekleyin.

1. `UserController` içinde kimlik doğrulama gerektiren bir `GET /secure-data` endpoint’i ekleyin:
   * Route’u korumak için `[Authorize]` attribute’ünü kullanın.
   * Kullanıcının güvenli bir endpoint’e eriştiğini belirten basit bir mesaj döndürün.
2. Postman veya curl gibi araçlarla API’yi test edin:
   * Token’ın `Authorization` header’ında Bearer şemasıyla dahil edildiğinden emin olun.
   * Yetkisiz isteklerin 401 yanıtı aldığını doğrulayın.

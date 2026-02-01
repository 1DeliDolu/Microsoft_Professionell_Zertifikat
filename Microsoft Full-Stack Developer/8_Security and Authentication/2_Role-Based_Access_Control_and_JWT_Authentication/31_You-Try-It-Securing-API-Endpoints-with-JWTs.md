## 🧪 You Try It! JWT’lerle API Uç Noktalarını Güvenceye Alma

### 🎯 Amaç

Bu etkinliğin sonunda, katılımcılar *JWT authentication* kullanarak API endpoint’lerini güvenceye alacak, *role-based access control* uygulayacak ve yalnızca yetkili kullanıcıların endpoint’lere erişebilmesini sağlayacaktır.

---

## 🧩 Adım 1: Uygulama için Hazırlık

*Visual Studio Code* kullanarak küçük bir *ASP.NET Core Web API* oluşturacaksınız. Bu uygulama, *authentication* ve *authorization* için JWT’leri, rol tabanlı erişim kontrolüyle birlikte kullanacaktır.

### 📝 Talimatlar

1. *Visual Studio Code* ’u açın ve projeniz için yeni bir klasör oluşturun.
2. VS Code’da terminali açın ve projeyi oluşturup kurmak için aşağıdaki komutları çalıştırın:

```bash
dotnet new webapi -o SecureApiWithJwt
cd SecureApiWithJwt
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.1
dotnet add package System.IdentityModel.Tokens.Jwt --version 7.2.0
dotnet add package Microsoft.IdentityModel.Tokens --version 7.2.0
```

3. Projeyi temizlemek için varsayılan **WeatherForecast** ve ilgili dosyaları kaldırın.
4. Yapılandırma için **Program.cs** dosyasını ve **appsettings.json** dosyasını açın.

---

## ⚙️ Adım 2: JWT Authentication için Yapılandırma Ekleme

1. JWT ile ilgili ayarları saklamak için **appsettings.json** dosyasına bir **JwtSettings** bölümü ekleyin:

```json
{
  "JwtSettings": {
    "Key": "SuperSecretKeyForJwtTokenAuthorization123456789",
    "Issuer": "SecureApi",
    "Audience": "SecureApiUsers",
    "DurationInMinutes": 60
  }
}
```

2. **Program.cs** içinde JWT authentication’ı yapılandırın:

* Token’ı doğrulamak ve roles claim’ini eşlemek için **TokenValidationParameters** kurulumunu yapın.

---

## 🧱 Adım 3: Token Üretimini Uygulama

1. JWT oluşturmayı yönetmek için bir **TokenService** sınıfı oluşturun.

* Bu sınıf, **appsettings.json** içindeki ayarları kullanarak JWT token oluşturmayı yönetecektir.

2. Token oluştururken username ve roles için claim’ler ekleyin.

---

## 🔑 Adım 4: Login Endpoint’i Ekleme

1. **Controllers** klasöründe **AuthController** adlı yeni bir controller oluşturun.
2. Geçerli kullanıcı kimlik bilgileri için bir JWT token üreten ve döndüren bir **POST** endpoint’i uygulayın.

---

## 🛡️ Adım 5: API Endpoint’lerini Güvenceye Alma

1. **Controllers** klasöründe bir API endpoint’ini güvenceye alın:

* **GET** istekleri için endpoint’leri olan bir **ValuesController** oluşturun.
* Roller kullanarak (örn. `"Admin"` veya `"User"`) bu endpoint’lere erişimi kısıtlayın.

2. Endpoint’leri korumak için **[Authorize]** attribute’larını kullanın.

---

## 🧪 Adım 6: Uygulamayı Test Etme

1. *Postman* kullanarak:

* **/auth/login** endpoint’ine bir **POST** isteği göndererek bir token üretin.
* Rol tabanlı kısıtlamaların doğru çalıştığından emin olmak için token’ı kullanarak güvenli endpoint’lere erişin.

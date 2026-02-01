## 🧪 Rehberli Laboratuvar: JWT Oluşturma ve Çözümleme

## ℹ️ Arka Plan Bilgisi

Bir istemci ile bir sunucu arasında JWT’lerin bilgiyi nasıl güvenli bir şekilde iletebileceğini göstermek için bir *ASP.NET Core* uygulaması geliştiriyorsunuz. Laboratuvar; token tabanlı kimlik doğrulama için en iyi uygulamaları incelerken JWT’leri oluşturma, çözümleme ve doğrulama üzerine odaklanır.

---

## ℹ️ Arka Plan Bilgisi

**JwtDemo** adında yeni bir .NET Console uygulaması oluşturun. Bu uygulama, JWT’leri üretmek ve çözümlemek için temel oluşturacaktır.

```bash
dotnet new console -n JwtDemo
```

---

## 🧩 Adım 2: Bir JWT Oluşturma

## ℹ️ Arka Plan Bilgisi

JWT üretimini yönetmek için **JwtCreator** adında bir sınıf oluşturun. Bu sınıf, kullanıcı adı ve rol için claim’ler içeren bir JWT üretmek üzere bir metod içerir. İmzalama süreci güvenlik için **"HS256"** algoritmasını kullanır ve token, hassas işlemler için kısa ömürlü erişimi sağlamak amacıyla 5 dakika içinde sona erecek şekilde ayarlanır. Token’ı imzalamak için kullanılan anahtarı güvenli şekilde saklamak üzere **SecretKey** adında bir sabit kullanılır.

---

İmlecinizi **JwtCreator.cs** dosyasında **20. satıra** yerleştirin. Benzersiz tanımlayıcı claim türünü temsil eden *JwtRegisteredClaimNames* içindeki tek alanı girin. Ardından ilerlemek için  **Enter** ’ı seçin.

```csharp
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JwtCreator
{
    private const string SecretKey = "MySuperSecretKeyForJwtLearningDemo";

    public string CreateJwt(string username)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
        var credentials = new SigningCredentials(key, "HS256");

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim("role", "admin"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: "JwtDemoApp",
            audience: "JwtDemoApp",
            claims: claims,
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
```

---

## ℹ️ Arka Plan Bilgisi

JWT’leri *JwtSecurityTokenHandler* sınıfını kullanarak çözümleyin ve doğrulayın. Bu handler, JWT’leri okumak ve işlemek için metodlar sağlar. Token’ı okunabilir bir nesneye çözümlemek için *ReadJwtToken* metodunu ve kolay inceleme için claim’leri anahtar-değer formatına dönüştürmek amacıyla  *ToDictionarymethod* ’unu kullanacaksınız.

```csharp
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JwtDecoder
{
    private const string SecretKey = "MySuperSecretKeyForJwtLearningDemo";

    public void DecodeJwt(string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "JwtDemoApp",
            ValidAudience = "JwtDemoApp"
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey))
        };

        var jwtToken = handler.ReadJwtToken(token);
        var claims = jwtToken.Claims.ToDictionary(c => c.Type, c => (object)c.Value);

        foreach(var claim in claims)
        {
```

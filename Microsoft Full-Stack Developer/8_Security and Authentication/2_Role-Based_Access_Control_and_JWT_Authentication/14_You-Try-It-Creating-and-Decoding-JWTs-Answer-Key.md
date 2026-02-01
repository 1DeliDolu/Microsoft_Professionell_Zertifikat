## 🎯 Amaç

Bir *ASP.NET Core* uygulamasında JWT’leri oluşturmayı ve çözümlemeyi öğreneceksiniz. Bu laboratuvar, JWT işlevselliğini daha kolay anlaşılması için ayrı sınıflara bölerek modülerleştirmeye odaklanır.

---

## ✅ You Try It! Creating and Decoding JWTs – Cevap Anahtarı

## 🧩 `Program.cs`

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        JwtCreator creator = new JwtCreator();
        string token = creator.CreateJwt();
        Console.WriteLine($"Generated Token:\n{token}\n");

        JwtDecoder decoder = new JwtDecoder();
        decoder.DecodeJwt(token);
    }
}
```

---

## 🔐 `JwtCreator.cs`

```csharp
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JwtCreator
{
    private const string SecretKey = "MySuperSecretKeyForThisDemoApp123456789"; // Key should be stored securely

    public string CreateJwt()
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, "user123"),
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

        var tokenHandler = new JwtSecurityTokenHandler();
        return tokenHandler.WriteToken(token);
    }
}
```

---

## 🔎 `JwtDecoder.cs`

```csharp
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JwtDecoder
{
    private const string SecretKey = "MySuperSecretKeyForThisDemoApp123456789"; // Key should be stored securely

    public void DecodeJwt(string token)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
        var tokenHandler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "JwtDemoApp",
            ValidAudience = "JwtDemoApp",
            IssuerSigningKey = securityKey
        };

        try
        {
            var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
            Console.WriteLine("Decoded Claims:");
            foreach (var claim in principal.Claims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Token validation failed: {ex.Message}");
        }
    }
}
```

---

## 🖥️ Beklenen Çıktı

Uygulamayı çalıştırdığınızda şunlar görüntülenmelidir:

* Üretilen JWT token
* Çözümlenen claim’ler, örneğin:

```text
Generated Token:
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...

Decoded Claims:
http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier: user123
http://schemas.microsoft.com/ws/2008/06/identity/claims/role: admin
jti: f6a471da-2b42-43bb-9644-a8411845a044
exp: 1736547158
iss: JwtDemoApp
aud: JwtDemoApp
```

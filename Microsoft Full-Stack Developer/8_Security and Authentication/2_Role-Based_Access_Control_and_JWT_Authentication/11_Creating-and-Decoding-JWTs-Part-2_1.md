
## 🎯 Öğrenme Hedefi

Bu videonun sonunda şunları yapabiliyor olacaksınız:

* *ASP.NET Core* uygulamasında  *JSON Web Token* ’ları ( *JWT* ) oluşturmayı ve kodlamayı öğrenmek

---

## 🧰 Adım 2: JWT Oluşturucularını Ayarlayın

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
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
        var credentials = new SigningCredentials(key, "HS256");

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, "user123"),
            new Claim("role", "admin"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
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

## 🔑 Adım 3: Giriş Uç Noktasını Oluşturun

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
        var handler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "JwtDemoApp",
            ValidAudience = "JwtDemoApp",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey)),
        };

        var jwtToken = handler.ReadJwtToken(token);
        var claims = jwtToken.Claims.ToDictionary(c => c.Type, c => (object)c.Value);

        foreach (var claim in claims)
        {
            Console.WriteLine($"{claim.Key}: {claim.Value}");
        }

#region
        // try
        // {
        //     var principal = handler.ValidateToken(
        //         token,
```

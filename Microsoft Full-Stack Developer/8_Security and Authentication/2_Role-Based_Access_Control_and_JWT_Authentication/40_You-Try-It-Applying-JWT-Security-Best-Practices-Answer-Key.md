## 🧪 You Try It! JWT Güvenlik En İyi Uygulamalarını Uygulama – Cevap Anahtarı

---

## ✅ Adım 1: Uygulama için Hazırlık

Bu adım için kod gerekmez.

---

## ✅ Adım 2: JWT Authentication’ı Yapılandırma

```csharp
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var secretKey = "SuperSecretKeyForJwtTokenAuthorization123456789"; // Production'da environment variable kullanın
var key = Encoding.ASCII.GetBytes(secretKey);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
```

---

## ✅ Adım 3: Kullanıcı Authentication’ını Uygulama

```csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private static readonly Dictionary<string, string> Users = new()
    {
        { "user1", "password1" },
        { "admin", "password2" }
    };

    private readonly string secretKey = "SuperSecretKeyForJwtTokenAuthorization123456789";

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (!Users.TryGetValue(request.Username, out var password) || password != request.Password)
            return Unauthorized("Invalid username or password.");

        var token = GenerateJwtToken(request.Username);

        return Ok(new { Token = token });
    }

}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
```

---

## ✅ Adım 4: Refresh Token Fonksiyonelliği Ekleme

**AuthController.cs** güncellemesi:

```csharp
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private static readonly Dictionary<string, string> Users =
        new() { { "user1", "password1" }, { "admin", "password2" } };

    private readonly string secretKey = "SuperSecretKeyForJwtTokenAuthorization123456789";
    private static readonly Dictionary<string, string> RefreshTokens = new();

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (!Users.TryGetValue(request.Username, out var password) || password != request.Password)
            return Unauthorized();

        var accessToken = GenerateAccessToken(request.Username);
        var refreshToken = GenerateRefreshToken();

        // Refresh token sakla
        RefreshTokens[refreshToken] = request.Username;

        return Ok(new { AccessToken = accessToken, RefreshToken = refreshToken });
    }

    [HttpPost("refresh")]
    public IActionResult Refresh([FromBody] RefreshTokenRequest request)
    {
        if (!RefreshTokens.TryGetValue(request.RefreshToken, out var username))
            return Unauthorized("Invalid refresh token.");

        // Eski refresh token'ı iptal et
        RefreshTokens.Remove(request.RefreshToken);

        // Yeni access token ve refresh token üret
        var newAccessToken = GenerateAccessToken(username);
        var newRefreshToken = GenerateRefreshToken();

        // Yeni refresh token'ı sakla
        RefreshTokens[newRefreshToken] = username;

        return Ok(new { AccessToken = newAccessToken, RefreshToken = newRefreshToken });
    }

    private string GenerateAccessToken(string username)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(secretKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
            Expires = DateTime.UtcNow.AddMinutes(2),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature
            ),
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private string GenerateRefreshToken()
    {
        return Guid.NewGuid().ToString();
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class RefreshTokenRequest
{
    public string RefreshToken { get; set; }
}
```

---

## ✅ Adım 5: API Endpoint’lerini Korumak

```csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[ApiController]
[Route("api/secure")]
public class SecureController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetSecureData()
    {
        return Ok(new { Message = "This is a secure endpoint." });
    }
}
```

---

## ✅ Beklenen Çıktı

Uygulamayı çalıştırın:

```bash
dotnet run
```

Postman ile API’ye istek gönderin.

Yeni token almak için:

`POST http://localhost:5000/api/auth/login` (terminalde görünen portu kullanın)

```json
{
  "username": "user1",
  "password": "password1"
}
```

Secure endpoint’e erişmek için:

`GET http://localhost:5000/api/secure`

Authorization header:

```text
Authorization: Bearer <token>
```

2 dakika sonra token süresi dolacak ve aynı GET isteği:

**Unauthorized** döndürecek.

Token yenilemek için:

`POST http://localhost:5000/api/auth/refresh`

```json
{
  "username": "user1",
  "password": "password1",
  "refreshToken": "[your refresh token"
}
```

API yeni bir token üretecek ve bunu `/secure` endpoint’inde kullanabileceksiniz.

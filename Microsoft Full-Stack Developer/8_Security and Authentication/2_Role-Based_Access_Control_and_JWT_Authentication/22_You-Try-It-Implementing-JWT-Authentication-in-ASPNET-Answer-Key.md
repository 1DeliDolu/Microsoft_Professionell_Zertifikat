
## 🧪 You Try It! ASP.NET’te JWT Kimlik Doğrulamasını Uygulama – Cevap Anahtarı

## ✅ Adım 1: Uygulama için Hazırlık

**Değiştirilen Dosya:** Yok ( *Komut satırı kurulumu* )

```bash
dotnet new webapi -n JwtAuthDemo
cd JwtAuthDemo
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package System.IdentityModel.Tokens.Jwt
```

---

## ✅ Adım 2: Startup’ta JWT Kimlik Doğrulamasını Yapılandırma

**Değiştirilen Dosya:** `Program.cs`

```csharp
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<TokenService>();

var jwtSettings = builder.Configuration.GetSection("JwtSettings");
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Secret"]))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
```

---

## ✅ Adım 3: User Modeli ve Token Üretimini Uygulama

**Değiştirilen Dosya:** `Models/User.cs`
**Değiştirilen Dosya:** `Services/TokenService.cs`

```csharp
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class TokenService
{
    private readonly string _secret;
    private readonly string _issuer;
    private readonly string _audience;

    public TokenService(IConfiguration configuration)
    {
        _secret = configuration["JwtSettings:Secret"];
        _issuer = configuration["JwtSettings:Issuer"];
        _audience = configuration["JwtSettings:Audience"];
    }

    public string GenerateToken(string username)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secret));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _issuer,
            audience: _audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
```

---

## ✅ Adım 4: Bellek İçi Kullanıcı Deposu Oluşturma

**Değiştirilen Dosya:** `Controllers/UserController.cs`

```csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly TokenService _tokenService;
    private static readonly List<User> _users = new List<User>
    {
        new User { Username = "testuser", Password = "password123" }
    };

    public UserController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User user)
    {
        var existingUser = _users.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);
        if (existingUser == null)
        {
            return Unauthorized("Invalid credentials");
        }

        var token = _tokenService.GenerateToken(user.Username);
        return Ok(new { Token = token });
    }
}
```

---

## ✅ Adım 5: API Route’larını Güvenceye Alma

**Değiştirilen Dosya:** `Controllers/UserController.cs`

```csharp
[HttpGet("secure-data")]
[Authorize]
public IActionResult GetSecureData()
{
    return Ok(new { Message = "This is a protected endpoint!" });
}
```

---

## ⚙️ Ek Yapılandırma

**Değiştirilen Dosya:** `appsettings.json`

```json
{
  "JwtSettings": {
    "Secret": "SuperSecretKeyForJwtTokenAuthorization123456789",
    "Issuer": "JwtAuthDemo",
    "Audience": "JwtAuthDemoAudience",
    "ExpiresInMinutes": 30
  }
}
```

---

## 🖥️ Beklenen Çıktı

**POST** `/User/login` isteği, body içinde geçerli kimlik bilgileriyle:

**Input:**

```json
{
  "username": "testuser",
  "password": "password123"
}
```

**Output:**

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

**GET** `/User/secure-data` (token olmadan):

**Output:** `401 Unauthorized.`

**GET** `/User/secure-data` (Authorization header’da token ile):

**Output:**

```json
{
  "message": "This is a protected endpoint!"
}
```

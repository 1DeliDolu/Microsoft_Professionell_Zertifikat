## 🧪 You Try It! JWT’lerle API Uç Noktalarını Güvenceye Alma – Cevap Anahtarı

---

## ✅ Adım 1: Uygulama için Hazırlık

### Çözüm

Yeni bir *ASP.NET Core Web API* projesi oluşturun ve gerekli *NuGet* paketlerini yükleyin:

```bash
dotnet new webapi -o SecureApiWithJwt
cd SecureApiWithJwt
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.1
dotnet add package System.IdentityModel.Tokens.Jwt --version 7.2.0
dotnet add package Microsoft.IdentityModel.Tokens --version 7.2.0
```

Varsayılan **WeatherForecast** ve ilgili dosyaları kaldırın.

---

## ✅ Adım 2: JWT Authentication için Yapılandırma Ekleme

### Çözüm

**appsettings.json** dosyasına aşağıdakini ekleyin:

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

**Program.cs** içinde authentication yapılandırmasını ekleyin:

```csharp
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

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
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]))
        };
    });

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
```

---

## ✅ Adım 3: Token Üretimini Uygulama

### Çözüm

Bir **TokenService** sınıfı oluşturun:

```csharp
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class TokenService
{
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(string username, string role)
    {
        var jwtSettings = _configuration.GetSection("JwtSettings");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(ClaimTypes.Role, role),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["DurationInMinutes"])),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
```

---

## ✅ Adım 4: Login Endpoint’i Ekleme

### Çözüm

Login için bir **AuthController** ekleyin:

```csharp
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.Username == "admin" && request.Password == "admin123")
        {
            var token = _tokenService.GenerateToken(request.Username, "Admin");
            return Ok(new { Token = token });
        }

        if (request.Username == "user" && request.Password == "user123")
        {
            var token = _tokenService.GenerateToken(request.Username, "User");
            return Ok(new { Token = token });
        }

        return Unauthorized("Invalid credentials");
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
```

---

## ✅ Adım 5: API Endpoint’lerini Güvenceye Alma

### Çözüm

Bir **ValuesController.cs** oluşturun:

```csharp
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet("admin")]
    [Authorize(Roles = "Admin")]
    public IActionResult GetAdminData()
    {
        return Ok("This is Admin data");
    }

    [HttpGet("user")]
    [Authorize(Roles = "User")]
    public IActionResult GetUserData()
    {
        return Ok("This is User data");
    }
}
```

---

## ✅ Adım 6: Uygulamayı Test Etme

### Çözüm

Uygulamayı başlatın:

```bash
dotnet run
```

`/auth/login` endpoint’ini test edin:

Body içinde JSON kimlik bilgileriyle bir **POST** isteği gönderin:

```json
{
  "username": "admin",
  "password": "admin123"
}
```

Yanıtta token döndüğünü doğrulayın.

Token’ı kullanarak diğer endpoint’lere erişin:

Postman’da **Authorization** header’ına token ekleyin:

```text
Authorization: Bearer <token>
```

`/values/admin` ve `/values/user` endpoint’lerini test ederek rol tabanlı kısıtlamaların çalıştığını doğrulayın.

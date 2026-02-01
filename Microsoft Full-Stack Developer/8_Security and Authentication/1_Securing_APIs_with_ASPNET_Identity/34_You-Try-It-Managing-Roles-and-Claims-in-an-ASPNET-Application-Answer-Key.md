## 🧪 You Try It! ASP.NET Uygulamasında Rolleri ve Claim’leri Yönetme – Cevap Anahtarı

---

## 🗄️ Adım 2: ApplicationDbContext Oluşturma

Projenizde bir **Data** klasörü oluşturun ve içine `ApplicationDbContext.cs` adlı yeni bir dosya ekleyin; aşağıdaki kodu kullanın:

```csharp
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) 
    { 
    }
}
```

---

## ⚙️ Adım 3: ASP.NET Identity ve Authorization Policy’lerini Yapılandırma

`Program.cs` dosyasını, Identity ve yetkilendirme policy’lerini yapılandıracak şekilde düzenleyin:

```csharp
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add controllers support
builder.Services.AddControllers();

// Configure in-memory database for Identity
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("TestDB"));

// Configure Identity services
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Add authorization policies (without requiring authentication)
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireITDepartment", policy =>
        policy.RequireClaim("Department", "IT"));
});

var app = builder.Build();

app.UseAuthorization();

// Enable controllers
app.MapControllers();

app.Run();
```

---

## 🧑‍⚖️ Adım 4: Rol Tabanlı Yetkilendirmeyi Uygulama

`UsersController.cs` dosyasını rol tabanlı yetkilendirmeyi uygulayacak şekilde düzenleyin:

```csharp
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet("role-based")]
    public IActionResult GetUserByRole()
    {
        // Simulate a logged-in user with a role
        var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "TestUser"),
            new Claim(ClaimTypes.Role, "Admin") // Simulating an Admin role
        }, "mock"));

        HttpContext.User = user;

        // Perform role-based authorization manually
        if (user.IsInRole("Admin"))
        {
            return Ok(new { Message = "Access granted for Admin role." });
        }
        else
        {
            return Forbid();
        }
    }
}
```

---

## 🧾 Adım 5: Claim Tabanlı Yetkilendirmeyi Uygulama

`UsersController.cs` dosyasını claim tabanlı yetkilendirmeyi uygulayacak şekilde düzenleyin:

```csharp
[HttpGet("claims-based")]
public IActionResult GetUserByClaim()
{
    // Simulate a logged-in user with a claim
    var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
    {
        new Claim(ClaimTypes.Name, "TestUser"),
        new Claim("Department", "IT") // Simulating an IT Department claim
    }, "mock"));

    HttpContext.User = user;

    // Perform claim-based authorization manually
    var hasClaim = user.HasClaim(c => c.Type == "Department" && c.Value == "IT");

    if (hasClaim)
    {
        return Ok(new { Message = "Access granted for IT department." });
    }
    else
    {
        return Forbid();
    }
}
```

---

## 🧪 Adım 6: Postman ile Endpoint’leri Test Etme

### ✅ Test Case 1: Rol Tabanlı Yetkilendirme

**Method:** `GET`

**URL:**

```text
http://localhost:5000/api/users/role-based
```

**Beklenen Yanıt (Simulated Admin Role):**

```json
{ "Message": "Access granted for Admin role." }
```

---

### ✅ Test Case 2: Claim Tabanlı Yetkilendirme

**Method:** `GET`

**URL:**

```text
http://localhost:5000/api/users/claims-based
```

**Beklenen Yanıt (Simulated IT Department Claim):**

```json
{ "Message": "Access granted for IT department." }
```

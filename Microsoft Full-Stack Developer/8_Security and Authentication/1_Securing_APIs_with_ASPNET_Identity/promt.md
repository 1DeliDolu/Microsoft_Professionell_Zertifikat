Tamam — verdiğin yönerge/answer key’e göre projeyi **VS Code + ASP.NET Core MVC + ASP.NET Identity + InMemory** ile **adım adım** kuracağız. Aşağıdaki adımlar, “çalışır” bir yapı çıkarmak için küçük ama kritik düzeltmeleri de içeriyor (namespace, view konumu, cookie login path, Identity parola kuralları gibi).

---

## Step 1 — Projeyi oluşturma ve paketleri kurma

Terminal:

```bash
dotnet new mvc -n UserAuthInMemoryApp
cd UserAuthInMemoryApp

dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.UI
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet restore
```

Kontrol: Proje derleniyor mu?

```bash
dotnet build
```

---

## Step 2 — ApplicationDbContext oluşturma (Identity’nin kullanacağı DbContext)

Şu yolu oluştur:

* `Data/ApplicationDbContext.cs`

**Data/ApplicationDbContext.cs**

```csharp
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserAuthInMemoryApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
```

> Not: `namespace` satırı önemli; birazdan `Program.cs` içinde bunu kullanacağız.

---

## Step 3 — Program.cs: InMemory + Identity servislerini bağlama

`Program.cs` dosyanı aşağıdaki gibi düzenle:

**Program.cs**

```csharp
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserAuthInMemoryApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// In-memory database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryUserAuthApp"));

// Identity
builder.Services
    .AddDefaultIdentity<IdentityUser>(options =>
    {
        // Lab için parolayı kolaylaştırmak istersen (opsiyonel):
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Eğer ileride [Authorize] kullanırsan, login yolu bizim controller’a gelsin:
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Identity UI paketini ekledik; Razor Pages map etmek iyi olur
app.MapRazorPages();

app.Run();
```

Kontrol: şimdi çalıştır.

```bash
dotnet run
```

Tarayıcı: `https://localhost:<port>` açılmalı.

---

## Step 4 — Register ekranı (ViewModel + Controller + View)

### 4.1 RegisterViewModel

Dosya:

* `Models/RegisterViewModel.cs`

```csharp
using System.ComponentModel.DataAnnotations;

namespace UserAuthInMemoryApp.Models;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
}
```

### 4.2 AccountController (Register GET/POST)

Dosya:

* `Controllers/AccountController.cs`

```csharp
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserAuthInMemoryApp.Models;

namespace UserAuthInMemoryApp.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public AccountController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var user = new IdentityUser
        {
            UserName = model.Email,
            Email = model.Email
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            return RedirectToAction(nameof(Login));
        }

        foreach (var error in result.Errors)
            ModelState.AddModelError(string.Empty, error.Description);

        return View(model);
    }

    // Login adımını Step 6'da tamamlayacağız (aşağıda da veriyorum)
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
}
```

### 4.3 Register View

**Önerilen yer:** `Views/Account/Register.cshtml`
(Answer key “Views/Shared” demiş ama Account altında tutmak daha temiz; MVC zaten bulur.)

Dosya:

* `Views/Account/Register.cshtml`

```cshtml
@model UserAuthInMemoryApp.Models.RegisterViewModel

<h2>Register</h2>

<form asp-action="Register" method="post">
    @Html.AntiForgeryToken()

    <div>
        <label asp-for="Email"></label>
        <input asp-for="Email" />
        <span asp-validation-for="Email"></span>
    </div>

    <div>
        <label asp-for="Password"></label>
        <input asp-for="Password" type="password" />
        <span asp-validation-for="Password"></span>
    </div>

    <button type="submit">Register</button>
</form>

<div asp-validation-summary="All"></div>
<a asp-action="Login">Already have an account? Login</a>
```

---

## Step 5 — Register sonrası Login’e yönlendirme

Bunu zaten Register POST içinde yaptık:

```csharp
return RedirectToAction(nameof(Login));
```

---

## Step 6 — Login (ViewModel + Controller POST + View)

### 6.1 LoginViewModel

Dosya:

* `Models/LoginViewModel.cs`

```csharp
using System.ComponentModel.DataAnnotations;

namespace UserAuthInMemoryApp.Models;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    public bool RememberMe { get; set; }
}
```

### 6.2 AccountController: Login POST + Logout ekle

`AccountController.cs` içine (Login GET zaten var) şunları ekle:

```csharp
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Login(LoginViewModel model)
{
    if (!ModelState.IsValid)
        return View(model);

    var result = await _signInManager.PasswordSignInAsync(
        model.Email,
        model.Password,
        model.RememberMe,
        lockoutOnFailure: false);

    if (result.Succeeded)
        return RedirectToAction("Index", "Home");

    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
    return View(model);
}

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Logout()
{
    await _signInManager.SignOutAsync();
    return RedirectToAction("Index", "Home");
}
```

### 6.3 Login View

Dosya:

* `Views/Account/Login.cshtml`

```cshtml
@model UserAuthInMemoryApp.Models.LoginViewModel

<h2>Login</h2>

<form asp-action="Login" method="post">
    @Html.AntiForgeryToken()

    <div>
        <label asp-for="Email"></label>
        <input asp-for="Email" />
        <span asp-validation-for="Email"></span>
    </div>

    <div>
        <label asp-for="Password"></label>
        <input asp-for="Password" type="password" />
        <span asp-validation-for="Password"></span>
    </div>

    <div>
        <label asp-for="RememberMe"></label>
        <input asp-for="RememberMe" type="checkbox" />
    </div>

    <button type="submit">Login</button>
</form>

<div asp-validation-summary="All"></div>
<a asp-action="Register">Create account</a>
```

---

## Step 7 — Test

1. Çalıştır:

```bash
dotnet run
```

2. Register’a git:

* `https://localhost:<port>/Account/Register`

3. Kayıt ol → Login’e yönlenmeli.
4. Login ol:

* Doğru email/şifre ile Home/Index’e dönmeli.

5. **Remember Me** :

* Aynı uygulama çalışırken tarayıcıyı kapat-aç dene (cookie kalır).
* Ama **uygulamayı restart edince kullanıcılar InMemory olduğu için silinir** → cookie olsa bile user store’da kullanıcı kalmayacağı için oturum davranışı bozulur/yeniden login isteyebilir. Bu “in-memory storage behavior”ın doğal sonucu.

---

## Minik iyileştirme (menüye link eklemek)

`Views/Shared/_Layout.cshtml` içinde navigation’a şunları ekleyebilirsin:

```cshtml
<li class="nav-item">
  <a class="nav-link text-dark" asp-controller="Account" asp-action="Register">Register</a>
</li>
<li class="nav-item">
  <a class="nav-link text-dark" asp-controller="Account" asp-action="Login">Login</a>
</li>
```

---

### Şimdi senden tek şey:

Şu ana kadar  **Step 3** ’e kadar (Program.cs dahil) geldiysen `dotnet run` çıktısında bir hata var mı? Varsa hatayı buraya yapıştır; yoksa Step 4-6 dosyalarını birlikte yerleştirip ilk kayıt/login testini netleştirelim.

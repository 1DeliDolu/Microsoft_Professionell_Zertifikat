## 🧪 You Try It! Kullanıcı Kaydı ve Kimlik Doğrulamayı Uygulama – Cevap Anahtarı

---

## 🗄️ Adım 2: Uygulama Veritabanı Context’ini Oluşturma

### `ApplicationDbContext.cs`

```csharp
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
```

---

## ⚙️ Adım 3: Uygulamayı In-Memory Depolama Kullanacak Şekilde Yapılandırma

### `Program.cs`

```csharp
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure in-memory database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryUserAuthApp"));

// Add Identity
builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
app.MapRazorPages();

app.Run();
```

---

## 🧾 Adım 4: Kullanıcı Kayıt Formunu Oluşturma

### `RegisterViewModel.cs`

```csharp
using System.ComponentModel.DataAnnotations;
public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
```

### `AccountController.cs`

```csharp
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public AccountController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
        return View(model);
    }
}
```

### `Shared/Register.cshtml`

```cshtml
@model RegisterViewModel

<form asp-action="Register" method="post">
    <div>
        <label>Email</label>
        <input asp-for="Email" />
    </div>
    <div>
        <label>Password</label>
        <input asp-for="Password" type="password" />
    </div>
    <button type="submit">Register</button>
</form>
```

---

## 🔐 Adım 6: Kullanıcı Kimlik Doğrulamayı Uygulama

### `LoginViewModel.cs`

```csharp
using System.ComponentModel.DataAnnotations;
public class LoginViewModel
{
    [Required]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}
```

### `AccountController.cs` (Mevcut controller’a şu bölümü ekleyin)

```csharp
private readonly SignInManager<IdentityUser> _signInManager;
private readonly UserManager<IdentityUser> _userManager;

public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
{
    _userManager = userManager;
    _signInManager = signInManager;
}

[HttpGet]
public IActionResult Login()
{
    return View();
}

[HttpPost]
public async Task<IActionResult> Login(LoginViewModel model)
{
    if (ModelState.IsValid)
    {
        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }
        ModelState.AddModelError("", "Invalid login attempt.");
    }
    return View(model);
}
```

### `Shared/Login.cshtml`

```cshtml
@model LoginViewModel

<form asp-action="Login" method="post">
    <div>
        <label>Email</label>
        <input asp-for="Email" />
    </div>
    <div>
        <label>Password</label>
        <input asp-for="Password" type="password" />
    </div>
    <div>
        <label>Remember Me</label>
        <input asp-for="RememberMe" type="checkbox" />
    </div>
    <button type="submit">Login</button>
</form>
```

---

## ✅ Beklenen Çıktı

Başarılı kullanıcı kaydı ve giriş işlevselliği.

**"Remember Me"** işlevi tek bir oturum boyunca beklendiği gibi çalışır.

Uygulama yeniden başlatıldığında tüm kullanıcı verileri sıfırlanır.

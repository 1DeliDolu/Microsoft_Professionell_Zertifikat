

---

## Step 8 — Navbar: Login/Register/Logout + “Merhaba user”

Dosya: `Views/Shared/_Layout.cshtml`

1. Dosyanın en üstüne (veya uygun bir yere) şu inject’leri ekle:

```cshtml
@using Microsoft.AspNetCore.Identity
@inject SignInManager<IdentityUser> SignInManager
@inject UserManager<IdentityUser> UserManager
```

2. Navbar’daki `<ul class="navbar-nav ...">` bölümüne şunu ekle (mevcut linklerin yanına):

```cshtml
<ul class="navbar-nav ms-auto">
@if (SignInManager.IsSignedIn(User))
{
    <li class="nav-item">
        <span class="nav-link text-dark">Merhaba, @User.Identity?.Name</span>
    </li>
    <li class="nav-item">
        <form asp-controller="Account" asp-action="Logout" method="post" class="d-inline">
            @Html.AntiForgeryToken()
            <button type="submit" class="nav-link btn btn-link text-dark">Logout</button>
        </form>
    </li>
}
else
{
    <li class="nav-item">
        <a class="nav-link text-dark" asp-controller="Account" asp-action="Register">Register</a>
    </li>
    <li class="nav-item">
        <a class="nav-link text-dark" asp-controller="Account" asp-action="Login">Login</a>
    </li>
}
</ul>
```

> `Logout` işlemi **POST** olarak yapılmalı (CSRF için doğru pratik). Biz zaten `Logout` action’ını POST yazmıştık.

---

## Step 9 — Sayfa koruma: `[Authorize]` ile giriş zorunlu yapalım

Örnek olarak `Home/Privacy` sayfasını koruyalım.

Dosya: `Controllers/HomeController.cs`

En üste ekle:

```csharp
using Microsoft.AspNetCore.Authorization;
```

Sonra `Privacy` action’ını şöyle değiştir:

```csharp
[Authorize]
public IActionResult Privacy()
{
    return View();
}
```

Artık `https://localhost:<port>/Home/Privacy` açılınca login ister.

> Login sayfasına yönlenmesi için `Program.cs`’teki `options.LoginPath = "/Account/Login";` ayarı zaten hazır.

---

## Step 10 — Login’de ReturnUrl desteği (login sonrası doğru yere dön)

Şu an login olunca her zaman `Home/Index`’e gidiyor. `[Authorize]` ile korunan sayfaya gitmeye çalışınca Identity genelde `?ReturnUrl=...` koyar. Biz bunu destekleyelim.

### 10.1 Login GET: ReturnUrl’ı taşı

`Controllers/AccountController.cs` içinde Login GET:

```csharp
[HttpGet]
public IActionResult Login(string? returnUrl = null)
{
    ViewData["ReturnUrl"] = returnUrl;
    return View();
}
```

### 10.2 Login POST: ReturnUrl’a güvenli redirect

Login POST’u şöyle güncelle:

```csharp
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
{
    ViewData["ReturnUrl"] = returnUrl;

    if (!ModelState.IsValid)
        return View(model);

    var result = await _signInManager.PasswordSignInAsync(
        model.Email,
        model.Password,
        model.RememberMe,
        lockoutOnFailure: false);

    if (result.Succeeded)
    {
        if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
            return Redirect(returnUrl);

        return RedirectToAction("Index", "Home");
    }

    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
    return View(model);
}
```

### 10.3 Login View: ReturnUrl’ı hidden olarak gönder

`Views/Account/Login.cshtml` formuna (form tag’inin içine) şunu ekle:

```cshtml
<input type="hidden" name="returnUrl" value="@(ViewData["ReturnUrl"] ?? "")" />
```

Aynı şekilde Register’dan sonra Login’e ReturnUrl ile gidebilmek istersen Step 10.4’ü de ekleyebilirsin:

### 10.4 Register POST: Login’e ReturnUrl ile yönlendir (opsiyonel)

Register POST’ta RedirectToAction satırını şu hale getir:

```csharp
return RedirectToAction(nameof(Login), new { returnUrl });
```

ve Register action imzasını şöyle yap:

```csharp
public async Task<IActionResult> Register(RegisterViewModel model, string? returnUrl = null)
```

---

## Step 11 — Client-side validation (ekranda anında validation)

MVC template genelde hazır getirir. Sadece view’lara partial ekleyelim:

### 11.1 Register view en alta ekle

`Views/Account/Register.cshtml` en altına:

```cshtml
@section Scripts {
    <partial name="_ValidationScriptsPartial" />
}
```

### 11.2 Login view en alta ekle

`Views/Account/Login.cshtml` en altına:

```cshtml
@section Scripts {
    <partial name="_ValidationScriptsPartial" />
}
```

> Eğer `_ValidationScriptsPartial` bulunamaz hatası alırsan söyle — bazı şablonlarda kaldırılabiliyor; gerekirse ekleriz.

---

## Step 12 — “In-memory’de user var mı?” Debug ekranı (lab için)

Bu adım **sadece lab/demonstrasyon** için. In-memory’de kayıtların oluştuğunu “gözle” göstermek için ideal.

### 12.1 Controller: DebugUsers

Yeni controller dosyası oluştur:

* `Controllers/AdminController.cs`

```csharp
using Microsoft.AspNetCore.Mvc;
using UserAuthInMemoryApp.Data;

namespace UserAuthInMemoryApp.Controllers;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _db;

    public AdminController(ApplicationDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Users()
    {
        var users = _db.Users
            .Select(u => new UserRow { Id = u.Id, Email = u.Email!, UserName = u.UserName! })
            .ToList();

        return View(users);
    }

    public class UserRow
    {
        public string Id { get; set; } = "";
        public string Email { get; set; } = "";
        public string UserName { get; set; } = "";
    }
}
```

### 12.2 View: Users listesi

Dosya oluştur:

* `Views/Admin/Users.cshtml`

```cshtml
@model List<UserAuthInMemoryApp.Controllers.AdminController.UserRow>

<h2>In-Memory Users</h2>

@if (Model.Count == 0)
{
    <p>Henüz kullanıcı yok.</p>
}
else
{
    <table class="table">
        <thead>
            <tr>
                <th>Id</th>
                <th>Email</th>
                <th>UserName</th>
            </tr>
        </thead>
        <tbody>
        @foreach (var u in Model)
        {
            <tr>
                <td>@u.Id</td>
                <td>@u.Email</td>
                <td>@u.UserName</td>
            </tr>
        }
        </tbody>
    </table>
}
```

Şimdi şu URL ile gör:

* `https://localhost:<port>/Admin/Users`

Kayıt olduktan sonra listede kullanıcıyı görmelisin.
Uygulamayı kapatıp tekrar `dotnet run` yapınca liste **boş** gelir (in-memory davranışı).

---

## Step 13 — Test senaryosu (hızlı kontrol)

1. `dotnet run`
2. `/Account/Register` → kayıt ol
3. `/Admin/Users` → kullanıcı göründü mü?
4. `/Home/Privacy` → login ister mi? login olunca privacy’e döndü mü? (ReturnUrl)
5. `RememberMe` işaretle → tarayıcıyı kapat-aç dene
6. Uygulamayı restart et → `/Admin/Users` boş mu?

---

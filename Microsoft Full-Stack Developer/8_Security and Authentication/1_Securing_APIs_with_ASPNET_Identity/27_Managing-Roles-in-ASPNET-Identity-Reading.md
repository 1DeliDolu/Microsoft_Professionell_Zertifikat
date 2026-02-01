## 👥 ASP.NET Identity’de Roller Yönetimi

### 📌 Giriş

Rol tabanlı erişim kontrolü ( **RBAC** ), kullanıcıların bir uygulama içinde yalnızca ihtiyaç duydukları alanlara erişmesini sağlar.  **ASP.NET Identity** ’de **"Admin"** veya **"User"** gibi roller, izinleri verimli biçimde yönetmeye yardımcı olur. Bu rehber; rol oluşturmayı, rolleri kullanıcılara atamayı ve uygulamanızda RBAC’i zorunlu kılmayı adım adım açıklar.

---

## 1️⃣ Adım 1: Projeye RoleManager Ekleme

Projenizin **ASP.NET Identity** kullandığını doğrulayın.

Projenizde `RoleManager<IdentityRole>` servisini kaydedin:

```csharp
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

---

## 2️⃣ Adım 2: Yeni Bir Rol Oluşturma

Bir controller veya servise `RoleManager<IdentityRole>` enjekte edin:

```csharp
private readonly RoleManager<IdentityRole> _roleManager;

public RolesController(RoleManager<IdentityRole> roleManager)
{
    _roleManager = roleManager;
}
```

`CreateAsync` kullanarak bir rol ekleyin:

```csharp
if (!await _roleManager.RoleExistsAsync("Admin"))
{
    var role = new IdentityRole("Admin");
    await _roleManager.CreateAsync(role);
}
```

*Pro Tip:* Çoğaltmayı önlemek için her zaman mevcut rol olup olmadığını kontrol edin.

---

## 3️⃣ Adım 3: Bir Kullanıcıya Rol Atama

Controller veya servisinize `UserManager<IdentityUser>` enjekte edin:

```csharp
private readonly UserManager<IdentityUser> _userManager;

public RolesController(UserManager<IdentityUser> userManager)
{
    _userManager = userManager;
}
```

Kullanıcıyı e-posta veya ID ile bulun:

```csharp
var user = await _userManager.FindByEmailAsync("user@example.com");
```

Kullanıcıya rol atayın:

```csharp
if (user != null)
{
    await _userManager.AddToRoleAsync(user, "Admin");
}
```

---

## 4️⃣ Adım 4: Rol Atamalarını Doğrulama

Bir kullanıcının rolünü doğrulayın:

```csharp
var isInRole = await _userManager.IsInRoleAsync(user, "Admin");

if (isInRole)
{
    Console.WriteLine("User is an Admin.");
}
```

Rol verileri otomatik olarak veritabanınıza kaydedilir (**AspNetRoles** ve **AspNetUserRoles** tabloları).

---

## 🔒 Adım 5: Uygulama Erişimini Güvenli Hale Getirme

Belirli rollere erişimi `[Authorize]` niteliği ile kısıtlayın:

```csharp
[Authorize(Roles = "Admin")]
public IActionResult AdminDashboard()
{
    return View();
}
```

Farklı kullanıcılarla giriş yaparak ve erişim haklarını doğrulayarak rol tabanlı kısıtlamaları test edin.

---

## ✅ Sonuç

 **ASP.NET Identity** ’de rollerin uygulanması, RBAC’i etkili biçimde zorunlu kılmanızı sağlar ve uygulamanızın güvenliğini ile kullanılabilirliğini artırır. Rol ekleme, rolleri kullanıcılara atama ve erişim kısıtlamalarını uygulama; uygulamanızın ihtiyaçlarına uygun, ölçeklenebilir ve güvenli bir sistem oluşturur.

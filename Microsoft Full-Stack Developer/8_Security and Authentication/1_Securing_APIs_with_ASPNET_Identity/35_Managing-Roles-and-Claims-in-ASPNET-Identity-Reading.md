## 🔐 ASP.NET Identity’de Roller ve Claim’leri Yönetme

### 📌 Giriş

 **ASP.NET Identity** , roller ve claim’ler aracılığıyla kullanıcı erişimini ve izinlerini yönetmek için güçlü özellikler sunar. Bu rehber, rol oluşturma, rolleri kullanıcılara atama ve claim tabanlı yetkilendirmeyi uygulama adımlarını açıklar. Bu adımları izleyerek ASP.NET uygulamalarınızda güvenli ve esnek erişim kontrolünü etkili şekilde yapılandırıp yönetebilirsiniz.

---

## 👥 Bölüm 1: Rol Oluşturma ve Rol Atama

### 🧩 Role Manager’ı Kurma

Gerekli namespace’leri içeri aktarın:

```csharp
using Microsoft.AspNetCore.Identity;
```

Uygulamanızda `RoleManager`’ı başlatın:

```csharp
public RoleManager<IdentityRole> RoleManager { get; }
```

---

### 🏷️ Rol Oluşturma

`RoleManager` kullanarak yeni bir rol oluşturun:

```csharp
var roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
if (roleResult.Succeeded)
{
    Console.WriteLine("Role created successfully!");
}
Else
{
          Console.WriteLine("Error creating role.");
}
```

---

### 👤 Kullanıcıya Rol Atama

`UserManager` kullanarak bir kullanıcıya rol atayın:

```csharp
var user = await UserManager.FindByEmailAsync("user@example.com");
await UserManager.AddToRoleAsync(user, "Admin");
```

---

### ✅ Rol Atamasını Doğrulama

Kullanıcının rollerini doğrulayın:

```csharp
var roles = await UserManager.GetRolesAsync(user);
Console.WriteLine(string.Join(", ", roles));
```

---

## 🧾 Bölüm 2: Claim Yönetimi

### ❓ Claim Nedir?

Claim’ler, rolere kıyasla daha ayrıntılı kontrol sağlayan anahtar-değer çiftleri olarak saklanan özniteliklerdir (örn. `"department"`, `"IT"`).

---

### ➕ Kullanıcıya Claim Atama

`AddClaimAsync` kullanarak bir claim ekleyin:

```csharp
var claim = new Claim("department", "IT");
var claimResult = await UserManager.AddClaimAsync(user, claim);
if (claimResult.Succeeded)
{
    Console.WriteLine("Claim added successfully!");
}
```

---

### 🔎 Claim’leri Alma

Kullanıcının claim’lerini kontrol edin:

```csharp
var claims = await UserManager.GetClaimsAsync(user);
foreach (var c in claims)
{
    Console.WriteLine($"{c.Type}: {c.Value}");
}
```

---

### 🛡️ Yetkilendirme İçin Claim Kullanma

Uygulamanızda bir policy tanımlayın:

```csharp
services.AddAuthorization(options =>
{
    options.AddPolicy("ITDepartment", policy =>
        policy.RequireClaim("department", "IT"));
});
```

Policy’yi action’lara uygulayın:

```csharp
[Authorize(Policy = "ITDepartment")]
public IActionResult SecureResource()
{
    return View();
}
```

---

## 🗄️ Bölüm 3: Rolleri ve Claim’leri Depolama

**Roller:** ASP.NET Identity tarafından otomatik olarak **AspNetRoles** tablosunda saklanır.

**Claim’ler:** **AspNetUserClaims** tablosunda kalıcı olarak tutulur.

---

## 🧪 Bölüm 4: Test ve Sorun Giderme

### ✅ Rol Atamasını Test Etme

Bir kullanıcıyla giriş yapın ve rol bazlı erişimin uygulamanın farklı bölümlerinde doğru çalıştığını doğrulayın.

---

### ✅ Claim Tabanlı Erişimi Doğrulama

Claim tabanlı policy’lerin gerçekten uygulandığını doğrulamak için güvenli kaynaklara erişimi test edin.

---

### 🛠️ Yaygın Sorunları Giderme

Identity tablolarının migration’lara dâhil olduğundan emin olun.

Kullanıcı rol ve claim doğrulamaları için `UserManager` metotlarını kullanın.

---

## ✅ Sonuç

Rolleri oluşturma ve atama ile claim’leri yönetme adımlarında ustalaşarak ASP.NET uygulamalarınızda güvenli ve dinamik erişim kontrolü uygulayabilirsiniz. Rolleri daha geniş erişim seviyeleri için, claim’leri ise daha ayrıntılı kontrol için kullanabilirsiniz. Bu pratikleri projelerinizde uygulayarak yetkilendirmeyi güvenle hayata geçirebilirsiniz.

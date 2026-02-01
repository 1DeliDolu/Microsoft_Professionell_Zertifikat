## 🧪 Rehberli Laboratuvar: ASP.NET Uygulamasında Rolleri ve Claim’leri Yönetme

---

## ℹ️ Arka Plan Bilgileri

Kimlik doğrulama için *Identity* kullanan bir **ASP.NET Core** uygulaması üzerinde çalışıyorsunuz. Amacınız, uygulamanın belirli bölümlerine erişimi yönetmek için **rol tabanlı** ve **claim tabanlı** yetkilendirme uygulamaktır. Bu laboratuvarda, rolleri yapılandırmak, claim’leri atamak ve uygulamanızdaki uç noktaları güvence altına almak için bunları kullanmak üzere kod boşluklarını tamamlayacaksınız.

---

## 👥 Adım: Roller Tanımlama

Bu adımda, **ASP.NET Core** uygulamasında rolleri tanımlamakla görevlisiniz. **"Admin"** ve **"User"** gibi roller, erişim kontrolünü uygulamanıza olanak tanır. Bu roller, Identity tarafından sağlanan **RoleManager** servisi kullanılarak yapılandırılacaktır.

```csharp
var app = builder.Build()
app.UseHttpsRedirection();
RoleManager<IdentityRole> roleManager = app.Services.GetService<RoleManager<IdentityRole>>();
if(!await roleManager.RoleExistsAsync("Admin"))
{
    await roleManager.CreateAsync(new IdentityRole ("Admin"));
}
if(!await roleManager.RoleExistsAsync("User"))
{
    await roleManager.CreateAsync(new IdentityRole ("User"));
}
```

---

## 🧾 Adım: HR Rolüne Claim Atama

Uygulamanızda **HR** departmanı, çalışan verilerini yönetmek için claim’lere ihtiyaç duyar. **ManageEmployeeRecords** gibi belirli claim’leri **"HR"** departmanı rolüne atayacaksınız.

```csharp
Claim claim = new Claim ("Permission", "ManageEmployeeRecords");
claim claim = new Claim ("Permission", "ManageEmployeeRecords");
await roleManager.AddClaimAsync (
    await roleManager.FindByNameAsync("HR"),
    _claim
);
```

---

## 🔒 Son Adım: Uç Noktaları Roller ve Claim’lerle Güvence Altına Alma

Bu son adımda, önceki adımlarda kurduğunuz rolleri ve claim’leri kullanarak hem **rol tabanlı** hem de **claim tabanlı** yetkilendirmeyi uygulayacaksınız. Oluşturduğunuz **HR** rolü ve ona atanan **ManageEmployeeRecords** claim’i, artık bir **ASP.NET** uygulamasındaki belirli uç noktaların erişimini kontrol etmek için kullanılacaktır.

Amaç, yalnızca uygun role veya claim’e sahip yetkili kullanıcıların hassas uç noktalara erişebilmesini sağlamaktır.

**EmployeeController** sizin için oluşturulmuştur ve çalışan kayıtlarını yönetmeyi simüle eden yer tutucu metotlar içerir. Göreviniz:

```csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
[Route("api/employees")]
[ApiController]
public class EmployeeController : ControllerBase
{
    // GET: Retrieve all employee records (role-based authorization)
    [HttpGet]
    [Authorize(Roles = "HR")]
    public IActionResult GetAll()
    {
        return Ok("All employee records retrieved.");
    }

    // POST: Add a new employee record (claims-based authorization)
    [HttpPost]
    [Authorize(Policy = "ManageEmployeeRecords")]
    public IActionResult AddEmployee()
    {
        return Ok("New employee record added.");
    }

    // DELETE: Remove an employee record (claims-based authorization)
    [HttpDelete("{id}")]
    [Authorize(Policy = "ManageEmployeeRecords")]
    public IActionResult RemoveEmployee(int id)
    {
        return Ok($"Employee record with ID {id} removed.");
    }
}
```

---

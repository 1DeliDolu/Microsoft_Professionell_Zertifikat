## ℹ️ Arka Plan Bilgileri

Şirketin API’sinin, erişim kontrolünü etkili şekilde yönetmek için kullanıcılara roller ataması gerekiyor.  **ASP.NET Identity** ’den **RoleManager** ve **UserManager** sınıflarını kullanarak kullanıcılara rol atamakla görevlisiniz. Sistem içinde **"Admin"** ve **"User"** rolleri zaten oluşturulmuştur. Uygulama, kullanıcıları temsil etmek için **IdentityUser** sınıfını kullanır ve **Username** özelliği onları benzersiz şekilde tanımlar. **"[testuser@example.com](mailto:testuser@example.com)"** kullanıcı adına sahip yeni bir kullanıcı oluşturacak ve ona **"Admin"** rolünü atayacaksınız. Göreviniz, bu kullanıcıya **UserManager** sınıfını kullanarak rol atama kodunu tamamlamaktır.

```csharp
var user = new IdentityUser { UserName = "testuser@example.com", Email = "testuser@example.com" };
await userManager.CreateAsync(user, "Test@1234");
await userManager.AddToRoleAsync(user, "Admin");
```

---

## 🧾 Arka Plan Bilgileri

API’de ince ayarlı yetkilendirme uygulamak için şirket, belirli claim’lerin kullanıcılara eklenmesini gerektirir. Claim’ler, sistemin bir kullanıcı hakkında departmanı veya erişim seviyesi gibi belirli öznitelikleri tanımlamasına olanak tanır ve bunlar yetkilendirme sırasında kontrol edilebilir. API, belirli kaynaklara erişim izni vermek için türü **"Department"** ve değeri **"HR"** olan bir claim’i kontrol eder. Göreviniz, **UserManager** sınıfını kullanarak bu claim’i **"[testuser@example.com](mailto:testuser@example.com)"** test kullanıcısına eklemektir.

```csharp
var user = await userManager.FindByNameAsync("testuser@example.com");
await userManager.AddClaimAsync(user, new Claim("Department", "HR"));
```

---

## ✅ Arka Plan Bilgileri

API, kaynaklara erişimi kısıtlamak için claim tabanlı yetkilendirme kullanır. Sistem, erişime izin vermek için değeri **"HR"** olan **"Department"** claim’ini kontrol eder. Göreviniz, test kullanıcısının gerekli claim’e sahip olduğunu doğrulayarak yetkilendirmeyi test etmektir.

```csharp
var user = await userManager.FindByNameAsync("testuser@example.com");
var claims = await userManager.GetClaimsAsync(user);
bool hasClaim = claims.Any(c => c.Type == "Department" && c.Value == "HR");
if (hasClaim)
{
    Console.WriteLine("Access granted.");
}
else
{
    Console.WriteLine("Access denied");
}
```

---

## ✅ Tamamlandı

Bu rehberli laboratuvarı tamamladığınız için harika iş çıkardınız. Şimdi, bir **ASP.NET** uygulamasında **Token Tabanlı Kimlik Doğrulamayı Uygulama** konusunda ustalığınızı bağımsız olarak göstermek için bu laboratuvarın **You Try It!** bölümünü tamamlayın.

## 🧪 You Try It! ASP.NET Uygulamasında Rolleri ve Claim’leri Yönetme

### 🎯 Amaç

Bu laboratuvarın sonunda, **ASP.NET Identity** kullanarak bir **ASP.NET Web API** konsol uygulamasında rol tabanlı ve claim tabanlı yetkilendirmeyi uygulayabileceksiniz. Rol tabanlı ve claim tabanlı yetkilendirme ile kullanıcı bilgisinin getirilebildiği basit bir API oluşturacaksınız.

---

## 🧱 Adım 1: Uygulama için Hazırlık

**Visual Studio Code** içinde küçük bir **ASP.NET Core Web API** projesi oluşturacaksınız.

**Talimatlar**

Visual Studio Code’u açın.

Yeni bir ASP.NET Core Web API projesi oluşturun:

Terminali açın ve çalıştırın:

```bash
dotnet new webapi -n RoleClaimsApp
```

Proje klasörüne gidin:

```bash
cd RoleClaimsApp
```

`Program.cs` ve `appsettings.json` hariç gereksiz dosyaları kaldırın.

Gerekli ASP.NET Identity paketlerini yükleyin:

```bash
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

`Program.cs` dosyasını açın ve rol tabanlı ve claim tabanlı yetkilendirmeyi kaydetmeye hazırlayın.

---

## 🗄️ Adım 2: Application DbContext Oluşturma

 **ASP.NET Identity** ’yi bir *in-memory* veritabanı ile yapılandıracak ve kullanıcı verilerini yönetmek için `ApplicationDbContext`’i kaydedeceksiniz.

**Talimatlar**

**Data** klasörü içinde `ApplicationDbContext.cs` adlı yeni bir dosya oluşturun.

`IdentityDbContext`’ten türeyen `ApplicationDbContext` adlı bir sınıf tanımlayın.

`Program.cs` dosyasını, veritabanı context’ini kaydedecek ve Identity depolaması için kullanacak şekilde düzenleyin.

---

## ⚙️ Adım 3: ASP.NET Identity ve Authorization Policy’lerini Yapılandırma

 **ASP.NET Identity** ’yi kullanıcı ve rollerin yönetimi için yapılandıracak ve yetkilendirme policy’lerini tanımlayacaksınız.

**Talimatlar**

`Program.cs` dosyasını açın.

Controller’lar dâhil ASP.NET Core servislerini kaydedin.

ASP.NET Identity’yi *in-memory* veritabanı ile yapılandırın.

Rol tabanlı ve claim tabanlı yetkilendirme policy’lerini ekleyin.

Uygulamanın, kimlik doğrulama gerektirmeden rol ve claim kontrollerine izin verdiğinden emin olun.

---

## 🧑‍⚖️ Adım 4: Rol Tabanlı Yetkilendirmeyi Uygulama

**Admin** rolüne sahip olan kullanıcıların bir kullanıcıyı getirebilmesini sağlayan bir uç nokta oluşturacaksınız.

**Talimatlar**

**Controllers** klasöründe `UsersController.cs` adlı yeni bir dosya oluşturun.

Yalnızca `"Admin"` rolüne sahip kullanıcıların bir kullanıcıyı getirebildiği bir API endpoint’i uygulayın.

**Admin** rolüne sahip kimliği doğrulanmış bir kullanıcıyı simüle etmek için **manual identity injection** kullanın.

Kullanıcı **Admin** rolüne sahipse başarı mesajı döndürün.

Kullanıcı **Admin** rolüne sahip değilse forbidden mesajı döndürün.

---

## 🧾 Adım 5: Claim Tabanlı Yetkilendirmeyi Uygulama

Belirli bir claim’e sahip olan kullanıcıların bir kullanıcıyı getirebilmesini sağlayan ikinci bir uç nokta oluşturacaksınız.

**Talimatlar**

`UsersController.cs` içinde ikinci bir API endpoint’i uygulayın; bu endpoint yalnızca `Department: IT` claim’i olan kullanıcıların erişimine izin versin.

`Department` claim’ine sahip bir kullanıcıyı simüle etmek için **manual identity injection** kullanın.

Kullanıcı gerekli claim’e sahipse başarı mesajı döndürün.

Kullanıcı gerekli claim’e sahip değilse forbidden mesajı döndürün.

---

## 🧪 Adım 6: Postman ile Endpoint’leri Test Etme

Kimlik doğrulama header’ları kullanmadan her iki endpoint’i de **Postman** ile test edeceksiniz.

**Talimatlar**

Uygulamayı başlatın.

Postman’ı açın.

Rol tabanlı endpoint’e bir **GET** isteği gönderin ve yanıtı gözlemleyin.

Claim tabanlı endpoint’e bir **GET** isteği gönderin ve yanıtı gözlemleyin.

Roller ve claim’lere göre erişimin izin verildiğini veya reddedildiğini doğrulayın.

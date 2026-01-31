## 🧪 You Try It! ASP.NET Identity ile Kullanıcı Kaydı ve Kimlik Doğrulama

### 🧭 VS Code’da In-Memory Depolama ile Kullanıcı Kaydı ve Giriş Uygulaması

---

## 🎯 Amaç

Bu etkinliğin sonunda, bir **ASP.NET** uygulamasında **ASP.NET Identity** kullanarak kullanıcı kaydı ve kimlik doğrulama sürecini uygulayacaksınız. Veritabanı kurulumu gerektirmeden yalnızca işlevselliğe odaklanmak için kalıcı bir veritabanı yerine **in-memory depolama** kullanacaksınız.

---

## 🧱 Adım 1: Uygulama için Hazırlık

Kullanıcı kaydı ve kimlik doğrulama işlemlerini uygulamak için **Visual Studio Code** içinde yeni bir **ASP.NET Core** uygulaması oluşturacaksınız.

**Talimatlar:**

Visual Studio Code’u açın ve **C# for Visual Studio Code (powered by OmniSharp)** eklentisinin yüklü olduğundan emin olun.

VS Code’da  **Terminal** ’i açmak için `Terminal > New Terminal` seçin.

Yeni bir ASP.NET Core MVC projesi oluşturmak için aşağıdaki komutu çalıştırın:

```bash
dotnet new mvc -n UserAuthInMemoryApp
```

Bu komut, gerekli proje dosyalarını içeren **UserAuthInMemoryApp** adlı yeni bir klasör oluşturur.

Proje klasörüne gidin:

```bash
cd UserAuthInMemoryApp
```

Gerekli NuGet paketlerini ekleyin:

**ASP.NET Identity’yi yükleyin:**

```bash
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```

**ASP.NET Identity UI’yi yükleyin:**

```bash
dotnet add package Microsoft.AspNetCore.Identity.UI
```

**In-memory veritabanı sağlayıcısını yükleyin:**

```bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

Paketlerin düzgün kurulduğundan emin olmak için restore işlemi yapın:

```bash
dotnet restore
```

---

## 🗄️ Adım 2: Uygulama Veritabanı Context’ini Oluşturma

ASP.NET Identity’nin kullanıcı verilerini yönetmek için kullanacağı özel bir veritabanı context’i tanımlayacaksınız.

**Talimatlar:**

**Models** klasöründe (veya **Data** adlı yeni bir klasör oluşturarak) `ApplicationDbContext.cs` adlı yeni bir dosya ekleyin.

Veritabanı context’ini tanımlamak için gerekli kodu ekleyin.

---

## ⚙️ Adım 3: Uygulamayı In-Memory Depolama Kullanacak Şekilde Yapılandırma

Projenizi *in-memory* veritabanını kullanacak şekilde yapılandıracak ve **Identity** servislerini kaydedeceksiniz.

**Talimatlar:**

`Program.cs` dosyasını açın.

Uygulamanın *in-memory* depolama ve **ASP.NET Identity** servislerini kullanmasını yapılandırın.

---

## 🧾 Adım 4: Kullanıcı Kayıt Formunu Oluşturma

Kullanıcıların e-posta ve parola girebilmesi için bir kayıt formu oluşturacaksınız.

**Talimatlar:**

**Controllers** klasöründe `AccountController.cs` adlı yeni bir dosya oluşturun.

Kayıt formunu render etmek için bir `Register` action method’u ekleyin.

**Models** klasöründe `RegisterViewModel.cs` dosyası oluşturun ve e-posta ile parola özelliklerini ekleyin.

**Views/Shared** klasöründe formu göstermek için `Register.cshtml` dosyası oluşturun.

---

## ✅ Adım 5: Kullanıcı Kaydını İşleme

Form gönderimini işleyerek yeni kullanıcı kaydı oluşturacaksınız.

**Talimatlar:**

`AccountController`’ı, form gönderimlerini işleyecek ve `UserManager` servisini kullanarak yeni kullanıcılar oluşturacak şekilde güncelleyin.

Parola hash’lemesini  **ASP.NET Identity** ’nin otomatik olarak yapmasını sağlayın.

Başarılı kayıt sonrası kullanıcıları giriş sayfasına yönlendirin.

---

## 🔐 Adım 6: Kullanıcı Kimlik Doğrulamayı Uygulama

Kullanıcıları doğrulamak için giriş işlevi ekleyeceksiniz.

**Talimatlar:**

**Models** klasöründe e-posta, parola ve **"Remember Me"** özelliklerini içeren `LoginViewModel.cs` dosyasını oluşturun.

`AccountController`’ı, giriş formunu render etmek ve giriş işlemini işlemek için bir login action ekleyecek şekilde güncelleyin.

**Views/Shared** klasöründe giriş formunu göstermek için `Login.cshtml` dosyasını oluşturun.

---

## 🧪 Adım 7: Uygulamayı Test Etme

Kayıt ve kimlik doğrulama işlevlerini test edeceksiniz.

**Talimatlar:**

Uygulamayı çalıştırın:

```bash
dotnet run
```

Tarayıcınızı açın ve şu adrese gidin:

```text
https://localhost:[port number]
```

Kullanıcı kaydını test edin:

* Kayıt formunu doldurun.
* Yeni kullanıcının bellekte saklandığını doğrulayın.

Giriş sürecini test edin:

* Doğru kimlik bilgileriyle giriş yapın.
* **"Remember Me"** işlevini test edin.

Uygulamayı yeniden başlatın ve verinin kaybolduğunu gözlemleyin ( *in-memory depolama davranışı* ).

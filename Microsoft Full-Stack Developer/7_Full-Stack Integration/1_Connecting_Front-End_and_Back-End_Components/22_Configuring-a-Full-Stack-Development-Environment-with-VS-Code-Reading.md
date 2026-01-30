## 🛠️ Configuring a Full-Stack Development Environment with VS Code

---

## 👋 Introduction

Bu özet, bir kod editörü içinde front-end ve back-end araçlarını, veritabanı entegrasyonunu ve proje organizasyonunu bir araya getirerek full-stack geliştirme ortamı kurmak için gereken temel adımları açıklar.

---

## 🧰 Steps to Set Up

---

## 📥 Install Development Tools

* Birincil kod editörü olarak  **Visual Studio Code (VS Code)** ’u indirin ve yükleyin.
* Geliştirme yapabilmek için  **.NET SDK** ’yı yükleyin.

---

## ⚙️ Configure the Development Environment

* VS Code’a gerekli eklentileri ekleyin; örneğin .NET desteği için **C# Dev Kit** ve HTTP istekleri için  **REST Client** .
* Terminali kullanarak .NET sürümünü kontrol edip kurulumu doğrulayın:

```bash
dotnet --version
```

---

## 🧩 Set Up Projects

* Terminali kullanarak bir Blazor front-end projesi başlatın:

```bash
dotnet new blazor
```

* Bir Minimal API back-end projesi oluşturun:

```bash
dotnet new web
```

* Yönetimi kolaylaştırmak ve VS Code içinde bağlantıyı düzenlemek için projeleri ayrı klasörlerde organize edin.

---

## 🗄️ Database Integration

* Back-end tarafında veritabanı etkileşimleri için **Entity Framework Core (EF Core)** kullanarak **SQL Server** entegrasyonu yapın.

---

## ▶️ Run and Test Applications

* Front-end ve back-end projelerini ayrı ayrı `dotnet watch` komutlarıyla çalıştırın.

```bash
dotnet watch
```

* Port çakışması varsa, back-end port ayarlarını düzenleyin.

---

## ✅ Conclusion

Bu adımları izlemek, işlevsel ve düzenli bir full-stack geliştirme ortamı sağlar. Bu kurulum;  **Blazor** ,  **Minimal APIs** , **SQL Server** ve **Visual Studio Code** gibi araçlarla sağlam ve ölçeklenebilir uygulamalar geliştirmenizi destekler.

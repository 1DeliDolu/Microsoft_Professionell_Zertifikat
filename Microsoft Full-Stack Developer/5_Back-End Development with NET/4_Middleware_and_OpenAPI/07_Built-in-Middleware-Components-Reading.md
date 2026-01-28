## 🧰 Built-in Middleware Components

---

## 📌 Introduction

ASP.NET Core, web isteklerini ( *requests* ) ve yanıtlarını ( *responses* ) yönetmeyi kolaylaştıran, uygulama güvenliğini ve performansını artıran çeşitli yerleşik ( *built-in* ) *middleware* bileşenleri sunar.

---

## 🧩 Key Components

---

## 🧯 Exception Handling Middleware

Uygulama hatalarını, kullanıcıları özel ( *custom* ) bir hata sayfasına yönlendirerek yönetir; hassas ayrıntıları korurken hataları geliştiricilerin incelemesi için *logging* eder.

Üretim ( *production* ) için  **`app.UseExceptionHandler("/Home/Error")`** , geliştirme ( *development* ) için ise ayrıntılı hata ayıklama bilgileri sağlamak üzere **`app.UseDeveloperExceptionPage()`** kullanılır.

```csharp
app.UseExceptionHandler("/Home/Error");
```

```csharp
app.UseDeveloperExceptionPage();
```

---

## 🔐 Authentication Middleware

Kısıtlı bölümlere erişimi kontrol etmek için kullanıcı kimliğini doğrular. Yalnızca oturum açmış kullanıcıların korumalı alanlara erişmesini sağlamak amacıyla **`Startup.cs`** dosyasında  *request pipeline* ’a **`app.UseAuthentication()`** ekleyerek etkinleştirilir.

```csharp
app.UseAuthentication();
```

---

## 🛡️ Authorization Middleware

Kullanıcı izinlerini düzenler ve yalnızca yetkili kullanıcıların erişmesine izin verir. **`app.UseAuthorization()`** ile uygulanır ve tanımlı politikalar ( *policies* ) üzerinden kullanıcı erişim haklarını zorunlu kılarak  *authentication* ’ı tamamlar.

```csharp
app.UseAuthorization();
```

---

## 🧾 Logging Middleware

Önemli olayları ve hataları kaydeder; izleme ( *monitoring* ) ve sorun giderme ( *troubleshooting* ) için uygulama davranışı hakkında içgörü sağlar. **`app.UseHttpLogging()`** ile etkinleştirilir ve **`appsettings.json`** içinde seviyeler yapılandırılarak log ayrıntısı kontrol edilir.

```csharp
app.UseHttpLogging();
```

```json
"Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware": "Information"
```

---

## ✅ Conclusion

 *Exception handling* ,  *authentication* , *authorization* ve *logging middleware* uygulanarak ASP.NET Core uygulamaları daha güvenli, daha güvenilir ve daha sürdürülebilir ( *maintainable* ) hâle gelir; bu da duyarlı ( *responsive* ) web uygulamaları inşa etmek için sağlam bir temel sağlar.

## 🧩 Step 1: Yeni Bir ASP.NET Core Web API Projesi Kurma

Visual Studio Code’u açın ve projeniz için yeni bir klasör oluşturun.

Terminali açın ve aşağıdaki komutlarla yeni bir ASP.NET Core Web API projesi oluşturun:

```bash
dotnet new webapi -o MiddlewareOptimizationApp
cd MiddlewareOptimizationApp
```

**Program.cs** dosyasını açın. Middleware bileşenlerini implement etmek için bu dosyayı değiştireceksiniz.

Middleware implementasyonuna odaklanmak için **Controllers** klasöründeki controller dosyalarını silin.

---

## ⚙️ Step 2: HTTP Only Configure Etme

Basitlik için uygulamayı yalnızca HTTP dinleyecek şekilde yapılandırın. Bunun için Program.cs içinde HTTPS’e özel kodları kaldırın. Bu, HTTPS bağlantısı gerektirmeden middleware test edilmesini sağlar.

```csharp
var builder = WebApplication.CreateBuilder(args);

// Configure to listen on HTTP only for simplicity
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5294);
});

var app = builder.Build();
```

Bu kurulum, uygulamanın yalnızca şu adresten HTTP isteklerine yanıt vermesini sağlar:

`http://localhost:5294`

---

## ⚡ Step 3: Performans Optimizasyonu ve Güvenlik için Middleware Tasarlama

Bu adımda learners, performans optimizasyonu ve güvenlik için middleware bileşenleri yazacak. Özellikle:

* **Simulated HTTPS Enforcement** : HTTPS’i simüle etmek için query parametresi kullanın. `secure=true` parametresi yoksa, middleware isteği non-HTTPS gibi engellemelidir.
* **Short-Circuit Unauthorized Access** : Unauthorized request’lerde pipeline’ı erken durdurun.
* **Asynchronous Processing** : I/O operasyonlarını diğer request’leri bloklamadan yönetmek için async metodlar kullanın.
* **Input Validation** : Gelen request verisini doğrulayın ve unsafe input’u sanitize edin.
* **Authentication Checks** : Authenticated olmayan kullanıcıların erişimini kısıtlamak için erken authentication kontrolü ekleyin.
* **Security Event Logging** : Engellenen veya başarısız olan request’ler için security event’leri loglayın.

---

## 🧪 Step 4: Middleware Performans ve Güvenlik Testi

Middleware bileşenlerini yazdıktan sonra aşağıdaki testleri uygulayın. Test için Postman veya `curl` kullanabilir ya da URL’leri doğrudan tarayıcıda deneyebilirsiniz.

### ✅ Test Koşulları

| Condition                       | URL Example                                               | Expected Response                                                    |
| ------------------------------- | --------------------------------------------------------- | -------------------------------------------------------------------- |
| Simulated HTTPS Enforcement     | `http://localhost:5294/`                                | `"Simulated HTTPS Required"`(400)                                  |
| Default Route (authenticated)   | `http://localhost:5294/?secure=true&authenticated=true` | `"Processed Asynchronously"`+`"Final Response from Application"` |
| Unauthorized Access             | `http://localhost:5294/unauthorized?secure=true`        | `"Unauthorized Access"`(401)                                       |
| Invalid Input                   | `http://localhost:5294/?secure=true&input=<script>`     | `"Invalid Input"`(400)                                             |
| Access Denied (Unauthenticated) | `http://localhost:5294/?secure=true`                    | `"Access Denied"`(403)                                             |
| Security Event Log              | 400+ status dönen herhangi bir istek                     | Console’da security event log                                       |

---

## ✅ Ek Test Açıklamaları

---

### ✅ Default Route (Asynchronous Processing Test)

**URL:**
`http://localhost:5294/?secure=true`

**Expected Output:**
`"Processed Asynchronously"` ardından `"Final Response from Application."`

**Explanation:**
Asenkron middleware’in doğru çalıştığını doğrular.

---

### ✅ Simulated HTTPS Enforcement Test

**URL:**
`http://localhost:5294/?secure=true&authenticated=true`

**Expected Output:**
`"Simulated HTTPS Required"` ve **400** status code.

**Explanation:**
`?secure=true` içermeyen request’leri engelleyerek HTTPS enforcement’ı simüle eder.

---

### ✅ Unauthorized Access Test

**URL:**
`http://localhost:5294/unauthorized?secure=true`

**Expected Output:**
`"Unauthorized Access"` ve **401** status code.

**Explanation:**
Unauthorized request’lerin pipeline’da erken durdurulduğunu test eder.

---

### ✅ Invalid Input Test

**URL:**
`http://localhost:5294/?secure=true&input=<script>`

**Expected Output:**
`"Invalid Input"` ve **400** status code.

**Explanation:**
Input validation’ın unsafe input’ları engellediğini test eder.

---

### ✅ Access Denied Test

**URL:**
Örneğin: `http://localhost:5294/?secure=true`

**Expected Output:**
`"Access Denied"` ve **403** status code.

**Explanation:**
Authentication kontrolü ile unauthenticated kullanıcıların engellendiğini doğrular.

---

### ✅ Security Event Log Test

**Trigger:**
400 veya üstü status code dönen herhangi bir request.

**Expected Output:**
VS Code terminalinde şu tarz log mesajları:

```text
Security Event: /unauthorized - Status Code: 401
```

**Explanation:**
Security event logging middleware’in doğru çalıştığını doğrular.

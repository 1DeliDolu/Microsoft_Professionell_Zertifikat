## 🧩 You Try It! Designing and Securing Middleware Components - Answer Key

---

## ⚙️ Step 2: Configure HTTP Only in Program.cs

Uygulamayı yalnızca HTTP dinleyecek şekilde yapılandırmak için Kestrel’i `localhost:5294` üzerinde dinleyecek şekilde ayarlayın.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5294); // HTTP only
});

var app = builder.Build();
```

Bu kurulum, uygulamanın yalnızca şu adresten HTTP isteklerine yanıt vermesini sağlar:

`http://localhost:5294`

---

## 🛡️ Step 3: Design Middleware for Performance Optimization and Security

Bu adımda, performans optimizasyonu ve güvenlik için middleware bileşenleri yazılır. Aşağıda adımlarda istenen her middleware bileşeninin kodu yer alır.

---

## 📝 1. Security Event Logging

Bu logging middleware’ini pipeline’ın en başına koyun ki sonraki middleware’lerin ürettiği status code’lara göre security event’lerini yakalasın.

```csharp
// Middleware to log security events if response status indicates an issue
app.Use(async (context, next) =>
{
    await next(); // Run the next middleware first

    if (context.Response.StatusCode >= 400)
    {
        Console.WriteLine($"Security Event: {context.Request.Path} - Status Code: {context.Response.StatusCode}");
    }
});
```

Bu, 400 veya daha yüksek status code dönen tüm request’leri loglar ve security event takibi için kullanışlıdır.

---

## 🔒 2. Simulated HTTPS Enforcement

Bu middleware, `?secure=true` query parametresini kontrol ederek HTTPS enforcement’ı simüle eder. Parametre yoksa request’i engeller.

```csharp
// Simulated HTTPS Enforcement Middleware
app.Use(async (context, next) =>
{
    // Check for a query parameter to simulate HTTPS enforcement (e.g., "?secure=true")
    if (context.Request.Query["secure"] != "true")
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsync("Simulated HTTPS Required");
        return;
    }

    await next();
});
```

---

## ✅ 3. Input Validation

Bu middleware `input` query parametresini kontrol eder. Yalnızca alfanümerik karakterlere izin verir ve `<script>` içeren input’ları engeller.

```csharp
// Middleware for input validation
app.Use(async (context, next) =>
{
    var input = context.Request.Query["input"];
    if (!IsValidInput(input))
    {
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 400;
            await context.Response.WriteAsync("Invalid Input");
        }
        return;
    }

    await next();
});

// Helper method for input validation
static bool IsValidInput(string input)
{
    // Checks for any unsafe characters or patterns, including "<script>"
    return string.IsNullOrEmpty(input) || (input.All(char.IsLetterOrDigit) && !input.Contains("<script>"));
}
```

Bu middleware, yalnızca güvenli input’un geçmesini sağlar ve `<script>` gibi kötü niyetli pattern’leri bloklar.

---

## ⛔ 4. Unauthorized Access

Bu middleware path’in `/unauthorized` olup olmadığını kontrol eder. Eğer öyleyse 401 status code ile “Unauthorized Access” döner ve pipeline’ı durdurur.

```csharp
// Middleware for short-circuiting unauthorized access
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/unauthorized")
    {
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Unauthorized Access");
        }
        return; // Exit middleware pipeline early if unauthorized
    }
    await next();
});
```

---

## 🔐 5. Simulated Authentication and Secure Cookies

Bu middleware `authenticated=true` query parametresi ile authentication’ı simüle eder. Parametre yoksa 403 ile “Access Denied” döner. Authenticated request’lerde secure cookie set eder.

```csharp
// Middleware for simulated authentication and secure cookies
app.Use(async (context, next) =>
{
    // Simulate authentication with a query parameter (e.g., "?authenticated=true")
    var isAuthenticated = context.Request.Query["authenticated"] == "true";
    if (!isAuthenticated)
    {
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Access Denied");
        }
        return;
    }

    context.Response.Cookies.Append("SecureCookie", "SecureData", new CookieOptions
    {
        HttpOnly = true,
        Secure = true
    });

    await next();
});
```

---

## ⏳ 6. Asynchronous Processing

Bu middleware kısa bir delay ile async processing’i simüle eder ve output’a “Processed Asynchronously” ekler.

```csharp
// Middleware for asynchronous processing
app.Use(async (context, next) =>
{
    await Task.Delay(100); // Simulate async operation
    if (!context.Response.HasStarted)
    {
        await context.Response.WriteAsync("Processed Asynchronously\n");
    }
    await next();
});
```

Bu middleware yalnızca önceki middleware’ler request’in devam etmesine izin verirse çalışır.

---

## ✅ 7. Final Response Middleware

Bu middleware, pipeline’ın sonuna kadar gelen her request için final response döner.

```csharp
// Final Response Middleware
app.Run(async (context) =>
{
    if (!context.Response.HasStarted)
    {
        await context.Response.WriteAsync("Final Response from Application\n");
    }
});
```

Bu sayede tüm middleware’lerden geçen request’ler bir final response alır.

---

## 📄 Full Code for Program.cs

Aşağıda tüm adımların entegre edildiği tam **Program.cs** kodu yer alır:

```csharp
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

// Configure to listen on HTTP only for simplicity
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5294); // HTTP only
});

var app = builder.Build();

// Middleware to log security events if response status indicates an issue
app.Use(async (context, next) =>
{
    await next(); // Run the next middleware first

    if (context.Response.StatusCode >= 400)
    {
        Console.WriteLine($"Security Event: {context.Request.Path} - Status Code: {context.Response.StatusCode}");
    }
});

// Simulated HTTPS Enforcement Middleware
app.Use(async (context, next) =>
{
    // Check for a query parameter to simulate HTTPS enforcement (e.g., "?secure=true")
    if (context.Request.Query["secure"] != "true")
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsync("Simulated HTTPS Required");
        return;
    }

    await next();
});

// Middleware for input validation
app.Use(async (context, next) =>
{
    var input = context.Request.Query["input"];
    if (!IsValidInput(input))
    {
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 400;
            await context.Response.WriteAsync("Invalid Input");
        }
        return;
    }

    await next();
});

// Helper method for input validation
static bool IsValidInput(string input)
{
    // Checks for any unsafe characters or patterns, including "<script>"
    return string.IsNullOrEmpty(input) || (input.All(char.IsLetterOrDigit) && !input.Contains("<script>"));
}

// Middleware for short-circuiting unauthorized access
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/unauthorized")
    {
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Unauthorized Access");
        }
        return; // Exit middleware pipeline early if unauthorized
    }
    await next();
});

// Middleware for simulated authentication and secure cookies
app.Use(async (context, next) =>
{
    // Simulate authentication with a query parameter (e.g., "?authenticated=true")
    var isAuthenticated = context.Request.Query["authenticated"] == "true";
    if (!isAuthenticated)
    {
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Access Denied");
        }
        return;
    }

    context.Response.Cookies.Append("SecureCookie", "SecureData", new CookieOptions
    {
        HttpOnly = true,
        Secure = true
    });

    await next();
});

// Middleware for asynchronous processing
app.Use(async (context, next) =>
{
    await Task.Delay(100); // Simulate async operation
    if (!context.Response.HasStarted)
    {
        await context.Response.WriteAsync("Processed Asynchronously\n");
    }
    await next();
});

// Final Response Middleware
app.Run(async (context) =>
{
    if (!context.Response.HasStarted)
    {
        await context.Response.WriteAsync("Final Response from Application\n");
    }
});

app.Run();
```

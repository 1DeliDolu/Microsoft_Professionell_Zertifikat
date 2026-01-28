## 🗝️ You Try It! Middleware Bileşenlerini Uygulama - Cevap Anahtarı

---

## 🧩 Step 2: Built-In Middleware Configuration

### 🧯 1. Exception Handling Middleware

```csharp
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
else
{
    app.UseDeveloperExceptionPage();
}
```

### 🔐 2. Authentication Middleware

```csharp
app.UseAuthentication();
```

### 🧾 3. HTTP Logging Configuration

**`builder.Services`** içindeki servis yapılandırması:

```csharp
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});
```

HTTP logging middleware ekleme:

```csharp
app.UseHttpLogging();
```

---

## 🧩 Step 3: Custom Middleware

### 🧾 1. Request Path ve Response Status Logging için Middleware

```csharp
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request Path: {context.Request.Path}");
    await next.Invoke();
    Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
});
```

### ⏱️ 2. Request Duration Logging için Middleware

```csharp
app.Use(async (context, next) =>
{
    var startTime = DateTime.UtcNow;
    Console.WriteLine($"Start Time: {startTime}");
    await next.Invoke();
    var duration = DateTime.UtcNow - startTime;
    Console.WriteLine($"Response Time: {duration.TotalMilliseconds} ms");
});
```

---

## 📄 Complete Program.cs Example

Aşağıda, tüm kod eklendikten sonra **Program.cs** dosyasının tamamı yer almaktadır.

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpLogging();

// Custom middleware for logging request path and response status
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request Path: {context.Request.Path}");
    await next.Invoke();
    Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
});

// Custom middleware for tracking request duration
app.Use(async (context, next) =>
{
    var startTime = DateTime.UtcNow;
    Console.WriteLine($"Start Time: {startTime}");
    await next.Invoke();
    var duration = DateTime.UtcNow - startTime;
    Console.WriteLine($"Response Time: {duration.TotalMilliseconds} ms");
});

app.MapGet("/", () => "Hello, ASP.NET Core Middleware!");

app.Run();
```

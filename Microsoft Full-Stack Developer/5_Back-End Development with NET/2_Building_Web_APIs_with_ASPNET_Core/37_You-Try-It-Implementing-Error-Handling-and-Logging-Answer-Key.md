## 🧪 You Try It! Error Handling ve Logging’i Uygulama

### 🎯 Objective

Bu etkinliğin sonunda, *ASP.NET Core* web API projesinde error handling mekanizmalarını uygulayabilecek, built-in ve third-party logging provider’larını kullanarak logging kurabilecek ve log verisini yakalayıp analiz edebileceksiniz.

---

## ✅ You Try It! Implementing Error Handling and Logging - Answer Key

---

## 🧩 Step 2: ErrorHandlingController İçinde Try-Catch Implementasyonu

```csharp
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorHandlingController : ControllerBase
    {
        [HttpGet("division")]
        public IActionResult GetDivisionResult(int numerator, int denominator)
        {
            try
            {
                var result = numerator / denominator;
                return Ok(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return BadRequest("Cannot divide by zero.");
            }
        }
    }
}
```

---

## 🌍 Step 3: Program.cs İçinde Global Error Handling Middleware

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(); // Enables controller support

// Configure logging (optional)
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

// Configure middleware for error handling
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Global exception caught: {ex.Message}");
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync("An unexpected error occurred. Please try again later.");
    }
});

// Enable routing and map controller endpoints
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Maps attribute-defined routes in controllers
});

app.Run();
```

---

## 🪵 Step 4: appsettings.json İçinde Logging Konfigürasyonu

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

---

## 🧾 Step 5: Program.cs İçinde Serilog Konfigürasyonu

```csharp
using Serilog;

var builder = WebApplication.CreateBuilder(args);
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();
```

---

## 🧪 Step 6: Testing

Uygulamanızın request’leri dinlediği URL’yi Terminal (VS Code) penceresinden bulun. Ardından browser açın ve aşağıdaki URL’yi address bar’a girin (VS Code’da görünen port numarasıyla “5139” değerini değiştirin):

```
http://localhost:5139/api/ErrorHandling/division?numerator=10&denominator=0
```

Browser aşağıdaki çıktıyı gösterecektir:

```
Cannot divide by zero.
```

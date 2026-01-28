## 🧩 You Try It! Integrating Swagger and Generating API Clients - Answer Key

---

## 🧩 Step 2: Configuring Swagger

```csharp
// Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));

        Task.Run(() => app.RunAsync());
    }
}
```

---

## 🧩 Step 3: Setting up the API Specification

```csharp
// Controllers/UserController.cs
using Microsoft.AspNetCore.Mvc;

// User model
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    [Produces("application/json")]
    public ActionResult<User> GetUser(int id)
    {
        var user = new User
        {
            Id = id,
            Name = $"User {id}"
        };

        return Ok(user);
    }
}
```

---

## 🧩 Step 4: Generating Client Code with NSwag

```csharp
// ClientGenerator.cs
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using NSwag;
using NSwag.CodeGeneration.CSharp;

public class ClientGenerator
{
    public async Task GenerateClient()
    {
        using var httpClient = new HttpClient();
        var swaggerJson = await httpClient.GetStringAsync("http://localhost:5000/swagger/v1/swagger.json");
        var document = await OpenApiDocument.FromJsonAsync(swaggerJson);

        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = "GeneratedApiClient",
            CSharpGeneratorSettings = { Namespace = "MyApiClientNamespace" }
        };

        var generator = new CSharpClientGenerator(document, settings);
        var code = generator.GenerateFile();

        await File.WriteAllTextAsync("GeneratedApiClient.cs", code);
    }
}
```

---

## 🧩 Step 5: Customizing Client Settings

```csharp
var settings = new CSharpClientGeneratorSettings
{
    ClassName = "CustomApiClient",
    CSharpGeneratorSettings = { Namespace = "CustomNamespace" }
};
```

---

## 🧩 Step 6: Using the Generated Client

```csharp
// Program.cs (Additional Code)

Using CustomNamespace //replace with your namespace

var httpClient = new HttpClient();
var client = new CustomApiClient("http://localhost:5000", httpClient); //replace CustomApiClient with your class name

var user = await client.GetUserAsync(1);
Console.WriteLine($"Fetched User: {user}");
```

---

## 🧪 Testing the Application

---

## 🧪 1. Run the Application and Check Swagger Configuration

Amaç: Swagger’ın doğru kurulduğunu ve API dokümantasyonunu sunduğunu doğrulamak.

```bash
dotnet run
```

Tarayıcıda Swagger UI’a gidin:

`http://localhost:5000/swagger`

Swagger UI’da **GetUser** endpoint’inin göründüğünü ve route’un doğru olduğunu doğrulayın: `api/User/{id}`

---

## 🧪 2. Verify the API Endpoint with Swagger UI

Swagger UI içinde **GetUser** endpoint’ini bulun.

Örnek bir user ID (örn. `1`) girin ve **Try it out** ile çalıştırın.

Başarılı response’da `"User 1"` benzeri bir çıktı görmelisiniz.

---

## 🧪 3. Run the Client Generator

Program.cs içine geçici olarak ekleyin:

```csharp
await new ClientGenerator().GenerateClient();
```

Sonra tekrar çalıştırın:

```bash
dotnet run
```

Çalıştırdıktan sonra proje dizininde `GeneratedApiClient.cs` (veya `CustomApiClient.cs`) dosyasının oluştuğunu doğrulayın.

---

## 🧪 4. Test the Generated Client Code

Program.cs içindeki test kodunu şununla değiştirin:

```csharp
Using CustomNamespace //replace with your namespace

var httpClient = new HttpClient();
var client = new CustomApiClient("http://localhost:5000", httpClient);

var user = await client.UserAsync(1);
Console.WriteLine($"Fetched User: {user}");
```

Sonra çalıştırın:

```bash
dotnet run
```

Konsolda `"Fetched User: User 1"` benzeri bir çıktı beklenir.

---

## 🧪 5. Modify the API and Regenerate the Client

UserController.cs içinde GetUser response’unu değiştirin (örn. `"User ID: {id}"`).

Client’i yeniden üretmek için uygulamayı çalıştırın ve `GenerateClient` çağrısını tekrar kullanın.

Sonra ana programı tekrar çalıştırıp çıktının değişikliği yansıttığını doğrulayın.

---

## 🛠️ Troubleshooting

* **Step 2: Port kontrolü**
  Bu egzersiz boyunca port `5000` kullanılıyor. Terminalde `Now listening on: http://localhost:5000` satırını doğrulayın. Port farklıysa, tüm kodda portu güncelleyin.
* **Step 4: Client generation çalışmıyor**
  `app.Run();` satırından sonra kod çalışmaz. Bu yüzden `app.Run();` yerine şunu kullanın:

```csharp
Task.Run(() => app.RunAsync());
```

* **Step 6: Namespace ve class name uyumu**
  Step 5’te değiştirdiğiniz **namespace** ve **class name** değerleri Program.cs içindeki `using` ve `new CustomApiClient(...)` satırlarıyla birebir aynı olmalıdır.

---

## 📄 Complete Application Code by File

---

## 📄 Program.cs

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Threading.Tasks;
using CustomNamespace; //replace with your custom namespace

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
        app.MapControllers();

        //app.Run();
        Task.Run(() => app.RunAsync());
        //await Task.Delay(3000);
        //await new ClientGenerator().GenerateClient();

        var httpClient = new HttpClient();
        var client = new CustomApiClient("http://localhost:5000", httpClient);
        var user = await client.GetUserAsync(1);
        Console.WriteLine($"Fetched User: {user}");
    }
}
```

---

## 📄 Controllers/UserController.cs

```csharp
using Microsoft.AspNetCore.Mvc;

// User model
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    [Produces("application/json")]
    public ActionResult<User> GetUser(int id)
    {
        var user = new User
        {
            Id = id,
            Name = $"User {id}"
        };

        return Ok(user);
    }
}
```

---

## 📄 ClientGenerator.cs

```csharp
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using NSwag;
using NSwag.CodeGeneration.CSharp;

public class ClientGenerator
{
    public async Task GenerateClient()
    {
        using var httpClient = new HttpClient();
        var swaggerJson = await httpClient.GetStringAsync("http://localhost:5000/swagger/v1/swagger.json");
        var document = await OpenApiDocument.FromJsonAsync(swaggerJson);

        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = "CustomApiClient",
            CSharpGeneratorSettings = { Namespace = "CustomNamespace" }
        };

        var generator = new CSharpClientGenerator(document, settings);
        var code = generator.GenerateFile();

        await File.WriteAllTextAsync("CustomApiClient.cs", code);
    }
}
```

---

## 📄 GeneratedApiClient.cs

Bu dosya NSwag tarafından otomatik üretilir. ClientGenerator çalıştırıldıktan sonra oluşur ve API ile etkileşim kurmak için tamamen typed metotlar içerir.


## 🌐 Harici Kimlik Doğrulama Sağlayıcılarını Entegre Etme

```csharp
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

var clientSecrets = new ClientSecrets
{
    ClientId = builder.Configuration["Authentication:Google:ClientId"],
    ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"],
};

var scopes = new[] { "https://www.googleapis.com/auth/userinfo.profile" };

var dataStorePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
    "DesktopAuth"
);

var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
    clientSecrets,
    scopes,
    "user",
    CancellationToken.None,
    new FileDataStore(dataStorePath)
);
```

```csharp
app.MapGet(
    "/login",
    async context =>
    {
        await context.Response.WriteAsync("Authentication");
    }
);

app.Run();
```

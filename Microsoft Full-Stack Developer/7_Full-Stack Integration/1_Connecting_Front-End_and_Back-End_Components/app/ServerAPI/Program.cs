using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// ...existing code...
// Register DbContext BEFORE building the app
builder.Services.AddDbContext<AppContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);
// ...existing code...

var app = builder.Build();

app.MapGet("/", static () => "Hello World!");
// ...existing code...
app.Run();
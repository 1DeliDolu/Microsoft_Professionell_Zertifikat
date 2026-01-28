using EFCOREMODELAPP3;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the DbContext for design-time and runtime resolution.
builder.Services.AddDbContext<CompanyContext>();

var app = builder.Build();

app.MapGet("/", () => "EF Core model app is running.");

app.Run();

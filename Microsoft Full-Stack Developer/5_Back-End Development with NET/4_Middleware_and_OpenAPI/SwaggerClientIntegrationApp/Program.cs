var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger middleware
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

if (args.Contains("--generate-client", StringComparer.OrdinalIgnoreCase))
{
    var swaggerJsonUrl = "http://localhost:5000/swagger/v1/swagger.json";
    await ClientGenerator.GenerateClientAsync(swaggerJsonUrl, "GeneratedApiClient.cs");
    return;
}

app.Run();

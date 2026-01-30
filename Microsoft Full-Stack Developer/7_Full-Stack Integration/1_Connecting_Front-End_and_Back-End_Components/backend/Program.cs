var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(static options =>
{
    options.AddDefaultPolicy(static builder =>
    {
        builder
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed(static _ => true);
    });
});

var app = builder.Build();
app.UseCors();

//app.UseHttpsRedirection();

app.MapGet(
    "/products",
    static () => new[] { new { Id = 1, Name = "Laptop" }, new { Id = 2, Name = "Phone" } }
);

app.Run();

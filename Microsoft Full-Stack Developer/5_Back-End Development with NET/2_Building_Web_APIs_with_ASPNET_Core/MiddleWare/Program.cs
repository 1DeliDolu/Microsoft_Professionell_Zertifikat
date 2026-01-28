var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(o => { });
var app = builder.Build();

// middleware
//app.UseRouting();
//app.useAuthentication();
//app.UseAuthorization();
//app.UseExceptionHandler();
app.Use(
    async (context, next) =>
    {
        Console.WriteLine("Middleware 1: Incoming Request");
        await next.Invoke();
        Console.WriteLine("Middleware 1: Outgoing Response");
    }
);
app.Use(
    async (context, next) =>
    {
        Console.WriteLine("Middleware 2: Incoming Request");
        await next.Invoke();
        Console.WriteLine("Middleware 2: Outgoing Response");
    }
);

app.MapGet("/", () => "Hello World!");

// hello route
app.MapGet("/hello", () => "Hello from the hello route!");

// app.UseEndpoints

app.Run();

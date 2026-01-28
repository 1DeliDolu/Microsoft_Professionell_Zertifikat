# You Try It! Routing, Attribute Routing, and Dependency Injection - Answer Key

## Step 1: Set Up the Project

1. Open Visual Studio Code, and in the terminal, create a new ASP.NET Core project by running:

   dotnet new web -o DIProject
2. Navigate into the project directory:

   cd DIProject
3. Open Program.cs in the DIProject folder.

## Step 2: Define the Service Interface

1. In the DIProject folder, create a new file named IMyService.cs.
2. Add the following code in IMyService.cs to define the IMyService interface:

public interface IMyService
{
    void LogCreation(string message);
}


## Step 3: Create the Service Implementation

1. In the DIProject folder, create a new file named MyService.cs.
2. Add the following code in MyService.cs to implement the IMyService interface:


using System;

public class MyService : IMyService
{
    private readonly int _serviceId;

    public MyService()
    {
        _serviceId = new Random().Next(100000, 999999); // Generate a random 6-digit number
    }

    public void LogCreation(string message)
    {
        Console.WriteLine($"{message} - Service ID: {_serviceId}");
    }
}



**Explanation**: The MyService class generates a unique ID for each instance and logs messages with the service ID, helping us track the service lifecycle.

## Step 4: Register the Service in Program.cs

1. Open Program.cs and register IMyService as a singleton with the following line:


using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMyService, MyService>();



**Explanation**: Registering IMyService as a singleton ensures that the same instance of MyService is shared across the application.

## Step 5: Add Middleware to Use the Service

1. In Program.cs, add middleware to demonstrate service usage within the request pipeline:


var app = builder.Build();

app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService`<IMyService>`();
    myService.LogCreation("First Middleware");
    await next();
});

app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService `<IMyService>`();
    myService.LogCreation("Second Middleware");
    await next();
});


**Explanation**: This middleware retrieves the IMyService instance and logs its use in two parts of the pipeline. Since IMyService is registered as a singleton, the same instance will be reused.

## Step 6: Create a Route to Access the Service

1. In Program.cs, add a route handler that also uses the IMyService instance:

app.MapGet("/", (IMyService myService) =>
{
    myService.LogCreation("Root");
    return Results.Ok("Check the console for service creation logs.");
});


**Explanation**: This route logs a message with LogCreation and returns a message indicating that logs should appear in the console.

## Step 7: Run the Application and Verify Output

1. In the terminal, start the application by running:

   dotnet run
2. Once the application is running, open a browser or Postman and navigate to http://localhost:5000/.

**Expected Console Output**

First Middleware - Service ID: 123456
Second Middleware - Service ID: 123456
Root - Service ID: 123456

**Explanation**: The Service ID should be the same in all three logs, confirming that a single instance is used throughout the request.

## Optional Step: Experiment with Different Service Lifetimes

1. In Program.cs, try changing AddSingleton to AddScoped or AddTransient to observe different behavior.
   1. AddScoped: Each request gets a new instance of MyService, but the same instance is shared across the request.
   2. AddTransient: A new instance of MyService is created each time it is requested, even within the same request.
2. Restart the application and observe the console output when accessing /.

**Expected Output with **AddScoped: The service ID is consistent within a single request but changes across different requests.

**Expected Output with **AddTransient: Each call to LogCreation generates a new Service ID, showing that a new instance is created each time.

## Complete Program.cs


using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;

var builder = WebApplication.CreateBuilder(args);

// Register services with different lifetimes
// Uncomment one at a time to test each scope

// builder.Services.AddSingleton<IMyService, MyService>();  // Singleton
// builder.Services.AddScoped<IMyService, MyService>();    // Scoped
builder.Services.AddTransient<IMyService, MyService>();   // Transient

var app = builder.Build();

// Middleware to demonstrate lifecycle in multiple parts of the pipeline
app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService`<IMyService>`();
    myService.LogCreation("First Middleware");
    await next();
});

app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService`<IMyService>`();
    myService.LogCreation("Second Middleware");
    await next();
});

// Final endpoint to demonstrate service lifecycle in the request
app.MapGet("/", (IMyService myService) =>
{
    myService.LogCreation("Root");
    return Results.Ok("Check the console for service creation logs.");
});

app.Run();

public interface IMyService
{
    void LogCreation(string message);
}

public class MyService : IMyService
{
    private readonly int _serviceId;

    public MyService()
    {
        _serviceId = new Random().Next(100000, 999999); // Generate a random 6-digit number
    }

    public void LogCreation(string message)
    {
        Console.WriteLine($"{message} - Service ID: {_serviceId}");
    }
}

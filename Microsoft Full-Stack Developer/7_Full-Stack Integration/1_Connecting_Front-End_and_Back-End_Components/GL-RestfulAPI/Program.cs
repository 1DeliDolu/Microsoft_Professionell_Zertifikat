using System.IO.Pipelines;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing",
    "Bracing",
    "Chilly",
    "Cool",
    "Mild",
    "Warm",
    "Balmy",
    "Hot",
    "Sweltering",
    "Scorching",
};

app.MapGet(
        "/weatherforecast",
        () =>
        {
            var forecast = Enumerable
                .Range(1, 5)
                .Select(index => new WeatherForecast(
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
                .ToArray();
            return forecast;
        }
    )
    .WithName("GetWeatherForecast");
var counters = new List<Counter>();

app.MapGet(
    "counters",
    (Counter request) =>
    {
        var ConcurrentExclusiveSchedulerPair = new Counter
        {
            ID = request.ID,
            Name = request.Name,
            Count = request.Count,
        };
        counters.Add(ConcurrentExclusiveSchedulerPair);
        return Results.Created(
            $"/counters/{ConcurrentExclusiveSchedulerPair.ID}",
            ConcurrentExclusiveSchedulerPair
        );
    }
);

app.MapGet(
    "counters",
    () =>
    {
        return counters;
    }
);

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

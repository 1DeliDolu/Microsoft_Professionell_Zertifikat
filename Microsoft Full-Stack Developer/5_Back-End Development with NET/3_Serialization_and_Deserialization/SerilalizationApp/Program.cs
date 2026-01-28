using System.Text.Json;
using System.Xml.Serialization;

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

var samplePerson = new Person { Username = "Alice", UserAge = 30 };

var serializerOptions = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
};

app.MapGet("/", () => "I am root");

app.MapGet(
    "/manual-json",
    () =>
    {
        var jsonString = JsonSerializer.Serialize(samplePerson);
        return TypedResults.Text(jsonString, "application/json");
    }
);

app.MapGet(
    "/custom-serializer",
    () =>
    {
        var customJsonString = JsonSerializer.Serialize(samplePerson, serializerOptions);
        return TypedResults.Text(customJsonString, "application/json");
    }
);

app.MapGet("/json", () => TypedResults.Json(samplePerson));

app.MapGet("/auto", () => samplePerson);

// XML Serialization
app.MapGet(
    "/xml",
    () =>
    {
        var xmlSerializer = new XmlSerializer(typeof(Person));
        var stringWriter = new StringWriter();
        xmlSerializer.Serialize(stringWriter, samplePerson);
        var xmlOutput = stringWriter.ToString();

        return TypedResults.Text(xmlOutput, "application/xml");
    }
);

app.Run();

public sealed class Person
{
    public required string Username { get; init; }
    public required int UserAge { get; init; }
}

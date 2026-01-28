using System.Net;
using System.Text.Json;

const string ApiBaseUrl = "http://localhost:5230";
const string SwaggerJsonPath = "/swagger/v1/swagger.json";
const string GeneratedClientFile = "BlogApiClient.cs";

var runManualRequest = args.Contains("--manual", StringComparer.OrdinalIgnoreCase);
var runGenerator = args.Contains("--generate", StringComparer.OrdinalIgnoreCase);

using var httpClient = new HttpClient();

if (runManualRequest)
{
    var blogs = await FetchBlogsManuallyAsync(httpClient, ApiBaseUrl);
    if (blogs is not null)
    {
        foreach (var blog in blogs)
        {
            Console.WriteLine($"{blog.Title}: {blog.Body}");
        }
    }
}

if (runGenerator)
{
    var generator = new SwaggerClientGenerator();
    var swaggerJsonUrl = $"{ApiBaseUrl}{SwaggerJsonPath}";
    await generator.GenerateClientAsync(httpClient, swaggerJsonUrl, GeneratedClientFile);
    Console.WriteLine($"Generated client: {GeneratedClientFile}");
}

static async Task<List<Blog>?> FetchBlogsManuallyAsync(HttpClient httpClient, string apiBaseUrl)
{
    var httpResults = await httpClient.GetAsync($"{apiBaseUrl}/blogs");
    if (httpResults.StatusCode != HttpStatusCode.OK)
    {
        Console.WriteLine("Failed to fetch blogs.");
        return null;
    }

    await using var stream = await httpResults.Content.ReadAsStreamAsync();
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    return await JsonSerializer.DeserializeAsync<List<Blog>>(stream, options);
}

class Blog
{
    public required string Title { get; set; }
    public required string Body { get; set; }
}

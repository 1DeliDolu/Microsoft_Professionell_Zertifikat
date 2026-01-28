using NSwag;
using NSwag.CodeGeneration.CSharp;

public class SwaggerClientGenerator
{
    public async Task GenerateClientAsync(HttpClient httpClient, string swaggerJsonUrl, string outputPath)
    {
        var swaggerJson = await httpClient.GetStringAsync(swaggerJsonUrl);
        var document = await OpenApiDocument.FromJsonAsync(swaggerJson);

        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = "BlogApiClient",
            CSharpGeneratorSettings =
            {
                Namespace = "BlogApi"
            }
        };

        var generator = new CSharpClientGenerator(document, settings);
        var code = generator.GenerateFile();

        await File.WriteAllTextAsync(outputPath, code);
    }
}

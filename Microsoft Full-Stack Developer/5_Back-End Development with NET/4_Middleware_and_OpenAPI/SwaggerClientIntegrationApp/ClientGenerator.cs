using NSwag;
using NSwag.CodeGeneration.CSharp;

public static class ClientGenerator
{
    public static async Task GenerateClientAsync(string swaggerJsonUrl, string outputPath)
    {
        using var httpClient = new HttpClient();
        var swaggerJson = await httpClient.GetStringAsync(swaggerJsonUrl);
        var document = await OpenApiDocument.FromJsonAsync(swaggerJson);

        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = "OctoberApiClient",
            CSharpGeneratorSettings =
            {
                Namespace = "MyClientNamespace"
            }
        };

        var generator = new CSharpClientGenerator(document, settings);
        var code = generator.GenerateFile();
        await File.WriteAllTextAsync(outputPath, code);
    }
}

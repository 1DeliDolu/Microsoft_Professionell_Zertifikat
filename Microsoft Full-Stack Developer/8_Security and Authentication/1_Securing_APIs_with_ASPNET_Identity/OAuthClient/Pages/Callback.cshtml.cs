using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace OAuthClient.Pages
{
    public class CallbackModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CallbackModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public string? AccessToken { get; private set; }
        public string? TokenType { get; private set; }
        public int? ExpiresIn { get; private set; }
        public string? Error { get; private set; }

        public async Task OnGet([FromQuery] string? code, [FromQuery] string? state)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                Error = "Missing 'code' query parameter.";
                return;
            }

            var client = _httpClientFactory.CreateClient();

            var response = await client.PostAsync(
                "http://localhost:5000/oauth/token",
                new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("code", code),
                    new KeyValuePair<string, string>("client_id", "client_app")
                })
            );

            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                Error = $"Token request failed ({(int)response.StatusCode}): {content}";
                return;
            }

            using var doc = JsonDocument.Parse(content);
            var root = doc.RootElement;

            AccessToken = root.GetProperty("access_token").GetString();
            TokenType = root.GetProperty("token_type").GetString();
            ExpiresIn = root.GetProperty("expires_in").GetInt32();
        }
    }
}

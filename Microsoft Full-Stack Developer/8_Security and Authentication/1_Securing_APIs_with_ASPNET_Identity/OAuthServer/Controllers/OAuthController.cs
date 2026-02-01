using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Concurrent;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OAuthServer.Controllers
{
    [ApiController]
    [Route("oauth")]
    public class OAuthController : ControllerBase
    {
        private static readonly ConcurrentDictionary<string, (string ClientId, DateTime ExpiresAt)> _codes = new();

        // Demo key
        private const string SigningKey = "super_secret_demo_key_change_me_1234567890";

        // HTTP issuer (senin server http://localhost:5000)
        private const string Issuer = "http://localhost:5000";
        private const string Audience = "oauth-client";

        [HttpGet("authorize")]
        public IActionResult Authorize(
            [FromQuery(Name = "response_type")] string responseType,
            [FromQuery(Name = "client_id")] string clientId,
            [FromQuery(Name = "redirect_uri")] string redirectUri,
            [FromQuery] string? state = null)
        {
            if (responseType != "code")
                return BadRequest(new { error = "unsupported_response_type" });

            if (string.IsNullOrWhiteSpace(clientId) || string.IsNullOrWhiteSpace(redirectUri))
                return BadRequest(new { error = "invalid_request" });

            if (clientId != "client_app")
                return BadRequest(new { error = "unauthorized_client" });

            var code = Guid.NewGuid().ToString("N");
            _codes[code] = (clientId, DateTime.UtcNow.AddMinutes(2));

            var sep = redirectUri.Contains('?') ? "&" : "?";
            var url = $"{redirectUri}{sep}code={Uri.EscapeDataString(code)}";

            if (!string.IsNullOrEmpty(state))
                url += $"&state={Uri.EscapeDataString(state)}";

            return Redirect(url);
        }

        [HttpPost("token")]
        public IActionResult Token([FromForm] string code, [FromForm(Name = "client_id")] string clientId)
        {
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(clientId))
                return BadRequest(new { error = "invalid_request" });

            if (!_codes.TryRemove(code, out var entry))
                return BadRequest(new { error = "invalid_grant" });

            if (entry.ClientId != clientId)
                return BadRequest(new { error = "invalid_client" });

            if (entry.ExpiresAt < DateTime.UtcNow)
                return BadRequest(new { error = "invalid_grant", error_description = "code_expired" });

            var now = DateTime.UtcNow;
            var expires = now.AddMinutes(60);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, "demo-user"),
                new Claim("client_id", clientId),
                new Claim(JwtRegisteredClaimNames.Iat,
                    new DateTimeOffset(now).ToUnixTimeSeconds().ToString(),
                    ClaimValueTypes.Integer64)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SigningKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims: claims,
                notBefore: now,
                expires: expires,
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new
            {
                access_token = jwt,
                token_type = "Bearer",
                expires_in = (int)(expires - now).TotalSeconds
            });
        }
    }
}

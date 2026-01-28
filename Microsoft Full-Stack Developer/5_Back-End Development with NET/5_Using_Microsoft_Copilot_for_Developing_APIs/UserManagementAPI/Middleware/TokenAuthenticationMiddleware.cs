sealed class TokenAuthenticationMiddleware
{
    private const string Scheme = "Bearer ";
    private readonly RequestDelegate _next;
    private readonly ILogger<TokenAuthenticationMiddleware> _logger;
    private readonly string _token;

    public TokenAuthenticationMiddleware(RequestDelegate next, ILogger<TokenAuthenticationMiddleware> logger, IConfiguration configuration)
    {
        _next = next;
        _logger = logger;
        _token = configuration["Auth:Token"] ?? "dev-token-123";
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (IsAnonymousAllowed(context.Request.Path))
        {
            await _next(context);
            return;
        }

        var authHeader = context.Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authHeader) || !authHeader.StartsWith(Scheme, StringComparison.OrdinalIgnoreCase))
        {
            await DenyAsync(context);
            return;
        }

        var token = authHeader.Substring(Scheme.Length).Trim();
        if (!string.Equals(token, _token, StringComparison.Ordinal))
        {
            await DenyAsync(context);
            return;
        }

        await _next(context);
    }

    private static bool IsAnonymousAllowed(PathString path)
    {
        return path.StartsWithSegments("/openapi") || path.StartsWithSegments("/swagger");
    }

    private async Task DenyAsync(HttpContext context)
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsJsonAsync(new { error = "Unauthorized." });

        _logger.LogWarning("Unauthorized request {Method} {Path} responded {StatusCode}.",
            context.Request.Method,
            context.Request.Path,
            context.Response.StatusCode);
    }
}

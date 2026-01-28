sealed class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

    public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var method = context.Request.Method;
        var path = context.Request.Path;

        try
        {
            await _next(context);
            _logger.LogInformation("HTTP {Method} {Path} responded {StatusCode}.", method, path, context.Response.StatusCode);
        }
        catch (Exception)
        {
            _logger.LogError("HTTP {Method} {Path} threw an exception and responded {StatusCode}.",
                method,
                path,
                StatusCodes.Status500InternalServerError);
            throw;
        }
    }
}

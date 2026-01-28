var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet(
    "/users/{userId}/posts/{slug}",
    (int userId, string slug) =>
    {
        return $"User ID: {userId}, Post Slug: {slug}";
    }
);

app.MapGet(
    "/products/{id:int:min(0)}",
    (int id) =>
    {
        return $"Product ID: {id}";
    }
);

app.MapGet(
    "/report/{year?}",
    (int year = 2016) =>
    {
        return $"Report for year: {year}";
    }
);

app.MapGet(
    "/files/{*filePath}",
    (string filePath) =>
    {
        return filePath;
    }
);

app.MapGet(
    "/search",
    (string? q, int page = 1) =>
    {
        return $"Searching for {q} on page {page}";
    }
);

app.MapGet(
    "/store/{category}/{productId?}/{*extraPath}",
    (string category, int? productId, string? extraPath, bool inStock = true) =>
    {
        var safeProductId = productId?.ToString() ?? "none";
        var safeExtraPath = string.IsNullOrWhiteSpace(extraPath) ? "none" : extraPath;

        return $"Category: {category}, Product ID: {safeProductId}, Extra Path: {safeExtraPath}, In Stock: {inStock}";
    }
);

app.Run();

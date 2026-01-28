using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Services for Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger only in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var blogs = new List<Blog>
{
    new Blog { Id = 1, Title = "Hello Swagger", Body = "First post" },
    new Blog { Id = 2, Title = "Minimal API", Body = "Typed results and OpenAPI" }
};

app.MapGet("/", () => "Swagger Integration API")
    .ExcludeFromDescription();

app.MapGet("/blogs", () => TypedResults.Ok(blogs))
    .WithOpenApi(operation =>
    {
        operation.Summary = "Get all blogs";
        operation.Description = "Returns all blog posts.";
        return operation;
    });

Results<Ok<Blog>, NotFound> GetBlog(int id)
{
    var blog = blogs.FirstOrDefault(b => b.Id == id);
    return blog is null ? TypedResults.NotFound() : TypedResults.Ok(blog);
}

app.MapGet("/blogs/{id:int}", GetBlog)
    .WithOpenApi(operation =>
    {
        operation.Summary = "Get single blog";
        operation.Description = "Returns a single blog.";
        if (operation.Parameters is { Count: > 0 })
        {
            operation.Parameters[0].Description = "ID of the blog to retrieve.";
        }
        return operation;
    });

Results<Created<Blog>, BadRequest<string>> CreateBlog(BlogInput input)
{
    if (string.IsNullOrWhiteSpace(input.Title))
    {
        return TypedResults.BadRequest("Title is required.");
    }

    var nextId = blogs.Count == 0 ? 1 : blogs.Max(b => b.Id) + 1;
    var blog = new Blog { Id = nextId, Title = input.Title, Body = input.Body };
    blogs.Add(blog);
    return TypedResults.Created($"/blogs/{blog.Id}", blog);
}

app.MapPost("/blogs", CreateBlog)
    .WithOpenApi(operation =>
    {
        operation.Summary = "Create blog";
        operation.Description = "Creates a new blog post.";
        return operation;
    });

Results<NoContent, NotFound> UpdateBlog(int id, BlogInput input)
{
    var blog = blogs.FirstOrDefault(b => b.Id == id);
    if (blog is null)
    {
        return TypedResults.NotFound();
    }

    blog.Title = input.Title;
    blog.Body = input.Body;
    return TypedResults.NoContent();
}

app.MapPut("/blogs/{id:int}", UpdateBlog)
    .WithOpenApi(operation =>
    {
        operation.Summary = "Update blog";
        operation.Description = "Updates an existing blog post.";
        return operation;
    });

Results<NoContent, NotFound> DeleteBlog(int id)
{
    var blog = blogs.FirstOrDefault(b => b.Id == id);
    if (blog is null)
    {
        return TypedResults.NotFound();
    }

    blogs.Remove(blog);
    return TypedResults.NoContent();
}

app.MapDelete("/blogs/{id:int}", DeleteBlog)
    .WithOpenApi(operation =>
    {
        operation.Summary = "Delete blog";
        operation.Description = "Deletes a blog post.";
        return operation;
    });

app.Run();

record Blog
{
    public int Id { get; init; }
    public string? Title { get; set; }
    public string? Body { get; set; }
}

record BlogInput(string? Title, string? Body);

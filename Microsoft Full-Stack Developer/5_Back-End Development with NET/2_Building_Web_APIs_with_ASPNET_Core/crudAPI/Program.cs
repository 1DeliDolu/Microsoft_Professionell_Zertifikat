var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var blogs = new List<Blog>
{
    new Blog { Title = "My First Post", Body = "This is my first post" },
    new Blog { Title = "My Second Post", Body = "This is my second post" },
};

app.MapGet("/", () => "I am root!");

// Get all blogs
app.MapGet("/blogs", () => blogs);

// Get blog by index
app.MapGet(
    "/blogs/{index:int}",
    (int index) =>
    {
        if (index < 0)
        {
            return Results.NotFound("Blog not found - index less than zero");
        }
        else if (index >= blogs.Count)
        {
            return Results.NotFound("Blog not found - index exceeds blog count");
        }
        else
        {
            return Results.Ok(blogs[index]);
        }
    }
);

// add a new blog
app.MapPost(
    "/blogs",
    (Blog blog) =>
    {
        blogs.Add(blog);
        return Results.Created($"/blogs/{blogs.Count - 1}", blog);
    }
);

// delete a blog by index
app.MapDelete(
    "/blogs/{index:int}",
    (int index) =>
    {
        if (index < 0)
        {
            return Results.NotFound("Blog not found - index less than zero");
        }
        else if (index >= blogs.Count)
        {
            return Results.NotFound("Blog not found - index exceeds blog count");
        }
        else
        {
            var blog = blogs[index];
            blogs.RemoveAt(index);
            return Results.Ok(blog);
        }
    }
);

// update a blog by index
app.MapPut(
    "/blogs/{index:int}",
    (int index, Blog updatedBlog) =>
    {
        if (index < 0)
        {
            return Results.NotFound("Blog not found - index less than zero");
        }
        else if (index >= blogs.Count)
        {
            return Results.NotFound("Blog not found - index exceeds blog count");
        }
        else
        {
            blogs[index] = updatedBlog;
            return Results.Ok(updatedBlog);
        }
    }
);

app.Run();

public class Blog
{
    public required string Title { get; set; }
    public required string Body { get; set; }
}

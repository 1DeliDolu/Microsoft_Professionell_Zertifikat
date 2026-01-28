var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<IUserRepository, InMemoryUserRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<TokenAuthenticationMiddleware>();
app.UseMiddleware<RequestResponseLoggingMiddleware>();

app.MapGet("/users", (int? skip, int? take, IUserRepository repo) =>
    {
        var paging = Paging.Normalize(skip, take, out var error);
        if (error is not null)
        {
            return Results.BadRequest(new { message = error });
        }

        var users = repo.GetAll(paging.Skip, paging.Take).ToList();
        var response = new PagedResponse<User>(users, repo.Count, paging.Skip, paging.Take);
        return Results.Ok(response);
    })
    .WithName("GetUsers")
    .WithOpenApi();

app.MapGet("/users/{id:guid}", (Guid id, IUserRepository repo) =>
    {
        var user = repo.GetById(id);
        return user is null ? Results.NotFound() : Results.Ok(user);
    })
    .WithName("GetUserById")
    .WithOpenApi();

app.MapPost("/users", (CreateUserRequest? request, IUserRepository repo) =>
    {
        if (request is null)
        {
            return Results.BadRequest(new { message = "Request body is required." });
        }

        var validation = UserValidator.ValidateCreate(request, repo);
        if (validation is not null)
        {
            return Results.BadRequest(new { message = validation });
        }

        var user = repo.Add(request);
        return Results.CreatedAtRoute("GetUserById", new { id = user.Id }, user);
    })
    .WithName("CreateUser")
    .WithOpenApi();

app.MapPut("/users/{id:guid}", (Guid id, UpdateUserRequest? request, IUserRepository repo) =>
    {
        if (request is null)
        {
            return Results.BadRequest(new { message = "Request body is required." });
        }

        var validation = UserValidator.ValidateUpdate(request, repo, id);
        if (validation is not null)
        {
            return Results.BadRequest(new { message = validation });
        }

        if (!repo.Update(id, request, out _))
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    })
    .WithName("UpdateUser")
    .WithOpenApi();

app.MapDelete("/users/{id:guid}", (Guid id, IUserRepository repo) =>
    {
        if (!repo.Delete(id))
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    })
    .WithName("DeleteUser")
    .WithOpenApi();

app.Run();

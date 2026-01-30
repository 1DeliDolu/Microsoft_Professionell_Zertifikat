var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var tasks = new List<TaskItem>();
var nextId = 1;

app.MapGet("/tasks", () => tasks);

app.MapPost(
    "/tasks",
    (TaskItemCreate create) =>
    {
        var task = new TaskItem(nextId++, create.Title, create.IsComplete);
        tasks.Add(task);
        return Results.Created($"/tasks/{task.Id}", task);
    }
);

app.MapPut(
    "/tasks/{id:int}",
    (int id, TaskItemUpdate update) =>
    {
        var index = tasks.FindIndex(t => t.Id == id);
        if (index == -1)
        {
            return Results.NotFound();
        }

        var updated = tasks[index] with { Title = update.Title, IsComplete = update.IsComplete };
        tasks[index] = updated;
        return Results.Ok(updated);
    }
);

app.MapDelete(
    "/tasks/{id:int}",
    (int id) =>
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task is null)
        {
            return Results.NotFound();
        }

        tasks.Remove(task);
        return Results.Ok(task);
    }
);

app.Run();

record TaskItem(int Id, string Title, bool IsComplete);

record TaskItemCreate(string Title, bool IsComplete);

record TaskItemUpdate(string Title, bool IsComplete);

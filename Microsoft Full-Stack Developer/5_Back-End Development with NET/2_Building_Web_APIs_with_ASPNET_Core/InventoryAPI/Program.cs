var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Item> items = new List<Item>
{
    new Item
    {
        Id = Guid.NewGuid(),
        Name = "Item1",
        Price = 9.99M,
        CreatedDate = DateTimeOffset.UtcNow,
    },
    new Item
    {
        Id = Guid.NewGuid(),
        Name = "Item2",
        Price = 19.99M,
        CreatedDate = DateTimeOffset.UtcNow,
    },
    new Item
    {
        Id = Guid.NewGuid(),
        Name = "Item3",
        Price = 29.99M,
        CreatedDate = DateTimeOffset.UtcNow,
    },
};

// all item route
app.MapGet("/items", () => items);

// single item route
app.MapGet(
    "/items/{id}",
    (Guid id) =>
    {
        var item = items.FirstOrDefault(i => i.Id == id);
        return item is not null ? Results.Ok(item) : Results.NotFound();
    }
);

// new item route
app.MapPost(
    "/items",
    (Item newItem) =>
    {
        newItem.Id = Guid.NewGuid();
        newItem.CreatedDate = DateTimeOffset.UtcNow;
        items.Add(newItem);
        return Results.Created($"/items/{newItem.Id}", newItem);
    }
);

// update item route
app.MapPut(
    "/items/{id}",
    (Guid id, Item updatedItem) =>
    {
        var existingItem = items.FirstOrDefault(i => i.Id == id);
        if (existingItem is null)
        {
            return Results.NotFound();
        }
        existingItem.Name = updatedItem.Name;
        existingItem.Price = updatedItem.Price;
        return Results.NoContent();
    }
);

// delete item route
app.MapDelete(
    "/items/{id}",
    (Guid id) =>
    {
        var existingItem = items.FirstOrDefault(i => i.Id == id);
        if (existingItem is null)
        {
            return Results.NotFound();
        }
        items.Remove(existingItem);
        return Results.NoContent();
    }
);

app.MapGet("/", () => "Hello World!");

app.Run();

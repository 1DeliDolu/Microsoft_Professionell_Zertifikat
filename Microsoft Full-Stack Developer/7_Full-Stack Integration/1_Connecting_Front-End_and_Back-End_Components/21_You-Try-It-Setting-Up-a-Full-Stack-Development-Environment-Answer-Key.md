## 🗝️ You Try It! Setting Up a Full-Stack Development Environment – Answer Key

---

## ✅ Step 1

Kod gerekmez; bu adım projeleri oluşturmaya odaklanır.

---

## ✅ Step 2

Kurulum ve bağımlılıkları şu komutlarla doğrulayın:

```bash
dotnet --version
```

ve gerekli VS Code eklentilerini yükleyin.

---

## ✅ Step 3

Front-end Blazor uygulamasını şu komutla çalıştırın:

```bash
dotnet watch
```

---

## ✅ Step 4

`backend/Program.cs` içine aşağıdaki örnek endpoint’i ekleyin:

```csharp
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().AllowCredentials().SetIsOriginAllowed(_ => true);
    });
});

var app = builder.Build();
app.UseCors();
//app.UseHttpsRedirection();

app.MapGet("/products", () =>
    new[] { new { Id = 1, Name = "Laptop" }, new { Id = 2, Name = "Phone" } });
```

Uygulamayı şu komutla çalıştırın:

```bash
dotnet watch
```

---

## ✅ Step 5

Frontend projesinde aşağıdaki Blazor component’ini ekleyin ( **FetchData.razor** ):

```razor
@inject HttpClient Http
@page "/fetch"

<h3>Products</h3>
@if (products == null)
{
    <p>Loading...</p>
}
else
{
    <ul>
        @foreach (var product in products)
        {
            <li>@product.Name</li>
        }
    </ul>
}

@code {
    private Product[]? products;

    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<Product[]>("https://localhost:[portnumber]/products");
    }

    private class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
```

Her iki uygulamayı çalıştırın ve front-end’in back-end’den çektiği veriyi görüntülediğini doğrulayın.

Tarayıcıda şu adrese gidin:

*[http://localhost:[portnumber]/fetch](http://localhost:%5Bportnumber%5D/fetch)*

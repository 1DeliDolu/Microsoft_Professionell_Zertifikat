## 🗝️ You Try It! Implementing API Consumption in React – Answer Key

---

## ✅ Step 2: Initial Setup

HttpClient’ın dependency injection için register edildiğinden emin olmak için `Program.cs` dosyasında şu satırı kontrol edin:

```csharp
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
```

Yeni bir **FetchData.razor** component’i oluşturun ve HttpClient’ı inject edin. Ayrıca API response’unu yönetmek için bir data model ( **Post** ) tanımlayın:

```razor
@page "/fetchdata"
@inject HttpClient Http

<h3>Posts</h3>

@code {
    // Declare a variable to hold the API response
    private List<Post>? posts;

    // Define the data model for handling API response
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
```

---

## ✅ Step 3: Make the API call

`FetchData.razor` içinde component initialize olduğunda API çağrısı yapın. `async Task` kullanarak isteği yönetin ve Step 2’deki Post değişkenine kaydedin:

```csharp
// Fetch data from the API when the component is initialized
protected override async Task OnInitializedAsync()
{
    // Use HttpClient to call the API endpoint and fetch the data
    posts = await Http.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts");
}
```

---

## ✅ Step 4: Display Data in a User-Friendly Way

`FetchData.razor` içinde bir HTML `<table>` yapısı tanımlayın ve satırları doldurmak için döngü kullanın:

```razor
@if (posts is null)
{
    <p><em>Loading...</em></p>
}
else
{
    <table>
        <thead>
            <tr>
                <th>Post ID</th>
                <th>Title</th>
                <th>Body</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var post in posts)
            {
                <tr>
                    <td>@post.Id</td>
                    <td>@post.Title</td>
                    <td>@post.Body</td>
                </tr>
            }
        </tbody>
    </table>
}
```

---

## ✅ Step 5: Error Handling

`FetchData.razor` dosyasını bir `try-catch` bloğu kullanarak güncelleyin:

```csharp
protected override async Task OnInitializedAsync()
{
    try
    {
        posts = await Http.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error fetching data: {ex.Message}");
        posts = null; // Optional: Set to null to handle rendering conditions.
    }
}
```

---

## ✅ Expected Output

* **Post ID** ,  **Title** , **Body** alanlarını içeren post listesini gösteren bir tablo.
* Fallback mesajları:
  * Loading state: *"Loading..."*
  * Error state: *"Error fetching data. Please try again later."*

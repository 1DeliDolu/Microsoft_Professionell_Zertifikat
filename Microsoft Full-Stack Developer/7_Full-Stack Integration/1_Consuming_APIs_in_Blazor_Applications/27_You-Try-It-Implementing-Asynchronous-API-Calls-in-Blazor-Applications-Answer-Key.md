## 🧪 You Try It! Blazor Uygulamalarında Asenkron API Çağrılarını Uygulama – Cevap Anahtarı

---

## 🛠️ 1. Adım: VS Code’da Blazor Uygulaması Kurulumu

`Program.cs` dosyasında gerekli servis kayıtlarını ekleyin:

```csharp
builder.Services.AddHttpClient();
```

`Program.cs` dosyasının tamamı aşağıdaki gibi olmalıdır:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorComponents<App>();

app.Run();
```

---

## 👤 2. Adım: User Class Tanımlama

`Models` klasörü içinde `User.cs` adlı yeni bir dosya oluşturun ve kullanıcı verisinin yapısını şöyle tanımlayın:

```csharp
namespace AsyncApiBlazorApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
    }
}
```

---

## 🔄 3. Adım: Asenkron API Çağrıları Uygulama

`FetchUsers.razor` bileşenini güncelleyerek `HttpClient` servisini en üste inject edin:

```razor
@inject HttpClient Http
@rendermode InteractiveServer
```

`@code` bloğu içinde fetch metodunu tanımlayın:

```razor
@code {

private async Task LoadUsers()
{
    isLoading = true;
    errorMessage = null;
    users = null;

    try
    {
        users = await Http.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
    }
    catch (Exception ex)
    {
        errorMessage = $"Error fetching data: {ex.Message}";
    }
    finally
    {
        isLoading = false;
    }
}
```

Fetch metodunu tetikleyecek butonu UI’a ekleyin (`@code` bloğunun üstüne):

```razor
<h3>Users</h3>
<button @onclick="LoadUsers">Fetch New Users</button>
```

---

## ⏳ 4. Adım: Loading ve Error State Eklemek

`@code` bloğuna loading ve error için property ekleyin:

```csharp
private bool isLoading = false;
private string? errorMessage = null;
```

Loading mesajını göstermek için:

```razor
@if (isLoading)
{
    <div>Loading...</div>
}
```

Error mesajını göstermek için:

```razor
else if (!string.IsNullOrEmpty(errorMessage))
{
    <p class="error">@errorMessage</p>
}
```

---

## 📊 5. Adım: Veriyi Table Olarak Gösterme

`@code` bloğunda kullanıcı listesini tutacak property:

```csharp
private List<User>? users = null;
```

Veriyi table olarak göstermek için:

```razor
else if (users != null)
{
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>City</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var user in users)
            {
                <tr>
                    <td>@user.Id</td>
                    <td>@user.Name</td>
                    <td>@user.Email</td>
                    <td>@user.Address.City</td>
                </tr>
            }
        </tbody>
    </table>
}
else
{
    <p>No data available.</p>
}
```

---

## ✅ 6. Adım: Uygulamayı Test Etme

Uygulamayı çalıştırın:

```cli
dotnet run
```

---

## 📄 Tüm Adımlar Sonrası `FetchUsers.razor` Tam Hâli

```razor
@page "/fetchusers"
@inject HttpClient Http
@rendermode InteractiveServer

<h3>Users</h3>
<button @onclick="LoadUsers">Fetch New Users</button>

@if (isLoading)
{
    <div>Loading...</div>
}
else if (!string.IsNullOrEmpty(errorMessage))
{
    <p class="error">@errorMessage</p>
}
else if (users != null)
{
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>City</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var user in users)
            {
                <tr>
                    <td>@user.Id</td>
                    <td>@user.Name</td>
                    <td>@user.Email</td>
                    <td>@user.Address.City</td>
                </tr>
            }
        </tbody>
    </table>
}
else
{
    <p>No data available.</p>
}

@code {
    private List<User>? users = null;
    private bool isLoading = false;
    private string? errorMessage = null;

    private async Task LoadUsers()
    {
        isLoading = true;
        errorMessage = null;
        users = null;

        try
        {
            users = await Http.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
        }
        catch (Exception ex)
        {
            errorMessage = $"Error fetching data: {ex.Message}";
        }
        finally
        {
            isLoading = false;
        }
    }
}
```

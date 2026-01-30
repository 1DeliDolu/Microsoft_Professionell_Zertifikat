## 🧰 Başlamadan Önce

Eğer henüz tamamlamadıysanız, lütfen **“You Try It! Implementing API Calls in Blazor Applications”** etkinliğine geri dönün. Bu etkinlikte Blazor’da API çağrıları ve hata yakalama temellerini öğrenmiş olmanız gerekiyor; bu aktivitede aynı proje üzerinde ilerleyip **dinamik state management** ekleyeceksiniz.

---

## 🧩 1. Adım: Blazor Uygulamasını Genişletme

Önceki laboratuvardan kalan **WeatherApp** projesini açın.

* `WeatherFetch.razor` bileşeninin çalıştığını ve weather API’den veri çektiğini doğrulayın.
* `Pages` klasöründe yeni bir Razor bileşeni oluşturun: **`DynamicWeather.razor`**
  (Bu bileşen dinamik güncellemeleri ve state yönetimini göstermek için kullanılacak.)

---

## 🔄 2. Adım: JSON Yanıtını Çekme ve Deserialize Etme

Bu adımda ikinci bir public API’den ( **JSONPlaceholder** ) kullanıcı verisi çekecek ve `DynamicWeather.razor` içine entegre edeceksiniz.

### 📌 API

`https://jsonplaceholder.typicode.com/users`

### 📁 Models Klasörü

Proje kökünde bir klasör oluşturun:

* `Models/`

### 👤 User Modelini Ekleyin

`Models/User.cs` içine:

```csharp
public class User
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required Address Address { get; set; }
}

public class Address
{
    public required string Street { get; set; }
    public required string Suite { get; set; }
    public required string City { get; set; }
    public required string Zipcode { get; set; }
}
```

### 💉 HttpClient Inject Edin ve Kullanıcı Verisini Dinamik Çekin

`Pages/DynamicWeather.razor` içinde `HttpClient` inject edin ve **CancellationToken** ile çakışan istekleri iptal edecek şekilde kullanıcı verisi çekin. Burada istenen kritik noktalar:

* `OnInitializedAsync` içinde ilk fetch
* Yeni fetch başladığında önceki fetch’i iptal etmek (`CancellationTokenSource`)
* `GetFromJsonAsync` ile JSON deserialize etmek

Örnek yapı:

```razor
@page "/dynamicweather"
@inject HttpClient Http

@code {
    private CancellationTokenSource? cts;
    private List<User>? users;

    protected override async Task OnInitializedAsync()
    {
        await FetchUserData();
    }

    private async Task FetchUserData()
    {
        cts?.Cancel();
        cts = new CancellationTokenSource();

        try
        {
            users = await Http.GetFromJsonAsync<List<User>>(
                "https://jsonplaceholder.typicode.com/users",
                cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Previous user request was canceled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching user data: {ex.Message}");
        }
    }
}
```

---

## 🧠 3. Adım: API Veri Güncellemeleri için State Management

Bu adımda, hem weather hem user verisini tutan **paylaşılan state** oluşturup bileşenlerle entegre edeceksiniz.

### 📁 Models Klasörüne WeatherData Ekleyin

`Models/WeatherData.cs`:

```csharp
using System.Text.Json.Serialization;

public class WeatherData
{
    public required Location Location { get; set; }
    public required Current Current { get; set; }
}

public class Location
{
    public required string Name { get; set; }
    public required string Country { get; set; }
}

public class Current
{
    [JsonPropertyName("temp_c")]
    public required double Temp_C { get; set; }
    public required Condition Condition { get; set; }
}

public class Condition
{
    public required string Text { get; set; }

    [JsonPropertyName("icon")]
    public required string Icon { get; set; }
}
```

### 🧩 Services Klasörüne WeatherStateService Ekleyin

`Services/WeatherStateService.cs`:

```csharp
public class WeatherStateService
{
    public WeatherData? Weather { get; private set; }
    public List<User>? Users { get; private set; }

    public event Action? OnChange;

    public void UpdateWeather(WeatherData newWeather)
    {
        Weather = newWeather;
        NotifyStateChanged();
    }

    public void UpdateUsers(List<User> newUsers)
    {
        Users = newUsers;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
```

### 🧾 Program.cs İçinde Service’i Register Edin

```csharp
builder.Services.AddSingleton<WeatherStateService>();
```

### 🔌 DynamicWeather.razor İçinde Service’i Inject Edin ve UI’ı Bağlayın

`StateHasChanged` subscription ekleyin:

```razor
@inject WeatherStateService StateService

@code {
    protected override void OnInitialized()
    {
        StateService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        StateService.OnChange -= StateHasChanged;
    }
}
```

> Bu sayede `StateService.UpdateWeather(...)` veya `StateService.UpdateUsers(...)` çağrıldığında UI otomatik yeniden render olur.

---

## 🖥️ 4. Adım: Yeni API Yanıtlarıyla UI’ın Dinamik Güncellenmesini Test Etme

Bu adımda amaç, state değiştikçe UI’ın dinamik güncellenmesini garanti etmek.

### ✅ Yapılacaklar

* **Her iki API için** (Users ve Weather) **buton** ekleyerek manuel fetch tetikleyin.
* Fetch sırasında **loading indicator** gösterin.
* State güncellendiğinde UI’ın değiştiğini doğrulayın.
* State güncellemesinden sonra UI güncellenmesi için:
  * `StateService.OnChange += StateHasChanged`
  * ve state update sonrası otomatik render

### 🧷 Örnek UI Blokları

```razor
<button @onclick="FetchUserData">Fetch Users</button>
<button @onclick="FetchWeatherData">Fetch Weather</button>

@if (isLoading)
{
    <p>Loading...</p>
}

@if (StateService.Users is not null)
{
    <ul>
        @foreach (var user in StateService.Users)
        {
            <li>@user.Name (@user.Email)</li>
        }
    </ul>
}

@if (StateService.Weather is not null)
{
    <p>Weather: @StateService.Weather.Current.Temp_C°C, @StateService.Weather.Current.Condition.Text</p>
}
```

Ve loading state örneği:

```razor
@code {
    private bool isLoading;

    private async Task FetchWeatherData()
    {
        isLoading = true;
        try
        {
            // weather fetch + StateService.UpdateWeather(...)
        }
        finally
        {
            isLoading = false;
        }
    }
}
```

---

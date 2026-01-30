## 🗝️ Sen Deneyin! Blazor’da API Yanıtlarını İşleme ve Durum Yönetimi - Cevap Anahtarı

---

## 🧩 1. Adım: Blazor Uygulamasını Genişletme

Kod değişikliği gerekmez. Önceki etkinlikteki `WeatherFetch.razor` bileşenini doğrulayın.

---

## 🔄 2. Adım: Farklı Bir Public API’den Gelen JSON Yanıtını Deserialize Etme

Placeholder API yanıtı için aşağıdaki **Users** modelini ekleyin:

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

`DynamicWeatherFetch.razor` içinde veriyi çekin:

```razor
@page "/dynamicweather"
@inject HttpClient Http

@code {
    private CancellationTokenSource? cts;
    private List<User>? users;

    private async Task FetchUserData()
    {
        cts?.Cancel(); // Cancel any previous requests
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

## 🧠 3. Adım: API Veri Güncellemelerini Yönetmek İçin State Management Uygulama

**WeatherData** class’ını ekleyin:

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

Bir state service oluşturun:

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

Bileşene inject edin ve UI güncellenmesini bağlayın:

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

---

## 🖥️ 4. Adım: Yeni API Yanıtlarına Göre UI Güncellemelerini Dinamik Test Etme

Dinamik UI güncellemelerini ekleyin:

```razor
<button @onclick="FetchNewUserData">Fetch Users</button>
<button @onclick="FetchWeatherData">Fetch Weather</button>

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

---

## ⚔️ 5. Adım: Birden Fazla API Çağrısı Sırasında State Çakışmalarını Yönetme

Bir loading göstergesi ekleyin ve weather verisini çekin. Kodda `YOUR_API_KEY` kısmını kendi API key’iniz ile değiştirmeyi unutmayın:

```razor
@if (isLoading)
{
    <p>Loading...</p>
}
else
{
    <p>Data loaded.</p>
}

@code {
    private bool isLoading;

    private async Task FetchWeatherData()
    {
        isLoading = true;
        try
        {
            var weather = await Http.GetFromJsonAsync<WeatherData>(
                "https://api.weatherapi.com/v1/current.json?key=YOUR_API_KEY&q=London");
            StateService.UpdateWeather(weather);
        }
        finally
        {
            isLoading = false;
        }
    }
}
```

Bu yaklaşım, uygulamanızın dinamik güncellemeleri ve çakışmaları etkili biçimde yönetmesini sağlar.

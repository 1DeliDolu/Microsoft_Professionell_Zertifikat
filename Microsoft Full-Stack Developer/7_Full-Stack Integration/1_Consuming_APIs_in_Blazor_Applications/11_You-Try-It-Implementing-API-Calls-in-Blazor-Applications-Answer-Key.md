## 🗝️ You Try It! Blazor Uygulamalarında API Çağrılarını Uygulama — Cevap Anahtarı

---

## 🧱 Adım 1: Uygulama İçin Hazırlık

Bu adım için kod gerekmez.

---

## 🌐 Adım 2: GET İsteği Yapmak İçin HTTPClient’ı Yapılandırma

**WeatherFetch.razor** dosyasını güncelleyin:

```razor
@page "/weatherFetch"
@inject HttpClient Http

@code {
    private WeatherData? weather;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            weather = await Http.GetFromJsonAsync<WeatherData>("https://api.weatherapi.com/v1/current.json?key=YOUR_API_KEY&q=London");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching weather data: {ex.Message}");
        }
    }

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
        public required double Temp_c { get; set; }
        public required Condition Condition { get; set; }
    }

    public class Condition
    {
        public required string Text { get; set; }
        public required string Icon { get; set; }
    }
}
```

---

## 🧩 Adım 3: API Yanıtını Blazor Bileşenine Bağlama

**WeatherFetch.razor** dosyasının en üstüne HTML ekleyin:

```razor
<h3>Weather Information</h3>

@if (weather is not null)
{
    <div>
        <h4>@weather.Location.Name, @weather.Location.Country</h4>
        <p>Temperature: @weather.Current.Temp_C°C</p>
        <p>Condition: @weather.Current.Condition.Text</p>
        <img src="https:@weather.Current.Condition.Icon" alt="Weather Condition" />
    </div>
}
else
{
    <p><em>Loading weather data...</em></p>
}
```

---

## 🧯 Adım 4: Hata Yönetimi Uygulama

Hata yönetimi Adım 2’de `try-catch` bloğu ile uygulanmıştır. Fallback mesajı göstermek için `else` bloğunu güncelleyin.

**WeatherFetch.razor** güncellemesi:

```razor
@if (weather is null)
{
    <p><em>Unable to fetch weather data. Please try again later.</em></p>
}
```

---

## 🧪 Adım 5: API Çağrısını Test Etme

Test için ek kod gerekmez. Uygulamayı çalıştırın ve tarayıcıda şu adrese gidin:

```text
http://localhost:5000/weatherfetch
```

Gerekirse, `5000` değerini Adım 1’de not ettiğiniz doğru port ile değiştirin.

Geçerli ve geçersiz senaryolarla işlevselliği ve dayanıklılığı doğrulayın.

---

## ✅ Beklenen Çıktı

**Geçerli API Çağrısı:** Uygulama hava durumu bilgisini gösterir (şehir, sıcaklık, durum ve bir ikon).

**Geçersiz API Endpoint:** Console bir hata loglar ve kullanıcı şunu görür: **"Unable to fetch weather data. Please try again later."**

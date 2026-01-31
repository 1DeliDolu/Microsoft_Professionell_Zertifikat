## 🧪 Deneyin! Full-Stack Uygulamada Sunucu Tarafı Durum Yönetimi - Cevap Anahtarı

### 🧱 Adım 1: Uygulama İçin Hazırlık

Bu adım için kod gerekmiyor.

---

## 🕒 Adım 2: Oturum Yönetimini Yapılandırma

```csharp
// Program.cs
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
});
app.UseSession();
```

---

## 🚀 Adım 3: Caching Servisi Oluşturma

```csharp
// CacheService.cs
using Microsoft.Extensions.Caching.Memory;

public class CacheService
{
    private readonly IMemoryCache _cache;

    public CacheService(IMemoryCache cache)
    {
        _cache = cache;
    }

    public T GetOrCreate<T>(string key, Func<ICacheEntry, T> createItem)
    {
        return _cache.GetOrCreate(key, createItem);
    }
}
```

---

## 🧩 Adım 4: Servisleri Kaydetme

```csharp
// Program.cs
builder.Services.AddSingleton<CacheService>();
builder.Services.AddMemoryCache();
```

---

## 🌦️ Adım 5: Önbellek Kullanan Bir Bileşen Oluşturma

```razor
// FetchData.razor
@page "/fetch"
@inject CacheService CacheService

<h3>Weather Data</h3>

<p>@WeatherData</p>

@code {
    private string WeatherData;

    protected override async Task OnInitializedAsync()
    {
        WeatherData = CacheService.GetOrCreate("weatherData", entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5);
            return "Sample weather data"; // Replace with real fetch logic
        });
    }
}
```

---

## 🧾 Adım 6: Gelişmiş Oturum Yönetimini Etkinleştirme

```csharp
// Program.cs
using Blazored.SessionStorage;

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddHttpContextAccessor();
```

```razor
// Counter.razor
@page "/counter"
@rendermode InteractiveServer
@inject Blazored.SessionStorage.ISessionStorageService SessionStorage

<h1>Counter</h1>
<p>Current count: @CounterInc</p>
<button @onclick="IncrementCount">Click me</button>

@code {
    private int CounterInc;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            CounterInc = await SessionStorage.GetItemAsync<int>("Counter");
        }
    }

    private async Task IncrementCount()
    {
        CounterInc++;
        await SessionStorage.SetItemAsync("Counter", CounterInc);
    }
}
```

---

## ✅ Beklenen Çıktı

Önbelleğe alınmış veri ve kalıcı oturum yönetimiyle akıcı bir kullanıcı deneyimi.

Cache veya session içinde saklanan veri kalıcı olmalı ve sunucu iş yükünü azaltmalıdır.

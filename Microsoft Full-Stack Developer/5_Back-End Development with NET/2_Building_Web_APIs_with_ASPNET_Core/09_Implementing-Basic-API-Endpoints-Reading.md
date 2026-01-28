## 🧩 Temel API Endpoint’lerini Uygulama

### 📝 Introduction

Bu nasıl-yapılır kılavuzu, bir *ASP.NET Core* projesinde temel API endpoint’lerini ( *GET, POST, PUT, DELETE* ) uygulama sürecini açıklar.

---

## 🪜 Steps

## 🛠️ Geliştirme Ortamını Kurun

* Microsoft’un resmi sitesinden  *.NET SDK* ’yı indirin ve yükleyin.
* *Visual Studio Code* ’u yükleyin ve kurulum sırasında *ASP.NET* ve web geliştirme workload’unun seçili olduğundan emin olun.

---

## 🧱 Yeni Bir ASP.NET Core Web API Projesi Oluşturun

* *Command Prompt* veya  *Terminal* ’i açın.
* Yeni bir proje oluşturmak için şu komutu çalıştırın:

```bash
dotnet new webapi -n MyWebAPI
```

Bu, temel klasör yapısıyla yeni bir Web API projesi üretir.

---

## 🧭 Bir Controller Ekleyin

*Visual Studio Code* içinde yeni bir controller sınıfı ekleyin (ör. `WeatherForecastController.cs`).

Sınıfa şu attribute’ları ekleyin:

```csharp
public class WeatherForecast

{

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public string? Summary { get; set; }

}

[ApiController]

[Route("[controller]")]

public class WeatherForecastController : ControllerBase

{

    private static readonly string[] Summaries = new[]

    {

        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"

    };

    // Method implementations go here

}
```

---

## 🧩 API Metotlarını Tanımlayın

### 📥 GET Method (Retrieve Data)

Bu metot, bir hava durumu tahmini listesini döndürür.

```csharp
[HttpGet]
public IEnumerable<WeatherForecast> Get()

{

    var rng = new Random();

    return Enumerable.Range(1, 5).Select(index => new WeatherForecast

    {

        Date = DateTime.Now.AddDays(index),

        TemperatureC = rng.Next(-20, 55),

        Summary = Summaries[rng.Next(Summaries.Length)]

    }).ToArray();

}
```

---

### ➕ POST Method (Create Data)

Bu metot, request body içinde bir data object kabul eder ve oluşturulan object’i döndürür.

```csharp
[HttpPost]
public IActionResult Post([FromBody] WeatherForecast forecast)
{
	// Add data to storage (e.g., database)
	return Ok(forecast);
}
```

---

### ♻️ PUT Method (Update Data)

Bu metot, ID’ye göre mevcut bir öğeyi günceller.

```csharp
[HttpPut("{id}")]
public IActionResult Put(int id, [FromBody] WeatherForecast forecast)
{ 
   	// Update data for the given ID
	// Example: Find and update an item with a matching ID
	var existingForecast = /* fetch the data */;
	existingForecast.Date = forecast.Date
    	return NoContent();
}
```

---

### 🗑️ DELETE Method (Remove Data)

Bu metot, ID’ye göre bir öğeyi siler.

```csharp
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{ 
   // Delete data for the given ID
    return NoContent();
}
```

---

## ▶️ Uygulamayı Çalıştırın

* *Command Prompt* veya  *Terminal* ’i açın.
* Henüz yapmadıysanız dizini değiştirin:

```bash
cd MyWebAPI
```

* Projeyi çalıştırın:

```bash
dotnet run
```

* Bir tarayıcı veya API test aracı (*Postman* gibi) kullanarak şu adresten API’ye erişin:

[http://localhost:5215/WeatherForecast](http://localhost:5215/WeatherForecast)

**Not:** Port numaranız `5215` olmayabilir. API’nin kullandığı port’u bulmak için terminal çıktısında şu satırı kontrol edebilirsiniz:

`Now listening on: http://localhost:<your-port>`

veya `Properties` klasörüne gidip `launchSettings.json` dosyasını açarak port numarasını bulabilirsiniz.

---

## ✅ Sonuç

Artık *ASP.NET Core* kullanarak temel *GET, POST, PUT ve DELETE* endpoint’lerine sahip çalışan bir API’niz var.

Bu metotları proje ihtiyaçlarınıza göre test edebilir ve genişletebilirsiniz.

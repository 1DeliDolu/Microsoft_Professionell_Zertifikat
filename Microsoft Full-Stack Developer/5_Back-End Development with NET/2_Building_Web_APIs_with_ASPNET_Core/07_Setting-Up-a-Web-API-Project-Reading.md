## 🧩 Bir Web API Projesi Kurulumu

### 📝 Introduction

Bu kılavuz, *ASP.NET Core* kullanarak temel bir Web API kurmanıza yardımcı olacaktır. Doğru araçları yüklemekten başlayarak ilk API endpoint’inizi yazmaya ve test etmeye kadar adım adım ilerleyeceğiz. Bu kılavuz, web geliştirmeye yeni başlayanlar ve yalnızca *Visual Studio Code (VS Code)* yüklü olanlar için hazırlanmıştır.

---

## 🧰 Başlamadan Önce İhtiyacınız Olanlar

Bu kılavuzu takip etmek için bilgisayarınıza aşağıdaki araçları yüklemelisiniz. Henüz yüklemediyseniz, aşağıdaki talimatları izleyin:

---

## 1️⃣ .NET SDK

**Nedir:** .NET uygulamaları geliştirmek için kullanılan araçlar ve kütüphaneler seti.

**Buradan indir:**
[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

**Kurulum ipucu:** .NET SDK’nın en güncel *LTS* sürümünü seçin (ör. mevcutsa  *.NET 9* ). Yalnızca runtime değil,  **SDK** ’yı indirin.

**Kurulumu doğrulamak için:**

```bash
dotnet --version
```

---

## 2️⃣ Visual Studio Code (VS Code)

Bunun zaten yüklü olması gerekir. Değilse buradan edinin:
[https://code.visualstudio.com/](https://code.visualstudio.com/)

---

## 3️⃣ VS Code için C# Eklentisi

VS Code içinde:

* Extensions sekmesine gidin (sol kenar çubuğu veya `Ctrl+Shift+X`)
* “C#” aratın
* Microsoft tarafından yayınlanan eklentiyi yükleyin

---

## 🛠️ Adım Adım: İlk Web API’nizi Oluşturun

### ✅ Step 1: Yeni Bir Proje Oluşturun

VS Code’da veya işletim sisteminizde terminalinizi açın ve şunu yazın:

```bash
dotnet new webapi -o MyFirstApi

cd MyFirstApi
```

Bu komut:

* `MyFirstApi` adlı yeni bir klasör oluşturur
* Varsayılan olarak controller içermeyen *minimal API* stilini kullanarak yeni bir Web API projesi kurar

.NET sürümünüze bağlı olarak `Program.cs` ve muhtemelen `WeatherForecast.cs` ve `WeatherForecastController.cs` gibi dosyalar göreceksiniz.

**Önemli:** Template varsayılan olarak bir `Controllers` klasörü içermez. Bunu sizin oluşturmanız gerekir.

---

### 📂 Step 2: Projeyi VS Code’da Açın

```bash
code .
```

Bu, mevcut klasörü VS Code’da açar.

Bir istem çıkarsa, gerekli asset’lerin eklenmesine izin verin. Bunlar uygulamayı debug etmek ve build etmek için yardımcı olur.

---

### 🧩 Step 3: Controller Desteği İçin Program.cs Dosyasını Değiştirin

Varsayılan minimal API template’i controller’ları desteklemez. Controller desteğini etkinleştirmek için:

* `Program.cs` dosyasını açın.
* İçeriğini aşağıdakiyle değiştirin:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

// Remove HTTPS redirection so you can test with http

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
```

**Not:** API’nizi `https://` yerine `http://` ile test edebilmeniz için `app.UseHttpsRedirection();` satırını yorum satırı yaptık; bu, erken geliştirme aşamalarında bazen problemli olabiliyor.

---

### 🗂️ Step 4: Controllers Klasörünü Oluşturun

* Projenin kök dizinine sağ tıklayın
* **New Folder** seçin
* Adını `Controllers` yapın

Burası controller’ları tanımladığınız yerdir. Controller’lar uygulamanızın mantığını yönetir ve HTTP isteklerine yanıt verir.

---

### 🧾 Step 5: Kendi Controller’ınızı Oluşturun

Ürün listesini döndüren bir controller ekleyelim.

* `Controllers` klasörüne sağ tıklayın
* **New File** seçin
* Dosya adını `ProductsController.cs` yapın
* Aşağıdaki kodu dosyaya yapıştırın:

```csharp
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace MyFirstApi.Controllers

{

    [ApiController]

    [Route("api/[controller]")]

    public class ProductsController : ControllerBase

    {

        [HttpGet]

        public ActionResult<List<string>> Get()

        {

            return new List<string> { "Apple", "Banana", "Orange" };

        }

    }

}
```

**Bu ne yapar:**

* Bir route tanımlar: `api/products`
* Bu route’a gelen GET isteklerini işler
* Ürün isimleri olarak string listesini döndürür

---

### ▶️ Step 6: API’nizi Çalıştırın

Terminalde şunu yazın:

```bash
dotnet run
```

Şuna benzer bir çıktı görmelisiniz:

`Now listening on: http://localhost:5000`

**Not:** Port numaranız farklı olabilir. Örneğin `"5000"` yerine farklı bir sayı görebilirsiniz. 5000 yerine terminalinizde görünen numarayı kullanın.

Bir tarayıcı açın ve şuraya gidin:

[http://localhost:5000/api/products](http://localhost:5000/api/products)

Şunu görmelisiniz:

`["Apple", "Banana", "Orange"]`

---

## 🧭 Step 7: Routing Temellerini Anlayın

* `[HttpGet]` bir metodu HTTP GET isteğine eşler
* `[Route("api/[controller]")]` route’un controller adına göre belirlendiği anlamına gelir (`ProductsController` → `products`)

Özel route’lar da tanımlayabilirsiniz:

```csharp
[HttpGet("featured")]

public string GetFeaturedProduct() => "Mango";
```

Artık şu adreste erişilebilir:

[http://localhost:5000/api/products/featured](http://localhost:5000/api/products/featured)

---

## 🌐 Step 8: Daha Fazla HTTP Metodu Ekleyin

`ProductsController` içine POST, PUT ve DELETE metotlarını ekleyebilirsiniz:

```csharp
[HttpPost]

public ActionResult<string> Post([FromBody] string newProduct)

{

    return $"Added: {newProduct}";

}

[HttpPut("{id}")]

public ActionResult<string> Put(int id, [FromBody] string updatedProduct)

{

    return $"Updated product {id} to: {updatedProduct}";

}

[HttpDelete("{id}")]

public ActionResult<string> Delete(int id)

{

    return $"Deleted product with ID: {id}";

}
```

Bu metotları test etmek için *Postman* kullanın. Postman’i web sitelerinden indirip ücretsiz sürümünü burada kullanabilirsiniz:
[https://www.postman.com/](https://www.postman.com/)

---

## 🧪 Step 9: Pratik Yapın ve Geliştirin

Artık temel bir Web API’niz olduğuna göre:

* Sadece string değil, gerçek veri modelleri döndürmeyi deneyin
* Validation ve hata yönetimi ekleyin
* Koleksiyonlar, dosyalar veya veritabanları kullanarak veriyi saklayıp çekin (gelecek dersler yardımcı olacak)

---

## ✅ Conclusion

Artık *ASP.NET Core* ile VS Code üzerinde basit bir Web API oluşturup test ettiniz. İlerledikçe bu kurulum; authentication, veritabanları ve gerçek dünya deployment gibi daha gelişmiş özellikler için bir temel olacaktır.

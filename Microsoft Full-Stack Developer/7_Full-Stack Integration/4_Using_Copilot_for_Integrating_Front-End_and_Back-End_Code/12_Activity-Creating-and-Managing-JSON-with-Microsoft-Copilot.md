## 🧪 Etkinlik Tanıtımı

InventoryHub’ın ön yüzü, arka uç API’nin iyi yapılandırılmış JSON yanıtlarına dayanır. Bu etkinlikte göreviniz, API’nin uygulama gereksinimlerini destekleyecek şekilde düzgün formatlanmış JSON döndürmesini sağlamaktır. **Microsoft Copilot** kullanarak JSON yapılarını oluşturacak ve doğrulayacaksınız.

Bu, capstone projesindeki dört etkinliğin üçüncüsüdür. Bir sonraki etkinlikte performansı optimize edecek ve tüm çalışmanızı birleştirerek projeyi tamamlayacaksınız.

---

## 📋 Etkinlik Talimatları

---

## 1️⃣ Adım: Senaryoyu gözden geçirin

InventoryHub’ın arka ucu, ürün verisini standart bir JSON formatında döndürmelidir. Yanıt şunları içermelidir:

* `id`, `name`, `price`, `stock` gibi ürün detayları
* Her ürün için iç içe (nested) bir `category` nesnesi

---

## 2️⃣ Adım: Copilot kullanarak JSON yapılarını üretin

1. Minimal API içinde `/api/productlist` endpoint’ini, iç içe bir `category` nesnesi içerecek şekilde güncelleyin:

```csharp
app.MapGet("/api/productlist", () =>
{
    return new[]
    {
        new
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50,
            Stock = 25,
            Category = new { Id = 101, Name = "Electronics" }
        },
        new
        {
            Id = 2,
            Name = "Headphones",
            Price = 50.00,
            Stock = 100,
            Category = new { Id = 102, Name = "Accessories" }
        }
    };
});
```

2. Copilot’u kullanarak JSON yapısını refine edin ve endüstri standartlarını karşıladığından emin olacak şekilde validate edin.

---

## 3️⃣ Adım: JSON yanıtını test edin

Postman gibi bir araç kullanarak `/api/productlist` endpoint’ini test edin. Şunları doğrulayın:

* JSON yanıtı gerekli alanları içeriyor mu (`id`, `name`, `price`, `stock`, `category`)?
* Yapı geçerli mi ve doğru biçimde nested mı?

---

## 4️⃣ Adım: Çalışmanızı kaydedin

Bu etkinliğin sonunda, arka uç API için iyi yapılandırılmış JSON yanıtlarını uygulamış ve doğruluğunu doğrulamış olacaksınız.

Çalışmanızı son etkinlik için kaydedin; burada kodunuzu optimize edecek ve Copilot ile kodlama sürecine dair bir değerlendirme yazacaksınız.

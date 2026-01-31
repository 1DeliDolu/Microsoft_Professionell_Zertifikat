## 🧪 Etkinlik: Copilot ile Entegrasyon Kodu Yazma

---

## 🧭 Etkinlik Tanıtımı

Küçük bir işletme için bir envanter yönetim sistemi olan  **InventoryHub** ’ı geliştirmekle görevli bir geliştirme ekibinin parçası olduğunuzu hayal edin. Uygulama, kullanıcıların arka uçtaki bir API’den ürün ayrıntılarını görüntülemesine izin vermelidir. Hedefiniz, ön yüz ( **Blazor** ) ile arka uç ( **Minimal API** ) arasındaki entegrasyonu oluşturmaktır.

Bu etkinlikte,  **Microsoft Copilot** ’u kullanarak iki bileşen arasında sorunsuz iletişim sağlayan entegrasyon kodunu üretecek ve iyileştireceksiniz.

Bu, InventoryHub uygulamasına doğru ilerleyen dört etkinliğin ilkidir. Burada oluşturacağınız entegrasyon kodu, sonraki etkinliklerde yapılacak hata ayıklama ve performans optimizasyonu için temel oluşturacaktır.

---

## 📋 Etkinlik Talimatları

---

## 1️⃣ Adım: Sağlanan temel uygulama kodunu kurun

### Uygulamalarınızı ve bir çözüm dosyası oluşturun

Uygulamanızı oluşturmak istediğiniz kök klasöre gidin.

Aşağıdaki komutlarla uygulama klasörünüzü oluşturun ve içine geçin:

```bash
mkdir FullStackApp
cd FullStackApp
```

Aşağıdaki komutlarla Client ve Server uygulamalarınızı oluşturun:

```bash
dotnet new blazorwasm -n ClientApp
dotnet new webapi -n ServerApp
```

Aşağıdaki komutlarla bir çözüm oluşturun ve uygulamalarınızı buna ekleyin:

```bash
dotnet new sln -n FullStackSolution
dotnet sln add ClientApp ServerApp
```

ServerApp’in `Program.cs` dosyasındaki kodu bu başlangıç koduyla değiştirin:

**Minimal API Back-End (ServerApp.cs):**

```csharp
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/api/products", () =>

{

    return new[]

    {

        new { Id = 1, Name = "Laptop", Price = 1200.50, Stock = 25 },

        new { Id = 2, Name = "Headphones", Price = 50.00, Stock = 100 }

    };

});

app.Run();
```

### Uygulamalarınızı açın ve çalıştırın

VS Code’da iki yeni terminal penceresi açın.

İlk terminal penceresinde, istemci uygulaması dizinine geçmek için `cd ClientApp` kullanın.

İkinci terminal penceresinde, sunucu uygulaması dizinine geçmek için `cd ServerApp` kullanın.

Her iki terminal penceresinde de `dotnet run` kullanarak Blazor ClientApp ve ServerApp projelerini çalıştırın.

Tarayıcınızda ClientApp’i (ön yüz) açın. Entegrasyon kodu henüz uygulanmadığı için verinin görüntülenmediğine dikkat edin.

Tarayıcınızda ServerApp’i (arka uç) açın ve `http://localhost:[port number]/api/products` adresine gidin. API’nin ürün bilgilerini JSON formatında döndürdüğüne dikkat edin.

---

## 2️⃣ Adım: Copilot kullanarak entegrasyon kodu üretin

Arka uç API’den ürün verisini getirip ön yüzde görüntülemeniz gerekiyor. Önce ürün listesini gösterecek yeni bir Blazor bileşeni oluşturarak başlayın.

1. Ön yüz projesinde `FetchProducts.razor` adlı bir dosya oluşturun ve aşağıdaki başlangıç kodunu ekleyin:

```razor
@page "/fetchproducts"

<h3>Product List</h3>

<ul>
   @if (products != null)
    {
        foreach (var product in products
        {
            <li>@product.Name - $@product.Price</li>
        }
    }
    else
    {
        <li>Loading...</li>
    }
</ul>

@code {
    private Product[]? products;
    protected override async Task OnInitializedAsync()
    {
        // API call logic will go here
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
```

2. `OnInitializedAsync` metodunun içine API çağrısı mantığını üretmek için Microsoft Copilot’u kullanın:

* `/api/products` endpoint’ini çağırmak için `HttpClient` kullanın.
* JSON yanıtını `Product` sınıfına deserialize edin.

---

## 3️⃣ Adım: Entegrasyon kodunu iyileştirin ve test edin

Copilot ile API çağrısı mantığını şu şekilde iyileştirin:

* Geçersiz API yanıtları veya zaman aşımları için hata yönetimi ekleyin.
* Kodun okunabilirlik ve sürdürülebilirlik açısından en iyi uygulamalara uygun olmasını sağlayın.

Entegrasyonu test etmek için hem ön yüz hem de arka uç projelerini çalıştırın:

* Ürün verisinin tarayıcıda göründüğünü doğrulayın.

---

## 4️⃣ Adım: Çalışmanızı kaydedin

Bu etkinliğin sonunda, Minimal API’den ürün verisini başarıyla alıp Blazor ön yüzde görüntüleyen entegrasyon kodunu üretmiş ve iyileştirmiş olacaksınız.

Çalışmanızı sonraki etkinliklerde kullanmak üzere kaydedin. Bu çalışma, Etkinlik 2’de genişletilecek; burada entegrasyon sorunlarını hata ayıklayacak ve çözeceksiniz.

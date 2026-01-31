## 🧪 Etkinlik Tanıtımı

InventoryHub için ilk entegrasyon kodunu uyguladıktan sonra sorunlar ortaya çıktı. Kullanıcılar, ürün listesinin; yanlış API route’ları, CORS kısıtlamaları ve bozuk JSON yanıtları gibi hatalar nedeniyle düzgün görüntülenmediğini bildiriyor. Göreviniz, **Microsoft Copilot** kullanarak bu sorunları hata ayıklamak ve çözmektir.

Bu, projedeki dört etkinliğin ikincisidir. Buradaki entegrasyon hata ayıklaması, bir sonraki etkinlikte JSON yapılandırması için sağlam bir temel oluşturur.

---

## 📋 Etkinlik Talimatları

---

## 1️⃣ Adım: Senaryoyu gözden geçirin

InventoryHub için entegrasyondaki şu sorunları çözmekle görevli lead developer sizsiniz:

1. **Yanlış API route’u:** Ön yüz `/api/products` çağırıyor, ancak arka uç endpoint’i `/api/productlist` olarak güncellendi.
2. **CORS hataları:** Güvenlik kısıtlamaları, ön yüzün arka uç API’ye erişmesini engelliyor.
3. **Bozuk JSON:** Arka uç geliştiricisi API yanıt yapısını yanlışlıkla değiştirdi ve bu da ön yüz görüntülemesini bozdu.

Hedefiniz, bu sorunları hata ayıklayarak uygulamanın çalışmasını geri kazandırmaktır.

---

## 2️⃣ Adım: Copilot ile entegrasyon sorunlarını hata ayıklayın

### 1) ✅ API route’unu düzeltin

Copilot kullanarak `FetchProducts.razor` içindeki API çağrısını güncellenmiş route’a göre değiştirin:

* Eski: `/api/products`
* Yeni: `/api/productlist`

---

### 2) 🛡️ CORS hatalarını çözün

Minimal API projesinin `Program.cs` dosyasına aşağıdaki CORS yapılandırmasını Copilot ile ekleyin:

```csharp
app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());
```

Sonra uygulamayı test edin ve ön yüzün arka uca başarıyla eriştiğinden emin olun.

---

### 3) 🧾 Bozuk JSON’u ele alın

Copilot ile ön yüzde JSON deserialize işlemi için hata yakalama ekleyin.

`OnInitializedAsync` metoduna geçersiz JSON yanıtlarını yönetmek için `try-catch` bloğu ekleyin:

```csharp
try
{
    var response = await HttpClient.GetAsync("/api/productlist");
    response.EnsureSuccessStatusCode();
    var json = await response.Content.ReadAsStringAsync();
    products = JsonSerializer.Deserialize<Product[]>(json);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

---

## 3️⃣ Adım: Düzeltilmiş kodu test edin

Uygulamayı çalıştırın:

* Ürün listesinin ön yüzde doğru görüntülendiğini doğrulayın.
* Tarayıcı konsolunda CORS veya JSON kaynaklı exception log’u olmadığından emin olun.

---

## 4️⃣ Adım: Çalışmanızı kaydedin

Bu etkinliğin sonunda, entegrasyon sorunlarını hata ayıklayıp çözerek ön yüz ile arka uç arasında sorunsuz iletişimi sağlamış olacaksınız.

Çalışmanızı sonraki etkinliklerde kullanmak üzere kaydedin. Bu çalışma, Etkinlik 3’te genişletilecek; orada JSON yapılarını uygulayacaksınız.

## 🧪 Blazor’da Performans, Güvenlik ve Sürdürülebilirlik için Public API Analizi

---

## 🎯 Amaç

Bir public API’nin performans, güvenlik ve sürdürülebilirlik stratejilerini değerlendirmek ve bu içgörüleri bir Blazor uygulamasının API entegrasyonunu iyileştirmek için uygulamak.

---

## 🌦️ Vaka Çalışması: OpenWeather API

OpenWeather API, dünya genelindeki şehirler için hava durumu verisi sağlar.  *Mevcut hava durumu* , *tahminler* ve *geçmiş veriler* gibi özellikler içerir. Bu API’yi analiz ederek performans, güvenlik ve sürdürülebilirlik özelliklerini ve bunların bir Blazor projesinde nasıl değerlendirilebileceğini anlayalım.

---

## 🔗 API Detayları

**Endpoint:**

```text
https://api.openweathermap.org/data/2.5/weather
```

**Rate Limits:** Ücretsiz katman dakikada **60** çağrıya izin verir.

**Caching:** Performansı artırmak için yanıtların cache’lenmesini teşvik eder.

**Security:** Kimlik doğrulama için bir *API key* gerektirir; *HTTPS* zorunludur.

---

## 📚 Entegrasyon Kavramlarını Öğretme

---

## ⚡ 1. Performans Stratejileri

**Rate Limiting:** Dakikada 60 çağrı limitine, istekleri batch’leyerek veya yenileme aralıklarını sınırlayarak uyun.

**Caching:** Sık erişilen veriler için API yanıtlarını istemci tarafında cache’leyin (ör. bir şehir için hava durumu verisini 5 dakika saklamak).

---

## 🔐 2. Güvenlik Stratejileri

**API Key Yönetimi:** API key’i Blazor’un yapılandırma seçeneklerini kullanarak güvenli şekilde saklayın (ör. `appsettings.json`) ve anahtarları hardcode etmeyin.

**HTTPS:** Taşınan veriyi korumak için tüm API çağrılarının *HTTPS* üzerinden yapıldığından emin olun.

---

## 🧰 3. Sürdürülebilirlik Stratejileri

**Yeniden Kullanılabilir Servisler:** API etkileşimini merkezileştirmek ve yönetmek için API çağrılarını bir Blazor servis class’ında toplayın.

**Hata Yönetimi:** *rate limit exceeded* (HTTP `429`) veya *invalid requests* (HTTP `400`) gibi durumlar için hata yönetimi uygulayın.

---

## 📝 Görev: Bir Public API’yi Değerlendir ve Raporla

### ✅ Talimatlar

**Bir Public API Seçin**
Aşağıdaki listeden bir API seçin, örneğin:

```text
GitHub API (https://api.github.com)
OpenWeather API (https://api.openweathermap.org)
SpaceX API (https://api.spacexdata.com/v4)
```

**API’yi Analiz Edin**
Seçtiğiniz API için şunları belirleyin ve açıklayın:

* **Rate Limits:** API’nin rate limitleri nelerdir ve Blazor’da bunu nasıl yönetebilirsiniz?
* **Caching Policies:** API yanıtların cache’lenmesini öneriyor mu? Blazor’da caching’i nasıl uygularsınız?
* **Security Features:** API kimlik doğrulama gerektiriyor mu? Kimlik bilgilerini güvenli şekilde nasıl yönetirsiniz?

**Bir Rapor Teslim Edin**
Yukarıdaki maddeleri ele alan kısa bir rapor (200–300 kelime) hazırlayın. Bu içgörüleri bir Blazor uygulamasına uygulamak için pratik stratejiler ekleyin.

---

## 🧾 Örnek Rapor: OpenWeather API

### ⛔ Rate Limits

OpenWeather API, dakikada 60 isteğe kadar izin verir. Bu limiti aşmamak için Blazor’da API çağrıları, güncellemeleri dakikada bir ile sınırlayarak veya birden fazla isteği batch’leyerek throttle edilebilir.

### 🗃️ Caching Policies

Sık erişilen veriler için yanıtların cache’lenmesi önerilir. Blazor’da, belirli bir konum için hava durumu verisini 5 dakikaya kadar kaydetmek üzere in-memory caching veya local storage kullanılabilir. Bu, tekrar eden API çağrılarını azaltır ve performansı iyileştirir.

### 🔐 Security Features

API, kimlik doğrulama için bir API key gerektirir. Blazor’da anahtar, `appsettings.json` içinde güvenli şekilde saklanabilir ve dependency injection aracılığıyla erişilebilir. Tüm istekler, iletim sırasında API key’i korumak için HTTPS üzerinden yapılmalıdır.

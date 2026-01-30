## 🚀 Blazor Uygulamalarında API Çağrılarını Uygulama

## 🧱 Adım 1: Uygulama İçin Hazırlık

Herkese açık bir API kullanarak hava durumu verisi çeken yeni bir Blazor WebAssembly uygulaması oluşturacaksınız. Uygulamanız hava durumu bilgisini görüntüleyecek ve hataları zarif bir şekilde ele alacaktır.

**Talimatlar:**

Visual Studio Code’u açın.

Yeni bir Blazor WebAssembly projesi oluşturun:

```bash
dotnet new blazorwasm -o WeatherApp
cd WeatherApp
dotnet run
```

Terminalde verilen URL’ye giderek uygulamanın çalıştığından emin olun. “localhost:” ifadesinden sonra gelen port numarasını not edin.

---

## 🔑 Adım 2: Weather API’ye Kaydolun ve API Key Alın

WeatherAPI veya OpenWeatherMap gibi herkese açık bir API’den hava durumu verisi çekmek için bir API key’e ihtiyacınız olacak.

**Talimatlar:**

**WeatherAPI** web sitesine gidin.

E-posta adresinizle kaydolup ücretsiz bir hesap oluşturun.

Giriş yaptıktan sonra, hesap panelinizdeki **"API Key"** bölümüne gidin.

Panelinizde sağlanan API key’i kopyalayın. Bu anahtarı API isteğinde kullanacaksınız.

---

## 🌐 Adım 3: GET İsteği Yapmak İçin HTTPClient’ı Yapılandırma

Blazor’da HTTPClient’ı ayarlayarak herkese açık bir API’den hava durumu verisi çekin.

**Talimatlar:**

Pages klasöründe **WeatherFetch.razor** adlı yeni bir Razor bileşeni oluşturun.

HTTPClient servisini bileşene enjekte edin.

Weather API yanıt yapısıyla eşleşen bir veri modeli tanımlayın.

`OnInitializedAsync` metodunda API endpoint’inden veri çekmek için HTTPClient kullanın.

Aşağıdaki API URL’sini kullanın. `YOUR_API_KEY` kısmını bir önceki adımda kopyaladığınız key ile değiştirin.

```text
https://api.weatherapi.com/v1/current.json?key=YOUR_API_KEY&q=London
```

---

## 🧩 Adım 3: API Yanıtını Blazor Bileşenine Bağlama

Çekilen hava durumu verisini Blazor bileşeni içinde dinamik olarak görüntüleyin.

**Talimatlar:**

Şehir, sıcaklık ve hava durumu gibi detayları gösterecek basit bir UI tasarlayın.

Çekilen veriyi UI’ya bağlayın.

Veri çekilirken bir yükleniyor mesajı veya spinner sağlayın.

---

## 🧯 Adım 4: Hata Yönetimi Uygulama

API çağrısı sırasında uygulamanın hataları ele aldığından emin olun.

**Talimatlar:**

API çağrısını bir `try-catch` bloğuna alın.

`catch` bloğunda:

Hata mesajını console’a loglayın.

UI’da kullanıcı dostu bir hata mesajı gösterin.

API çağrısı başarısız olursa varsayılan veya placeholder veri göstermek gibi fallback stratejileri kullanın.

---

## 🧪 Adım 5: API Çağrısını Test Etme

Uygulamanın işlevselliğini ve hata yönetimini test edin.

**Talimatlar:**

Uygulamanızı şu komutla başlatın:

```bash
dotnet run
```

Tarayıcıda şu adrese gidin:

```text
http://localhost:5000/weatherfetch
```

Gerekirse, 5000 değerini Adım 1’de not ettiğiniz doğru port ile değiştirin.

Uygulamayı geçerli bir hava durumu API endpoint’i ile test edin.

Koddaki endpoint’i geçersiz bir URL olacak şekilde değiştirin; örneğin  **New York** ; ve hata yönetiminin çalıştığını doğrulayın.

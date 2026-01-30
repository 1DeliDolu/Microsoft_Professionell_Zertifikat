## 🌐 API Consumption in a Blazor-Based Front-End Application

Bu lab’de, bir back-end servisten veri çekip görüntüleyerek React tabanlı bir front-end uygulamasında API consumption uygulayacağız.

Bende burada bir Blazor uygulaması kurulu. **Blazor WASM template** kullanıyor. Özel olarak oluşturduğum bir Razor dosyam var:  **FetchData.razor** . Bunun dışında çoğunlukla template kodu.

---

## 🧰 Step 1: HTTP Client’ı Yapılandırma

Step one’da  **HttpClient** ’ı yapılandırıyoruz. Bu genellikle template tarafından hazır gelir.

Bu örnekte, base address ekleyeceğiz ve bu şu değere eşit olacak:

`new Uri(builder.HostEnvironment.BaseAddress)`

Burada, WebAssembly host’tan oluşturduğumuz `builder` nesnesini kullanıyoruz.

Bu, uygulamada HttpClient’ı kullanabilmemiz için ortamı hazırlar.

---

## 🧩 Step 2: API’den Veri Çekecek Razor Component’i Oluşturma

Step two’da, API’den veri çekecek Razor component’ini oluşturuyoruz:  **FetchData.razor** .

En üstte, API’den çekilen hava durumu verisiyle bir tabloyu doldurmak için Blazor directive’leri kullanan HTML bloğumuz var.

Aşağıdaki `@code` directive’i içinde ise back-end servisten veri çekmek için kullanacağımız C# kodları var.

---

## 🔁 HTML İçinde foreach ile Veri Bağlama

HTML içinde bir `foreach` döngümüz var.

Bu döngü, remote servisten çekilen hava durumu verisiyle doldurulan nesneyi/değişkeni alır. Bu hava durumu verisi, C# kodunda tanımlanır.

Burada `weather data` adında bir **WeatherForecast** object’lerinden oluşan liste oluşturuyoruz.

Bu listeyi iterate ediyoruz ve tablodaki her satır, `weather data` içindeki her bir öğeden geliyor.

Yani listede her öğe için `data` adında bir değişken oluşturuyoruz ve satırları bu nesnedeki üç alanla dolduruyoruz.

Bu nesne aşağıda `WeatherForecast` class’ı içinde tanımlı:

* `Date`
* `Temperature`
* `Summary`

Ve `foreach` döngüsünde HTML’i doldurmak için kullandığımız üç alan da bunlar.

WeatherForecast class’ında kullandığımız attribute’lerin, API’den çektiğimiz ve HTML’e bastığımız alanlarla aynı olduğundan emin olmanız gerekiyor.

HTML’i populate ederken, object içindeki alanların API’den gelen veriyle eşleşmesi gerekir.

---

## 📥 API Çağrısı: try-catch ile weatherData’yı Doldurma

API çağrısını bir `try-catch` bloğu içinde yapıyoruz.

Burada `weather data` listesini, yaptığımız API çağrısının sonuçlarıyla dolduruyoruz.

Dikkat ederseniz endpoint yalnızca şudur:

`/weatherforecast`

Normalde bu tam bir HTTPS URL olurdu, fakat burada `/weatherforecast` ile remote çağrıyı simüle ediyoruz.

Yani burada `/weatherforecast` endpoint’ine gidiyoruz ve GET çağrısından dönen sonuç neyse, `weather data` listesini dolduruyor.

Sonra yukarıda HTML’i populate ederken bunu kullanıyoruz.

---

## ✅ Kapanış

Bu lab’in özü bu.

Doldurmanız gereken alanlar bunlar ve bu yaklaşımı kullanarak, Blazor’da bir API’den veri çekebilir ve HTML elementlerini bu veriyle populate edebilirsiniz.

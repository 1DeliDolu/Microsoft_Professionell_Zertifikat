## 🔌 RESTful API Implementation in VS Code

Burada çok basit bir .NET Web API uygulamam var. Üzerinde çalışması kolay olsun diye tüm route’ları `Program.cs` içine koydum. Bu uygulamanın yapacağı şey, çağırabileceğimiz bazı endpoint’ler kurmak.

Test için **Postman** kullanacağız. Tüm route’larımız, uygulamanın çalışması için eklememiz gereken tüm context’lerin altında burada ayarlı. Yani bir dizi endpoint’imiz var.

Her birini tek tek üzerinden geçeceğim.

---

## 📥 GET Endpoint: Tüm Counter’ları Alma

İlki bir **GET** endpoint’i. Postman’da GET method’unu kullanarak bu endpoint üzerinden veri alıyoruz.

Endpoint: `/counters`

Bu endpoint’in yaptığı tek şey, kurduğumuz ve aşağıdaki POST method’u kullanarak eklediğimiz counter’ları geri döndürmek. Yani aslında in-memory (bellek içi) bir veritabanına bazı counter’lar ekleyeceğiz ve bu GET method’u eklediğimiz counter’ların tamamını alacak.

---

## 📥 GET Endpoint: İsme Göre Tek Counter Alma

Bir sonraki endpoint de bir **GET** method’u.

`app.MapGet` gördüğünüz gibi, bu method tek bir counter’ı isme göre alacak. Route şu şekilde:

`/counters/{name}`

Köşeli parantez içinde `name` var ve Postman’dan endpoint’e `name` göndereceğiz. Bu GET method’u, listemizde `name` değeri gönderdiğimiz `name`’e eşit olan ilk counter’ı (first) ya da varsayılanı (default) bulacak.

Counter null değilse, counter’ın adını ve onunla ilişkili diğer tüm verileri döndürür. Aksi halde **not found** döndürür.

---

## 📤 POST Endpoint: Counter Oluşturma

Bir sonraki endpoint bir  **POST** .

Route, yukarıda kullandığımız GET ile aynı: `/counters`. Ama bu bir POST endpoint’i olduğu için uygulama bunu farklı ele alacak ve .NET, endpoint aynı olsa bile POST method’u ile gönderdiğimiz istek ile GET method’u ile gönderdiğimiz istekte ne yapacağını bilecek.

Burada yaptığı şey, gönderdiğimiz request’i almak. Bir body göndereceğiz; test yaptığımızda bunu göreceksiniz. JSON formatında veri göndereceğiz.

Öncelikle string’in null olup olmadığını kontrol edecek. Null değilse, gönderdiğimiz request body içinden değerleri çıkaracak. İlk olarak gönderdiğimiz `name` değerinin zaten mevcut olup olmadığını kontrol edecek; mevcut değilse, `counters` (db.counters) verisine body’yi, yani gönderdiğimiz veriyi ekleyecek ve tüm değişiklikleri kaydedecek.

Ayrıca counter’ın oluşturulduğunu döndürecek ve yaptığımız istekte gönderdiğimiz veriden aldığı bilgileri bize sağlayacak.

Yani bu bir POST method’u: veri gönderiyoruz ve bu method o veriyle bir şey yapıyor.

---

## 📤 POST Endpoint: Counter Artırma

Son method bir başka **POST** method’u.

Bu route şöyle:

`/counters/{name}/increment`

Yine köşeli parantez içinde `name` var ve route’un bir parçası daha var: `/increment`.

Oluşturduğumuz counter’ın adını göndereceğiz ve bu method o adı arayıp counter value içindeki `count` değerini 1 artıracak. Ne gönderirsek, onu 1 artıracak; sonra değişiklikleri kaydedecek ve güncellenmiş yeni `count` ile counter bilgisini bize geri döndürecek.

Yine, bu bir POST. Bu route’u özellikle, in-memory veritabanında zaten olan veri üzerinde işlem yapacak şekilde ayarladık. Açıkça, burada bir isim gönderirsek ve o isim mevcut değilse method başarısız olur ve istediğimiz sonucu alamayız.

---

## ▶️ API’yi Çalıştırma ve Base URL

Şimdi bu API’yi çalıştıracağım. API’nin `localhost:5091` üzerinde çalıştığını görebiliyoruz; bunu base route olarak kullanabiliriz ve Postman’da isteklerimizi bu route ile göndereceğiz.

Visual Studio Code’un çalıştığını söylediği:

`localhost:5091`

ve ardından route’umuz geliyor.

API’yi çalıştırmak için:

```bash
dotnet run
```

---

## 🧪 Postman ile Test: GET /counters

İlk olarak Postman’da **GET** method’unu `/counters` üzerinde kullanacağız.

Uygulamamızda bu route, şuradaki kısım:

`app.MapGet("/counters", ...)`

Gönderdiğimizde bir yanıt alıyoruz. Status  **200** , yani API’ye ulaştı, method’u buldu ve döndürmesi gereken şeyi döndürdü.

Bu durumda “hiçbir şey” döndürdü, çünkü daha counter oluşturmadık. Endpoint’i kullanabildik ama veritabanında counter olmadığı için boş döndü; beklediğimiz de bu.

---

## 🧪 Postman ile Test: POST /counters (Body ile)

Şimdi diğer bir sekmede POST method’um var. Uygulamada bunun da `/counters` route’u olduğunu görmüştük.

Bu, uygulamaya veri göndermemizi ve veriyi veritabanına kaydetmemizi sağlayacak. Bu method’da `Body` sekmesini kullanarak JSON verisi gönderiyoruz.

Bu JSON içinde bir `name` ve `count` var. Counter’ın adı `counter1` ve count’u 1’den başlatacağız.

İsteği gönderdiğimizde body’yi bu POST method’una göndermiş olacağız. Bu method request’i alacak ve `counters db.counters` verisini gönderdiğimiz counter bilgisiyle dolduracak.

Gönderelim.

Çalıştı. **202.0.1** aldık; bu, kaydın oluşturulduğu anlamına geliyor. Kayıt `ID` değeri 1, `name` değeri `counter1` ve `count` değeri 1.

İkinci bir tane daha oluşturmayı, body verisini değiştirerek kolayca yapabiliriz. `counter2` yapıyoruz; gönderiyoruz; `ID` değeri 2 ve `count` değeri 1.

---

## 🧪 Tekrar GET /counters: Oluşturulan Counter’ları Görme

Şimdi tüm counter’ları alan GET method’umuza geri dönersek ve isteği gönderirsek, artık veritabanında oldukları için iki counter’ımızı görürüz.

Bu bir in-memory veritabanı; ama program çalıştığı sürece içeride kalır. Dolayısıyla iki counter’ımız var ve her birinin `count` değeri 1.

---

## 🧪 POST /counters//increment: Artırma

Şimdi dördüncü method’umuza gidelim: increment method’u.

`counter1`’i route’a parametre olarak verebiliriz:

`/counters/counter1/increment`

POST ile increment’e gönderdiğimizde name’i geçmemiz gerekiyor. `counter1` adında bir counter’ımız olduğunu biliyoruz.

İsteği yaptığımızda API bu adı alacak, adı bulacak ve umarım counter’ı 1 artıracak.

Gönderelim.

Şimdi `count` değerinin 2 olduğunu görebilirsiniz. Yani `counter1`’in `count` değeri 2, çünkü 1 artırıyoruz.

Veritabanında o an hangi sayı varsa, 1 artırıp geri gönderiyoruz ve bu kaydediliyor. `db.SaveChangesAsync` yaptığımızda increment veritabanına kaydedilecek.

Göndermeye devam edebiliriz; ben de sayacı artırmaya devam edeceğim. Şimdi `count` değeri 8.

---

## ✅ Son Kontrol: GET /counters

Tüm veriyi alan GET method’una geri dönüp isteği gönderirsek:

* `counter1` → `count` 8
* `counter2` → `count` 1

Ve endpoint’leri oluşturma süreci bu şekilde.

Bu çok basit bir API uygulaması ve API’lerinizin çalışıp çalışmadığını test etmek için Postman iyi bir araç. Sonrasında da, Postman’ın API’lerle etkileşime girdiğine benzer şekilde bu API’lerle etkileşime girebilecek bir front-end uygulaması geliştirebilirsiniz; ancak kullanıcıların API ile çok daha kolay etkileşime girebilmesi için bir kullanıcı arayüzü (UI) inşa edersiniz.

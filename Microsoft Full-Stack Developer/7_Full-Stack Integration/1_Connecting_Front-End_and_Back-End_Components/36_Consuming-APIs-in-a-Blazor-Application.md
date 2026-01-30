## 🌐 Consuming APIs in a Blazor Application

Web tarayıcıları veya uygulamalar gibi client cihazlara veri aktarımını düşündüğünüzde, bunun büyük bir kısmı internet üzerinden **API’ler (Application Programming Interfaces)** kullanılarak gerçekleşir.

Bu videoda, bir Blazor uygulamasında **HttpClient** kullanarak API’leri nasıl tüketeceğimizi (consume) ve veriyi UI bileşenlerine nasıl bağlayacağımızı (bind) göstereceğiz.

---

## 🧩 Hazır Bir Blazor Uygulaması

Bende zaten hazırlanmış bir Blazor uygulaması var. Bu screencast’te, Blazor uygulamasını **.NET new** ve **Blazor WASM template** ile kurdum.

Bu komutu kullanarak uygulamayı oluşturdum ve ardından bazı dosyalarda değişiklikler yaptım. Bu screencast’te bu dosyalarda ne olduğunu ve nasıl çalıştıklarını adım adım inceleyeceğiz.

Bu uygulamada yapacağımız şey, bir API’ye çağrı yapmak ve **HttpClient** kullanarak o API’den veri çekmek.

---

## 📄 FetchData.razor Dosyası ve UI Yapısı

Üstte, Pages klasörü içinde oluşturduğum **FetchData.razor** dosyasını görebilirsiniz.

Bu Razor dosyasının en üstünde HTML var ve Blazor directive’leri kullanıyor:

* `if` directive’i
* `foreach` döngüsü

Burada veriyi çekip API’den gelen post’ları ekrana basmak için gereken öğeleri oluşturuyoruz. Razor dosyasının üst kısmındaki içerik bu.

Eğer veri henüz çekilmediyse, `else` kısmında sadece **Loading...** mesajını gösteriyoruz.

---

## 🧠 @code Bloğu ve C# Mantığı

Sonraki bölümde `@code` directive’i var; C# kodlarımızı burada yazıyoruz.

İlk yaptığımız şey, post’lardan oluşan bir liste tanımlamak.

Buradaki `Post` tipi, benim oluşturduğum özel bir object ve dosyanın en altında yer alıyor.

`Post` class’ında üç öğe var:

* `Id` → `int`
* `Title` → `string`
* `Body` → `string`

API’den veri geldiğinde, bu veriyi `Post` object’lerine koyacağız ve API’den birden fazla post geleceği için bunu bir listeye koyacağız.

Yani `Post` object’lerinden oluşan bir liste oluşturduk ve bu değişkene `posts` adını verdik.

---

## ⚙️ OnInitializedAsync: Sayfa Yüklendiğinde Çalışan Kod

Sonra `OnInitializedAsync` method’u geliyor. Bu, sayfa yüklendiğinde çalışan method.

Sayfa her yüklendiğinde bu method çalışacak ve içindeki kodlar da çalışacak.

Bu method’un `async` olduğunu fark edeceksiniz. API’den veriyi birden fazla kez almak istersek, `async` method bunu arka planda yapmamıza izin verir ve task’leri sıraya koyabilir.

Yani bu `OnInitializedAsync` çağrısı birden çok kez çalışabilir; biri bittiğinde bir sonrakini yapar ve bu şekilde devam eder.

Bu async task yapısı, API çağrısı yapılırken uygulamanın responsive kalmasını sağlar.

---

## 📥 API’den Veri Çekme: GetFromJsonAsync

Burada veriyi çekiyoruz ve bu veriyle `posts` listesini dolduracağız.

`await` keyword’unu kullanıyoruz; böylece bir sonraki işleme geçmeden önce isteğin tamamlanmasını bekliyoruz.

Sonra `GetFromJsonAsync` method’unu kullanıyoruz.

Burada `Http` nesnesi bizim kullandığımız “harness”. `Http` üzerindeki `GetFromJsonAsync` method’u, API’den veriyi getirir.

Bu method’a, veri çekmek istediğimiz API URL’sini veriyoruz. Yani bu bir GET çağrısı ve şu endpoint’e istek atıyoruz:

`jsonplaceholder.typico.com/posts`

Bu, uzaktaki (remote) bir API’den veri almak için kullandığımız bir test API’si.

Bu dolduğunda, Blazor directive’lerini kullandığımız için UI otomatik güncellenir. `posts` değişkeni dolunca, sayfa HTML bölümündeki öğeleri API’den gelen verilerle doldurur ve veriyi ekranda görebiliriz.

---

## ▶️ Uygulamayı Çalıştırma ve Sonucu Görme

Şimdi bunu nasıl çalıştığını göstereceğim.

Uygulamayı çalıştıracağız, build edeceğiz ve sonra bu sayfaya gideceğiz.

İlk açılan sayfa Hello World landing page.

Sonra route’u yazıyoruz: **Fetch Data** sayfasına gidiyoruz; bu da bizim oluşturduğumuz sayfa.

Ve burada `Id`, `Title` ve `Body` alanlarını görebiliyoruz.

Bu veriler sahte (fake) veri; demo amaçlı. Ama veriyi internet üzerindeki remote API’den çekti, `posts` değişkenini doldurdu ve HTML bölümündeki elementleri API’den gelen verilerle doldurdu.

---

## 🧯 Try-Catch ile Hata Yönetimi

Kodda yaptığımız bir diğer şey de, isteği bir `try-catch` bloğu içine almak.

Bir şey ters giderse uygulamanın graceful şekilde hata vermesini istiyoruz.

Burada kullanıcı deneyimini daha iyi hâle getirmek için çok daha fazlası yapılabilir. Ama demonstrasyon için, sadece error’ı console’a yazan basit bir `try-catch` kullandık.

Şimdi URL’yi var olmayan bir şeye değiştireceğim ve uygulamayı tekrar çalıştıracağız. Böylece `try-catch` bloğuna düşüp düşmediğini görebiliriz.

Sayfayı yenilediğimde **Loading...** mesajı kalır; çünkü veri hiçbir zaman dolmamıştır.

Bu kod satırında endpoint bulunamadığı için exception oluştu ve console’a yazıldı.

Bunu DevTools üzerinden inceleyebiliriz.

Console’da şu mesajı görürüz: **error fetching data** ve exception message da yazdırılır.

Mesaj şudur: response status code success göstermiyor. Bu bir **404** hatasıdır.

Ve 404, **not found** demektir.

Yani `catch` bloğuna düştü ve bu mesajı console’a yazdı.

---

## ✅ Kapanış

Bu, bir Blazor uygulamasında API çağrıları yaparak remote bir endpoint’e istek atma, yanıt olarak veri alma ve gelen veriyi HTML elementlerine bind ederek ekranda gösterme sürecine dair çok basit bir örnektir.

## 🧩 Customizing API Client Generation

.NET ekosisteminde çalışmanın en iyi yanlarından biri Swagger araçlarıdır. Swagger dokümantasyonunu nasıl ekleyeceğimizi zaten inceledik, peki Swagger API’nizi istemci ( *client* ) kodunda tüketmek istediğinizde ne olur? Swagger’ın gerçekten parladığı bir diğer yer de burasıdır.

Bu videoda, Swagger kullanarak API istemci kodunu otomatik olarak nasıl üreteceğimizi açıklayacağız.

---

## 🧠 Ek Bağlam

Bu bir back-end kursu ve front-end’e çok fazla odaklanmadık; ancak bir front-end, back-end’imize istek ( *request* ) yapan bir istemcidir.

Belki de bir istemci oluşturmanın en kolay yolu basit bir komut satırı ( *command line* ) uygulamasıdır, o yüzden bunu yapalım.

---

## 🖥️ Basit Console App Oluşturma

Burada bir uygulama oluşturdum ve bu standart bir console app.

```bash
dotnet new console
```

Bunu Command Palette üzerinden de yapabilirsiniz.

Bu, basit bir uygulama oluşturmanın gerçekten kolay bir yoludur.

Ayrıca şunu da belirtmek istiyorum: Burada bir sunucum çalışıyor ve şu anda bu URL’de çalışıyor; Swagger entegrasyonu yerleşik olan blog CRUD API’sini sunuyor.

Dolayısıyla istemci üretimi için burada bunu tüketebileceğiz.

---

## 🔧 İstemciden Sunucuya Manuel İstek Atma Süreci

Şimdi istemciden sunucumuza manuel olarak istek yapma sürecini adım adım anlatacağım.

İlk olarak bir **`HttpClient`** oluşturacağız ve bu, yeni bir **`HttpClient`** olacak.

Ayrıca API base URL’imizi burada not edeceğim; bu, yukarıda kaydettiğim değer, böylece daha sonra kullanacağım. Bu bizim base URL’imiz.

Sonra bir **GET** isteği yapacağım. Bunun sonucunu **`httpResults`** olarak kaydedeceğim ve **`await httpClient.GetAsync`** yapacağım; adından da anlaşılacağı gibi, asenkron olarak bir GET isteği yapacak.

Bunun için kullanacağım string, API base URL’imiz olacak ve ardından **`/blogs`** gelecek. Bu, blog path’imize bir GET isteği yapacak.

İlk yapacağım şey, bu sonuçların status code’unun **OK** olup olmadığını kontrol etmek.

**`httpResults`** ve  **`StatusCode`** ’a ihtiyacım var ve bunun  **`System.Net.StatusCode.OK`** ’ye eşit olmadığını kontrol edeceğim.

Eğer eşit değilse, **`Console.WriteLine`** yapıp “failed to fetch blogs” diyeceğim. Sonra **return** edeceğim; yani fonksiyondan çıkacağım.

Eğer OK ise, devam edeceğiz.

İlk olarak blog’u okumak için bir stream oluşturacağım; **`await`** diyeceğim ve  **`httpResults.Content`** ’e ihtiyacım var; yani bu sonuçların content’ine bakacağız ve sonra **`ReadAsStreamAsync`** yapacağız.

Sonraki yapacağım şey, bu blog’ları tutacak bir stream oluşturmak ve sonra **`await httpResults.Content.ReadAsStreamAsync`** çağırmak.

Bu, artık içine okunacak bir stream verecek ve sonra bunu deserialize etmemiz gerekecek.

Bu yüzden bazı deserializer options istiyoruz. **`new System.Text.Json.JsonSerializerOptions`** diyeceğiz. Sonra bir satır aşağı inip süslü parantez açacağız ve *property name case insensitivity* gibi birkaç şeyi set etmek istiyoruz; bunu **true** yapacağız ki büyük-küçük harf duyarlılığını doğru ele alabilelim.

Bunu yaptıktan sonra, bu yeni ayarlarla deserialize edeceğiz. **`var blogs = await System.Text.Json.JsonSerializer.DeserializeAsync`** diyeceğiz. Sanırım async, evet, istediğim bu.

Bu, **`List<Blog>`** alacak. Bunun ne olduğunu henüz bilmiyor; o yüzden **Blog** class’ını oluşturalım.

```csharp
class Blog
{
    public required string Title { get; set; }
    public required string Body { get; set; }
}
```

Şimdi bir  **Blog** ’umuz var; dolayısıyla orada **`List<Blog>`** diyebiliriz.

Bu bir metot olduğu için, o metodu çağırmak istiyoruz ve iki şey alacak:

* Daha önce oluşturduğumuz stream
* Options

Son yapacağım şey, Blog’u yanlış yazmış gibi görünüyorum; o yüzden **Blog** yapacağız.

Şimdi sonunda blogs elimizde, artık onlarla bir şey yapabiliriz.

**`foreach (var blog in blogs)`** deyip, **`Console.WriteLine`** ile title, iki nokta, sonra body yazdıralım; **`blog.Body`** ve  **`blog.Title`** ’a ihtiyacım var.

Burada **possible null reference** uyarısını fark edeceksiniz; o yüzden aşağıya inip, blogs’un gerçekten gelmemiş olabileceğini ele almam gerekiyor.

Dolayısıyla, **`if (blogs != null)`** ise bunu yap, değilse yapma.

Bunu bir seviye içeri girinti yapacağız.

Teoride bu kod artık çalışmalı. O halde terminale gidip şunu diyelim:

```bash
dotnet run
```

Burada “my first post”, “my second post” çıktısını alıyoruz ve hâlâ ihtiyacım olmayan “Hello World” satırı da var.

Bu, blog’umuza manuel istek atma şeklinizdir:

* Base URL gerekir
* Oraya GET isteği atarsınız
* Status code’un OK geldiğini kontrol edersiniz
* Deserialize edersiniz
* Bunun için options ayarlarsınız
* İçine yüklemek için stream oluşturursunuz
* Null olmadığını kontrol edersiniz
* Son olarak onunla bir şey yaparsınız

Bir sürü adım var.

---

## 🧰 Üretilmiş İstemciyle Daha Kolay ve Daha Güvenli

Ama bunu, üretilmiş ( *generated* ) bir istemci kullanarak çok daha kolay ve çok daha güvenli şekilde yapabiliriz.

Bunu yapmak için bu projede yeni bir dosya oluşturacağım. Dosyanın adı **client generator** olacak.

Sonra burada bir paket daha ekleyeceğiz. Yine NuGet’ten bir paket istiyoruz; NSwag ama bu sefer **code generation C#** olanı:

*NSwag.CodeGeneration.CSharp*

Şimdi ihtiyacımız olan her şeyi içeri alacak bir sürü using statement kopyalayıp yapıştıracağım; hepsini yazmamı izlemek zorunda kalmayın:

* `System`
* `System.IO`
* `System.Net.Http`
* `System.Threading.Tasks`
* `NSwag`
* `NSwag.CodeGeneration.CSharp`

Bu çok kod gibi hissedebilir, ama burada önemli olan şunu hatırlamak: Bunu bir kere çalıştıracağız.

---

## 🧱 Swagger Client Generator Sınıfı

Önce bir public class oluşturacağız. Adı **SwaggerClientGenerator** olacak.

Sonra **`public async Task GenerateClient`** yazacağım.

Burada da önceki gibi:

**`var httpClient = new HttpClient`**

Sonra bununla ne yapacağız? Şunu diyeceğiz:

**`var swaggerJson = await httpClient.GetStringAsync`**

Sonra bunun içine, sunucumuzun base URL’ini yazacağız; bu örnekte:

* `http://localhost`

Portun ne olduğunu görelim; yukarıda olmalı: **5230** (ya da sizin portunuz neyse onu ayarlayın).

Sonra da:

* `swagger/v1/swagger.json`

Unutmayın, bu API’miz için ham ( *raw* ) JSON dokümanıdır. Generator bunu tüketecek.

Bu, programatik olarak “API’niz her şeyi yapabiliyor” bilgisini okuyabileceği bir yol.

Şimdi o belgeyi oluşturacağız:

**`document = await OpenApiDocument.FromJsonAsync`**

Bu, az önce aldığımız swagger JSON’u alacak ve document’i ondan oluşturacak.

Sonra generator için bazı ayarlar oluşturmak istiyorum:

**`new CSharpClientGeneratorSettings`**

Sonra class name’i belirleyelim; buna **BlogApiClient** diyelim. Bunları hatırlamak isteyeceğiz çünkü daha sonra lazım olacak.

Şimdi **CSharpGeneratorSettings** oluşturacağız ve bir namespace vereceğiz:

Namespace: **BlogApi**

Bunlar namespace ve class’a erişirken kullanacağımız adlar olacak. İsterseniz bunları istediğiniz gibi değiştirebilirsiniz. Bu örnekte bunların mantıklı olduğunu düşünüyorum.

Son olarak bir generator oluşturacağız:

**`new CSharpClientGenerator`**

Ve buna biraz önce oluşturduğumuz document’i ve settings’i geçeceğiz.

Bu, dokümantasyondan ve belirlediğimiz ayarlardan kod üretecek şeydir.

Son olarak şunu diyebiliriz:

**`var code = generator.GenerateFile`**


## 🧩 Customizing API Client Generation

Böylece bu aslında bir sürü metin üretiyor ve bu metin aslında C# kodu. Sonra da bunu bir dosyaya yazabiliriz: **`File.WriteAllTextAsync`** kullanarak, aslında istediğim de bu.

Bir isim verelim. Buna **blog API client** diyeceğim. Son olarak neyi kaydedeceğiz? Uzantıyı unuttum, o yüzden **`BlogApiClient.cs`** olacak ve kodumu oraya kaydedeceğim.

Artık API istemci kodumuzu üretmek için yapmamız gereken her şey bu kadar. İstemci oluşturmak istediğimiz her seferinde bunu çalıştırırız; bu da API’mizde değişiklik yaptığımız her sefer demektir. Yeni route’lar eklersek ya da yeni davranışlar eklersek, muhtemelen bunu yeniden üretmek isteriz; böylece istemcide kullandığımızda veya istemciyi geliştiren kişiye verdiğimizde, alttaki kodumuzu doğru şekilde yansıtır.

Şimdi tek yapmamız gereken, bunu kullanmak. O yüzden az önce yazdığımız tüm kodu comment out edelim; çünkü artık buna ihtiyacımız yok.

---

## 🧰 Client Kodunu Üreticiyle Oluşturma

Tamam, şimdi hepsi comment out olduğuna göre, yukarı geri çıkıp şunu yazabiliriz:

**`await new SwaggerClientGenerator().GenerateClient();`**

Bu, burada oluşturduğumuz generator; **`SwaggerClientGenerator`** ve **`GenerateClient`** metodunu çağırıyoruz.

Şimdi biraz sihir göreceksiniz. Kaydettikten sonra **`dotnet run`** yaparsam, artık şunu görüyoruz:  **`BlogApiClient.cs`** .

Bu devasa bir dosya; muhtemelen yüzlerce ve yüzlerce satır C# kodu var ve API’mizle nasıl çalışılacağını anlatıyor.

Şimdi programımıza geri dönüp bunu comment out edeceğim, çünkü bunu tekrar çalıştırmamıza gerek yok. Bu kodu yalnızca API istemcimizi üreteceğimiz zaman çalıştırmamız gerekiyor. Bu örnekte bunu bir kere yaptım ve API’mi değiştirmediğim için tekrar yapmam gerekmeyecek.

Normalde bunu iki ayrı projeye bölerdim, ama gösterim kolaylığı için burada tek projede entegre şekilde gösteriyorum.

---

## 🔌 Üretilen Client Kodunu Kullanma

Şimdi bu istemciyi nasıl kullanabileceğimize bakalım.

İlk yapmak istediğim şey, blog client’ını import etmek; sanırım **`BlogApi`** diye adlandırmıştım. İşte burada:  **BlogApi** .

Önce  **BlogApi** ’yi import edeceğim; bunu generator’da da kullanmıştık. Yani **BlogApi** ve sonra **BlogApiClient** istiyoruz.

Şimdi şunu yazalım:

`var client = new BlogApi.BlogApiClient(...)`

Bu bir base URL istiyor. Bunu buradan alacağız. Ayrıca bir `HttpClient` da istiyor.

Dolayısıyla o iki satırı uncomment edebiliriz ve:

* API base URL’i
* HttpClient

ile birlikte geçeriz.

Böylece yeni client’ımız oluşur ve aslında burada `BlogApi` yazmama gerek yok, sadece **`BlogApiClient`** yeterli.

Bu artık API’mizle nasıl çalışacağını bilen bir nesne.

---

## 📥 Blogları Çekme

Şimdi blogları almak istiyorsam:

`client.BlogsGetAllAsync()` (ya da benzeri)

Bunun bir şey istemediğini görüyorum, o yüzden noktalı virgül koyabiliriz.

Şimdi bloglarımız var.

Bunlarla ne yapabiliriz? Önceden yaptığımız gibi aynı şeyi yapabiliriz. Aşağıdaki for döngüsünü alıp buraya yapıştırabiliriz.

Ama bir saniye, burada `await` etmem gerekiyor çünkü bu async. Yoksa task geri dönüyor olur.

Artık bunu await ediyorum ve blog’ların üzerinden dönebilirim.

Ben for döngüsünü buradan alıp aşağıya yapıştırıyorum ve comment ediyorum.

Şimdi bu kodu çalıştırabiliriz ve sanırım artık o `if` kontrolüne gerek yok; çünkü bunu biz uğraşmadan düzgün şekilde ele alıyor.

Kaydedip **`dotnet run`** yapalım.

Ve işte: iki blog’umuz var.

Buradaki birkaç satır kod, az önceki koca bloğun yerini aldı.

Buraya gelmek için çok adım atmış gibi hissedebiliriz, ama şunu tekrar vurgulamak istiyorum: Bu generator kodunu bir kez yazıyoruz. Bunu bir daha değiştirmemize gerek yok. API değiştikçe tekrar tekrar çalıştırırız.

Eğer API’ye sadece tek bir çağrı yapacaksam, muhtemelen bir API client üretmeye vakit ayırmaya değmez. Ama diyelim ki bir blog silmek de istiyorum.

---

## 🗑️ Blog Silme ve ➕ Blog Oluşturma

Örneğin:

`client.BlogsDeleteAsync(...)`

İlkini silmek istiyorum diyelim; bunu yapabilirim.

Yeni bir blog oluşturmak için bir blog nesnesi hazırlayalım:

* title: “my title”
* body: “a new body”

Sonra:

`client.BlogsPostAsync(blog)`

Burada da şunu unuttum: bunlar async. O yüzden `await` etmem gerekiyor.

Böylece blog silmek ve blog post etmek, eskiden bunun gibi yepyeni bir kod bloğu gerektirirdi; ama artık buna gerek yok.

Bu metotları kullanabiliriz; bunlar tüm hata durumlarını zarif biçimde ele alır ve doğru tiplerin gönderildiğinden / alındığından emin olur; bizim bunlarla uğraşmamız gerekmez.

---

## 🔄 API Değişince Ne Olur?

Blog’umuzda büyük değişiklikler yaparsak, yeni bir API client üretir ve bunu istemciyi geliştiren kişiye göndeririz.

Bir anda bir sürü hata görürlerse, API’nin “breaking” bir şekilde değiştiğini anlarlar ve kullanıcılar bu problemlerle karşılaşmadan önce kodlarını sorumlu biçimde güncelleyebilirler.

Status code kontrolü, null kontrolü gibi şeylerle uğraşmadık; hepsi arka planda otomatik hallediliyor.

Bu yaklaşım:

* daha kısa,
* daha güvenli,
* daha kolay bakım yapılabilir

ve manuel yazdığımız koda kıyasla daha iyi type safety sağlar.

Ayrıca *IntelliSense* sayesinde kendini dokümante eder.

---

## 🌍 Başka Dillere İstemci Üretme

API’ye yeni nesneler ekleyebilir, mevcut API’yi değiştirebilir ve yeni endpoint’ler ekleyebiliriz; iletişimi sağlıklı tutmak için tek yapmamız gereken, daha önce tanımladığımız yöntemlerle yeni bir API client üretmek.

Hatta sadece birkaç satırı değiştirerek başka bir dil için de istemci üretebiliriz; örneğin TypeScript.

Burada C# generator kullandık. TypeScript generator da var; TypeScript, JavaScript’in tipli sürümüdür.

---

## ✅ Kapanış

İşte böyle: Swagger kullanarak API’niz için otomatik istemci üretmeyi artık biliyorsunuz.

Bu yaklaşım size çok zaman ve emek kazandırır ve istemci kodunuzun her zaman güncel kalmasını, API’nizle senkron olmasını sağlar.

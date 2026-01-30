## 🌐 HTTPClient Kullanarak Blazor’da GET İstekleri Yapma

API’ler (Application Programming Interfaces), internet üzerinde verinin nasıl aktarıldığının adeta belkemiğidir. Mobil uygulama ya da web tarayıcınız gibi bir istemci uygulamanız olduğunda ve veri çekmeniz gerektiğinde, uzak bir sunucudan veri almanız gerekir. Application Programming Interfaces genellikle bunun yapıldığı yoldur. Bu ekran kaydında yapacağımız şey, basit bir uygulama üzerinden, GET komutlarını kullanarak uzak bir API’den nasıl veri alabileceğinizi göstermektir.

Basit bir Blazor uygulaması kurulumum var; bu uygulamayı oluşturmak için `dotnet new Blazor wasm` şablonunu kullandım. Sonra da bu uygulamada Pages klasörüne bir `fetch data dot razor` dosyası ekledim. Buradaki yol  *fetch users* ; siteyi açtığımızda göz atmamız gereken route bu.

Dosyanın en üstünde, C# koduyla etkileşime geçmemizi sağlayan bazı HTML ve Blazor yönergeleri var. Bir `if` ifadesi var: sayfa yükleniyorsa spinner’ı göster; yani bir mesaj gösterilmiyor, sadece spinner görüntüleniyor. Hata mesajı boş değilse, yani görüntülemek istediğimiz bir mesaj varsa, bunu uygulamada kullanıcıya geri gösteriyoruz. Son olarak ikinci `else if` bloğunda, `users` değişkeni `null` değilse—yani C# kodumuz tarafından doldurulmuşsa—API’den aldığımız bilgileri görüntülüyoruz.

Uygulamamızda bir `foreach` ifadesi var; tüm kullanıcı bilgilerini alacak ve bunları bir tablo formatında gösterecek. Son `else` bloğu ise, API çağrısı yapıldıysa, başarılı olduysa ama veri dönmediyse kullanıcıya **no data available** göstereceğimizi söylüyor.

Bu da kullanıcıya daha iyi bir deneyim sunar.

---

## 🧠 C# Kodunun Bulunduğu Bölüm

Burada `@code` yönergemiz var; C# kodumuzun olduğu yer burası ve işin büyük kısmını burada yapacağız. Bu kodda HTTP client’ı kullanacağız; `HTTP.GetFromJsonAsync` metodunu kullanıyoruz. Bu çağrıyı yapmak için de HTTP client’ı kullanıyoruz.

Dosyanın en üstünde HTTP client’ı enjekte edip `HTTP` değişkenine atıyoruz. Bu kütüphaneyi sayfamıza enjekte ettiğimiz için artık o kütüphanenin metodlarını kullanabiliyoruz. Yani bunu sayfanın en üstünde enjekte ediyoruz, sonra da `@code` bölümünde kullanıyoruz.

---

## 👤 User Nesnesi ve Liste Mantığı

Burada ilk yaptığımız şey, bir kullanıcı listesini oluşturmak; `User`, sayfanın en alt kısmında oluşturduğum bir C# nesnesi. `User` sınıfının `Id`, `Name`, `Email` ve `Address` alanları var ve bunlar API çağrısından gelen verilerle doldurulacak.

`Address` alanının da bir nesne olduğuna dikkat edin. Yani address’in parçası olarak `Street`, `Suite`, `City` ve `ZipCode` alanlarını doldurabiliyoruz. Bu da `User` nesnesindeki `Address` alanının tipi oluyor.

İlk yaptığımız şey, bu `User` nesnelerinden oluşan bir liste oluşturmak.

API çağrısı döndüğünde, içinde bir sürü veri olan bir JSON dosyası alacağız. Bu veriden `User` nesnelerini dolduracağız. Sayfanın yüklenip yüklenmediğini anlamak için bir `bool` değişkenimiz var ve gerekirse gösterebileceğimiz bir `error message` değişkenimiz var.

---

## 🔄 FetchUsers Metodu ve Async Davranışı

Sonra `FetchUsers` metodunu oluşturdum. Bunun `async` olduğuna dikkat edin. `FetchUsers` metodunu çağırdığımızda, eğer bu metot birden fazla kez çağrılırsa sıraya girer ve sırayla çalışır. Yani bir kez çağırırsak API’ye gider, verinin dönmesini bekler. Bu metodu birden fazla kez çağırırsak, sırayla çalışmaya devam eder.

Burada HTML tarafında bir buton da var; o butona tıklanınca `FetchUsers` metodu çağrılıyor. Bu, API’den veri alma şeklimiz: butona tıklıyoruz, buton `FetchUsers` metodunu çağırıyor, metot da API’ye çağrı yapıyor.

API çağrısını yönetmek için birkaç değişken daha var ama asıl “büyü” şu satırda gerçekleşiyor: `try` bloğu içindeki `users = await HTTP.GetFromJsonAsync(...)`.

`users` bir listeydi. Metot çağrıldığında `List<User>` tipini geçiriyoruz. Böylece çağrı geri döndüğünde hangi tip veriyle doldurmamız gerektiğini biliyor. Ardından şu adrese çağrı yapıyoruz:

```text
jsonplaceholder.typicode.com/users
```

Bu, kodunuzun çalışıp çalışmadığını test etmek için kullanabileceğiniz bir demo API.

Buradan veri çekiyoruz. Eğer dönen veri, kurduğumuz sınıfın formatıyla uyumluysa—yani dönen veride `Id`, `Name`, `Email`, `Address` alanları varsa ve `Address` da bu şekilde yapılandırılmışsa—listeyi geri gelen `User` nesneleriyle dolduruyoruz.

Dönen verinin yapısını bilmeniz önemlidir. Genellikle sunucu tarafındaki API, dönen veri tipinin ne olduğunu açıklayan bir sayfaya sahiptir; böylece sınıfları doğru şekilde oluşturabilirsiniz.

Bu veri geldiğinde `User` tipinde olacak ve listemizi bu `User` nesneleriyle dolduracağız.

Bir exception oluşursa `catch` bloğuna girecek ve `error message` alanını **error fetching data** ile dolduracak.

---

## ⚙️ Durum Yönetimi

Değişkenleri burada yönetiyoruz. `try` bloğu da çalışsa `catch` bloğu da çalışsa, sonrasında `isLoading = false` yapıyoruz. Sonra da çağrının hangi durumda olduğunu bilmek için state’i değiştiriyoruz.

---

## ▶️ Uygulamayı Çalıştırma ve Sayfayı Test Etme

Kodu çalıştıralım. Derlenmesi biraz sürecek. Ardından siteyi açtığımızda başlangıç sayfasına ineceğiz; bu sadece ana sayfa. Bu, uygulamanın root route’u. Ama istediğimiz sayfayı görmek için `fetch users` sayfasına gidebiliriz.

Gördüğünüz gibi `Users` başlığımız var ve butonumuz var. Şu anda **no data available** gösteriyor çünkü henüz API’ye çağrı yapmadık.

Butona tıklayacağım:  **fetch new users** . API’ye gidiyor, kullanıcıları alıyor ve sayfanın üst kısmında gördüğümüz HTML tablosunu dolduruyor. Yani butona tıklayınca `FetchUsers` çağrılıyor, `jsonplaceholder.typicode.com/users` adresine gidiyor ve veriyi çekiyor.

---

## 🧪 Try/Catch ve Hatalı Endpoint Testi

Şimdi `try catch` bloğunun çalışıp çalışmadığına bakalım. Önce uygulamayı durduracağım. Bu satırı comment’leyip şu satırı uncomment edeceğim.

Bu, var olmayan bir endpoint; yani geçersiz bir endpoint. `GetFromJsonAsync` bu endpoint’e çağrı yapmaya çalıştığında başarısız olacak. Bir exception üretecek ve `error message` dolacak. Veriyi çekmeyi denediğimizde uygulamada bu hata mesajını görmeliyiz.

Uygulamayı yeniden çalıştıracağım. Sonra web sayfama geri dönüp  **fetch new users** ’a tıklayacağım. Ah, sayfayı yenilemem gerekiyor.

Sayfayı yenileyip  **fetch new users** ’a tıkladığımda hata mesajı doluyor:  **error fetching data** . Aldığımız mesaj da şu: yanıt durum kodu başarıyı göstermiyor  **404** ; yani endpoint bulunamadı.

Bu mesaj, kodumuzdaki **error fetching data** ile birlikte exception mesajını da üretir.

Bu çok esnektir; çünkü hangi sorunla karşılaşılırsa karşılaşılsın, hangi exception oluşursa oluşsun, kullanıcı o exception’ı görebilir ve bu sayfayı debug etmeye çalışan birine bilgi sağlayabilir.

---

## ✅ Kapanış

Bu, GET metodunu kullanarak bu API’den veri çeken ve bu veriyi bir `User` nesneleri listesine doldurarak web sayfasında kullanıcıların görebileceği şekilde gösteren çok basit bir uygulamadır.

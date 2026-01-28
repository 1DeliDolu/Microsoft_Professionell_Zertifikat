## 🛡️ ASP.NET Core’da Error Handling

Beklenmeyen sorunlar, doğru error handling olmadan uygulamanızı crash ettirebilir ve user experience’ı olumsuz etkileyebilir. Doğru error handling, sorunların sorunsuz şekilde yönetilmesini sağlar; bilgilendirici mesajlar sunar, developer’lar için hataları loglar ve bir şeyler ters gittiğinde bile istikrarlı bir user experience sağlar. Bu videoda,  *ASP.NET Core* ’da error handling best practice’lerini açıklayacağız.

---

## 🧯 Try-Catch Blocks ile Başlamak

Şimdi  *ASP.NET Core* ’da bazı yaygın error handling tekniklerini inceleyelim; try-catch block’larla başlayalım.

Bir  *try-catch block* , error handling için kullanılan bir programming construct’tur; kodu dener ve exception’ları yakalayarak crash’i önler. Bir kod bloğunu denemenizi sağlar. Execution sırasında bir exception oluşursa, catch block hatayı programı crash ettirmeden handle eder.

Mantık basittir: hata oluşturma ihtimali olan kodu try block içine koyarsınız. Bir hata oluşursa, catch block bunu handle eder. Böylece program crash olmaz ve hata yakalandığında ne olacağını tanımlayabilirsiniz.

Örneğin bir database update başarısız olursa, try-catch block hatayı yakalayabilir ve kullanıcıya yardımcı bir mesaj gösterebilir. Bu, uygulamanın crash olmadan çalışmaya devam etmesini sağlar.

Tüm hataları generic bir exception handler ile yakalamak yerine, database error gibi spesifik exception’ları yakalamak iyi bir pratiktir. Bu, bir şeyler ters gittiğinde sorunları daha kolay pinpoint edip fix etmeyi sağlar.

---

## 🧩 Try-Catch Block’un Üç Parçası

Try-catch block’un üç ana bölümü vardır.

İlk olarak, hata oluşma ihtimali olan kodu koyduğunuz yer try block’tur. Örneğin iki variable’ımız varsa; numerator `10` ve denominator `0` ve bunlarla bir bölme işlemi yapmayı planlıyorsak, denominator `0`’ın programı crash ettirmediğinden emin olmamız gerekir.

İkinci olarak, catch block try block içindeki exception’ları handle eder. Örneğin denominator `0` olduğunda, bir catch block kullanarak exception’ı ele alırız ve console’a `console.writeLine` ile “error cannot divide by zero” mesajını yazdırırız.

Bu yapı, spesifik exception’ları yakalayacak şekilde de yazılabilir. Bu örnekte, .NET’te built-in bir arithmetic exception olan `divideByZeroException` kullanıyoruz.

Üçüncü olarak `finally` block ekleyebilirsiniz. Bu, hata oluşup oluşmadığına bakmadan bir dosyayı kapatmanızı veya memory release etmenizi sağlar. Burada, division denemesinden sonra bir finally block ekleriz ve `console.writeLine` ile “division attempt completed” mesajını veririz. Bu, kullanıcıya operasyonun bittiğini bildirir.

---

## 🌍 Global Exception Handling Neden Gerekli?

Try-catch block’lar belirli hataları handle eder, ancak bu block’ların dışında kalan hatalar için global exception handling gerekir.

 *Global exception handling* , runtime sırasında oluşan tüm handle edilmemiş exception’ları yakalamak ve yönetmek için merkezi bir mekanizmadır.

Bireysel kod block’larında exception handling yapmanın dışında, global exception handling hatanın nerede olduğuna bakmadan tek bir yerde yakalanmasını ve yönetilmesini sağlar.

Örneğin, uygulamanızın bağlı olduğu bir third-party service fail olursa, global exception handling bu hatayı yakalayabilir, loglayabilir ve “there’s an issue. Please try again later.” gibi bir mesaj gösterebilir.

 *ASP.NET Core* ’da middleware kullanarak request sırasında oluşan exception’ları yakalayabilir ve bunları handle/loglamak için global bir yer sağlayabilirsiniz. Bu, kullanıcıların düzgün bir error message almasını sağlar.

---

## 🧱 Middleware ile Global Exception Handling Konfigürasyonu

Şimdi middleware’i adım adım nasıl configure edeceğimizi inceleyelim.

İlk olarak, `Program.cs` dosyası içinde doğrudan middleware ile global exception handling oluşturursunuz.

`app.use` method’u exception handling implement etmek için kullanılabilir.

Bu method, ASP.NET Core’da middleware pipeline setup’ının bir parçasıdır.

Request-response pipeline sırasında çalıştırılacak middleware’i register eder.

Bu, `context` ve `next` adında iki parametre alan asynchronous bir function’dır.

`context` parametresi mevcut HTTP request-response context’ini temsil eder, `next` ise pipeline’daki bir sonraki middleware’i temsil eder.

Middleware function’ının gövdesi şu an boş; yani context ile bir şey yapmıyor veya request-response’u modify etmiyor.

Sonra `app.use` method’unun içine bir try-catch block ekleriz.

Try block request’in devam etmesine izin verirken catch block herhangi bir exception’ı yakalar.

`next.invoke`, request’i pipeline’da daha ileri işlemek için bir sonraki middleware’i çağıran asynchronous bir method’dur.

`await` kullanmak bu operasyonun awaited olmasını sağlar; yani bir sonraki middleware işini bitirene kadar execution bu block içinde devam etmeden bekler.

Pipeline’ın başka bir yerinde request işlenirken bir exception oluşursa, catch block bunu capture eder.

Son olarak, custom bir error message döndürmek için `console.writeline` kullanırız.

Bu örnekte mesaj “global exception caught” ve ardından hataya uygun bir mesaj olur.

Örneğin, divide by zero denerseniz mesaj “global exception caught, attempted to divide by zero” şeklinde olabilir.

---

## 🧾 Loglamak ve HTTP Status Code Döndürmek

Son olarak, hatayı loglarız ve bir error status code döndürürüz.

Bu örnekte bir exception olursa, catch block içinde `exception ex` ile exception message’ını console’a loglarız.

`$ex message` syntax’ı string interpolation’dır; yani exception message’ını string içine dinamik olarak yerleştirir.

String interpolation, `$` ve `{ }` içine alınmış değişken/ifade kullanımıyla yapılır.

Bu, exception message gibi harici bir değişkeni veya response’u mesaj string’inize eklemenizi sağlar.

Exception message, yakalanan exception’a özeldir.

C#’ta `divide-by-zero exception` veya `null-reference exception` gibi birçok built-in exception vardır.

Bu örnekte error aldığımızda, programın `500` status code göstermesini isteriz; bu `internal server error` anlamına gelir.

Sonra HTTP response body’sine asynchronous şekilde bir error message ekleriz.

`await` ile `context.response.writeAsync` kullanırız ve string mesaj olarak “an unexpected error occurred, please try again later” göndeririz.

`await` kullandığımız için, `writeAsync` çağrısı awaited olur; yani response yazılırken diğer operasyonları block etmez.

---

## ✅ Kapanış

Bu videoda,  *ASP.NET Core* ’da best practice’leri kullanarak error handling yapmayı öğrendiniz.

Try-catch block’ları ve global exception handling kullanarak client ve server error’larını yönetmeyi; handle edilmemiş hataları yakalamayı ele aldık.

Middleware, exception’ları merkezi olarak yönetmeye yardımcı olur; anlamlı error message’ları sağlar ve uygulama stabilitesini iyileştirir.

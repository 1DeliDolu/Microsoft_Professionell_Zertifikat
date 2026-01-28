## 🧩 Implementing Middleware Components

Program.cs dosyasındayız ve bu adımda bu ASP.NET *middleware* uygulaması için kullanacağımız bazı servisleri ekleyeceğiz.

Dosyanın en üstünde **`builder`** adında bir değişken oluşturuyoruz ve bu değişkeni **`CreateBuilder`** metodunun sonucuna eşitliyoruz. **`CreateBuilder`** metodu, bu ASP.NET uygulamasına servis eklememizi sağlar.

---

## 🧾 Logging Servisini Ekleme

Sonraki birkaç satırda **`builder.Services.AddHttpLogging`** ile *logging* özelliğimizi kuruyoruz. Yine **`builder`** değişkenini kullanıyor ve bu değişken üzerinden **`Services`** çağırarak uygulamaya *logging* ekliyoruz.

**`LoggingFields`** alanında hangi tür alanları loglamak istediğimizi ayarlıyoruz ve bu örnekte **all** olarak ayarlıyoruz. Satırın sonunda **`HttpLoggingFields.All`** görünüyor; yani her şeyi yakalayacağız.

---

## 🔐 Authentication ve Authorization Servisleri

Sonraki iki satır, ASP.NET uygulamasına *authentication* ve *authorization* ekliyor. Yine **`builder`** değişkenini kullanıyoruz ve bu iki özelliği uygulamaya eklemek için **`Services`** çağırıyoruz; bu kod bunu yapmamıza izin veriyor.

---

## 🏗️ Uygulamayı Build Etme

Son olarak **`app`** değişkenini **`Build`** metoduna eşitliyoruz; bu, uygulamadan az önce talep ettiğimiz tüm özellikleri oluşturmasını ( *build out* ) istediğimiz anlamına gelir.

---

## 🧯 Exception Handler Ortama Göre Ayarlanması

Buradaki **if else** ifadesi bir  *exception handler* ’dır. Şunu söylüyoruz:

Uygulama bir development ortamı değilse, **`Home/Error`** yolunda exception handler kullanacağız ve production seviyesinde bir exception handler çalıştıracağız.

Eğer development ortamıysa, sadece developer exception handler’ı kullanacağız.

Developer exception handler, bir hata aldığınızda size daha fazla bilgi verir; bu da sorun giderme ( *troubleshooting* ) sırasında geliştirici için faydalı olabilir.

Production seviyesi handler ise çok fazla bilgi çıktısı vermez; burada yaptığımız şey budur.

---

## ✅ Authentication ve Authorization’ı Pipeline’da Kullanma

Ardından **`app.UseAuthentication`** ve **`app.UseAuthorization`** satırlarına geliyoruz. Uygulamaya artık daha önce oluşturduğumuz bu özellikleri kullanmasını söylüyoruz.

Yani uygulamaya onları build etmesini söylemiştik, şimdi de bu iki özelliği gerçekten kullanabildiğimizden emin olmak istiyoruz. **`UseAuthentication`** ve **`UseAuthorization`** bize bunu sağlar.

---

## 🧾 Http Logging’i Pipeline’da Kullanma

Son üç satırdaki  **`app.UseHttpLogging`** , *UseAuthentication* ve  *UseAuthorization* ’a benzer. Uygulamaya daha önce oluşturduğumuz bu özelliği kullanmasını söylüyoruz.

 **`app.MapGet`** , root seviyesindeki URL’ye hit ettiğimizde dönecek olan şeyi tanımlar.

Son olarak en altta **`app.Run`** var. Şimdilik bu satırları atlayacağız.

En altta **`app.Run`** bulunur ve  **`app.Run`** , uygulamayı gerçekten başlatabilmemizi sağlar.

Bu, uygulamanın ana gövdesindedir.

---

## 🧩 Custom Middleware Ekleme

Şimdi üçüncü adıma geçiyoruz. Burada orta bölümde, dosyanın gövdesinde bazı custom middleware ekleyeceğiz.

İki tane **`app.Use`** ifademiz var. Bunlar bizim “simüle edilmiş”  *middleware* ’lerimiz.

Bunların middleware olduğunu anlayabilirsiniz çünkü **`async (context, next)`** kullanıyoruz; bu, uygulama çalıştıkça bu **`app.Use`** bloğunun içindeki her şeyi çalıştırmaya çalışacağı anlamına gelir.

---

## 🧾 İlk `app.Use`: Path ve Status Code Yazdırma

İlk blokta **`app.Use(async context next)`** içinde console’a iki satır yazdırıyoruz:

* request’in  **path** ’i
* request’in  **status code** ’u

Bu çok basit iki şey.

Bu “tırnak içinde middleware” çok fazla bir şey yapmaz. Sadece console’a mesaj basar.

Ama **`next`** komutu olduğu için, o bloğu çalıştırdıktan sonra bir sonraki **`app.Use`** bloğuna geçer.

Bu yüzden middleware’dir; çünkü bu kodu ardışık şekilde çalıştırır ve gerçek bir uygulamada görevleri yerine getirmemize olanak tanır.

---

## ⏱️ İkinci `app.Use`: Süre Ölçme

İkinci blok çok benzer, ancak burada **`startTime`** adında bir değişken oluşturuyoruz ve bunu mevcut zamana eşitliyoruz.

Bu middleware’in yaptığı ilk şey, az önce ayarladığımız değişkeni kullanarak  **start time** ’ı console’a yazdırmaktır.

Sonra bir sonraki öğeye geçmeden önce biraz bekleyecektir.

Ardından **`duration`** değişkenini, yani  **`var duration`** ’ı, mevcut zaman eksi start time olacak şekilde ayarlar.

Bu bize farkı verir ve o işin ne kadar sürdüğünü gösterir.

Sonra da console’a bunun kaç milisaniye sürdüğünü yazar.

---

## 🔗 Middleware Zinciri Mantığı

Bu da yine simüle edilmiş bir middleware parçasıdır. Bu bloğun içine gerçek iş yapmak için neredeyse her şeyi koyabilirsiniz.

Uygulama çalıştığında, önce birinci **`app.Use`** bloğunu çalıştırır, sonra ikinci **`app.Use`** bloğunu çalıştırır.

Gerçek bir uygulamada ihtiyaç duyduğunuz kadar bu bloklardan zincirleyebilirsiniz.

Bu uygulamada custom middleware’in çalışma şekli budur.


```
var builder = WebApplication.CreateBuilder(args);

// Add services for logging, authentication, and authorization
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddAuthentication();  // Authentication service
builder.Services.AddAuthorization();   // Authorization service

var app = builder.Build();

// Configure exception handling middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");  // Production exception handler
}
else
{
    app.UseDeveloperExceptionPage();         // Detailed error pages in development
}

// Authentication & Authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Add HTTP logging middleware
app.UseHttpLogging();

// Custom middleware: log request path & response status
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request Path: {context.Request.Path}");
    await next();
    Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
});

// Middleware to track request duration
app.Use(async (context, next) =>
{
    var startTime = DateTime.UtcNow;
    Console.WriteLine($"Start Time: {startTime}");
    await next();
    var duration = DateTime.UtcNow - startTime;
    Console.WriteLine($"Response Time: {duration.TotalMilliseconds} ms");
});

// Endpoint
app.MapGet("/", () => "Hello, ASP.NET Core Middleware!");

app.Run();

```

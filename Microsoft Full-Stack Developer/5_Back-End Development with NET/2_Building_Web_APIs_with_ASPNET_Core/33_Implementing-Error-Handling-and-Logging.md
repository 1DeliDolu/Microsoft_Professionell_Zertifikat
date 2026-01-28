## 🧪 Error Handling ve Logging’i Uygulama

Bu lab’de temel bir web API projesi oluşturacağız ve hem basic hem de global error handling yapacağız. Bu hataların nasıl ele alındığını göstermek için temel *ASP.NET logging* kullanacağız ve ardından daha robust logging için bazı third-party logging library’leri de kullanacağız.

---

## 🧱 Adım 1: Projeyi Kurma

İlk adımda projeyi kuruyoruz. Bu, temel bir web API projesi olacak ve `Error Handling Project` olarak adlandıracağız.

Bunu `dotnet new webapi` komutuyla oluşturacağız; bu komut templated bir application yaratır.

---

## 🧩 Adım 2: Endpoint’te Basic Error Handling Eklemek

İkinci adımda uygulamamızdaki endpoint’lerden birine basic error handling ekleyeceğiz.

Bunun için root dizinde bir `controllers` folder oluşturdum ve içinde uygulamanın kullanacağı route’u tutan `ErrorHandlingController.cs` dosyasını oluşturdum.

Burada route’un ayarlı olduğunu görebilirsiniz.

`api/` var ve ardından köşeli parantez içinde `controller` var; bu, bu route için istediğiniz controller adını geçebileceğiniz anlamına gelir.

Ama route içinde `api/` olmalı, ardından controller adını geçebilirsiniz.

Buradaki route’lardan biri `HttpGet`.

Bu, CRUD operasyonlarının bir parçasıdır.

CRUD’un read operasyonudur.

`division` adlı bir route alacağız; yani bunun için `api/division` yapacağız.

Sonra `getDivisionResults` adında bir method’umuz var ve bu route üzerindeki call’da method call’un bir parçası olarak bir numerator ve bir denominator geçeceğiz ve numerator ile denominator üzerinde matematik yapmayı deneyeceğiz.

Şimdi burada bir error handler olduğunu fark edin.

Bir try-catch block var.

Try block, denominator’ı numerator’a bölmeyi dener ve sonucu geri döndürür.

Eğer bir sorun olursa, division operasyonunda herhangi bir issue yaşarsak kod catch block’a düşer.

Console’a division by zero’nun allowed olmadığını yazarız ve ardından calling application’ın response’un valid olmadığını bilmesi için bad request response döndürürüz.

Bu CS file’ın bu specific route için içerdiği her şey bu.

Bu, route’a verdiğimiz variable’lar üzerinde division yapmaya çalışan çok basit bir operasyondur.

---

## 🌍 Adım 3: Global Error Handling Implement Etmek

Üçüncü adımda global error handling implement edeceğiz.

Controller içindeki error handling division operasyonuna çok spesifikti.

Global error handling’i de implement edebiliriz ve bunun için `Program.cs` dosyasına geri döneceğiz.

Builder’ı implement ettikten sonra; yani `WebApplication.CreateBuilder` ile uygulama için gereken altyapıyı kurduktan sonra, `builder.Services.AddControllers` satırına geliyoruz.

Bu, eklediğimiz `ErrorHandlingController.cs` dosyasını kullanmamıza izin verir.

Sonra `app builder` kısmına geçiyoruz.

Bu kodu ve diğer kodları birazdan tekrar ele alacağız; ama şu an sadece builder kodunu istiyoruz.

Middleware olarak `app.Use` kullanacağız ve bunun içinde global bir error handler yazacağız.

Bu, uygulama her çalıştığında run olur ve çalışması gereken diğer operasyonları run etmeye çalışır.

Eğer düzgün çalışmazsa catch block’a düşer.

Division route’unda spesifik bir error handler vardı.

Burada ise, error handling’i olmayan başka operasyonlar oluşturursak, bu onları da yakalar ve `500` status code döndürür, “global exception caught” mesajını verir ve kullanıcıya bir şeylerin ters gittiğine dair bir response döndürür.

En sonda, uygulamaya routing kullanmasını, kurduğumuz tüm controller’ları map etmesini ve uygulamayı başlatmasını söyleriz.

Bu, division operasyonuna özel error handling’den farklı olarak global error handling’dir.

---

## 🪵 Adım 4: Logging’i Implement Etmek

Şimdi logging implement etmek istiyoruz.

Yukarıda birkaç logging komutu eklediğimi görebilirsiniz:

* `builder.Logging.ClearProviders`
* `builder.Logging.AddConsole`

Bu iki method, basic *ASP.NET logging* kullanarak logging altyapımızı oluşturur.

Bunu yaptığımızda console’a log atabiliriz ve web browser üzerinden developer’a veya debug etmek isteyen kişiye mesajlar sağlayabiliriz.

Basic *ASP.NET infrastructure* ile doğrudan console’a log yazabiliriz.

---

## 🧰 Adım 5: Serilog ile Third-Party Logging Entegrasyonu

Beşinci adım Serilog ile third-party logging’i entegre etmek.

Serilog, logging için kullandığımız spesifik bir library’dir.

En üstte `using Serilog` yazdığımı görebilirsiniz; bu, uygulamaya bu library’yi kullanmak istediğimizi bildiren using statement’tır.

Bundan önce, `dotnet add package` ile library’yi uygulamaya ekledik.

Bu package’ların yüklü olduğunu `csproj` dosyasına giderek doğrulayabiliriz.

Orada şu package reference’ları görürsünüz:

* `Serilog.AspNetCore`
* `Serilog.Sinks.Console`
* `Serilog.Sinks.File`

Bu üç include statement, üç farklı package yüklediğimiz anlamına gelir:

Serilog’u ASP.NET Core ile kullanmak için temel altyapı,

Serilog ile console’a log yazmak için,

Serilog ile file’a log yazmak için.

Bunları implement ettikten sonra Serilog kullanarak logger’a çağrılar yapabiliriz.

En üstte using statement’ımız var ve artık Serilog library’si ile ihtiyaç duydukça yeni log’lar oluşturabiliriz.

Şu satırı görürsünüz:

`Log.Logger = new LoggerConfiguration()...`

Bu bir Serilog logger configuration setup’ıdır.

Bu configuration içinde Serilog’a hem console’a hem de `logs/myapp.txt` dosyasına log yazmasını söylüyoruz ve bu log’ları ne sıklıkla yazacağını belirtiyoruz.

Sonra `.CreateLogger` bu logger’ı oluşturur.

Artık API’de olan her şey, console’a ve file’a daily rolling interval ile loglanabilir.

Ardından `builder.Host` üzerinden Serilog library’sini log oluşturmak için kullanmasını söyleriz.

Böylece logging için third-party bir seçenek kullanmış oluruz.

Hem ASP.NET’in internal logging sistemini hem de Serilog’u daha robust logging için kullanabiliriz.

## 🎬 Temel API Endpoint’lerini Uygulama

Tamam, bu kursun en heyecan verici kısmı burası. Nihayet *ASP.NET Core* kullanarak ilk *.NET* web uygulaması kodunuzu yazacağınız o ana gelmek için altyapıyı hazırlıyorduk.

Bu videoda,  *ASP.NET Core* ’da temel API endpoint’lerini uygulayacağız.

---

## 🧱 Temel Bir Web Uygulaması Oluşturma

Bunu yapmanın en kolay yollarından biri, hiçbir şey açık değilken yepyeni bir *Visual Studio Code* penceresiyle başlamaktır. Bunu yaptığınızda `Create .NET project` seçeneğini görürsünüz.

Bir proje oluşturacağız. Bunu daha önce gösterdiğimiz gibi *Command Palette* üzerinden de yapabilirsiniz. Terminal üzerinden de yapabilirsiniz.

`ASP.NET Core empty` seçeneğine gideceğiz. Burada bir sürü farklı web proje türü olduğunu fark edeceksiniz. Bunlardan birini seçmek istemezsiniz çünkü bunlar bunun çok daha karmaşık sürümleridir.

Bu, gerçekten basit, “bare bones” bir web API ya da web uygulamasıdır. Ve bunların hepsi aslında bunun üzerine inşa edilmiştir.

Dolayısıyla  *API’ler* ,  *gRPC* ,  *MVC* ,  *Razor Pages* , hatta *Blazor* gibi bir sürü farklı şey göreceksiniz. Bunlardan birini seçerseniz, siz `empty web` olanı istiyorsunuz.

---

## 📁 Projeye Klasör Seçme ve İsim Verme

Hadi buna yaşayacağı bir klasör verelim. Ben `Basic API Endpoints` adında yeni bir klasör oluşturacağım. Onu oluşturacağım, o klasörü seçeceğim, `Select Folder` diyeceğim.

Bir isim istiyor. Ben klasörle aynı ismi kullanmayı seviyorum ama kullanmak zorunda değilsiniz. Sonra `Enter`’a basacağım.

Template seçeneklerinin hiçbirini değiştirmenize gerek yok, bu yüzden projeyi oluşturacağız. Burada bir saniye verin. O “flash”ı göreceksiniz. Ve bam, projemiz oluşturuldu.

Burada `Program.cs` dosyamızı göreceksiniz.

---

## 🧩 `Program.cs` ve Az Kodla Çok İş

Bu bir web uygulaması. Burada muhtemelen ilk fark edeceğiniz şey şu: çok fazla kod yok. Sadece dört satır.

Bu, *.NET* ile çalışmanın sayesinde. Kodu çalıştırdığımızda bizim adımıza on binlerce satır kod çalışacak. Ama sizin sadece bu dört satırı dert etmeniz gerekiyor.

Bunlar, bizim uygulamamıza özel olan satırlar.

Bilgisayarınızdaki en alt seviyedeki donanıma kadar giden bir sürü kod çalışacak. Bununla ilgilenmenize gerek yok. Sizin ilgilenmeniz gereken şey sadece bu.

Sunucuyu kurmakla, bu “fancy stuff” ile uğraşmıyorsunuz. Sadece API’nizi ve API route’larınızı kuruyorsunuz. Uygulamanın çekirdeği burada başlıyor.

---

## 🏗️ `WebApplication`, `CreateBuilder`, `Build`

`WebApplication` adında bir paketimiz olacak. Bu class üzerinde `CreateBuilder` metodunu çağıracağız ve bu bir `builder` oluşturacak.

Peki builder ne inşa eder? Builder web uygulamaları inşa eder.

Builder’ımızı alıp `Build` çağırırız ve bu da bize `app` döndürür.

Bu biraz “verbose” görünebilir. Neden tüm bunlara ihtiyacınız var?

Çünkü builder, daha sonra göreceğimiz üzere, uygulamayı build etmeden önce bazı şeyleri değiştirmemize izin verir. Bazı ayarları ve konfigürasyonu değiştirmemizi sağlar.

Burada bunların hiçbirini yapmıyoruz. Çok basit ve düz bir şeyle gidiyoruz.

Artık `app`’imizi build ettik.

---

## 🌐 Web App Nedir?

Peki `app` ne? Bir web app aslında nedir?

Bir web app, sunucuda yaşayan, diğer bilgisayarlardan gelen istekleri dinleyen ve sonra onları işleyen özel bir yazılım parçasıdır. Bu süreç genellikle bir yanıt (response) göndermekle sonuçlanır.

Yani bir web app kodlarken yaptığınız şey, sunucunuza istek gönderildiğinde ne olması gerektiğini tanımlamaktır. Hepsi bu. Gerçekten bu kadar basit.

Mesajlar, *universal resource locator* ya da `URL` olarak bilinen bir adres kullanılarak web uygulamanıza gönderilebilir.

Tıpkı sokak adresinizin evinizin konumunu belirlemesi gibi, URL de ağ üzerinden uygulamanıza mesajların nereye gönderileceğini belirler.

Bu, client’ın internet denen dev bilgisayar ağında sizin bilgisayarınızı nasıl bulduğudur.

---

## 🧭 `URL` İçindeki `Path` Kavramı

URL’nin içinde `path` denilen ek bir bilgi parçası olabilir.

Path’i şöyle düşünebilirsiniz: Web domain’i bir apartman binası gibi ve her bir daire bir path gibi.

Apartman binası domain’dir, her daire ise path’tir.

Ve o apartman binasında bir “front office” vardır; bu da `root path` olarak bilinir.

`Root path` sadece bir *forward slash*tır: `/`.

Burada gördüğümüz şey de bu. Bu sadece bir `/`.

Bu, client’ın domain’imizde belirli bir adrese istek yapabileceği bir path tanımlar.

Ve bu, `app.MapGet` metodunun ilk argümanıdır.

---

## 🛣️ `app.MapGet` ile Davranış Tanımlama

Yani bu, birisi istek gönderdiğinde ne olacağını tanımlamamızdır.

Buna biraz daha gireceğiz ama şimdilik şunu bilin:

`MapGet` metodunu çağırıyoruz. Bir path veriyoruz ve bir fonksiyon veriyoruz.

Bu fonksiyon sadece `"hello world"` string’ini döndürüyor. Hiç argüman almıyor.

Hayal edebileceğiniz en basit fonksiyonlardan biri.

Bu kodun söylediği şey şu:

Bir client uygulamamızın root domain’ine istek yaptığında, ona `"hello world"` string’ini geri gönder.

Ve son olarak, en aşağıda uygulamamızda `Run` metodunu çağırıyoruz ve bu da uygulamayı çalıştırmaya başlar.

Bu, sunucuyu gerçekten başlatır, client isteklerini dinlemeye başlar ve istek geldikçe bir şey geri gönderir.

---

## ▶️ Uygulamayı Çalıştırma ve Debug

Hadi uygulamamızı başlatalım.

Buraya gelip `Run and Debug` yapabilirim. `Run and Debug`, `Choose C#`, `C# basic endpoints`.

Bu, varsayılan konfigürasyondu.

Bunu build etmek ve yüklemek bir saniye alacak. Sonra debug console’a bazı bilgiler akacak ve ardından web browser’a bir “flash” göreceksiniz.

Şimdi ikisini aynı anda açık tutalım.

Sunucumuz başladı. Metni burada görebilirsiniz.

Ben geri dönüp terminali açtım. Artık şunu görüyoruz:

`HTTP colon slash slash localhost 5137`

Bu, sunucumuzun adresi. Olan şey şu: bir web browser açtı.

Web browser’lar sunuculara istek yapmak için kullanılır.

Onu açarsanız şunu görürsünüz: sunucumuza bir istek yaptı ve ne geri aldı?

`Hello world`, `localhost 5137`.

Tekrar, bu sayfanın adresi.

---

## 🔄 Metin Değiştirme ve `Restart`

Şimdi sayfamıza geri dönüp bu metni “`the root path`” olarak değiştirir ve kaydedersem…

Burada değişiklik yaptığımız için, `restart` butonuna basmadığımız sürece farklı bir şey görmeyeceğiz.

Çünkü sunucumuz hâlâ eski bilgiyi servis ediyor.

Bunun böyle olduğunu göstermek için sayfayı yenileyeceğim: hiçbir şey değişmedi.

Dosyayı kaydetmiş olsak bile değişiklik görmüyoruz.

Yapmadığımız şey şu: `restart` butonuna basmamız gerekiyor.

Sonra yine aynı süreçten geçecek; bir sürü output, sonra tekrar açılacak ve bam, şimdi “`root path`” yazıyor.

Burada eski açık sayfa var; onu yenilersem: “`root path`”. Harika.

---

## 🧑‍💻 Client ve Server, `localhost`, Development Server

Client ve server hakkında biraz konuştuk.

Bu durumda client ve server aynı bilgisayarda. Aynı bilgisayar ikisi olarak da çalışabilir.

Ve o bilgisayar, yerel makineniz olduğunda ve onu sunucu olarak kullandığınızda, buna `development server` denir.

Bu, canlıya aldığınızda gerçekten servis edeceğiniz yer değildir. Sadece geliştirme yaparken test etmek için bir yerdir.

Adres burada `localhost`.

Ayrıca şu `colon 5137` kısmını da fark edeceksiniz. Bu `port` olarak bilinir.

Bu URL’nin domain kısmıdır ve bu da port’tur.

Port’un yaptığı şey, sunucunun üzerinde birden fazla sunucunun çalışmasına izin vermektir ve her birine bir port atanabilir.

Port’un yaptığı tek şey bu.

Yeni bir *.NET* projesi oluşturduğunuzda, *.NET* size bir port atar.

Port’un ne olduğunu öğrenmenin bir yolu, açılan browser’a bakmaktır.

Ama koda geri dönersek, debug output’ta da port’u görebilirsiniz.

Eğer yanlışlıkla browser’ı kapattıysanız ve tekrar erişmek istiyorsanız, buna `control click` yapabilirsiniz.

Ayrıca kopyalayıp browser adres çubuğuna yapıştırabilirsiniz.

Port’u bulmanın başka bir yolu da `File Explorer`’a gidip `Properties`, `launch settings` ve sonra port’a bakmaktır.

Burada bir port göreceksiniz; `IIS settings` altındaki port yanlış porttur, onu aramıyorsunuz.

`Profiles` altındaki port’u arıyorsunuz.

Dikkat etmeniz gereken port budur. Uygulamanıza erişebileceğiniz port budur.

---

## ⚠️ Farklı Bir Path ve `404` Hatası

Şimdi bir istek yaptık; root address’e istek yapabiliyoruz.

Peki farklı bir path denersek ne olur?

Mesela `/downloads` deneyelim.

Domain ve port’un ardından gelen bilgi, `path` olarak bilinir.

Burada `/downloads` bizim `/downloads` path’imiz.

Buna erişmeye çalışırsam `404 error` alacağım.

`404`, sunucunun client’a şunu söylemesidir: “Sana ne göndereceğimi bilmiyorum, o adreste bir şeyim yok.”

Bu, var olmayan bir eve mektup göndermeye benzer ve postacının size “nereye gideceğimi bilemedim, mektubun burada” diye geri göndermesi gibidir.

---

## 🔌 `HTTP` Protokolü

Burada bir şey daha fark edebilirsiniz: sadece `localhost 5137` görüyoruz.

Ama buraya bakarsak `HTTP colon slash slash` kısmını da göreceğiz.

Buna `protocol` denir.

Protokol, sunucuların nasıl iletişim kurduğunu açıklayan bir şeydir.

Client ve server arasında beklenen iletişim şeklinin tanımıdır.

Bu durumda `HTTP`’dir; yani *hypertext transfer protocol* olan `HTTP`.

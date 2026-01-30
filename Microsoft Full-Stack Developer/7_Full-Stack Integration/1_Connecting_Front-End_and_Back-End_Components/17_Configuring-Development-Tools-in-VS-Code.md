## 🛠️ Configuring Development Tools in VS Code

Bu screencast’te, VS Code ile bir full-stack ortamının nasıl yapılandırılacağını göstereceğiz. VS Code açık ve terminal penceresi çalışmaya hazır.

İlk yapacağım şey, ihtiyacım olan tüm SDK’ların yüklü olduğundan emin olmak için SDK’ları listelemek. Bu yüzden .NET için SDK’ları listeleyeceğim.

Tamam, bende üç sürüm .NET SDK yüklü. Muhtemelen en güncel sürüm olduğu için sonuncusunu,  **9.0** ’ı kullanacağım. Ama SDK’lar yüklü, yani başlamaya hazırız gibi görünüyor.

---

## 🧩 Front-End Oluşturma: Blazor Uygulaması

İlk olarak bir front-end uygulaması oluşturacağım, yani bir Blazor uygulaması.

**.NET new** komutunu kullanacağım ve **Blazor Blazor** template’ini kullanacağım. Bu, bizim için bazı template kodlarıyla birlikte etkileşimli bir front-end web sitesi oluşturacak ve buna **front-end app** adını vereceğim.

Şimdi bu front-end uygulamasına geçmek için ilgili klasöre geçeceğim.

Artık o klasördeyim ve PowerShell satırında **front-end app** içinde olduğumu görebilirsiniz.

Şimdi uygulamayı daha sonra çalıştırabileceğimizden emin olmak için build edeceğim. Başarılı olduğunu söylüyor; yani bu uygulama hazır.

İstersek şu komutu çalıştırarak kendi Visual Studio Code örneğinde açıldığını da görebiliriz:

```bash
code .
```

Bu komut front-end’i açar ve sayfaları ve projedeki diğer dosyaları görebiliriz. Bu hazır, o yüzden kapatacağım.

---

## 🧩 Back-End Oluşturma: Server API

Şimdi root klasörüme geri döneceğim ve bir server uygulaması oluşturacağım.

Web template’ini kullanacağım:  **.NET new, web /o** .

 **/o** , klasör yapısını ve uygulamayı oluşturmak için gereken her şeyi oluşturacağı anlamına gelir. Buna **server API** adını vereceğim.

Şimdi o uygulamaya geçeceğim; böylece onu kendi Visual Studio Code örneğinde açtı.

---

## 🧾 Program.cs Düzenleme ve Yeni Route Ekleme

Şimdi, bunu bir web uygulaması için nasıl geliştirmeye başlayabileceğimizi göstermek amacıyla küçük bir değişiklik yapacağım.

Uygulama çalıştığında çalışan dosya olan **program.cs** dosyasını açacağım.

Burada zaten `/` route’u var; yani bir kullanıcı API’nin root’una giderse, `hello world` değerini geri alır.

Bir route daha ekleyeceğiz:  **weather** . Bu route iki değer döndürecek: sıcaklık **72** ve durum  **sunny** .

Yani bir kullanıcı API’nin root’una gidip ardından `/weather` yazarsa, bu değeri geri alacak.

---

## 📦 NuGet Paketleri Ekleme: SQL Server ve Entity Framework

Şimdi veritabanına bağlanmak için ihtiyaç duyacağımız birkaç package ekleyeceğiz.

İlk ekleyeceğim paket, SQL Server’a bağlanmamızı sağlayacak. İkinci ekleyeceğim paket ise SQL Server verisiyle çalışmak için Entity Framework’ü kullanmamıza izin verecek.

Bu, NuGet üzerinden paketi indirip uygulamaya kurar; böylece uygulamada kullanabilirim.

Entity Framework tools ile de aynı şeyi yapacağım.

Komut olarak **.net add package** çalıştıracağım; bu Entity Framework’ü kuracak.

Tabii bunun çalışması için internete bağlı olmanız gerekiyor; fakat Visual Studio Code’da paket kurulumunun yolu budur.

---

## 🧩 DbContext Servisini Eklemeye Başlama

Tamam, şimdi uygulamaya service ekleyeceğiz.

Özel bir komut kullanacağım:  **add db context** , böylece az önce kurduğumuz araçları gerçekten kullanabileceğiz.

Bazı kırmızı çizgiler görüyor olacaksınız. Bunun nedeni, ihtiyaç duyduğumuz tüm yapıların (harnesses) henüz tam olarak yerinde olmaması; ancak programın geri kalanını oluşturduğumuzda SQL Server ve Entity Framework ile çalışabilmemizi sağlayacak.

Bu, uygulamamıza veritabanı seçenekleriyle çalışmaya başlamak için fırsat verir.

---

## 🧩 Tek Çözüm Altında Toplama: Solution Oluşturma

Şimdi bir son şey daha yapacağız.

Server tarafını kapatacağım. Bu beni root klasörüne geri getiriyor; yani geliştirme klasörümdeyim.

Şu anda server ve client, alt klasörlerde. Ben bunları tek bir solution içine eklemek istiyorum.

Bu yüzden root klasörde terminal komutuyla **FullStackSolution** adlı yeni bir solution oluşturacağım.

```bash
dotnet new solution -n FullStackSolution
```

Tamam, solution dosyası oluşturuldu ve şimdi tek tek projeleri ekleyebilirim.

Artık hem front-end app hem de server API projelerini solution’a ekledik ve şimdi bu solution’ı VS Code’da açabiliriz.

Solution dosyamıza bakarsak,  **front-end app** ’i front-end app klasörünün içinde eklediğimizi ve projeyi orada görebildiğimizi görürüz.

Ayrıca **server API** projesi de bu solution içinde yer alıyor.

---

## ✅ Kapanış

Artık bunu tek bir solution olarak ele alabiliriz. Front-end app’i ve server API’yi geliştirmeye devam edebilir, kodu iki tarafın birbiriyle iletişim kuracağı şekilde inşa edebiliriz.

Projeler solution üzerinden yönetilirken, istersek onları ayrı ayrı çalıştırıp birbirleriyle birlikte çalışmasını sağlayabiliriz.

Bu, bir front-end uygulaması ve bir server API ile çalışabileceğiniz bir ortamı kurmanın temelleridir; ardından onların birbiriyle etkileşime girebilmesi için iletişim araçlarını geliştirebilirsiniz.


dotnet add package Microsoft.EntityFrameworkCore.SqlServer server


dotnet new blazorwasm -o FrontEndApp  frontend

dotnet new web -o ServerAPI backend

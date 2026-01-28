## 🧩 API İstekleri İçin Middleware Yapılandırma

Route handler’lar, uygulamanızın her endpoint’inde ne olacağını kontrol etmede kritiktir. Her route için belirli aksiyonlar tanımlamanıza izin verirler.

Ancak, tüm route’larda ya da yalnızca belirli bir kısmında çalışması gereken kodlara ihtiyaç duyduğunuz birçok durum vardır; işte burada middleware devreye girer.

Bu videoda, *ASP.NET Core* uygulamalarında middleware’in nasıl yapılandırılacağını açıklayacağız.

---

## 🧱 Temel Empty Web App Kurulumuna Geri Dönüş

Temel *empty web app* kurulumumuzu tekrar ele alarak başlayacağız.

Bu, .NET’te `create-empty-web-app`’tir ve tek bir route handler içerir: root route’a bir `GET` request’i map eder ve `hello world` döndürür.

Böyle bir route handler, her API route’u için davranışı belirler.

Ancak sadece route handler’ın ötesine geçen kod eklemek çoğu zaman gereklidir.

Middleware, route handler’larımızın ötesinde ek request processing eklememizi sağlar.

Önemli faydalarından biri, yalnızca tek bir route’ta değil, uygulamanın farklı bölümlerinde ek mantık çalıştırabilmesidir.

---

## 🧠 Zaten Middleware Kullanıyorsunuz

Henüz fark etmemiş olabilirsiniz ama aslında zaten middleware kullanıyorsunuz.

Sadece bu arka planda gerçekleşiyor.

 *ASP.NET Core* , uygulamanızı middleware ile sarar.

Routing gibi şeylerin gerçekleşmesi aslında budur.

Bunu biraz sonra daha fazla inceleyeceğiz, ama şimdilik kendi middleware’imizi eklemeye odaklanalım.

---

## 🧰 Built-in Middleware: HTTP Logging

İnceleyeceğimiz ilk middleware türü built-in middleware.

Sık kullanılan bir middleware parçası, HTTP logging middleware’dir.

Bunu şu şekilde ekleyebiliriz: `app.useHTTPLogging` ve IntelliSense’in bizim için tamamlamasına izin vereceğiz.

Artık middleware yükledik.

Şimdi buraya iki şey ekleyeceğiz.

Bir service eklememiz gerekiyor ve service’leri biraz sonra konuşacağız.

Şimdilik sadece takip edebilirsiniz.

Ayrıca log level’ı ayarlamak için projemizde bazı konfigürasyon değişiklikleri yapmamız gerekiyor.

En genel anlamıyla log level, log’ların farklı seviyelerde üretilebilmesi demektir.

Bazı log’lar “bu çok önemli, her zaman görünmeli” seviyesindedir.

Bazıları ise “ben geliştirme yaparken bilgi amaçlı kullanacağım” gibidir.

Temelde log level, göstermek istediğiniz log’un ne kadar önemli olması gerektiğini belirleyen bir eşik (threshold) gibidir.

Biz bunu ayarlayacağız.

Yine, bununla çok uğraşmanıza gerek yok.

Bunu çok sık düşünmenize gerek yok, ama logging middleware’i kullanmak için bunu kurmanız gerekir.

---

## 🧩 `builder` ile Service Eklemek

Bir sonraki yapacağımız şey bir service eklemek.

Daha önce `builder`’ın uygulamanın konfigürasyonunu değiştirmemize izin verdiğini konuşmuştuk.

İşte o zamanlardan biri.

`builder.services.addHTTPLogging` diyeceğiz.

Şimdi bu, hiçbir şey yapmayan bir fonksiyon istiyor.

Bu biraz garip hissettirecek ama bu sadece uymamız gereken bir konvansiyon gibi.

Eğer logging’in davranışını değiştirmek isterseniz bu fonksiyonu değiştirebilirsiniz.

Bu hâliyle default konfigürasyonu kullanır; bu da şu an göstermeye çalıştığımız şeyi açıklamak için yeterince iyi.

---

## ⚙️ `appsettings.json` ile Log Level Ayarlama

Kurulması gereken ikinci şey konfigürasyon.

`appsettings.json` dosyamıza gitmemiz gerekiyor ve `log level` kısmına gelmemiz gerekiyor.

Sonra şu key’i eklememiz gerekiyor:

`Microsoft.ASPNetCore.HTTPLogging.HTTPLoggingMiddleware`

Bu gerçekten uzun bir ifade ve doğru olduğundan emin olmak için kontrol edeceğim.

Evet: `Microsoft.ASPNetCore.HTTPLogging.HTTPLoggingMiddleware`.

Bir `:` ekleyeceğiz ve değer olarak `information` yazacağız.

Bu, temelde “üretebileceğimiz hemen hemen tüm log’ları göster” demektir.

Böylece her zaman o output’u alırız.

Sonra kaydedebiliriz.

Beni az önce virgül koyarken gördünüz.

Bazı diller trailing comma denen şeyi destekler; yani bu dictionary’nin sonunda fazladan virgül olur.

Bu durumda desteklemiyor.

Bu, diğer dillerle programlama alışkanlığından gelen bir refleks, o yüzden lütfen o ekstra virgülü eklemeyin.

Bir dile alıştıysanız, bunu bilin.

---

## ▶️ Uygulamayı Çalıştırma ve Logları Görme

Artık app settings tamam, program tamam.

Terminali açabiliriz; `Command-Tilde` ya da `Control-Tilde`.

Şimdi şunu yazacağım:

```bash
dotnet run
```

Build olması bir saniye sürecek ve her şey compile olursa web browser’ın açıldığını görmeliyiz.

Hey! İşte oldu.

Otomatik açılmadı gibi görünüyor.

Burada önemli bir nokta: `Control` ile link’e tıklayabilirim ve bam! İşte oldu.

Şimdi `hello world` görüyoruz.

Ve burada logging middleware devreye girdi.

Eğer logging middleware olmasaydı, bu kadar output görmezdik.

Bu, yapılan request hakkında diagnostic türü bir sürü bilgidir.

Middleware’ı görebilirsiniz, response status code’u, content type, tarih… hepsi burada.

Hatta burada görebiliriz: route neydi?

Favicon’u aldı; yani burada yukarıdaki küçük icon.

---

## ➕ Yeni Bir Route Eklemek ve `dotnet watch run`

Bir sonraki ekleyeceğim şey başka bir route.

Bunu kopyalayıp yapıştıracağız ve bu route’a `hello` diyelim.

Burada bizi duplicate route istemediğimiz konusunda uyarıyor.

`this is the hello route` diyeceğim.

Kaydedelim.

Ve şimdi hatırlayın, ne yapmamız gerekiyor?

Sunucuyu restart etmemiz gerekiyor.

Bunu yapmak için burada `Control + C`’ye birkaç kez basabilirim; bu kapatır.

Sonra tekrar:

```bash
dotnet run
```

Alternatif olarak:

```bash
dotnet watch run
```

`dotnet watch run`, dosyada değişiklikleri izler ve sunucuyu restart eder.

Her zaman çalışmayabilir ama ayrıca `Control + R` ile server’ı restart etmemi sağlar.

Bu çok kullanışlı.

Web app’lerimi neredeyse her zaman bu şekilde çalıştırmak isterim.

Burada tekrar output’u görürsünüz ve path’i de görürsünüz.

Path route.

Şimdi `localhost`’a gidip `hello` yazabiliriz ve terminal output’unun bunu yansıttığını görmeliyiz.

Şimdi aşağı kaydırırsak o output’u görmeliyiz ve bu bizim `hello` route’umuzdu.

Burada güzel olan şey şu: Bu, çağırdığımız her route’ta çalışan kod hâline geldi.

Bu `GET`’ler sadece bu belirli path’te çalışır, ama kullanıcıyı her route’ta authenticate etmek istediğinizi düşünün.

İşte middleware burada devreye girer.

Birden fazla route’ta çalıştırabilirsiniz.

Route handler’lar ise sadece bir route’ta veya birazdan konuşacağımız gibi küçük bir route set’inde çalışır.

Bu built-in middleware’dir.

Birisi bizim için işlevsellik oluşturmuştur.

Bu örnekte logging.

---

## 🧱 Kendi Middleware’imizi Yazmak

Biz kendi middleware’imizi de yazabiliriz ve geliştirme yaparken çoğu zaman bunu isteyeceksiniz.

Bunu yapma yolu şudur: `app.use` yazarsınız.

`app.use`, tek bir parametre alır; bu da bir request delegate’tir.

Request delegate yine, “bir request’i işleyen fonksiyon” demenin süslü yoludur.

Bu durumda bu fonksiyon:

* birincisi asynchronous olacak
* ikincisi iki parametre alacak

Bu parametrelere `context` ve `next` diyeceğiz.

Birazdan bunlara geleceğiz çünkü bunlar kesinlikle kritik derecede önemli.

Şimdi elimizde `app.use` var ve bu hiçbir şey yapmıyor.

Uygulamanın ortasında çalışacak bir fonksiyon ama hiçbir şey yapmıyor.

Dolayısıyla bir şey yapmasını istiyoruz.

Şimdi bu parametreleri konuşalım.

---

## 🧱 Terminal Middleware ve `next`

Yapabileceğiniz en temel middleware tipi bunun gibidir ve buna `terminal middleware` denir.

Terminal middleware, kodun çalışmasını durdurur; çünkü bir sonraki middleware’i çağırmaz.

Çünkü buradaki parametre aslında çağırabileceğimiz bir fonksiyondur.

Dolayısıyla şunu yapacağız:

```csharp
await next.invoke
```

Bu şunu der: “Ben bir fonksiyonum. Pipeline’daki bir sonraki fonksiyonu çağırmak istiyorum.”

Ve o bir sonraki fonksiyon; bir sonraki route delegate, bir sonraki middleware ya da bir sonraki route handler olacaktır.

Şimdi bu tamamen geçerli bir middleware.

Bir sonraki middleware’i çağırmaktan başka pek bir şey yapmıyor ama middleware bu.

Ve buraya mantık eklemeye başlayabiliriz:

Buraya mantık ekleyebiliriz.

Aşağıya da mantık ekleyebiliriz.

Ve bu iki yere farklı nedenlerle mantık eklemek istersiniz; şimdi ondan bahsedeceğim.

---

## 🔁 `next` Öncesi ve Sonrası Mantık

Mantığı buraya eklemek istemenizin nedeni şudur:

Bu, `next` fonksiyonu çağrılmadan önce çalışacak mantıktır.

Bu, her fonksiyon gibi yukarıdan aşağıya çalışır.

Yani bu, bir sonraki middleware çalışmadan önce olacak bir şeydir.

Ama ayrıca bir sonraki middleware çalıştıktan sonra da kod çalıştırabilirsiniz.

Onu da aşağıya koyarsınız.

Dolayısıyla elinizde şu tür bir yapı oluşur:

Middleware’ler birbirine zincirlenir (daisy chain).

Biri bir sonrakini çağırır.

Sonra her biri kontrolü bir önceki middleware’e geri verir; böylece önceki middleware temizleme (clean up) yapabilir veya finalize etmesi gereken şeyi tamamlayabilir.

İşte custom middleware’i bu şekilde inşa ederiz.


## 🧠 Middleware’e Mantık Eklemek

Hadi buraya biraz mantık ekleyelim.

`console.writeline` diyeceğim ve `logic before` yazdıracağım. Aşağıda da `console.writeline` diyip `logic after` yazdıracağım.

Bunları kaydedeceğim ve çalıştıracağım.

Bunu biraz daha kolay görmek için diğer logging’imizi comment out edeceğim.

Yine buraya inip uygulamamızı restart etmek istiyoruz ve `watch` kullandığımız için artık `Control + R`’a basabilirim; tekrar build edecek.

Bu, uygulamayı kapatıp tekrar açmaya gerek kalmadan resetledi. Burada gerçekten çok kullanışlı.

Şimdi yukarı gelirsek, her iki middleware’in output’unu da görmeliyiz.

Bu route’u tekrar çalıştırırsam, burada orijinal `useHttpLogging` gibi görünen bir sürü logging göreceksiniz, sonra `logic before` ve `logic after`’ı göreceksiniz.

Sonra daha fazla logging görüyorsunuz; çünkü `useHttpLogging` middleware’i aslında bir şeyleri *önce* yapıyor ve bir şeyleri *sonra* yapıyor.

Yani bu, middleware’imizden önce bir şey yapıyor ve middleware’imizden sonra da logluyor.

Burada şu noktayı bilmek önemli: Bu middleware, dosyamızdaki sırada bu middleware’den önce geliyor ve bu, bu middleware’in bizimkinden önce çalıştığı anlamına geliyor.

Temelde şu olur:

Önce burada “before” mantığını çalıştırır, sonra burada “before” mantığını çalıştırır, sonra nerede terminate ediyorsa oraya gider (muhtemelen bu route handler’lardan birinde).

Sonra burada “after” mantığını çalıştırır, ardından burada “after” mantığını çalıştırır.

Bunu gösterebiliriz.

Burada şunu görüyorsunuz:

Bu, logging middleware’inin before mantığı.

Bu, custom middleware’imizin before mantığı.

Sonra custom middleware’imizin after mantığı.

Sonra HTTP logging middleware’inin after mantığı.

Şimdi bunu kesip en üste alırsam, çalıştırma sırasını değiştirmiş oluruz.

Bunu tekrar kaydediyorum.

Aşağı geliyorum.

Doğru bir reload için `Control + R`’a basıyorum.

Edge’i açıyorum ve sayfayı refresh ediyorum.

Şimdi bu sıranın farklı olduğunu görüyorsunuz.

Burada bir yerlerde `logic before` görüyorsunuz.

Yani artık bu mantık ilk çalışıyor.

Sonra burada initial logging çalışıyor.

Sonra terminal route’a kadar gidiyor; yani bunun tamamından geçiyor.

Sonra aşağıda “after” mantığı çalışıyor (bu bizim son middleware’imiz) ve sonra ilk middleware’imizin “after” mantığı çalışıyor.

Yani  **before mantığı birinciden sonuncuya doğru** , **after mantığı sonuncudan birinciye doğru** akar.

---

## 🔢 Aynı Middleware’den Birkaç Tane ile Sırayı Netleştirmek

Bunu comment out edelim.

Belki bunu anlamanın daha kolay yolu, bu middleware’den birkaç kopya göstermek.

Bunlara numara verelim çünkü bunu iyice oturtmak istiyorum; gerçekten çok önemli bir kavram.

Şimdi tekrar restart edeceğim; artık üç middleware’imiz var.

`logic before`, `logic after` çalışıyor ve hepsinde numaralar var.

Şimdi kısa bir durup düşünün:

Output’ta altı satır loglanacak, ama sizce hangi sırada olacak?

Edge’e gidip refresh ediyorum.

Burada görüyorsunuz:

Birinci satır, ikinci satır, üçüncü satır…

Sonra ters sırada: üçüncü, ikinci, birinci.

Ve tekrar: Eğer sıraları karıştırırsam, bu sıra değişir.

Üstten alta, sonra alttan üste çalışan bir tür piramit gibi düşünün.

---

## 🧱 .NET’in Arka Planda Eklediği Middleware’ler

Bu çok önemli, çünkü daha önce .NET’in arka planda middleware eklediğini söylemiştim.

Ben bunları kaldıracağım çünkü bazı konseptleri göstermek istiyorum.

Arka planda .NET birkaç şey yapar.

Bir middleware kullanır: `routing`.

Yani `app.useRouting` çağırır ve bu, bu farklı route’ları çalıştırmak için gereken mantığı başlatır.

Ve sizin tüm mantığınızdan sonra da `app.useEndpoints` çağırır.

Bu, route endpoint’lerinizi gerçekten kullanan ikinci parçadır.

Bu `map get`, `map post`, `map put` mantığı middleware tarafından yönetilir.

Siz bunu bilmezsiniz çünkü arka planda olur.

Eklediği başka middleware’ler de var; üç tane.

Birincisi: koşullu olarak `app.useAuthentication` çağırır.

İkincisi: `app.useAuthorization` çağırır.

Bunlar kullanıcıların login olmasını ve kim olduklarının kontrol edilmesini sağlar.

Bunların koşullu olduğunu söyledim; yani bu, authentication ve authorization servislerini ekleyip eklemediğinizi kontrol eder.

Yani bir tür otomatik olarak middleware’i ekler; eğer servisleri dahil ettiyseniz.

Şunu bilir gibi: “Hey, authentication kontrol eden bir servis ekledin. Muhtemelen middleware’i kullanmak istiyorsun.” ve bunu ekler.

Platform kullanmanın güzel yanlarından biri budur.

Bir de aşağı gelir ve `app.useExceptionHandler` çağırır.

Exception handler’ın yaptığı şey: bu da koşullu çalışır.

Sadece development ortamındayken çalışır.

Sunucuda bir hata olduğunda, size ne olduğunu söylememek yerine, çok güzel bir error page verir.

Bunları çok görürsünüz; full stack trace ve hatayı teşhis etmek için ihtiyacınız olan tüm bilgileri sağlar.

Ama bu yalnızca development’ta yapılır; çünkü bunu end user’a göstermek istemezsiniz.

Birincisi, kafa karıştırıcı ve garip görünümlüdür.

Kullanıcı deneyimini tuhaflaştırır.

İkincisi, bir güvenlik açığıdır.

Bu, birinin kötü niyetle kullanabileceği bilgi sağlar.

Uygulamanızın nasıl çalıştığına dair içgörü verir ve bunu gerçekten istemezsiniz.

Tekrar vurgulamak istiyorum: Bu middleware’leri sizin eklemenize gerek yok.

Zaten kodunuzda varlar.

Tüm kodun etrafına ekleniyorlar.

Şunu hızlıca kaldırabilirim çünkü bu onlardan biri değil.

Bunu explicit olarak eklemeniz gerekiyordu, ama bunlar temelde şu sırayla gerçekleşir.

Tüm bu middleware’leri sizin kodunuzdan önce ekler, sonra sizin kodunuzdan sonra `useEndpoint` ekler.

Yine, o sıra önemlidir.

İsterseniz bunları başka bir yere de ekleyebilirsiniz.

Genelde buna ihtiyacınız yoktur ve bu, .NET’in varsayılan olarak size verdiği implementasyonu overwrite eder.

Bu, yine koşullu kontrol eden mekanizmanın bir parçasıdır.

Ama şunu bilin: Arka planda sizin yerinize `useRouting`, `useAuthentication`, `useAuthorization`, `useExceptionHandler` ve `useEndpoints` çağrılıyor.

Sizin tek odaklanmanız gereken şey, burada neler olduğudur.

Bu middleware’lerle ilgilenmeniz gereken tek zaman, .NET’in default davranışlarını değiştirmeniz gerektiğinde olur.

---

## ✅ Kapanış

İşte bu kadar.

Hem custom hem de built-in middleware, *ASP.NET Core* uygulamanızın request’leri nasıl işlediğinde kritik bir rol oynar.

Birden fazla route üzerinde kod çalıştırmanıza izin verir ve request/response döngüsü üzerindeki kontrolünüzü artırır.

Middleware’i doğru yapılandırmak, sağlam API’ler oluşturmanın anahtarıdır.

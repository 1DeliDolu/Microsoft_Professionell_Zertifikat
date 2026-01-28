## 🧩 ASP.NET Core’da Dependency Injection Uygulama

Bir uygulama geliştirdiğinizi hayal edin; logging yapmak, bir veritabanına erişmek ya da kullanıcı girdisini işlemek gibi görevleri yerine getirmesi gerekiyor. Büyük bir uygulamada bu görevler genellikle *services* denen yapılar tarafından ele alınır.

 *ASP.NET Core* ’da service’lerin nasıl oluşturulacağını, nasıl kullanılacağını ve davranışlarının nasıl kontrol edileceğini; ayrıca uygulamanızı daha düzenli ve ölçeklenebilir hâle getirmek için *Dependency Injection* adlı güçlü bir özelliğin nasıl kullanılacağını inceleyeceğiz.

Bu videoda,  *ASP.NET Core* ’da  *Dependency Injection* ’ı uygulayacağız.

Her oluşturulduğunda benzersiz bir ID loglayan basit bir service oluşturacağız; böylece her service’in ne sıklıkla ve ne zaman kullanıldığını inceleyebileceğiz.

---

## 🧰 .NET’te Service Örnekleri

.NET’te her türden middleware vardır.

Builder’a gelip `services` kısmına giderseniz `add anti-forgery`, `add certificate forwarding`, `add connectors`, `controllers` gibi şeyler görürsünüz.

Bunların hepsi service örnekleridir.

Bunlardan herhangi birini ekleyebiliriz ve çoğu zaman da ekleriz; örneğin authorization veya authentication için.

Ama şu an bunlardan birini eklemeyeceğiz, çünkü size gerçek anlamda bir service’i nasıl inşa edeceğinizi göstermek istiyorum.

---

## 🧾 Adım 1: Interface Tanımlamak

Custom bir service oluşturmak için bir interface tanımlamamız gerekir.

`public interface imyinterface` diyeceğiz ve bunun bir `void` döndürmesini isteyeceğiz.

Tek bir metodu olacak: `log creation` ve `string message`.

---

## 🧱 Adım 2: Interface’i Uygulayan Class Oluşturmak

Sonra bu interface’i uygulayan bir class oluşturmalıyız.

`public class my service` diyeceğiz ve bu, o interface’i implement etmeli.

Bu class’ta tek bir `private readonly int` olacak; buna `service ID` diyeceğiz.

Bu, tutulacak benzersiz bir ID olacak.

Constructor’ı yazalım.

Constructor içinde `service ID`’yi benzersiz bir ID’ye ayarlayacağız; pseudo unique olacak, sadece random sayı ile, yani bir milyonda bir çakışma ihtimali var.

Burada altı hane var, onu seviyorum, `1,2,3,4,5,6`.

Yani bu, random altı haneli bir sayı olacak ve bu sayı constructor’ın başında atanacak.

Yani bu, method’u çağırdığımızda değil, object oluşturulduğunda atanacak.

Şimdi implement etmemiz gereken method’a geçiyoruz: `log service`.

`public void log creation` diyelim, `string message` alacak.

Bu “tamamlanmadı” diyor, şimdi tamamlandı.

`console.writeLine` kullanacağız çünkü void return var; bir şey döndürmemize gerek yok.

Bir string yazdıracağız: message ve `service ID`.

Şimdi elimizde bir interface ve onu implement eden bir class var.

Dependency injection için ihtiyacınız olan tek şey bu.

Burada özel bir şey yok.

Service’ler sadece object’tir.

Genelde, uygulamanın geri kalanı için faydalı bir iş yapan object’tir.

---

## 🧷 Adım 3: Service’i Uygulamaya Register Etmek

Şimdi service’i uygulamaya register etmeye geçebiliriz.

Yine `builder.services` diyeceğiz, ama bu sefer `addSingleton` kullanacağım.

Bu, custom service eklemenin bir yoludur.

Type alan birini istiyoruz ve bu iki şey ister:

`I myService` ve `myService`.

Yani interface’i ister ve kullanacağımız service’in class’ını ister.

Ve bu çağrılması gereken bir metottur.

Buraya bakınca, bir hata yaptığımı görüyorum.

Bunu `I myInterface` diye yazmışım ama bunu aslında `I myService` diye çağıracağım; daha açık olur.

Tamam.

Şimdi yukarı dönersek, bu doğru olmalı.

Artık elimizde `builder.services.addSingleton I myService, myService` var.

Bu, istediğimiz zaman bu object’in bir instance’ını oluşturacak.

Ve burada interface’e ihtiyaç duymasının sebebi şudur:

Ben `myService`’i, aynı interface’i implement eden herhangi bir object ile değiştirebilirim.

Ve bir service için bunun bu kadar kullanışlı olmasının sebebi şudur:

Diyelim service’iniz veritabanına erişim sağlıyor.

Yeni bir veritabanına geçerseniz, sadece yeni implementasyonu takarsınız.

Data erişimi için aynı interface’i implement ettiği sürece her şey çalışır.

Kodunuzda büyük, kırıcı değişiklikler yapmanız gerekmez.

---

## 🧠 Singleton Davranışı

Daha önce service’in constructor’ının başında bu log’u oluşturduğumuzu söylemiştim.

Buradaki büyük nokta şu:

`singleton` ile, kaç kere çağırırsam çağırayım sadece tek bir instance oluşturulur.

Bir tanesi var olur.

Bunu yapmanın başka yolları da var ve birazdan onları da göstereceğiz.

Ama bu en popüler olanlardan biridir; çünkü örneğin bir veritabanı bağlantısı gibi bir şeyde, sürekli yeniden oluşturmanız gerekmez.

Her şeyin kullanabileceği tek bir bağlantı istersiniz.

---

## 🧩 Adım 4: Service’i Route Handler İçinde Kullanmak

Şimdi request kısmına inebiliriz.

Orada buna erişebiliriz.

`I my service` beklediğimizi söyleyebiliriz ve bu `my service` olacak.

Bu handler içinde `my service`’e erişebiliriz.

Bunu genişletelim.

`my service dot log creation` ve mesaj olarak `root` vereceğiz.

Sonra `results dot ok` döndüreceğiz: `check the console for service creation log`.

Harika.

Şimdi uygulamayı başlatabiliriz.

`requests dot http` dosyası, `.netwatch run`.

Şimdi output’a bakınca bir hata görünüyor.

Service collection read only olduğu için değiştirilemiyor.

Service’e geri bakınca, bunun `app`’ten sonra olmasından kaynaklanıyor.

Çünkü `builder.build`’i kullandıktan sonra artık read only olur; uygulamayı zaten build etmiş olursunuz.

Bu built-in bir safety mechanism.

Şimdi `app`’ten önce yaptık.

Save edip restart edersek iyi olmalı.

Mükemmel, çalışıyor.

`5124`.

`GET http://localhost:5124`.

Request’i yapınca şunu görüyoruz:

`root service ID 208310` iki kere.

Beklediğimiz şey buydu.

Aynı ID tekrar tekrar.

Bu ID değişecek çünkü memory’de tutuluyor.

Uygulama her resetlendiğinde değişir.

Ama uygulama çalıştığı sürece sabit kalır.

Bunu hızlıca göstermek için uygulamayı restart edeceğim.

Açıldığında root’a erişecek ve yeni bir service ID verecek.

`700619` gördük.

Önce `208310` vardı.

Birkaç kere daha `GET` yaparsam, her seferinde aynı.

---

## 🧱 Service’i Middleware İçinde Kullanmak

Bunu biraz daha ilginç hâle getirelim.

Bir middleware ekleyelim.

Çünkü her request’te bunu birden fazla kez çağırmak istiyorum.

`app.use` diyeceğiz ve `async`.

Bu `context` ve `next` alacak.

Sonra:

`var myService = context.requestServices.getRequiredService`

Bu `I myService` type’ını alacak.

Bu, hangi service’i çekmeye çalıştığını söyler.

S büyük olmalı.

Harika.

Şimdi service’in bir kopyasını alıyor.

Sonra `myService.log creation` diyeceğim.

Ve sonra `await next.invoke`.

`log creation` bir string alıyor.

Ve bunu çağırmamız gerekiyor.

`first middleware` diyeceğim.

Şimdi service’imizi kullanan bir middleware’imiz var.

Burada fark ettiğiniz şey şu:

Burada service’e erişim şekli biraz farklı.

Aşağıda service, `GET` kullandığımızda fonksiyona doğrudan parametre olarak geliyordu.

Burada ise `context` üzerinden alıyoruz.

`context.requestServices` ve sonra `I myService` service’ini çekiyoruz.

Bunu daha iyi göstermek için bir ikinci kopya ekleyelim.

Buna `second middleware` diyelim.

Şimdi restart edelim.

Çünkü bu ekstra middleware’leri ekledik ve hot reload bunu yakalamayabilir.

Şimdi request’e gidersek:

Kaç tane log göreceğimizi düşünün.

İki middleware var.

Bir de endpoint request’i var.

Bunu gönderirsek:

`first middleware, ID`

`second middleware, ID`

`root ID`

Üçü de aynı ID’yi aldı.

Kaç kere çağırırsak çağıralım aynı ID.

---

## 🔁 `AddScoped` ile Davranışı Değiştirmek

Şimdi küçük bir değişiklik yapalım.

`addSingleton` yerine `addScoped` yapacağım.

Kaydediyorum.

Bu davranışı değiştirir.

`scoped` ile her request için yeni bir service instance’ı oluşturulur.

Bu şu anlama gelir:

Tek bir request içinde tüm middleware ve endpoint aynı instance’ı paylaşır.

Ama her yeni request için farklı bir instance oluşturulur.

Tekrar başlatalım ve ne aldığımıza bakalım.

Request yaptığımda üçünde de `573320` görüyoruz.

Ama bir tane daha yaptığımda bu yeni bir request.

Dolayısıyla yeni bir instance.

Request’e scoped bir service istediğinizde `addScoped` kullanırsınız.

---

## ⚡ `AddTransient` ile Davranışı Değiştirmek

Göstermek istediğim bir tane daha var: `addTransient`.

`transient`, instance’ları daha da sık oluşturur.

Service’i transient olarak register ettiğinizde, service her istendiğinde yeni bir instance oluşturulur.

Yani her middleware ve her endpoint, service’in taze bir instance’ını alır.

`requestService` çağırdığımızda bu, yeni bir instance oluşturur.

Aşağıda `myService` aldığımızda da yeni bir instance alır.

Bunu hot reload edeceğim.

Şimdi request’i çalıştırırsak üç farklı sayı görmeliyiz.

Bir daha request atarsam, üç yeni sayı.

Yani her request’te, her kullanımda yeni instance oluşuyor.

Ve umarım bu şunu gerçekten gösteriyordur:

Service sadece bir object’tir.

Hepsi bu.

İnsanlar “service” gibi süslü kelimeler kullanır ama bu sadece uygulamanız için bir şey yapan bir object.

Bu örnekte, kendi benzersiz ID’sini loglayan basit bir şey.

İşte bu kadar.

Artık bir service oluşturmayı, dependency injection ile API’nize доступlu hâle getirmeyi ve scope’unu ihtiyacınıza göre değiştirmeyi biliyorsunuz.

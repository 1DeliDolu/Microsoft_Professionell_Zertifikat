## 🎬 ASP.NET Uygulamasında Rolleri ve Claim’leri Gösterme

 **ASP.NET Identity** ’de kullanıcı rolleri ve claim’ler hakkında çok şey öğrendiniz; şimdi bunu uygulamaya dökme zamanı. Bu videoda, **ASP.NET Identity** kullanarak ASP.NET uygulamalarında rol ve claim yönetiminin nasıl uygulandığını göstereceğiz.

---

## 🧩 Başlangıç: Basit Uygulama ve Rotalar

Başlamak için burada basit bir programımız var. Yeni bir web uygulaması oluşturdum ve birkaç yeni rota ekledim. **admin only** ve **user claim check** rotalarımız var; fikir şu: birincisi yalnızca **admin** rolüne sahip kişiler tarafından erişilebilir olacak, ikincisi ise yalnızca **IT department** claim’ine sahip kişiler için kullanılabilir olacak.

Ayrıca burada birkaç rol de oluşturacağız. Bir **admin** ve bir **user** rolü oluşturacağız.

---

## 📦 Eklenen Paketler ve Namespace’ler

Ek olarak, burada bazı namespace’leri içeri aldık. Yani projeye eklediğimiz paketler bunlar:

* **Entity Framework Core** : veritabanı ve veri yönetimini bununla ele alıyoruz.
* Ayrıca bir **in-memory database** kullanacağız; bu, böyle bir şeyi hızlıca *stub* etmek için bir yöntem gibi. Tam teşekküllü bir veritabanı değil. Bunu prod ortamında kullanmak istemezsiniz; ancak kullanıcıları ve rolleri daha resmi bir veritabanında oluşturmak için gerekli olacak gerçek migration’ları kurmak gibi şeylere kıyasla çok daha basit.
* Sonraki olarak **ASP.NET Core Identity** var; kullanıcı yönetimini bununla yapıyoruz.
* Ardından `identity.entityframeworkcore` paketi var; bu da identity ile entity framework core’u birbirine bağlayan bir “tutkal” gibi.

Son olarak, bu rotaları test etmek için bu `.http` dosyasında birkaç istek oluşturdum ve bu da şu kullanışlı **REST client extension** sayesinde. Ben bunun büyük hayranıyım. Bu istekleri `cURL` ya da Postman gibi bir şeyle yapmak isterseniz, bunu da elbette yapabilirsiniz.

---

## 🗄️ Program.cs: In-Memory Veritabanını Kurma

`program.cs` dosyasına geri dönersek, ilk yapacağımız şey veritabanını eklemek.

Örneğin:

* `builder.services.adddbcontext`
* Buraya basitlik için `identity db context` geçeceğiz.
* Ardından seçenekler: `options.useInMemoryDatabase`
* Ve buna bir string vereceğiz; buna `AuthDemoDB` diyelim.

Bu, veritabanını kurma şeklimiz.

---

## 🔐 Identity’yi Kurma

Şimdi Identity’yi oluşturalım:

* `builder.services.addIdentity`
* Buraya `identity user` ve `identity role` geçeceğiz.

Eğer kendi özel kullanıcılarınızı ve rollerinizi oluşturmak isterseniz, burada onları da kullanabilirsiniz. Ama bunun hatırına, yerleşik olanları kullanalım:

* `.addEntityFrameworkStores`
* Bu da o `identity db context` üzerinde olacak.

Şu an bunları bulamıyor çünkü `using` ifadesini eklemedik. Bakalım otomatik ekleyebiliyor mu.

Bende şu an çalışmıyor, bu yüzden buraya gelip şunu yazacağım:

```csharp
using Microsoft.asp.core.identity
```

Bu sorunu çözmeli. Mükemmel.

Artık veritabanımız var ve Identity de bu veritabanında bir kullanıcılar tablosu ve bir roller tablosu oluşturacak şekilde ayarlandı.

---

## 🧰 Authentication ve Authorization’ı Ayarlama

Şimdi kimlik doğrulama ve yetkilendirmeyi ayarlayalım:

* `builder.services.addAuthentication`
* `builder.services.addAuthorizationBuilder` (birazdan burada birkaç şey yapacağız)

Ve bununla birlikte uygulamayı başlatalım.

---

## ▶️ Uygulamayı Çalıştırma ve İlk Test

Aşağıda `.NET watch` çalıştıracağız; bu bizi başlatmalı. Ve artık çalışıyoruz.

İsteklerime dönüp rotama erişebildiğimden emin olacağım. Bu iki rota henüz korunmuyor; bu yüzden içeriklerini **200 OK** ile görüyoruz.

Şimdi bunu değiştirip değiştiremeyeceğimize bakalım.

---

## 🔒 Rotaları Korumaya Alma: requireAuthorization

İlk olarak temel yetkilendirmeleri ekleyeceğim.

`requireAuthorization` diyeceğim.

Bu, bu iki rotaya erişmek için kullanıcının giriş yapmış olmasını ve geçerli bir cookie’ye sahip olmasını gerektirecek.

Kaydedeceğim ve sunucuyu yeniden başlatacağım. Build olmasını bekliyoruz.

Build tamamlandığında, rotaları tekrar çağırmayı deneyelim.

Ve şimdi **404 not found** alıyoruz. Bu biraz garip bir davranış, çünkü aslında 404 istemiyoruz. Bu geçerli bir rota, ama yetkisiz. Burada görmek istediğimiz aslında  **401** .

---

## 🚦 Neden 404 Görüyoruz?

404 görmemizin nedeni, varsayılan davranışın şu olması: kullanıcı, erişmek için kimliği doğrulanmamış olduğu bir rotaya erişmeye çalışırsa, sistem onu belirli bir sayfaya yönlendirmeye çalışır.

Bu durumda varsayılan olan bu rota.

Şimdi `app.map.get` yapalım. Bu rotanın, sanırım `"/account/user"` olduğunu düşünüyorum. Ve “user route” diyelim; size gerçekten olanın bu olduğunu göstermek için.

Bir virgülü kaçırdım. Şimdi kaydedip sunucuyu tekrar başlatalım.

Tekrar rotaları denersek bunu görmemiz gerekir. Ve tekrar 404 ile 404 alıyoruz.

Bunu tekrar yapacağım. Sorun şu: bunu yanlış yaptım. Aslında `account.login` olmalı diye düşünüyorum.

Bir kez daha deneyelim. Buraya gelip isteklerimizi yapabilmeliyiz. Bu iyi.

Ve şimdi görüyorsunuz: bu  **user route** . Ve bu da  **user route** . Çünkü onu değiştirmedim. Yani bu teknik olarak  **login route** .

Olan bu.

Bu, normalde bir web uygulaması veya web sitesi yapıyorsanız isteyeceğiniz davranıştır: kullanıcı erişemeyeceği bir sayfaya giderse, “hey, git giriş yap” dersiniz.

Ama API’ler için bu genelde istediğiniz davranış değildir. Onların **unauthorized** almasını istersiniz.

404 sorununu tekrar yaşıyor olmamızın sebebi de bu: normal web sayfasında login’e redirect edersiniz. Burada başka bir sayfaya yönlendirmek istemiyoruz; yalnızca **401** dönmek istiyoruz.

---

## 🍪 Redirect Davranışını Override Etme: Application Cookie

Bunu yapmak için `builder.services.configureApplicationCookie` kullanacağız.

Bu, `options` alan bir fonksiyon alacak. Sonra `options.events.onRedirectLogin` diyeceğiz.

Bu event, kullanıcı bir rotadan “bounce” edilip login’e gönderilmeye çalışıldığında çağrılır. Bu gerçekleştiğinde bu davranışı overwrite edeceğiz.

Varsayılan davranış şuna benzer:

* `context.response.redirect`
* `context.redirectUri`’ye gider (yani `/account/login` rotasına)
* ve `task.completedTask` döner

Yani bu şekilde mevcut davranışı kopyalamış oluyoruz.

Değiştireceğimiz yer ise şurası: uygulamamızda bir çeşit ayrım yapacağız.

Şöyle diyelim:

* `context.request.path.startsWithSegments`
* ve `"/API"`

API’lerimizin nasıl kurulduğunda küçük bir değişiklik yapacağız.

Ayrıca ikinci bir davranış daha ekleyeceğiz; `context.response.statusCode`’u kontrol edeceğiz ve bunun `statusCodes.Ibelieve200OK` olmasını isteyeceğiz.

Tekrar bakarsak: login’e redirect edileceklerinde bu event çalışacak; bunun bir API rotası olup olmadığını ve status code’un başka bir şey tarafından değiştirilmemiş olduğunu (yani hâlâ 200 olduğunu) kontrol edeceğiz.

Eğer öyleyse **401** döneceğiz. Değilse normal şekilde redirect edeceğiz.

---

## 🧪 Tekrar Test: Artık 401 Dönüyor

Bunu test edelim.

Buna vurursam, orada **200** aldığımızı göreceğiz. Sonra `blogs` login’e yönlendiriyor.

Bunlara tıklarsam **404** alıyorum. Ve bu, o rotaların isimlerini değiştirdiğim için.

Bir kez daha deneyelim.

Şimdi **admin only** yaparsam **401** alıyorum, **user claim check** de  **401** .

İşte almamız gereken bu. Bu harika.

Artık API’lerimiz bu rotaları gerçekten koruyor.

---

## 🧑‍🔧 “Hacky” Şekilde Kullanıcı Oluşturma (Demo İçin)

Şimdi yapmamız gereken ilk şey, birine login olma yolu vermek.

Biraz “hacky” bir şekilde bir kullanıcı oluşturacağız; prod’da bunu yapmak istemezsiniz.

Burada başlayarak birkaç rota oluşturacağız; bunları “administrative routes” gibi düşünebilirsiniz. Böyle rotaları açık bırakmak istemezsiniz; admin izinleri arkasında korumak istersiniz.

Ama demo için hızlı ve kirli bir şekilde yapacağız.

---

## 🏷️ Rolleri Oluşturma İçin Route

Roller oluşturacağız ve bunun bir async function’a ihtiyacı var.

Burada `role manager`’ı alacağız; buna `role manager` diyeceğiz.

Response’u kapatacağım; ne olduğunu görebilirsiniz.

Sonra `results.OK` döndürelim ve “roles created successfully” diyelim.

Son parantezi kaçırdım.

Peki burada rolleri nasıl oluşturuyoruz?

Şöyle diyelim: `for each var role in roles`.

Yukarıda listelediğimiz iki rol bunlar: **admin** ve  **user** . Yani ikisini de oluşturacağız.

`role manager` ile bu rollere erişeceğiz.

* `role exists async` ile rolün var olup olmadığına bakacağız.
* Eğer yoksa: `role manager.create async`
* `new identity role` ile rolü oluşturacağız ve içine `role`’ü vereceğiz.

Bu, ihtiyacımız olan tüm rolleri oluşturacak.

Bunun ne yaptığını gösterebilirim ama çok heyecan verici olmayacak; yaptığı şey yalnızca veritabanında birkaç kayıt oluşturmak.

Tamam, artık bu rollerimiz var.

---

## 👤 Rol Atayacağımız Bir Kullanıcı Oluşturma

Şimdi, bu rolleri atayabileceğimiz bir kullanıcı oluşturalım.

Bir route daha oluşturacağız:

* `"/api/assign role"` için `map posts`

Bu da yine async function alacak.

Bu kez bir `user manager` istiyoruz. Ve bu `user manager`, hangi tür kullanıcılarla çalıştığımızı bilsin diye `identity user` tipi alacak.

Buna `user manager` diyelim.

İlk ihtiyacımız olan şey bir kullanıcı:

* `var new identity user`
* `user name` vereceğiz
* ve buna `test user at example.com` diyelim


## 👤 Aynı E-postayı Verme ve Kullanıcıyı Oluşturma

Ve aynı e-postayı da verelim. Böylece e-postayı kullanıcı adı olarak kullanacağız. Yani `test user at example.com`.

Tamam, şimdi bu kullanıcıyı oluşturalım. Nesneyi oluşturduk ama aslında bunu Identity’ye eklememiz gerekiyor. Bunun için `user manager dot create async` diyeceğiz ve o kullanıcıyı geçeceğiz; ayrıca bir parola da isteyecek.

Burada gerçekten kötü bir parola yapalım; lütfen asla o parolayı kullanmayın. Burada yaptığımız şey için çalışacaktır.

Sonra `user manager dot add to role async` de diyeceğiz. Bu, kullanıcıyı alacak ve ona **admin** rolünü ekleyeceğiz. Yani kullanıcıyı oluşturuyoruz ve aynı anda bir rol veriyoruz.

Son olarak, return içinde bir şey yapalım. `return if is in role` diyelim ve burada bir ternary statement kullanalım. Sonra `var is in role` yapıp gerçekten role eklendiğinden emin olalım.

Şöyle diyelim: `await user manager dot is in role async` ve `user` ile `admin`.

Sonra, eğer roldeyse ve başarılı şekilde eklendiyse `results dot okay` döndürelim. Aksi halde `results dot bad request`.

Harika. Artık bir kullanıcı oluşturup ona bir rol atamanın bir yoluna sahibiz.

Tekrar özetlemek gerekirse: `IdentityUser` olan yeni bir nesne oluşturuyoruz, `UserManager` ile asenkron şekilde oluşturuyoruz ve parola veriyoruz. Sonra `UserManager` ile role ekliyoruz; bu örnekte **admin** rolü. Rolün başarıyla eklendiğini kontrol ediyoruz. Eklendiyse  **okay** , değilse **bad request** döndürüyoruz.

Ve şimdi bu bilgiyi gerçekten kullanabiliriz; sunucuyu yeniden başlatırsak.

---

## 🧪 Rotaları Test Etme

`API assign role` ve `API create role` vardı. Şimdi aşağıda birkaç yeni rota oluşturalım; hatta bunu en üste koyacağım:

* `/API/create role`
* `/API/assign role`

Normal rotamızı deneyelim.

 **admin only** : unauthorized, unauthorized ve sonra blogs.

Harika. Bunların hepsi beklendiği gibi çalışıyor.

Şimdi `create role` deneyelim: 404 not found.

Buradaki sorun şu: bu bir **POST** isteği, **GET** değil. İkisi de POST.

Bir başka şey de, görünüşe göre ben bunu kaydetmemişim. O yüzden sunucumu tekrar yeniden başlatayım.

Şimdi tekrar gelirsek, bunu çalıştırabilmeliyiz ve **200** alıyoruz.

Ve burada da **200** alıyoruz.

Yani roller atandı ve ardından o kullanıcıyı oluşturduk.

---

## 🔐 Kullanıcıyı Login Etme İçin Yeni Route

Şimdi merak ediyor olabilirsiniz: kullanıcıları oluşturduk, roller atadık. Peki şimdi bununla ne yapacağız?

İlk yapmamız gereken şey, onları **login** etmek.

Bir tane daha küçük bir API route oluşturacağız. Yine, bu prod’da isteyeceğiniz bir route değil, ama burada test etmek için iyi.

Buna `/API/login` diyeceğiz.

Normalde kullanıcıların giriş yapacağı bir route olabilir, ama burada yalnızca belirli bir kullanıcıyı login eden özel bir route oluşturacağız.

Bunun bir `SignInManager` istemesi gerekecek. Tip olarak `IdentityUser` da olacak. Buna `sign in manager` diyeceğiz. Ve ayrıca bir `user manager`’a ihtiyacımız var; buna da `user manager` diyelim.

Peki kullanıcıyı nasıl login edeceğiz?

Önce kullanıcıyı almamız gerekiyor: `await user manager dot find by email async` ve `test user at example.com`.

Bunu yukarıdan kopyalamalıyım ki tam aynı olsun.

Bu, kullanıcıyı alacak. Sonra `if user equals null` diyeceğiz; yani o kullanıcı gerçekten yoksa kontrol edeceğiz.

Bu route’u önceki iki route’u çalıştırmadan çağırırsak sorun olur; o yüzden bu durumu yakalayalım.

`results dot not found` ve sonra `user not found` diyelim.

Ardından `await sign in manager dot sign in async` var ve bu da kullanıcıyı ister. Sonra cookie’nin tarayıcı kapandıktan sonra kalıcı olup olmayacağını belirleyen `is persistent` flag’i var. `false` diyelim.

Özetle: kullanıcıyı user manager ile alıyoruz. Bu, bu route’u çağırdığımızda oluşturduğumuz kullanıcı. Eğer yoksa not found döndürüyoruz. Eğer varsa `results dot okay` döndürüyoruz ve “user signed in!” gibi bir şey yazıyoruz; çünkü bu büyük bir an.

Şimdi sunucuyu tekrar başlatalım.

Bu `/API/login`.

Bir çağrı daha oluşturalım: `API slash log in`.

Ve şimdi bir istek gönderelim: rolleri oluştur, rolleri ata, sonra login.

Şimdi burada `set cookie` header’ını aldığımızı görüyorsunuz. Bu, tarayıcınızın bu cookie’yi bu değerle ayarlamasını sağlayan özel bir header’dır.

Bu, uygulamamızın geri gönderdiği bir çeşit “gizli anahtar” gibi; “hey, giriş yaptım, ben buyum” demek için.

Tekrar kontrol edelim: eğer `/admin`’e gidersem unauthorized. `user claim check` unauthorized.

O zaman tekrar login yapayım ve cookie’yi alalım.

Tarayıcının normalde yaptığı şey bu cookie’yi almak ve onu `cookie` header’ı olarak geri göndermek.

Şimdi bu kodu çalıştırırsam, **200 OK admin access only** döndüğünü görüyoruz.

Yani bu kullanıcıyı başarıyla login ettik, cookie geri aldık ve cookie’yi de bununla birlikte set ettik.

Bunu manuel yapmak zorunda kaldım, çünkü REST API ayarlarında bir ayarı değiştirdim. Normalde tarayıcı gibi davranıp cookie’leri senin için tutar.

Kullanıcı login olur olmaz, herhangi bir route’a gittiğimde bu cookie’leri otomatik olarak gönderir.

Eğer burada cookie için ararsanız “remember cookies for subsequent requests” diye bir seçenek var.

Login olduğunda cookie’yi alır ve tüm isteklerde otomatik gönderir.

Ama test için bunun kapalı olmasını tercih ediyorum; böylece bunu açıkça “ne zaman cookie göndermek istiyorum, ne zaman istemiyorum” diyerek kontrol edebiliyorum.

Bu route’u çalıştırırsam hâlâ unauthorized. Cookie’yi buraya indirirsem, ne olacak?  **200 OK** .

Ve yine, bunun nedeni bu rotaların herhangi bir özel claim veya rol gerektirmemesi. Sadece yetkili bir kullanıcı olmasını istiyorlar.

Şimdi bunu değiştirelim.

---

## 📜 Policy Oluşturma

Policy’leri authorization builder üzerinde ekleyeceğiz.

Aşağıya geliyorum ve `dot add policy` diyorum.

Policy’nin bir adı olacak: buna `admin` diyelim.

Bu bir policy alacak ve `policy dot require...` diyeceğiz.

Bu sefer rol kullanalım: `admin`.

Yani bu policy, kullanıcının admin rolüne sahip olmasını gerektiriyor.

Şimdi bir tane daha policy yapalım: `add policy`.

Bu sefer adını `I.T. department` koyalım.

Bu kez rol yerine `policy dot require claim` diyeceğiz.

`department` diyeceğim ve bunun değeri `I.T.` olacak.

Yani bu claim: `department` claim’i ve değeri `I.T.`.

Kullanıcımız zaten admin rolüne sahipti, ama bunu kontrol etmiyorduk; sadece authorized user olup olmadığına bakıyorduk. Yani giriş yapmış olduğunu söyleyen cookie’ye sahip olması yeterliydi. Özel bir izin gerekmiyordu.

Şimdi bunu `admin` yaparsam, `admin` policy’sini zorunlu kılıyoruz; bu da admin rolünü zorunlu kılar.

Aşağıda da bunu `I.T. department` zorunlu yapabiliriz.

Bunlar `admin` ve `I.T. department` policy’lerinden geliyor.

Böylece artık bu rotaların, kullanıcı cookie’si üzerinde belirli gereksinimleri oluyor.

Kaydedelim ve tekrar test edelim. Sunucuyu yeniden başlatıp davranışa bakalım.

---

## 🧪 Policy Sonrası Test

İsteklerime geliyorum.

Rolleri oluştur, rol ata, sonra `API login` tekrar.

Cookie’yi alacağım ve aşağıda cookie’yi yeni cookie ile değiştireceğim.

Şimdi bakalım ne alıyoruz.

Önceden tüm rotalara erişebiliyorduk, şimdi ne yapabiliyoruz?

 **admin only** : hâlâ erişebiliyorum.

 **user claim** : erişemiyorum.

Çünkü kullanıcımızın o claim’i yok.

Ve cookie göndermediğimiz için  **blogs** ’a da erişemiyoruz.

Ama cookie’yi alıp aşağıya eklersek artık `blogs`’a erişebiliyoruz.

---

## ➕ Kullanıcıya Claim Eklemek

Son olarak, kullanıcıya bir claim ekleyelim ve bunun için yeni bir route ekleyelim.

Buna `/API/add claim` diyeceğiz.

Benzer olacak ama burada sadece `user manager` gerekecek.

Bir kez daha user’ı isteyeceğiz. Kullanıcı yoksa `results dot not found` döndüreceğiz.

Bu sefer rol eklemek yerine şunu yapacağız:

`await user manager add claim async`

Bunu kullanıcı üzerinde yapacağız ve `new claim` diyeceğiz: `department` ve `I.T`.

Bu claim nesnesi `system dot security dot claims`’ten geliyordu sanırım.

Şimdi, bu claim’e sahip mi diye kontrol edelim:

`var claims equals await user manager dot get claims async`, user’ı geçiyoruz.

Sonra `var has it claim`:

`claims dot any c => c dot type equals department and c dot value equals I.T`

Bu, claim’lerinden herhangi birinin type’ı `department` ve value’su `I.T` mi diye kontrol eder.

Son olarak, eğer IT claim’ine sahipse `results dot okay`, değilse `results dot bad request`.

Harika. Bunu kaydedeceğim.

Şimdi bir çağrı daha ekleyelim: `API slash add claim`.

Sunucuyu tekrar yeniden başlatacağız.

Rolleri oluştur, rolleri ata, claim’i ekle, login ol, cookie’yi al; sonra bu cookie’yi bu üç route’un her birinde kullanacağız.

Ve bu sefer erişebildiğimizi görmeliyiz.

Oraya erişebiliyoruz.

Claim route’una da erişebiliyor muyuz? Evet.

Ve `blogs` route’una da hâlâ erişebiliyoruz.

---

## ✅ Kapanış

Artık bir **role-based policy** ve bir **claims-based policy** uyguladık.

Ve login olmuş bir kullanıcının rolü veya claim’i olup olmamasına göre erişebileceği bu üç route’a sahibiz.

Biliyorum bu çok şey. Umarım bu, kimlik doğrulama sistemleri kurmaya nasıl başlayabileceğinize dair iyi bir örnek verir.

Ve bu, bu kursta uygulama geliştirmeye devam ederken kullanacağımız çerçeve olacak.

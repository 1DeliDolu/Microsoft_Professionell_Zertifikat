## 🔐 JWT’ler için Güvenlik En İyi Uygulamalarını Uygulamak

JWT’lerle nasıl çalışacağımızı ve bunları .NET’te nasıl uygulayacağımızı öğrendik. Ancak bu noktaya kadar, aslında özellikle çok da güvenli olmayan bazı pratikleri bilerek gösteriyordum. Amaç, ardından en iyi uygulamaları nasıl hayata geçireceğimizi gösterebilmekti. Bazı şeyler, uygulamanızın varsayılan olarak güvenli olması için çok kolay yapılabilir. Bu durumda ise, bilerek kötü bir yapma şeklini göstermeye çalıştım.

Özellikle, anahtarınızı ( *key* ) asla bu şekilde doğrudan kodun içine kaydetmek istemezsiniz. Ayrıca bir token’ın  *lifetime* ’ını her zaman doğrulamalısınız ve genellikle *issuer* ile  *audience* ’ı da doğrulamak istersiniz.

---

## 🗝️ Anahtarı Koddan Çıkarmak

İlk işlerden biri olarak, bunu koddan çıkarmayı ele alalım. Bunu yapmanın bir sürü yolu var. Bunun kodda kalmasını istememenizin sebebi şu: Birisi kod tabanınızı ele geçirirse, aynı anda hem anahtara hem de kod tabanına sahip olur.

Örneğin bunu Git gibi bir sürüm kontrolüne kaydederseniz ve biri kod tabanınıza ulaşırsa, anahtarınız da elinde olur. Ama bunu koddan çıkarırsanız, kod tabanınızı ele geçirse bile anahtarınız onda olmaz. Böylece umarız özellikle kötü niyetli bir şey yapamaz.

En azından, bu değeri koddan çıkarır ve  *app settings* ’e eklerdim. Buna istediğim adı verebilirim; ama ben `JWT key` diye adlandıracağım ve bu değeri buraya koyacağım.

Bunu daha güvenli yapan tek şey şudur: Sürüm kontrolü kullanırken, bu dosyayı repository’nizin geri kalanıyla birlikte commit etmemelisiniz. Git kullanıyorsanız, bir *gitignore* dosyası oluşturur ve özellikle “bu dosyayı commit etmek istemiyorum” diye belirtirsiniz.

Bu da şu anlama gelir: Başka biri bu uygulamayı kullanmak isterse—örneğin bu kodu bir iş arkadaşıma verirsem—uygulamayı ayağa kaldırabilmeleri için bu bilgiyi ayrıca ve ayrı bir şekilde de vermem gerekir.

---

## ⚙️ App Settings’teki Anahtara Erişmek

Artık değerimiz burada olduğuna göre kaydedebilirim. Peki bu değere nasıl erişiriz?

Programımıza gidelim ve bu sefer yukarıda yeni bir değişken oluşturalım; buna `jwtKey` diyelim. Sonra bunu `builder.Configuration` üzerinden alalım ve anahtar adı olarak da ayarladığımız `JWT key` değerini kullanalım.

Böylece `jwtKey` elimizde olur ve burada, orijinal string’in yerine bu değeri koyarak kullanabilirim.

Uygulamayı yeniden başlatacağım ve burada dalgalı çizgiler (squiggles) göreceksiniz; çünkü bu değer mevcut olmayabilir, *null* olabilir. Normalde burada bir hata fırlatmak ya da bir varsayılan değer ayarlamak gibi bir şey yapmak istersiniz.

Sunucuyu yeniden başlattıktan sonra geri gelip yeni anahtarı kullanarak test edebilirim ve gerçekten de çalışmaya devam ettiğini görebiliriz. Artık anahtarı doğrudan koddan değil, ayarlardan alıyoruz.

Ama belirttiğim gibi bunun bir güvenlik zafiyeti var: Repository’ye kaydederken bu dosyayı commit etmediğinizden emin olmanız gerekiyor.

---

## 🧰 .NET User Secrets ile Anahtar Saklamak

Bunları saklamanın bir başka yolu da .NET’te *user secrets* denen bir teknoloji kullanmaktır.

Terminalde şunu çalıştırırsak:

```bash
dotnet user-secrets -h
```

Burada .NET user secrets kullanımıyla ilgili bilgiler görürüz. Bu bir  *secret manager* ’dır; yani gizli bilgileri kod tabanınızın dışında, oldukça güvenli bir yerde tutmak içindir.

Burada bazı flag’ler var; temel olarak şunlar önemli:

* Tüm secret’ları temizlemek ( *clear* )
* Başlatmak ( *init* ) — ilk yapmak istediğimiz bu
* Secret’ları listelemek ( *list* )
* Kaldırmak ( *remove* )
* Belirli bir secret set etmek ( *set* )

İlk olarak ilgili dosyalardan birini açalım: `.csproj` dosyası. Şimdi şu komutu çalıştırdığımda bu dosyada bir değişiklik göreceksiniz:

```bash
dotnet user-secrets init
```

Bu komutun, `UserSecretsId` eklediğini göreceksiniz. Bu, secret’ların gideceği yer için bir placeholder olan özel bir ID’dir.

Şimdi yeni bir secret oluşturabiliriz. `set` komutuyla bir ad ve bir değer vermemiz gerekiyor:

```bash
dotnet user-secrets set "my other JWT key" "<buraya-anahtar-değeri>"
```

Enter’a bastığımda bunu eklemiş olmalı.

Peki bu gerçekte ne yaptı? Klasörleri açtığımda, veriyi özel bir yerde sakladığını görebilirsiniz. Makinemdeki bir klasör olan  *AppData* ’ya giderim, sonra `Microsoft` ve ardından `UserSecrets`. Buradaki kodun, `.csproj` dosyasına eklenen kodla eşleştiğini göreceksiniz.

Birden fazla proje oluşturursanız, her birinin burada kendi klasörü olur. Bunu açıp dosyayı görüntülersem, `my other JWT key` ve ona karşılık gelen değerleri görürüz.

Bu sadece bir JSON nesnesidir ve olan şey şudur: Uygulama başladığında, bu veri uygulamanın config’iyle “birleştirilir” ( *blended* ). Yani, kabaca şunun gibi çalışır: Buraya inip bunu alıp buraya eklemek gibi; ama aslında kodda tutulmaz. Her şeyi arka planda yapar.

Dolayısıyla buna aynı şekilde erişirim: Az önce verdiğim key adını kullanarak config’ten alırım ve bu yine çalışır.

Bu sefer farklı bir anahtar verdiğimiz için, uygulamayı yeniden başlatalım. Sonra oluşturduğumuz kod ile yeni bir JWT üretirsek, bu anahtarı alıp burada anahtarın yerine koyabilir ve secure route’a istek atmaya devam edebilirim.

İşte bu, *user secrets* ile secret set etmenin yolu; bunu yapmak nispeten güvenli bir yöntemdir.

Ama bu yalnızca geliştirme ortamında ( *development environment* ) çalışır. Production’da ise, Microsoft’un sunduğu hosted bir secret storage sistemi gibi başka bir sistem kullanmak istersiniz; bu da bunu yapmanın gerçekten harika bir yoludur.

Geliştirme ayarlarına da “hardcode” edebilirsiniz; yine sadece bunların sürüm kontrolüne kodla birlikte gitmediğinden emin olun.

---

## ✅ Lifetime Doğrulamasını Açmak

Şimdi anahtarımızı güvence altına aldık; ama burada `ValidateIssuer`, `ValidateAudience` ve `ValidateLifetime` için “doğrulama yapma” diyorum.

Bunlar üç spesifik değer. Bunların içinde en önemlisi, bence `ValidateLifetime`.

Token’ların temel güvenlik özelliklerinden biri, birinin eline olmaması gereken bir token geçerse, onunla kötü niyetli bir şey yapabileceği süreyi kısıtlamaktır.

Lifetime doğrulaması, token’da birkaç değeri kullanabilmemiz anlamına gelir. Bunlardan biri `iat` ( *issued at* ). Bu bir  *epoch time* ’dır; yani belirli bir zaman. Burada bunun 17 Ocak 2018’de şu anlama geldiğini görebilirsiniz. Bu, token’ın hangi andan itibaren geçerli olduğudur.

Sonra `exp` vardır; token’ın ne zaman süresinin dolduğunu belirtir.

Aynı tarihleri kullanırsak, aslında hiç kullanılamayan bir anahtar elde etmiş oluruz; çünkü bir mikrosaniyelik bir süre için geçerli olmuştur. Ama bu değeri alıp sayılardan birini artırırsak, örneğin 17 Ocak’tan 25 Ocak’a uzatmış oluruz.

Dolayısıyla `ValidateLifetime`, sistemimizin mevcut zamanının, *issued* zamanı ile *expired* zamanı arasında olup olmadığını kontrol edeceğimiz anlamına gelir. Bu yüzden bunu `true` yapardım.

Kaydedip yeniden başlatırsam, requests’e gelip tıkladığımda “token’ın expiration’ı yok” gibi bir şey alırız; çünkü orijinal oluşturduğumuz token’da expiration yok.

Ve eğer bu token’ı kullanırsak—altı yıl önce çıkarılmış ve altı yıl önce süresi dolmuş bir token olduğu için—bunun çalışmaması gerektiğini de test edebiliriz. Burada geçmişte süresinin dolduğunu görebiliriz; bu da görmek istediğimiz şeydir.

Son olarak, yeni bir epoch time oluşturacağım. Bazı online araçlar var. Bakalım kullanışlı bir şey bulabilir miyim… İşte bu mevcut epoch time. Bunu buraya koyarım ve bir daha kopyalarım. Sonra bu sayıyı biraz artırırım ki gelecekte olsun. Bu da çalışmalı diye düşünüyorum.

Bunu gönderdiğimizde bunun artık güvenli olduğunu görüyoruz.

Lifetime doğrulamasının yaptığı şey budur. İdeal olarak, token’ı yalnızca birkaç dakika, belki 30 dakika, belki 1 saat gibi küçük bir süre geçerli olacak şekilde ayarlarsınız.

Sonra, bir refresh sistemi kullanarak kullanıcıların yeni token’lar almasını sağlarsınız. Böylece token yanlışlıkla yakalansa bile, kullanıcı yeniden giriş yapmak zorunda kalmadan oturumunu sürdürür; ama aynı token’ın iki yıl sonra bile kullanılabilmesi gibi bir durum olmaz.

---

## 🧾 Issuer ve Audience Doğrulamasını Açmak

Diğer iki parça `ValidateAudience` ve `ValidateIssuer`.

Bunlar, “sert” güvenlik özellikleri gibi değildir. Asıl kritik olan, güvenlik anahtarının ( *security key* ) imzayla eşleşmesidir.

Issuer ve audience doğrulaması daha çok şunu sağlar: Arka planda bir şeyi yanlışlıkla karıştırmamanız.

Issuer, token’ı kimin ürettiğini ifade eden bir string’dir. Bunu yalnızca, token anahtarınızla imzalandığı için güvenilir kabul edebilirsiniz.

Audience ise: Bu token kimin için üretildi? Kim tarafından tüketilmesi amaçlanıyor? Bu sizin uygulamanız olmalı.

Bunları neden kullanmak istersiniz? Örneğin bir uygulamanız var ve bir sebeple birden fazla issuer kullanacaksınız. Kimin ürettiğini ayırt edebilmek faydalı olabilir. Belki birinden farklı bilgi geliyordur. Belki biri diğerinden daha güvenilirdir.

Audience ise “bu token hangi tüketici için?” sorusudur. Genelde bunu web sitenizin domain’i gibi bir değer olarak saklamak yaygındır.

Bu, örneğin büyük bir uygulama yaptığınızda ve birkaç backend olduğunda işe yarar: Bir issuer’ı yanlışlıkla bir backend’e token gönderecek şekilde ayarlarsanız, diğer backend’de bu token’ı tüketmeye çalışmak yerine bunun “yanlış yerde” olduğunu fark etmenizi sağlar.

Bu ikisini `true` yaparsanız, ayrıca “hangi değer olmalı?” diye bir değer de isterler.

Örneğin:

* `ValidIssuer = "MyIssuer"` gibi bir değer
* `ValidAudience = "http://localhost:5030"` gibi bir değer

Bunları kaydedip yeniden başlatırsak, token’da bulunmayan yeni değerler arandığı için, request gönderdiğimde “audience empty is invalid” gibi bir hata alırım.

Token üretimine geri gidip `aud` anahtarını kullanarak audience set edebilirim (burada `aud` için küçük harf `a`). Audience olarak `http://localhost:5030` diyebilirim.

Sonra bir de issuer ister; bu da `iss` claim’i olur. Bunu da (benim verdiğim isimle) `MyIssuer` olarak ayarlayacağım. Burada `MyIssuer`’ın büyük `M` ile olduğunu kontrol ediyorum.

Şimdi token’ı tekrar alıp buraya koyarsam, bunun yeniden güvenli bir token olduğunu görürüz.

Bunlar, JWT’leri daha güvenli yapmak için kullanabileceğiniz birkaç örnekti.

---

## 🧪 .NET User JWTs Aracıyla Lokal JWT Üretmek

Burada kullanmak isteyebileceğiniz başka kullanışlı bir özellik de .NET’in *user jwts* aracıdır.

 *User JWTs* , secret’ları oluşturduğunuz yere benzer şekilde, test için JWT’ler oluşturmanızı sağlar. Yani epoch time’ları hesaplamakla uğraşmadan lokal JWT üretebilirsiniz; JWT.io gibi bir araca da ihtiyaç duymazsınız.

Önce yardım çıktısına bakalım. Burada ilk seferde `.NET`’i yanlış yazdığımı fark edeceksiniz; sonra düzeltiyorum:

```bash
dotnet user-jwts create -h
```

Burada ayarlayabileceğim flag’leri görürüm:

* scheme
* audience
* issuer
* scope
* role
* claim
* not before
* expires on
* valid for

Epoch time’ları bulmakla uğraşmak istemiyorum ama örnek olarak şunu yapabiliriz:

```bash
dotnet user-jwts create --audience "test audience" --issuer "MyIssuer"
```

(Bu audience bizim audience’ımızla eşleşmeyecek; sadece nasıl yapılacağını göstermek için.)

Bu bize yeni bir token verecek. Burada bir ID gibi bir şey var ama esas ilgilendiğimiz token budur.

Sonra şunu diyebilirim:

```bash
dotnet user-jwts list
```

Ve JWT’lerimin listesini görürüm.

Ayrıca anahtarın ne olduğunu da öğrenebilirsiniz. Şunu diyebilirsiniz; sanırım `key` idi:

```bash
dotnet user-jwts key
```

Bu size, token üretimi için kullanılan secret ID’yi verir.

Bu anahtarları kullanmak isterseniz, onları burada doğru şekilde bağlamanız gerekir: doğru issuer, doğru audience ve doğru key.

Burada dikkat edilmesi gereken bir şey var: Bu anahtarı içeri çekerken *base64 encoded* gelecektir.

Eğer `.NET user-jwts` ile üretirseniz, `Encoding.UTF8.GetBytes` çağırmak yerine `Convert.FromBase64String` kullanmak istersiniz ve builder config’teki değeri buna verirsiniz.

---

## 🗂️ User JWTs’in Oluşturduğu Dosyalar ve Konumlar

Bu değerlerin ne olduğunu merak ediyorsanız, Finder’a geri döndüğümüzde birkaç şey yaptığını görebilirsiniz.

Bir JWT oluşturdu; bu, user jwts listesinin içinde görünüyor. Token burada ve token etrafında bazı bilgiler var. Asıl önemli olan token; ama bu bilgi, token’ın içine ne kodlandığı hakkında ipuçları verir.

Ayrıca *user secrets* tarafına gidersek, anahtarın burada saklandığını görürüz. Bu değer şurada tutulur:

`AuthenticationSchemes:Bearer:SigningKeys`

Burada bunun bir liste ( *list* ) olduğuna dikkat edin; sonra da value gelir.

Eğer bunu `builder.Configuration` üzerinden almak istersek, kabaca şu şekilde yaparız: signing keys listesindeki ilk değer ve onun `value` alanı.

Ve sonra issuer ve audience’ı da buna göre eşleştirmek istersiniz.

Ayrıca bazı ayarlar da eklemiş olur: Audience ve issuer için valid değerleri burada da ekler. Dolayısıyla burada kullanılan audience ve issuer’ı kullanmak istersiniz.

---

## 🧩 Kapanış

Bu, geliştirme sunucunuz için güvenli JWT’leri ayarlamanın ve lokal olarak JWT üretmenin yoludur; böylece JWT.io gibi bir aracı kullanmak zorunda kalmazsınız.

JWT’ler inanılmaz güçlü bir araçtır. Yine, mümkün olduğunda cookie kullanmayı şiddetle öneririm; doğru ortamda inanılmaz iyi bir seçenektir. Cookie’leri kesinlikle kullanamadığınız durumlarda ise JWT’ler mükemmel bir güvenlik aracıdır.

Sadece şunu bilin: Etrafından dolaşmanız gereken bazı küçük meseleler vardır ve mümkün olduğunca güvenli olmaları için en iyi güvenlik pratiklerini uyguladığınızdan emin olmanız gerekir.

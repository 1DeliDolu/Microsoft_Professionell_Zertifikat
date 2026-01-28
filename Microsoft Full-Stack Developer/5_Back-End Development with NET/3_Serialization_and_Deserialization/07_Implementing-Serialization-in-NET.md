## 🧩 .NET’te Serialization Uygulamak

Serialization hakkında çok şey öğrendiniz, ama artık serialization’ı uygulamalı olarak görme zamanı. Bu videoda, .NET’te serialization tekniklerini uygulayacağız.

---

## 👤 Person Sınıfı ve Örnek Nesne

Burada *Person* sınıfımızı konuşarak başlayalım. Yani bir  *Person* , tanımladığımız şekliyle *required* bir *username* string’ine ve bir *userAge* int’ine sahiptir.

Yukarıda ayrıca tek bir örnek *Person* oluşturduğumuzu göreceksiniz. Bu durumda, *username* değeri *Alice* ve *userAge* değeri  *30* .

---

## 🌐 Serialization’ın Amacı

Serialization’ın tüm amacı, bunun gibi bir nesneyi alıp ağ üzerinden iletmek ve ardından istemcimizin (client) bu verilere erişebilmesini sağlamaktır.

Bu da demek oluyor ki, veriyi bilgisayarımızın bellekte anladığı hâlden alıp, ağ üzerinden farklı bir formatta göndermemiz gerekiyor; sonra da istemci tarafında bu veriyi alıp, bilgisayar belleğinde kullanılabilecek bir şeye geri dönüştürebilmeleri gerekiyor.

Şimdi sizi bir dizi örnek üzerinden yönlendireceğim; en manuel yöntemden en otomatik yönteme doğru ilerleyeceğiz. Bunu büyük ölçüde, bu kavramları kademeli olarak inşa etmenize ve perde arkasında neler olduğunu anlamanıza yardımcı olmak için yapıyorum.

---

## 🛣️ Mevcut Route ve Yeni Route Eklemek

Burada şu anda tek bir route var, *root route* olarak adlandırılıyor. Sadece “I am root” döndürüyor.

Ve eğer burada yeni bir route daha eklersek, buna *get* diyeceğiz ve sonra bunun bir  *name* ’e ihtiyacı var.

Buna *manual JSON* diyelim. Sonra ikinci bir argümana ihtiyacı var ve o da bir fonksiyon olacak.

Ve şimdi *manual JSON* adlı tamamen geçerli bir route’umuz var.

---

## 🧾 Manuel JSON Serialization

İlk yapmamız gereken şey, nesnemizi açıkça serialize etmek.

Buna *jsonString* diyeceğiz ve *JsonSerializer* kullanacağız. Bir sürü JSON seçeneği var. Ve bunun üzerinde *Serialize* metodunu çağıracağız; içine de örnek  *person* ’ımızı geçeceğiz.

Böylece bu nesneyi, ağ üzerinden gönderebileceğimiz bir veri string’ine dönüştürmüş olacağız.

Sonra yapacağımız şey, döndürmek olacak; burada *TypedResults* kullanacağız. *Results* da kullanabilirsiniz, ama ben *TypedResults* tercih ediyorum. Tavsiye ediliyor.

Ve sonra bunun *Text* değerini  *jsonString* ’imize ayarlayabiliriz.

Son olarak yapmamız gereken bir şey daha var: Bu verinin türünü eklememiz gerekiyor ki istemci bunun sadece string olmadığını, aslında başka bir şeye “unpack” edileceğini anlasın.

Bu yüzden *application/json* diyeceğiz.

Sonra noktalı virgülümüzü ekleriz.

Şimdi bu, veriyi manuel olarak serialize etmenin temel yolu.

 *JsonSerializer* ’ı çağıracaksınız, *Serialize* metodunu kullanacaksınız.

Bu, veriyi bilgisayarınızın belleğinde anlaşıldığı hâlden, ağ üzerinden iletilebilecek bir formata dönüştürüyor.

Bunu *text* olarak göndereceksiniz ve bunun *application/json* olduğundan emin olacaksınız.

Bu, bunu manuel şekilde yapmanın ilk yolu.

Şimdi bunu kopyalayıp yapıştıralım.

---

## 🛠️ Custom Serializer Ayarları

Bir sonrakine *custom serializer* diyelim.

Şimdi bunun bir kısmını kaldıralım.

Burada göstermek istediğim şey, bazı özel serializer ayarlarını nasıl set edeceğiniz.

Burada bizim için serialization yaptı ama bir sürü varsayılan ayar (defaults) kullanıyor. Ne olup bittiğini gerçekten bilmiyoruz.

O yüzden bir *options* oluşturalım ve *new JsonSerializerOptions* diyelim.

Bu, farklı anahtarlar alır; burada farklı değerler ayarlayabilirsiniz.

Şimdilik oynayacağım şeylerden biri:  *property naming policy* ’yi değiştirelim.

Bu, property’lerinizin nasıl adlandırıldığını değiştirir.

*JsonNamingPolicy.SnakeCaseLower* diyeceğim.

Bu, bizim naming convention’larımızı burada olduğu gibi  *PascalCase* ’ten dönüştürecek; yani ilk harf büyük ve sonraki her kelimenin ilk harfi büyük olacak. İlk kelimenin ilk harfi de dâhil.

*snake_case* ise Python gibi dillerde yaygın kullanılır. Bu durumda bir değişkende tüm değerler küçük harf olur ve alt çizgilerle ayrılır.

Diyelim ki bu API’nin Python servisleri tarafından tüketilmesi (consumed) amaçlanıyor. O zaman bekledikleri naming convention bu olur.

Yani politikalarınızı değiştirirken düşünebileceğiniz şeylerden biri: Bu nasıl tüketilecek?

Şimdi elimde bu *options* var. Bunlarla ne yapabilirim?

Custom serialize edelim.

Diyelim ki  *var customJsonString* .

Ve bu, deserialize etmeyecek; deserialize değil, yeni serializer options’larımızı kullanarak serialize edecek.

Yani daha önce yaptığımız gibi, *JsonSerializer.Serialize* kullanacağız.

Ve içine tekrar örnek  *person* ’ı geçeceğiz.

Bu sefer ikinci argüman olarak  *options* ’ı da geçeceğiz.

Böylece örneğimizde özel serializer options kullanmış oluyoruz.

Yine *TypedResults.Text* döndürebiliriz.

Ve içine  *customJsonString* ’i geçeriz; evet, IntelliSense beni yakalıyor.

Ve yine istemcinin bunun ne olduğunu bilmesini sağlamak istiyoruz; yani  *application/json* .

Son olarak noktalı virgül.

Bu, önce yaptığımız şeyin aynısı; ek olarak özel serializer options ile.

---

## 📤 TypedResults.Json ile Daha Basit Gönderim

Şimdi başka bir yöntem deneyelim; *app.MapGet* yapacağız.

Bu sefer buna ne isim verelim? Buna sadece *json* diyelim.

Veriyi göndermenin başka bir yolu bu.

Özel serializer kullanmak yerine, *TypedResults* üzerinde özel bir metot kullanabiliriz ve bu, .NET’in bize verdiği varsayılanları (defaults) kullanmak istiyorsak tüm bu “bulanık” adımları yapmadan veriyi göndermemizi sağlar.

Bu örnekte yapacağım şey şu:

*return TypedResults.Json* diyeceğim ve içine  *samplePerson* ’ı geçeceğim.

Hepsi bu. Tek satır kod yazmam gerekiyor.

Bunun yaptığı şey: Bunu manuel olarak JSON olarak serialize ediyor.

Veriyi JSON olarak göndermek istediğimizi biliyor ve tıpkı daha önce yaptığımız gibi *application/json* header’ını burada ayarlıyor; böylece istemci anlıyor.

Ama yukarıdaki tüm adımları yapmak zorunda değiliz. Sadece böyle gönderebiliriz.

Peki neden önceki adımları yapasınız?

Önceki yöntemi, property naming policy gibi şeyleri değiştirmek veya nasıl serialize edildiğini değiştirmek istiyorsanız yaparsınız.

Varsayılanları kullanmak istiyorsanız, normal JSON gönderecekseniz, *TypedResults.Json* yolu çok kullanışlı.

Ama daha da iyisi var.

Bir tane daha route oluşturalım.

---

## 🤯 Otomatik Serialization

Bunu aşağıya kopyalayacağım ve bu sefer buna *auto* diyeceğiz.

Şimdi işler gerçekten “acayip” olacak.

*return samplePerson* diyeceğim.

Hepsi bu.

Varsayılan olarak .NET JSON’a serialize eder.

Temelde bunu perde arkasında yapar; yani bunu gönderirseniz, aslında bu işlemlerden geçen şey.

Bir *samplePerson* nesnesi oluşturup direkt gönderebilirsiniz.

Aslında ağ üzerinden göndermek istediğiniz herhangi bir nesneyi, bir *return statement* içine koyup gönderebilirsiniz.

Route oluştururken string gönderebilirsiniz, nesne gönderebilirsiniz, *typed results* ve *results* gönderebilirsiniz.

Yani birkaç seçeneğiniz var ve bu, çoğu zaman kullanmak isteyeceğiniz şey; çünkü gerçekten inanılmaz basit.

Bozacak çok şey yok.

Çok kod yazmanız gerekmiyor.

Okuması çok değil.

Bakımı çok değil.

Ve normalde yapmak istediğiniz şeyi yapıyor: gönderdiğiniz veriyi JSON’a serialize etmek.

---

## ❓ JSON İstemediğinizde Ne Olur?

Bu bir soru doğurabilir: JSON’a serialize etmek istemediğinizde ve başka bir şeye serialize etmek istediğinizde ne olur?

Benim ilk önerim: mümkün olduğunda JSON kullanın.

Web’in fiilî (de facto) veri değişim formatı hâline geldi.

Kullanmak istemediğiniz zamanlar da var. Bazı sınırlamaları var.

Burada ona girmeyeceğim.

O yüzden XML göndermeyi kısaca anlatacağım ve bunun neden gerçek bir “baş ağrısı” olduğunu sonunda anlayacaksınız.

---

## 🧱 XML Göndermek

Aşağıda bir route daha oluşturalım ve bu sefer buna *XML* diyelim.

XML göndermek uzun bir iş.

Öncelikle bir *XmlSerializer* gerekiyor.

Yani bir serializer oluşturmalıyım. JSON serializer gibi hazır bir serializer elimde yok.

Bu yüzden yeni bir *XmlSerializer* oluşturmalıyım.

Sonra bunu import etmem gerekiyor; burada tıklayacağım ve bu, yukarıya *using* ifademizi ekleyecek; *System.Xml.Serialization* içinden çekiyoruz.

Şimdi yeni bir serializer’a ihtiyacım var ve serializer’ın belirli bir tipe ihtiyacı var.

Bu, *Person* tipi olacak; çünkü bunun hangi tipi serialize edip deserialize edeceğini bilmesi gerekiyor; bizim  *JsonSerializer* ’ımızın kendi kendine çıkardığı şeyin aksine.

Sonraki ihtiyacım şu:  *var stringWriter* ; yani bir string tutabileceğimiz bir yer oluşturmamız gerekiyor.

*var stringWriter = new StringWriter* diyelim.

Sonra *xmlSerializer.Serialize* çağıracağız.

İçine  *stringWriter* ’ı ve  *samplePerson* ’ı geçeceğiz.

Ve burada bir şey yanlış yaptım çünkü *serialize* yapmak istiyorum, *serializer* değil.

Şimdi bunu çağırmak bizim serializer’ımızı kullanacak, serialize edecek,  *person* ’ı alacak ve bunu  *stringWriter* ’a yazacak.

Ve  *stringWriter* , yeni serialize edilmiş XML’i tutacak olan şey gibi.


## 🧩 Sonraki Adım: XML Çıktısını Oluşturmak ve Döndürmek

Sonra yapmak istediğimiz bir sonraki şey *var xmlOutput* tanımlamak; buna böyle diyeceğiz. Ardından `stringWriter.ToString()` diyeceğim; bu, onu artık serialize edilmiş bir string’e dönüştürecek.

Ve şimdi döndüreceğiz; `TypedResults.Text(xmlOutput)` diyelim; az önce oluşturduğumuz değer bu.

Ve yine, bu sefer JSON yerine *application/xml* olduğunu söylemek isteyeceğiz. Vay canına, bu çok fazla adım. Anlaması gereken çok şey var.

---

## 🔍 JSON ile XML Arasındaki Fark

Şimdi burada farkın ne olduğuna biraz bakalım.

Daha önce yaptığımızla karşılaştırırsanız, daha önce sadece bir *JsonSerializer* aldık, verimizi serialize ettik ve sonra bunu buna benzer bir metotla döndürdük; tek fark *application/json* kullanmamızdı, *application/xml* değil.

Bu durumda ise bu karmaşık adımlara gitmek zorundayız. XML serializer’ı açıkça oluşturmak zorundayız; oysa yukarıda sadece bir JSON serializer var ve onun *Serialize* metodunu çağırabiliyoruz.

Ayrıca bir *StringWriter* oluşturmak zorundayız; yine bu, serializer’dan gelen string’i yazacak olan şey.

Sonra aslında string’i burada yazıyoruz.

Sonra çıktıyı alıyoruz.

Yani burada olan şey bu.

Ve bunların hepsi veriyi serialize etmenin farklı yolları.

Yine, bununla bunun arasındaki farka bakın.

XML kullanmak için çok açık bir nedeniniz yoksa—yani çok özel bir neden—JSON kullanın. Gerçekten harika bir veri değişim formatı.

---

## 🧪 requests.http ile Route’ları Test Etmek

Göstermek istediğim son şey, *requests.http* içinde bir araya getirdiğim bazı istekler.

Bunlar, bu farklı route’lardan veriyi almak için yazılmış istekler.

Ben `dotnet watch run` yapacağım ve bu sunucumuzu başlatacak.

Ve unutmayın, sunucunuzu yeniden başlatmak için her zaman *Ctrl + R* yapabilirsiniz; önemli değişiklikler yaptığınız her seferde bunu yapmak isteyeceksiniz.

Şimdi sunucumuz çalışıyor gibi görünüyor ve işte burada. “I am root.”

Tarayıcıdan hızlıca çıkıp tekrar *requests.http* dosyasına döneceğim; çünkü burada görmek istediğim şeyler biraz daha güzel görünecek.

Şimdi fark edeceğim ilk şey şu: burada yanlış port var, yani her zaman portunuzu kontrol edin.

Çok kullanışlı bir kısayol:  *Ctrl + D* . Bu, bir kelimeyi çoklu seçer.

Şimdi bakın; bunların hepsi aynı anda seçildi ve ben `5227` yazabiliyorum.

Bu kısayol, ilk gördüğümde aklımı uçurmuştu. Çok kullanışlı.

Şimdi burada kaydedelim ve ilk isteği gönderelim; burada yanıtı geri aldığımızı görüyorsunuz:  *username* ,  *userAge* .

Bunlar *PascalCase* naming convention’ına uygun beklediğimiz şekilde görünüyor.

---

## 🧾 JSON Route’larında Naming Convention Farkları

Şimdi bir sonraki istekte JSON kullanacağız ve aynı şeyi görmeliyiz; ama şimdi *username* ve  *userAge* ’in altında çizgi olduğunu görüyoruz.

Ve unutmayın; yukarıdaki JSON route’unda bu  *TypedResults* ’ları kullandık.

 *TypedResults* ’lar, konvansiyon gereği bunu  *camelCase* ’e dönüştürecek.

Şimdi custom serializer kullanırsak—burada var—bunların *snake_case* olarak geldiğini göreceksiniz ve bu, custom serializer’da tanımladığımız şeydi.

Son olarak burada bir tane daha vardı.

Bunu XML olarak almaya çalışabiliriz ve bunu gönderirsek, bunun JSON olmadığını görürsünüz.

Beklediğimiz gibi gerçekten XML.

---

## 🌍 Global Serializer Politikaları Tanımlamak

Göstermek istediğim son şey: Bazen serializer’ları route seviyesinde ayarlamamak gerçekten faydalıdır.

Bazen global politikalar ayarlamak daha hoş olur.

Bunu yapmak için yukarı çıkıp  *builder* ’ımıza müdahale etmemiz gerekiyor.

Yine, en üstteki builder, uygulama oluşturulmadan önce bazı ayarları değiştirdiğimiz yer.

Buraya birkaç satır ekleyeceğim ve şöyle diyeceğim: `builder.Services`.

Burada `ConfigureHttpJsonOptions` diyeceğiz.

Bu, options’ları alan bir fonksiyon alacak; sonra bunu kapatalım, böylece çalışır bir fonksiyonumuz olur.

Şimdi burada yapacağımız şey: `options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.KabobCaseUpper`.

Dünyada *kabob case upper* kullanmak isteyeceğiniz bir sebep bildiğimi sanmıyorum. Gerçekten çok tuhaf bir şey.

Tüm kelimeler büyük harf olacak ve farklı kelimeler arasında tire olacak.

Bunu kullanma sebebim, çok kolay görünmesi.

Normalde bunu  *PascalCase* , *snake_case* veya *camelCase* gibi bir şeye çevirmek istersiniz. Bunlar çok daha yaygın konvansiyonlar.

Ama eminim *kabob case upper* istemek için de bazı nedenler vardır.

Şimdi burada yeterince büyük değişiklik yaptım; her şeyin yayıldığından emin olmak için sunucumu yeniden başlatacağım.

---

## 🔁 Global Ayarların Route Davranışına Etkisi

Ve şimdi birkaç şey göstermek istiyorum.

 *Manual JSON* ’u hatırlayın: bir serializer kullandık, veriyi döndürdük.

 *Custom serializer* ’da: custom serializer options oluşturduk.

Ve burada: yeni bir serializer oluşturmadan `TypedResults.Json` kullandık; yani varsayılan ayarlarla veriyi göndermesine izin verdik.

Şimdi buraya gelelim ve tekrar bazı istekler gönderip ne olduğuna bakalım.

Burada *PascalCase* var. Bu, daha önce gördüğümüz şey.

Burada JSON route’una gönderiyorum. İşte o  *kabob case* .

Yani JSON üzerinde  *kabob case* ’in override ettiğini görüyoruz.

Bu sefer global default kullanılıyordu.

Yani bu, route ayarını ezmiş oldu.

Ama şimdi custom serializer’a gidip bunu çalıştırırsak, hâlâ *snake_case* olduğunu görürsünüz.

Bu size garip gelebilir ama sebebi şu: Burada global ayarları set ettik, ama aşağıda yeni custom options ile yeni bir custom serializer kullanıyoruz.

Yani o global ayarları tamamen override ediyor.

Ve burada kontrol edebiliriz; *manual JSON* gönderdiğimizde ne olduğuna bakalım: yine  *PascalCase* , çünkü yine global’i kullanmıyoruz; çünkü bir custom serializer kullanıyoruz. Sadece custom options set etmiyoruz.

---

## ✅ Kapanış: En Önemli Çıkarım

Artık JSON’da serialization hakkında bilmeniz gereken neredeyse her şeyi biliyorsunuz.

Ve belki de bundan çıkarılacak en önemli ders şu: mümkün olduğunda bunu yapın.

Sadece bir nesne döndürün.

.NET’in size mantıklı standartlar vermesine izin verin ve API’niz üzerinde bu kadar spesifik bir kontrol seviyesine ihtiyaç duyduğunuzda kullanabileceğiniz bu diğer seçeneklerin olduğunu bilin.

Modern .NET’in harika yanı şu: Çoğu zaman serialization hakkında hiç düşünmeniz gerekmez.

Route handler’larınız zaten bunu sizin için halleder.

## 🐞 Copilot ile Entegrasyon Kodunu Hata Ayıklama

Ön yüz ve arka uç kodunu entegre etmeye çalışırken, iki ayrı sistemle çalıştığınız için bug’ları bulmak ve düzeltmek bazen zor olabilir. Bu ekran kaydı, **Microsoft Copilot** kullanarak bu entegrasyondaki problemleri nasıl çözeceğinizi ele alacak.

Copilot; zaman kazandırabilir, hataları tespit edebilir ve ardından bunları düzeltmenize yardımcı olabilir.

---

## 🧪 Örnek Senaryo

Burada, harici bir API’ye çağrı yapan çok basit bir konsol uygulamam var. Bu uygulama, sahte veri döndüren `jsonplaceholder.typico.com` gibi bir endpoint’i kullanıyor; bu URL’yi API çağrılarını test etmek ve veri almak için kullanabiliyoruz.

Bu uygulamada:

* bazı **genel bug’lar** var ve Copilot’la bunları düzeltmeye çalışacağız,
* ayrıca **entegrasyon bug’ları** var ve Copilot’la bu entegrasyon sorunlarını da gidermeye çalışacağım.

Koda baktığımda, bazı yerlerde kırmızı çizgiler var; burada açıkça bir problem var. Bazı şeyler düzgün çalışmıyor. Bunu proje build almaya çalışarak da test edebiliriz.

Projeyi build ediyorum ve hata alıp almayacağımıza bakıyorum. Evet, iki hata ile başarısız oldu. Dolayısıyla bunu şu an çalıştıramayacağız.

---

## 🧠 Copilot ile Genel Hataları Düzeltme

Şimdi Copilot’u kullanarak bu kodda neler olduğuna bakacağım. Bu kısım daha çok genel bug düzeltmeleri; ama yine de ne olup bittiğini anlamakta Copilot’tan yardım alacağım.

Projeden tüm kodu alacağım. Bu küçük bir uygulama olduğu için tamamını kopyalayıp yapıştırabilirim. Copilot’la istersem daha granular ilerleyip sadece belirli fonksiyonları ya da değişkenleri de paylaşabilirim. Ama uygulama çok küçük olduğu için tamamını yapıştıracağım.

Çok basit bir prompt veriyorum: Problem şu, kod build olmuyor. Sonra Copilot’tan kodu incelemesini, hataları bulmasını ve bunları düzeltmem için yardımcı olmasını istiyorum.

`Program.cs` içindeki tüm kodu yapıştırdım ve bu sorunu çözmesini istedim.

Copilot, birkaç sorun gördüğünü söylüyor:

* `Main` metodu `Task` dönüş tipine sahip olmalı,
* string alan bir metotta `await` anahtar sözcüğü eksik,
* response’u `List<User>` içine deserialize etmeye çalışıyor ama sınıfın adı `Data`.

Bu maddeleri düzeltmeye çalışıyor. Döndürdüğü kodda:

* `Task` eklemiş,
* `await` eklemiş,
* dönüş tipinde `Data` kullanmış.

Bu kodu kopyalıyorum. Çoğu zaman Copilot’un verdiği koddan sadece belirli satırları alıp kendi uygulamamda düzeltirim; ama burada değişiklikleriyle birlikte tüm kodu yapıştırıyorum.

Artık `Task` var, `await` var ve tip olarak `Data` kullanılıyor. Bu, build sorunlarını çözmelidir. Tekrar build alıyorum.

Build artık başarılı. Şimdi uygulamayı çalıştırıp veriyi alıp alamadığımıza bakalım.

---

## 🔗 Entegrasyon Akışını Çalıştırma

Bu uygulama basit bir web API çağrısı yapıyor. Endpoint olarak `jsonplaceholder that typical calm` kullanıyor (server tarafı). Client tarafı ise bu küçük konsol uygulaması.

Uygulama API’den kullanıcı verisini çekmeye çalışıyor:

* `client.GetStringAsync` ile response alıyor (kullanıcı veri seti),
* bu kullanıcıları `Data` adlı user objesine deserialize ediyor,
* sonra deserialize sonucu tek tek property’lere yazıyor.

Uygulamayı çalıştırıyorum; çağrı yaptığımızda kullanıcı listesi dönmeli.

Ama bir problem var: Bir miktar veri geliyor, fakat tam değil. Arada bir virgül görüyoruz. `username` ve `email` dönmesi gerekirken `username` gelmiyor. Bir şeyler yanlış hizalanmış.

Copilot’a ilk seferde sadece neler olduğunu anlamasını istemiştik. Şimdi yapacağım şey: API çağrısındaki URL’yi alacağım. Copilot uygulamamızın bağlamını ve veri tiplerini biliyor. Bu sefer yanlış response aldığımı söyleyip düzeltmesini isteyeceğim.

Endpoint’i veriyorum ki veri tiplerini analiz edebilsin. Yeni field eklemek istemediğimi, sadece kullandığım field’ların doğru olmasını istediğimi belirtiyorum. Çünkü sorun, ön yüz/arka uç hizalaması gibi görünüyor: JSON tarafındaki alan adlarıyla sınıftaki property adları uyuşmuyor olabilir.

Copilot, “API dokümantasyonuna göre doğru yapı bu” diyerek yanıt veriyor. Yani endpoint’in döndürdüğü alan adlarını analiz etmiş.

Copilot’a göre:

* `fullName` alanı `name` olarak yeniden adlandırılmalı,
* ayrıca bir `geo` sınıfı da ekliyor (istersek ekleyebiliriz).

Şimdilik sadece `fullName` → `name` değişikliğini yapacağım ve sorunu çözüp çözmediğine bakacağım. Çözmezse Copilot’un verdiği diğer detayları da alabilirim.

Property’yi `name` yapıyorum ve uygulamayı tekrar çalıştırıyorum.

Ve şimdi geldi: Artık hem `name` hem de `email` adresi doğru şekilde geliyor.

Demek ki hata şuydu: Yanıtta dönen JSON property adını yanlış kullanmışım. API tarafında bu alanın adı aslında `name`. Copilot bunu tespit etti; URL’ye gidip dönüş tipindeki property isimlerini analiz ederek sınıftaki property adlarını JSON isimleriyle hizaladı. Bu sayede uygulama artık doğru çalışıyor.

---

## 🧾 Origin Header Üzerine Ek Bir Kontrol

Son olarak, `Origin` satırı / default request headers kısmı hakkında bir şey daha sormak istiyorum. Bunun doğru olduğundan emin olmak istiyorum; içgüdüsel olarak orada bir şeyin pek doğru olmadığını düşünüyorum.

Copilot şunu söylüyor:

* Bu header, genellikle bir web sayfasından başka bir domain’e istek yapılırken önemlidir.
* Konsol uygulamasından istek yaptığınız için gerekli değildir.
* Eğer ihtiyaç olursa nasıl kullanılacağını da açıklar.

Bu yüzden `origin` satırını yorum satırına alıyorum ve gerçekten ihtiyaç var mı test ediyorum.

Yorum satırına aldıktan sonra tekrar çalıştırıyorum. Kayıtları yine döndürdü. Yani burada gerçekten gerekli değilmiş.

Bazı bağlamlarda, doğru `Origin` header’ı ayarlanmadığında uygulama API çağrısı yapamayabilir. Böyle durumlarda Copilot bunu eklemenizi önerebilir ve doğru ayarlama biçimini gösterebilir.

---

## ✅ Kapanış

Copilot’u kullanarak ön yüz ve arka uç arasındaki entegrasyon sorunlarını düzeltebilirsiniz. Copilot, sorunları bulmayı ve hata ayıklamayı kolaylaştırır; ayrıca çoğu zaman problemleri daha hızlı çözebilmeniz için düzeltilmiş kod da sunar.

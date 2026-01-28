## 🧩 Kapsamlı Middleware Yönetimi

Tamam, şimdi bunu bir araya getirelim. Kendi middleware’lerimizi yaptık ve custom middleware hakkında öğrendik. Şimdi hepsini tek bir projede birleştirelim ve her şeyin doğru şekilde entegre edildiğinden emin olmamız için Copilot’tan yardım alalım.

Burada üzerinde çalıştığımız standart CRUD API var. Yine bu sadece bir  *blogs API* . Bu blog nesneleri var ve onlar için standart CRUD operasyonlarımız mevcut.

---

## 🧮 Path Counting Middleware’i Eklemek

Burada implement etmek istediğim ilk middleware, önceki bir videodan aldığım path counting middleware. Bu middleware, uygulamada bir path’e her gittiğimizde bunu sayacak.

İlk yaptığım şey şu: request count middleware’im var ve bu bizim servisimizi kullanıyor. O yüzden servisi eklediği kısmı aldığımda, servisin kendisini de aldığımdan emin olmam gerekiyor.

Bu kodun tamamını alıyorum. Hadi bunu kopyalayalım. Ve diğer koda yapıştıracağız.

Tamam. Şimdi aşağıda, tüm top-level statement’larımın olduğu yerde, herhangi bir uyarı veya hata alıyor muyum bakalım. Görünüşe göre burada herhangi bir `using` statement’a ihtiyacım olmadı, harika.

Bunun doğru şekilde uygulanıp uygulanmadığını test edelim; ama bir şey daha almam gerekiyor. Servisimi de almam lazım; şaşırtıcı şekilde bu hata vermedi. Bu da builder tarafında geliyor, harika.

Ve ayrıca count’ları döndürecek route’u da almam gerekiyor.

---

## 🖥️ Uygulamayı Çalıştırma ve İlk Test

Hadi bir terminal açalım ve şunu yazalım:

```bash
.NET watch run
```

Ve birazdan bunun açıldığını göreceğiz.

Bu çalışırken, buraya gelip bir tane daha localhost isteği oluşturacağım. Bu artık yeni bir port kullanıyor:  **5238** . O yüzden bu portu değiştireceğim. Bunu tekrar açacağım, **5238** ile değiştireceğim ve artık doğru porta sahibiz.

Son yapmak istediğim şey bunu `counts` yapmak. Tamam. Ve onları da yukarıya eklemem gerekiyor.

Şimdi teoride bu `counts` route’una gidebilmeliyim. Ama **404 not found** alıyorum.

---

## 🧭 Route Hatasını Düzeltme

Geri dönüp baktığımda, bunun `API` olması gerekiyormuş. Şimdi bunu gönderiyorum ve şimdi boş bir nesne alıyorum.

Yani 200 dönüyor; server açık, server çalışıyor, ama bunu uygulama biçimimde bir şey yanlış.

Bunu kopyalayacağım ve Copilot’un bize yardım edip edemeyeceğine bakalım.

Yeni bir pencere açacağım.

“Counts route’una erişmeye çalıştığımda her zaman boş bir nesne alıyorum.”

Tamam. Görünüşe göre middleware’imi eklemeyi unutmuş olabilirim.

Koda geri dönüp baktığımızda gerçekten de: servisi ekledim, tanımları ekledim ama middleware’i eklemedim.

Önceki kodda bunu nasıl yaptığımıza bakalım.

Bu, benim tek başıma çözmemin ages sürebileceği türden bir hata. Ama bunun yerine bunu Copilot’a aktarabiliyorum ve Copilot yardımcı oluyor.

Yeni middleware’i ekliyoruz. Uygulamayı reload etmem gerekiyor. Şimdi çalışıyor gibi görünüyor.

Bir daha deneyelim.

Hey, count’lar geldi.

---

## 🧾 Header Üzerinden Count Döndürmeyi Kaldırma

Ve görünüşe göre bu header’ı hiç kaldırmamışım. Bunu middleware’den kaldırmak istiyorum.

Burada bir yerde header set ediliyor.

Ve diyelim ki buradan neyi kaldırabileceğimden emin değilim. O zaman bunun bir kopyasını alalım ve Copilot’a geri gidelim.

“Count’u header’larda döndürmek istemiyorum. Bunu middleware’imden nasıl kaldırabilirim?”

Önceki konuşmadan ihtiyacımız olanı aldık, bu yüzden stop responding diyorum. Bu farklı bir konu olduğu için, iyi bir cevap vermezse yeni bir konuşma başlatacağım. Önceki konuşmayı durdurdum; biraz kafası karışabilir.

Burada şunu görüyoruz: middleware’den `context.Response.OnStarting(...)` kısmını kaldırabilirsin.

Bunu kopyalayıp geri dönelim, doğru kodu aldığımızdan emin olalım ve middleware’imizi değiştirelim.

Bir daha test edeceğim. Server’ı tekrar restart edeceğim ki değişikliklerin yansıdığını göreyim. Ve bu header’ın kaybolmasını umuyorum.

Mükemmel. Artık her response’ta count dönmüyor.

Yani sadece bu route count’ları döndürüyor.

Birkaç farklı route’a gitmeyi deniyorum ve işte: hepsinin count’ları geliyor.

Bu tam da beklediğimiz şey.

---

## 🚦 Rate-Limiting Middleware’i Eklemek

Şimdi sırada rate-limiting middleware var.

Bu middleware’i henüz test etmedik, ama önceki videonun sonunda Copilot kullanarak bunu üretmiştik.

Burada `AddRateLimiter` servisini kullanmak istiyorum. Builder var, `UseRateLimiter` var, ve kodumuzda `RequireRateLimiting` var.

Şimdi elimde yeterince çok kod var ve bunu kopyalayıp Copilot’a “ekle” dersem, bazı artifacts oluşmasından korkuyorum: yanlışlıkla bir şeyler ekleyebilir, çıkarabilir veya kodumu değiştirebilir.

O yüzden adımları manuel olarak ayıklayacağım.

Önce service’i alalım.

Burada `AddFixedWindowLimiter` ekliyoruz.

Ama burada `AddFixedWindowLimiter` için bir tanım yok. Önce kodun geri kalanını ekleyelim; belki bazı hatalar gider. Sonra neyi düzeltmemiz gerektiğine geri döneriz.

Şimdi rate-limiter’ı alalım. Sorun yok.

Kaydetti, kodu çalıştırmaya çalıştı; bu normal.

Sonra en sonda `RequireRateLimiting` method’u var. Sanırım eklememiz gereken tek parçalar bunlar.

Yukarıdaki statement’ları da almak isteyebiliriz. Bakalım fark edecek mi. Bu, tüm method’ların sonunda gibi görünüyor.

Her şeyi rate-limit etmek zorunda değiliz muhtemelen, ama hadi bunu tüm method’ların sonuna ekleyelim.

Kaydedince hâlâ hata var.

`using` statement’larını alalım ve ne oluyor görelim.

Type checker’a bir saniye verelim.

Copilot koduna geri dönüp bakalım ne diyor.

Tamam, hâlâ çalışmıyor gibi duruyor.

---

## 📚 Dokümantasyona Bakıp Düzeltme

Şimdi `learn.microsoft.com`’a bakalım. Daha önce bunu açmıştım: rate-limiting middleware dokümanı.

Bakalım nasıl görünüyor; belki Copilot tam doğru üretmemiştir.

Evet, farklı görünüyor. Policy adı `fixed` ve options.

İkinci argümanda da `PermitLimit`, `Window`, `QueueProcessingOrder`, `QueueLimit` var.

Yani yakın üretmiş ama tam doğru değil.

Şimdi buradaki argümanları alıp kendi koduma kopyalayacağım.

Ve artık bunlar policy değil, options olmalı.

Şimdi build’in başarılı olduğunu görüyorum.

Tamam, bu çalışmış gibi görünüyor.

---

## 🧪 Rate Limit’i Test Edilebilir Hale Getirme

Şimdi test edebileceğim bir limit ayarlamak istiyorum.

Diyelim ki permit limit sadece **2** ve bir time span.

Bu satırı kopyalayıp comment out edeceğim ki sonra geri dönebileyim.

Ama muhtemelen daha kısıtlayıcı bir şeye ihtiyacımız var.

`TimeSpan.FromMinutes` yerine `FromSeconds` kullanalım.

Diyelim ki  **5 saniye** .

Tamam.

Servisi restart edelim; service değişikliği hot reload olmamış olabilir.

Şimdi saniyede ikiden fazla istek yaptığımızda bir reddetme görmeliyiz.

Ama iki tane de queue edebiliyorsunuz, o yüzden dört taneden fazla göndermemiz gerekebilir.

Bu davranışın nasıl göründüğünü test edelim.

Bir istek atıyorum, tamam. Bir tane daha, tamam. Bir tane daha, tamam. Ve sonra:  **Service unavailable** . Harika.

Çok hızlı çok fazla istek yaparsam **503 service unavailable** alıyorum.

Bu tam da umduğum şeydi.

---

## 🔁 Ek Testler ve Middleware’lerin Birlikte Çalışması

Biraz daha test edelim.

Birkaç istek daha atalım.

Şimdi counts route’unu tekrar deneyelim. Birkaç kere çağırabiliyoruz.

Şimdi başka bir route’a vurup 503 alabiliyor muyuz? Evet.

Farklı route’lara vurabiliyoruz ve aralarında gidip gelebiliyoruz; ve kullanıcıların hangi hızla gelebileceğini sınırladığımızı görüyoruz.

---

## ⚖️ Daha Makul Ayarlara Geri Dönme

Son olarak, burada daha makul bir ayara dönmek isteyeceksiniz.

Diyelim:

* **100 request**
* **1 dakika** içinde

Yani dakikada 100 oldukça makul.

Bu uygulamayı çok yoğun kullanmayacağız.

Eğer sorun yaşamaya başlarsak, rate limit’leri artırabiliriz.

Ayrıca counts’ları kullanarak insanların hangi route’lara kaç kez erişmeye çalıştığını da görebiliriz.

---

## ✅ Sonuç

Ve bununla birlikte, artık çalışan bir CRUD API’miz var ve iki tane gerçekten faydalı middleware ekledik.

Başka seçenekleri de keşfedebilirsiniz.

Copilot’u kullanın, bununla başka neler yapabileceğinize bakın.

Belki bloglarınıza image ekleme yeteneği implement etmek istersiniz.

Bunun için static file middleware gibi bir şey kullanabilirsiniz.

Ya da Copilot’a başka hangi tür middleware’leri implement etmek isteyebileceğinizi sorabilirsiniz.

Bir sürü seçeneğiniz var ve Copilot, böyle bir uygulama geliştirirken her adımda size yardımcı olabilir.

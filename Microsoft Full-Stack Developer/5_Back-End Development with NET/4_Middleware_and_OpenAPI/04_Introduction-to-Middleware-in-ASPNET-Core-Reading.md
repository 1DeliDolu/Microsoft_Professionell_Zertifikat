## 🧩 Introduction to Middleware in ASP.NET Core

---

## 📌 Introduction

ASP.NET Core’da  *middleware* , HTTP isteklerini yapılandırılmış bir *pipeline* içinde yakalayan ve işleyen bir dizi yazılım bileşenidir. Bu yapı, geliştiricilerin modüler, sürdürülebilir ( *maintainable* ) ve güvenli uygulamalar oluşturmasını sağlar.

Her bir  *middleware component* , statik dosya isteklerini işleme,  *logging* , *authentication* ve *routing* gibi belirli rolleri yerine getirir. Bu katmanlı mimari, istemci istekleri ile sunucu yanıtları arasındaki iletişimi verimli hâle getirerek performansı ve uygulama yönetimini iyileştirir.

---

## 🧠 Concept of Middleware

 *Middleware* , istemci istekleri ile sunucu yanıtları arasında bir köprü görevi görür ve her bileşen, *middleware pipeline* olarak bilinen bir sıralama içinde kendine özgü bir işlev gerçekleştirir.

Bu kurulum, *separation of concerns* yaklaşımını mümkün kılar; yani her  *middleware* , isteği pipeline boyunca iletmeden önce yalnızca belirli bir göreve (örneğin *logging* veya  *authentication* ) odaklanır.

Örneğin, *logging middleware* kullanıcı etkileşimlerini takip ederken, *authentication middleware* kullanıcı kimlik bilgilerini doğrular ve uygulamanın belirli bölümlerine erişimi kontrol eder.

---

## 🧱 The Middleware Pipeline in ASP.NET Core

 *Middleware pipeline* , HTTP isteklerini ve yanıtlarını yapılandırılmış bir sırayla yönetmek için tasarlanmıştır.

Bir istek pipeline’a girdiğinde, ilk olarak başlangıçtaki *middleware component* (örneğin  *logging* ) ile etkileşime girer; ardından *authentication* vb. adımlar takip eder ve en sonunda veriyi alan veya işleyen *application logic* aşamasına ulaşır.

*Application logic* tamamlandıktan sonra pipeline bir *response* üretir ve bunu istemciye geri gönderir.

Bileşenlerin hangi sırada çalıştırıldığı kritik öneme sahiptir; örneğin,  *authentication middleware* ’in  *data retrieval* ’dan önce konumlandırılması, yetkisiz erişimi engeller.

---

## 🧰 Built-in Middleware Components

ASP.NET Core, yaygın görevleri yönetmek için çeşitli yerleşik *middleware* bileşenleri sunar:

* **`UseAuthentication`** : Bu bileşen, güvenli uygulama bölümlerine erişime izin vermeden önce kullanıcı kimlik doğrulamasını kontrol eder ve hassas verilerin korunmasını sağlar.
* **`UseRouting`** : Bu  *middleware* , gelen istekleri istek URL’sine göre uygun  *controller* ’a yönlendirir ve uygulama içi gezinmeyi basitleştirir.

---

## ✅ Conclusion

ASP.NET Core’da  *middleware* , HTTP isteklerini *middleware pipeline* içinde yönetilebilir adımlara bölerek yönetmede temel bir rol oynar. Bu modüler yapı, isteklerin verimli işlenmesini destekler ve uygulama güvenliğini ve sürdürülebilirliğini artırır.

*Middleware pipeline* ile geliştiriciler, istemci-sunucu etkileşimlerini verimli biçimde yöneten, sağlam ve hızlı yanıt veren uygulamalar geliştirebilir.

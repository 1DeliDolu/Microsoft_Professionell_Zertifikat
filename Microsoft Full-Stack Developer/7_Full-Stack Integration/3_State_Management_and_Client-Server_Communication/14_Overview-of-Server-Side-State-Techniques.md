## 🖥️ Sunucu Tarafı Durum Tekniklerine Genel Bakış

Çevrim içi alışveriş yaptığınızda ya da sevdiğiniz bir uygulamayı kullandığınızda, kim olduğunuzu ve ne yaptığınızı hatırlayan akıcı deneyim; sunucu tarafı durum yönetimi sayesinde mümkün olur. Bu teknoloji, sayfalar arasında gezinseniz bile veya bir süre sonra geri dönseniz bile etkileşimlerinizin tutarlı ve kişiselleştirilmiş kalmasını sağlar.

Bu videoda, oturumlar arasında kullanıcı durumunu korumak için kullanılan temel sunucu tarafı durum yönetimi tekniklerini açıklayacağız.

---

## 🧾 Oturum Yönetimi

Yaygın sunucu tarafı durum yönetimi tekniklerini keşfetmeye, oturum yönetimiyle ( *session management* ) başlayalım.

Oturum yönetimi, oturum verisini sunucuda güvenli şekilde saklayarak bir kullanıcının web sitesindeki eylemlerini takip eder. Bir çevrim içi mağazaya giriş yapıp sepetinize ürün eklediğinizde, oturum yönetimi etkinliğinizin benzersiz bir *session ID* aracılığıyla hesabınıza bağlanmasını sağlar.

Bu, farklı sayfalara göz atarken mağazanın sepetinizi bozulmadan korumasına olanak tanır.

Oturum yönetimi olmadan, site içinde gezinirken seçimleriniz kaybolabilir ve bu da sinir bozucu bir deneyime yol açar.

Sunucular, durumu doğru yönetmek için *stateful sessions* kullanır. Bu teknoloji, sunucuların sürekliliği korumak amacıyla kullanıcı etkileşimlerini hatırlamasını sağlar.

---

## 🔁 Stateful Sessions Neyi Farklı Kılar?

 *Stateful sessions* , kullanıcı bilgisini etkileşimler boyunca saklayarak sunucuların bir oturum boyunca sürekliliği korumasını sağlar.

Örneğin, bir sosyal medya uygulamasına giriş yaptığınızda, oturum boyunca hesap ayrıntılarınızı hatırlayarak oturumunuzun açık kalmasını sağlar ve kişiselleştirilmiş bir deneyim sunar.

*Stateful* sistemler etkileşimler arasında hafıza tutarken, *stateless sessions* her isteği bağımsız şekilde yönetir.

---

## 🧊 Stateless Sessions

 *Stateless sessions* , her isteğin önceki etkileşimlere dair hiçbir “hafıza” olmadan bağımsız kabul edildiği sistemlerdir.

Örneğin, çevrim içi hava durumuna baktığınızda sunucunuz isteğinizi işler, ilgili veriyi alır ve size geri gönderir. Ancak yanıt verildikten sonra sizinle ilgili herhangi bir bilgiyi tutmaz.

Bu tür *stateless* etkileşim, hava durumunu kontrol etmek gibi basit isteklerde iyi çalışsa da daha karmaşık etkileşimler, sunucuların birden fazla istek boyunca kullanıcı durumunu yönetmesini gerektirir.

---

## 🧩 Kullanıcı Durumunu Yönetmenin Üç Temel Tekniği

Kullanıcı durumunu yönetmek üç temel teknikle sağlanır.

İlk olarak, sunucular her kullanıcıya benzersiz bir *session ID* atar; bu ID genellikle bir *cookie* içinde saklanır. Bu ID, kullanıcıyı sunucuda saklanan verilerine bağlayan bir referans görevi görür.

Bunu, vestiyerde numaralı bir fiş almak gibi düşünebilirsiniz. Fişin içinde montunuz yoktur, ancak görevlinin onu bulmasına yardım eder.

Benzer şekilde, bir *session ID* sayfalar arasında gezinirken alışveriş sepetinizi bozulmadan tutarak sorunsuz bir deneyim sağlar.

Ek olarak, *session cookies* oturum verisine referanslar saklar; bu sayede sunucu, tarayıcıda doğrudan hassas bilgi açığa çıkarmadan kimliğinizi doğrulayabilir.

Bir  *session cookie* ’yi, “bu kullanıcı 123 numaralı kullanıcı” diyen dijital bir anahtar gibi düşünün.

Sunucu bu anahtarı, oturum açmanızı doğrulamak ve oturumunuzu güvenli biçimde sürdürmek için kullanır; böylece anahtarın kendisi yetkisiz kişilerce değiştirilemez veya okunamaz.

Son olarak, *session cookies* çoğu zaman geçicidir ve tarayıcıyı kapattığınızda silinir; bu yüzden sunucular, daha uzun süre kalıcı olması gereken veriler için oturum bilgisini veritabanlarında saklar.

Örneğin, bir e-ticaret sitesindeki istek listesi ( *wish list* ) veritabanına kaydedilir; böylece oturumu kapatsanız bile kullanılabilir olmaya devam eder.

Bu tür kalıcılık, sorunsuz ve tutarlı bir kullanıcı deneyimi sağlar.

---

## 🚀 Önbellekleme

Sunucu tarafı durum tekniklerinden sonuncusu  *caching* ’dir.

Önbellekleme, sık erişilen verileri geçici olarak saklayarak performansı artırır ve sunucu üzerindeki yükü azaltır.

Örneğin, haber başlıkları önbelleğe alınabilir; böylece sunucu veritabanını tekrar tekrar sorgulamadan onları hızlıca iletebilir.

Bu, sunucu iş yükünü azaltır ve performansı belirgin şekilde iyileştirir.

Bu teknikler birlikte, sorunsuz ve verimli bir uygulama deneyimi sağlar; kullanılabilirliği ve performansı artırır.

---

## ✅ Kapanış

Bu videoda, oturumlar arasında kullanıcı durumunu korumak için kullanılan temel sunucu tarafı durum yönetimi tekniklerini öğrendiniz.

Tüm bu teknikler birlikte çalıştığında, kullanıcıların bağlı kalmasını ve geri gelmesini sağlayan tutarlı deneyimler sunarak sorunsuz, verimli ve sezgisel kullanıcı deneyimleri oluşturabilirsiniz.

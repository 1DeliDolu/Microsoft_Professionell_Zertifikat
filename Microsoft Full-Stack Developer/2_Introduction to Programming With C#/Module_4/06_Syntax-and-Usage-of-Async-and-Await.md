## 🧵 Async ve Await Sözdizimi ve Kullanımı

Bir uygulamayla çalıştığınızı ve aniden veri yüklediği için her şeyin donduğunu hayal edin. Sinir bozucu, değil mi? Günümüzün hızlı dijital dünyasında, bir uygulamanın yetişmesini beklemek sadece can sıkıcı olmaktan daha fazlasıdır. Kullanıcıları uzaklaştırabilecek bir problemdir.

Peki ya uygulamanız, arka planda karmaşık görevleri yürütürken bile sorunsuz çalışabilseydi? C#’ta **async** ve **await** ile asenkron programlama tam olarak bunu yapabilir. Bu videoda, C#’ta **async** ve **await** anahtar sözcüklerinin sözdizimini ve kullanımını açıklamayı öğreneceksiniz.

---

## 🚀 `async` Anahtar Sözcüğü

**async** ile başlayalım; bu, uygulamalarınızı daha hızlı ve daha duyarlı hâle getirmede kilit bir kavramdır. **async** anahtar sözcüğü, bir metodu asenkron yapan bir  *modifier* ’dır. Bu, metodun ana uygulamayı dondurmadan arka planda görevler gerçekleştirebileceği anlamına gelir.

C#’ta  **async** , zaman alan görevleri uygulamanızın ana akışını bozmadan ele alacak ayrı bir çalışan ayarlamak gibidir. Örneğin, bir restoranda olduğunuzu hayal edin. Sipariş verirsiniz; tezgahta beklemek yerine, şef yemeğinizi hazırlarken siz oturursunuz.  **async** ’in yaptığı şey budur.

Kodunuz, arka planda bir görev üzerinde çalışırken başka şeylere devam etmenizi sağlar.

C#’ta **async** anahtar sözcüğünü kullanmak için önce **public** erişim belirleyicisiyle bir metot tanımlarsınız. Ardından, bu metodun asenkron görevleri işleyeceğini belirtmek için **async** anahtar sözcüğünü eklersiniz. Sonra da metodun çıktısını tanımlamak için **Task** dönüş türü ile devam edersiniz.

**async** anahtar sözcüğü derleyiciye bu metodun asenkron iş yapacağını söyler ve metodun arka planda çalışmasına izin verir.

Şimdi,  **async** ’in arka planda görevler çalıştırarak uygulamalarınızı nasıl duyarlı tuttuğuna dair bu genel bakıştan sonra **await** anahtar sözcüğüne geçelim.

---

## ⏳ `await` Anahtar Sözcüğü

 **await** , **async** ile el ele çalışır ve arka plan görevlerinin bir sonraki adıma geçmeden önce ne zaman tamamlanması gerektiğini yönetmenize yardımcı olur.

**await** anahtar sözcüğünü, bir sonraki kod bloğuna geçmeden önce arka plan görevinin tamamlanmasını bekleyerek program akışını kontrol etmek için kullanırsınız.  **await** , beklenen görev tamamlanana kadar metodun yürütülmesini duraklatan bir anahtar sözcüktür.

Bu, uygulamanızın gerekli veri veya işlemlerin tamamlanmasını beklemesini sağlar; ancak yalnızca ihtiyaç duyulan yerde. Böylece uygulamanın geri kalanı sorunsuz biçimde çalışmaya devam eder.

İlk olarak, **await** kullandığınızda **await** içeren metot askıya alınır ve kontrol, çağırdığınız metoda verilir. Ardından, beklenen görev tamamlandığında metot,  **await** ’ten hemen sonraki noktadan yürütülmeye devam eder.

 **await** ’i çalışanlara “Bir dakika, devam etmeden önce şu görevi bitireyim.” diyen bir işaret gibi düşünün. Bu, restoranda yemek yerken yaşanan deneyime benzer.

Yemeğiniz restoranda geldiğinde, sohbet etmeyi duraklatır ve yemeye başlarsınız. Bu bir duraklamadır, ama sadece yemek için yeterince.

Sonraki adımda, **Task** döndüren metodun önüne **await** anahtar sözcüğünü koyarsınız. **GetDataFromApi()** metodunun önünde **await** kullanırsınız. Bu, **GetDataFromApi** görevi tamamlanana kadar mevcut metodun yürütülmesini duraklatır.

**await** anahtar sözcüğü, sonuçları beklerken uygulamanızın diğer işleri ele almasına izin verir; uygulamanız duyarlı kalır.

---

## ✅ Kapanış

Bu videoda, C#’ta **async** ve **await** anahtar sözcüklerinin sözdizimini ve kullanımını açıklamayı öğrendiniz.

Görevleri arka planda çalıştırarak ve yürütmeyi stratejik olarak duraklatarak, uygulamanız karmaşık işlemleri sorunsuz ve verimli biçimde ele alabilir.

## 🧠 Mantıksal Süreçler

Bir yolculuk planladığınızı hayal edin. Güzergâhı, durakları ve her durakta ne kadar kalacağınızı belirlemeniz gerekir. Bu kararlar, programlamanın çalışma biçimine çok benzer şekilde mantıksal bir sıralamayı takip eder. Bu videoda, mantıksal süreçlerin ne olduğunu ve programlamadaki önemini nasıl açıklayacağınızı öğreneceksiniz.

Programlamada mantıksal süreçlerin nasıl çalıştığını tartışmadan önce, mantıksal süreçlerin ne olduğunu inceleyelim. Mantıksal süreçler, programlama dillerindeki kodu oluşturan temel bileşenlerdir. Mantıksal süreçler koddan ayrı değildir; aksine kodun kendi içindeki akışı ve kontrolü tanımlarlar.

Bunlar, programın nasıl çalışması gerektiğine dair yapıyı sağlayan programlamanın yapı taşlarıdır. Bir programın her yönü, tüm programın beklenildiği gibi çalışması için doğru şekilde bir araya getirilmeli ve birlikte çalıştırılmalıdır. Bunu sağlamak için programcıların kullandığı şey mantıksal süreçlerdir.

---

## 🔗 Sıralamalar

İlk inceleyeceğimiz mantıksal süreç *sıralamalar*dır. Programlamada bir sıralama, kodun belirli bir sırayla yürütüldüğü en basit kontrol yapısı biçimidir. Sabah rutininizi düşünün: dişlerinizi fırçalamak, sonra duş almak ve son olarak kahvaltı yapmak gibi bir eylem sıralamanız olabilir. Programlamada sıralamalar, doğru bir sonuç elde etmek için talimatların belirli bir düzende yürütülmesini sağlar.

Bir sıralamanın kodda nasıl çalıştığını göstermek için, *pseudocode* (sözde kod) kullanacağız.  *Pseudocode* , sade bir dille programlama mantığını yazmanın basitleştirilmiş ve resmi olmayan bir yoludur. Sözde kodda bir sıralama şöyle yapılandırılabilir:

```text
Adım 1: Uygulamalar klasörünü aç.
Adım 2: Metin düzenleyiciyi aç.
Adım 3: Yeni bir belge oluştur.
```

---

## 🧭 Kontrol Yapıları

Sıralamalar, programlamadaki tek mantıksal süreç değildir. Programları farklı koşullara duyarlı hâle getirmek için programcılar *kontrol yapıları* adı verilen bir mantıksal süreç kullanır. Kontrol yapıları, belirli koşullara bağlı olarak kod yürütmenin akışını belirleyen ifadelerdir.

Yağmur yağıp yağmadığına göre yürüyüşe çıkıp çıkmamaya karar vermek, gerçek hayatta bir kontrol yapısı örneğidir. Programlamada, *if-else* ifadeleri karar vermek için kullanılır ve programların farklı koşullar altında farklı tepkiler vermesine olanak tanır. Bu nedenle programcılar bunlara *koşullu ifadeler* de der.

Bu ifadeler mantıksaldır; çünkü programın akışını kontrol ederler, koşullar ise program çalışana kadar bilinmeyebilir. Örneğin, bir kullanıcı uygulamadaki bir formu dolduruyor olsun ve yaş alanını boş bıraksın. Kullanıcının yaşını istemeye yönelik bir kontrol yapısı sözde kodda şöyle olurdu: yaş alanı boşsa kullanıcıdan bilgi istenir. Aksi hâlde ya da  *else* , bir sonraki alana geçilir.

Bu durumda kullanıcı yaş alanını boş bıraktığı için mantık, uygulamanın kullanıcıyı uyarması gerektiğini söyler. Kontrol yapıları, kodu belirli bir yola yönlendirmeye yardımcı olur ve bu, bir programda çok fazla mantıksal işi üstlenir.

---

## 🔁 Yinelemeler

Ancak bir geliştiricinin belirli bir kodun tekrar tekrar çalışmasını sağlaması gerekiyorsa, *yineleme (iteration)* adı verilen başka bir mantıksal yapı kullanır. Yinelemeler, *döngüler (loops)* olarak da adlandırılır ve belirli bir koşul karşılanana kadar bir programın bir dizi eylemi tekrar etmesini sağlayan ifadelerdir.

Yeni bir beceri öğrenirken ustalaşana kadar tekrar tekrar pratik yapmanız gerekir. Bu, programlamadaki yinelemelere benzer; döngüler, yinelenen görevleri gerçekleştirmek için aynı kod bloğunu birden çok kez yürütür ve örneğin bir listedeki öğeleri listenin sonuna kadar işlemek gibi, belirli bir koşul sağlanana kadar devam eder.

Örneğin, 10 kaydı olan bir veritabanınız olduğunu ve tüm 10 kaydın soyadı alanındaki veriyi büyük harfe dönüştüren bir program yazmanız gerektiğini varsayın. Sözde kodda, programınızın mantığı şöyle çalışırdı:

```text
1: Bir kayıt yükle.
2: Soyadı alanını büyük harfe çevir.
3: Eğer veritabanındaki son kayıt ise çık, değilse bir sonraki kayda geç.
4: Süreci tekrarla.
```

---

## 🧠 Mantık ve Programlama İlişkisi

Bilgisayarların mantık makineleri olduğunu anlamak önemlidir. Bu nedenle geliştiriciler mantıksal yapılar açısından düşündüklerinde, bilgisayar kodunu nasıl yazmaları gerektiğini daha iyi düşünürler. Mantıksal düşünme ayrıca programcıların kod problemlerini çözmesini ve kodlarını hata ayıklamasını sağlar; çünkü karmaşık problemleri yönetilebilir parçalara ayırma konusunda daha yetkin olurlar.

Şimdi tüm bu fikirleri basit bir örnekle birleştirelim.

---

## ✅ Basit Bir Örnek: Görev Listesi Uygulaması

Bir geliştiricinin basit bir görev listesi uygulaması oluşturmak için ihtiyaç duyacağı mantıksal yapıyı düşünün. Kullanıcıların görev ekleyebilmesi gerekir; bu da adımları belirli bir sıralama içinde işleyen kodla yapılır.

Sonra programcının, kullanıcıların görevleri tamamlandı veya tamamlanmadı olarak işaretleyebilmesini sağlaması gerekir; bu da *if-then* ifadeleri biçimindeki kontrol yapılarıyla yapılır.

Son olarak geliştiricinin, kullanıcı uygulamayı açtığında veya kapattığında tüm görevleri belleğe ya da veri depolamaya kaydetmesi ve yüklemesi gerekir; bu ise bir yineleme kullanılarak gerçekleştirilir. Mantıksal yapılar kullanılarak uygulama görevleri verimli biçimde yönetebilir ve sağlayabilir; bu da sorunsuz bir kullanıcı deneyimi sağlar.

---

## 📌 Özet

Bu videoda, mantıksal süreçlerin ne olduğunu ve programlamadaki önemini nasıl açıklayacağınızı öğrendiniz. Sıralamalar, kontrol yapıları ve yinelemeler gibi mantıksal süreçler, herhangi bir programın yapı taşlarıdır.

Bu yapıları anlamak ve uygulamak, programcıların verimli ve hatasız kod yazmasına yardımcı olur.

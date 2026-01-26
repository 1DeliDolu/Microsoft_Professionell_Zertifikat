## 🧩 Advanced If-Else Statements

Bir geliştirici olarak, kodun birden fazla karar seviyesinde karar vermesini gerektiren zorluklarla karşılaşacaksınız. Örneğin, bir koşul sağlandığında süreç bitmek yerine başka bir koşullar kümesine ve belki ondan sonra bir başka koşullar kümesine daha ilerleyebilir.

Programlamada, bu tür senaryoları yönetmek için *gelişmiş if else ifadelerini* kullanabiliriz. Bu videoda, gelişmiş if else ifadelerini ve programlarda nasıl uygulanacağını öğreneceğiz.

Başlamadan önce, kavramı gözden geçirelim:  *if else ifadesi* . If else ifadeleri, bir koşulun doğru ( *true* ) ya da yanlış ( *false* ) olmasına bağlı olarak farklı kod bloklarını çalıştırarak bir programın akışını kontrol etmemizi sağlar. Karmaşık problemler çoğu zaman basit bir doğru/yanlış kararından fazlasını gerektirir.

---

## 🧠 Gelişmiş If-Else Kullanımları

Bu noktada, *iç içe (nested) if else* ve *zincirleme (chained) if else* gibi gelişmiş kullanım biçimleri gerekli hâle gelir; bu sayede karmaşık karar verme süreçlerini daha yüksek bir doğruluk ve netlikle yönetebiliriz.

Bu yapılar, farklı koşullara bağlı olarak farklı kod bloklarının çalıştırılmasına olanak tanır.

---

## 🧱 İç İçe If-Else Statements

 *İç içe if else ifadeleri* , bir if else ifadesini başka bir if else ifadesinin içine yerleştirerek birden fazla koşulu kontrol etmenizi sağlar. İç içe if else ifadeleri, *bağımlı koşullarınız* olduğunda faydalıdır; yani bir koşulun değerlendirilmesi, başka bir koşulun sonucuna bağlıdır.

İç içe if else ifadeleri şöyle çalışır:

* Birincil bir if else koşuluyla başlayın.
* İlk koşulun içinde, ek bir koşulu kontrol etmek için bir if else ifadesi ekleyin.
* Gerekirse birden fazla if else katmanı ekleyebilirsiniz.

Bu, her dal içinde ek koşulları kontrol ederek daha karmaşık karar verme süreçlerine imkân tanır.

---

## 🛍️ Gerçek Dünya Senaryosu: İndirim Uygulama

İç içe if else ifadesinin kullanımına örnek olarak, bir mağazanın toplam satın alma tutarına ve müşterinin üyelik durumuna göre farklı indirimler uygulamak istemesini ele alabiliriz.

İlk yaptığımız şey, `totalAmount` değişkeninin 100’den büyük olup olmadığını kontrol etmektir. Bu, herhangi bir indirim uygulanıp uygulanmayacağını belirleyen birincil koşuldur.

Eğer toplam tutar 100’den küçükse, üyelik durumundan bağımsız olarak indirim uygulanmaz. Program, if ifadesi sağlanmadığı için, *indirim uygulanmayan* koda gider ve bu nedenle herhangi bir indirim uygulanmaz.

Birincil koşul sağlandığında, müşterinin üye olup olmadığını kontrol eder. Bu, birincil koşulun içindeki iç içe (nested) koşuldur. Burada, `isMember` adlı özel bir program fonksiyonunu kullanarak üyelik durumunu doğrulayan ikincil koşulu ekleriz.

* Müşteri üye ise, program `applyMemberDiscount()` kodunu çağırır ve müşteriye özel bir indirim sağlar.
* Müşteri üye değilse, program `applyRegularDiscount()` metodunu çağırır ve standart bir indirim uygular.

Bu, üyelerin en iyi indirimi almasını sağlarken, üye olmayanların da belirli bir tutarın üzerinde harcama yaptıklarında fayda görmesini sağlar.

---

## 🔗 Zincirleme If-Else Statements

İç içe if else ifadeleri bağımlı koşullarla çalışmak için harikadır; ancak bazen koşulların *bağımsız ve birbirini dışlayan* (mutually exclusive) olduğu durumlar vardır. Bu noktada *zincirleme if else ifadeleri* kullanılır.

Zincirleme if else ifadelerinin nasıl çalıştığını ve neden faydalı olduklarını inceleyelim.

Zincirleme if else ifadeleri, çeşitli koşulları iç içe yerleştirmeden sırayla kontrol etmenizi sağlar. Bu, kodu daha temiz, daha okunabilir ve takip etmesi daha kolay hâle getirir.

Zincirleme if else ifadeleri, birden fazla *birbirini dışlayan* koşulunuz olduğunda idealdir; burada her koşul diğerlerinden bağımsızdır.

Zincirleme if else ifadeleri şöyle çalışır:

* Birincil bir `if` koşuluyla başlayın.
* Ek koşullar için `else if` kullanın.
* Gerektiği kadar `else if` ekleyin.
* Diğer tüm durumları yönetmek için en son bir `else` ile bitirin.

---

## 🚚 Örnek: Konuma Göre Kargo Ücreti Belirleme

Zincirleme if else kullanımını, müşterinin konumuna göre kargo maliyetini belirleme örneğiyle gösterelim.

Önce konumun yerel olup olmadığını doğrularız. Bu koşul doğruysa, `applyLocalShipping()` metodunu çağırarak yerel kargoyu uygularız.

İlk koşul sağlanmadığında, program bir sonraki koşula geçer ve konumun ülke içi (domestic) olup olmadığını kontrol etmek için `else if` kullanır. Eğer öyleyse, açık ve kapalı parantezlerle `applyDomesticShipping()` kodunu çağırarak ülke içi kargoyu uygularız.

Eğer konum ne yerel ne de ülke içi ise, `else` bloğunu çalıştırırız; bu da açık ve kapalı parantezlerle `applyInternationalShipping()` kodunu çağırarak uluslararası kargoyu uygular.

---

## 🍝 Spaghetti Code’dan Kaçınma

İç içe ve zincirleme if else ifadelerini kullanmaya başladığınızda, kodunuzun nasıl yapılandığına dikkat etmelisiniz. Doğru planlama olmadan, bu yapılar geliştiricilerin sıklıkla *spaghetti code* dediği şeye yol açabilir: bakımı zor, karmaşık ve dolaşık bir kod tabanı.

Bunun olmasını önlemek için bazı yolları listeleyelim. Spaghetti code’dan kaçınmak için şu ipuçlarını izleyin:

* Basit tutun.
* Karmaşık koşulları daha basit, daha küçük koşullara bölün.
* Ana kodun okunmasını kolaylaştırmak için koşullu mantığı fonksiyonların içine alarak kapsülleyin.
* Son olarak, her koşulun amacını açıklamak için yorumlar kullanın.

---

## ✅ Video Özeti

Bu videoda, programlamada gelişmiş if else ifadelerinin nasıl uygulanacağını öğrendiniz. İç içe if else ifadelerinin karmaşık koşulları nasıl yönetebildiğini ve zincirleme if else ifadelerinin kodun temiz ve okunabilir kalmasına nasıl yardımcı olabileceğini incelediniz.

En iyi uygulamaları kullanarak, korkulan spaghetti code’u önleyebilir ve programlarınızın okunabilir ve takip etmesi kolay kalmasını sağlayabilirsiniz

## 🧩 Kontrol Yapıları ve Döngülerin Entegre Kullanımı

### 📘 Giriş

Kod yazarken, çoğu zaman karmaşık koşulları tekrar tekrar ele almak gerekir. *If-else* ifadeleri ve *switch* durumları gibi kontrol yapılarının döngülerle birleştirilmesi, bu senaryoları verimli bir şekilde ele alabilir. Bu okuma, gerçek dünyadaki problemleri etkili biçimde çözmek için bu kontrol yapılarını döngülerle entegre etmeyi inceler.

---

## ✅ Döngülerle *If-Else* İfadelerini Kullanma

*If-else* ifadeleri, bir programın belirli koşullara bağlı olarak eylemler arasında seçim yapmasını sağlar. Döngülerle birleştirildiğinde, koşulları tekrar tekrar değerlendirebilir ve uygun eyleme karar verebilirler.

---

## 🧾 Örnek: Kullanıcı Girdisini Doğrulama

Kullanıcının hem **çift** olan hem de **1 ile 10 arasında** bulunan bir sayı girmesinin zorunlu olduğu bir uygulama hayal edin. Burada bir *do-while* döngüsü, geçerli bir sayı sağlanana kadar kullanıcıdan tekrar tekrar girdi ister. Döngünün içinde bir *if-else* ifadesi, girilen sayının her iki koşulu da sağlayıp sağlamadığını kontrol eder:

* Sayı geçerliyse (çift ve 1 ile 10 arasındaysa), bir başarı mesajı görüntülenir ve döngüden çıkılır.
* Sayı geçersizse, bir hata mesajı kullanıcıdan tekrar denemesini ister.

Bu yaklaşım, kullanıcı geçerli bir yanıt verene kadar programın girdi istemesini sağlar; böylece genel güvenilirlik ve kullanıcı deneyimi iyileşir.

---

## 🏫 Örnek: Notlandırma Sistemi

*If-else* ifadelerini döngülerle entegre etmenin bir diğer pratik örneği, bir notlandırma sistemidir. Bir öğrenci notları listemiz olduğunu ve her notun `"Pass"` mı yoksa `"Fail"` mi olduğunu belirlememiz gerektiğini varsayalım. Bir *for* döngüsü notlar listesini dolaşır ve bir *if-else* ifadesi her notu değerlendirir:

* Not 65 veya üzerindeyse, sonuç `"Pass"` olarak işaretlenir.
* Not 65’in altındaysa, sonuç `"Fail"` olarak işaretlenir.

Döngü ve *if-else* yapısı, programın değişken sayıda notu ele almasına ve her birini belirlenmiş kriterlere göre dinamik olarak değerlendirmesine olanak tanır. Bu yöntem, birden fazla koşulun tekrar tekrar değerlendirilmesi gereken büyük veri kümelerini verimli biçimde işler.

---

## 🔀 Döngülerle *Switch* İfadelerini Kullanma

Bir *switch* ifadesi, tek bir değişkenin birden fazla olası değere sahip olduğu durumlarda, birden fazla *if-else* koşuluna alternatif olarak kullanılır. Karmaşık karar verme süreçleri için daha açık ve okunabilir bir yapı sağlar. Döngülerle birleştirildiğinde, bir *switch* ifadesi yinelemeli bir süreç içinde çeşitli durumları verimli bir şekilde ele alabilir.

---

## 🛒 Örnek: E-Ticaret Uygulamasında Sipariş İşleme

Bir e-ticaret uygulamasının `"Pending"`, `"Shipped"`, `"Delivered"` veya `"Canceled"` gibi durumlara göre birden fazla siparişi işlemesi gerektiğini düşünün. Bu durumda bir *for* döngüsü her siparişi tek tek dolaşır ve farklı durumları yönetmek için bir *switch* ifadesi kullanılır:

* Döngü, her siparişin durumunu sırayla alır.
* *Switch* ifadesi durumu kontrol eder ve belirli eylemleri gerçekleştirir. Örneğin:
  * Durum `"Pending"` ise `"Order is pending."` yazdırır.
  * Durum `"Shipped"` ise `"Order has been shipped."` yazdırır.
  * Durum `"Delivered"` ise `"Order has been delivered."` yazdırır.
  * Durum `"Canceled"` ise `"Order has been canceled."` yazdırır.
* Belirtilen durumların hiçbiri eşleşmezse `"Unknown status"` varsayılan mesajı yazdırılır.

Bu yaklaşım, siparişler üzerinde yineleme sürecini karar verme sürecinden ayırır ve kodun anlaşılırlığını ile bakım kolaylığını artırır.

---

## 🎓 Örnek: Öğrenci Notu Değerlendirme

*Switch* ifadeleri, öğrenci notlarını değerlendirip not aralığına göre geri bildirim sağlamak için de kullanılabilir. Örneğin, harf notlarına ayrılması gereken bir öğrenci puanları listesi düşünün:

* Bir *for* döngüsü listedeki her puanı dolaşır.
* *Switch* ifadesi, önceden tanımlanmış aralıklara göre bir harf notu atar:
  * 90 ve üzeri notlar `"A"` alır ve `"Excellent!"` gibi bir geri bildirim verilir.
  * 80 ile 89 arasındaki notlar `"B"` alır ve `"Good job!"` gibi bir geri bildirim verilir.
  * 70 ile 79 arasındaki notlar `"C"` alır ve `"Fair."` gibi bir geri bildirim verilir.
  * 60 ile 69 arasındaki notlar `"D"` alır ve `"Needs improvement."` gibi bir geri bildirim verilir.
  * 60’ın altındaki notlar `"F"` alır ve `"Fail."` gibi bir geri bildirim verilir.

Bir *switch* ifadesini döngüyle birleştirerek program, her puanı verimli biçimde değerlendirir ve uygun geri bildirimi sağlar; böylece kod daha yapılandırılmış ve okunması daha kolay hâle gelir.

---

## ✅ Sonuç

*If-else* ve *switch* ifadeleri gibi kontrol yapılarının döngülerle birleştirilmesi, programlamada karmaşık koşulları yönetmek için güçlü bir tekniktir. Geliştiricilerin yineleme sürecini karar verme sürecinden ayırmasına olanak tanır; bu da daha verimli, daha okunabilir ve bakımı daha kolay kodlara yol açar. Bu tekniklerde ustalaşmak, girdi doğrulama ve sipariş işleme süreçlerinden öğrenci performansını değerlendirmeye kadar geniş bir yelpazedeki gerçek dünya programlama problemlerini çözmek için kritiktir.

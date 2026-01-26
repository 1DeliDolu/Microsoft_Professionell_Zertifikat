## 🧩 Mantıksal Süreçlerin Pratik Uygulamaları

Ön yüz geliştiricilerinin işinin ana odağı uygulama kodu yazmaktır. Ancak, tek bir satır kod yazmadan önce bile geliştiricilerin programın mantıksal akışını tasarlaması gerekir. Bu videoda, mantıksal süreçlerin gerçek dünya programlama senaryolarında nasıl uygulandığını göstereceğiz.

Geliştiricilerin bir programın mantıksal akışını tasarlamasına yardımcı olmak için yaygın olarak kullanılan iki araç *akış şemaları (flowcharts)* ve  *pseudocode* ’dur (sözde kod). Akış şemalarını inceleyerek başlayalım.

---

## 🗺️ Akış Şemaları

Bir  *akış şeması* , bir süreci temsil eden bir diyagramdır. Uygulamanın mantığını göstermek için çeşitli şekiller kullanır ve kullanıcıların yazılım içinde izleyebileceği yolları göstermek için oklarla yönlendirme yapar.

Akış şemaları, kod yazmadan önce mantığı planlamaya yardımcı olur; karmaşık süreçleri anlamayı ve iletmeyi kolaylaştırır. Geliştiriciler, uygulamalarının mantığını haritalamak için sıkça akış şemaları kullanır. Örneğin bir geliştirici, bir giriş ( *login* ) sisteminde kullanıcının izleyebileceği adımları bir akış şeması ile temsil edebilir.

Örneğin, bir e-ticaret ödeme ( *checkout* ) süreci geliştirdiğimizi varsayalım. Akış şeması şu adımları içerir:

1: Ürünleri seçme.
2: Sepete ekleme.
3: Gönderim bilgilerini girme.
4: Ödeme yöntemi seçme.
5: Siparişi onaylama.

Bir müşteri ödeme yöntemini seçtiğinde, birden fazla yol izleyebilir. Akış şeması, tüm bu seçeneklerin haritalandığından emin olur.

Bu akış şemasını oluşturmak için geliştirici, her adımı temsil eden şekiller oluşturmak amacıyla *Visio* veya *Miro* gibi bir araç kullanabilir. Şekiller, akıştaki belirli olay türlerini temsil eder. Geliştirici, e-ticaret ödeme sürecini başlangıç noktasıyla tasarlamaya, içinde `"Start"` yazan oval bir şekil kullanarak başlar.

Oval şekil, sürecin başlangıcını net biçimde işaretler ve akış şemasını okuyan herkese müşterinin yolculuğunun burada başladığını gösterir.

Sonra geliştirici, `"Select Products"` (Ürünleri Seç) yazısını içeren dikdörtgen bir şekille temsil edilen ürün seçimi adımını oluşturur. Dikdörtgen, bir süreç veya eylem adımını gösterir. Burada müşteri ürün kataloğunu inceler ve satın almak istediği ürünleri seçer. Geliştirici, ürün seçimi eylemini yakalamak için bu dikdörtgen şekli kullanır.

Başlangıç ovalinden ürün seçimi dikdörtgenine giden bir ok, sürecin akış yönünü gösterir.

Ürün seçiminden sonra geliştirici, `"Add to Cart"` (Sepete Ekle) yazısını içeren bir dikdörtgen ile sepete ekleme adımını tasarlar. Geliştirici, müşterinin seçtiği ürünleri alışveriş sepetine — ödeme adımına geçmeden önce geçici bir bekletme alanına — koyduğu basit süreç eylemini belirtmek için yine dikdörtgeni seçer. Geliştirici, ürün seçimi adımından sepete ekleme adımına işaret eden bir ok ekler.

Ardından geliştirici, bu kez `"View Cart"` (Sepeti Görüntüle) yazısını içeren başka bir dikdörtgen kullanarak sepeti görüntüleme adımına geçer. Bu şekil, müşterinin sepetindeki ürünleri gözden geçirdiği, miktarları kontrol ettiği ve bir sonraki adıma geçmeden önce gerekli ayarlamaları yaptığı düzenli bir süreç adımını temsil eder. `"Add to Cart"` şekline işaret eden bir ok, `"View Cart"` şekline yönlendirilir.

Müşteri sepetten memnun olduğunda, geliştirici `"Proceed to Checkout"` (Ödemeye Geç) yazısını içeren bir dikdörtgen ile ödemeye geç adımını kurar. Bu şekil, alışveriş aşamasından satın alma aşamasına geçiş eylemini ifade eder. Geliştirici `"View Cart"` şekilden `"Proceed to Checkout"` şekline işaret eden bir ok ekler.

Sonra geliştirici, `"Shipping Details"` (Gönderim Bilgileri) yazısını içeren başka bir dikdörtgenle gönderim bilgilerini girme adımını tasarlar. Dikdörtgen, doğru teslimatı sağlamak için müşterinin gönderim bilgilerini girdiği bir süreç adımı olduğunu gösterir. Ok, `"Proceed to Checkout"` şekilden `"Shipping Details"` şekline yönelir.

Bu noktada geliştirici bir karar noktası ekler: `"Select Payment Method"` (Ödeme Yöntemi Seç). Geliştirici, burada içinde `"Select Payment Method"` yazan bir elmas şekli kullanır; çünkü bu, birden çok yola açılan bir kararı temsil eder. Bu şekil, onu süreç adımlarından görsel olarak ayırır ve müşterinin kredi kartı veya PayPal gibi çeşitli ödeme seçeneklerinden birini seçmesi gerektiğini ifade eder. Ok, `"Shipping Details"` şekilden `"Select Payment Method"` şekline yönelir.

Bu noktada geliştirici, her olası yöntemi göstermek için oklar ve şekiller ekleyerek farklı ödeme yöntemlerini görselleştirebilir.

Bir ödeme yöntemi seçildikten sonra geliştirici, `"Confirm Order"` (Siparişi Onayla) yazısını içeren bir dikdörtgen kullanarak siparişi onaylama adımını ekler. Bu şekil, müşterinin işlemi tamamlamadan önce her şeyin doğru olduğundan emin olmak için sipariş detaylarını gözden geçirip onayladığı son eylem adımını temsil eder. Ok, `"Select Payment Method"` şekilden `"Confirm Order"` şekline yönelir.

Son olarak geliştirici, içinde `"End"` yazan oval şekli kullanarak süreci bitirir. Oval, ödeme sürecinin tamamlandığını işaret eder; müşterinin yolculuğunun sona ulaştığını ve siparişin başarıyla verildiğini açıkça gösterir. Son ok, `"Confirm Order"` şekilden `"End"` şekline yönelir.

Bu basit akış şeması, bir kullanıcının ödeme akışı boyunca nasıl ilerleyeceğini görsel olarak gösterir ve aynı zamanda uygulamanın desteklemesi gereken olayların mantıksal sırasını ortaya koyar. Okların yönleri, kodda mantıksal operatörler olarak çevrilebilir ve akış şeması geliştiricinin bu mantıksal akışı anlamasına yardımcı olur.

Akış şemalarının program mantığını görselleştirmeye nasıl yardımcı olduğunu gördüğümüze göre, başka bir temel aracı inceleyelim:  *pseudocode* .

---

## 🧾 Pseudocode

 *Pseudocode* , bir kod parçasının ne yapması gerektiğini açıklayarak bu mantıksal süreci daha da rafine eder. Pseudocode, bir bilgisayar programının veya algoritmanın ne yapması gerektiğinin, bir programlama dili yerine doğal bir dille ifade edilen ayrıntılı ve okunabilir bir açıklamasıdır. Bu, başlangıçtaki konsept ile gerçek kod arasında bir köprü kurmaya yardımcı olur.

Örneğin geliştirici, e-ticaret uygulamasını tasarlamaya program mantığını bir akış şemasıyla göstererek başlar. Ardından, yüksek seviyeli tasarımı alır ve gerçek kodun ne yapması gerektiğini daha iyi anlayabilmek için sürecin her adımını pseudocode’a çevirmeye başlar.

Sepete ürün ekleme adımını kullanarak bir pseudocode örneğini inceleyelim. Kod, müşterinin bir ürün seçmesini desteklemelidir. Pseudocode şu şekilde başlar:

```text
Adım 1: Fonksiyonu başlat: AddToCart(productID, quantity)
Adım 2: productID kullanarak veritabanından ürün detaylarını al.
Adım 3: Eğer ürün istenen miktarda mevcutsa:
        Seçenek A: Ürünü ve miktarı sepete ekle.
        Seçenek B: Envanteri güncelle.
Adım 4: Sepete eklemeyi onayla.
Adım 5: Eğer ürün istenen miktarda mevcut değilse kullanıcıya bir hata mesajı göster.
Adım 6: Fonksiyonu bitir.
```

Bu pseudocode, adımları ve koşulları net ve öz biçimde ortaya koyar ve gerçek koda çevrilmeye hazırdır.

---

## 📌 Özet

Bu videoda, mantıksal süreçlerin gerçek dünya programlama senaryolarında nasıl uygulandığını öğrendiniz. Mantıksal süreçleri anlamak ve uygulamak, her yazılım geliştiricisi için kritik becerilerdir. Akış şemaları ve pseudocode gibi araçları kullanarak geliştiriciler, gerçek kodlama sürecine başlamadan önce program yapılarını etkili biçimde haritalayabilir ve planlayabilir.

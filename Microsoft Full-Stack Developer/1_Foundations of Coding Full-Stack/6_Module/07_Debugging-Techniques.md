## 🛠️ Hata Ayıklama Teknikleri

Bir uygulama için yeni bir özellik üzerinde çalışan bir geliştirici olduğunuzu hayal edin. Yüzlerce satır kod yazdınız, ancak çalıştırdığınızda bir şeylerin yanlış olduğunu görüyorsunuz. Uygulama çöküyor ya da sonuçlar beklediğiniz gibi değil.

Bütün kodu baştan yazmazsınız veya “olur belki” diye ummazsınız. Bunun yerine sistematik olarak hata ayıklarsınız; kodu adım adım tarayarak işlerin tam olarak nerede ters gittiğini bulursunuz.

Bu videoda, kodunuzdaki mantık hatalarını tespit etmek için çeşitli hata ayıklama tekniklerini uygulayacağız. Debugging, bir bilgisayar programındaki hataları veya bug’ları tanımlama ve çözme sürecidir.

Debugging, her geliştirici için temel bir beceridir. Geliştiriciler, kodun beklenildiği gibi davranmadığı yeri bulmalı ve tüm programın sorunsuz çalışması için düzeltmelidir.

Kodunuzu hata ayıklamanın, her birinin kendi güçlü yönleri olan birkaç yolu vardır. Mantık hatalarını yakalamak ve düzeltmek için  *watch’lar* ,  *logging* , *print statement’lar* ve *breakpoint’ler* gibi teknikleri kullanabilirsiniz.

---

## 👀 Watch’lar ile Değişkenleri Gerçek Zamanlı İzleme

Değişkenleri gerçek zamanlı izlemeye yarayan bir araç olarak  *watch* ’ları keşfederek başlayalım.

Watch, kodunuz çalışırken belirli değişkenlerin değerini takip etmenize yardımcı olan bir özelliktir. Bu özellik,  *debugger* ’lar veya *integrated development environment* gibi yazılım geliştirme araçlarına entegredir.

*Integrated development environment* ya da  *IDE* , kod yazmayı, derlemeyi ve hata ayıklamayı tek bir yerde birleştirerek geliştirme sürecini kolaylaştıran bir araçtır.

Bir değişkene watch koyduğunuzda, o değişkenin mevcut değerini ve program çalışırken bu değerin adım adım nasıl değiştiğini görebilirsiniz.

Örneğin uygulamanız bir alışveriş sepetinin toplamını hesaplıyor olsun. IDE’nizi kullanarak `totalPrice` değişkenini izleyebilirsiniz. Test sırasında, belirli bir ürünü eklediğinizde bu değerin aniden sıfıra düştüğünü fark edersiniz. Bu, o ürün için fiyatların eklenme biçiminde bir hata olduğu anlamına gelebilir; örneğin eksik bir değer veya yanlış bir format.

Bir watch ayarlamak, belirli bir değişkende ne zaman bir şeylerin ters gittiğini bulmaya yardımcı olurken, *logging* programınızın nasıl davrandığına dair daha geniş bir perspektif sağlar.

---

## 🧾 Logging ile Çalışma Zamanı Davranışını Kaydetme

Logging, programınız çalışırken neler olduğuna dair gerçek zamanlı verileri kaydeder. Takip etmek istediğiniz bilgilerin bulunduğu kritik noktalara kodunuza log ifadeleri ekleyebilirsiniz.

Program çalıştığında, ayrıntılar dosyalarda veya veritabanlarında saklanır. Kodunuza log ifadelerini stratejik olarak yerleştirerek, kodunuzun çalışma zamanında nasıl davrandığına dair içgörü elde edebilirsiniz; bu, özellikle karmaşık sistemlerde hataları izlerken faydalıdır.

Örneğin toplam sipariş ağırlığına göre kargo maliyeti hesaplayan bir fonksiyonu debug ettiğinizi hayal edin. Her ürünün ağırlığını izlemek için logging kullanırsınız. Log, belirli bir ürün işlendiğinde ağırlıkta beklenmeyen bir sıçrama olduğunu gösterir; bu da ağırlığın kilogram yerine gram olarak kaydedildiğini ortaya çıkarır.

Bu, birim dönüşüm hatasını hızlıca bulmanıza ve düzeltmenize yardımcı olur.

Log’lar saklanabilir, dosyalara yönlendirilebilir ve zaman içinde analiz edilerek ayrıntılı bir kayıt sağlayabilir; ancak geliştirme sırasında hızlı bir kontrol için  *print statement* ’lar daha anlık ve doğrudan bir yaklaşım sunar.

---

## 🖨️ Print Statement’lar ile Hızlı Gözlem

Print statement, metin veya veriyi bir konsol ya da terminal penceresine yazdıran bir komuttur. Print statement’ları, değişkenlerin değerini veya yürütme akışını doğrudan konsola yazdırmak için kullanırsınız.

Print statement’lar, kodunuzun mantığını izlemeye yardımcı olur; ana noktalarda mesajlar göstererek akışı takip edebilirsiniz.

Örneğin müşteri satın alma geçmişine göre indirim hesaplayan bir fonksiyonu debug ettiğinizi hayal edin. İndirim yüzdesini göstermek için bir print statement ekleyebilirsiniz.

Çıktı, indirimin her zaman sıfır olduğunu gösterir; bu da indirimi hesaplayan koşulun hiçbir zaman sağlanmadığını ortaya çıkarır. Bu, indirim hesaplamasındaki hatalı mantığı bulmanıza ve düzeltmenize yardımcı olur.

Print statement’lar hızlı içgörü sağlar; ancak daha ayrıntılı inceleme gerektiğinde breakpoint’ler sorunları daha hassas şekilde izole etmek için güçlü bir araçtır.

---

## 🧷 Breakpoint’ler ile Kodun Durup İncelenmesi

Breakpoint’ler, programın durumunu ayrıntılı olarak incelemek için kodunuzu belirli satırlarda duraklatmanıza izin verir. Onları kodunuz içindeki bir kontrol noktası gibi düşünün.

IDE’de breakpoint belirleyebilir ve kodu debug modunda çalıştırabilirsiniz. Programınız breakpoint olan satıra geldiğinde çalışmayı durdurur.

Bu noktada değişkenleri inceleyebilir, kodu satır satır ilerletebilir ve işlerin tam olarak nerede ters gittiğini görebilirsiniz.

Bu yöntem, hemen görünmeyen karmaşık bug’ları izole etmek için oldukça etkilidir.

Örneğin kullanıcı verilerini dolaşarak toplam harcamayı hesaplayan bir fonksiyonu debug ettiğinizi hayal edin. Döngünün başına bir breakpoint koyarsınız. Adım adım ilerlerken, bir koşul yanlışlıkla sağlandığı için döngünün erken çıktığını fark edersiniz.

---

## 🧰 Teknikleri Birlikte Kullanma

Bu teknikleri birlikte kullanmak, iyi donanımlı bir araç çantası gibidir. Birleştirmek, hataların kaynağına kadar iz sürmenize yardımcı olabilir.

Örneğin, genel bir görünüm elde etmek için logging ile başlayabilir, problemi daraltmak için print statement kullanabilir ve sonra daha ayrıntılı inceleme için breakpoint’ler ayarlayabilirsiniz.

Her araç, size değerli bilgiler sağlar ve parçaları bir araya getirerek bulmacayı tamamlamanıza yardım eder.

Bu tekniklerin gerçek dünyada birlikte nasıl kullanılabileceğini inceleyelim. Alışveriş sepetindeki ürünlerin toplam fiyatını hesaplayan bir fonksiyon üzerinde çalıştığınızı düşünün, ancak doğru toplamı döndürmüyor.

Toplam fiyatı takip eden değişkende bir watch ayarlarsınız. Fonksiyonun çağrılıp çağrılmadığını kontrol etmek için bir print statement eklersiniz, eklenen değerleri log’lar ve nihai hesaplama satırına bir breakpoint koyarsınız.

Birdenbire, yanlış toplamın küçük bir yuvarlama hatasından kaynaklandığını bulursunuz.

İşte bu teknikler, bug’ları bulup düzeltmenize böyle birlikte yardımcı olur.

---

## ✅ Kapanış

Debugging sadece hataları düzeltmek değildir — kodunuzun adım adım nasıl çalıştığını anlamak ve problem çözme yeteneğinize güven inşa etmektir.

Bu videoda,  *watch’lar* ,  *logging* , *print statement’lar* ve *breakpoint’ler* dahil olmak üzere çeşitli hata ayıklama tekniklerini nasıl uygulayacağınızı öğrendiniz; bu teknikler, kodunuzdaki mantık hatalarını tanımlamanıza ve izini sürmenize yardımcı olur.

Debugging, her programcının ustalaşması gereken hayati bir beceridir. Debugging tekniklerini uygulayarak mantık hatalarını verimli şekilde tespit edip çözebilir, daha temiz ve daha güvenilir kod elde edebilirsiniz.

## 🧩 Çok Biçimlilik

Modern mesajlaşma uygulamaları, dosyaları işleme konusunda önceki sürümlere kıyasla daha gelişmiştir. Örneğin bir video dosyası paylaştığınızda, mesajlaşma uygulamanız arkadaşınızın ya da iş arkadaşınızın videoyu deneyimleyebilmesi için otomatik olarak bir *play* düğmesi sağlayabilir.

Fotoğraf yüklediğinizde ise, tüm görseller arasında kaydırma yapmalarına olanak tanıyan flipbook tarzı bir arayüz görebilirler. Uygulama dosyalar için tek bir arayüz kullanır, ancak yüklediğiniz dosyanın türüne bağlı olarak farklı eylemler gerçekleştirecek şekilde uyum sağlar.

Nesne yönelimli programlama da kodla çalışmak için benzer bir kavram sunar.  *Çok biçimlilik (polymorphism)* , geliştiricilerin üzerinde işlem yaptıkları nesneye bağlı olarak farklı görevler gerçekleştiren tek bir metot oluşturmasını sağlar.

Bu videoda, nesne yönelimli programlamada çok biçimlilik kavramını nasıl açıklayacağınızı öğreneceksiniz.

---

## 🧠 Çok Biçimliliğin Tanımı

Çok biçimlilik, geliştiricilerin tek bir metot adını kullanarak, üzerinde işlem yaptığı nesnenin türüne bağlı olarak farklı görevler gerçekleştirmesini sağlar.

Bu, bir metodun kendisinden ne istendiğine bağlı olarak farklı davranabileceği anlamına gelir.

---

## 🧬 Türetilmiş Sınıf ve Metot Davranışı

İşte bir nesneyle çok biçimliliği kullanmaya bir örnek. Geliştiriciler önce bir taban sınıfı ( *base class* ) genişleterek bir türetilmiş sınıf ( *derived class* ) oluşturur.

Kalıtım yoluyla, türetilmiş sınıf taban sınıfın metotlarına ve özniteliklerine ( *attributes* ) sahip olur. Bu noktada, taban sınıftaki metotların uygulamasını kullanabilir veya bir ya da daha fazla metodu geçersiz kılarak ( *override* ) bunların kendi sürümünü uygulayabilirler.

Ayrıca, taban sınıfın işlevselliğini genişletmek için metotlar ve öznitelikler ekleyebilirler.

---

## ☕ Gerçek Dünya Örneği: CoffeeMaker

Bunu gerçek dünyadan bir örnekle daha ayrıntılı inceleyelim.

Bir geliştiricinin *coffeeMaker* adında bir taban sınıf oluşturduğunu ve bu sınıfta *water* ve *beans* adlı metotlar bulunduğunu varsayalım.

İlk olarak *water* metodunu uygular; böylece coffee maker nesnesi suyu bir tankta tutabilir. Ayrıca *beans* metodunu uygular; böylece coffee maker öğütülmüş kahveyi ( *grounds* ) kabul eder.

Geliştirici daha sonra, *coffeeMaker* taban sınıfını genişleten *drip* ve *super automatic* adlı iki türetilmiş sınıf oluşturur.

---

## 🫗 Drip Türetilmiş Sınıfı

İlk türetilmiş sınıf *drip* sınıfıdır. *Drip* türetilmiş sınıfı, taban sınıftaki metotları aynen oldukları gibi kullanır; ancak kahvenin demlendikten sonra nerede saklandığını tanımlayan *vessel* adlı ek bir metot ekler.

---

## 🤖 Superautomatic Türetilmiş Sınıfı

İkinci türetilmiş sınıf *superautomatic* türetilmiş sınıfıdır. *Superautomatic* türetilmiş sınıfı *water* ve *beans* metotlarını miras alır.

Bu türetilmiş sınıf, *water* metodunu taban sınıfta olduğu gibi aynen kullanır; çünkü bu kahve makinesinin sürümü de suyu tutmak için bir tanka sahiptir.

Ancak *superautomatic* ayrıca çekirdekleri öğütebildiği için, geliştirici bu işlevi eklemek amacıyla *beans* metodunu geçersiz kılar ( *override* ).

---

## 🧩 Metot Geçersiz Kılma

Sonraki adımda, türetilmiş sınıflarda metotların geçersiz kılınması ( *overriding* ), geliştiricilerin bir türetilmiş sınıfta yalnızca ihtiyaç duydukları şeyi değiştirmesine ve taban sınıfın diğer işlevselliğini değişiklik yapmadan kullanmasına olanak tanır.

Şimdi metot geçersiz kılmayı daha ayrıntılı inceleyelim.

---

## 🛠️ Overriding Nedir?

 *Overriding* , nesne yönelimli programlamada, türetilmiş bir sınıfın, taban sınıfında zaten tanımlanmış olan bir metodun kendi uygulamasını sağlaması tekniğidir.

Bu teknik, geliştiricilerin bir metodun kendi sürümünü tanımlayan daha spesifik nesne türleri oluşturmasına olanak tanır.

Bir metodu geçersiz kılarak, geliştirici taban sınıftan miras alınan metotların davranışını iyileştiren ( *refine* ) veya tamamen değiştiren türetilmiş sınıflar tasarlayabilir.

Overriding, geliştiricilere; mevcut kod nesnelerini ve özelliklerini kullanırken, belirli bağlamlarına uygun türetilmiş sınıf metotları tasarlama yeteneği verir.

Bu, kod yeniden kullanımını teşvik eder; ancak esneklik pahasına değil.

---

## ✅ Sonuç

Bu videoda, nesne yönelimli programlamada çok biçimlilik kavramını nasıl açıklayacağınızı öğrendiniz.

Çok biçimlilik, geliştiricilere; üzerinde işlem yaptıkları nesneye bağlı olarak farklı görevler gerçekleştirmek üzere türetilmiş sınıflarda metotları değiştirme veya genişletme konusunda güçlü bir yetenek kazandırır.

Bir metodun geçersiz kılınması, türetilmiş sınıfların bir metodun ne yapabileceğine dair kendi sürümlerini sağlamasına imkân verir.

Bu nesne yönelimli programlama kavramları, geliştiricilerin esnek ve yeniden kullanılabilir kod yazmasına yardımcı olur.

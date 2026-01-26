## 🧼 Kod İncelemesi ve İyileştirme

Temiz, verimli ve sürdürülebilir kod, programlarınızın sorunsuz çalışmasını sağlar ve hata ayıklamayı, genişletmeyi ve başkalarıyla iş birliği yapmayı kolaylaştırır. En iyi uygulamalara bağlı kalarak geliştiriciler, zamanın testine dayanan, yeni gereksinimlere uyum sağlayan ve hataları en aza indiren kod üretebilir.

Bu videoda, en iyi uygulamalar ve akran geri bildirimi temel alınarak kodu inceleyecek ve iyileştireceğiz. Bu kavramları C# ile örnek bir proje üzerinden göstereceğim. Yaygın tuzakları, kodlama en iyi uygulamalarını ve akran geri bildiriminin kodunuzu nasıl geliştirebileceğini ele alacağız. Hadi başlayalım.

---

## 🎓 Geçti/Kaldı Belirleyen Temel Kodun İncelenmesi

Öncelikle bir öğrencinin test puanına göre geçip geçmediğini belirleyen bazı temel kodları inceleyerek başlayacağız.

Şu anda elimizdeki kod şöyle. İlk olarak, `s` adında bir tamsayı alan `CalculatePassFail` isimli public bir metot tanımlıyoruz. Fonksiyon, puanı kontrol etmek için bir `if-else` ifadesi kullanır ve not `60`’tan büyük veya eşitse konsola `Pass` yazdırır. Aksi halde konsola `Fail` yazdırır.

Bu kod doğru gibi görünebilir; ancak geliştiricilerin kaçınması gereken birkaç yaygın kodlama tuzağı vardır.

---

## ⚠️ Yaygın Kodlama Tuzakları

### 🏷️ Belirsiz Metot veya Değişken İsimleri

Burada `s` adında bir değişkenimiz olduğuna dikkat edin. C# için, değişkenlerde açıklayıcı isimler kullanmak ve *camelCase* gibi belirli adlandırma kurallarına uymak gibi naming convention’lar vardır.

İlk bakışta `"s"`’nin neyi temsil ettiği net değildir. Bu netlik eksikliği, kodu anlamayı zorlaştırabilir.

### 🧱 Çok Fazla İş Yapan Uzun Fonksiyonlar

Bir diğer tuzak, çok fazla iş yapan uzun fonksiyonlar oluşturmaktır. Programlamada buna *single responsibility principle* denir. Bu ilke, bir bileşenin yalnızca tek bir belirli görevten veya işlevden sorumlu olması gerektiğini söyler.

Örneğimizde `CalculatePassFail` metodu yalnızca puanın geçme mi kalma mı olduğunu belirlemekle kalmaz, aynı zamanda sonucu doğrudan konsola yazdırır.

Bu, fonksiyonun iki sorumluluğu olduğu anlamına gelir: sonucu hesaplamak ve çıktıyı yönetmek.

Bu neden iyi değil? Çünkü fonksiyonu bakım açısından daha zor hâle getirir. Sonucun nasıl gösterildiğini değiştirmek isterseniz, örneğin konsola yazdırmak yerine bir dosyaya yazmak isterseniz, yalnızca geçme/kalma belirleme işiyle ilgilenmesi gereken bu fonksiyonu değiştirmeniz gerekir.

### 📝 Açık ve Doğru Yorumların Olmaması

Son olarak üçüncü tuzak, kodunuzu doğru şekilde açıklayan net yorumların olmamasıdır. Yorumlar olmadan, özellikle başka biri için veya birkaç ay sonra sizin için bile, kodun amacını anlamak zordur.

Şimdi bu tuzakları en iyi uygulamalarla düzeltelim.

---

## ✅ En İyi Uygulamalarla İyileştirme

En iyi uygulamalar, temiz, verimli ve sürdürülebilir kod yazmanıza yardımcı olur.

### 🧠 Anlamlı İsimler Kullanın

İlk olarak anlamlı isimler kullanalım. `"s"` değişkenini `student score` olarak değiştireceğim. Bu şekilde değişkenin neyi temsil ettiği anında anlaşılır ve kodu okuyan herkes için daha kolay hâle gelir.

### 🎯 Fonksiyonları Kısa ve Odaklı Tutun

Sonra, fonksiyonları kısa ve odaklı tutma uygulamasını uygulayın. `CalculatePassFail` metodunu iki küçük, daha odaklı fonksiyona böleceğim.

Önce `CalculatePassFail` metodunu değiştirerek yalnızca puanın geçme mi kalma mı olduğunu belirlemesini sağlayacağım.

`If Else` ifadesini şöyle değiştiriyorum: öğrenci `60`’tan büyük veya eşit puan alırsa `"Pass"` döndürecek, aksi halde `"Fail"` döndürecek.

Ardından yazdırma mantığını `PrintPassFail` adında, `student score` isimli bir tamsayı alan ayrı bir metoda taşıyacağım.

Metodun sonucunu bir `string` olarak alacağım ve sonra çıktıyı konsola yazacağım.

Artık kodumuz en iyi uygulamalara uyuyor. `CalculatePassFail` sonucu belirlemeye odaklanırken `PrintPassFail` gösterimi oluşturur. Bu, ileride kodun bölümlerini değiştirmeyi, hata ayıklamayı veya yeniden kullanmayı kolaylaştırır.

### 🗒️ Net Yorumlar Ekleyin

Son olarak, koda net yorumlar eklemek de bir en iyi uygulamadır.

Burada `CalculatePassFail` metodunun ne yaptığını açıklayan bir yorum ekliyorum: öğrencinin `60` veya daha yüksek puan alıp almadığını kontrol et ve `"Pass"` veya `"Fail"` döndür.

`PrintPassFail` metoduna da ne yaptığını açıklayan yorumlar ekleyeceğim.

Açık parantezin hemen içine şu yorumu ekleyeceğim: `CalculatePassFail` çağırarak öğrencinin geçip geçmediğini belirle.

`Console.Write` satırından önce ise şunu ekleyeceğim:

`// Print the pass/fail result to the console`

Yorumların, bilgisayara bunların çalıştırılacak kod olmadığını belirtmek için çift eğik çizgiyle başladığına dikkat edin.

Bu en iyi uygulamaları izleyerek, kodumuz artık daha açık ve daha okunabilir. Hata ayıklaması, bakımı ve anlaşılması daha kolay; ister biz ister gelecekte başka biri tarafından olsun.

---

## 🤝 Akran Geri Bildirimi

Şimdi akran geri bildirimini konuşalım. Başkalarının kodunuzu incelemesi öğrenmek ve iyileştirmeler yapmak için harika bir yoldur.

Burada, bir öğrencinin test puanlarına göre harf notunu hesaplayan bazı kodlara dikkat edin. Kod, `studentScore` adında bir tamsayı alan `CalculateGrade` isimli bir fonksiyon içerir.

Fonksiyon, puanı kontrol etmek ve `A`, `B`, `C`, `D` veya `F` notunu döndürmek için bir `if-else` ifadesi kullanır.

Kod GitHub’da akran incelemesinden geçirilmiş ve incelemem gereken bazı yorumlar var. Yorumlardan biri, daha iyi okunabilirlik ve daha kolay bakım için birden fazla `if-else` ifadesi yerine `switch` ifadesi kullanmayı öneriyor.

---

## 🔄 Geri Bildirimi Koda Dahil Etme

Bu geri bildirimi kodumuza dahil edelim.

`if-else` zincirini `switch` ifadesiyle değiştirmekle başlayacağım.

Önce `return` anahtar sözcüğünü satırın başına, ardından `studentScore` değişken adını getireceğim.

Sonra `switch` ifadesini `switch` yazarak çağıracağım ve `switch` case’lerini tanımlamak için yeni bir süslü parantez seti açacağım.

Parantezlerin içinde, `90` veya daha büyük puanlarla başlayarak her koşulu belirtirim; ok sembolünü kullanarak — yani eşittir işareti ve büyüktür işaretinin birlikte olduğu — `A` harfine ve tek tırnaklara yönlendiririm.

Aynı kalıbı diğer aralıklar için tekrarlarım: `80` veya daha büyük `B`’ye işaret eder, `70` veya daha büyük `C`’ye işaret eder ve `60` veya daha büyük `D`’ye işaret eder.

Son olarak, bu koşullara uymayan tüm puanları ele almak için tüm diğer durumları temsil eden bir alt çizgi kullanır ve onu `f`’ye yönlendiririm.

Bir `switch` ifadesi kullanarak kod daha okunabilir ve anlaşılması daha kolay hâle gelir. Her koşul açıkça belirtilmiştir; bu da orijinal `if-else` zincirine kıyasla takip etmeyi daha basit yapar.

---

## ✅ Kapanış

İşte bu kadar. Bazı yaygın tuzaklara en iyi uygulamaları uygulayarak ve akran geri bildirimini dahil ederek kodumu geliştirdim.

İyi kod yazmak sadece çalıştırmakla ilgili değildir. Onu anlaşılır, sürdürülebilir ve verimli hâle getirmekle ilgilidir.

Bu videoda, en iyi uygulamalar ve akran geri bildirimi temel alınarak kodu inceledik ve iyileştirdik. Bu yaklaşımlar, kodunuzu daha açık, bakımını daha kolay ve gelecekteki değişikliklere daha uyarlanabilir hâle getirmenize yardımcı olur.

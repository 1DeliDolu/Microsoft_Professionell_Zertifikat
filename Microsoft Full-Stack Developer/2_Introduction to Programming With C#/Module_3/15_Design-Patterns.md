## 🧩 Tasarım Desenleri

Yazılım geliştirme evrildikçe, mühendisler programları verimli, bakımı daha kolay ve ölçeklenebilir şekilde nasıl inşa edeceklerini öğrenmeye devam ediyor. Bu tür yazılımlar oluşturmaya katkı sağlayan yaygın çözümlere *tasarım desenleri (design patterns)* denir.

Yazılım mühendisleri, tüm geliştiricilerin takip etmesi gereken bir desenler seti oluşturmuştur. Bu videoda, nesne yönelimli programlamada tasarım desenlerinin önemini nasıl açıklayacağınızı öğreneceksiniz.

Tasarım desenleri, yazılım tasarımındaki mimari zorluklara standart bir yaklaşım sunan, yaygın problemlere yönelik yeniden kullanılabilir çözümlerdir. Uygulama tasarlarken bir mimari problemi çözmek için geliştiriciye bir şablon ( *template* ) sağlarlar.

Bir tasarım deseni kullanmak, en iyi uygulamaları ( *best practices* ) takip etmek anlamına gelir.

Desen geliştiriciler arasında yaygın olduğu için, kodun okunabilirliğini artırmaya yardımcı olur ve bakımı kolaylaştırır. Bu desenler ayrıca kodun daha verimli çalışmasını sağlar.

---

## 🧱 Basit Bir Örnek: Singleton

Basit bir örnek inceleyelim.

*Singleton* deseni, bir sınıfın yalnızca tek bir örneğe ( *instance* ) sahip olabileceğini ve uygulamanın herhangi bir yerinden erişilebilen tek bir erişim noktası ( *single point of access* ) sağlaması gerektiğini belirten bir tasarım desenidir.

Bu, bir yapılandırma yöneticisi ( *configuration manager* ) veya veritabanı bağlantısı ( *database connection* ) gibi paylaşılan kaynakları yönetmek için kullanışlıdır.

Singleton desenini inceledikten sonra—ki nesnelerin oluşturulmasını verimli şekilde yönetmeye yardımcı olur—şimdi yazılım geliştirmedeki farklı zorlukları ele alan diğer tasarım deseni türlerine geçelim.

---

## 🏗️ Oluşturucu Desenler

 *Oluşturucu desenler (creational patterns)* , geliştiricilerin bir uygulamada nesneleri nasıl oluşturması gerektiğini belirtir.

Bu desen türü, nesneleri kullanılacakları duruma uygun şekilde üreten kod yazmaya odaklanır.

Örneğin, global değişkenler oluşturmak daha kolay ve daha az karmaşık olsa da, bunların aşırı kullanımı bir uygulamayı daha az güvenli hâle getirebilir, daha fazla bellek tüketebilir ve kod bakımını zorlaştırabilir.

Belirli bir senaryoda var olan ve ardından yok edilen yerel bir değişken ( *local variable* ) oluşturmak ise genel olarak daha iyi bir desendir.

---

## 🧱 Yapısal Desenler

 *Yapısal desenler (structural patterns)* , nesnelerin nasıl birleştirildiği ve sınıflar ile nesnelerin daha büyük yapılar oluşturmak üzere nasıl bir araya getirilebileceği ile ilgilenir.

Geliştiriciler bu desenleri, değişikliklerin etkisini en aza indirecek şekilde nesneler ve sınıflar arasındaki ilişkileri organize etmek için kullanır.

Yapısal desenlere bir örnek *adapter* desenidir. Bu desenin nasıl çalıştığını bir örnekle inceleyelim.

Bir nesnenin arayüzü ( *interface* ), başka bir nesnenin arayüzüyle uyumlu olmayabilir. Geliştiriciler, birlikte çalışabilmelerini sağlamak için *adapter* desenini kullanabilir.

Daha sonra nesnelerden birinin çalışma biçimini değiştirirlerse, tüm sistemi değil yalnızca adapter’ı güncellemeleri gerekebilir. Bu, sistem üzerindeki etkiyi azaltır.

Örneğin, *square peg* sınıfı ve *round hole* sınıfı olan bir uygulamanız olduğunu varsayalım. *Round hole* sınıfı nesnelerin yarıçapını ( *radius* ) almak için bir metoda sahip olmasını bekler; ancak *square peg* sınıfında bunun yerine genişliği ( *width* ) almak için bir metot vardır.

Adapter deseni, bu iki nesnenin birlikte çalışması için bir arayüz yazmanıza yardımcı olabilir.

---

## 🔁 Davranışsal Desenler

Şimdi, nesnelerin nasıl etkileşime girdiğine odaklanan geliştirme desenlerinin son kategorisini inceleyelim.

 *Davranışsal desenler (behavioral patterns)* , nesnelerin ve sınıfların birlikte nasıl çalıştığına ilişkin kuralları ve metotları tanımlamaya odaklanır.

Görevlerin programın farklı bölümleri arasında nasıl paylaştırıldığını ve verinin aralarında nasıl aktığını ( *data flows* ) belirleyen net protokoller oluştururlar.

Geliştiriciler davranışsal desenleri etkili biçimde uyguladığında, sistem büyüse veya değişse bile sistemin farklı bileşenleri daha verimli şekilde birlikte çalışır.

---

## 🛠️ Desenleri Destekleyen Araçlar

Bu üç kategori, bakımı daha kolay ve daha verimli çalışan yazılımlar oluşturmak için geliştiricilerin takip etmesi gereken tasarım desenlerini açıklar.

Ancak geliştiriciler desenleri görmezden gelebilir; bu yüzden mühendisler, yazılım geliştiricilerin tasarım desenlerini takip etmesine ve zorlamasına yardımcı olan araçlar geliştirmiştir.

Visual Studio Code gibi modern yazılım geliştirme araçları, kodun yerleşik tasarım desenleriyle uyumlu şekilde yazılmasına yardımcı olan eklentilerle ( *extensions* ) donatılmıştır.

Örneğin, bazı eklentiler siz yazarken kodunuzu analiz edebilir ve tekrarlayan kod bloklarını yeniden kullanılabilir fonksiyonlara veya sınıflara dönüştürmek gibi yaygın desenlerle uyumlu yeniden düzenlemeler ( *refactorings* ) önerebilir.

Visual Studio Code’un entegre geliştirme ortamı ( *integrated development environment* ), kodu analiz ederek en iyi uygulamalardan sapmaları—tasarım desenlerinin yanlış kullanımını da dahil ederek—tespit edebilir.

Bir sapma tespit ettiklerinde, geliştiriciye değişiklik yapabilmesi için uyarı verebilirler.

Bu araçlar, geliştiricilerin tutarlı ve mimari desenlere bağlı kalan kod yazmasına yardımcı olur.

Araçlar ve pratiklerin bir kombinasyonunu kullanarak, geliştiriciler kabul görmüş tasarım desenlerine uygun yazılım yazma yönünde sürekli çalışmalıdır.

Bu, kodu daha kolay bakımı yapılabilir hâle getirecek ve daha kolay büyüyüp evrilebilen güçlü sistemler oluşturmalarına yardımcı olacaktır.

---

## ✅ Sonuç

Bu videoda, nesne yönelimli programlamada tasarım desenlerinin önemini;  *creational* , *structural* ve *behavioral* desenler dahil olmak üzere nasıl açıklayacağınızı öğrendiniz.

Bu desenleri uygulayarak, verimli, sürdürülebilir ve ölçeklenebilir kod yazabilirsiniz.

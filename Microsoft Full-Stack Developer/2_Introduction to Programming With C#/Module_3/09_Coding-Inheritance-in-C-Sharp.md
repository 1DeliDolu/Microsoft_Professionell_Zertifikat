## 🧬 C#’ta Kalıtımı Kodlamak

Bir evi inşa etmek için kullanılan bir planınız olduğunu ve bu planın farklı türde evler yapmak için yeniden kullanılabildiğini ve değiştirilebildiğini hayal edin. Programlamada kalıtım da benzer şekilde çalışır; zaten var olan bir sınıftan özellikleri ve metotları kullanır.

Bu videoda, C# programlarında kalıtımı uygulayacağız. C#’ta kalıtımı kullanarak geliştiriciler, mevcut bir sınıftan özellikleri ve metotları miras alan yeni bir sınıf oluşturabilir. Mevcut sınıfa  *taban sınıf (base class)* , yeni sınıfa ise *türetilmiş sınıf (derived class)* denir.

---

## 🔐 Erişim Belirleyicileri ile Taban Sınıf Tanımlama

Başlamak için, C# geliştiricileri bir erişim belirleyicisi ( *access modifier* ) kullanarak bir taban sınıf tanımlar. Bu anahtar sözcükler, kodun diğer bölümlerinin sınıfa erişip erişemeyeceğini belirler.

Bir sınıfı *public* olarak bildirmek, üyelerinin başka herhangi bir sınıftan erişilebilir olduğu anlamına gelir. *Private* sınıf üyeleri yalnızca sınıfın kendi içinde erişilebilir, *protected* üyeler ise sınıf içinde ve türetilmiş sınıflar tarafından erişilebilir.

Erişim belirleyicisinden sonra, geliştirici *class* anahtar sözcüğünü kullanır ve bildirimi tamamlamak için sınıf adını yazar.

Taban sınıf, diğer sınıfların miras alabileceği ortak özellikleri ( *properties* ) ve metotları ( *methods* ) içerir. Özellikler, sınıfın nasıl çalışacağını dahili olarak yönlendirmek için kullanacağı verileri veya sınıfın işleyeceği verileri tutar.

Metotlar, sınıfın gerçekleştirebileceği işi tanımlar. Son olarak taban sınıfın bir  *constructor* ’ı vardır; bu, sınıfın giriş noktasıdır.

Bu, bir evin ön kapısı gibidir; içeri girer ve kim olduğunuzu ve neden orada olduğunuzu bildirirsiniz. Constructor, geliştiricinin sınıfın özelliklerinin başlangıç değerlerini ayarlamak için kullanabileceği giriş parametreleri alabilir.

---

## 🏊 Örnek: Pool Sınıfı

Bir geliştiricinin bir havuz için bakım bilgilerini yöneten bir sınıf oluşturmak istediğini varsayalım. Sınıfı *public* olarak bildirir ve iki özelliği vardır: *chlorineLevel* ve  *waterLevel* .

Constructor, bu değerleri giriş parametreleri olarak alır ve özelliklere atar.

Bu basit sınıfın, constructor’a aktarılan değerleri yazdıran *poolInfo* adlı bir metodu vardır.

Bu sınıf, bir taban sınıfın tüm öğelerine sahiptir ve sınıfı çok daha güçlü hâle getirmek için daha fazla özellik ve metot eklenerek kolayca genişletilebilir.

---

## 🧩 Türetilmiş Sınıf ile Genişletme

Geliştiriciler, bir sınıfın neler yapabileceğini türetilmiş sınıf oluşturarak daha da genişletebilir. Bir türetilmiş sınıf, taban sınıfın tüm özelliklerini ve metotlarını miras alır ve geliştiriciler, orijinal taban sınıfı etkilemeden onu genişletebilir.

Bunun nasıl çalıştığını inceleyelim.

Türetilmiş sınıflar C#’ta taban sınıflara benzer şekilde, bir erişim belirleyicisi ve türetilmiş sınıf için bir ad kullanılarak tanımlanır.

Türetilmiş sınıf oluşturmak için geliştirici, sınıf adından sonra iki nokta üst üste ( *:* ) koyar ve bildirime taban sınıfın adını ekler.

Türetilmiş sınıf, taban sınıfın tüm özelliklerini ve metotlarını miras alır.

Geliştiriciler ayrıca kendi yeni özelliklerini ve metotlarını da ekleyebilir. Taban sınıfın tüm avantajlarını elde ederler, ancak belirli bir senaryo için özelleştirebilirler.

---

## 🛁 Örnek: Pool’dan Türetilen Spa Sınıfı

Örneğin bir geliştirici, *pool* taban sınıfından bir spa için türetilmiş bir sınıf oluşturabilir.

Türetilmiş sınıfı *public* belirleyicisi ve sınıf adı *spa* olacak şekilde bildirir; bu sınıf *pool* taban sınıfından türetilmiştir.

Türetilmiş sınıf, taban sınıfın sahip olduğu *chlorineLevel* ve *waterLevel* özelliklerine sahiptir; ancak geliştirici spa’ların ısıtmalı olması nedeniyle *heatLevel* adlı yeni bir özellik eklemeye karar verir.

Constructor, üç özelliğin tamamı için veriyi giriş parametreleri olarak alır ve bu değerleri türetilmiş sınıfın özelliklerine atar.

Bu türetilmiş sınıf, ekrandaki spa bilgisini göstermek için taban sınıftan miras aldığı *PoolInfo* metodunu kullanır.

---

## ✅ Sonuç

Sonuç olarak, C#’ta kalıtım; geliştiricilerin kodu yeniden kullanmasını sağlayan ve C# kodunu daha kolay sürdürülebilir hâle getiren güçlü bir nesne yönelimli araçtır.

Bu videoda, C# programlarında kalıtımı uygulamayı öğrendiniz. C#’ta kalıtım, bir taban sınıf oluşturmayı ve ardından kalıtım kullanarak bir türetilmiş sınıf türetmeyi içerir.

Kalıtımı kullanarak geliştiriciler C#’ta düzenli, yeniden kullanılabilir ve sürdürülebilir kod oluşturur.

## 🧩 Integrating Functions and Methods

Kodunuzun her parçasının sorunsuz şekilde birlikte çalıştığı, karmaşık programları kolaylıkla oluşturduğunuzu hayal edin. Bu yalnızca bir programcının hayali değildir; fonksiyonları ve metotları tek bir programda birleştirme sanatında ustalaşarak ulaşabileceğiniz bir gerçektir. Kod okunabilirliğini artırmaktan verimliliği yükseltmeye kadar, bu yaklaşımın faydaları her seviyedeki geliştirici için gerçekten dönüştürücüdür.

Bu videoda, program tasarımına ve modüler yaklaşımın faydalarına odaklanarak fonksiyonları ve metotları tek bir program içinde birleştireceğiz.

---

## 🧱 Fonksiyonları ve Metotları Birlikte Kullanmak

Fonksiyonları ve metotları tek bir programda birleştirmek, kodlama verimliliğinizi ve program yapınızı önemli ölçüde iyileştirebilen güçlü bir tekniktir. Birden fazla fonksiyon ve metodu etkili biçimde entegre eden bir programı nasıl tasarlayacağımızı inceleyelim.

İlk olarak, birden fazla fonksiyon ve metodu entegre eden bir program tasarlarken, programınızı daha küçük ve yönetilebilir görevlere bölerek başlayın.

Uygulamanızın kullanıcıların hangi hedeflere ulaşmasına yardımcı olması gerektiğini düşünün.

Ardından, kullanıcıların bu hedeflere ulaşmasına yardımcı olmak için gereken tekil görevleri izole etmeye çalışın.

Her görev, bir fonksiyon veya metot olarak temsil edilebilir; bu da kodunuzu daha düzenli ve daha anlaşılır hâle getirir.

---

## 🏦 Örnek: Basit Bir Bankacılık Uygulaması

Örnek olarak basit bir bankacılık uygulamasını ele alalım.

Uygulamanın görevlerini; hesap bakiyesini kontrol etme, para yatırma, para çekme ve faiz hesaplama gibi işlere bölebiliriz.

Bunların her biri programımızda ayrı bir fonksiyon veya metot olabilir.

---

## 🔗 Görevler Arasındaki İlişkileri Planlama

Sonraki adımda, bu görevler arasındaki ilişkiyi düşünün.

Bazı fonksiyonların diğerlerini çağırması gerekebilir; metotlar ise paylaşılan veri üzerinde çalışabilir.

Bu etkileşimleri planlayarak programınızın yapısı için bir yol haritası oluşturursunuz.

Bankacılık uygulaması örneğimizde, **withdrawal** fonksiyonunun, yeterli bakiye olduğundan emin olmak için **check balance** fonksiyonunu çağırması gerekebilir.

Bir müşteri para çekmeye çalıştığında, program önce mevcut bakiyeyi kontrol eder, çekilmek istenen miktarla karşılaştırır ve yalnızca hesapta yeterli para varsa çekim işlemine devam eder.

Bu, bir fonksiyonun ( **withdraw** ) görevini yerine getirmek için başka bir fonksiyona ( **check balance** ) nasıl dayanabileceğini gösterir.

---

## 🎯 Single Responsibility Principle

Fonksiyonlarınızı ve metotlarınızı tek bir göreve odaklı tutmayı unutmayın.

Bu ilke, *Single Responsibility Principle* olarak bilinir ve kodunuzu daha modüler ve daha kolay sürdürülebilir hâle getirir.

 *Single Responsibility Principle* , bir sınıfın, fonksiyonun veya modülün yalnızca tek bir değişme nedeni olması gerektiğini söyler; yani yalnızca tek bir belirli işlevden veya görevden sorumlu olmalıdır.

Bu öğeler yalnızca tek, iyi tanımlanmış bir amaca veya göreve sahip olduğunda; anlaması, sürdürmesi ve test etmesi kolay olur.

Bu ilkeyi kullanarak yazılımınızı tasarladığınızda, yazılım modüler hâle gelir.

---

## 🧩 Modularity

Uygulamanızda fonksiyonları ve metotları birleştirirken modüler bir yaklaşım benimsemek, kodunuzu daha kolay sürdürülebilir ve yeniden kullanılabilir hâle getirebilir.

Bu yaklaşım *Modularity* olarak adlandırılır.

 *Modularity* , bir programı ayrı, kendi kendine yeterli birimlere veya modüllere bölme pratiğidir; her modül belirli bir işlev parçasından sorumludur.

Şimdi modüler kodun faydalarını inceleyelim.

---

## 📖 Modüler Kodun Faydaları

### ✅ Daha Okunabilir Kod

Modüler kod daha okunabilirdir.

Programınızı ayrı fonksiyonlar ve metotlar hâline böldüğünüzde, kodunuzda doğal bölümler oluşturursunuz.

Bu, sizin ve diğer geliştiricilerin program yapısını anlamasını ve içinde gezinmesini kolaylaştırır.

Bankacılık uygulamamızda, her işlem için ayrı metotların olması ( **deposit** ,  **withdrawal** ,  **check balance** ) programın genel yapısını daha net hâle getirir.

Projeye yeni katılan bir geliştirici, karmaşık kod çözmeye gerek kalmadan her bölümün ne yaptığını hızlıca anlayabilir.

---

### ♻️ Daha Yüksek Yeniden Kullanılabilirlik

Modülerliğin bir diğer faydası, kodun yeniden kullanılabilirliğini artırmasıdır.

İyi tanımlanmış fonksiyonlarınız ve metotlarınız olduğunda, bunları programınızın farklı bölümlerinde veya hatta başka projelerde kolayca yeniden kullanabilirsiniz.

Bu, zaman kazandırır ve kod tekrarını azaltır.

Örneğin, bankacılık uygulamamızdaki faiz hesaplama metodu; tasarruf hesapları, krediler veya tamamen ayrı bir yatırım takip uygulaması gibi birden fazla bağlamda yeniden kullanılabilir.

Bu işlevi kendi metodunda tutarak, bu özelliği başka programlara taşımayı veya aynı program içinde kullanımını genişletmeyi kolaylaştırırız.

---

### 🧪 Daha Kolay Test ve Hata Ayıklama

Son olarak, modüler yaklaşım test etmeyi ve hata ayıklamayı kolaylaştırır.

Her fonksiyon veya metodu bağımsız olarak test edebilirsiniz; bu da kod içindeki sorunları izole edip düzeltmeyi daha basit hâle getirir.

Bankacılık programında, **withdrawal** işlevini bağımsız şekilde kolayca test edebiliriz.

Bilinen bir bakiyeye sahip bir hesap oluşturduğumuz bir test kurabilir, çekim denemesi yapabilir ve ardından bakiyenin doğru şekilde güncellenip güncellenmediğini doğrulayabiliriz.

Eğer çekimlerde bir sorun varsa, programın geri kalanını düşünmeden hata ayıklama çabamızı bu belirli fonksiyona odaklayabiliriz.

---

## 🎯 Özet

Bu videoda, program tasarımına ve modüler yaklaşımın faydalarına odaklanarak fonksiyonları ve metotları tek bir programda nasıl birleştireceğinizi öğrendiniz.

Unutmayın: Anahtar, modüler düşünmek, fonksiyonlarınız ve metotlarınız arasında net ilişkiler kurmak ve her zaman yeniden kullanılabilirlik ile test edilebilirliği akılda tutmaktır.

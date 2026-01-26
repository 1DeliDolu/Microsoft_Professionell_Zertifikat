## 🧩 Solving Problems With Functions and Methods

[MUSIC] Daha önce uzun süre bir şey monte edip, en başta küçük bir hata yaptığınızı fark ettiğiniz oldu mu? Parçalarca şeyi söküp en baştan başlamak zorunda kaldığınızı anladığınızda derin bir hayal kırıklığı yaşarsınız. Benzer şekilde, uygulamaları en baştan doğru şekilde yazmak, saatler sürebilecek yeniden çalışma süresinden tasarruf etmenizi sağlayabilir. Fonksiyonları ve metotları doğru kullanmak, büyük sorunlara yol açabilecek küçük hatalardan kaçınmanın bir yoludur.

Bu videoda, belirli hedefleri gerçekleştirmek için fonksiyonlar ve metotlar kullanan programlar geliştireceğiz. Fonksiyonlar ve metotlar, karmaşık problemleri daha küçük, yeniden kullanılabilir parçalara bölmenize olanak tanıyan kod bloklarıdır. JavaScript’te fonksiyonları, C#’ta metotları kullanırız.

Şimdi, bu araçları nasıl kullanacağımızı fonksiyonlarla başlayarak inceleyelim.

---

## 🧩 Functions

Bir fonksiyon, belirli bir görevi gerçekleştirmek için tasarlanmış yeniden kullanılabilir bir kod bloğudur. Bu, tekrarlanabilir görevler içeren problemleri çözerken kodu organize etmeye yardımcı olur.

Şimdi, bir JavaScript fonksiyonunu farklı girdilerle aynı görevi yapmak için nasıl kullanabileceğimize dair bir örnek inceleyelim.

Bu JavaScript kodu, **calculateTotalPrice** adlı bir fonksiyon tanımlar.

Fonksiyon bir parametre kabul eder:  **item prices** , yani fiyatların bir listesi.

**total** değişkenini **0** olarak başlatırız; bu değişken tüm ürün fiyatlarının toplamını tutacaktır.

Ardından, **item prices** dizisindeki her fiyatı almak için bir **for loop** kullanırız.

Döngünün içinde, her fiyat **total** değişkenine eklenir.

Döngü bittiğinde, toplam değer fonksiyonun çıktısı olarak geri döndürülür.

Bu fonksiyon, bir e-ticaret web sitesinde sepetteki ürün fiyatlarını toplamak gibi senaryolarda kullanışlıdır.

---

## 📞 Fonksiyonu Çağırma

Artık fonksiyon tanımlı olduğuna göre, bir değer listesini hesaplamak için nasıl çağırdığımızı inceleyelim.

**"totalprice"** değişkenini **"calculateTotalPrice"** fonksiyonuna atayacağız.

 **totalprice** , fonksiyonun döndürdüğü değeri saklayacaktır.

Fonksiyonu **totalPrice** değişkenine atadığımızda, JavaScript bu satıra geldiğinde **calculatetotalprice** fonksiyonunu çağırır.

**calculateTotalPrice** fonksiyonunu çağırdığımızda, sayılardan oluşan bir liste geçiririz; bu örnekte ürün fiyatlarını temsil eden  **10** , **20** ve  **30** .

**console.log** fonksiyonu, toplam fiyatı konsola yazdırır.

Bu, size çıktıyı sunar.

Bu örnek, bir alışveriş sepetindeki ürünlerin toplam maliyetini hesaplamayı simüle eder.

---

## 🧩 Methods

JavaScript’te fonksiyonların nasıl çalıştığını gördüğümüze göre, şimdi metotlara geçelim.

Metotlar fonksiyonlara benzer, ancak C#’ta bir sınıfın ( *class* ) parçasıdır.

Bu yapı, nesne yönelimli kodda nesnelerle çalışmayı daha kolay hâle getirir.

İndirim hesaplayan bir metot örneğine bakacağız.

Metotlar, belirli görevleri yerine getiren yeniden kullanılabilir kod blokları olmaları açısından fonksiyonlara benzer.

Metotlar, nesnelerde kullanıldıkları için fonksiyonlardan farklıdır.

Nesne yönelimli programlamada, bir görev üzerinde çalışırken nesnenin diğer metotları veya nesnenin verisi gibi bileşenleri kullanabilirler.

Şimdi C#’ta tekrarlanabilir bir görevi tamamlamak için bir metodu nasıl kullanabileceğinizi inceleyelim.

---

## 🛍️ C# Örneği: İndirim Hesaplayan Metot

Önce metodu içerecek bir **product** sınıfı tanımlarız.

Sınıfın içinde **CalculateDiscount** metodunu tanımlarız.

Bu metot iki parametre alır: **price** ve  **discountRate** .

Son olarak indirimi uygulanmış fiyatı döndürür.

Bu metot, bir çevrim içi mağazada ürünlere indirim uygulamak için kullanılabilir.

Metot indirimi, **price** değerini **discountRate** ile çarpıp sonucu orijinal fiyattan çıkararak hesaplar.

---

## 📞 Metodu Çağırma

Şimdi indirimi uygulamak için metodu çağırmamız gerekir.

Metot çağrısında, **price** ve **discount rate** değerlerini parametre olarak geçiririz.

İlk olarak **new Product()** kodunu kullanarak **Product** sınıfının bir örneğini ( *instance* ) oluştururuz.

Sonra **product** nesnesi üzerinde **CalculateDiscount** metodunu çağırır, **price** olarak **100** ve **discount rate** olarak **0.2** geçiririz.

Metot indirimi uygulanmış fiyatı döndürür; bu değer **discountedPrice** değişkeninde saklanır.

Son olarak **Console.WriteLine** fonksiyonu, indirimli fiyatı konsola yazdırır.

Bu, bir üründe indirim uygulandıktan sonra fiyatın hesaplanmasını ve görüntülenmesini simüle eder.

---

## 🎯 Özet

Bu videoda, tekrarlayan görevler için fonksiyonları nasıl kullanacağınızı ve bir uygulama içinde belirli işlemleri yönetmek için metotları nasıl uygulayacağınızı öğrendiniz.

Bu teknikleri uygulayarak, yalnızca anlık zorlukları çözmekle kalmayan; aynı zamanda gelecekteki geliştirmeler için güçlü bir temel oluşturan modüler, yeniden kullanılabilir ve sürdürülebilir kod oluşturabiliriz. [MUSIC]

## 🧑‍💻 C# ile Uygulamalı Kodlama

C-sharp’ın temellerinde ustalaşmak, verimli ve ölçeklenebilir programlar geliştirmenin kapısını açar. Yazdığınız her satır kodun bir amacı vardır ve söz dizimini anlamak, temiz ve etkili uygulamalar yazmanın anahtarıdır.

Bu videoda, söz dizimini pratik etmek ve özelliklerini anlamak için temel C-sharp programları yazacağız. Burada sıfırdan kod yazmak yerine, önceden hazırlanmış bazı kodlarım var ve bunların üzerinden birlikte geçmenin en iyi yol olacağını düşünüyorum. Bu videodaki amaç, dilde farklı söz dizimlerinin nasıl göründüğünü size göstermektir. Bu yüzden C-sharp’ın farklı özelliklerini sergileyen bir sürü örnek hazırladım. Dosyanın en üstünü inceleyerek başlayalım.

---

## 🗂️ Dosyanın Üst Kısmı: Namespace ve Interface

İlk fark ettiğimiz şey **C-sharp basics** namespace’i. Yani tüm bu kodun yaşadığı namespace bu. Bu encapsulation sağlar; tüm kodumuz o namespace altında yaşar. Başka kodlarla çakışmaları engeller.

Hemen ardından `IDiscountable` adında bir interface var. Bu interface’in tek bir member’ı var: `decimal`. `decimal`, float veya int gibi bir şeydir. `decimal`, para gibi şeylerle çalışırken daha hassas bir veri türüdür ve burada da bununla çalışıyoruz.

Burada `ApplyDiscount` method’u var ve parametre olarak bir yüzde alıyor. Ayrıca interface’in büyük `I` harfiyle başladığını fark edin. Bu yaygın bir isimlendirme konvansiyonudur; kesinlikle zorunlu değildir ama “ben indirime uygunum” ( *I am discountable* ) gibi düşünülür: `IDiscountable`. İnsanların bunları düşünme biçimidir. Ayrıca hızlıca bunun bir interface olduğunu, class olmadığını anlamanızı sağlar.

---

## 🧱 Product Class: Dosyanın Çekirdeği

Aşağı doğru devam ettiğimizde `Product` class’ının çekirdeğine geliyoruz; bu dosyadaki ana class gibi.

Burada bir private field var: `_price`. Alt çizgi kullanımı genelde C Sharp’ta private field’lar için standart bir isimlendirme konvansiyonudur. Kesinlikle gerekli değil; insanların yaptığı bir şey.

Ardından public `Name` property’si var. Sonra da ek bir setter içeren public bir property var; eğer değeri sıfırın altına set etmeye çalışırsak, bunu yapmıyor. Yani yalnızca fiyat sıfırdan büyük veya eşitse (`>= 0`) price gerçekten o değere set ediliyor. Eğer `Price`’ı alıp `-12` gibi bir değere set etmeye karar verirsek, bu çalışmayacak.

Bu, private bir `_price` kullanmakla public bir setter ve getter kullanmak arasındaki farkı gösteriyor.

Ayrıca burada sadece tek kelime olduğunu fark edeceksiniz; fakat bu tür property’lerde genellikle **PascalCase** kullanılırken, private field’larda **camelCase** görmeniz yaygındır. Ve yine alt çizgiyle birlikte.

---

## 🧱 Constructor

Sonraki kısımda constructor var. Constructor iki parametre alıyor: `string name` ve `decimal price`. Ardından bu property’leri, geçirilen argümanlarla eşleşecek şekilde set ediyor.

---

## 🧬 Virtual Method ve Static Method

Class içinde `DisplayProductDetails` adında bir virtual method da bulacağız; bu method sadece ürün adını ve fiyatını log’luyor.

Virtual method’lar bir parent class’ta tanımlanır ve child class’ta overwrite edilebilir; bunu birazdan göreceğiz.

Bunun ardından `CalculateDiscount` adlı static method geliyor. Bunun static olduğunu `static` yazmasından, bunun virtual olduğunu da `virtual` yazmasından anlıyoruz.

Bu method `decimal` döndürür ve iki argüman alır: bir `price` ve bir `discount percentage`.

Static bir method, instance member’larında değil, class’ın kendisi üzerinde var olur. Yani `Product.CalculateDiscount` çağırabilirsiniz; bir instance oluşturup sonra o product üzerinden `CalculateDiscount` çağırmanız gerekmez.

Bu, bir şekilde “her zaman elimizde olsun” istediğimiz ama tek tek her instance’ın price’ına bağlı olmak zorunda olmayan bir fonksiyon. Yine burada fiyat ve indirim yüzdesi argümanlarla gelir. Yukarıdaki `_price` ile aynı şey değildir. Bunlar, class içindeki member’lardan alınan değerler değil; bu method’a dışarıdan verilen argümanlardır.

---

## 👕 Derived Class: Clothing

Aşağı indiğimizde bir subclass görüyoruz. Bu, `Product`’ın derived class’ı ve aynı zamanda `IDiscountable` interface’ini de implement ediyor.

Yani `Product`’ın sahip olduğu her şeye sahip olacak ve ayrıca yukarıda gördüğümüz `IDiscountable` interface’inin `ApplyDiscount` method’unu da implement etmek zorunda olacak.

Burada eklenen bir public member var: `Size`. Yani bir `Product`’ın sahip olduğu her şeye sahip, ama ayrıca `Size` da var. Buradaki fikir şu: örneğin kitaplarınız olabilir ama kitapların bedeni olmaz; kıyafetlerin olur. Bu da yeni bir property ile `Product` fonksiyonelliğini genişletmek demek.

Constructor’a baktığınızda `string name`, `decimal price`, `int size` aldığını görüyorsunuz; ek olarak `size` alıyor. `name` ve `price`’ın nasıl set edildiğine bakarsanız, aslında `base(name, price)` çağrısı yapıyor. Bu, parent’ın constructor’ını bu iki argümanla çağırarak değerleri set ediyor. Ardından `Size`’ı `size` ile set ediyor; çünkü bu parent’ın constructor’ından kopyalanamayacak yeni davranış.

---

## 🏷️ Size Dönüşümü ve Switch Case

Sonra, `size`’ı bir `int`’ten bir “size name”e dönüştüren bir method var. Bu yaygın bir konvansiyondur. Bir integer saklamak, string saklamaktan çok daha verimlidir. Burada 1, 2, 3, 4 gibi değerleri saklayıp bunları `SM` (small), `MD` (medium), `LG` (large) gibi değerlere çevirebilirsiniz.

Aşağıda bilinmeyen beden için bir “catch-all” da var.

Burada ayrıca bir `switch case` görüyorsunuz. `size` değişkenine bakıyor ve değere göre:

* 1 ise o string’i döndürüyor,
* 2 ise o string’i döndürüyor,
* 3 ise o string’i döndürüyor,
* ve benzeri.

Bu `switch` içindeki farklı case’lerin hepsini yakalıyor.

---

## 🧬 Override ile Detayları Gösterme

Sonraki kısımda ürün detaylarını gösteren bir override method var. Bu, base class’ın `DisplayProductDetails` implementasyonunu override ediyor.

Burada `base.DisplayProductDetails` çağrısı yaptığımızı görüyorsunuz. Bu, parent’ın `DisplayProductDetails` implementasyonunu çağırır ve buna ek olarak `Size` ve `GetSize` ile bir `WriteLine` daha yapar.

Parent’a geri bakarsanız, `DisplayProductDetails` için bir virtual method olduğunu görürsünüz. `base.DisplayProductDetails` işte tam olarak onu çağırıyor. Yani önce o satırı yazar, ardından da beden detayını yazar.

Bu, base implementasyonu kullanırken aynı zamanda ek fonksiyonellik ekleyebileceğinizi gösterir.

Bunu kaldırabilir, yorum satırına alabilirsiniz; kod yine tamamen geçerli olur. Sadece base implementasyonu çağırmaz.

---

## 🏷️ IDiscountable Uygulaması ve ApplyDiscount

Daha da aşağıda `IDiscountable` interface’inin implementasyonunu görüyoruz. Yukarı kaydırırsanız `IDiscountable`’ın `decimal` döndüren ve `decimal` alan bir `ApplyDiscount` method’u olması gerektiğini görürsünüz. Burada da aynen bunu yapıyor.

Ayrıca parent class’tan gelen `CalculateDiscount` method’undan (static method) faydalanıyor. Burada `price` ve `percentage`, bu instance’tan geliyor.

---

## 🧑‍💻 Program Class ve Main Method

Şimdi `Program` class’ına geliyoruz. Bu, programımızın mantığını tutacak ana class.

Giriş noktası (`entry point`) `Main` method’u. Yani `.NET run` yaptığımızda çalışan şey bu `Main` method’u.

Bir `Clothing` object listesi oluşturacağız ve buna `catalog` diyeceğiz; `new List<Clothing>()` olarak set edilecek.

Buradaki angle bracket gösterimi (`< >`), **generic type** olarak bilinir. `List`, içinde tutacağı object türünü alır. Burada `Clothing` dediğimizde, bu bir clothing item’ları listesi olur.

Sonra üç clothing item ekliyoruz ve bunların üzerinden standart bir `for` loop ile geçiyoruz. Iterator’ı 0’dan başlatıyoruz. Iterator için bir `int` kullanacağız.

Her döngüde iterator’ı 1 artıracağız; bu `i++`.

`i < catalog.Count` olduğu sürece loop devam eder.

Her loop’ta `catalog`’un o index’indeki item’ı alıp `DisplayProductDetails` çağıracağız.

Ayrıca, aynı şeyi `foreach` loop kullanarak da yapabileceğinizi göstermek istedim. Bu belki henüz gösterilmemiş olabilir ama çok kullanışlıdır.

`foreach` loop, bunun yaptığıyla birebir aynı şeyi yapar. Bir listede tüm item’ların üzerinden geçtiğiniz her durumda, bu “enumerable” olarak bilinen bir şeydir. Yani index 1, index 2, index 3, index 4… Bu enumerable demektir. Böylece `catalog` içindeki her item üzerinde `foreach` ile gezebilirsiniz.

Bu çok kullanışlıdır çünkü bazen bunları yanlış yazabilirsiniz. Bunlar oldukça hata yapmaya açık:

* bazen `<=` yazarsınız,
* bazen `++` yerine tek `+` yazarsınız,
* bazen bunu yanlışlıkla 1’e set edersiniz,
* ve daha birçok şey ters gidebilir.

`foreach` loop bunları yapmanızı engeller. Çok daha temizdir, okunması çok daha kolaydır, anlaşılması çok daha kolaydır.

Son olarak, clothing ürünlerine indirim uyguluyoruz. `discountedPrice` diyeceğimiz şey `catalog[0]` olacak; yani katalogdaki ilk item. Burada `%10` indirim uyguluyoruz. Sonra o indirimli fiyatı `Console.WriteLine` ile yazdırıyoruz.

Ardından, daha önce gösterdiğimiz `Product` class’ındaki static method’u kullanarak hesaplanan indirimi yine `Console.WriteLine` ile yazdırıyoruz.

---

## ▶️ Kodu Çalıştırma ve Terminal

Şimdi bu kodu çalıştıralım. Bir terminal açacağım. `Ctrl + ~` yapacağım; bu yeni bir terminal açar.

Tilde, klavyenizin sol üstünde, Escape tuşunun hemen altındaki tuştur. Çok kullanışlı bir kısayol.

Ayrıca yukarıda Terminal menüsünden de terminal açabilirsiniz ya da buradan sağ tıklayıp “integrated terminal” açabilirsiniz.

Şimdi çalıştıralım. Şunu yazacağım:

```bash
dot net run
```

Yine, yukarıdan da çalıştırabilirsiniz, buradan da çalıştırabilirsiniz. Çalıştırmanın bir sürü yolu var. Benim tercih ettiğim yöntem terminali kullanmak.

`dot net run` yazınca çıktıyı görmeliyiz. İki kez loop etmeyi, `DisplayProductDetails` göstermeyi, aşağıya inip indirim işlerini yapmayı bekliyoruz.

İşte item’larımız: bir, iki, üç. Ve yine aynı şekilde bir, iki, üç. Ardından indirim sonrası fiyatı burada görüyorsunuz. Ve burada da yine `CalculateDiscount` fonksiyonunu gösteren fiyat var.

---

## 🧩 Daha Fazla Genişletme

Artık `Product` ve `Clothing`’in birlikte nasıl çalıştığını bildiğinize göre, bunu daha da genişletmeyi deneyebilirsiniz. Örneğin, garanti süresi gibi farklı property’lere sahip `Electronics` gibi başka bir class oluşturabilirsiniz. Bu, inheritance ve class tasarımında daha rahat olmanıza yardımcı olur.

Ayrıca static method’lar ekleyerek ya da item’lardan oluşan bir kataloğu ada veya fiyata göre sıralayan bir class oluşturarak da denemeler yapabilirsiniz. Yani burada kullandığımız bu list yerine, daha karmaşık bir şey ekleyebilirsiniz.

Bu genel bakış, C sharp ve dot net koduyla çalışırken karşılaşacağınız temel kavramların çoğunu kapsar.

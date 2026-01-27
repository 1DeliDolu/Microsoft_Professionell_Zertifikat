## 🧱 Temel C# Sözdizimi

Yeni bir programlama dili öğrenirken, yapıyı ve sözdizimini en baştan doğru oturtmak; sorunsuz ilerleme ile sayısız saatlik hata ayıklama arasında fark yaratabilir. C# ile başlarken, programın her parçasının nasıl bir araya geldiğini anlamak; temiz ve işlevsel kod yazmak için kritiktir. Bu temelleri şimdi öğrenmek, bundan sonra inşa edeceğiniz her şeyin zeminini oluşturacaktır.

Bu videoda, C# programlarının temel sözdizimini ve yapısını açıklayacağız.  *Sınıflar* ,  *değişkenler* , *kontrol yapıları* ve *metotlar* gibi temel kavramları ele alacağız. Ayrıca bu kavramları göstermek için basit kod örnekleri de inceleyeceğiz.

---

## 🏗️ Temel Bir C# Programının Yapısı

C# programları bir *class (sınıf)* tanımıyla başlar ve asıl mantığın yer aldığı *metotları* içerir.

Bu C# kod bloğu, çalıştırılabilir tüm kodu içeren `Program` sınıfını tanımlar. `static void Main` metodu, programın giriş noktasıdır ( *entry point* ). Süslü parantezler, sınıf ve metodun kod bloklarını tanımlar.

`Console.WriteLine` komutu, `Hello, World` metnini konsola yazdırır. Burası programın gövdesidir; işin yapıldığı yer.

---

## 🧺 Değişkenler

Sırada, program içinde kullanılabilen ve değiştirilebilen verileri saklamak için kullanılan *değişkenler* var.

Değişkenler, değişkenin hangi tür veriyi tuttuğunu programa söyleyen bir *type keyword* ile tanımlanmalıdır. Bir istisna vardır; bunu birazdan inceleyeceğiz.

Bu örnek kod, dört farklı değişken tanımlar ve onları bir değerle başlatır:

İlk olarak, `int age = 25` ifadesi, `age` adlı bir tamsayı değişkeni tanımlar ve ona `25` değerini atar. `int` veri türü yalnızca *tam sayı* değerlerini tutabilir.

İkinci değişkeni `string` veri türüyle tanımlarız. `name` değişkenine `John` metnini atarız. `string` değişkenleri yalnızca metin verisini tutabilir.

Son iki değişken ise özel bir tür anahtar sözcüğü olan `var` kullanır. Bu değişkenler, başta tür belirtmez. Bunun yerine, C# program çalıştığında değişkenin hangi tür değeri tuttuğunu belirler.

Bu örnekte `count` değişkeni `10` tamsayısı ile, `message` değişkeni ise `hello` string değeri ile başlatılır. İkisi de `var` ile tanımlanmıştır.

---

## 🔀 C#’ta Kontrol Yapıları

Kontrol yapıları, programın akışını yönetir. En yaygın kontrol yapıları *if ifadeleri* ve  *döngülerdir* . Bu yapılar, programın karar vermesine ve eylemleri tekrar etmesine yardımcı olur.

### ✅ if / else

`if else` ifadesi, `true/false` koşullarını değerlendirir.

Bu örnek kodda, `if age >= 18` ifadesi, `age` değerinin `18`’e eşit veya büyük olup olmadığını kontrol eder. `>=` operatörünü kullanarak yaşın yalnızca 18’den büyük değil, *18 veya daha büyük* olup olmadığını denetleriz.

Koşul `true` ise program `you're an adult` yazdırır. Koşul `false` ise program `else` bölümüne geçer ve `you're a minor` yazdırır.

Bu yapı, koşula bağlı olarak programın farklı eylemler gerçekleştirmesini sağlar.

### 🔁 Döngüler

Döngüler, aynı kod bloğunu tekrar tekrar çalıştırmak için kullanılır.

C#’ta `for` döngüsü `for` anahtar sözcüğüyle tanımlanır. Tekrarlanacak kod, süslü parantezler arasına yazılır. Döngünün koşulları ise `for` ifadesinden sonra parantez içinde tanımlanır.

Bu örnek kodda önce `i` adlı sayaç değişkenini `0` ile başlatırız. Bu, döngünün başlangıç değeridir.

Sonra döngünün ne zaman biteceğini belirleyen koşulu yazarız: `i < 5`. Yani döngü, `i` 5’ten küçük olduğu sürece çalışır.

Son olarak, `i++` ifadesi her turda `i` değerini 1 artırır.

Döngü içinde `Console.WriteLine(i)` yazarız; bu da `i` değerini konsola yazdırır.

Bu örnek, konsola `0` ile `4` arasındaki sayıları yazdırır.

---

## 🧩 Metotlar

İnceleyeceğimiz son kavram  *metotlardır* . Metotlar, C# gibi nesne yönelimli bir dilde sınıfların içinde bulunan fonksiyonlardır. Belirli görevleri yerine getiren kod bloklarıdır.

Metotlar parametre alabilir ve değer döndürebilir. Bu, kodu düzenlemeye ve yeniden kullanılabilir hâle getirmeye yardımcı olur. Şimdi nasıl çalıştıklarını ve nasıl oluşturulduklarını inceleyelim.

Bu örnek kodda, `calculator` adlı bir sınıf oluştururuz.

Bu sınıfa bir hesap makinesinin tüm işlemlerini yapabilecek kodlar ekleyebiliriz. Bu işlevleri sınıfa koyarak benzer işi yapan kodları tek yerde toplar ve birlikte çalışabilmelerini sağlarız.

Sınıfın `number1` ve `number2` adlı iki üye değişkeni ( *member variables* ) vardır ve `int` veri türündedir. Bunlar, yalnızca sınıfın metotları tarafından kullanılacağı için `private` olarak tanımlanmıştır.

Bu örnekte sınıfa `add` adlı bir metot ekleriz ve bu metot `int` olarak tanımlanır. Metodu bu şekilde tanımlamak, metodu çağıran koda döndürülen değerin `int` olması gerektiği anlamına gelir.

Toplama yaptığımız için iki adet tamsayı parametresi uygularız. Bunlar, metoda dışarıdan geçilecek verilerdir.

Şimdi `add` metodunda üye değişkenlere giriş parametrelerinin değerlerini atarız. Üye değişkenler sınıfın parçası olarak tanımlandığı için metot, işini yapmak üzere onları kullanabilir.

Bu, metot ile fonksiyon arasındaki farklardan biridir: bir metot sınıfın üyelerini kullanabilir, bir fonksiyon kullanamaz.

Son olarak, metodun gövdesi `number1` ve `number2` parametrelerinin değerlerini toplar ve sonucu döndürür.

Bu metot, veri işleyip sonuç döndürmesi açısından bir fonksiyona benzer şekilde çalışır.

Ancak sınıfın içinde çalıştığını ve diğer sınıf üyeleriyle etkileşime girebildiğini fark edeceksiniz.

---

## 🧮 Tüm Kavramları Birleştirme: Hesap Makinesi Örneği

Şimdi tüm bu kavramları bir araya getirelim ve hesap makinesi programımızı geliştirerek devam edelim.

Önceki örneğe benzer bir sınıf ve metot kullanarak, `add` metodunu içeren `calculator` sınıfını tanımlarız.

Sonra `main` adlı ikinci bir `static` metot ekleriz. `main` metodunu `void` dönüş tipiyle tanımlarız; çünkü bu metot giriş parametresi almaz ve bir değer döndürmez.

Ardından, `num1` ve `num2` adlı iki üye değişken ekleriz ve bunları `int` türüyle tanımlarız. `num1` değişkenini `5`, `num2` değişkenini ise `10` değeriyle başlatırız.

Sonra `int` türünde `result` adlı bir değişken tanımlarız. Bu değişkenin değerini `add` metodunun sonucuna eşitleriz.

`add` metoduna parametre olarak `num1` ve `num2` değerlerini geçiririz.

Son olarak `Console.WriteLine` ile `result` değişkeninin değerini konsola yazdırırız.

Bu örnekte sonuç `15` olacaktır; dolayısıyla konsolda `sum is 15` görünecektir.

---

## ✅ Kapanış

Artık C# programlarının temel sözdizimini ve yapısını ele aldık. Program yapısını inceledik, değişkenler ve veri türlerini keşfettik, kontrol yapılarını inceledik ve metotları konuştuk.

Ayrıca her şeyi bir araya getirmek için basit bir hesap makinesi programı oluşturduk.

Bu yapı taşları, daha karmaşık C# uygulamaları yazmak için temel öneme sahiptir.

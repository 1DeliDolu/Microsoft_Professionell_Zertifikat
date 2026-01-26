## 🔁 Loop Constructs

## 📘 Introduction to Essential Loop Constructs

Döngüler, programlamada geliştiricilerin bir kod bloğunu birden fazla kez çalıştırmasına olanak tanıyan temel kontrol yapılarıdır. Zaman kazandırır ve kodu daha verimli hâle getirir. Bu okuma, üç yaygın döngüyü ele alacaktır:  *for döngüleri* , *while döngüleri* ve  *do-while döngüleri* . Tanımlarını, kullanım alanlarını ve C# örnekleriyle sözdizimlerini inceleyeceğiz.

---

## 🔂 For Loops

 *For döngüsü* , belirli sayıda tekrar için bir kod bloğunu tekrar tekrar çalıştıran bir kontrol akışı (control flow) ifadesidir. Özellikle yineleme (iteration) sayısı önceden biliniyorsa faydalıdır. Örneğin, bir dizideki (array) her öğeyi işlemek veya belirli sayıda hesaplama yapmak için bir for döngüsü kullanılabilir.

Bir for döngüsünün sözdizimi dört bölüm içerir:

* **Initialization:** Bu bölüm, döngü sayacını başlatır; genellikle başlangıç değeri atanır.
* **Condition:** Her yinelemeden önce koşul kontrol edilir. Koşul doğruysa döngü devam eder; yanlışsa döngü durur.
* **Increment/decrement:** Her yinelemeden sonra döngü sayacı güncellenir; genellikle artırılır veya azaltılır.
* **Code block:** Her yinelemede çalıştırılacak kodu içerir.

### 💻 Example in C#

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

Bu örnekte döngü, `i` adlı bir tamsayı değişkenini 0’a başlatır. `i < 5` koşulu, `i` 5’ten küçük olduğu sürece döngünün çalışmasını sağlar. `i++` artırma işlemi, her yinelemeden sonra `i` değerini 1 artırır. Döngü her seferinde `i` değerini yazdırır ve sonuç şu olur: `0, 1, 2, 3, 4`. For döngüleri, dizilerle çalışırken veya bir görevin bilinen sayıda tekrar edilmesi gerektiğinde yaygın olarak kullanılır.

---

## 🔄 While Loops

 *While döngüsü* , verilen bir koşula bağlı olarak kodun tekrar tekrar çalıştırılmasına izin veren bir başka kontrol akışı ifadesidir. For döngüsünün aksine, while döngüsü yineleme sayısı önceden bilinmediğinde ve çalıştırma sayısı yürütme sırasında değişebilen bir koşula bağlı olduğunda idealdir. Bu nedenle while döngüleri, kullanıcı girdisi okumak veya bir sensörün durumunu sürekli kontrol etmek gibi belirli bir koşul sağlanana kadar işlem yapılması gereken durumlar için özellikle kullanışlıdır.

While döngüsünün sözdizimi basittir:

* `while` anahtar sözcüğü ile başlar ve parantez içinde bir koşul alır.
* Koşul doğru olduğu sürece, döngü içindeki kod bloğu çalıştırılır.

### 💻 Example in C#

```csharp
int counter = 0;
while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}
```

Burada while döngüsü, her yinelemeden önce `counter < 10` koşulunu kontrol eder. Koşul doğruysa, döngü kod bloğunu çalıştırır; bu blok `counter` değerini yazdırır ve sonra `counter++` ile 1 artırır. Döngü, `counter` artık 10’dan küçük olmayana kadar devam eder ve sonuç şu olur: `0, 1, 2, 3, 4, 5, 6, 7, 8, 9`. Bu döngü türü, dinamik bir koşul sağlanana kadar çalışması gereken durumlar için idealdir.

---

## 🔁 Do-While Loops

 *Do-while döngüsü* , while döngüsüne benzer ancak kritik bir farkı vardır: koşuldan bağımsız olarak kod bloğunun **en az bir kez** çalışmasını garanti eder. Bunun nedeni, koşulun döngü çalıştırıldıktan sonra kontrol edilmesidir. Do-while döngüsü, herhangi bir koşul değerlendirilmeden önce bir eylemin en az bir kez gerçekleşmesini sağlar. Yaygın kullanım senaryoları arasında kullanıcıdan geçerli veri gelene kadar girdi istemek veya en az bir kez çalışması gereken başlatma süreçleri yer alır.

Do-while döngüsünün sözdizimi iki bölüm içerir:

* Döngü `do` anahtar sözcüğü ile başlar ve süslü parantez `{}` içindeki kod bloğu çalıştırılır.
* Kod bloğundan sonra `while` anahtar sözcüğü ve koşul belirtilir.

### 💻 Example in C#

```csharp
int counter = 10;
do
{
    Console.WriteLine(counter);
    counter++;
} while (counter < 10);
```

Bu durumda döngü, `counter < 10` koşulunu kontrol etmeden önce `counter` değerini bir kez yazdırır. `counter` 10’a başlatıldığı için, ilk yinelemeden sonra koşul hemen yanlış olur. Ancak do-while döngüsü koşulu yalnızca kod bloğunu çalıştırdıktan sonra kontrol ettiği için, döngü sonlanmadan önce `10` sayısı bir kez yazdırılır. Bu davranış, do-while döngülerini standart while döngülerinden ayırır: do-while döngüleri her zaman en az bir yineleme çalıştırır.

---

## ⚖️ Comparing the Loops

Her döngü türü farklı bir amaca hizmet eder ve farklı senaryolar için uygundur:

* **For döngüleri** , yineleme sayısı önceden bilindiğinde en uygundur; örneğin diziler veya koleksiyonlar üzerinde gezinirken.
* **While döngüleri** , yineleme sayısı önceden belirli olmadığında ve yürütme sırasında dinamik olarak değişen bir koşula bağlı olduğunda idealdir.
* **Do-while döngüleri** , en az bir çalıştırmayı garanti eder; bu da koşulu kontrol etmeden önce bir eylemin mutlaka gerçekleşmesi gereken senaryolar için mükemmeldir.

---

## ✅ Conclusion

Bu üç döngü arasındaki farkları anlamak, programcıların ihtiyaçlarına en uygun döngüyü seçmesini sağlar. For döngüleri sabit tekrarlar için uygunken, do-while döngüleri koşula bağlı ve tekrarlı süreçler için esneklik sunar. Bu kontrol yapılarında ustalaşmak, verimli programlama ve etkili kod yönetimi için gereklidir.

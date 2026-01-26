## 🔁 For Loops

Bir fabrikanın yöneticisi olduğunuzu ve binlerce ürünün sevkiyattan önce kalite kontrolünden geçirilmesi gerektiğini hayal edin. Bunu her ürün için manuel olarak yapmak sonsuza kadar sürerdi. Peki ya tek bir komutla her ürünü bir saniyede denetleyebilen bir makineniz olsaydı?

Kodunuzda bir *for döngüsü* tam olarak bunu yapar. Tekrarlayan görevleri otomatikleştirir, zaman ve emek tasarrufu sağlar ve her adımın kusursuz biçimde tamamlanmasını sağlar. Bu videoda, *for döngülerinin* amacını ve sözdizimini (syntax) açıklayacağız.

Önce bir *for döngüsü* tanımıyla başlayalım.

---

## 📌 For Loop Tanımı

 *For Loop* , bir koşula bağlı olarak kodun tekrar tekrar çalıştırılmasını sağlayan bir kontrol akışı (control flow) ifadesidir.

Birçok programlama dilinde, for döngüleri temel bir deseni izler. Döngü şunlardan oluşur:

* Bir  *gövde (body)* : tekrar tekrar çalışmasını istediğiniz kod
* Gövde kodunun kaç kez tekrarlanacağını belirleyen bir sayı veya öğe koleksiyonu

Şimdi bu öğeleri içeren bir for döngüsünü nasıl oluşturacağımıza bakalım:

* `"for"` anahtar sözcüğünü ekleyin.
* Gövde kodunun kaç kez çalıştığını takip etmek için bir değişken başlatın; bu değişken genellikle küçük harf `"i"` olur.
* Döngünün ne zaman biteceğini belirleyen bir koşul ayarlayın.
* Gövde kodu her çalıştığında `"i"` değişkenini artırın.
* Son olarak, her döngüde çalıştırılacak kodu ekleyin.

---

## 💻 C# ile For Loop Yapısı ve Sözdizimi

Şimdi C# kullanarak bir for döngüsünün yapısını ve sözdizimini parçalarına ayıralım.

Önce parantezlerle birlikte `"for"` anahtar sözcüğünü ekleyin. Ardından `"i"` değişkenini başlatıp parantez içinde sıfıra eşitleyin.

Sonra her döngünün çalışması için gereken bir koşul belirleyin. Bu da parantez içinde yer alır ve her öğe noktalı virgül ile ayrılır.

Bu örnekte koşul `"i"` değerinin 5’ten küçük olmasıdır. Bu, döngünün `"i"` 5’ten küçük olduğu sürece çalışacağı anlamına gelir.

Sonrasında, gövde kodu her çalıştığında `"i"` değişkenini 1 artırmasını söyleriz. C#’ta bunun için `"i++"` sözdizimini kullanırız; bu, her yinelemeden (iteration) sonra `"i"` değerine 1 ekler.

`"i"` değeri her döngüde 1 artar ve 5’ten küçük olan son tamsayı olan 4’e ulaşana kadar devam eder. Döngü ne zaman biteceğini bu şekilde bilir.

Son olarak, for döngüsünün gövdesine her yinelemede çalıştırılacak kodu ekleyin. Bu örnekte şu kodu kullanırız: `console.WrightLine(i)`.

Bu, döngü her çalıştığında `"i"` değerini yazdırır. Sonuç `0, 1, 2, 3 ve 4` olur.

---

## 🧮 Array ile For Loop Kullanımı

Bir sonraki örnekte, programlamada yaygın olarak kullanılan bir liste türü olan *array* (dizi) ile çalışacağız.

Bir  *array* , öğe listesini temsil etmek için kullanılan sıralı (ordered) bir değer listesidir. C# kullanarak bir array’in temel yapısını inceleyelim.

Bir sayı dizimiz olduğunu ve toplamını hesaplamak istediğimizi varsayalım. Döngü, dizi boyunca yineleyerek (iterate), her sayıyı toplama ekler.

Bunu göstermek için, `"numbers"` adlı bir array’imiz olduğunu ve içinde `one, two, three, four, five` değerlerinin bulunduğunu hayal edin.

C#’ta bu diziyi tanımlamak için veri tipiyle başlarız. Bu örnekte veri tipi tamsayıdır. `"int"` anahtar sözcüğünü ve ardından boş köşeli parantezleri kullanırız.

Sonra dizi adı `"numbers"` eklenir ve ardından eşittir işareti gelir.

Eşittir işaretinden sonra, dizide saklanacak öğe listesini süslü parantezler içinde ekleriz ve noktalı virgülle bitiririz.

---

## ➕ Sum Değişkeni ve Döngü Mantığı

Sonraki adımda, döngü dizinin değerleri boyunca ilerlerken toplamı saklayacak bir değişken tanımlamamız gerekir.

Bu örnekte değişkene `"sum"` adını vereceğiz ve for döngüsüne başlamadan önce sıfıra başlatacağız. Aksi takdirde program her yinelemede toplamı yeniden başlatır.

Şimdi, önceki yapıdan yararlanarak for döngüsünü kuralım.

Bu örnekte:

* Yineleyici (iterator) yani `"i"` değişkenini 0’a başlatırız.
* Her yinelemenin işlenmesi için koşulu belirtiriz.
* Koşul: yineleyicinin dizideki eleman sayısından küçük olmasıdır.
* Dizideki öğe sayısını almak için `numbers.Length` kullanırız.
* Her yinelemeden sonra `"i"` değerini `"i++"` ile 1 artırırız.

Ardından, her döngü yinelemesi için eylemi belirlemek üzere gövdeye çalıştırılacak kodu yazarız.

Bizim örneğimizde, yineleyicinin `"i"` değeriyle gösterdiği konumdaki değeri birikmiş toplama ekleriz.

Başlangıçta `"sum"` sıfırdır. Döngü gövdesi her çalıştığında diziden bir değer eklenir.

* İlk döngü: `0 + 1 = 1`
* İkinci döngü: yeni `"sum"` değeri olan `1`, dizideki sonraki değerle toplanır.

Döngü ilerledikçe şu şekilde olur: `1 + 2 = 3`

Bu işlem dizideki tüm değerler için tekrarlanır ve nihai sonuç `fifteen` olur.

---

## ✅ Video Özeti

Bu videoda, *for döngülerinin* amacı ve sözdizimini açıklamayı öğrendiniz. Buna, for döngüsünün yapısını gösteren örnekler ve dizilerle (arrays) nasıl kullanılabileceğini gösteren örnekler dahildir.

For döngüleri, tekrarlayan görevleri otomatikleştirmek ve büyük miktarda veriyi verimli şekilde işlemek için güçlü araçlar olabilir.

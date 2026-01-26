## 🧾 Farklı Veri Türlerini Bildirme

Bir hesaplama yapmaya çalıştığınızı ama sayılarınızın doğru toplanmadığını hayal edin. Daha yakından bakıyorsunuz ve problemi fark ediyorsunuz. Sayı olduğunu düşündüğünüz şeyler aslında metin olarak işleniyordu. Programlamada veri türleri yanlış kullanıldığında olan şey budur. Veri türlerinin gücü, bilgiyi doğru formatta saklayabilmelerinde yatar; bu da doğru hesaplamaları ve verimli işlemleri mümkün kılar. Onlar olmadan, en basit görevler bile kafa karıştırıcı sonuçlara ve beklenmeyen hatalara yol açabilir.

Bu videoda, C#’ta farklı veri türlerine sahip değişkenler bildireceğiz.

Değişkenler veriyi tutar ve veri; sayılar, metin ve doğru/yanlış değerleri gibi çeşitli formatlarda veya türlerde gelir. Değişkenleri belirli bir türde veri tutacak şekilde veya herhangi bir türde veri tutabilecek şekilde bildirebilirsiniz.

Şimdi, C#’ın değişkenleri nasıl ele aldığına bakalım. C#’ta değişkenleri, yalnızca belirli bir veri türünü tutabilecek şekilde bildirirsiniz. C# gibi değişkenlerin belirli bir türle bildirilmesini gerektiren dillere **"type safe"** denir; çünkü programcı değişken türünün her zaman ne olacağını bilir. Başka bir deyişle, tür bir kez bildirildiğinde güvenlidir. Örneğin bir değişkeni *string* olarak bildirirseniz, program değişkenin içerdiği veriyi metin olarak işler.

C#’ta yaygın veri türleri  *integer* ,  *double* ,  *string* , *Boolean* ve  *array* ’dir. Her tür, belirli bir anahtar kelime kullanır.

Buna karşılık JavaScript gevşek türlenen ( *loosely typed* ) bir programlama dilidir. JavaScript’te değişkenler herhangi bir veri türünü tutabilir ve program, uygulama çalıştığında değişkenin hangi türde veri tuttuğunu belirler.

Bir değişken bildirmek için geliştiriciler belirli bir söz dizimi ( *syntax* ) kullanır.  *Syntax* , bir programlama dilinde öğelerin yapısını ve düzenini tanımlayan kurallar bütünüdür. Dili oluşturan “kelime dağarcığıdır”.

Şimdi, geliştiricilerin farklı programlama dillerinde değişken bildirmek için kullandıkları söz dizimini inceleyelim.

Öncelikle bir değişken bildirmek, programın hangi türde veri saklayacağını belirten **"string"** gibi bir tür anahtar kelimesiyle başlar. Ardından tür anahtar kelimesini değişken adı, eşittir işareti ve değişkenin saklayacağı değer takip eder.

JavaScript’te bildirilen bir değişken herhangi bir türde değer tutabildiği için, herhangi bir değişkeni bildirirken genel tür anahtar kelimesi olan **"var"** kullanılabilir.

Şimdi farklı türlerde değişken bildirimlerine ait bazı örnekleri inceleyelim.

---

## 🔢 Sayısal Veri Tutan Değişkenleri Bildirme

C#’ta *integer* değişkenleri **"int"** anahtar kelimesiyle bildirilir. Diyelim ki bir kişinin yaşını temsil eden sayıyı saklayan **"age"** adlı bir değişken oluşturmak istiyorsunuz.

Bu değişkenin başlangıç değerini 25 yapmak istiyorsunuz. C#’ta kodu şöyle yazarsınız:

```csharp
int age = 25
```

JavaScript’te bildirimi şöyle yazabilirsiniz:

```javascript
var age = 25;
```

C#’ta *double* değişkenler **double** anahtar kelimesiyle bildirilir. *Double* değişkenler ondalık içeren sayısal veriyi tutar.

Örneğin, sıcaklık verisini tutmak için **"temp"** adlı bir değişken bildirmek istiyorsanız, C#’ta şöyle yazarsınız:

```csharp
double temperature = 36.6;
```

*int* bildirimine benzer şekilde, JavaScript’te değişkeni şöyle bildirirsiniz:

```javascript
var temperature = 36.6;
```

Önceki örnekler, sayısal veri tutan değişkenleri nasıl bildirebileceğinizi gösterdi. Şimdi metin verisi ve doğru/yanlış değerleri gibi diğer türde verileri tutan değişkenlerin nasıl bildirildiğini inceleyelim.

---

## 📝 Metin ve Doğru/Yanlış Değerleri Tutan Değişkenleri Bildirme

*String* değişkenler metin verisini tutar. C#’ta *string* değişken bildirme söz dizimi **"string"** anahtar kelimesini kullanır.

**"Alice"** değerini tutan **"name"** adlı bir değişkeni *string* olarak bildirmek için kodu şöyle yazarsınız:

```csharp
string name = "Alice"
```

JavaScript’te bir *string* değişken bildiriminin örneği:

```javascript
var name = "Alice";
```

Her iki dilde de değişkene atadığınız verinin tırnak içinde olduğuna dikkat edin. Bu, herhangi bir programlama dilinde *string* değişken bildirirken gereklidir.

Bir sonraki tür olan *Boolean* değişkenler, C#’ta **bool** anahtar kelimesiyle bildirilir. *Boolean* değişkenler **true** ve **false** değerlerini saklar.

Örneğin, **"isStudent"** adlı bir değişkeni C#’ta *Boolean* olarak bildirmek için şu söz dizimini kullanırsınız:

```csharp
bool isStudent = true;
```

JavaScript’te ise şöyle bildirebilirsiniz:

```javascript
var isStudent = true;
```

Şimdiye kadar tek bir değer tutan değişkenleri nasıl bildireceğimizi inceledik. Değer değişebilir, ancak aynı anda yalnızca bir değer vardır.

Programlama dillerinde, aynı anda birden fazla değer saklayabilen **arrays** adı verilen bir tür vardır. Bir  *array* , genellikle aynı türde olan değerlerin sıralı bir koleksiyonunu saklayan bir veri yapısıdır.

Şimdi hem C# hem de JavaScript’te bir diziyi ( *array* ) nasıl bildireceğimizi inceleyelim.

---

## 🧺 Dizileri (Arrays) Bildirme

C#’ta diziler, veri türünden sonra köşeli parantezler **[]** kullanılarak ve değerler süslü parantezlerin **{}** içine yazılarak bildirilir.

Tam sayı değerlerinden oluşan bir koleksiyon için bir dizi şöyle yazılır:

```csharp
int[] numbers = {1, 2, 3, 4, 5};
```

JavaScript’te bu dizi şöyle bildirilir:

```javascript
var numbers = [1, 2, 3, 4, 5];
```

JavaScript’te dizi bildirimi, **var** tür anahtar kelimesinden sonra **[]** gerektirmez; ancak değerlerin etrafında köşeli parantezler kullanır.

---

## ✅ Özet

Özetlemek gerekirse, C# *type-safe* bir dildir; açık veri türü bildirimleri gerektirir; bu da hassasiyet sağlar ve hataları azaltır. Örneğin, sayılar yanlışlıkla metin olarak ele alınamaz.

Buna karşılık JavaScript dinamiktir; değişkenlerin herhangi bir türde veri tutmasına izin verir; ancak bu durum hata riskini artırabilir.

Bu farkları anlamak, her dilde daha güvenilir kod yazmanıza yardımcı olur.

Bu videoda, C#’ta çeşitli türlerde değişkenlerin nasıl bildirileceğini ve bunları JavaScript ile karşılaştırmayı öğrendiniz. Ayrıca her iki dilde de dizilerin ( *arrays* ) nasıl bildirileceğini ele aldınız.

Değişken bildirimi, programlamanın temelidir ve verinin doğru şekilde saklanmasını ve işlenmesini sağlar.

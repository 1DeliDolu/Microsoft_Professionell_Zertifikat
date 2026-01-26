## 🧩 Syntax of Methods

Sözdizimini ( *syntax* ) anlamak her programcı için kritiktir. Bu, açık ve hatasız kod yazmanızı sağlayan temeldir. C# metotlarının sözdizimini kavramak, onların tüm potansiyelini ortaya çıkarmanın anahtarıdır.

Bu videoda, C#’ta metotların sözdizimini açıklayacağız. C#’ta metot oluşturma sözdizimi birkaç temel bileşenden oluşur:  *access modifiers* ,  *return type* , *method name* ve  *parameters* . Bu kavramları gözden geçirelim.

---

## 🔐 Access Modifiers

C#’ta  *access modifiers* , bir metodun erişilebilirliğini tanımlayan anahtar kelimelerdir; örneğin  **public** ,  **private** , **protected** ve  **internal** .

Access modifier’ları, metodun kimler tarafından erişilebileceğini belirlemek için güvenlik seviyeleri gibi kullanın. Örneğin **public** bir modifier, diğer herhangi bir kodun metoda erişebileceği anlamına gelir. **private** bir modifier ise yalnızca sınıfın kendisinin metoda erişebileceği anlamına gelir.

---

## ↩️ Return Type

Metotlar, fonksiyonlar gibi değer alabilir; ancak onları çağıran koda değer döndürürler. Metodun döndürdüğü değerin bir türü vardır ve bu tür, döndürülebilecek değeri sınırlar. Şimdi bunu inceleyelim.

 *Return type* , metodun döndürdüğü değerin veri türünü belirtir.

Örneğin, metot bir isim döndürüyorsa dönüş türü **string** olur. Bir tam sayı döndürüyorsa dönüş türü **int** olur. Metot bir değer döndürmüyorsa dönüş türü  **void** ’dur.

---

## 🏷️ Method Name

Her metodun ayrıca bir adı olmalıdır. Genellikle, bir metodun adı metodun ne yaptığına dair bilgi verir. Şimdi bir metot tanımlarken metod adının nasıl işlediğini inceleyelim.

 *Method name* , programlamada bir metodu adlandırmak için kullanılan tanımlayıcıdır. Bu, geliştiricilerin kod içinde belirli metodu referans almasına ve çağırmasına olanak tanıyan benzersiz bir etikettir.

Geliştiriciler, metotları ne yaptıklarını açıklayan şekilde adlandırma en iyi uygulamasını takip etmelidir. Örneğin **"capitalizeFirstName"** adlı bir metot,  **"Method001"** ’den çok daha açıklayıcıdır.

---

## 📥 Parameters

Şimdi metotların veri almak için kullandığı parametreleri inceleyelim.

 *Parameters* , metodun kabul ettiği giriş değerleridir. Metoda veri sağlamak için metoda geçirilen değişkenlerdir ve metot adından sonra parantez içinde yer alırlar.

---

## 🧾 Member Variables

Son olarak, bir nesnenin durumunu veya özelliklerini saklayan *member variables* konusunu inceleyelim.

 *Member variables* , bir nesne veya sınıfla ilişkili değişkenlerdir. Metotlar, bir nesnenin verisini yönetmek ve onunla etkileşim kurmak için bu member variable’ları kullanır veya değiştirir.

---

## 🧱 C#’ta Temel Metot Bildirimi

Artık metotların yapısını anladığınıza göre, kavramların C#’ta temel bir metot bildirimi için nasıl uygulandığını inceleyelim.

C#’ta bir metot bildirim yapısı;  *access modifiers* ,  *return type* , *method name* ve *parameters* bileşenlerini içerir. Örneğin **AddNumbers** metodu bu temel yapıya sahiptir.

Şimdi **AddNumbers** metodunu parçalarına ayıralım.

**"public"** anahtar kelimesi access modifier’dır; yani diğer herhangi bir kod metoda erişebilir.

**"int"** anahtar kelimesi return type’tır; yani metot bir **integer** değer döndürür.

Sonra metot adını ekleriz. Bu örnekte metot adı  **"AddNumbers"** ’dır.

Yapının bir sonraki parçası parametrelerdir. Metot birden fazla parametre alıyorsa, bunlar virgülle ayrılır.

Örnekte, metodun iki adet integer parametre aldığı belirtilir: **A** ve  **B** .

Şimdi member variable’ları ekleyeceğiz.

İkisi de integer veri türündedir ve bu değişkenler için **MemberA** ve **MemberB** adlarını kullanırız. Bunları sırasıyla giriş parametreleri **A** ve **B** değerleriyle başlatırız.

Son olarak, metodun yaptığı işi tanımlayan metot gövdesini ekleriz. Burada, metodun davranışını tanımlayan ifadeleri yazarız. Örneğimizde metot, iki member variable değerini toplar ve sonucu döndürür.

---

## 🏷️ Gerçek Dünya Örneği: CalculateDiscount

Bu kavramları gerçek dünyadan bir örneğe uygulayalım. Bir üründeki indirimi hesaplamak için **CalculateDiscount** adlı bir metot oluşturacağız.

Bunu C#’ta adım adım sözdizimini parçalayarak nasıl uygulayacağımızı inceleyelim.

Önce access modifier’ı tanımlarız; örneğimizde **public** anahtar kelimesi metodu başka herhangi bir sınıftan erişilebilir yapar.

Ardından metodun return type’ını ekleriz. Bu örnekte, indirim tutarını temsil eden bir **double** döndürecektir.

Sonraki adım, metoda ad vermektir. Daha önce belirttiğimiz gibi, adını **CalculateDiscount** koyacağız.

Şimdi metot parametrelerini ekleriz.

Bizim örneğimizde, metot **double** türünde iki parametre alacaktır: **originalPrice** ve  **discountRate** .

**double** türü, ondalık basamaklar içeren bir sayıdır.

Ardından iki member variable ekleriz. **origPrice** üye değişkeni, **originalPrice** değeriyle başlatılan bir **double** değişkendir. **discRate** üye değişkeni de **discountRate** değeriyle başlatılan bir **double** değişkendir.

Son olarak, metodun davranışını gövdesinde tanımlarız. Bu örnekte metot, **origPrice** ile **discRate** değerlerini çarpacak ve sonucu döndürecektir.

Bu **CalculateDiscount** metodu, bir metodun sahip olması gereken tüm bileşenlere sahiptir: bir access modifier’a sahiptir, açıklayıcı bir adı vardır, bir return type’ı vardır, giriş parametreleri vardır ve bu parametreler üzerinde çalışarak bir değer döndürür.

Bu, C#’ta yazabileceğiniz herhangi bir metot için temel bir şablondur.

---

## 🎯 Özet

Bu videoda, C#’ta metotların sözdizimi ve yapısı hakkında bilgi edindiniz. Bu temellerde ustalaşarak, kendi metotlarınızı oluşturabilir ve çeşitli uygulama görevlerini gerçekleştirebilirsiniz.

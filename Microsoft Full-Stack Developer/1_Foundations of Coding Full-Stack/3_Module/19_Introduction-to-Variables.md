## 📦 Değişkenlere Giriş

Bilgisayar programlarının bir müşterinin adı ve hesap numarası ya da bir şeyin satın alındığı tarih gibi bilgileri nasıl hatırladığını hiç merak ettiniz mi? Benim iş takvimim doğum günümü hatırlıyor. Bunu nasıl yapıyor? Bu, bir geliştirici olarak yolculuğunuz boyunca kullanacağınız en temel programlama araçlarından biri olan değişkenlerin kullanımıyla gerçekleşir.

Bu videoda, değişkenlerin ne olduğunu ve programlamadaki rollerini tanımlayacağız.

Değişkenler bilgisayar kodunda, programcıların bir programın çalışması sırasında veriyi saklamasına, geri çağırmasına ve manipüle etmesine olanak tanıyan; bellekte veriyi saklamak için kullanılan adlandırılmış depolama konumlarıdır. Örneğin, bir kullanıcının yaşını, bir ürün fiyatını veya başka herhangi bir veri parçasını bir değişkende saklayabilirsiniz; bu da bu bilgiyi daha sonra kullanmayı kolaylaştırır.

Değişkenler, verilerinin daha sonra kolayca geri çağrılabilmesi için anlamlı adlandırma kurallarıyla uygun şekilde isimlendirilmeli veya etiketlenmelidir. Şimdi değişken adlandırmaya yönelik bazı en iyi uygulamaları ele alalım.

---

## 🏷️ Değişken Adlandırma İçin En İyi Uygulamalar

Değişken adlandırmada en iyi uygulamalardan biri açıklayıcı isimler kullanmaktır. Değişkenin amacını açıklayan isimler seçmek önemlidir. Örneğin,  *age* , *total price* veya *user name* gibi isimler açıklayıcıdır ve kodun anlaşılmasını kolaylaştırır.  *A* , *B* veya *X* gibi tek harfli isimlerden kaçının.

Değişken adlandırmada bir diğer en iyi uygulama adlandırma kurallarını takip etmektir. Örneğin C#’ta değişken adları için *camelCase* kullanmak yaygın bir uygulamadır. Bu, küçük harfle başlamak ve sonraki her kelimenin ilk harfini büyük yapmak anlamına gelir; örneğin  *userAge* , *totalAmount* ve  *firstName* .

*camelCase* kullanırken kelimeler boşluk, tire veya alt çizgi olmadan bitişik yazılır. Örneğin,  *userAge* , *totalAmount* ve *firstName* *camelCase* kuralını takip eder.

Değişken adlandırmada bir diğer en iyi uygulama da kapsamı ( *scope* ) dikkate almaktır. Bir değişkenin kapsamı, kod içinde nereden erişilebildiğini ifade eder. Uygun kapsamla birlikte anlamlı isimler kullanın.

İşte global ve local kapsam için basit bir örnek. Bir okulu düşünün: müdür tüm okul için kararlar alabilen global bir figürdür; bu nedenle her yerden erişilebilir, yani global kapsam. Şimdi, bir sınıfın içinde öğretmen yalnızca o belirli sınıftan sorumludur; local kapsam ve yalnızca o sınıf içinde kararlar verebilir. Müdür tüm okulu etkileyebilir, ancak öğretmenin etkisi sınıfla sınırlıdır.

Kodlama terimleriyle, global bir değişken müdür gibidir. Programın her yerinden erişilebilir. Local bir değişken öğretmen gibidir; yalnızca belirli bir fonksiyon veya kod bölümünde erişilebilir.

---

## 🧩 Değişkenleri Oluşturma ve Bildirme

Artık değişkenlerin ne olduğunu ve onları adlandırmak için bazı yaygın en iyi uygulamaları anladığınıza göre, onları nasıl oluşturacağımızı açıklayalım.

Programlamada bu süreci tanımlamak için “declare” terimini kullanırız; örneğin: “let's declare a variable”.

C# programlama dilini kullanarak bazı örnekleri tamamlayalım.

Bir yaş değerini saklamak için bir tamsayı değişkeni bildirmek şöyle olabilir:

```csharp
int age = 25;
```

**INT** veya **int** kısmı  *integer* ’ın kısaltmasıdır ve programa bildirilen değişkenin bir *integer* veri türü olduğunu söyler; **age** ise değişken adıdır. Kod boyunca bu değişkene bu adla referans vereceğiz.

Ardından, değişkene başlangıç değeri atamak için eşittir işaretini kullanırız ve C#’ta satırın bittiğini belirtmek için noktalı virgül kullanırız.

Bu nedenle, bu kod satırıyla **age** değişkenini 25 değerine sahip bir *integer* olarak oluşturduk veya bildirdik.

Şimdi farklı veri türlerine sahip değişkenleri göstermek için birkaç örnek daha inceleyelim.

---

## 🔢 Farklı Veri Türleriyle Değişken Örnekleri

Son örnekteki *age* değişkenimiz, değeri 25 olan bir  *integer* ’dır; yani bir tam sayıdır. Bu, tam sayılarla çalışırken uygundur. Peki ya bir ürün fiyatı gibi ondalık bir değer olabilecek bir değişken istiyorsak? O zaman *double* adı verilen bir veri türünü kullanmamız gerekir.

Bir ürünün fiyatını saklamak için *double* değişkeni bildirmek:

```csharp
double price = 19.99;
```

Bu kod satırıyla, **price** değişkeninin veri türünün *double* olduğunu ve değerinin 19.99 olduğunu bildirdik.

Şimdi, bir kişinin adı gibi metin saklayan bir değişken istiyorsak ne olur? Bunun için *string* veri türünü kullanacağız; C# ile bir kullanıcının adını saklamak için bir *string* değişkeni bildiririz:

```csharp
String userName = "John Doe";
```

Bu kod satırıyla, **user name** değişkeninin *string* veri türüne sahip olduğunu ve değerinin John Doe olduğunu bildirdik. John Doe etrafındaki tırnaklara dikkat edin. Bu, *string* veri türü kullanırken gereklidir.

Son olarak, *Boolean* veri türü vardır. Bu veri türünün değişken için yalnızca iki olası değeri vardır: **true** veya  **false** .

C# kullanarak bu tür bir değişkenin nasıl bildirileceğini göstermek için bir örnek kullanalım:

```csharp
bool isStudent = true;
```

Bu kod satırıyla, **isStudent** değişkeninin veri türünün *bool* (Boolean’ın kısaltması) olduğunu ve değerinin true olduğunu bildirdik.

---

## ✅ Kapanış

Bu videoda, değişkenleri ve programlamadaki rollerini öğrendiniz. Ayrıca değişkenleri adlandırmak için bazı en iyi uygulamaları ve C# programlama dili kullanarak onları nasıl bildireceğinizi öğrendiniz.

Değişkenleri etkili şekilde kullanmayı anlamak, kod yazmanın kritik bir parçasıdır. Bir geliştirici olma yolculuğunuzda ilerledikçe bu bilginin üzerine inşa edeceksiniz.

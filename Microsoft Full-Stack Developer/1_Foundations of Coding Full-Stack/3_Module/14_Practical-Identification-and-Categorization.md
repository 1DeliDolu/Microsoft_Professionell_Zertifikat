## 🍎 Pratik Tanımlama ve Kategorize Etme

Bir meyve dükkanında çalıştığınızı ve her bir meyveye fiyat etiketi koyup müşterilerin bulabilmesi için raflara yerleştirmekle görevlendirildiğinizi hayal edin. Bunu yapmak için, her bir meyvenin hangi tür meyve olduğunu tanımlayabilmeniz gerekir; böylece mağazada nereye koyacağınızı ve hangi fiyatı belirleyeceğinizi bilirsiniz. Meyveler yanlış yere konursa veya kendi fiyatları olursa, müşteriler onları bulamaz ya da çok fazla veya çok az öderler.

Bunu programlamada da yapmamız gerekir. Değişkenleri programımızda doğru şekilde çalıştıklarından emin olmak için tanımlamalı ve kategorize etmeliyiz.

Bu videoda, örnekler ve alıştırmalar aracılığıyla farklı veri türlerini tanımlayacak ve kategorize edeceğiz.

Veri türlerini kategorize etmek için şu dört adımı izleyeceğiz:  **Adım 1 veri türlerini tanımlamak** ;  **Adım 2 veri türü uyumluluğunu kontrol etmek** ;  **Adım 3 veri türlerini dönüştürmek** ; ve  **Adım 4 dönüşümü doğrulamak** .

Şimdi bu adımların her birini daha yakından inceleyelim.

---

## 1️⃣ Veri Türlerini Tanımlama

 **Adım 1: Veri Türlerini Tanımlama** , veri türlerini belirlemek için programlama dili fonksiyonlarını kullanır. Örneğin, değişkenin ne tür olduğunu sorarak değişkeni tanımlayabilirsiniz. Bu, farklı meyveler sunan bir tezgahtan bir elma seçmenize benzer.

Bunu yapmak için **"GetType"** fonksiyonunu kullanacaksınız.

*"Function"* terimi sizin için yeni olabilir, bu yüzden onu tanımlayalım. Programlamada bir fonksiyon, girdi alan, bunu işleyen ve bir çıktı döndüren bir kod bloğudur.

Örneğin, **"GetType"** fonksiyonu bir değişkeni alır, değişkenin hangi veri türü olduğunu işler ve ardından veri türünü çıktı olarak verir.

C#’ta, değişkenimizi bildirerek başlayalım:

***string myVariable equals "This fruit is an apple";***

Şimdi **GetType** fonksiyonunu kullanarak **"myVariable"** değişkeninin veri türünü bulabiliriz. Bu fonksiyonu, **"Type"** adı verilen yeni bir türle yazarız.

 **"Type"** , C#’ta bir nesnenin veya değişkenin türünü temsil etmek için kullanılır. Bu örnekte, **"myVariable"** adlı değişkendir.

Ayrıca, GetType fonksiyonunun bize döndürdüğü Type sonucunu saklamak için bir değişkene ihtiyacımız var; bu yüzden **"dataType"** adlı değişkeni kullanalım.

Fonksiyon şu şekilde okunur:

***Type DataType equals myVariable GetType();***

Bu, bilgisayardan **"myVariable"** değişkeninin veri türünü kontrol etmesini ve sonucu **"dataType"** değişkeninde saklamasını ister.

Ardından, bilgisayardan **"dataType"** değerini konsola yazdırmasını şu satırla isteriz:

***Console.WriteLine(dataType);***

Konsolda **"System.String"** sonucunu alırız.

---

## 2️⃣ Veri Türü Uyumluluğunu Kontrol Etme

Veri türü belirlendikten sonra  **Adım 2** , uyumluluğunu kontrol etmektir. Fonksiyon, bağlama göre veri türünün dönüştürülmesi gerektiğini belirler. Bir değişkenin türünü beklenen türle karşılaştırmak için koşullu ifadeler kullanır.

**"myVariable.GetType()"** fonksiyonu veri türünü belirler. Fonksiyon, türe bağlı olarak belirli eylemler gerçekleştirir veya mesajlar yazdırır. Bu yaklaşım, değişkenin türünün beklenen işlemlerle uyumlu olmasını sağlar.

C#’ta bir örnek: 123 değeri bir tamsayıdır. **"myVariable"** adlı bir değişken bildiriyoruz; ancak *int* veya *string* gibi somut bir veri türü belirtmek yerine **object** türünü kullanıyoruz.

C#’ta **object** en genel türdür. Sayılar, metin veya hatta karmaşık nesneler dahil olmak üzere her tür veriyi tutabilir. **object** kullanarak, **myVariable** değişkeninin potansiyel olarak herhangi bir tür değeri tutmasına izin vermiş oluyoruz.

 **myVariable** ’a 123 değerini atıyoruz. 123 teknik olarak bir tamsayıdır; ancak şu anda  **myVariable** , içinde bir tamsayı bulunan bir object’tir.

 **myVariable** ’ın türünü kontrol etmek için bir **If Statement** kullanıyoruz. **GetType()** metodu **myVariable** üzerinde çağrılır ve içinde depolanan değerin gerçek veri türünü döndürür.

 **typeof(int)** , C#’ta *int* türünü temsil eder. Bu satır,  **myVariable** ’ın gerçek türünün (GetType() ile elde edilen) *int* türüyle aynı olup olmadığını karşılaştırır.

Eğer **myVariable** bir tamsayı içeriyorsa, bu karşılaştırma doğru olur ve if bloğunun içindeki kod çalışır. Başka bir tür içeriyorsa, else bloğundaki kod çalışır.

**myVariable** gerçekten bir tamsayıysa, program ilk **Console.WriteLine()** ifadesini çalıştırır. **"The variable 123 is an integer."** mesajını yazdırır.

**$"{myVariable}"** söz dizimi, **myVariable** değerini doğrudan metnin içine yerleştirir. Eğer **myVariable** 123 ise mesaj **"The variable 123 is an integer"** olur.

Eğer **myVariable** bir tamsayı değilse, program ikinci **Console.WriteLine()** ifadesini çalıştırır ve **"The variable 123 is not an integer"** yazdırır.

Veri türü uyumluluğunu kontrol etmeyi özetlemek gerekirse: bir değişken ( **myVariable** ) bildirin ve ona bir değer atayın. Bu örnekte, 123 bir object olarak saklanır.  **myVariable** ’ın gerçek türünü kontrol edin.

Eğer bir tamsayıysa, tamsayı olduğunu belirten bir mesaj yazdırın. Aksi halde tamsayı olmadığını söyleyen bir mesaj yazdırın.

Koşula göre çıktı, tür karşılaştırmasının sonucu olmalı; ardından uygun mesaj konsola yazdırılmalıdır.

Bu kod, C#’ta tür kontrolünün nasıl çalıştığını gösteren basit ama güçlü bir örnektir. Bir değişken genel bir object olarak bildirilse bile, tuttuğu gerçek veri türünü inceleyip buna göre tepki verebileceğinizi gösterir.

Bu, C#’ı hem esnek hem de type safe yapar.

Bir sonraki adım  **Adım 3: Veri Türlerini Dönüştürme** ’dir.

---

## 3️⃣ Veri Türlerini Dönüştürme

 **Adım 3** , program değişkeni belirledikten ve başka bir veri türüyle uyumluluğunu kontrol ettikten sonra gerçekleşir.

**int.Parse** fonksiyonu bir değişkeni girdi olarak alır. Değişkeni istenen veri türüne dönüştürür ve dönüştürülen değeri döndürür. Hedef tür desteklenmiyorsa hata üretir.

C#’ta bir örnek: değişken **"123"** olarak temsil edilen bir string’tir ve bir tamsayı olan 123’e dönüştürülür.

Bu örnekte, **myVariable** adlı bir değişken bildiriyor ve ona **"123"** string değerini atıyoruz. **"123"** tırnak içinde olduğuna dikkat edin; bu,  **myVariable** ’ın aslında bir string olduğu anlamına gelir.

Bu da değişkenin bir sayı değil, metin olarak işlendiği anlamına gelir. String **"123"** sayı gibi görünse de, şu anda sadece karakter dizisidir; aritmetik işlemler yapabileceğiniz bir sayı değildir.

String  **"123"** ’ü **int.Parse()** metodunu kullanarak bir tamsayıya dönüştürüyoruz.  **int.Parse()** , bir string’i girdi olarak alan ve string geçerli bir sayı ifade ediyorsa onu bir tamsayıya dönüştüren bir metottur.

String sayısal olmayan bir karakter içeriyorsa veya geçerli bir sayı değilse, bu metot hata fırlatır.

Bu dönüşümden sonra  **number** , string versiyonu 123 değil, tamsayı değeri 123’ü tutar. Bu, gerekiyorsa number ile sayısal işlemler yapmanızı sağlar.

String’i tamsayıya dönüştürmek, kullanıcı girdisiyle veya metin olarak gelen ama programınızda sayı olarak ele alınması gereken verilerle çalışırken faydalıdır.

Bu satır, **number** değerini konsola yazdırır. Çıktı 123 olur; ancak artık metin olarak değil, tamsayı olarak yazdırılır.

Bu, daha sonra bu değişken üzerinde matematik işlemleri yapmak isterseniz bunu yapabileceğiniz anlamına gelir.

Özetlemek gerekirse, sayı gibi görünen ama aslında metin olan bir string ile başlarız; bu örnekte  **"123"** . String’i **int.Parse()** kullanarak tamsayıya dönüştürürüz; string  **"123"** , tamsayı  **123** ’e dönüşür.

Son olarak, dönüşümün başarılı olduğunu göstermek için tamsayı değeri konsola yazdırılır.

Son adım  **Adım 4: Dönüşümü Doğrulama** ’dır.

---

## 4️⃣ Dönüşümü Doğrulama

Bir fonksiyon, dönüşümün başarılı olup olmadığını kontrol ederek ve dönüşüm sürecinde oluşabilecek hataları yöneterek veri türü dönüşümünü doğrulayabilir.

**myVariable** adlı bir değişken bildirir ve ona string olarak **"123"** değerini atarız.

 **int.TryParse()** , bir string’i tamsayıya dönüştürmeyi deneyen bir metottur.  **int.Parse()** ’tan farklı olarak, dönüşüm başarısız olursa hata vermek yerine bir Boolean değer döndürür: dönüşüm başarılıysa  **true** , değilse  **false** .

Bu fonksiyonda yerleşik parametreler vardır. İlk parametre, dönüştürmeye çalıştığımız string olan  **myVariable** ’dır. İkinci parametre  **out int number** , dönüşüm başarılı olursa dönüştürülen tamsayının saklanacağı yerdir.

**out** anahtar sözcüğü, metodun bu değeri çağırana geri göndermesine izin verir.

Kod,  **int.TryParse()** ’ın  **myVariable** ’ı başarıyla bir tamsayıya dönüştürüp dönüştürmediğini kontrol eder. Dönüştürürse, değer **number** içinde saklanır ve koşul true olarak değerlendirilir; böylece if bloğundaki kod çalışır.

Dönüşüm başarısız olursa, koşul false olur ve else bloğundaki kod çalışır.

Dönüşüm başarılıysa, program ilk **Console.WriteLine()** ifadesini çalıştırır ve **"Conversion successful"** mesajını dönüştürülmüş tamsayı değeriyle birlikte yazdırır.

Süslü parantezler  **{}** , koşul doğru olduğunda çalışacak birden fazla kod satırını gruplamamıza olanak tanır.

Örneğin: Eğer **myVariable** **"123"** ise, **int.TryParse()** bunu başarıyla dönüştürür ve çıktı **Conversion Successful: 123** olur.

Eğer dönüşüm başarısız olursa (örneğin **myVariable** "123" yerine **"abc"** içeriyorsa), program ikinci **Console.WriteLine()** ifadesini çalıştırır ve **"Conversion failed"** yazdırır.

Bu, kullanıcıya string’in bir tamsayıya dönüştürülemediğini bildirir.

Fonksiyonun veri dönüşümünü nasıl doğruladığını kısaca özetleyelim. Sayı gibi görünen ama aslında metin olan bir string **"123"** ile başladık.

**int.TryParse()** kullanarak string’i tamsayıya dönüştürmeyi denedik: Program string’i tamsayıya çevirmeye çalıştı ve başarılı olursa sonucu bir number değişkeninde sakladı.

Başarılıysa konsol, dönüştürülmüş tamsayı değeriyle birlikte bir mesaj yazdırır. Başarısızsa konsol, dönüşümün başarısız olduğunu söyleyen bir mesaj yazdırır.

---

## ✅ Kapanış

Bu videoda, örnekler ve alıştırmalar aracılığıyla farklı veri türlerini nasıl tanımlayacağınızı ve kategorize edeceğinizi öğrendiniz.

Veri türlerini tanımlama ve dönüştürme konusunda ustalaşarak, programlarınızda hata oluşma olasılığını azaltabilir ve programlarınızın tasarlandığı gibi çalışmasını sağlayabilirsiniz.

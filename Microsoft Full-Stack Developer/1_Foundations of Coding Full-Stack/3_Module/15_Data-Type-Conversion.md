## 🔄 Veri Türü Dönüştürme

Verilerle ve programlamayla çalışmak birçok biçimde olabilir. Peki ya üzerinde çalıştığınız veri doğru formatta değilse ne olur? İşte burada, veri türleri arasında dönüştürme yapmayı anlamak; birbirleriyle çalışabilen sistemler oluşturmanıza yardımcı olabilir. Bu videoda, programlamada veri türleri arasında nasıl dönüştürme yapıldığını inceleyeceğiz.

Veri türü dönüştürmeyi tanımlayarak başlayalım. Veri türü dönüştürme, bir değişkende saklanan veriyi bir türden başka bir türe dönüştürme sürecidir; örneğin bir değişkeni  *string* ’den  *integer* ’a dönüştürmek gibi. Veri türü dönüştürme, işlemler veya fonksiyonlar belirli veri türleri gerektirdiğinde gereklidir.

Veri türü dönüştürmenin iki türü vardır. Her iki türü de inceleyelim ve örtük ( *implicit* ) dönüştürme ile başlayalım.

---

## 🧩 Örtük Dönüştürme

Örtük dönüştürme, geliştiriciden özel talimatlar olmadan veri türlerinin program tarafından otomatik olarak dönüştürülmesidir.

Örneğin, *num1* adlı bir değişkeni değeri 5 olan bir *int* olarak bildirirsek ve *num2* adlı bir değişkeni değeri 3.14 olan bir *double* olarak bildirirsek; ardından *result* adlı bir *double* değişkeni oluşturup bunu *num1* ile  *num2* ’nin toplamına eşitlersek, program iki farklı veri türünü toplaması istendiği için örtük dönüştürme yapacaktır.

Program, tamsayıyı otomatik olarak  *double* ’a dönüştürür.

Bu durumda, eğer değeri konsola yazdırırsak, sonuç *double* veri türünde 8.14 olacaktır.

Birçok durumda, veri dönüşümünü programa bırakmak riskli olabilir; çünkü veri, geliştiricinin beklediği şekilde dönüştürülmeyebilir. Bunun yerine geliştirici, değişkenlerin nasıl dönüştürülmesini istediğini açıkça belirlemeyi tercih edebilir. Buna açık ( *explicit* ) dönüştürme denir. Şimdi bu kavramı inceleyelim.

---

## 🛠️ Açık Dönüştürme

Açık dönüştürme, bir değeri bir veri türünden başka bir veri türüne manuel olarak dönüştürme sürecidir. Veri türlerini açıkça dönüştürmek için birkaç yöntem vardır.

En yaygın iki yöntemi ele alacağız: *casting* ve  *parsing* .

Şimdi bu programatik yöntemlerin her birini daha ayrıntılı inceleyelim ve *casting* ile başlayalım.

---

## 🎯 Casting

 *Casting* , bir değişkeni bir türden başka bir türe, istenen türü açıkça belirterek dönüştürür.

C#’ta *casting* için bir örnek, bir  *double* ’ı bir  *integer* ’a dönüştürmek olabilir.

*piVar* adlı bir değişkeni *double* olarak bildirdiğimizi varsayalım. Bu değişkeni 3.14 olan bir *double* değerle başlatıyoruz.

Ardından, *piInt* adlı başka bir değişkeni *integer* olarak bildiriyoruz. Bu değişkene *double* değişken olan  *piVar* ’ın değerini atayabilmek için,  *piVar* ’ı  *int* ’e cast etmemiz gerekir.

Bunu, *piVar* değişken adından önce parantez içinde cast etmek istediğimiz türü yazarak yaparız.

C#’ta cast şu şekilde yazılır:

***int piInt equals open parentheses, int, closed parenthesis, piVar, semicolon.***

Yeni değişken değeri konsola yazdırılır ve 3 değerini verir; bu da *integer* veri türüdür.

Şimdi, *parsing* adı verilen veri türü dönüştürme yöntemini inceleyelim.

---

## 🧾 Parsing

 *Parsing* , *string* veri türü ile kullanılır.

 *Parsing* , verinin string gösterimini yorumlamayı ve bunu *integer* gibi başka bir veri türüne dönüştürmeyi içerir.

C#’ta *parsing* için bir örnek, bir  *string* ’i bir  *integer* ’a dönüştürmek olabilir.

Değeri 1, 2, 3 olan *myString* adlı bir *string* değişkenle çalıştığımızı varsayalım. Değer 1, 2, 3 olsa bile bu sayısal veri değil, metinsel veridir. Bir *string* olduğu için matematiksel işlemlerde kullanılamaz.

 *myString* ’i bir tamsayıya dönüştürmek için onu parse edebiliriz.

Bir değişkeni parse etmek için, C# sisteminin bir parçası olan metotları kullanabilirsiniz. Bu metotlar, dönüştürmek istediğiniz değeri değerlendirir ve onu yeni türe dönüştürmeye çalışır.

 *myString* ’i bir  *integer* ’a dönüştürmek için, C# *int* türünün bir parçası olan parse metodunu kullanırız.

 *myString* ’i  *int* ’e parse etmek için kullanılan kod:

***“int.Parse(myString)”.***

Bu örnekte, string  **"123"** , parse metodu kullanılarak *integer*  **123** ’e dönüştürülür.

---

## 🏦 Veri Türü Dönüştürmenin Kullanım Alanları

Veri türü dönüştürme birçok senaryoda kullanılır.

Örneğin, bir bankacılık uygulaması web sitesinde kullanıcı girdisini *string* veri olarak kabul edebilir. Bu verinin, doğru para birimi hesaplamaları ve veritabanında saklama için *double* gibi sayısal türlere parse edilmesi gerekir.

Hesaplamalar yapılıp saklandıktan sonra, bu değerler para birimi sembolleriyle biçimlendirilerek görüntülenmesi için tekrar  *string* ’e dönüştürülür.

Bu süreç, hassasiyet, birlikte çalışabilirlik ve finansal verinin güvenilirliğini sağlar.

---

## ✅ Kapanış

Bu videoda, veri türlerini dönüştürmek için bazı yöntemler öğrendiniz. Bu tür dönüştürme yöntemlerini uygulamak, verinizin gerçekleştirmek istediğiniz görevler için doğru formatta olmasını sağlar.

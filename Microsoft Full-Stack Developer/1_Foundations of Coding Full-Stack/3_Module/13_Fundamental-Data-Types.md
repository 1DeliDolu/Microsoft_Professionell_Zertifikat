## 🧪 Temel Veri Türleri

Programlamayı bir yemek tarifi gibi düşünün; veri türleri de malzemelerinizdir. Patates, tuz ve yağ bir yemek yapmak için nasıl gerekli ise;  *integer* ,  *double* , *string* ve *Boolean* gibi veri türleri de her programın yapı taşlarıdır. Şimdi, yemek yaparken bu malzemeleri saklamak ve kullanmak için kaselere, bardaklara veya kavanozlara ihtiyaç duyduğunuzu hayal edin. İşte burada değişkenler devreye girer. Değişkenler, verilerinizi tutan kaplardır; tıpkı bir tarifte malzemeleri karıştırıp ölçüp hazırlamanız gibi, programınızı hazırlamanıza olanak tanır. Veri türleri malzemelerdir, değişkenler ise bu malzemeleri saklayan ve yöneten kaplardır.

Bu videoda, programlamada kullanılan temel veri türlerini açıklayacağız.

---

## 📦 Değişkenler ve Veri Türleri Nedir?

Öncelikle değişkenlerin ve veri türlerinin ne olduğunu tanımlayalım.

Değişkenler, bir programda veri saklamanın bir yoludur. Bunu, içine bir sayı, bir metin parçası veya doğru-yanlış değeri gibi bilgileri koyabildiğiniz etiketli bir kap gibi düşünün. Bu etiketli kap, program boyunca kullanılabilir ve değiştirilebilir.

Artık değişkenlerin ne olduğunu tanımladığımıza göre, veri türlerinin ne olduğunu tanımlayalım.

Veri türleri, programlamada bir değişkenin tutabileceği değer türlerini belirleyen veri sınıflandırmalarıdır. Veri türlerini anlamak önemlidir; çünkü veriler üzerinde hangi işlemlerin yapılabileceğini ve verinin nasıl saklanacağını belirlerler.

---

## 🔢 Dört Temel Veri Türü

Şimdi dört temel veri türünü inceleyelim:  *integers* ,  *doubles* , *strings* ve  *Booleans* . Her türün kendine özgü özellikleri ve kullanım alanları vardır; bu yüzden her birini daha ayrıntılı inceleyeceğiz ve *integers* ile başlayacağız.

---

## 🧮 Integer

 *Integers* , pozitif ve negatif tam sayıları saklar; kesir veya ondalık sayı içermez ve sayma ile aritmetik işlemler için kullanılır.

Örneğin, temel aritmetikte *integer* kullanımı sözde kodda şöyle yazılabilir:

***“Integer 5 plus integer 10 equals 15.”***

Temel anlamıyla bu:

***5+10=15***

*Integer* veri türü yalnızca tam sayılar içindir. Peki ya ondalık değerlerimiz varsa? Daha hassas değerler için *double* veri türünü kullanırız.

---

## 📏 Double

 *Doubles* , ondalık noktasının sayının herhangi bir yerinde “yüzebildiği” için kayan noktalı sayılar olarak adlandırılır. Kesir veya ondalık gibi tam sayıdan daha yüksek hassasiyet gerektiren bir değerin saklanması gerektiğinde kullanılırlar.

Örnekler, bilimsel araştırmalarda veya finansta yapılan hesaplamalar olabilir.

*Double* ile yapılan hesaplamalara bir örnek şöyle olabilir:

***“double 7.15 times double 3.2 equals 22.88.”***

Temel anlamıyla bu:

***7.15*3.2=22.88***

*Integer* ve *double* veri türleri sayılarla çalışarak hesaplama yapmamızı sağlar; peki ya çalışmak istediğimiz diğer veri türleri?

---

## 📝 String

Sayıları temsil etmeyen karakterleri (harfler, kelimeler ve ünlem işaretleri gibi) saklamak için *string* veri türünü kullanırız.  *Strings* , metni temsil etmek için kullanılan karakter dizileridir.

Programlarınızda metinle çalışmanız gerektiğinde *strings* gereklidir; ister tek bir kelime ister bir cümle olsun.  *Strings* ; harfler, sayılar, semboller ve boşluklar içerebilir ve çoğunlukla metinsel verileri yönetmek ve işlemek için kullanılır.

*Strings* sayıları temsil eden karakterler içerebilir, ancak bunlar hesaplamalarda kullanılabilecek sayılar olarak değil, metin olarak kabul edilir.

 *Strings* , birleştirme ( *concatenation* ) gibi işlemlerle metin verisini saklamak ve işlemek için kullanılır. Bu, birden fazla metin parçasını bir araya getirmeyi içerir.

Bunu bir örnekle gösterelim. Bir örnek, *string* manipülasyonu olarak *strings* birleştirmektir. İlk adı John olarak tutacak bir değişken ayarlayın, soyadı Doe olarak tutacak başka bir değişken ayarlayın. Araya bir boşluk koyarak adı ve soyadı birleştirip tam adı oluşturun. Birleştirilmiş sonucu tam ad için bir değişkende saklayın.

***John plus a space, plus Doe equals John Doe.***

Bu örnek, tam ad **John Doe** için, ad **John** artı bir boşluk ve artı soyad **Doe** olarak okunur.

Son olarak, mantıksal işlemler için kullanılan *Boolean* veri türünü inceleyelim.

---

## ✅ Boolean

 *Booleans* , özellikle kodunuzda karar verirken kullanışlıdır; örneğin bir koşulun doğru mu yanlış mı olduğunu belirlemek gibi.  *Booleans* , veriyi **true** veya **false** olarak saklar.

Program akışını ve karar vermeyi kontrol etmek için  *and* , *or* ve *not* gibi mantıksal işlemlerle veriyi işlerler.

Artık  *Booleans* ’ın karar vermedeki önemini anladığımıza göre, bunu göstermek için bir örnek kullanalım.

Koşullarda *Booleans* kullanarak bir Boolean mantık örneği. Bir koşul ayarlayarak başlayın. Örneğin, *yağmur yağıyor mu* durumunu temsil eden bir değişkeni **false** olarak ayarlayın; bu, false olması gereken bir parametre belirler. Peki ya yağmur yağıyorsa? Program bir mesaj görüntüler: **Take an umbrella.** Aksi halde program şunu görüntüler: **enjoy the sunshine.**

---

## 🌦️ Veri Türlerini Tek Bir Uygulamada Birlikte Kullanma

Her veri türü için örneklerden geçtiğinize ve amaçlarını anladığınıza göre, şimdi birlikte nasıl çalışabileceklerini göstermek için bunları tek bir uygulamada bir araya getirelim.

Bir hava durumu uygulamasında, farklı veri türleri çeşitli bilgileri yönetmek için kullanılır:

* Sıcaklık için  *integers* : **int, temperature equals 25.**
* Nem için  *doubles* : **double humidity equals 75.5.**
* Açıklamalar için  *strings* : **string, weather description, equals sunny.**
* Uyarılar için  *Booleans* : **BoolIsStormWarning equals false.**

Bu veri türlerini uygun şekilde kullanarak uygulama, hava durumu verisini doğru biçimde temsil edebilir ve işleyebilir.

---

## 🛡️ Tip Güvenli ve Tip Güvenli Olmayan Diller

Artık dört temel veri türüne aşinasınız:  *integers* ,  *doubles* , *strings* ve  *Booleans* . Şimdi, farklı programlama dillerinin veri türlerine, veri türü kurallarını ne kadar katı veya esnek uyguladıkları açısından nasıl yaklaştığını tartışalım.

*Type-safe* ve *non-type-safe* diller kavramlarını inceleyeceğiz.

*Type-safe* diller, katı veri türü kurallarını zorunlu kılan programlama dilleridir. Veri türü kurallarının katı uygulanması, değişkenlerin tanımlı türleriyle tutarlı şekilde kullanılmasını sağlayarak hataları azaltır.

Buna karşılık, *non-type-safe* diller daha fazla esneklik sunar; ancak bunun kendine özgü zorlukları vardır.

*Non-type-safe* diller, *type-safe* dillere göre veri türü kuralları konusunda daha esnektir. Veri türü kurallarını katı şekilde zorunlu kılmadıkları için; hata ayıklaması zor hatalar gibi öngörülemez davranışlara ve potansiyel güvenlik açıklarına yol açabilirler.

*Non type safe* dillere ait avantajlar; daha hızlı geliştirme, daha fazla esneklik ve açık veri türü bildirimleri gerektirmediği için daha kısa/öz kod yazımı sunmalarıdır. Bu, onları hızlı prototipleme ve farklı veri türlerini işlemenin önemli olduğu dinamik ortamlar için ideal hâle getirir. Bu, plastik bloklarla inşa etmeye benzer. Kuralları dert etmeden istediğiniz parçayı alabilirsiniz. Hızlı inşa eder ve farklı fikirler denersiniz. Bu, *non-type-safe* bir dil kullanmak gibidir.

Bunu göstermek için, hava durumu uygulaması örneğini kullanalım.

*Type-safe* bir dil kullanırken, hava durumu uygulamanızdaki sıcaklık veya nem gibi her veri türünün katı kuralları vardır. Örneğin, hassas ihtiyaçlara bağlı olarak sıcaklığı tam sayı ya da ondalık olarak saklamanız gerekir. Nemi *float* veya *double* olarak, hava durumu açıklamalarını ise *string* olarak saklamanız gerekir. Bu kurallar, uygulamanızın doğru çalışmasını sağlar; ancak veri türlerini tam olarak doğru ayarlamanız gerektiği için sizi yavaşlatabilir. Bu, uygulamanızı daha güvenilir yapar; fakat kurulum daha uzun sürer.

*Non-type-safe* bir dil kullanırken, dilin türü otomatik olarak nasıl işleyeceğini belirlemesine izin vererek, türü belirtmeden farklı veri türlerini serbestçe karıştırabilirsiniz. Örneğin, sıcaklık için tam sayı veya ondalık, nem için tam sayı veya ondalık ve hava durumu açıklaması için *string* verisini katı kurallar olmadan birlikte kullanarak uygulamayı daha hızlı inşa edebilirsiniz. Ancak yanlış veri türlerini kullanarak hatalara neden olmamaya dikkat etmeniz gerekir.

---

## ✅ Kapanış

Bu videoda, programlamada kullanılan temel veri türlerini ve bunları etkili biçimde kullanmanın verimli ve hatasız kod yazmak için neden gerekli olduğunu açıkladık.

Veri türlerini anlamak, bir geliştirici olarak ihtiyaç duyacağınız temel yapı taşlarından biridir. Bu kurs boyunca ve çalışan bir geliştirici olarak ilerledikçe bu bilgiyi kullanmak için çok daha fazla fırsat elde edeceksiniz.

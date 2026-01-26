## 🧠 Programlamada Kullanılan Mantık Türleri

Programlamada mantıksal işlemler, bir programın karar verme sürecini yönlendirmek için doğru ( *true* ) veya yanlış ( *false* ) değerlerini işleyen  **AND** , **OR** ve **NOT** gibi operatörleri içerir. Bu operatörler, koşullu mantık geliştirmek ve bir programın akışını yönetmek için temeldir. Bu videoda, programlamada kullanılan farklı mantık türlerini belirleyecek ve açıklayacağız.

---

## ✅ Boolean Mantığı

İlk olarak, *Boolean mantığı* doğru ve yanlış değerleriyle ilgilenen mantık dalıdır. Programlar çalıştığında verileri işler, kullanıcı girdisine yanıt verir ve çalıştıkları makinedeki koşulları ele alır. Programlarda bunlar, doğru ya da yanlış olabilen bir kod satırı olan *ifadeler (expressions)* olarak temsil edilir.

Her ifade çeşitli koşullarda olabilir ve programcılar bunları işlemek için Boolean işlemlerini kullanır. Bir ifadenin doğru mu yanlış mı olduğu, onun *doğruluk değeri (truth value)* olarak adlandırılır. Boolean işlemleri, doğruluk değerlerini değerlendiren işlemlerdir.

Şimdi Boolean mantığının temel işlemlerini ve programlamada nasıl kullanıldıklarını inceleyelim; **AND** operatörüyle başlayalım.

---

## 🔗 AND Operatörü

**AND** operatörü iki ifadeyi değerlendirir. Değerlendirme sonucu, yalnızca **her iki ifade de doğruysa** doğrudur. İfadelerden biri yanlışsa veya her ikisi de yanlışsa, değerlendirme sonucu yanlıştır.

Bir programın, bir kayıtta iki veri öğesini — ad ( *first name* ) ve soyad ( *last name* ) — işlediğini varsayalım. Program, her iki alanın da bir değere sahip olup olmadığını değerlendirir.

İlk tabloda, kayıtta ad alanı `"Paul"` ve soyad alanı `"Picasso"` olarak görünür. Her iki alanın da değeri vardır; bu yüzden ad ve soyad için doğruluk koşulu doğrudur. Bu da **AND** işlemini doğru yapar.

Şimdi ikinci tabloda kayıt, ad alanını `"Paul"` olarak gösterir, fakat soyad `"null"`dur ya da bir değere sahip değildir. Burada ad için doğruluk koşulu doğrudur, ancak soyad için yanlıştır. Bu da **AND** işlemini yanlış yapar.

---

## 🔀 OR Operatörü

Bir sonraki Boolean operatörü **OR** operatörü de iki ifadeyi değerlendirir. Değerlendirme sonucu, **ifadelerden biri doğruysa** veya **her ikisi de doğruysa** doğrudur. Her iki ifade de yanlışsa, değerlendirme sonucu yanlıştır.

Programımızı, kayıttaki alanlardan en az birinin değer içerip içermediğini değerlendirecek şekilde değiştirelim. İlk tabloda kayıt, ad alanını `"Paul"` olarak gösterir ve soyad alanının değeri `"null"`dur. Ad için doğruluk koşulu doğru, soyad için yanlıştır. Alanlardan en az birinde değer olduğu için **OR** işlemi doğrudur.

Şimdi ikinci tabloda kayıt, ad `"null"` ve soyad `"null"` olarak görünür. Burada her iki alan için doğruluk değeri yanlıştır. Bu da **OR** işlemini yanlış yapar.

---

## 🚫 NOT Operatörü

**NOT** operatörü, Boolean operatörlerinin sonuncusudur. **AND** ve  **OR** ’dan farklı olarak, **NOT** operatörü tek bir ifade üzerinde çalışır ve ifadenin doğruluk değerini tersine çevirir. Bir ifade doğruysa, **NOT** operatörü uygulandığında yanlış olur. Bir ifade yanlışsa, **NOT** operatörü onu doğru yapar.

Programımızı son bir kez değiştirip soyad alanının bir değere sahip olup olmadığını değerlendirelim. Ya da başka bir ifadeyle, soyad alanı  *null değildir* .

İlk tabloda, ad `"Paul"` ve soyad `"null"` değerine sahiptir. Soyadın `"null"` olup olmadığı için doğruluk koşulu doğrudur. **NOT** operatörü için doğruluk koşulu yanlıştır.

Şimdi ikinci tabloda kayıt, ad `"Paul"` ve soyad `"Picasso"` olarak görünür. Soyadın bir değeri olduğu için `"null"` olup olmadığına dair doğruluk koşulu yanlıştır ve **NOT** operatörü için doğrudur.

---

## 🧭 Koşullu İfadeler

Boolean mantığı, programcıların bir programın nasıl çalıştığını kontrol etmek için kullanabileceği tek mantıksal araç değildir. Boolean ifadeler bir programa bir ifadenin doğruluk değerini söylerken, programcıların bu doğruluk değerlerindeki değişimlere yanıt vermesinin de bir yoluna ihtiyacı vardır.

Koşullu ifadeler, programcıların programın akışını kontrol etmek için Boolean değerlerini kullanma biçimidir. Bunları, en temel sürüm olan **if** ifadesiyle başlayarak inceleyelim.

**If** ifadeleri bir veya birden fazla ifade üzerinde çalışmak için kullanılır. İfadelerin doğruluk değerini değerlendirir ve değerlendirme sonucuna göre bir kod bloğunu yürütür.

Örneğin, programınızın, bir kullanıcının kaydındaki ad veya soyad alanlarından biri *null* ise kullanıcıyı uyarması gerektiğini varsayalım. İfadenin doğruluk değerini belirlemek için **if** ifadesi kullanan bir ifade yazarsınız. Program, ad alanı *null* mu **veya** soyad alanı *null* mu diye değerlendirir ve alanlardan herhangi birinde değer yoksa kullanıcıyı uyarır.

**If** ifadeleri, tek bir doğruluk değerine değerlendirilen ifadeleri ele almak için iyi tasarlanmıştır. Pek çok durumda programcıların, birden fazla olası değere sahip olabilen bir değişken için programın akışını yönlendirmesi gerekir. Bir seçenek, birden fazla **if** ifadesini art arda bağlamaktır. Diğer bir seçenek ise **switch** ifadesi kullanmaktır.

---

## 🔁 Switch İfadeleri

**Switch** ifadeleri, çeşitli değerlere sahip olabilen bir ifade üzerinde çalışır ve *case* adı verilen belirli bir değer doğru olduğunda bir kod bloğunu yürütür. Switch ifadeleri ayrıca değerlerden hiçbiri doğru değilse kullanılacak bir *default* seçeneği içerir.

Örneğin, programınızın belirli bir kayıttaki ülke alanını değerlendirmesi ve üç farklı ülke için (Almanya, Kenya ve Japonya) özel bir lisans sözleşmesi göstermesi gerektiğini varsayalım. Ülke alanı bu ülkelerden biri değilse, ifade genel bir lisans sözleşmesi gösterebilir.

Switch ifadesi her ülke için bir *case* içerir ve o ülkenin lisans sözleşmesini gösterir; ayrıca genel lisans sözleşmesi için bir *default* seçeneği bulunur.

Bu koşullu ifadeler, programcının programın akışını yönlendirmesine ve koşullara bağlı olarak belirli kodu çalıştırmasına yardımcı olur.

---

## 🔄 Döngüler

Bazen programcıların aynı görevleri birden fazla veri öğesi üzerinde gerçekleştirmesi gerekir. Bu tür görevler için *döngü (loop)* adı verilen ifadeleri kullanırlar.

Döngüler, bir programdaki eylemleri ya **for döngüsü** ile belirli sayıda kez, ya da **while döngüsü** ile bir koşul sağlanana kadar tekrarlamamıza izin verir. Önce **for** döngülerini inceleyelim.

---

## 🔢 For Döngüsü

**For** döngüsü, bir kod bloğunu belirli sayıda kez yürütür. Programcı, kodun kaç kez tekrarlanacağını belirtebilir ya da bu sayı değişkenin kendisinin bir özelliği olabilir.

Bir veritabanındaki on kaydı, ad ve soyad alanlarının başındaki ve sonundaki boşlukları kaldırarak işlemeniz gerektiğini hayal edin. Veriyi, on kaydın tamamını tutabilen özel bir değişken olarak bir **for** döngüsüne alabilirsiniz.

Sonra, döngü son kayda ulaşana kadar değişkende bulunan her kaydı dolaşabilirsiniz. **For** döngüsü, programcının işlemesi gereken değer sayısının bilindiği durumlarda faydalıdır.

---

## ⏳ While Döngüsü

Sayı bilinmediğinde, programcı koşullu bir döngü oluşturmak için **while** döngüsünü kullanabilir. Koşulun doğruluk değeri, döngünün kod bloğunu ne zaman çalıştırmayı bırakacağını söyler.

**While** döngüsü, belirtilen koşul doğru olduğu sürece bir kod bloğunu yürütür. While döngüleri, programcının değerlendirmek istediği koşulları oluşturmak için Boolean ifadelerle kullanılabilir.

Örneğin, bir veritabanındaki kayıtları işlediğinizi ve yinelenen kayıtları kaldırmanız gerektiğini varsayalım. Kaç tane yinelenen kayıt olduğunu önceden bilmeye gerek kalmadan, bir kayıtta yinelenenler olup olmadığını kontrol etmek ve var oldukları sürece silmek için bir **while** döngüsü kullanabilirsiniz.

---

## 📌 Özet

Bu videoda, programlamada kullanılan farklı mantık türlerini belirlemeyi ve açıklamayı öğrendiniz. Boolean mantığı ifadeleri ve koşullu ifadeler, programcıların bir programda hangi kodun çalışacağını değerlendirmesi ve yönlendirmesi için kullanılan yöntemlerdir.

Bu ifadeleri kullanarak, çok değerli işler yapan dinamik programlar oluşturabilirsiniz.

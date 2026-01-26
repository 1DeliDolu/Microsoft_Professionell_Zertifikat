## 🎛️ Complex Switch Cases

Programlamada, karmaşık olan ve birden fazla karar seviyesini gerektiren problemler olacaktır. Bazen bu tür problemleri programatik olarak çözmek için basit *switch* ifadeleri yeterli olmaz.

Bu videoda, programlarda *karmaşık switch ifadelerini* uygulayacağız. Bazı örnekleri incelemeden önce, switch ifadelerinin ne olduğunu ve neden faydalı olduklarını hızlıca hatırlayalım.

Switch ifadeleri, bir programın bir değişkeni değerlendirmesine ve değerine bağlı olarak farklı eylemler gerçekleştirmesine olanak tanır. Örneğin, bir program sipariş boyutuna göre farklı bir kargo yöntemi uygulamak için bir switch ifadesi kullanabilir.

Hangi sipariş boyutunun hangi kargo yöntemiyle eşleştiğini belirlemek için switch ifadeleri *case* kullanır.

---

## 🧩 Case Nedir

 *Case* , bir switch ifadesinde programın bir değişkenin ya da ifadenin değerine karşı kontrol ettiği belirli bir koşuldur ve sonraki adımda ne yapılacağını belirler.

Her case, değişkenin eşleşebileceği olası bir değeri temsil eder. Bir eşleşme bulunduğunda, o case ile ilişkili kod bloğu çalıştırılır.

---

## 🧠 Daha Karmaşık Switch Kullanımları

Artık switch ifadelerinin daha karmaşık kullanımlarını incelemeye hazırız:

* Birden fazla case’in aynı eylemi paylaşması
* Hiçbir case ile eşleşmeyen değerleri yönetmek için *default* değerinin kullanılması

Basit bir switch ifadesinde, her case’in karşılık gelen bir eylemi olur. Örneğin, haftanın her günü için bir case içeren bir switch ifadesi, güne bağlı olarak benzersiz bir yemek önerisi verebilir.

Peki, pazartesi ve çarşamba günleri için yemek önerisinin aynı olmasını isteseydiniz ne olurdu?

---

## 🗓️ Birden Fazla Case’in Aynı Eylemi Paylaşması

Switch ifadeleri, birden fazla case’in aynı eylemi paylaşmasına izin vererek bunu mümkün kılar. Bunu *pseudocode* ile bir örnek üzerinden inceleyelim.

Önce bunun basit bir switch ifadesiyle nasıl yapılacağını gözden geçirelim. Her case için eylem şu şekilde sağlanır:

* İlk case `"Monday"` olur ve eylem `"Eat cereal"` mesajını yazdırmaktır.
* Çarşamba için de aynı eylem uygulanır: case `"Wednesday"` olur ve eylem `"Eat cereal"` mesajını yazdırmaktır.

Dikkat edin: `"Eat cereal"` mesajını yazdırma eylemi, her iki gün için de aynı olmasına rağmen iki kez yazılmak zorunda kaldı.

Şimdi daha karmaşık bir switch ifadesi kullanarak, pazartesi ve çarşamba için aynı eylemi paylaşabiliriz. Switch ifadesini yeniden yazıp, önce pazartesi case’ini, ardından çarşamba case’ini listeleriz.

Sonra yalnızca tek bir `"Eat cereal"` mesajı yazdırma eylemi her iki case için de geçerli olur.

---

## 🧬 Pattern Matching

Karmaşık switch ifadelerinin bir diğer kullanımı  *pattern matching* ’dir.

Pattern matching, girdileri önceden tanımlanmış bir desenle karşılaştırarak switch ifadelerini farklı veri türlerini ele almak için kullanmanıza olanak tanır.

Bu tür bir switch ifadesini, giriş metninin belirli bir karakter dizisini içerip içermediğini belirlemek ve ardından bir eylem gerçekleştirmek için kullanabilirsiniz.

Bu durumda girişin tam bir değer olması gerekmez; ancak bir desene uyan bir değeri içermesi gerekir.

Örneğin, girişin `"jazz"` kelimesini içerip içermediğini kontrol edebilir ve `"soft jazz"` veya `"jazz Nouveau"` gibi ifadelerle eşleşebilir. Bu durumda `"jazz music"` mesajını yazdırır.

Benzer şekilde, giriş `"rock"` kelimesini içeriyorsa `"rock music"` mesajını yazdırır.

---

## 🧯 Default Case

İnceleyeceğimiz son karmaşık switch türü, *default case* kullanımını içerir.

Default case, belirtilen case’lerin hiçbiri ifadeyle eşleşmediğinde çalıştırılmak üzere switch ifadesinde kullanılır. Default case kullanmak, programın çökmesini veya beklenmedik şekilde davranmasını önlemeye yardımcı olur.

Örnek olarak, daha önceki pattern matching örneğimize bir default case ekleyelim.

Zaten iki case’imiz var: biri jazz, diğeri rock için. Peki ya jazz veya rock dizgesini içermeyen bir değeri eşleştirmemiz gerekirse?

Bu diğer değerleri default case içinde yönetebilir ve `"Other type of music"` mesajını yazdırmak gibi bir eylem gerçekleştirebiliriz.

Dikkat edin: Bu örnekte default case’i en sona koyuyoruz, ancak default case switch ifadesinin içinde herhangi bir yerde yer alabilir ve mutlaka en sonda olmak zorunda değildir.

---

## ✅ Video Özeti

Bu videoda, karmaşık switch ifadelerini öğrendiniz. Birden fazla case’i yönetmeyi, pattern matching uygulamayı ve eşleşmeyen değerleri yönetmek ve kodunuzun sorunsuz çalışmasını sağlamak için default case kullanmayı incelediniz.

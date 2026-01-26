## 🔀 Switch İfadeleri

Kod yazarken, çoğu zaman bilgisayara farklı koşullara göre ne yapması gerektiğini söylemeniz gerekir. Çok sayıda `'if'` ve `'else'` ifadesi kullanmak yerine bir `'switch'` ifadesi kullanabilirsiniz. Bu, bir şeyin değerine bağlı olarak kodunuzun hangi bölümünün çalıştırılacağını seçmenin bir yoludur.

Bu videoda, *switch* ifadelerinin amacını ve sözdizimini açıklayacağız.

## 🧾 Switch İfadesi Nedir?

Önce bir *switch* ifadesinin ne olduğunu tanımlayarak başlayalım.

Bir *switch* ifadesi, bir programın bir değişkeni değerlendirmesine ve onun değerine (veya `"case"`ine) göre farklı eylemler yürütmesine olanak tanır. *Switch* ifadelerini kullanmanın temel amacı, geliştiricilerin bir değişkenin birden fazla olası değeriyle çalışabilmesini sağlamaktır; böylece kod, birden çok *if-else* ifadesi kullanmaya kıyasla daha okunabilir ve daha düzenli olur.

## 🧩 Yapı ve Mantık: Sözde Kod ile Örnek

Bir *switch* ifadesinin ne olduğu ve amacı tanıtıldıktan sonra, yapısını ve bir örnekle nasıl çalıştığını inceleyelim; önce sözde kod ( *pseudocode* ) ile başlayalım.

Hangi düğmeye basıldığını kontrol eden ve buna karşılık gelen eylemi gerçekleştiren bir otomat hayal edin. `"Water"` etiketli düğmeye basarsanız otomat su verir; `"Soda"` düğmesine basarsanız soda verir; `"Coffee"` düğmesine basarsanız kahve verir. Listelenmeyen başka bir düğmeye basarsanız, varsayılan ( *default* ) olarak bir hata mesajı görüntüler.

`"Water"`, `"Soda"` ve `"Coffee"` değerlerine *switch* ifadesinde *case* denir. `"default"` kullanımı da bir tür *switch* ifadesi  *case* ’idir. Sözde kodda bu örnek aşağıdaki yapıyı kullanır.

## 🧾 Sözde Kod Yapısı

`"button"` adlı bir değişken ve *string* veri türü kullanarak, `"button"` değişkeniyle bir *switch* ifadesi oluşturun. Ardından her seçim için karşılık gelen eylemi içeren bir *case* tanımlayın:

* İlk *case* `"Water"` olacak ve eylemi `"Dispensing water"` yazdırmaktır.
* Sonraki *case* `"Soda"` olacak ve eylemi `"Dispensing soda"`dır.
* Üçüncü *case* `"Coffee"` olacak ve seçilirse `"Dispensing coffee"` mesajı verilecektir.
* Ardından *default case* vardır; otomat üzerinde, eşleşecek bir *case* bulunmayan bir düğmeye basıldığı için `"Invalid option"` mesajını vermek eylemine sahiptir.

Şimdi aynı *switch* örneğini bu kez C# kullanarak deneyelim ve sözdizimini parça parça inceleyelim. `'button'` adlı değişken, otomat makinesindeki düğmeyi temsil eder ve bunu *switch* ifademizle kontrol edeceğiz.

## 💻 C# Sözdizimi: Adım Adım

Değişkeni tanımlamak için `"string"`, `"button"` ve noktalı virgül yazın.

`'switch'` anahtar sözcüğü ifadeyi başlatır ve ardından parantez içinde değerlendirilecek değişken gelir. Sonrasında açılış ve kapanış süslü parantezler eklenir. *Switch* ifadesinin  *case* ’leri bu parantezlerin içinde yer alır.

Her `'case'` anahtar sözcüğü, değişkenin olası bir değerini temsil eder. Değişken *case* değerine eşleşirse,  *case* ’in ardından gelen kod bloğu çalıştırılır. Seçilen düğme `"Water"` olduğunda, konsola otomatın `"Dispensing water"` mesajını verdiğini belirten bir mesaj görüntülenir veya yazdırılır.

## 🖥️ Console ve Break

Konsolun, komut girmek ve çıktıları görüntülemek için kullanılan bir arayüz olduğunu hatırlamak önemlidir.

`'break'` anahtar sözcüğü mevcut  *case* ’i sonlandırır. Bu olmadan program, değerine bakmaksızın bir sonraki  *case* ’i yürütmeye devam eder.

Şimdi otomat makinesinde basılan düğmeye ilişkin diğer tüm  *case* ’leri ekleyin. `"Soda"` bir soda verir ve `"Coffee"` kahve verir; her  *case* ’in sonunda bir `break` anahtar sözcüğü ekleyin.

Son olarak, *switch* ifadesinde diğer  *case* ’lerle eşleşmeyen değerlere sahip düğmeleri yönetmek için *default case* eklemeyi unutmayın. Bu  *case* , bir `'default'` anahtar sözcüğü ile başlar ve hiçbir *case* değeri değişkenle eşleşmediğinde çalıştırılacak bir kod bloğu içerir.

`'break'` anahtar sözcüğünü de eklediğinizden emin olun.

## ✅ Video Özeti

Bu videoda, *switch* ifadelerinin amacı ve sözdizimi hakkında bilgi edindiniz. *Switch* ifadeleri, bir değişkenin birden fazla olası değerini yönetmek için güçlü araçlardır.

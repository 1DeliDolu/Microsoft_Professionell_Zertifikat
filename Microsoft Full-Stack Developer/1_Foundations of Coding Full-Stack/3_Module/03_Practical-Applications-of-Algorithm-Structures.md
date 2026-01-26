## 🧭 Algoritma Yapılarının Pratik Uygulamaları

Bir şehri harita veya GPS olmadan dolaşmaya çalıştığınızı hayal edin. Her karar bir tahmin olurdu ve sonunda kaybolabilir ya da trafikte sıkışıp kalabilirdiniz. Yazılım geliştirme dünyasında ise algoritmalar sizin haritanızdır; sizi karmaşık kararlar boyunca yönlendirir ve verimli çözümlere ulaştırır.

İster  *front-end* , ister  *back-end* , ister *full-stack* geliştirici olun, farklı algoritma yapılarına hakim olmak sizi problem çözmede bir “navigatör”e dönüştürebilir ve başarıya giden en iyi rotayı her zaman bulmanızı sağlar.

Bu videoda, algoritma yapılarını gerçek dünya örneklerine uygulayacağız.

---

## 🧩 Koşullu İfadelerle Gerçek Dünya Örneği

Programlamada *if/then* ve *switch* gibi koşullu ifadeler, bir programın akışını kontrol etmek için kullanılır. Bir *if/then* ifadesi, koşul doğruysa bir kod bloğunu çalıştırır; bir *switch* ifadesi ise bir değişkenin değerine bağlı olarak birden fazla kod yolundan seçim yapmanıza olanak tanır.

Koşullu bir algoritmayı göstermek için sözde kodla bir örnek kullanalım. Bu örnekte, birinin yaşı 18’in üzerindeyse **“Oy kullanmaya uygunsunuz”** yazdırmak istiyoruz. Yaşı 18’in altındaysa **“Oy kullanmaya uygun değilsiniz”** yazdırmak istiyoruz.

Bunu yapmak için, yaşı 18’e eşitleyerek ***“Yaşı = 18 olarak ayarla”*** adımını uygularız. 18’in üzerindeki yaşlar için yazdırma koşulunu ayarlamak üzere bir *if/then* koşulu kullanırsınız.

Yaş 18’e eşit veya 18’den büyükse, **“Oy kullanmaya uygunsunuz”** yazdırın. Bu, örneğin biri 25 gibi bir yaş girerse, oy kullanmaya uygun olduğunu yazdıracağı anlamına gelir.

Ardından, yaşın 18’e eşit veya 18’den büyük olmadığı durumları belirtmek için **ELSE** kullanırız; böylece bu durumda izlenecek ayrı bir koşul belirlenmiş olur.

Bu örnek için, 18’e eşit veya 18’den büyük olmayan her şeyde, **“Oy kullanmaya uygun değilsiniz”** yazdırır. Bu, biri 17 gibi bir yaş girerse, oy kullanmaya uygun olmadığını yazdıracağı anlamına gelir.

Koşullu ifadelerin doğru/yanlış koşullarına göre karar vermeyi nasıl yönlendirdiğini incelediğimize göre, şimdi odağımızı kategorik ifadelere kaydıralım.

---

## 🗂️ Kategorik İfadelerle Veriyi Sınıflandırma

Bunlar, göreviniz verileri düzenlemeyi ve sınıflandırmayı içerdiğinde gereklidir; belirli ölçütlere göre net yollar oluşturmanıza yardımcı olur.

Bilgisayar kodu mantığında kategorik ifadeler, verileri belirli ölçütlere göre sınıflandırmak ve gruplamak için kullanılır. Bu kategorileştirme, verileri düzenlemeye yardımcı olur; farklı veri özelliklerine dayalı olarak verileri işlemek, analiz etmek ve karar almak kolaylaşır.

Kategorik ifadeleri gösteren bir sözde kod örneği deneyelim. Ailelere yönelik bir açık hava festivali düzenlediğinizi hayal edin. Etkinliğe ön kayıt yaptıran kişilerden, kaç çocuk, kaç genç ve kaç yetişkinin kayıt yaptırdığını bilmek istiyorsunuz.

Önce  **Children** , **Teens** ve **Adults** olarak kategorize edilmiş üç boş liste oluşturursunuz. Ardından bu üç kategorinin her biri için ölçütü belirlersiniz.

Çocuk olarak kategorize edilen katılımcılar şu şekilde temsil edilir:

***“Eğer yaş 13’ten küçükse: Yaşı çocuklar listesine ekle.”***

Genç olarak kategorize edilen katılımcılar şu şekilde temsil edilir:

***“Aksi halde eğer yaş 13 ile 19 arasındaysa”***

Son olarak, yetişkin olarak kategorize edilen katılımcılar şu şekilde temsil edilir:

***“Aksi halde: Yaşı Adults listesine ekle”***

Şimdi fonksiyon, her biri farklı bir kategoriyi temsil eden üç liste içeren veriyi döndürür:  **Children** , **Teens** ve  **Adults** .

Kategorik ifadelerle, verileri özelliklere göre kategorilere ayırmayı öğrendik. Peki ya kararlar yalnızca iki seçenek arasındaysa, evet veya hayır gibi? İşte burada ikili yapılar devreye girer.

---

## ⚖️ İkili Yapılarla İki Seçenekli Kararlar

Bu basit ama güçlü yapıların programlarınızdaki kritik kararları nasıl yönlendirebileceğini inceleyelim.

İkili yapılar ve algoritmalar, iki olası sonucu olan kararları içerir; tıpkı sıfır ve bir, doğru ve yanlış, evet ve hayır gibi ikili durumlar gibi.

Sözde kodda ikili yapılara bir örnek tartışalım. Festivalinizde yalnızca yetişkinlere özel bir etkinlik alanı oluşturmak istiyorsunuz; bunun için katılımcıların bileklikle 21 yaşında veya daha büyük olarak tanımlanması gerekir. RSVP yapan katılımcılardan kaçının 21 yaşında veya daha büyük olduğunu bilmek istiyorsunuz.

Bunu yapmak için iki liste oluşturursunuz:

***“Biri 21 veya daha büyük olanlar için ve biri 21’in altında olanlar için.”***

Şimdi, oluşturduğunuz iki listedeki her yaş için, yaşların nasıl gruplanmasını istediğinizi şu şekilde belirtirsiniz:

***“Eğer yaş 21 veya daha büyükse, kişiyi ‘21 veya daha büyük’ grubuna ekle. Aksi halde, kişiyi ‘21’in altında’ grubuna ekle.”***

Algoritma, sağlanan katılımcı yaş listesindeki her yaş üzerinde yineleme yapar. Her yaş için, *yaş 21 veya daha büyük mü* koşulunu kullanarak yaşın 21 veya daha büyük olup olmadığını kontrol eder.

Koşul doğruysa, yaş **“21 veya daha büyük”** listesine eklenir. Yanlışsa, yaş **“21’in altında”** listesine eklenir.

Algoritma başlatıldıktan sonra, veriyi iki listede döndürür: biri 21 ve üzerindekiler için, diğeri 21 yaşın altındakiler için.

---

## ✅ Kapanış

Bu videoda, algoritma yapılarını gerçek dünya örneklerine nasıl uygulayacağınızı öğrendiniz. Koşullu, kategorik ve ikili yapılar gibi algoritma yapılarını uygulamak, geliştiricilerin karmaşık problemlere verimli ve etkili çözümler oluşturmasını sağlar.

Bu yapıları anlayıp kullanarak, uygulamalarınızın performansını ve işlevselliğini artıran açık, düzenli ve verimli kod yazabilirsiniz.

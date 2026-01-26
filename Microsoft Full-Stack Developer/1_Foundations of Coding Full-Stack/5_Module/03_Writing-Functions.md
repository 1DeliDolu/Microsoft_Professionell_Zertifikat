## 🧩 Writing Functions

Hiçbir kodunuzu yeniden kullanma imkânınız olmadan karmaşık bir uygulama geliştirdiğinizi hayal edin. Her seferinde bir görevi gerçekleştirmeniz gerektiğinde, onu sıfırdan yeniden yazmanız gerekirdi; bu da yalnızca aşırı yüklenmiş bir kod tabanına değil, aynı zamanda hata yapma olasılığının da artmasına yol açardı.

İşte fonksiyonlar burada devreye girer. Bu videoda, yeniden kullanılabilir kod blokları oluşturmak için fonksiyonların nasıl yazılacağını öğreneceğiz.

Fonksiyonların ne olduğuna dair bir genel bakışla başlayalım.

---

## 🔁 Fonksiyonlar Nedir?

Fonksiyonlar, belirli görevleri yerine getiren yeniden kullanılabilir kod bloklarıdır. Geliştiricilerin veri geçirmesine, görevleri yürütmesine ve sonuç döndürmesine olanak tanırlar.

---

## 🧱 Fonksiyon Yazmanın Yapısı

Fonksiyon yazarken izlenecek belirli bir yapı vardır. İlk olarak, amacını tanımlayan bir adla bir fonksiyon bildirirsiniz.

Örneğin, *pseudocode* kullanarak bir dikdörtgenin alanını hesaplayan bir fonksiyon yazıyorsanız, fonksiyonunuzun adı olarak **`calculate area`** kullanabilirsiniz.

Fonksiyon yapısının bir diğer parçası, farklı verilerle çalışmak için *parametre* olarak bilinen girdileri almaktır. Aynı **`calculate area`** fonksiyonu örneğini kullanırsak, parametreler dikdörtgenin *uzunluğu* ve *genişliği* olabilir.

Fonksiyon gövdesi, görevi gerçekleştiren asıl kodu içerir. Fonksiyon gövdesinde, *uzunluk* ile *genişliği* çarparak dikdörtgenin alanını hesaplamak isteriz.

---

## ↩️ Dönüş Türü ve Sonuç Üretme

Bir fonksiyon çağrıldığında, kodunu yürütür ve genellikle bir sonuç üretir. *Dönüş türü* (return type), fonksiyonun hangi değeri döndüreceğini belirtir.

Dikdörtgenin alanını hesaplama örneğimizde, fonksiyonun dönüş türü, fonksiyonun kullandığı veri türüne bağlı olacaktır. Fonksiyon bir dikdörtgenin alanını hesapladığı için, dönüş türü bir sayı olacaktır; bu nedenle **`double`** veya **`integer`** olabilir.

---

## 🎯 Özet

Bu videoda, *pseudocode* kullanarak fonksiyon yazmanın yapısını ve sözdizimini öğrendiniz; buna fonksiyonun  *bildirimi* ,  *parametreleri* , *gövdesi* ve *dönüş türü* dahildir.

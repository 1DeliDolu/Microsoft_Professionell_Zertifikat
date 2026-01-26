## 🔁 Do-While Loops

Programlamada, başlangıç koşulları ne olursa olsun bir kod bloğunun **en az bir kez** çalıştırılmasını garanti etmeniz gereken durumlar vardır. *Do-while* döngüsü bunu sağlamak için kullanılabilir; ister kullanıcı girdisini yönetirken, ister önemli süreçleri başlatırken, ister kritik işlemlerin çalıştığından emin olurken.

Bu videoda, *do-while döngülerinin* amacını ve sözdizimini (syntax) açıklayacağız.

---

## 📌 Tanım

 *Do-while döngüsü* , koşulu kontrol etmeden önce kodun **en az bir kez** çalıştırılmasına izin veren yineleme (iteration) için bir kontrol akışı (control flow) ifadesidir.

Bunu, bir kapının kilitli olup olmadığını kontrol etmeden önce **en az bir kez açmayı denemek** gibi düşünün. *While* döngülerinden farklı olarak, *do-while* döngüleri koşulu kod bloğunu çalıştırdıktan sonra kontrol eder; bu da döngü gövdesinin **en az bir kez** çalışmasını garanti eder.

---

## 🔍 While vs Do-While

* Başlangıçtan itibaren koşul doğruysa kod bloğunu çalıştırmak için *while* döngüsünü kullanın; örneğin işlem yapmadan önce girdiyi doğrularken.
* Koşulun doğru olup olmadığını kontrol etmeden önce kod bloğunu **en az bir kez** çalıştırmak için *do-while* döngüsünü kullanın.

---

## 🧩 Do-While Yapısı

Bir  *do-while* ’ın temel yapısı şunları içerir:

* `"do"` anahtar sözcüğü
* Çalıştırmak istediğiniz kod bloğu
* Döngünün devam edip etmeyeceğini belirleyen `"while"` koşulu

---

## 💻 C# ile Do-While Örneği

Şimdi C# kullanarak bir örnek üzerinden do-while döngüsünü inceleyelim.

Bu örnekte `"counter"` adlı bir değişken tanımlar ve onu sıfıra başlatırız. Bu değişken döngünün çalışmasını kontrol etmek için kullanılır.

Ardından `"do"` anahtar sözcüğünü ve süslü parantezleri kullanırız. Süslü parantezlerin içinde, çalıştırılacak kod yer alır:

* `"counter"` değerini konsola yazdırırız
* Sonra `"counter++"` ile değişkenin değerini 1 artırırız

Son olarak `"while"` anahtar sözcüğünü ve şu koşulu kullanırız: `"counter"` 10’dan küçükse.

Bu kodun yaptığı şey şudur:

* Önce `"counter"` değişkeninin başlangıç değerini (0) yazdırır
* Sonra koşulu kontrol eder
* Koşul doğru olduğu sürece yinelemeye devam eder

Sonuç olarak ekrana şu değerler yazdırılır: `0, 1, 2, 3, 4, 5, 6, 7, 8, 9`.

Bu örnekte sonuç, do-while yerine while kullansaydık elde edeceğimiz sonuçtan farklı değildir.

---

## ⚠️ Farkı Gösteren Durum: Başlangıç Değeri 10 Olursa

Peki ya `"counter"` değişkeninin başlangıç değeri 10 olsaydı?

Eğer counter’ı 10’a başlatırsak, döngü:

* Önce `10` değerini yazdırır
* Sonra koşulu kontrol eder: `"counter" 10’dan küçük mü?`
* Koşul doğru olmadığı için durur

Bu nedenle sonuç yalnızca `10` olur.

Bu örnek, *do-while* döngüsünün *while* döngüsünden nasıl farklılaştığını gösterir.

---

## ✅ Video Özeti

Bu videoda, do-while döngülerinin amacını ve sözdizimini nasıl açıklayacağınızı öğrendiniz. Buna, do-while döngüsünü while döngüsüyle karşılaştırmak ve C# örnekleri üzerinden yapısını ve sözdizimini incelemek de dahildi.

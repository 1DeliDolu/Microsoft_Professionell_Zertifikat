
## 🧑‍💻 Functions ve Methods ile Program Geliştirme

*Methods* C#’ta problemleri çözmek için birer yapı taşı gibidir. Bir problemi yönetmesi daha kolay küçük parçalara ayırmamıza olanak tanırlar. Bir  *method* , çağrıldığında belirli bir görevi yerine getirir.

Bir  *method* ’u anahtar kelimeler kullanarak tanımlarız:  *Public* . Bu,  *method* ’un kodunuzun herhangi bir yerinden erişilebileceği anlamına gelir.  *Static* . Bu  *method* ’u bir nesne oluşturmaya gerek kalmadan doğrudan *main method* içinden çağırabilirsiniz.  *Void* . Bu,  *method* ’un herhangi bir değer döndürmediği anlamına gelir. Tek görevi, ona verdiğimiz işi gerçekleştirmektir.

---

## 📌 Method Tanımlama ve Çağırma

*Method* tanımladıktan sonra, içindeki kodu çalıştırmak için onu çağırmanız gerekir. Bir  *method* ’u tanımlamak ve çağırmak iki ayrı adımdır. Tanımlamak, programa  *method* ’un ne yaptığını söyler; çağırmak ise ne zaman çalıştırılacağını söyler.

---

## 🧩 Parameters ve Arguments ile Esneklik

 *Methods* , parametre aldıklarında daha da güçlü hâle gelir.  *Parameters* , *method* içine geçirmek istediğimiz veriler için yer tutucu görevi görür.  *Method* ’u çağırdığımızda *arguments* geçiririz; bunlar,  *parameters* ’ın yerini alan gerçek değerlerdir.

Bu, aynı  *method* ’u farklı girdiler için yeniden kullanmamızı sağlar;  *method* ’u esnek ve yeniden kullanılabilir hâle getirir. Örneğin, girdi olarak bir isim alan ve kişiselleştirilmiş bir selamlamayı yazdıran bir *method* oluşturacağız.

---

## 🔁 Return Value ve `return` Anahtar Kelimesi

Bazı *methods* işini bitirdiğinde bir sonuç geri verebilir. Buna *return value* denir. Bir değeri geri göndermek için `return` anahtar kelimesini kullanırız.

Bu sonuç bir değişkende saklanabilir veya program içinde doğrudan kullanılabilir.  *Return values* ,  *methods* ’ları daha kullanışlı hâle getirir çünkü bir şey hesaplamamıza veya  *method* ’dan bir sonuç alıp bunu programımızın başka bir yerinde kullanmamıza olanak tanır. Örneğin, iki sayıyı toplayan ve toplamı döndüren bir *method* oluşturacağız.

---

## ✅ Boolean Değer Döndüren Methods

*Methods* ayrıca *true* veya *false* değerleri döndürebilir; bunlara *Boolean values* denir.  *Boolean values* , karar verme için kullanışlıdır çünkü bir koşulun sağlanıp sağlanmadığını kontrol etmemizi ve sonuca göre bir eylem gerçekleştirmemizi sağlar.

Bir sayının pozitif olup olmadığını kontrol eden bir *method* yazacağız. Bu  *method* , sayı sıfırdan büyükse  *true* , sıfır veya daha küçükse *false* döndürecektir.

Ardından bu  *method* ’u bir *if-else statement* içinde kullanarak sayının pozitif olup olmadığını yazdıracağız.

---

## 🚗 Sürüş Yaşı Örneği ve `int.parse`

Çoğu ülkede yasal sürüş yaşı 18’dir. Kullanıcının yaşını girdi olarak alan ve sürüş için yeterince büyük olup olmadığını kontrol eden bir *method* oluşturacağız.

Kullanıcı yaşını girdiğinde, bu girdi bir *string* olarak alınır; yani metindir. Ancak yaşı bir sayı olarak kullanmamız gerekir, bu yüzden onu `int.parse` kullanarak  *string* ’den  *integer* ’a dönüştürmemiz gerekir. Bu, yaşı 18 ile karşılaştırmamızı sağlar.

Sonraki adımda, kullanıcının yaşının 18’e eşit veya 18’den büyük olup olmadığını kontrol eden `isOldEnoughToDrive` adlı bir *method* yazacağız.

Bu  *method* , kullanıcı yeterince büyükse  *true* , aksi hâlde *false* döndürecektir. *Main method* içinde ise bir *if-else statement* kullanarak, `isOldEnoughToDrive` tarafından döndürülen sonuca göre kullanıcıya araba kullanmasına izin verilip verilmediğini söyleyeceğiz.

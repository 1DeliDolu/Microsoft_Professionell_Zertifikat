
## 🧩 SQL Fonksiyonlarına Giriş

Veri, yalnızca statik satırlar ve sütunlardan ibaret değildir. Çeşitli amaçlar için kullanılabilen dinamik bilgiyi temsil eder. Ham verinin, analiz veya raporlama ihtiyaçlarına uyması için çoğu zaman yeniden şekillendirilmesi ve dönüştürülmesi gerekir; örneğin adları birleştirmek veya netlik için belirli kısımları çıkarmak gibi.

SQL, veriyi daha iyi anlaşılır ve gerçek dünya ihtiyaçlarına uygulanabilir hâle getirmek için güçlü fonksiyonlar sunar; raporlar oluşturma, içgörü üretme veya kullanıcı deneyimlerini iyileştirme gibi.

Bu videoda, veri manipülasyonu ve dönüşümü için kullanılan temel SQL fonksiyonlarını açıklayacağız.

---

## 🧠 SQL Fonksiyonu Nedir?

SQL fonksiyonları, veriniz üzerinde belirli görevleri gerçekleştirmenizi sağlayan, SQL içinde önceden tanımlanmış işlemlerdir; örneğin veriyi manipüle etmek veya dönüştürmek gibi.

Bu fonksiyonlar metni değiştirebilir, değer hesaplayabilir, bilgi çıkarabilir veya veriyi toplulaştırabilir. Böylece veriyi daha faydalı bir formatta almak ve sunmak kolaylaşır.

SQL fonksiyonları genellikle SQL sorgularının içinde kullanılır ve harici bir programlamaya ihtiyaç duymadan, veriyi doğrudan veritabanı tablolarından işleyebilmenizi sağlar.

---

## 🔗 `CONCAT` Fonksiyonu

En yaygın kullanılan SQL fonksiyonlarından bazılarını inceleyelim ve `CONCAT` ile başlayalım.

`CONCAT` fonksiyonu, birden fazla dizgeyi ( *string* ) tek bir dizgede birleştirmenizi sağlar. Örneğin ad ve soyadı birleştirip tam ad oluşturmak istiyorsanız, kullanacağınız araç `CONCAT`’tır.

`CONCAT`, `SELECT` ifadesi içinde; tablo sütunları, sabit değerler (tırnak içindeki metin veya sayılar) ya da hesaplamalar gibi birden fazla ifadeyi tek bir dizge hâline getirmek için kullanılır.

Bir *music catalog* tablomuz olduğunu ve iki sütun içerdiğini varsayalım: sanatçının adı ve sanatçının soyadı.

Bunları tek bir sütunda sanatçının tam adı olarak birleştirmek için şu sorguyu yazarız: `SELECT CONCAT`, ardından parantez içinde sanatçının adı, tırnak içinde bir boşluk ve sanatçının soyadı; bunlar virgülle ayrılır.

Sonrasında `AS ARTIST FULLNAME` ile sanatçının tam adı için bir takma ad ( *alias* ) oluştururuz.

Son olarak, veriyi nereden çektiğimizi belirtmek için `FROM MUSIC CATALOG` kullanırız.

Bu örnekte `CONCAT`, ad ve soyadı araya bir boşluk koyarak birleştirir ve iki sütunu tek bir anlamlı dizgeye dönüştürür.

---

## 📏 `LEN` / `LENGTH` Fonksiyonu

`CONCAT` ile dizgeleri birleştirdikten sonra, bazen bir metnin uzunluğunu ölçmeniz gerekebilir.

Bu noktada `LEN` ya da `LENGTH` fonksiyonu devreye girer. Verinizdeki karakter sayısını saymanıza yardımcı olur.

`LEN`, `SELECT` ifadesi içinde, boşluklar ve noktalama işaretleri dahil olmak üzere belirli bir ifadenin karakter sayısını hesaplamak için kullanılır.

Tüm sanatçı soyadlarının uzunluğunu bulmak için şu sorguyu yazarız: `SELECT LEN`. `LEN` sonrasında parantez içine sanatçının soyadını ekleriz.

Ardından, sonucu adlandırmak için `AS LAST NAME LENGTH` ile bir alias oluştururuz.

Son olarak, veriyi hangi tablodan aldığımızı belirtmek için `FROM MUSIC CATALOG` kullanırız.

---

## 🔠 `UPPER` Fonksiyonu

Metni birleştirip uzunluğunu bulduktan sonra, bazen metni standartlaştırmanız gerekebilir.

Örneğin tutarlılık için adları veya metni büyük harfe çevirmek istiyorsanız, `UPPER` fonksiyonu bunun için idealdir.

`UPPER`, belirtilen bir ifadeyi büyük harfe dönüştürür. Sözdizimi, `UPPER` anahtar kelimesinin ardından parantez içinde ifade şeklindedir.

Tüm sanatçı adlarını büyük harfe çevirmek için sorguya `SELECT UPPER` ile başlarız.

Parantez içinde sanatçının adını ekleriz.

Sonrasında `AS ARTIST FIRST NAME UPPER` ile sonucu büyük harfli ad olarak etiketleyen bir alias oluştururuz.

Son olarak, verinin kaynağını belirtmek için `FROM MUSIC CATALOG` yazarız.

---

## 🔡 `LOWER` Fonksiyonu

Bazen büyük harf yerine küçük harf gerekir.

Bunu yapmak için, metni küçük harfe dönüştüren `LOWER` fonksiyonunu kullanabilirsiniz.

`LOWER`, `SELECT` ifadesinde belirli bir ifadeyi küçük harfe dönüştürür ve sözdizimi `LOWER` anahtar kelimesi + parantez içinde ifade şeklindedir.

Örneğin tüm sanatçı e-posta adreslerini küçük harfe çevirmek için `SELECT LOWER` yazarız ve parantez içine `ARTIST EMAIL ADDRESS` sütun adını ekleriz.

Ardından `AS ARTIST EMAIL LOWER` ile küçük harfe çevrilmiş e-posta için alias oluştururuz.

Sonra `FROM MUSIC CATALOG` ile e-postayı *MUSIC CATALOG* tablosundan aldığımızı belirtiriz.

---

## ✂️ `SUBSTRING` Fonksiyonu

Son olarak, bir dizgenin bir kısmını çıkarmayı sağlayan SQL fonksiyonunu inceleyelim.

İster bir adın ilk birkaç harfine ihtiyaç duyun, ister bir metin alanının yalnızca belirli bir bölümüne; `SUBSTRING` fonksiyonu tam olarak ihtiyacınız olan metin parçasını seçmenize izin verir.

Belirlediğiniz başlangıç noktası ve uzunluğa göre bir dizgenin bir bölümünü çıkarır.

`SUBSTRING`, `SELECT` ifadesi içinde bir dizgenin bir kısmını almak için kullanılır. Sözdizimi; `SUBSTRING` anahtar kelimesi, bir ifade, başlangıç pozisyonu ve alt dizgenin uzunluğunu parantez içinde içerir.

Başlangıç pozisyonu çıkarımın nereden başlayacağını, uzunluk ise kaç karakter alınacağını belirtir.

Örneğin, daha kolay sıralama veya kategorilendirme için her sanatçı soyadının ilk üç harfini göstermek istiyorsanız `SUBSTRING` kullanabilirsiniz.

Sorgu `SELECT SUBSTRING` ile başlar; parantez içinde sanatçının soyadı, ardından virgül, başlangıç pozisyonu (bu örnekte 1), bir virgül daha ve alt dizge uzunluğu (3) yazılır.

Sorguyu `AS ARTIST LAST NAME SNIPPET FROM MUSIC CATALOG` ile bitirirsiniz.

Bu, sanatçının soyadından 1. pozisyondan başlayarak üç karakter çıkarır ve kısaltılmış sürüm için bir alias oluşturur.

---

## ✅ Özet

Bu videoda, veri manipülasyonu ve dönüşümü için kullanılan bazı temel SQL fonksiyonlarını öğrendiniz.

Bu teknikleri ne kadar uygularsanız, o kadar sezgisel hâle gelirler. Keşfetmeye devam edin; yakında SQL fonksiyonlarının veriyi yönetme ve dönüştürme konusunda ne kadar güçlü olabileceğini fark edeceksiniz.

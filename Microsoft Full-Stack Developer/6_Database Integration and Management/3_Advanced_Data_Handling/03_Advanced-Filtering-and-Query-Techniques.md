## 🎯 İleri Filtreleme ve Sorgu Teknikleri

SQL’de verileri filtrelemek, bir veritabanından işe yarar bilgi elde etmek için en önemli becerilerden biridir. Basit sorgular temel görevler için yeterli olsa da, gerçek dünya problemleri çoğu zaman daha gelişmiş filtreleme yöntemleri gerektirir.

İşte bu noktada, daha ileri SQL tekniklerini öğrenmek gerekebilir. Bu videoda, ileri filtreleme tekniklerini ve karmaşık SQL sorgularını açıklayacağız.

---

## 🧰 Gelişmiş Filtreleme Tekniklerine Genel Bakış

SQL’de gelişmiş filtreleme teknikleri, sorgularınızı daha karmaşık koşullara göre rafine etme ve verileri çekme gücü sağlar.

Bu teknikler şunları içerir:

* karşılaştırma operatörlerinin kullanımı
* mantıksal operatörler
* desen eşleştirme ( *pattern matching* )
* `WHERE` ifadelerinde koşullu mantık
* `HAVING` ifadesinde toplu ( *aggregate* ) filtreleme

Şimdi, neredeyse her sorguda kullanılan karşılaştırma operatörleriyle başlayalım.

---

## ⚖️ Karşılaştırma Operatörleri

Karşılaştırma operatörlerini, SQL filtrelemenin temel aracı olarak düşünün. Sayılar, tarihler veya metin gibi değerleri karşılaştırmanıza olanak tanırlar; böylece tam olarak aradığınız şeyi bulabilirsiniz.

Örneğin, maaşı tam olarak *50.000$* olan çalışanların listesini istiyorsanız, eşittir operatörünü kullanırsınız; tıpkı temel bir matematik probleminde olduğu gibi, `WHERE` ifadesine *salary equals 50,000* eklersiniz.

Diyelim ki *100.000$* üzerinde kazanan çalışanları bulmanız gerekiyor. Bu durumda “büyüktür” operatörü devreye girer. `WHERE` ifadesinde *salary* ifadesinin yanına büyüktür sembolünü koyar ve ardından *100,000* yazarsınız.

Ve eğer maaşı *100.000$* altında olan çalışanları bulmanız gerekseydi, `WHERE` ifadesinde *salary* için “küçüktür” sembolünü *100,000* ile birlikte yazardınız.

Bir değerden küçük veya büyük olan sonuçları, değerin kendisini de dahil ederek sorgulamak istiyorsanız, eşittir işaretini ekleyebilirsiniz. Örneğin, *50.000$* değerinden küçük veya eşit maaşları bulmak için “küçük eşittir” sembolünü ve ardından *50,000* yazarsınız.

Ayrıca, maaşı *50.000$* olmayan çalışanları filtrelemek için “eşit değildir” operatörü de vardır.

Bu karşılaştırmalar, veriyi filtrelemenin temelini oluşturur.

---

## 🧠 Mantıksal Operatörler

Şimdiye kadar karşılaştırma operatörlerinin tek bir koşula göre filtreleme yapmanıza nasıl yardımcı olduğunu gördük; ancak çoğu zaman daha fazla kriter ekleyerek sorgularınızı daha da rafine etmeniz gerekir. İşte burada mantıksal operatörler devreye girer.

Mantıksal operatörler koşulları birleştirmenize veya hariç tutmanıza olanak tanır.

Örneğin, 5 yıldan fazla deneyimi olan ve IT’de çalışan çalışanları bulmak istiyorsanız `AND` operatörünü kullanabilirsiniz. `AND` kullandığınızda, her iki koşulun da doğru olması gerekir: hem 5 yıldan fazla deneyim hem de IT’de çalışma.

Eğer IT’de olan **veya** 5 yıldan fazla deneyimi bulunan çalışanlarla ilgileniyorsanız, `OR` operatörünü kullanırsınız. `OR` operatörü, koşullardan yalnızca birinin doğru olmasının yeterli olduğu anlamına gelir: ya 5 yıldan fazla deneyim ya da IT’de çalışma.

Şimdiye kadar sayılara ve kesin koşullara dayalı filtrelemeye odaklandık. Şimdi, metinlerdeki desenlere veya belirli değer kümelerine göre nasıl filtreleme yapabileceğimizi keşfedelim: desen eşleştirme.

---

## 🧩 Desen Eşleştirme

Desen eşleştirme, kısmi eşleşmeleri veya bir küme içindeki değerleri aramanıza olanak tanır.

`LIKE` operatörü, bir desen izleyen veriyi bulmanıza yardımcı olmak için bir joker karakter ( *wildcard* ) kullanır — yüzde sembolü.

Örneğin, adı John ile başlayan çalışanları bulmak istiyorsanız, sorgunuza `LIKE` anahtar sözcüğünü, bir boşluk, ardından `John` ve hemen ardından bir yüzde işareti eklersiniz.

`John%` metni tek tırnak içinde olmalıdır.

Ayrıca `IN` operatörünü, IT, finance veya marketing departmanlarındaki çalışanları çekmek gibi bir değer listesiyle eşleştirme yapmak için kullanabilirsiniz.

Bunu, `IN` anahtar sözcüğünü kullanıp parantez içinde eşleştirilecek değerleri listeleyerek yaparsınız. Bu örnekte `IN` anahtar sözcüğünü yazıp parantez açar, listeye IT, finance, marketing ekler ve parantezi kapatırsınız.

---

## 🧷 Koşullu Mantık

Artık desenlere ve listelere göre filtreleme yapmayı bildiğinize göre, koşullu mantığı tanıtalım.

Koşullu mantık, belirli koşullara göre farklı değerleri aramanıza olanak tanır.

`CASE` ifadesi SQL’in içine biraz programlama mantığı ekler. Kodda belirli koşulları kontrol etmek ve sonuca göre bir değer döndürmek için kullanılan *IF-THEN* benzeri bir yapıdır.

Örneğin, çalışanları deneyimlerine göre etiketlemek istiyorsunuz. `CASE` kullanarak onları iki yıldan az deneyim için junior, iki ile beş yıl arası için mid-level ve beş yıldan fazla deneyim için senior olarak sınıflandırabilirsiniz.

Bu, belirli kriterlere göre sorgu çıktınızı özelleştirmenize olanak tanır ve veriyi nasıl sunduğunuza daha fazla esneklik katar.

---

## 📈 Toplu (Aggregate) Filtreleme ve HAVING

Şimdiye kadar tek tek satırları filtreledik; peki ya finance departmanları gibi satır gruplarını, belirli sayıda çalışandan fazla olanları filtrelemek isterseniz?

İşte burada toplu ( *aggregate* ) filtreleme devreye girer.

Toplu fonksiyonlar, birden fazla satır boyunca veriyi özetler.

Örneğin, şirkette çalışan toplam çalışan sayısını toplamak veya saymak için `COUNT` fonksiyonunu ve parantez içinde *employee ID* kullanabilirsiniz.

Bu, her bir *employee ID* değerini sayar ve sonuç olarak şirketteki çalışan sayısını döndürür.

Ortalama bulmak için `AVG` fonksiyonunu kullanabilirsiniz. Ortalama maaşı bulmak için `AVG` yazıp parantez içine *salary* koyarsınız.

Bu, *salary* sütunundaki tüm maaşları dolaşır ve ortalama maaşı hesaplar.

En düşük ya da minimum maaşı bulmak isterseniz `MIN` fonksiyonunu, yani `M-I-N` ve parantez içinde *salary* yazarsınız.

En yüksek ya da maksimum maaşı bulmak için `MAX` fonksiyonunu, yani `M-A-X` ve parantez içinde *salary* yazarsınız.

Tüm maaşların toplamını bulmak isterseniz `ADD` fonksiyonunu, yani `A-D-D` ve parantez içinde *salary* yazarsınız.

Bir toplu fonksiyon uyguladıktan sonra, özetlenmiş sonuçları filtrelemek isteyebileceğiniz durumlar olur; işte burada `HAVING` ifadesi devreye girer.

`HAVING` ifadesi `WHERE` ifadesine benzer, ancak toplulaştırılmış sonuçları filtrelemek için kullanılır.

Diyelim ki departman başına çalışan sayısını bulmak için `COUNT` kullandınız, ancak yalnızca 50’den fazla çalışanı olan departmanları göstermek istiyorsunuz.

Bu örnekte, toplulaştırmadan sonra sonuçları filtrelemek için `HAVING`, `COUNT`, parantez içinde *employee ID* ve `greater than 50` ifadesini kullanırsınız.

`WHERE` toplulaştırmadan önce satırları filtrelerken, `HAVING` toplulaştırma uygulandıktan sonra satırları filtreler; bu, gruplanmış veriyle çalışırken kritik bir noktadır.

---

## 🔗 Karmaşık Durumlar ve Gelişmiş JOIN’ler

Gelişmiş filtreleme tekniklerine ek olarak, birden fazla tablo arasında daha karmaşık biçimlerde veri birleştirmeniz gereken durumlarla da karşılaşabilirsiniz.

Gelişmiş join’ler, sorgularınız birden fazla kaynaktan gelen veriyi birleştirmeyi veya daha karmaşık filtreleme yapmayı gerektirdiğinde kullanışlıdır.

Çoğu zaman ihtiyacınız olan tüm veriyi almak için üç veya daha fazla tabloyu join etmeniz gerekir.

Örneğin, bir çalışan veritabanıyla çalışıyorsanız ve çalışanların, departmanlarının ve atandıkları projelerin detaylarını istiyorsanız;  *employees* , *departments* ve *project tables* arasında join’ler uygularsınız.

Join’e daha fazla tablo ekledikçe sorgunuz daha karmaşık hâle gelir, ancak veri setinizin tamamı boyunca daha kapsamlı bilgi toplamanızı sağlar.

---

## 🔍 JOIN İçinde Alt Sorgularla Filtreleme

Bazı durumlarda, birçok tabloyu join etmek yerine, bir tablodaki veriyi başka bir tablodaki koşullara göre filtrelemeniz gerekebilir.

Bu durumlarda join’lerin içinde alt sorgu kullanmak, önce veriyi filtrelemenize ve sonra sonucu başka bir tabloyla join etmenize olanak tanır.

Örneğin, belirli bir bütçe eşiğinin üzerinde bütçesi olan projelerde çalışan çalışanları arıyorsanız; *project table* içinden projeleri bütçeye göre filtrelemek için bir alt sorgu kullanabilirsiniz.

Sonra bu filtrelenmiş proje verisini employee tablosuyla join edersiniz.

Bu yaklaşım size daha fazla kontrol sağlar; çünkü alt sorgu, join gerçekleşmeden önce veriyi filtreler ve sorguyu daha hassas hâle getirir.

---

## 🧾 Daha İleri Karmaşıklık için CTE’ler

Daha da karmaşık sorgular için, bir join gerçekleştirmeden önce ara hesaplamaları veya sonuçları yönetmeniz gerektiğinde, Common Table Expressions ( *CTEs* ) kullanın.

CTE’ler, mantığı adım adım ele almak için etkili bir yoldur.

Örneğin, departman başına ortalama maaşı hesaplamak için bir CTE kullanabilir ve sonra bu sonucu başka bir tabloyla join ederek bireysel çalışan maaşlarını departman ortalamasıyla karşılaştırabilirsiniz.

CTE’ler, sorgunuzu adım adım yapılandırmanıza olanak tanır ve karmaşık join’leri yönetmeyi kolaylaştırır.

---

## ✅ Kapanış

Bu videoda, karmaşık SQL sorgularında gelişmiş filtreleme tekniklerini öğrendiniz.

Bu becerileri pratik ettikçe, karmaşık sorgular oluşturma yeteneğinin, tam olarak ihtiyacınız olan veriyi çekmek için değerli bir araca dönüştüğünü göreceksiniz; analizinizde size daha fazla hassasiyet ve güven kazandıracaktır.

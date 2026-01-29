## 🧹 Veriyi Filtreleme ve Sıralama

SQL’de verinizi filtreleyip sıralayabilmek, istediğiniz bilgiyi tam olarak elde etmenize yardımcı olur. İster binlerce satırı daraltıyor olun, ister sonuçlarınızı önemli içgörülere odaklanacak şekilde sıralıyor olun; `WHERE` ve `ORDER BY` yan tümcelerinde ustalaşmak verinizi anlamlandırmanın anahtarıdır.

Bu videoda, SQL sorgularında veriyi filtrelemek ve sıralamak için `WHERE` ve `ORDER BY` kullanacağız.

---

## 🎯 `WHERE` Yan Tümcesi

SQL’de `WHERE` yan tümcesi, sorgunun sonuç kümesine dahil edilecek satırların karşılaması gereken koşulları belirleyerek kayıtları filtrelemek için kullanılır.

`WHERE` yan tümcesi, `SELECT` gibi SQL ifadeleri içinde belirli koşullara göre satırları filtrelemek için kullanılır.

`WHERE` yan tümcesi kullanan bir `SELECT` ifadesi için temel sözdizimi; `SELECT` anahtar kelimesiyle başlar ve ihtiyaç duyulan sütun adlarıyla devam eder.

Ardından `FROM` anahtar kelimesi ve tablo adı kullanılır. Son olarak `WHERE` anahtar kelimesi gelir ve ardından uygulamak istediğiniz koşul yazılır.

Örneğin, eşittir, büyüktür veya küçüktür gibi karşılaştırma operatörleriyle yalnızca belirli satırların döndürülmesini sağlayabilirsiniz. Filtrelemeyi daha hassas yapmak için koşulları `AND` ve `OR` gibi mantıksal operatörlerle birleştirebilirsiniz.

Bu şekilde, yalnızca ilgilendiğiniz veriyi aldığınızdan emin olabilirsiniz.

---

## 👥 Örnek: Sadece HR Departmanındaki Çalışanlar

Sadece HR departmanındaki çalışanları döndüren bir sorgu yazmak istediğinizi varsayalım. Sorguyu şöyle yazarsınız.

Önce, sorgudan döndürmek istediğimiz sütunları listeleyen bir `SELECT` ifadesiyle başlarız: ad ve soyad.

Ardından, veriyi *employees* tablosunda aramasını söylemek için `FROM employees` kullanırız.

Şimdi, yalnızca HR departmanındaki çalışanları istemek için bir `WHERE` yan tümcesi ekleriz. Bunu, `department` alanını `HR` değerine eşitleyen bir eşittir operatörü kullanarak yaparız.

---

## ➕ `AND` ile Koşulları Birleştirme

Son örnekteki gibi temel bir filtre uyguladıktan sonra, sonuçlarınızı daha da daraltmak isteyebilirsiniz.

Örneğin, yalnızca HR departmanında olup  **50.000$** ’dan fazla kazanan çalışanlarla ilgileniyorsanız, koşulları `AND` operatörüyle birleştirerek sorgunuzu daha spesifik hâle getirebilirsiniz.

Oluşturduğumuz sorgudan devam edelim.

Sorgunun ayrıca maaşı  **50.000$** ’dan büyük olan çalışanları filtrelemesi için, `WHERE` yan tümcesinin sonuna `AND` operatörünü şu şekilde ekleriz: `AND salary greater than $50,000`.

Bu sorgu artık HR departmanında olup maaşı  **50.000$** ’dan büyük olan tüm çalışanların ad ve soyadlarını döndürür.

`AND` operatörünü kullanmak, her iki koşulun da doğru olması gerektiği anlamına gelir. Örneğimizde, bir çalışanın HR departmanında olması **VE** maaşının  **50.000$** ’dan büyük olması gerekir.

---

## 🔀 `OR` ile Alternatif Koşullar Eklemek

Şimdi, `WHERE` yan tümcesine bu kez `OR` operatörünü kullanarak farklı bir koşul ekleyerek işleri biraz daha karmaşıklaştıralım.

HR veya finance departmanlarında olan **VE** 5 yıldan fazla deneyime sahip çalışanları sorgulamak istediğinizi düşünün.

Bu durumda birden fazla koşula ihtiyacımız var.

Önce bir `SELECT` ifadesiyle başlayalım: *employees* tablosundan `first name`, `last name` ve `department` seçelim.

Ardından, sorgudan istediğimiz sonuçları daha net tanımlamak için bir `WHERE` yan tümcesi kullanalım.

Parantez içinde `OR` operatörüyle `department` değerini HR’ye eşitleriz veya `department` değerini finance’a eşitleriz. `OR` kullanarak, sonuçlarda ikisinden birinin doğru olabileceğini söyleriz.

Yani bir çalışan HR departmanında **VEYA** finance departmanında olabilir.

Sonuçları ayrıca 5 yıldan fazla deneyimi olan çalışanlarla sınırlandırmak için `AND` operatörünü kullanır ve `years experience` değerini 5’ten büyük olacak şekilde ayarlarız.

Bu sorgu, HR veya finance departmanında olan **VE** 5 yıldan fazla deneyime sahip çalışanlar için; *employees* tablosundan `first name`, `last name` ve `department` içeren sonuçlar döndürür.

---

## 📌 `ORDER BY` Yan Tümcesi

Filtreleme ile yalnızca önemli veriye odaklanmayı öğrendikten sonra, bir sonraki adım bu veriyi daha kullanışlı hâle getirmek için organize etmektir. Bunu `ORDER BY` yan tümcesiyle yaparız.

SQL’de `ORDER BY` yan tümcesi, bir sorgunun sonuç kümesini bir veya daha fazla sütuna göre artan veya azalan sırayla sıralar.

`SELECT` ifadesinde sonuçları artan sıraya göre sıralamak için, sorgunun sonuna `ORDER BY` anahtar kelimesi ve ardından sütun adı eklenir.

Artan sıralama için `ASC` eklenir. `ORDER BY` varsayılan olarak artan sıralama yaptığı için, `ASC` eklemek zorunlu değildir.

Ancak sıralamayı azalan yapmak istiyorsanız `DESC` eklemeniz gerekir.

---

## 🔤 Örnek: Soyada Göre Artan Sıralama

Tüm çalışanları soyadına göre artan sırayla sıralamak istediğinizi varsayalım.

*employees* tablosundan ad ve soyadı içeren bir `SELECT` ifadesi yazar, sonuna `ORDER BY` ekleriz; ardından `last name` sütununu ve son olarak `ASC` ekleriz.

Tekrar belirtmek gerekirse, `ORDER BY` varsayılan olarak artan sıralama kullandığı için `ASC` eklemek kesin olarak gerekli değildir.

Bu sorgu, *employees* tablosundan çalışanların ad ve soyadlarını döndürür ve sonuçları soyada göre artan sırada, alfabetik olarak sıralar.

---

## 🧩 Filtreleme + Sıralamayı Birleştirme

Artık `WHERE` ile filtrelemeyi ve `ORDER BY` ile sıralamayı öğrendiğinize göre, daha gelişmiş bir sorgu için ikisini birleştirelim.

Bu örnekte, HR departmanındaki çalışanları sorgulamak ve onları maaşlarına göre en yüksek kazanan en üstte olacak şekilde sıralamak istiyoruz.

Önce *employees* tablosundan `first name`, `last name` ve `salary` seçerek başlarız.

Ardından `department` değerini HR’ye eşitlemek için bir `WHERE` yan tümcesi ekleriz.

Sonra `ORDER BY` anahtar kelimesini, ardından `salary` sütununu ekler ve `DESC` ile bitiririz.

Bu sorgu, HR departmanındaki çalışanların adlarını, soyadlarını ve maaşlarını döndürür; sonuçlar en yüksek maaştan en düşük maaşa doğru azalan sırada sıralanır.

---

## ✅ Özet

Bu videoda, SQL sorgularında veriyi filtrelemek ve sıralamak için `WHERE` yan tümcelerini ve `ORDER BY` kullanımını öğrendiniz.

Farklı filtreler ve sıralama teknikleriyle denemeler yaparak, bunların veri getirme sonuçlarınızı nasıl değiştirdiğini keşfedin.

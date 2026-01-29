## 📥 `SELECT` ile Temel Veri Getirme

Veri, modern dünyadaki en değerli kaynaklardan biridir; ancak ihtiyacınız olan bilgiyi almak için doğru soruları sormayı bilmek daha da önemlidir. SQL `SELECT` ifadeleri, bu soruları sormanıza ve bir veritabanından veri getirmenize olanak tanır.

Bu videoda, bir veritabanından veri almak için basit `SELECT` ifadeleri yazacağız.

---

## 🧱 `SELECT` İfadesinin Temel Sözdizimi

Önce `SELECT` ifadesinin temel sözdizimini gözden geçirelim. Bu, bir veritabanından veri getirmenin temelidir.

Temel sözdizimi; `SELECT` anahtar kelimesiyle başlar, ardından sütun adı (birden fazlaysa  *adlar* ), sonra `FROM` anahtar kelimesi ve ardından tablo adı gelir.

`SELECT`, veritabanına veri almak istediğinizi söyler.

`Column 1` ve `column 2`, almak istediğiniz belirli sütunlardır ve `FROM TABLE NAME`, verinin hangi tablodan alınacağını belirtir.

---

## 👤 Belirli Sütunları Getirme

Artık temel sözdizimini anladığınıza göre, yalnızca belirli sütunları getiren basit bir sorguyla başlayalım.

Diyelim ki bir `EMPLOYEES` tablosundan çalışanların yalnızca ad ve soyad sonuçlarını almak istiyorsunuz. Şu sorguyu yazarsınız:

`SELECT firstName, lastName FROM employees.`

Bu, `EMPLOYEES` tablosundaki `firstName` ve `lastName` sütunlarını getirir.

---

## 📋 Tablodaki Tüm Veriyi Getirme

Şimdi, sorguları nasıl yazacağınıza dair bazı diğer senaryoları inceleyelim.

Örneğin, bir tablodaki tüm veriyi almak isteyebilirsiniz.

Bunu yapmak için, her şeyi seçmek üzere bir yıldız işareti ( *asterisk* ) kullanırsınız. `EMPLOYEES` tablosundaki tüm sütunları ve satırları almak için şu sorguyu yazarsınız:

`SELECT asterisk FROM employees.`

---

## 🧼 Tekrarsız Veri Getirme: `SELECT DISTINCT`

Peki, yinelenenler olmadan veri almak isterseniz?

Yalnızca benzersiz değerleri almak ve tekrarları kaldırmak için `SELECT distinct` kullanabilirsiniz.

Örneğin, benzersiz departmanların bir listesini almak istediğinizi varsayalım. Şunu yazarsınız:

`SELECT distinct department FROM employees.`

Bu sorgu, birden fazla çalışan aynı departmanda olsa bile her departmanı yalnızca bir kez döndürür.

---

## 🏆 En Yüksek Değerleri Getirme: `SELECT TOP`

Ya yalnızca verinizdeki en yüksek değerleri almak istiyorsanız?

Örneğin, en yüksek maaşları bulmak için bir sorgu yazmak.

Bir koşula göre döndürülen satır sayısını sınırlamak için `SELECT top` kullanabilirsiniz.

`EMPLOYEES` tablosundaki en yüksek 5 maaşı almak için şu sorguyu yazarsınız:

`SELECT top 5 FROM employees ORDER BY salary DESC.`

Bu, sonucu en yüksek maaşa sahip 5 çalışanla sınırlar ve sonuçları `salary` değerine göre azalan sırada sıralar.

Bu yaklaşım, bir organizasyondaki en yüksek kazananlar gibi kilit veri noktalarına odaklanmanız gerektiğinde kullanışlıdır.

---

## ✅ Özet

Bu videoda, bir veritabanından veri getirmek için basit `SELECT` ifadelerini nasıl yazacağınızı öğrendiniz.

SQL’de doğru soruları sorabilme yeteneği, verilerle etkileşim kurma biçiminizi dönüştürebilir ve içlerinde gizli olan içgörülerin kilidini açabilir.

Bu temel `SELECT` ifadelerini pratik edin; yakında, ihtiyacınız olan veriyi ihtiyaç duyduğunuz anda tam olarak getirebileceksiniz.

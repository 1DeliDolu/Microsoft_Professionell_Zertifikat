## 🔗 SQL `JOIN` Yan Tümceleri ile Veri Birleştirme

### 📌 Giriş

SQL `JOIN` yan tümceleri, birden fazla tablodan veriyi birleştirmeyi sağlayan ve veritabanı yönetiminde kritik öneme sahip araçlardır. İlişkisel veritabanlarında veri, tekrarları ( *redundancy* ) önlemek için çoğu zaman farklı tablolara dağıtılarak tutulur. `JOIN`’lar, ilişkili bilgileri bir araya getirerek veriyi bütüncül biçimde analiz etmeyi ve yorumlamayı mümkün kılar.

---

## 🧠 SQL `JOIN` Yan Tümcelerinin Temel Kavramları

---

## 🧷 SQL `JOIN` Türleri

### ✅ `INNER JOIN`

Her iki tabloda da eşleşmesi olan satırları getirir. Yalnızca tablolar arasında ilişkili veri gerektiğinde kullanışlıdır.

---

### ⬅️ `LEFT JOIN`

Sol (ilk) tablodaki tüm satırları dahil eder; sağ tabloda eşleşmeyen satırlar için sağ tablo sütunlarında `NULL` döndürür.

Bu `JOIN`, ilişkili bilgi eksik olsa bile birincil tablonun verisini eksiksiz görmek gerektiğinde idealdir.

---

### ➡️ `RIGHT JOIN`

`LEFT JOIN`’un tersidir; sağ tablodaki tüm satırları ve sol tablodan eşleşen satırları döndürür. Eşleşmeyen durumlarda sol tarafa ait sütunlar `NULL` ile doldurulur.

---

### 🌐 `FULL OUTER JOIN`

Her iki tablodaki tüm satırları birleştirir; iki tarafta da eşleşme yoksa ilgili alanlarda `NULL` gösterir.

Bu, iki tablo genelinde tam bir veri görünümü sağlar.

---

## 🧱 `JOIN` Sözdizimi ve Pratik Örnekler

### 🧩 Temel Sözdizimi

```sql
SELECT columns FROM table1
JOIN table2 ON table1.column = table2.column;
```

Bu format, alınacak sütunları tanımlamak için `SELECT` ile başlar; ardından tabloları ve bağlayıcı sütunları belirtmek için `JOIN` ve `ON` kullanılır.

Bu yapı genellikle bir **primary key** ve **foreign key** ilişkisini içerir.

---

## 🧾 Örnek Kullanım Senaryoları

### ✅ `INNER JOIN`

Satın alma yapan müşterileri listelemek için.

---

### ⬅️ `LEFT JOIN`

Sipariş verip vermediğine bakmaksızın tüm müşterileri dahil etmek için.

---

### ➡️ `RIGHT JOIN`

Tüm siparişleri ve karşılık gelen müşteri detaylarını listelemek için; eşleşmeyen müşteriler için `NULL` değerleriyle.

---

### 🌐 `FULL OUTER JOIN`

Müşteriler ve siparişler arasında eşleşme olmasa bile her iki tablonun da tam görünümünü almak için.

---

## ✅ Sonuç

SQL `JOIN` yan tümceleri, tablolar arasında veriyi bağlamak için güçlü araçlardır ve verimli, içgörü üreten sorgular yazmayı mümkün kılar.

Her `JOIN` türünün kendine özgü amacını ve sözdizimini anlamak; ilişkisel veritabanlarında farklı veri getirme ihtiyaçlarını yönetmenizi sağlar ve veri analiz yeteneklerinizi geliştirir.

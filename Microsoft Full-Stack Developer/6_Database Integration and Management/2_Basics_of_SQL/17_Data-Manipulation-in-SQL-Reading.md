## 🧩 SQL’de Veri Manipülasyonu

### 📌 Giriş

Bu rehber; veritabanı kayıtlarını manipüle etmek için gerekli temel SQL komutlarını ( **INSERT** ,  **UPDATE** ,  **DELETE** ) sunar. Doğru ve güvenli veri yönetimini sağlamak için sözdizimini, pratik örnekleri ve en iyi uygulamaları vurgular.

---

## ➕ `INSERT` İfadeleri ile Veri Ekleme

**Kullanım:** Veritabanına yeni veri ekleme. Bu, tekil kayıtlar olarak veya birden çok kaydı içeren toplu eklemeler ( *batch inserts* ) olarak yapılabilir.

---

## 🧱 Temel `INSERT` Sözdizimi

Yeni kayıt eklemek için şunu kullanın:

```sql
INSERT INTO tableName (columnA, columnB) VALUES ('valueA', 'valueB');
```

Tabloyu ve sütunları belirtin, ardından belirtilen sıraya göre her sütun için değerleri girin.

---

## 1️⃣ Tekil ve Çoklu Ekleme

**Tek Kayıt:** Tek bir satır eklemek için tek bir değer kümesi kullanın.

```sql
INSERT INTO Customer (FirstName, LastName) VALUES ('John', 'Doe');
```

**Birden Fazla Kayıt:** Daha hızlı toplu ekleme için virgülle ayrılmış birden fazla değer kümesini birleştirin:

```sql
INSERT INTO Customer (FirstName, LastName) VALUES ('John', 'Doe'), ('Jane', 'Smith');
```

**Foreign Key Kısıtları:** Foreign key içeren tablolara ekleme yaparken, referans verilen verinin ilişkili tabloda mevcut olduğundan emin olun. Örneğin, bir `Order` tablosundaki `CustomerID`, `Customer` tablosundaki bir kayda karşılık gelmelidir.

---

## ✏️ Veri Güncelleme ve Silme

**Kullanım:** Belirtilen kriterleri karşılayan kayıtları günceller.

---

## 🧱 Temel `UPDATE` Sözdizimi

Hedef sütun(lar)ı ve bir koşulu belirterek mevcut kayıtları değiştirin:

```sql
UPDATE tableName SET columnA = 'newValue' WHERE condition;
```

`WHERE` yan tümcesi, tüm kayıtların istemeden güncellenmesini önlemek için kritiktir. Bu olmadan tablodaki tüm satırlar değiştirilecektir.

---

## 1️⃣ Tekil ve Çoklu Güncelleme

**Tek Güncelleme:** Belirli bir kaydı değiştirin:

```sql
UPDATE MusicCatalog SET Genre = 'Rock' WHERE songTitle = 'Hey Jude';
```

**Toplu Güncelleme:** Bir koşula göre birden fazla kayda değişiklik uygulayın:

```sql
UPDATE MusicCatalog SET popularity = 'Viral' WHERE weeklyListeners > 1000000;
```

---

## 🗑️ `DELETE` ile Veri Silme

**Kullanım:** Tekil veya birden çok kayıt kümesini kaldırmak, sistem sıfırlamaları yapmak veya güncelliğini yitirmiş veri kümelerini temizlemek için kullanışlıdır.

---

## 🧱 Temel `DELETE` Sözdizimi

Bir tablodan kayıtları kaldırmak için:

```sql
DELETE FROM tableName WHERE condition;
```

Belirli kayıtları hedeflemek için `WHERE` kullanın; bu olmadan tüm kayıtlar silinir. Örneğin:

```sql
DELETE FROM MusicCatalog WHERE songTitle = 'Obsolete Song';
```

**Tüm Kayıtları Silme:** Tüm veriyi temizlemek için `WHERE` yan tümcesini eklemeyin; bu, tablo yapısını olduğu gibi bırakır:

```sql
DELETE FROM tableName;
```

---

## 🛡️ En İyi Uygulamalar

**`UPDATE` ve `DELETE` ile Güvenlik:** Belirli kayıtları hedeflemek için her zaman `WHERE` yan tümcelerini kullanın.

**Doğrulama:** Öncesinde aynı `WHERE` koşuluna sahip bir `SELECT` ifadesi çalıştırarak yalnızca istenen kayıtların etkileneceğini doğrulayın.

**Değişiklik Öncesi Yedek:** Yanlışlıkla veri kaybını önlemek için toplu güncelleme veya silme işlemlerini yürütmeden önce veritabanını yedekleyin.

---

## ✅ Sonuç

Bu SQL veri manipülasyon komutlarında ( **INSERT** ,  **UPDATE** ,  **DELETE** ) ustalaşmak, veriyi verimli ve hassas biçimde yönetmenizi sağlar. Güvenlik ve doğrulama için en iyi uygulamaları izlemek, veri bütünlüğünü korumaya ve güvenilir veritabanı operasyonlarını desteklemeye yardımcı olur.

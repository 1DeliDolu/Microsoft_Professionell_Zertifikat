## 🧪 You Try It! SQL’de Veri Manipülasyonu Pratiği – Cevap Anahtarı

## 2️⃣ Adım 2: `INSERT` İşlemi

```sql
INSERT INTO Users (FirstName, LastName, Email, Age) VALUES
('Arjun', 'Patel', 'arjun.patel@example.com', 41);
```

**Beklenen Çıktı:** Users tablosuna yeni bir satır eklenir. Tablo sorgulandığında şu kayıt görünmelidir:

`4 | Arjun | Patel | arjun.patel@example.com | 41`

---

## 3️⃣ Adım 3: `UPDATE` İşlemi

```sql
UPDATE Users SET Age = 26 WHERE FirstName = 'Mei';
```

**Beklenen Çıktı:** `FirstName = 'Mei'` olan kaydın `Age` sütunu 26 olarak güncellenir.

---

## 4️⃣ Adım 4: `DELETE` İşlemi

```sql
DELETE FROM Users WHERE LastName = 'Garcia';
```

**Beklenen Çıktı:** `LastName = 'Garcia'` olan kayıt silinir. Tablo sorgulandığında şu kayıt artık görünmemelidir:

`2 | Carlos | Garcia | carlos.garcia@example.com | 35`

---

## 5️⃣ Adım 5: Güvenli SQL Pratikleri

### ❌ `WHERE` Kullanılmadan

```sql
UPDATE Users SET Age = 30;
```

**Gözlenen Davranış:** Users tablosundaki tüm satırların `Age` değeri 30 olarak ayarlanır.

---

### ↩️ Geri Alma ( *Rollback* )

```sql
ROLLBACK;
```

**Gözlenen Davranış:** Yapılan değişiklikler geri alınır.

---

### ✅ `WHERE` Kullanılarak

```sql
UPDATE Users SET Age = 30 WHERE FirstName = 'Arjun';
```

**Gözlenen Davranış:** Yalnızca `FirstName = 'Arjun'` olan satır güncellenir.

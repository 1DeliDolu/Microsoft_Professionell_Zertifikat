## 🧠 SQL Sözdizimini Anlamak

### 📌 Giriş

SQL ( *Structured Query Language* ), ilişkisel veritabanlarını yönetmek ve onlarla etkileşim kurmak için kullanılan ana dildir. Bu rehber, örneklerle birlikte temel SQL adımlarını size gösterecektir.

---

## 🧩 Adım 1: SQL Komutları Ne Yapar?

Sorgu yazmaya başlamadan önce, SQL komutlarının amacını bilmek önemlidir. SQL komutları şunları yapmanıza izin verir:

* Veri almak (ör. belirli kayıtları bulmak).
* Veritabanına yeni veri eklemek.
* Mevcut verileri güncellemek.
* Artık ihtiyaç duymadığınız verileri silmek.

---

## 🛠️ Adım 2: İlk SQL Sorgunuzu Oluşturun

Bir SQL sorgusunu adım adım nasıl oluşturacağınızı inceleyelim:

### 🎬 Bir Eylemle Başlayın

Veriyle ne yapmak istediğinize karar verin. Veritabanına hangi eylemi gerçekleştireceğini söylemek için anahtar kelimeleri kullanın:

* `SELECT` veriyi alır.
* `INSERT INTO` veri ekler.
* `UPDATE` veriyi değiştirir.
* `DELETE` veriyi kaldırır.

Örneğin, veritabanınızdaki tüm kitap başlıklarını görüntülemek için şunu kullanın:

```sql
SELECT bookTitle FROM books;
```

---

### 🎯 Sonuçlarınızı Daraltın

Sorgunuzu odaklamak için yan tümceleri ( *clauses* ) kullanın:

* `FROM` verinin nereden geldiğini belirtir (ör. tablo adı).
* `WHERE` sonuçları filtrelemek için koşullar belirler.

Örneğin, 2015’ten sonra yayımlanan kitapları bulmak için bir koşul ekleyin:

```sql
SELECT bookTitle FROM books WHERE publicationYear > 2015;
```

---

### 🧮 Gerektiğinde İfadeleri Kullanın

İfadeler ( *expressions* ), mantık veya hesaplama eklemenizi sağlar.

Örneğin, belirli bir yazara ait kitapları bulmak için şunu yazın:

```sql
SELECT bookTitle FROM books WHERE author = 'Specific Author';
```

---

## 📚 Adım 3: Temel SQL Komutlarını Örneklerle Öğrenin

Aşağıda en sık kullanacağınız SQL komutları yer alır:

### 🔎 `SELECT`: Veri Alma

Bir tablodan belirli sütunları veya tüm veriyi (`*`) almak için kullanılır.

Örneğin, yalnızca kitap başlıklarını almak için:

```sql
SELECT bookTitle FROM books;
```

---

### ➕ `INSERT INTO`: Yeni Veri Ekleme

Veritabanınıza yeni satırlar ekler.

Örneğin, listeye yeni bir kitap eklemek için:

```sql
INSERT INTO books (bookTitle, author, publicationYear) VALUES ('New Book', 'Author', 2021);
```

---

### ✏️ `UPDATE`: Mevcut Veriyi Değiştirme

Veritabanında mevcut olan bilgileri değiştirir.

Örneğin, bir kitabın yayımlanma yılını güncellemek için:

```sql
UPDATE books SET publicationYear = 2022 WHERE bookTitle = 'Old Book';
```

---

### 🗑️ `DELETE`: Veri Silme

Belirli bir koşulla eşleşen satırları kaldırır.

Örneğin, listeden bir kitabı silmek için:

```sql
DELETE FROM books WHERE bookTitle = 'Obsolete Book';
```

---

### 🎚️ `WHERE`: Sonuçları Filtreleme

`WHERE`, yukarıdaki komutların herhangi birine koşul uygulamak için kullanılır.

Örneğin, belirli bir yazara ait tüm kitapları bulmak için:

```sql
SELECT bookTitle FROM books WHERE author = 'Specific Author';
```

---

## ▶️ Adım 4: Sorgunuzu Çalıştırın

Artık sorgunuzu uygulamaya koyma zamanı:

* SQL editörünüzü veya veritabanı yönetim aracınızı açın.
* Uygun anahtar kelimeler, yan tümceler ve ifadelerle sorgunuzu yazın.
* Sorguyu çalıştırın ve sonuçları kontrol edin.
* Bir şey yanlış görünüyorsa, sorgu sözdiziminizi gözden geçirip düzeltin. Hata ayıklama öğrenme sürecinin bir parçasıdır!

---

## ✅ Sonuç

Tebrikler! SQL komutlarını yazmanın ve çalıştırmanın temellerini öğrendiniz. Güven kazanmak ve daha karmaşık veritabanı görevlerini yönetebilmek için bu adımları düzenli olarak pratik edin. Örnekleri deneyin ve sorgularınızı belirli ihtiyaçlara göre nasıl özelleştirebileceğinizi keşfedin.

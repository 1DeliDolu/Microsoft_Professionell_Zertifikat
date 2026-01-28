## 🧭 Genel Bakış

### 🧩 Etkinlik: Veritabanı Şeması Tasarımı

**Amaç:** Veriyi ilişkilere ve kısıtlara sahip tablolara düzenlemek için bir veritabanı şeması tasarlamak ve verinin farklı parçalarının nasıl bağlandığını görselleştirmek.

**Açıklama:** Bu etkinlik, veritabanı şemalarını adım adım tasarlamanıza yardımcı olacak örnekler sunar. Önce bir kitapçı ve bir film izleme servisi için pratik örneklerle başlayacak, ardından bir üniversite ve bir kütüphane sistemi için şema oluşturmayı deneyeceksiniz.

---

## 📚 Örnek 1: Kitapçı Veritabanı Şeması

### 🧠 Problemi Tanımla

Bir kitapçı için; kitaplar, yazarlar ve yayınevleri hakkında bilgi yönetebilen bir veritabanı tasarlayın.

### 🪜 Adım Adım Örnek

#### 1) 🗂️ Temel Kategorileri Belirle (Tablolar)

* **Books:** Her kitapla ilgili bilgiler
* **Authors:** Yazar bilgileri
* **Publishers:** Kitapları yayımlayan şirket bilgileri

#### 2) 🧱 Her Tablo için Sütunları Tanımla

**Books Tablosu:**

* **BookID:** Benzersiz tanımlayıcı *(Primary Key)*
* **Title:** Kitabın adı
* **ISBN:** Kitap için benzersiz kod
* **PublisherID:** Publishers tablosuna bağlanır *(Foreign Key)*

**Authors Tablosu:**

* **AuthorID:** Benzersiz tanımlayıcı *(Primary Key)*
* **FirstName:** Yazarın adı
* **LastName:** Yazarın soyadı

**Publishers Tablosu:**

* **PublisherID:** Benzersiz tanımlayıcı *(Primary Key)*
* **Name:** Yayınevi adı
* **Address:** Yayınevi adresi

**BookAuthors Tablosu (Çoğa-Çok İlişki):**

* **BookID:** Books tablosuna bağlanır *(Foreign Key)*
* **AuthorID:** Authors tablosuna bağlanır *(Foreign Key)*

#### 3) 🔗 İlişkileri Kur

* Her kitap **tek bir** yayınevine bağlıdır, ancak bir yayınevi **birçok** kitap yayımlayabilir  *(One-to-Many)* .
* Her kitap **birden çok** yazara sahip olabilir ve her yazar **birden çok** kitap yazabilir  *(Many-to-Many)* .

#### 4) 🧾 Şemayı Görselleştir (Görüldüğü Hâliyle)

**Books Tablosu:**

* BookID *(PK)*
* Title
* ISBN *(UNIQUE)*
* PublisherID *(FK)*

**Authors Tablosu:**

* AuthorID *(PK)*
* FirstName
* LastName

**Publishers Tablosu:**

* PublisherID *(PK)*
* Name
* Address

**BookAuthors Tablosu:**

* BookID *(FK)*
* AuthorID *(FK)*

---

## 🎬 Örnek 2: Film İzleme Servisi Veritabanı Şeması

### 🧠 Problemi Tanımla

Bir film izleme servisi için; filmler, yönetmenler ve oyuncular hakkında bilgi saklayan bir veritabanı tasarlayın.

### 🪜 Adım Adım Örnek

#### 1) 🗂️ Temel Kategorileri Belirle (Tablolar)

* **Movies:** Her filmle ilgili ayrıntılar
* **Directors:** Yönetmen bilgileri
* **Actors:** Oyuncu bilgileri

#### 2) 🧱 Her Tablo için Sütunları Tanımla

**Movies Tablosu:**

* **MovieID:** Benzersiz tanımlayıcı *(Primary Key)*
* **Title:** Filmin adı
* **ReleaseYear:** Filmin çıkış yılı
* **DirectorID:** Directors tablosuna bağlanır *(Foreign Key)*

**Directors Tablosu:**

* **DirectorID:** Benzersiz tanımlayıcı *(Primary Key)*
* **Name:** Yönetmenin adı

**Actors Tablosu:**

* **ActorID:** Benzersiz tanımlayıcı *(Primary Key)*
* **Name:** Oyuncunun adı

**MovieActors Tablosu (Çoğa-Çok İlişki):**

* **MovieID:** Movies tablosuna bağlanır *(Foreign Key)*
* **ActorID:** Actors tablosuna bağlanır *(Foreign Key)*

#### 3) 🔗 İlişkileri Kur

* Her film **tek bir** yönetmen tarafından yönetilir, ancak bir yönetmen **birçok** film yönetebilir  *(One-to-Many)* .
* Her film **birçok** oyuncu içerebilir ve her oyuncu **birçok** filmde yer alabilir  *(Many-to-Many)* .

#### 4) 🧾 Şemayı Diyagramla

**Movies Tablosu:**

* MovieID *(PK)*
* Title
* ReleaseYear
* DirectorID *(FK)*

**Directors Tablosu:**

* DirectorID *(PK)*
* Name

**Actors Tablosu:**

* ActorID *(PK)*
* Name

**MovieActors Tablosu:**

* MovieID *(FK)*
* ActorID *(FK)*

---

## 🏫 Etkinlik Görevi 1: Üniversite Veritabanı Şeması

### 🧠 Problemi Tanımla

Bir üniversitenin; öğrencileri, dersleri ve profesörleri yönetebilmesi için bir veritabanı tasarlayın.

### 🪜 Görevi Tamamlama Adımları

* Tabloları belirleyin:  **Students** ,  **Courses** ,  **Professors** .
* Her tablo için sütunlara karar verin.
* Tabloları şu ilişkilerle bağlayın:
  * Her profesör **birçok** ders verebilir, ancak bir ders **tek bir** profesör tarafından verilir  *(One-to-Many)* .
  * Her öğrenci **birçok** derse kayıt olabilir ve her ders **birçok** öğrenciye sahip olabilir  *(Many-to-Many)* .

---

## 📖 Etkinlik Görevi 2: Kütüphane Yönetim Şeması

### 🧠 Problemi Tanımla

Bir kütüphanenin; üyeleri, kitapları ve ödünç alma işlemlerini yönetebilmesi için bir veritabanı tasarlayın.

### 🪜 Görevi Tamamlama Adımları

* Tabloları belirleyin:  **Members** ,  **Books** ,  **Loans** .
* Her tablo için sütunlara karar verin.
* Tabloları şu ilişkilerle bağlayın:
  * Bir ödünç alma işlemi ( *loan* ), bir üyeyi bir kitaba bağlar  *(One-to-Many)* .
  * Bir kitap, farklı üyeler tarafından birçok kez ödünç alınabilir  *(Many-to-Many)* .

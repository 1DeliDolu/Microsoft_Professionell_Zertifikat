## 🧪 You Try It! SQL’de Veri Manipülasyonu Pratiği

## 1️⃣ Adım 1: Uygulama için Hazırlık

MySQL kullanarak örnek bir veritabanını yönetmek için küçük bir uygulama oluşturacaksınız. Uygulama, **Users** adlı bir tabloda `INSERT`, `UPDATE` ve `DELETE` işlemlerini yapmanıza izin verecek.

### ✅ Talimatlar

Visual Studio Code’u açın ve terminal üzerinden MySQL veritabanınıza bağlanın.

Aşağıdaki komutla **SampleDB** adlı yeni bir veritabanı oluşturun:

```sql
CREATE DATABASE SampleDB;
```

Yeni veritabanını kullanın:

```sql
USE SampleDB;
```

Aşağıdaki yapıda **Users** adlı bir tablo oluşturun:

```sql
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    Age INT
);
```

**Users** tablosunu örnek verilerle doldurun:

```sql
INSERT INTO Users (FirstName, LastName, Email, Age) VALUES
('Aisha', 'Khan', 'aisha.khan@example.com', 29),
('Carlos', 'Garcia', 'carlos.garcia@example.com', 35),
('Mei', 'Chen', 'mei.chen@example.com', 24);
```

---

## 2️⃣ Adım 2: `INSERT` İşlemini Uygulama

**Users** tablosuna yeni bir kullanıcı eklemek için bir sorgu yazacaksınız.

### ✅ Talimatlar

Aşağıdaki detaylarla yeni bir kullanıcı ekleyin:

* FirstName: Arjun
* LastName: Patel
* Email: [arjun.patel@example.com](mailto:arjun.patel@example.com)
* Age: 41

Kullanıcının başarıyla eklendiğinden emin olmak için tabloyu sorgulayın.

---

## 3️⃣ Adım 3: `UPDATE` İşlemini Uygulama

Mevcut bir kullanıcının yaşını güncellemek için bir sorgu yazacaksınız.

### ✅ Talimatlar

`FirstName` değeri **Mei** olan kullanıcının yaşını **26** olarak güncelleyin.

Yalnızca hedeflenen kaydın güncellendiğini doğrulamak için tabloyu sorgulayın.

---

## 4️⃣ Adım 4: `DELETE` İşlemini Uygulama

**Users** tablosundan bir kullanıcıyı silmek için bir sorgu yazacaksınız.

### ✅ Talimatlar

`LastName` değeri **Garcia** olan kullanıcıyı silin.

Kaydın silindiğini doğrulamak için tabloyu sorgulayın.

---

## 5️⃣ Adım 5: Pratik

İstenmeyen değişiklikleri önlemek için `WHERE` yan tümcesini kullanarak güvenli SQL pratikleri yapacaksınız.

### ✅ Talimatlar

`WHERE` kullanmadan tüm kullanıcıların yaşını 30’a güncellemeyi deneyin. Davranışı gözlemleyin.

Aşağıdaki komutla değişiklikleri geri alın:

```sql
ROLLBACK;
```

Bu kez belirli bir kullanıcı için güncellemeyi `WHERE` kullanarak tekrar deneyin ve istenmeyen değişiklikleri önleyin.

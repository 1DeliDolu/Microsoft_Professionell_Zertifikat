## 🔌 MySQL Sunucusuna Bağlantının Aktif Olduğundan Emin Olma

### ✅ Adımlar

* **Visual Studio Code** ’u açın.
* Yan çubukta **MySQL Shell** ikonuna tıklayıp eklentiye erişin.

**MySQL sunucunuza bağlanın:**

* **New Connection** ’a tıklayarak MySQL’e bağlantı oluşturun.
* İstenirse MySQL sunucu bilgilerinizi girin (örn. *host:* `localhost`, *user:* `root`, *password:* `password`).

**Bağlantıyı basit bir sorgu ile doğrulayın.** Editör’de aşağıdaki SQL ifadesini oluşturun:

```sql
SHOW DATABASES;
```

Sorguyu, kod penceresinin üstündeki **Execute (şimşek)** düğmesine tıklayarak çalıştırın.

---

## 🏗️ Veritabanı Oluşturma ve Temel Ayarları Yapılandırma

### ✅ Adımlar

Editör’de aşağıdaki SQL komutunu çalıştırarak yeni bir veritabanı oluşturun:

```sql
CREATE DATABASE CompanyDB;
```

Yeni veritabanını oturumunuz için varsayılan olarak ayarlayın:

```sql
USE CompanyDB;
```

Aşağıdaki yapıda **Employees** adlı bir tablo oluşturun:

* **EmployeeID** *(Primary Key, INT, Auto Increment)*
* **FirstName** *(VARCHAR, 50)*
* **LastName** *(VARCHAR, 50)*
* **Department** *(VARCHAR, 50)*

```sql
CREATE TABLE Employees (
  EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
  FirstName VARCHAR(50),
  LastName VARCHAR(50),
  Department VARCHAR(50)
);
```

---

## 🔐 Veritabanını Güvence Altına Alma: Kullanıcı Oluşturma ve Yetki Verme

### ✅ Adımlar

Veritabanına erişim için yeni bir kullanıcı oluşturun:

```sql
CREATE USER 'manager'@'localhost' IDENTIFIED BY 'StrongPassword123';
```

Bu kullanıcıya **CompanyDB** veritabanı için yetki verin:

```sql
GRANT ALL PRIVILEGES ON CompanyDB.* TO 'manager'@'localhost';
```

Yeni kullanıcıyı test etmek için bu hesapla veritabanına bağlanın.

---

## ✅ Veritabanı ve Kullanıcının Beklendiği Gibi Çalıştığını Doğrulama

### ✅ Adımlar

**Employees** tablosuna örnek bir kayıt ekleyin:

```sql
INSERT INTO Employees (FirstName, LastName, Department) 
VALUES ('John', 'Doe', 'HR');
```

Kaydın eklendiğini doğrulamak için tabloyu sorgulayın:

```sql
SELECT * FROM Employees;
```

**manager** kullanıcısının veritabanına erişip sorgu çalıştırabildiğini doğrulamak için bu kullanıcıyla giriş yapıp aynı sorguyu çalıştırın.

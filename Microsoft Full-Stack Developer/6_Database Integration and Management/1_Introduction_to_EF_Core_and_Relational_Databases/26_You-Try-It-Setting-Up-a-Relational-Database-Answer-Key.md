## ✅ You Try It! İlişkisel Veritabanı Kurulumu – Cevap Anahtarı

---

## 🏗️ Adım 2: Veritabanını Yapılandırma

```sql
CREATE DATABASE CompanyDB;
USE CompanyDB;

CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50)
);
```

---

## 🔐 Adım 3: Kullanıcı Hesapları ve Yetkileri Yapılandırma

```sql
CREATE USER 'manager'@'localhost' IDENTIFIED BY 'StrongPassword123';
GRANT ALL PRIVILEGES ON CompanyDB.* TO 'manager'@'localhost';
```

---

## ✅ Adım 4: Kurulumu Test Etme ve Doğrulama

**Ekleme ve sorgulama komutları:**

```sql
INSERT INTO Employees (FirstName, LastName, Department) 
VALUES ('John', 'Doe', 'HR');

SELECT * FROM Employees;
```

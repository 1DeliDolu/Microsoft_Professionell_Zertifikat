## 🧪 Sen Deneyin! İleri SQL, İşlemler ve Saklı Yordamlar

## 🧩 Etkinlik: Saklı Yordamlar ve Fonksiyonlarla İleri SQL Tekniklerini Uygulama

### 🎯 Amaç

Bu etkinliğin sonunda, SQL işlemlerini otomatikleştirmek için saklı yordamlar ve fonksiyonlar oluşturmuş ve çalıştırmış olacaksınız. Bir veritabanı kuracak, örnek verilerle dolduracak ve SQL görevlerini saklı yordamlar ve fonksiyonlar kullanarak yöneteceksiniz. Bu etkinlik, ileri SQL teknikleriyle çalışma, işlemleri ( *transactions* ) yönetme ve veritabanı operasyonlarını optimize etme becerinizi pekiştirecektir.

---

## 🧰 Ortam Kurulumu: EmployeeDB Oluşturma ve Örnek Veri Ekleme

Aşağıdaki adımları izleyerek MySQL’i Visual Studio Code içinde kullanarak **EmployeeDB** adlı bir veritabanı oluşturacak ve örnek verilerle dolduracaksınız.

---

## 🟦 Talimatlar

### 🧭 1) Visual Studio Code’da MySQL’i Açın

Visual Studio Code içinde MySQL’i açın.

---

### 🗄️ 2) Yeni Bir Veritabanı Oluşturun

Aşağıdaki komutla yeni bir veritabanı oluşturun:

```sql
CREATE DATABASE EmployeeDB;
```

---

### 🔁 3) Oluşturulan Veritabanına Geçin

Yeni oluşturduğunuz veritabanını kullanmak için:

```sql
USE EmployeeDB;
```

---

### 🧾 4) Employees Tablosunu Oluşturun

Çalışan verilerini saklamak için **Employees** adlı tabloyu oluşturun:

```sql
CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10, 2),
    HireDate DATE
);
```

---

### 👥 5) Çeşitli ve Kapsayıcı Örnek Verilerle Tabloyu Doldurun

Aşağıdaki örnek verileri ekleyin:

```sql
INSERT INTO Employees (FirstName, LastName, Department, Salary, HireDate)
VALUES
    ('Aisha', 'Khan', 'Finance', 85000.00, '2019-03-15'),
    ('Luis', 'Garcia', 'IT', 95000.00, '2020-07-22'),
    ('Chloe', 'Nguyen', 'Marketing', 72000.00, '2018-10-05'),
    ('Amara', 'Smith', 'HR', 67000.00, '2021-01-18'),
    ('Ravi', 'Patel', 'Finance', 88000.00, '2017-11-03');
```

---

### ✅ 6) Veriyi Doğrulayın

Employees tablosundaki tüm kayıtları görüntülemek için:

```sql
SELECT * FROM Employees;
```

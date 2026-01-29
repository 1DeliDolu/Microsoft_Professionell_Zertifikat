## 🧪 You Try It! `SELECT` İfadeleri Yazma

### 🎯 Etkinlik: `SELECT`, `WHERE` ve `ORDER BY` ile Veriyi Getirme ve Manipüle Etme

Bu etkinlik, örnek bir veritabanı kurmanızı, temel SQL sorgularıyla veriyi getirmenizi ve filtreleme/sıralama işlevlerini kullanmanızı sağlar. Etkinliğin sonunda `WHERE` ve `ORDER BY` ile birlikte `SELECT` ifadelerini kullanarak veriyi etkili biçimde manipüle edip geri alabileceksiniz.

---

## 🏗️ Adım 1: Veritabanı Kurulumu için Hazırlık

Örnek bir veritabanı ve üzerinde çalışacağınız bir tablo oluşturacaksınız. Bu adım, MySQL kurulumu ve örnek verilerle veritabanını doldurmayı içerir.

### 📌 Talimatlar

Visual Studio Code’u açın ve MySQL veritabanınıza bağlanın.

Aşağıdaki komutu çalıştırarak **EmployeeDB** adında yeni bir veritabanı oluşturun:

```sql
CREATE DATABASE EmployeeDB;
```

**EmployeeDB** veritabanına geçin:

```sql
USE EmployeeDB;
```

Aşağıdaki sütunlara sahip **Employees** adlı bir tablo oluşturun:

* ID (INT, Primary Key, Auto Increment)
* FirstName (VARCHAR(50))
* LastName (VARCHAR(50))
* Department (VARCHAR(50))
* Salary (DECIMAL(10,2))
* YearsExperience (INT)

Employees tablosunu oluşturmak ve örnek verilerle doldurmak için aşağıdaki SQL’i kullanın:

```sql
CREATE TABLE Employees (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    YearsExperience INT
);

INSERT INTO Employees (FirstName, LastName, Department, Salary, YearsExperience) VALUES
('John', 'Doe', 'HR', 60000, 10),
('Jane', 'Smith', 'Finance', 70000, 8),
('Michael', 'Brown', 'IT', 50000, 5),
('Emily', 'Davis', 'HR', 45000, 2),
('Chris', 'Wilson', 'Finance', 80000, 15);
```

---

## 📥 Adım 2: `SELECT` ile Veri Getirme

Temel `SELECT` ifadeleriyle veri getirmeyi öğrenin.

### ✅ Talimatlar

Employees tablosundaki tüm satırlar için tüm sütunları getiren bir sorgu yazın.

Employees tablosundaki çalışanların yalnızca `FirstName` ve `LastName` sütunlarını getiren bir sorgu yazın.

`DISTINCT` kullanarak benzersiz departman adlarını getiren bir sorgu yazın.

---

## 🎯 Adım 3: `WHERE` ile Veriyi Filtreleme

Koşullara göre veriyi filtrelemek için `WHERE` yan tümcesini kullanma pratiği yapın.

### ✅ Talimatlar

HR departmanındaki tüm çalışanları getiren bir sorgu yazın.

Finance departmanında olup maaşı 60.000’den büyük olan çalışanları bulan bir sorgu yazın.

Deneyimi 5 yıldan fazla olup maaşı 70.000’den az olan çalışanları bulan bir sorgu yazın.

---

## 🔃 Adım 4: `ORDER BY` ile Veriyi Sıralama

Sonuçları düzenlemek için `ORDER BY` yan tümcesini kullanmayı öğrenin.

### ✅ Talimatlar

Tüm çalışanları `LastName` alanına göre artan sırada sıralayan bir sorgu yazın.

HR departmanındaki çalışanları `Salary` alanına göre azalan sırada sıralayan bir sorgu yazın.

Tüm departmanlarda en yüksek maaş alan ilk 3 çalışanı getiren bir sorgu yazın.

---

## 🧩 Adım 5: `WHERE` ve `ORDER BY` Birleştirme

Daha gelişmiş sorgular yazmak için filtreleme ve sıralamayı birleştirin.

### ✅ Talimatlar

IT departmanındaki ve deneyimi 3 yıldan fazla olan çalışanları `YearsExperience` alanına göre azalan sırada getiren bir sorgu yazın.

Maaşı 50.000 ile 75.000 arasında olan çalışanları `FirstName` alanına göre artan sırada getiren bir sorgu yazın.

## 🧪 You Try It! SQL Fonksiyonları ve Toplu ( *Aggregate* ) Fonksiyonları Uygulama

## 1️⃣ Adım 1: Uygulama için Hazırlık

MySQL kullanarak küçük bir veritabanı oluşturacak ve örnek verilerle dolduracaksınız. Bu veritabanı, SQL fonksiyonları ve toplu ( *aggregate* ) fonksiyonları pratik etmenizi sağlayacak.

MySQL ortamınızı veya terminalinizi açın.

Aşağıdaki SQL komutunu kullanarak **EmployeeDB** adlı yeni bir veritabanı oluşturun:

```sql
CREATE DATABASE EmployeeDB;
USE EmployeeDB;
```

Aşağıdaki şemaya sahip **Employees** adlı bir tablo oluşturun:

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

Employees tablosuna örnek verileri ekleyin:

```sql
INSERT INTO Employees (FirstName, LastName, Department, Salary, HireDate) VALUES
('Liam', 'Nguyen', 'Engineering', 85000.00, '2020-03-15'),
('Sophia', 'Smith', 'Marketing', 72000.00, '2019-05-22'),
('Raj', 'Patel', 'Sales', 64000.00, '2021-07-01'),
('Aisha', 'Khan', 'HR', 60000.00, '2020-09-12'),
('Carlos', 'Martinez', 'Engineering', 93000.00, '2018-12-01'),
('Chen', 'Zhao', 'Marketing', 77000.00, '2017-11-05'),
('Amara', 'Okafor', 'Sales', 67000.00, '2022-03-18');
```

---

## 2️⃣ Adım 2: Veri Manipülasyonu için SQL Fonksiyonlarını Kullanma

`CONCAT`, `UPPER`, `LOWER`, `LENGTH` ve `SUBSTRING` gibi temel SQL fonksiyonlarını kullanarak veriyi manipüle eden sorgular yazın.

Çalışanların ad ve soyadlarını `FullName` adlı tek bir sütunda birleştiren bir sorgu yazın.

`Department` sütununu büyük harfe dönüştürmek için `UPPER` fonksiyonunu kullanın.

`LastName` sütununu küçük harfe dönüştürmek için `LOWER` fonksiyonunu kullanın.

Her çalışanın `FirstName` uzunluğunu hesaplamak için `LENGTH` fonksiyonunu kullanın.

`LastName` sütunundaki ilk üç karakteri çıkarmak için `SUBSTRING` fonksiyonunu kullanın.

---

## 3️⃣ Adım 3: Toplu ( *Aggregate* ) Fonksiyonları Kullanma

`COUNT`, `SUM`, `AVG`, `MIN` ve `MAX` gibi toplu fonksiyonları kullanarak veriyi analiz eden sorgular yazın.

Şirketteki toplam çalışan sayısını sayın.

Tüm çalışanlar için toplam maaş harcamasını hesaplayın.

Engineering departmanındaki çalışanların ortalama maaşını bulun.

Şirketteki minimum maaşı belirleyin.

Sales departmanındaki maksimum maaşı belirleyin.

---

## 4️⃣ Adım 4: `GROUP BY` ile Toplu Fonksiyonları Birleştirme

Veriyi belirli sütunlara göre gruplandırıp toplu fonksiyonları uygulayan sorgular yazın.

Çalışanları `Department` alanına göre gruplayın ve her departman için toplam maaşı hesaplayın.

Çalışanları `Department` alanına göre gruplayın ve her departmandaki ortalama maaşı bulun.

`GROUP BY` kullanarak her departmandaki çalışan sayısını sayın.

---

## 5️⃣ Adım 5: Gelişmiş Fonksiyonları Keşfetme

SQL fonksiyonları ve toplu fonksiyonların kombinasyonlarını deneyin.

`FirstName` ve `LastName` değerlerini birleştirin, ardından oluşan tam adın uzunluğunu hesaplayın.

`COUNT` ve `GROUP BY` kombinasyonunu kullanarak her yıl kaç çalışanın işe alındığını bulun (`HireDate` içinden yıl bilgisini çıkarın).

`SUM` ve `GROUP BY` kullanarak işe alım yılına göre toplam maaş harcamasını hesaplayın.

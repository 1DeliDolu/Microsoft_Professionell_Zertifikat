## 🧪 You Try It! `SELECT` İfadeleri Yazma – Cevap Anahtarı

## 1️⃣ Adım 1

```sql
CREATE DATABASE EmployeeDB;
USE EmployeeDB;

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

## 2️⃣ Adım 2: `SELECT` ile Veri Getirme

### 📥 Tüm sütunları getir

```sql
SELECT * FROM Employees;
```

### 👤 Belirli sütunları getir

```sql
SELECT FirstName, LastName FROM Employees;
```

### 🧼 Benzersiz departmanları getir

```sql
SELECT DISTINCT Department FROM Employees;
```

---

## 3️⃣ Adım 3: `WHERE` ile Filtreleme

### 🧑‍💼 HR departmanındaki çalışanlar

```sql
SELECT * FROM Employees WHERE Department = 'HR';
```

### 💰 Finance departmanında maaşı 60.000’den büyük olanlar

```sql
SELECT * FROM Employees WHERE Department = 'Finance' AND Salary > 60000;
```

### 🧠 Deneyimi 5 yıldan fazla ve maaşı 70.000’den az olanlar

```sql
SELECT * FROM Employees WHERE YearsExperience > 5 AND Salary < 70000;
```

---

## 4️⃣ Adım 4: `ORDER BY` ile Sıralama

### 🔤 `LastName` alanına göre artan sıralama

```sql
SELECT * FROM Employees ORDER BY LastName ASC;
```

### 📉 HR çalışanlarını maaşa göre azalan sıralama

```sql
SELECT * FROM Employees WHERE Department = 'HR' ORDER BY Salary DESC;
```

### 🏆 En yüksek maaş alan ilk 3 kişi

```sql
SELECT * FROM Employees ORDER BY Salary DESC LIMIT 3;
```

---

## 5️⃣ Adım 5: `WHERE` + `ORDER BY` Birleştirme

### 🧑‍💻 IT departmanında deneyimi 3 yıldan fazla olanları deneyime göre azalan sırala

```sql
SELECT * FROM Employees WHERE Department = 'IT' AND YearsExperience > 3 ORDER BY YearsExperience DESC;
```

### 🎯 Maaşı 50.000–75.000 arasında olanları ada göre artan sırala

```sql
SELECT * FROM Employees WHERE Salary BETWEEN 50000 AND 75000 ORDER BY FirstName ASC;
```

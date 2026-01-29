## 🧪 You Try It! SQL Fonksiyonları ve Toplu ( *Aggregate* ) Fonksiyonları Uygulama – Cevap Anahtarı

## 2️⃣ Adım 2: Veri Manipülasyonu için SQL Fonksiyonlarını Kullanma

### 🔗 İsimleri birleştirme

```sql
SELECT CONCAT(FirstName, ' ', LastName) AS FullName FROM Employees;
```

### 🔠 Departmanı büyük harfe çevirme

```sql
SELECT UPPER(Department) AS UpperDepartment FROM Employees;
```

### 🔡 Soyadı küçük harfe çevirme

```sql
SELECT LOWER(LastName) AS LowerLastName FROM Employees;
```

### 📏 Adların uzunluğunu hesaplama

```sql
SELECT LENGTH(FirstName) AS FirstNameLength FROM Employees;
```

### ✂️ Soyadın ilk üç karakterini alma

```sql
SELECT SUBSTRING(LastName, 1, 3) AS LastNameSnippet FROM Employees;
```

---

## 3️⃣ Adım 3: Toplu ( *Aggregate* ) Fonksiyonları Kullanma

### 🔢 Toplam çalışan sayısını sayma

```sql
SELECT COUNT(*) AS TotalEmployees FROM Employees;
```

### ➕ Toplam maaşı hesaplama

```sql
SELECT SUM(Salary) AS TotalSalary FROM Employees;
```

### 📊 Engineering departmanında ortalama maaş

```sql
SELECT AVG(Salary) AS AvgEngineeringSalary FROM Employees WHERE Department = 'Engineering';
```

### 📉 Minimum maaş

```sql
SELECT MIN(Salary) AS MinSalary FROM Employees;
```

### 📈 Sales departmanında maksimum maaş

```sql
SELECT MAX(Salary) AS MaxSalesSalary FROM Employees WHERE Department = 'Sales';
```

---

## 4️⃣ Adım 4: `GROUP BY` ile Toplu Fonksiyonları Birleştirme

### 🧾 Departmana göre toplam maaş

```sql
SELECT Department, SUM(Salary) AS TotalSalary FROM Employees GROUP BY Department;
```

### 📌 Departmana göre ortalama maaş

```sql
SELECT Department, AVG(Salary) AS AvgSalary FROM Employees GROUP BY Department;
```

### 👥 Departmana göre çalışan sayısı

```sql
SELECT Department, COUNT(*) AS EmployeeCount FROM Employees GROUP BY Department;
```

---

## 5️⃣ Adım 5: Gelişmiş Fonksiyonları Keşfetme

### 🧩 Birleştirilmiş adların uzunluğu

```sql
SELECT CONCAT(FirstName, ' ', LastName) AS FullName, LENGTH(CONCAT(FirstName, ' ', LastName)) AS FullNameLength FROM Employees;
```

### 📅 İşe alım yılına göre çalışan sayısı

```sql
SELECT YEAR(HireDate) AS HireYear, COUNT(*) AS EmployeeCount FROM Employees GROUP BY HireYear;
```

### 💰 İşe alım yılına göre toplam maaş

```sql
SELECT YEAR(HireDate) AS HireYear, SUM(Salary) AS TotalSalary FROM Employees GROUP BY HireYear;
```

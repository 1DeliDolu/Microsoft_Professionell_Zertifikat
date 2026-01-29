## 🧪 Sen Deneyin! İleri SQL, İşlemler ve Saklı Yordamlar

## 🧩 Etkinlik: Saklı Yordamlar ve Fonksiyonlarla İleri SQL Tekniklerini Uygulama

### 🎯 Amaç

Bu etkinliğin sonunda, SQL işlemlerini otomatikleştirmek için saklı yordamlar ve fonksiyonlar oluşturmuş ve çalıştırmış olacaksınız. Bir veritabanı kuracak, örnek verilerle dolduracak ve SQL görevlerini saklı yordamlar ile fonksiyonlar kullanarak yöneteceksiniz. Bu etkinlik, ileri SQL teknikleriyle çalışma, işlemleri ( *transactions* ) yönetme ve veritabanı operasyonlarını optimize etme becerinizi pekiştirecektir.

---

## ✅ Sen Deneyin! İleri SQL, İşlemler ve Saklı Yordamlar - Cevap Anahtarı

### 🧾 Adım 2: Saklı Yordam

```sql
DELIMITER $$
CREATE PROCEDURE IncreaseSalary (
    IN deptName VARCHAR(50),
    IN increment DECIMAL(10, 2)
)
BEGIN
    IF increment <= 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Increment must be positive';
    END IF;

    UPDATE Employees
    SET Salary = Salary + increment
    WHERE Department = deptName;

    IF ROW_COUNT() = 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Department not found';
    END IF;
END$$
DELIMITER ;
```

**Çalıştırma (Execution):**

```sql
CALL IncreaseSalary('Finance', 5000);
SELECT * FROM Employees;
```

---

### 🔢 Adım 3: Scalar Fonksiyon

```sql
DELIMITER $$
CREATE FUNCTION CalculateBonus (salary DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
DETERMINISTIC
BEGIN
    IF salary <= 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Salary must be positive';
    END IF;
    RETURN salary * 0.10;
END$$
DELIMITER ;
```

**Kullanım (Usage):**

```sql
SELECT FirstName, LastName, CalculateBonus(Salary) AS Bonus FROM Employees;
```

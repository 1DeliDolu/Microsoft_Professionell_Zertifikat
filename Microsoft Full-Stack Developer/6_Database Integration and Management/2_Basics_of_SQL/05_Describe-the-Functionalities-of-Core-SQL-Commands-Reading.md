## 🧰 Temel SQL Komutlarının İşlevlerini Tanımlama

### 📌 Giriş

Bu rehber, veri alma, manipülasyon ve bakım için temel SQL komutlarının temel işlevlerini özetler.

---

## 📚 SQL Komut Rehberi

### 🔎 `SELECT` – Veri Alma

Belirtilen sütunlara veya koşullara göre bir tablodan belirli verileri seçer.

Örnek: `SELECT * FROM Employees` tüm kayıtları getirir; `SELECT * FROM Employees WHERE Department = 'Marketing'` departmana göre filtreler.

---

### ➕ `INSERT INTO` – Veri Ekleme

Yeni kayıtlar ekler veya başka bir tablodan veri kopyalar.

Örnek: `INSERT INTO Employees (Name, Department) VALUES ('John Doe', 'Sales')` tek bir kayıt ekler.

---

### ✏️ `UPDATE` – Veri Güncelleme

Bir tablodaki mevcut kayıtları günceller.

Örnek: `UPDATE Employees SET Salary = 50000 WHERE Name = 'John Doe'` maaş değerini değiştirir.

---

### 🗑️ `DELETE` – Veri Silme

Belirli veya birden çok kaydı siler.

Örnek: `DELETE FROM Employees WHERE Department = 'Sales'` satış departmanındaki tüm kayıtları kaldırır.

---

### 🔗 `JOIN` Yan Tümceleri – Tabloları Birleştirme

Ortak bir sütuna dayanarak birden fazla tablo arasında veriyi birleştirir.

Örnek: `SELECT Employees.Name, Departments.Department FROM Employees JOIN Departments ON Employees.DepartmentID = Departments.ID`.

---

## ✅ Sonuç

Bu SQL komutlarında ustalaşmak, veritabanı görevlerini daha akıcı hâle getirerek veri yönetimi verimliliğini artırır. Veriyi doğru ve verimli şekilde manipüle etme konusunda güven kazanmak için her komutu pratik edin.

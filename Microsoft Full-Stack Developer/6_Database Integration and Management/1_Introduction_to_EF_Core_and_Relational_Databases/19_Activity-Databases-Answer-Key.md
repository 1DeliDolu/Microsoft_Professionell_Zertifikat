## ✅ Etkinlik: Veritabanları – Cevap Anahtarı

---

## 🏫 Görev 1: Üniversite Veritabanı Şeması

### 🗂️ Tablolar ve İlişkiler

**Students Tablosu:**

* **StudentID** *(PK)*
* **Name**
* **Email**

**Courses Tablosu:**

* **CourseID** *(PK)*
* **CourseName**
* **ProfessorID** *(FK)*

**Professors Tablosu:**

* **ProfessorID** *(PK)*
* **Name**
* **Department**

**StudentCourses Tablosu (Junction Table):**

* **StudentID** *(FK)*
* **CourseID** *(FK)*

### 🧾 Diyagram

**Students Tablosu:**

* StudentID *(PK)*
* Name
* Email

**Courses Tablosu:**

* CourseID *(PK)*
* CourseName
* ProfessorID *(FK)*

**Professors Tablosu:**

* ProfessorID *(PK)*
* Name
* Department

**StudentCourses Tablosu:**

* StudentID *(FK)*
* CourseID *(FK)*

---

## 📚 Görev 2: Kütüphane Yönetim Şeması

### 🗂️ Tablolar ve İlişkiler

**Members Tablosu:**

* **MemberID** *(PK)*
* **Name**
* **Phone**

**Books Tablosu:**

* **BookID** *(PK)*
* **Title**
* **Author**

**Loans Tablosu:**

* **LoanID** *(PK)*
* **MemberID** *(FK)*
* **BookID** *(FK)*
* **LoanDate**
* **ReturnDate**

### 🧾 Diyagram

**Members Tablosu:**

* MemberID *(PK)*
* Name
* Phone

**Books Tablosu:**

* BookID *(PK)*
* Title
* Author

**Loans Tablosu:**

* LoanID *(PK)*
* MemberID *(FK)*
* BookID *(FK)*
* LoanDate
* ReturnDate

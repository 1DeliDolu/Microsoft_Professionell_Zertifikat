## 🧩 EF Core ile CRUD İşlemleri Gerçekleştirme

---

## 🧾 Giriş

Bu okuma, EF Core’da CRUD ( **Create, Read, Update, Delete** ) işlemlerini açıklar ve ilişkisel veritabanlarında veriyi yönetmek için gerekli olan `DbContext` ve ilgili metotlar kullanılarak nasıl uygulanacağını gösterir.

---

## 🔑 Temel Noktalar

### 🔄 CRUD Genel Bakış

CRUD işlemleri veri yönetiminin temelidir. Veritabanı içinde kayıtları oluşturma, okuma, güncelleme ve silme eylemlerini içerir. EF Core, bu işlemleri verimli şekilde gerçekleştirmek için `DbContext` kullanır.

---

## 🧠 DbContext’in Temel Bileşenleri

### 🗂️ DbSet

Bu class, veritabanı tablolarını temsil eder; her entity class’ı bir `DbSet`’e eşlenir ve sorgulama, ekleme, güncelleme veya silme gibi işlemleri mümkün kılar.

### 💾 SaveChanges

`DbContext` üzerinden yapılan tüm değişiklikleri veritabanına işler ( *commit* ); kayıt ekleme veya kaldırma gibi işlemleri tamamlar.

---

## 🛠️ CRUD İşlemleri

### ➕ Create

Yeni kayıt eklemek için `Add` kullanılır. Bir entity örneğini doldurduktan sonra, bunu veritabanına kaydetmek için `SaveChanges` çağrılır.

### 📖 Read

`Find`, `FirstOrDefault` ve `ToList` gibi metotlar, veritabanından tekli veya çoklu kayıtları almak için kullanılır.

### ✏️ Update

Kayıtları `Find` veya `ToList` ile alın, gerektiği gibi değiştirin, ardından değişiklikleri yansıtmak için `Update` ve `SaveChanges` uygulayın.

### 🗑️ Delete

Kaydı `Find` veya `ToList` ile alın, `Remove` metoduna verin ve silmek için `SaveChanges` çağırın.

---

## 🧾 Sonuç

EF Core’da CRUD işlemlerine hâkim olmak, uygulamalarda veriyi verimli biçimde yönetmeyi sağlar. Veritabanı tutarlılığını ve işlevselliğini sağlamak için `DbContext`, `DbSet` ve `SaveChanges` gibi temel bileşenlerden yararlanır.

## 🔄 SQL’de Transaction ve Eşzamanlılık Yönetimi

### 📌 Giriş

SQL’de işlemleri ( *transactions* ) ve eşzamanlılık kontrolünü ( *concurrency control* ) yönetmek, bir veritabanıyla aynı anda birden fazla işlem veya kullanıcı etkileşime girdiğinde veri bütünlüğünü ve tutarlılığını sağlamak için gereklidir.

---

## 🧾 SQL’de Transactions

SQL’de bir işlem ( *transaction* ), tek bir iş birimi olarak ele alınan bir dizi operasyondur. Bu, tüm operasyonların ya tamamen tamamlanmasını ya da hiçbirinin etkili olmamasını sağlar; böylece veritabanı tutarlılığı korunur.

Transactions, ACID ilkelerine uyar:

* *Atomicity* , bir işlemin tüm parçalarının birlikte başarılı olmasını veya birlikte başarısız olmasını sağlar.
* *Consistency* , işlemin öncesinde ve sonrasında veritabanının geçerli kalmasını garanti eder.
* *Isolation* , işlemlerin birbirini etkilememesini sağlar.
* *Durability* , işlem tamamlandığında değişiklikleri kalıcı hâle getirir.

---

## 🔁 Concurrency Control

Eşzamanlılık kontrolü ( *concurrency control* ), birden fazla kullanıcı veritabanına eriştiğinde veri kaybı veya yanlış güncellemeler gibi sorunları önleyerek, eşzamanlı operasyonları çatışma olmadan yönetir.

SQL, veri doğruluğu ile performans arasında denge kurmak için farklı yalıtım seviyeleri ( *isolation levels* ) sağlar:

* *Read Uncommitted* : Dirty reads’e izin verir; yani bir işlem, başka bir işlemin `COMMIT` edilmemiş verisini görebilir.
* *Read Committed* : Dirty reads’i engeller, ancak non-repeatable reads’e izin verir.
* *Repeatable Read* : Bir işlemin, süreç boyunca aynı veriyi okumasını garanti eder.
* *Serializable* : En yüksek seviyedir; eşzamanlı erişim sorunlarını önler, ancak kilitleme nedeniyle daha yavaş olabilir.

---

## ✅ Sonuç

Etkili transaction yönetimi ve eşzamanlılık kontrolü, çok kullanıcılı ortamlarda veri doğruluğunu ve tutarlılığını korumak için SQL’de kritik öneme sahiptir. Transactions’ı doğru kullanmak ve uygulama ihtiyaçlarına göre uygun yalıtım seviyelerini seçmek, veritabanı güvenilirliğini önemli ölçüde artırabilir.

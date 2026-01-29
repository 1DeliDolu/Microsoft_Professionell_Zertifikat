## 🧰 SQL’de Saklı Yordamlar ve Fonksiyonlardan Yararlanma

### 📌 Giriş

SQL’de saklı yordamlar ( *stored procedures* ) ve fonksiyonlar ( *functions* ), tekrar eden görevleri otomatikleştirmek, performansı artırmak ve veritabanı güvenliğini iyileştirmek için temel araçlar sağlar. Bu özellikler, geliştiricilerin her seferinde kodu yeniden yazmadan karmaşık görevleri tutarlı ve verimli bir şekilde yürütmesine olanak tanır.

---

## 🧾 Saklı Yordamlar

Saklı yordamlar, veritabanında saklanan, önceden yazılmış SQL komutları kümesidir. Kullanıcıların karmaşık görevleri tek bir işlev olarak çalıştırmasına izin verirler. Tekrarlı kullanım için tasarlanan saklı yordamlar, süreçleri sadeleştirir ve hatalardan kaçınmaya yardımcı olur; bu da onları sık gerçekleştirilen veritabanı işlemleri için ideal hâle getirir.

---

## 🧩 Saklı Yordam Türleri

### 👤 User-Defined Procedures

User-defined procedures, geliştiriciler tarafından belirli görevleri yerine getirmek için oluşturulur; örneğin sipariş durumlarını güncellemek veya raporlar üretmek gibi. Bu prosedürler, rutin veritabanı görevlerinde tutarlılığı sağlamaya yardımcı olur.

### ⏳ Temporary Procedures

Temporary procedures, bir oturum ( *session* ) içinde kısa süreli kullanım için oluşturulur ve oturum sona erdiğinde otomatik olarak silinir. Geçici hesaplamalar veya veri işleme gerektiren görevlerde değerlidir; veritabanını düzenli ve verimli tutmaya yardımcı olur.

---

## 🧠 SQL’de Fonksiyonlar

SQL fonksiyonları, saklı yordamlara benzer şekilde, veri döndürmek üzere tasarlanmış görevleri otomatikleştirir; karmaşık hesaplamaları ve veri çekmeyi basitleştirir. Fonksiyonlar sorgular arasında yeniden kullanılabilir ve SQL programlamasında çok yönlü araçlardır.

---

## 🧪 Fonksiyon Türleri

### 🔢 Scalar Functions

Scalar functions, sayı veya string gibi tek bir değer döndürür. Genellikle hesaplamalarda veya dönüşümlerde kullanılır ve tekrar eden veri manipülasyonu görevlerini basitleştirebilir.

### 🧾 Table-Valued Functions

Table-valued functions, tek bir değer yerine bir veri tablosu döndürür. Karmaşık veri çekme gerektiğinde faydalıdır ve fonksiyon çıktısının sorgular içinde tablo gibi kullanılmasına olanak tanır.

---

## ✅ Saklı Yordamlar ve Fonksiyonları Kullanmanın Faydaları

Saklı yordamlar ve fonksiyonları kullanmak, SQL veritabanı performansını ve yönetimini birkaç önemli şekilde geliştirir:

* **Kod Organizasyonu:** Saklı yordamlar ve fonksiyonlar, ilgili SQL komutlarını gruplayarak veritabanı script’lerinin okunabilirliğini ve sürdürülebilirliğini artırır.
* **Performans Optimizasyonu:** SQL komutlarını sunucuda önceden derleyip saklamak, sorguları her seferinde sıfırdan ayrıştırma ihtiyacını azaltarak yanıt sürelerini iyileştirir.
* **Azaltılmış Ağ Trafiği:** Prosedürler ve fonksiyonlar doğrudan veritabanı sunucusunda çalıştığı için, uygulamalar sık sık ileri-geri SQL komutları göndermekten kaçınır ve daha verimli olur.
* **Geliştirilmiş Güvenlik:** Doğrudan tablo erişimi yerine belirli saklı yordamlar ve fonksiyonlara erişim vererek hassas veriler korunabilir; maruziyet azaltılır ve güvenlik korunur.

---

## 🧾 Saklı Yordamları Oluşturma ve Yönetme

SQL’de saklı yordamları oluşturma süreci, etkin çalışmaları ve kolayca yeniden kullanılmaları için birkaç yapılandırılmış adımdan oluşur:

* **Prosedürü Tanımlama:** Benzersiz bir adla `CREATE PROCEDURE` kullanın. Giriş parametrelerini tanımlayın ve her parametrenin alacağı veriyi belirtin.
* **SQL Mantığını Ekleme:** Prosedürün çalıştıracağı SQL komutlarını yazın; ör. `INSERT`, `UPDATE` veya `SELECT`.
* **Output Parametreleri Tanımlama:** Prosedürden belirli verileri döndürmek için `OUTPUT` kullanın. Bu, yeni bir kayıt ekledikten sonra bir çalışan ID’si almak gibi görevlerde özellikle kullanışlıdır.
* **Prosedürü Çalıştırma:** Prosedürü çalıştırmak ve gerekli parametreleri geçirmek için `EXEC` komutunu kullanın.

---

## ✅ Saklı Yordamlar için En İyi Uygulamalar

* **Parametre Doğrulama:** Beklenmedik davranışları önlemek için tüm giriş parametrelerini doğrulayın. İşlemeden önce değerlerin gerekli koşulları karşıladığından emin olun.
* **Hata Yönetimi:** Sorunlar oluşursa yönetmek ve loglamak için `TRY CATCH` blokları gibi teknikleri kullanın.
* **Sürüm Kontrolü:** Değişiklikleri izlemek için sürüm kontrolü kullanın; bu, özellikle iş birliğine dayalı ortamlarda faydalıdır.

---

## 🧠 Fonksiyonları Oluşturma ve Yönetme

Prosedürlere benzer şekilde, SQL fonksiyonları da SQL sorguları içinde yeniden kullanılabilir hâle getirmek için belirli adımlarla oluşturulur:

* **Fonksiyonu Tanımlama:** `CREATE FUNCTION` ile başlayın ve fonksiyon adını yazın. Fonksiyonun ihtiyaç duyduğu veriyi belirtmek için giriş parametrelerini tanımlayın.
* **Dönüş Tipini Belirtme:** `RETURNS` kullanarak fonksiyonun ne döndüreceğini belirtin — scalar fonksiyonlar için tek bir veri tipi veya table-valued fonksiyonlar için `TABLE`.
* **Mantık ve End Statement Ekleme:** Fonksiyon sonucunu üreten hesaplamayı veya sorguyu belirtmek için `RETURN` kullanın. Fonksiyon tanımını `END` ifadesiyle bitirin.
* **Fonksiyonu Çalıştırma:** Fonksiyonlar sorgular içinde çağrılabilir. Scalar fonksiyonlar `SELECT` ifadelerinde çalışır; table-valued fonksiyonlar ise `FROM` bölümünde tablo gibi kullanılabilir.

---

## ✅ Sonuç

Saklı yordamlar ve fonksiyonlar, SQL veritabanı yönetimi için paha biçilemez araçlardır; veri işleme görevlerini otomatikleştirmek, optimize etmek ve güvence altına almak için yapılandırılmış yollar sunarlar. Bu araçları kullanarak geliştiriciler, veritabanlarının verimliliğini ve güvenliğini artırırken, karmaşık operasyonlar için düzenli ve yeniden kullanılabilir kodu korur.

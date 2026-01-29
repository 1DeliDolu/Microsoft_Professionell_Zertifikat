## ⚡ SQL Performans Ayarı: Giriş

### 📌 Giriş

Bu referans kılavuz, veritabanı performansını ve verimliliğini artırmak için SQL sorgularını optimize etmeye yönelik temel teknikleri özetler.

---

## 🛠️ Temel Teknikler

### 🧩 Sorgu Optimizasyonu

Sorgu optimizasyonu, yürütme süresini azaltmak için SQL sorgularını analiz etmeyi ve ayarlamayı içerir; bunu sözdizimini, indekslemeyi ve join’leri optimize ederek yapar.

---

### 🧱 İndeksleme

İndekslerin doğru kullanımı, özellikle sık sorgulanan sütunlarda, veri çekme işlemini dramatik biçimde hızlandırabilir; ancak ekleme ( *insert* ) ve güncelleme ( *update* ) işlemlerinde gereksiz ek yük oluşturmamak için dengeli uygulanmalıdır.

---

### 🗺️ Execution Plan’lar

Execution plan’ları incelemek, sorgu içindeki verimsiz işlemleri (ör. tam tablo taraması  *full table scan* ) belirlemeye yardımcı olur; bu işlemler daha verimli sorgu desenleriyle değiştirilebilir.

---

### 📊 Veritabanı İstatistikleri

Veritabanı istatistiklerini güncel tutmak, SQL optimizer’ın sorgu planları için en iyi seçimleri yapmasına yardımcı olur.

---

### 🎯 Sonuç Kümelerini Sınırlandırma

Filtreler kullanmak ve sonuç kümelerini yalnızca gerekli verilerle sınırlandırmak, özellikle büyük veritabanlarında bellek ve işlem yükünü azaltır.

---

## ✅ Sonuç

Bu teknikleri stratejik biçimde uygulamak, SQL sorgu performansını önemli ölçüde iyileştirebilir; yanıt sürelerini azaltır ve genel veritabanı verimliliğini artırır.

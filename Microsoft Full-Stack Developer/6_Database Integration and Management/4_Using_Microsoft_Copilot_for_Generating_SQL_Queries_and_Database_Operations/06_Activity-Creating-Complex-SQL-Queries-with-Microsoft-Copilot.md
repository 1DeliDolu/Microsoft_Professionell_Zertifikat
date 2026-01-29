## 🧭 Genel Bakış

## 🧩 Etkinlik 2: Microsoft Copilot ile Karmaşık SQL Sorguları Oluşturma

### 📌 Etkinlik Tanıtımı

Bu etkinlikte, Etkinlik 1’de oluşturduğunuz sorguların üzerine inşa ederek SmartShop Envanter Sistemi ( *SmartShop Inventory System* ) için Microsoft Copilot kullanarak karmaşık SQL sorguları yazacaksınız. Bu sorgular; birden fazla tabloyu join etmeyi, iç içe alt sorguları ( *nested subqueries* ) ve veri analizi için toplulaştırmayı ( *aggregation* ) içerecektir.

Bu, üç etkinliğin ikincisidir. Burada oluşturulan sorgular, son etkinlikte hata ayıklanacak ( *debugged* ) ve optimize edilecektir.

---

## 🧾 Adım 1: Özet ve Yeni Gereksinimleri Gözden Geçirme

Etkinlik 1’de, envanter verilerini çekmek ve filtrelemek için temel SQL sorguları yazdınız. Şimdi SmartShop’un ek gereksinimleri var:

* Ürün ve satış verilerini join ederek satış trendlerini analiz etmek.
* Toplulaştırma fonksiyonlarını ( *aggregate functions* ) kullanarak tedarikçi performans raporları üretmek.
* Mağazalar genelinde envanter seviyelerini takip etmek için birden fazla tablodan veriyi birleştirmek.

SmartShop’un yeni ihtiyaçları şunları içerir:

* Ürün satışlarını tarih ve mağazaya göre takip etmek.
* Teslim edilen stok üzerinden en iyi performans gösteren tedarikçileri belirlemek.
* Konsolide raporlama için mağazalar arası envanter verisini birleştirmek.

Bu etkinlik için, tablodaki gerçek verilere ihtiyacınız olmayacak. Ancak sorguları çalıştırmak için senaryodaki sorgu mantığı ve tablo yapısı anlayışınızı uygulamalısınız.

---

## 🔗 Adım 2: Copilot ile Çoklu Tablo JOIN Sorguları Yazma

Başlamak için Copilot’u kullanarak çoklu tablo JOIN sorguları üreteceksiniz.

Copilot ile şu tabloları join eden bir sorgu yazın:

* `Products`
* `Sales`
* `Suppliers`

Şu alanları görüntüleyen bir sorgu yazın:

* `ProductName`, `SaleDate`, `StoreLocation`, `UnitsSold`

---

## 🧠 Adım 3: Nested Queries ve Aggregation Uygulama

Sonraki adımda iç içe sorgular ( *subqueries* ) ve toplulaştırma ( *aggregation* ) uygulayacaksınız.

Copilot ile şu amaçlar için subquery’ler yazın:

* Her ürün için toplam satışları hesaplamak.
* En çok geciken teslimata sahip tedarikçileri belirlemek.

Trendleri analiz etmek ve özetlemek için `SUM`, `AVG`, `MAX` gibi aggregate fonksiyonlarını kullanın.

---

## 💾 Adım 4: Çalışmanızı Kaydetme

Bu etkinliğin sonunda:

* SmartShop’un ileri gereksinimlerini karşılamak için karmaşık SQL sorguları üretmiş olacaksınız.
* Hata ayıklama ve optimizasyon için hazır bir sorgu setiniz olacak.

Tüm karmaşık sorguları sandbox ortamınızda kaydedin. Bunlar Etkinlik 3’te hata ayıklanacak ve optimize edilecektir.

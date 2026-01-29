## 🧭 Genel Bakış

## 🧩 Etkinlik 1: Microsoft Copilot ile Temel SQL Sorguları Yazma

### 📌 Etkinlik Tanıtımı

Bu etkinlikte, SmartShop Envanter Sistemi ( *SmartShop Inventory System* ) için temel SQL sorgularını yazmak üzere Microsoft Copilot kullanmaya başlayacaksınız. Bu sorgular, veri çekme ve veriyi işleme imkânı sağlayarak sistemin temelini oluşturacaktır.

Bu, üç etkinliğin ilkidir. Burada yazılan sorgular, sonraki etkinliklerde daha karmaşık hâle getirilecek ve optimize edilecektir.

Başlamak için, “SmartShop Inventory System” oluşturmayla ilgili aşağıdaki senaryoyu inceleyin.

---

## 🏬 Senaryo: SmartShop Inventory System

Kurgusal bir perakende şirketi olan SmartShop için SmartShop Envanter Sistemi’ni geliştirmekle görevli bir veritabanı mühendisi olduğunuzu hayal edin. Bu sistem, birden fazla mağaza genelinde envanter verilerini yönetmeli ve stok seviyeleri, satış trendleri ve tedarikçi bilgileri hakkında gerçek zamanlı içgörüler sağlamalıdır.

Şirketin gereksinimleri:

* Envanter verilerini verimli bir şekilde depolayıp geri getirebilen bir veritabanı.
* Ürünler, satışlar ve tedarikçiler arasındaki trendleri ve ilişkileri analiz etmek için karmaşık sorgular.
* Yüksek performans ve ölçeklenebilirlik için optimize edilmiş veritabanı işlemleri.

Amacınız, performans ve doğruluk gereksinimlerini karşılayacak şekilde SQL sorgularını oluşturmak, hata ayıklamak ( *debug* ) ve optimize etmek için Microsoft Copilot’tan yararlanmaktır. Bu proje üç etkinliğe yayılacak ve kapsamlı bir envanter yönetimi veritabanı ile tamamlanacaktır.

---

## 📋 SmartShop’un İlk Gereksinimleri

SmartShop’un başlangıç gereksinimleri şunları içerir:

* Ürün adı, fiyatı ve stok seviyeleri gibi ürün detaylarını çekmek.
* Ürünleri kategori ve bulunabilirliğe göre filtrelemek.
* Daha iyi okunabilirlik için verileri sıralamak.

---

## 🧾 Adım 2: Copilot ile Temel SELECT Sorguları Üretme

Başlamak için Copilot’u kullanarak bu ihtiyaçları karşılayan temel sorgular üreteceksiniz.

Copilot ile aşağıdaki ürün detaylarını getiren bir sorgu yazın:

* `ProductName`, `Category`, `Price`, `StockLevel`

---

## 🔍 Adım 3: Filtreleme ve Sıralama Uygulama

Sonraki adımda filtreleme ve sıralama özellikleri üzerinde çalışacaksınız.

Copilot ile aşağıdaki filtreleri içeren sorgular yazın:

* Belirli bir kategorideki ürünler
* Stok seviyesi düşük ürünler

Ardından, ürünleri `Price` alanına göre artan sırada görüntülemek için sıralama ( *sorting* ) ekleyin.

---

## 💾 Adım 4: Çalışmanızı Kaydetme

Bu etkinliğin sonunda:

* Envanter verilerini çekmek ve düzenlemek için Copilot kullanarak temel SQL sorguları yazmış olacaksınız.
* Sorgular, Etkinlik 2’de genişletilmek ve iyileştirilmek üzere hazır hâle gelmiş olacak.

Tüm sorguları sandbox ortamınızda kaydedin. Bu temel sorgular Etkinlik 2’de genişletilecek ve kullanılacaktır.

## 🧰 Saklı Yordamlar ve Fonksiyonlara Giriş

Veritabanlarıyla çalışırken, aynı sorguları tekrar tekrar yazdığınızı ve farklı uygulamalar boyunca karmaşık hesaplamaları yönettiğinizi sıkça görürsünüz. Bu tekrarlayan iş, veritabanı yönetiminde önemli ölçüde zaman ve efor gerektirebilir.

Peki geliştiriciler, tekrar eden sorguları ve karmaşık hesaplamaları otomatikleştirirken aynı zamanda tutarlılığı nasıl sağlar ve hataları nasıl azaltır? SQL saklı yordamları ( *stored procedures* ) ve fonksiyonları verimli bir çözüm sunar.

Bu videoda, saklı yordamların ve fonksiyonların ne olduğunu ve SQL veritabanlarındaki rollerini açıklayacağız.

---

## 🧾 Stored Procedures Nedir?

Önce saklı yordamların ne olduğuna dair bir tanımla başlayalım.

Saklı yordamlar, bir veritabanında kaydedilen ve tek bir görev olarak çalıştırılabilen SQL komut kümeleridir. Yaygın görevler için kodu yeniden kullanmamıza olanak tanırlar.

Aynı komutları her seferinde yazmak yerine, saklı yordamı çağırarak tutarlı sonuçlar elde eder; zaman kazanır ve hataları azaltırız.

Bazı yaygın stored procedure türleri, *user-defined procedures* ve  *temporary procedures* ’tır.

---

## 🧩 User-Defined Stored Procedures

User-defined stored procedures, geliştiriciler tarafından belirli görevleri yerine getirmek için oluşturulan özel yordamlarıdır; örneğin sipariş durumlarını güncellemek veya satış raporlarını işlemek gibi.

Bu yordamlar rutin operasyonlarda esneklik ve tutarlılık sağlar; geliştiricilerin karmaşık görevleri her çağrıldığında doğru ve verimli şekilde gerçekleştiren yeniden kullanılabilir kod yazmasına imkân verir.

---

## ⏳ Temporary Stored Procedures

User-defined yordamların yanında, *temporary stored procedures* da vardır.

Temporary stored procedures, tek bir oturum ( *session* ) içinde kullanılmak üzere oluşturulan kısa süreli yordamlar olup, oturum bittiğinde otomatik olarak silinir.

Özellikle uzun süre saklanmasına gerek olmayan geçici hesaplamalar veya veri işleme işlemleri için kullanışlıdır. Veritabanını düzenli ve verimli tutmaya yardımcı olurlar.

---

## 🧠 Fonksiyonlar Nedir?

Şimdi fonksiyonları ele alalım.

Fonksiyonlar, belirli bir hesaplama veya operasyonu gerçekleştiren ve bir sonuç döndüren saklı SQL ifadeleri kümesidir. Karmaşık hesaplamaları veya veri çekme görevlerini basitleştirmek için sorgularda yeniden kullanılabilirler.

Fonksiyonlar iki ana türde gelir: *scalar functions* ve  *table-valued functions* .

---

## 🔢 Scalar Functions

Scalar functions, tek bir değer döndüren fonksiyonlardır; örneğin bir sayı veya bir string.

Genellikle tekil veri öğeleri üzerinde hesaplama veya dönüşüm yapmak için kullanılırlar.

Örneğin, bir scalar function bir ürün fiyatı üzerinden vergi hesaplayabilir ve yalnızca vergi tutarını döndürebilir; böylece hesaplama her kullanıldığında doğru ve tutarlı olur.

---

## 🧾 Table-Valued Functions

Scalar functions tek değer döndürürken, table-valued functions tek bir değer yerine tüm bir veri tablosu döndürür; bu da kullanıcıların karmaşık sorgular çalıştırmasına olanak tanır.

Fonksiyon çıktısını bir tabloymuş gibi ele alarak, esnek ve yeniden kullanılabilir veri çekmeyi mümkün kılar.

Örneğin, bir table-valued function belirli bir dönem boyunca en çok satan ürünleri listeleyebilir ve size normal bir tablo gibi sorgulanabilen bir veri seti sunar.

Bu, her seferinde karmaşık sorgular yazma ihtiyacını azaltarak zaman kazandırır.

---

## ✅ Stored Procedures ve Functions’ın Faydaları

Stored procedures ve functions birlikte, geliştiriciler ve veritabanları için birden fazla fayda sağlar. Şimdi bu faydalardan bazılarını inceleyelim.

---

## 🗂️ Kod Organizasyonunu İyileştirme

Faydalardan biri, ilgili SQL mantığını gruplayarak kod organizasyonunu iyileştirmeleridir; bu da yönetmeyi ve güncellemeyi kolaylaştırır.

Örneğin, birden fazla sorguda sürekli aynı filtreleme adımlarını tekrar etmek yerine, bunları tek bir stored procedure içinde merkezileştirerek bakım süreçlerini basitleştirebilirsiniz.

---

## 🚀 Performansı Artırma

Kod organizasyonuna ek olarak, stored procedures sorgu performansını önemli ölçüde iyileştirebilir.

Veritabanı sunucusunda SQL komutlarını önceden derleyip optimize ederek, her seferinde sorguları sıfırdan ayrıştırma ve çalıştırma ihtiyacını azaltırlar; bu da veritabanı işlemlerini hızlandırır.

Örneğin, müşteri sipariş geçmişlerini hızlı şekilde getiren bir stored procedure, yüksek trafikli bir uygulamada yanıt sürelerini artırabilir.

---

## 🌐 Ağ Trafiğini Azaltma

Bir diğer fayda, ağ trafiğinin azalmasıdır.

Stored procedures ve functions doğrudan veritabanı sunucusunda çalıştığı için, ağ üzerinden daha az SQL kodu gönderilir ve uygulamalar daha verimli çalışır.

Örneğin, bir dizi hesaplama yapmak için birden fazla sorgu göndermek yerine, bir stored procedure bu işlemleri sunucuda tek seferde çalıştırabilir; bu da ileri-geri iletişimi azaltır.

---

## 🔐 Güvenliği Artırma

Son olarak, tüm veritabanını açığa çıkarmadan yalnızca belirli prosedürlere veya fonksiyonlara erişim izni vererek güvenliği artırırlar; bu da hassas verileri korur.

Örneğin, kullanıcıların rapor özetlerini görüntülemek için bir stored procedure çalıştırmasına izin verirken, alttaki veri tablolarına doğrudan erişim izni vermeyebilirsiniz; böylece işlevsellik sağlanırken güvenlik de korunur.

---

## 🏁 Kapanış

Bu videoda, stored procedures ve functions’ın ne olduğunu ve veritabanlarındaki rollerini öğrendiniz.

Stored procedures ve functions, düzenli, verimli ve güvenli veritabanları oluşturmak için temel araçlardır. Bu özellikleri kullanarak veritabanı görevlerini basitleştirebilir, performansı artırabilir ve çok kullanıcılı ortamlarda veriyi güvende tutabiliriz.

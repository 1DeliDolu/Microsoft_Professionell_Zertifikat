## ⚡ SQL Performans Ayarı: Giriş

Verimli SQL sorguları yalnızca hızla ilgili değildir. Veri çekmenin mümkün olduğunca akıcı ve kaynak dostu olmasını sağlamakla ilgilidir. Küçük ayarlamalar büyük fark yaratabilir; yavaş bir veritabanını duyarlı bir veritabanına dönüştürebilir. Buna performans ayarı ( *performance tuning* ) diyoruz.

Bu videoda, SQL sorgu performans ayarının önemini ve temellerini açıklayacağız.

---

## 🐢 SQL Sorgularını Ne Yavaşlatır?

Başlamak için, SQL sorgularını neyin yavaşlatabileceğini ve neden ayarlamanın gerekli olduğunu ele alalım.

Verimsiz sorgular, çok fazla veri çekerek veya doğru şekilde filtreleme yapmayarak sonuçları geciktirebilir.

---

## 🧠 SQL Optimizer ve Execution Plan

İşte burada SQL Optimizer devreye girer.

SQL Optimizer, SQL sorgularının beynidir. Her sorguyu çalıştırmanın en hızlı ve en verimli yolunu bulur. En iyi rotayı seçen bir GPS gibi, kullanılabilir indekslere, join’lere ve sıralama seçeneklerine göre veriyi çekmek için izlenecek adımları belirleyen bir *execution plan* (çalıştırma planı) oluşturur.

Bir execution plan, veri çekme işlemi için bir harita görevi görür. Geliştiriciler bu planı inceleyerek, indeks kullanmak yerine tüm tabloyu tarama ( *full table scan* ) gibi verimsizlikleri tespit edebilir. Bir sorgu yavaşsa, planı analiz etmek; örneğin bir indeks eklemek gibi iyileştirmelerin performansı nerede artıracağını gösterebilir.

---

## 🚀 Veri İşlemeyi Azaltan Basit Teknikler

Bu temel üzerinden, veri işlemeyi azaltmak ve sorguları hızlandırmak için bazı kolay tekniklere bakalım.

---

## 🧾 `SELECT *` Yerine Gerekli Sütunları Seçmek

Bir `SELECT` ifadesi yazarken, `SELECT *` kullanmak yerine yalnızca ihtiyaç duyduğunuz sütunları belirtmek en iyisidir.

Bu, veritabanının çekip işlemesi gereken veri miktarını azaltır; zaman ve kaynak tasarrufu sağlar.

Eğer yalnızca bir ürünün adını ve fiyatını görmeniz gerekiyorsa:

* `SELECT productName, price FROM products` yalnızca iki sütunu çeker.
* `SELECT * FROM products` ise tüm sütunları getirir ve veritabanına gereksiz yük bindirir.

Çekilen veriyi azaltarak bu yaklaşım kaynak tasarrufu sağlar ve sorguyu hızlandırır.

---

## 🎯 `WHERE` ile Sonuçları Daraltmak

Bir diğer teknik de `WHERE` ifadesini kullanmaktır. Bu, kriter belirleyerek sonuçları daraltmanıza ve veritabanının yalnızca ihtiyacınız olan veriyi döndürmesine olanak tanır.

Bu, kaynak tasarrufu sağlar ve sorgunuzu hızlandırır; çünkü alakasız satırları çekmek zorunda kalmaz.

Örneğin yalnızca fiyatı 20$ altında olan ürünlere ihtiyacınız varsa, `WHERE price is less than $20` eklemek diğer tüm ürünleri eler ve yalnızca eşleşen satırların çekilmesini sağlar.

Bu, ilgili olmayan satırlarda boşa işlem yapılmasını önleyerek sorguyu hızlandırır.

---

## 🧹 `DISTINCT` ile Tekrar Eden Sonuçları Kaldırmak

Bazen sorgu birden fazla ilişkili tablodan veri çekerken sonuçlarda tekrarlar oluşabilir.

`DISTINCT` anahtar sözcüğü bu tekrarları kaldırır, sonuçları daha net tutar ve veritabanının işlemesi gereken veri miktarını azaltarak işlem süresinden tasarruf sağlar.

Örneğin büyük bir ürün veritabanından benzersiz ürün kategorilerinin listesini istiyorsanız:

```sql
SELECT DISTINCT category FROM products
```

Bu, yalnızca benzersiz kategorileri döndürür; sonuçtaki satır sayısını azaltır ve sorguyu hızlandırır.

---

## 🔟 `LIMIT` ile Döndürülen Satır Sayısını Azaltmak

Büyük bir veri kümesiyle çalışıyorsanız ama yalnızca hızlı bir önizleme istiyorsanız, `LIMIT` anahtar sözcüğü veritabanının döndürmesi gereken satır sayısını azaltır.

Örneğin ilk 10 ürünü görmek istiyorsanız:

```sql
SELECT * FROM products LIMIT 10
```

Bu, yalnızca o satırları çekerek sorguyu daha hızlı hâle getirir.

Bu, özellikle büyük tablolarda çok faydalıdır; çünkü her satırı çekmek sistemi yavaşlatır.

---

## ✅ Kapanış

Bu videoda, SQL sorgu performans ayarının önemini ve temellerini öğrendiniz.

SQL sorgularında yapılan iyileştirmeler yalnızca zaman kazandırmakla kalmaz; veritabanlarının kullanıcılara nasıl yanıt verdiğini de dönüştürür. Temel performans ayarı tekniklerini uygulayarak, her uygulama ile birlikte ölçekleyebileceğiniz verimli veri yönetimi için bir temel oluşturursunuz.

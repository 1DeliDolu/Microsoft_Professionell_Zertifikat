## 🧮 SQL’de Toplu ( *Aggregate* ) Fonksiyonları Kullanma

Büyük veri kümeleriyle çalışırken ham veriyi yorumlamak bunaltıcı olabilir. SQL’deki toplu ( *aggregate* ) fonksiyonlar, veri kümeleri üzerinde hesaplamalar yaparak tek bir sonuç üretmenizi sağlar ve böylece kalıpları ve trendleri ortaya çıkarır.

Bu videoda, veri üzerinde hesaplamalar yapmak için toplu fonksiyonların kullanımını açıklayacağız.

---

## 🧠 Toplu ( *Aggregate* ) Fonksiyonlar Nedir?

SQL toplu fonksiyonları, bir değer kümesi üzerinde hesaplama yapıp tek bir değer döndüren fonksiyonlardır.

Bu tek değer; anlamlı metrikler çıkarmak ve özetleme yoluyla içgörü sağlamak için kullanılır.

Diğer fonksiyonlar gibi, çoğunlukla veriyi özetlemek amacıyla `SELECT` ifadelerinde kullanılırlar.

---

## 🔢 `COUNT` Fonksiyonu

Toplu fonksiyonları uygulamada inceleyelim ve `COUNT` ile başlayalım.

`COUNT`, belirli bir koşulu sağlayan satır sayısını döndürür. Bu, belirli kriterleri karşılayan kaç giriş olduğunu belirlemek için kullanışlıdır.

`COUNT` fonksiyonunu kullanmak için, normalde sütunları listelediğiniz yerde `SELECT` ifadesinden sonra kullanırsınız.

Örneğin, *music catalog* tablosunda `song title` adlı bir sütun olduğunu varsayalım ve toplam şarkı sayısını saymak isteyelim.

Sorgu `SELECT COUNT` ile başlar ve parantez içinde yıldız (`*`) kullanılır; bu, tüm satırları sayar.

Yıldız kullanmak tüm girişleri sayarken, bir sütun adı belirtmek yalnızca `NULL` olmayan değerleri sayar.

Sonra sonuca anlamlı bir isim vermek için `AS TOTAL SONGS` ile bir alias ekleriz.

Son olarak, veri kaynağını belirtmek için `FROM MUSIC CATALOG` yazar ve sorguyu noktalı virgülle bitiririz.

Bu örnekte, parantez içinde yıldız ile kullanılan `COUNT`, tablodaki toplam şarkı sayısını döndürür.

---

## ➕ `SUM` Fonksiyonu

`COUNT` belirli kriterleri karşılayan giriş sayısını belirlerken, `SUM` bir sütundaki değerlerin toplamını verir.

Yalnızca girişleri saymak yerine, `SUM` belirtilen sütundaki her değeri toplar ve tüm değerlerin toplamını üretir.

Bu, büyük veri kümelerinde toplamları analiz etmek için temel bir fonksiyondur.

`COUNT` gibi, `SUM` da `SELECT` ifadesinde veri toplulaştırmak için kullanılır.

Örneğin, *music catalog* tablomuzda her şarkının ürettiği toplam satışları takip eden `REVENUE` adlı bir sütun varsa, toplam geliri bulmak için sorguya `SELECT SUM` ile başlar ve parantez içinde `revenue` yazarız.

Ardından sonuca alias vermek için `AS TOTAL REVENUE` ekleriz ve veri kaynağını belirtmek için `FROM MUSIC CATALOG` ile sorguyu tamamlarız.

Bu örnekte, parantez içinde `revenue` ile kullanılan `SUM`, sütundaki tüm değerleri toplayarak toplam satış gelirini hesaplar.

---

## 📊 `AVG` ( *Average* ) Fonksiyonu

`SUM` ve `COUNT` fonksiyonlarını inceledikten sonra, şimdi `AVG` ( *AVERAGE* ) fonksiyonuna bakalım.

`AVG`, bir sayısal sütundaki tüm değerlerin ortalamasını hesaplar; toplamı giriş sayısına bölerek genel performansa dair içgörüler sunar.

Şarkı başına ortalama geliri hesaplamak için `SELECT AVG` ile başlarız ve ortalaması alınacak değerleri belirtmek için parantez içinde `revenue` yazarız.

Sonra sonuç için alias eklemek üzere `AS AVERAGE REVENUE` kullanırız ve veri kaynağını belirtmek için `FROM MUSIC CATALOG` ile ifadeyi bitiririz.

Bu örnekte, parantez içinde `revenue` ile kullanılan `AVG`, katalogdaki tüm şarkıların ürettiği ortalama geliri hesaplar ve şarkı başına ortalama satış tutarını döndürür.

---

## 📉 `MIN` Fonksiyonu

Ortalama değer faydalıdır, ancak en düşük gelir veya en az popüler ürün gibi belirli veri noktalarını da bulmak isteyebilirsiniz.

Bunun için `MIN` fonksiyonunu kullanırız.

`MIN`, belirtilen bir sütundaki en küçük değeri bulur; veri kümenizdeki en düşük değeri doğrudan getirir.

Müzik kataloğunda bir şarkının ürettiği en düşük geliri bulmak için `MIN` kullanırız.

Sorgu `SELECT MIN` ile başlar ve parantez içinde sütun adını yazarız.

Sonra sonuç için alias vermek üzere `AS LOWEST REVENUE` ekleriz ve veri kaynağını belirtmek için `FROM MUSIC CATALOG` ile bitiririz.

Bu sorguda, `MIN REVENUE` en küçük satış geliri tutarını döndürür ve katalogdaki en düşük gelire sahip şarkıyı belirler.

---

## 📈 `MAX` Fonksiyonu

`MIN` en küçük değeri bulmaya yardımcı olurken, `MAX` bir sütundaki en büyük değeri belirler.

Müzik kataloğunda bir şarkının en yüksek haftalık dinlenmesini bulmak için `MAX` kullanırız.

Sorgu `SELECT MAX WEEKLY PLAYS` ile başlar ve parantez içinde sütun adını yazarız.

Ardından sonuç için alias oluşturmak üzere `AS HIGHEST PLAYS` ekleriz ve veri kaynağını belirtmek için `FROM MUSIC CATALOG` ile sorguyu tamamlarız.

Bu örnekte, `MAX WEEKLY PLAYS` katalogdaki herhangi bir şarkı için kaydedilmiş en yüksek haftalık dinlenme sayısını döndürür.

---

## 🧩 `GROUP BY` ile Toplu Fonksiyonları Güçlendirme

Artık toplu fonksiyonları `COUNT`, `SUM`, `AVERAGE`, `MIN` ve `MAX` olarak inceledik ve her birinin verinizden farklı içgörüler çıkarmanıza nasıl yardımcı olduğunu anladınız.

Ancak bu fonksiyonlar, `GROUP BY` yan tümcesiyle birleştirildiğinde çok daha güçlü hâle gelir.

`GROUP BY`, belirtilen sütunlarda aynı değerlere sahip satırları özet satırlarda gruplar ve toplu fonksiyonlarla birlikte yaygın olarak kullanılır.

Örneğin katalogda her müzik türünün ürettiği toplam geliri bulmak için `GROUP BY` ile birlikte `SUM` kullanırız.

Sorgu `SELECT GENRE` ile başlar, ardından `SUM REVENUE as total revenue` eklenir ve `FROM MUSIC CATALOG GROUP BY GENRE` ile bitirilir.

Bu kurulum, veriyi türe göre gruplayarak her tür için toplam geliri hesaplar.

---

## ✅ Özet

Bu videoda, veri üzerinde hesaplama yapmak için toplu fonksiyonların nasıl kullanılacağını öğrendiniz.

Denemeye devam edin; yakında toplu fonksiyonların herhangi bir analiz görevi için ne kadar güçlü olabileceğini fark edeceksiniz.

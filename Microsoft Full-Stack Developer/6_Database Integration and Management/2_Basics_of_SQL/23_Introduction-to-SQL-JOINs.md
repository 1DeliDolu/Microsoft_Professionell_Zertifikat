## 🔗 SQL `JOIN`’lara Giriş

Gerçek dünyadaki senaryolarda, birden fazla kaynaktan gelen veriyi birleştirmek çoğu zaman gereklidir. Peki, ihtiyacınız olan bilgiyi elde etmek için bir veritabanındaki farklı tabloların hepsini nasıl anlamlı şekilde bir araya getirirsiniz? SQL `JOIN` yan tümceleri, ilişkili verileri birbirine bağlamak için güçlü bir yol sunar.

Bu videoda, SQL’de `JOIN` yan tümcelerinin amacını ve türlerini açıklayacağız.

---

## 🧩 `JOIN` Nedir?

SQL’de `JOIN`, iki veya daha fazla tablodaki satırları, aralarındaki ilişkili bir sütuna dayanarak birleştirmek için kullanılan bir yan tümcedir.

Bu, verinin birden fazla tabloya dağıtıldığı durumlarda gereklidir; bu yaklaşım ilişkisel veritabanlarında veriyi düzenli tutmak ve tekrarları ( *redundancy* ) önlemek için yaygın bir pratiktir.

`JOIN`’lar, bu ilişkili tablolar arasında yapılandırılmış şekilde sorgulama yapmanızı sağlar. `JOIN` olmadan, aynı anda yalnızca tek bir tablonun verisine erişmekle sınırlı kalırsınız.

---

## 🛒 Örnek Senaryo: Müşteri ve Siparişler

Belirli bir müşterinin verdiği tüm siparişleri incelemek istediğinizi varsayalım.

Bir **customers** tablonuz ve ayrı bir **orders** tablonuz var. `JOIN`, bu iki ilişkili veri kümesini birleştirerek hangi müşterilerin hangi siparişleri verdiğini bulmanıza yardımcı olur.

Buradaki kritik nokta, tabloların ortak bir şeye sahip olmasıdır. Örneğin, her iki tabloda da veriyi birbirine bağlayan bir `customerID` bulunabilir.

Bu noktada **primary key** ve **foreign key** devreye girer.

---

## 🔑 Primary Key ve Foreign Key

`JOIN` ile tablolar arasındaki en önemli bağlantı, çoğu zaman **primary key** ve **foreign key** tarafından tanımlanan ilişkidir.

 **Primary key** , bir tablodaki her satır için benzersiz bir tanımlayıcıdır.

**Foreign key** ise başka bir tablodaki, bu primary key’e referans veren sütundur.

`JOIN`, bu ilişkiyi kullanarak veriyi birleştirir. Örneğin, `customerID` customers tablosunda primary key iken, orders tablosunda foreign key olabilir.

Bu ilişki, iki tablodan gelen verinin doğru şekilde eşleşmesini sağlar.

İyi tanımlanmış primary ve foreign key’ler olmadan, tablolar arasındaki ilişki net olmadığı için `JOIN`’ları güvenilir şekilde çalıştırmak çok daha zordur.

---

## 🧷 `JOIN` Türleri

Primary ve foreign key’lerin tablolar arasındaki ilişkileri nasıl tanımladığını gördüğümüze göre, bu ilişkilere dayanarak veriyi birleştiren farklı `JOIN` türlerine bakalım.

Her tür, veriyi nasıl birleştirmek istediğinize ve hangi bilgiye ihtiyaç duyduğunuza göre farklı bir amaca hizmet eder.

---

## ✅ `INNER JOIN`

`INNER JOIN`, en sık kullanılan `JOIN` türüdür.

Sadece her iki tabloda da eşleşme olan satırları döndürür.

Customers ve orders örneğinde, `INNER JOIN` yalnızca en az bir sipariş vermiş müşterileri döndürür; hiç sipariş vermemiş müşterileri dışarıda bırakır.

Bu `JOIN`, yalnızca tablolar arasında açık bir bağlantı olan veriyi almak istediğinizde kullanışlıdır.

---

## ⬅️ `LEFT JOIN`

`INNER JOIN` yalnızca eşleşen veriyi döndürür; ancak bazen diğer tabloda eşleşme olmasa bile bir tablodaki tüm veriyi almak isteriz.

`LEFT JOIN`, sorgudaki sol tablodan (yani sorguda ilk yazılan tablodan) **tüm satırları** ve sağ tablodan **eşleşen satırları** döndürür.

Eşleşme yoksa, yine de sol tablonun satırları sonuçlara dahil edilir; ancak sağ tablodan gelen sütunlar **NULL** olur.

Örneğin, hesabı olan ama henüz sipariş vermemiş müşterileri de dahil ederek tüm müşterilerin sipariş geçmişini almak istiyorsanız, `LEFT JOIN` doğru yaklaşımdır.

Bu, tüm müşteri verisini getirir ve varsa ilişkili sipariş bilgisiyle birleştirir.

Sipariş vermemiş müşteriler için sipariş detayları NULL görünür; ancak yine de sonuçlarda yer alırlar.

---

## ➡️ `RIGHT JOIN`

`RIGHT JOIN`, `LEFT JOIN`’e benzer şekilde çalışır ancak ters yönde.

Sağ tablodan **tüm satırları** ve sol tablodan **eşleşen satırları** döndürür.

Eşleşme yoksa, sol tablo sütunları NULL ile doldurulur.

Örneğin, tüm siparişlerin bir listesini almak ve ilgili müşteri bilgisini de dahil etmek isteyebilirsiniz.

Eğer bazı müşteri bilgileri (örneğin doğum tarihi) eksikse, bu veri noktası için NULL döndürülebilir.

---

## 🌐 `FULL OUTER JOIN`

En kapsayıcı `JOIN` türü `FULL OUTER JOIN`’dir.

Her iki tablodaki tüm satırları döndürür; eşleşme olsun ya da olmasın.

Eşleşme yoksa, sonuçlar yine de her iki tablodaki tüm satırları içerir ve eşleşmenin olmadığı yerlerde NULL değerleri yer alır.

Bu `JOIN`, verinin tablolar arasında tam olarak bağlanıp bağlanmadığına bakmaksızın verinin tam bir görünümünü almak istediğinizde kullanışlıdır.

Örneğin, hiç sipariş vermemiş müşteriler olsa bile tüm müşterileri ve hiçbir müşteriye bağlı olmayan siparişler olsa bile tüm siparişleri görebilirsiniz.

---

## 🧱 `JOIN` Sözdizimi

Farklı `JOIN` türlerini ele aldıktan sonra, SQL’de `JOIN` ifadelerini yazmak için kullanılan sözdizimine geçelim.

`JOIN` yan tümceleri, tabloların nasıl ilişkili olduğunu belirtmek için bir `SELECT` ifadesine eklenir.

Bir `JOIN`’un temel yapısı, almak istediğiniz sütun veya sütunları belirttiğiniz bir `SELECT` ifadesiyle başlar.

Bunu, ilk tablo adını verdiğiniz `FROM` yan tümcesi izler; bu tablo genellikle `JOIN` içinde sol tablo olarak kabul edilir.

Ardından `JOIN` anahtar kelimesi kullanılır ve ikinci tablo adı yazılır; bu tablo da sağ tablo olarak adlandırılır.

Sorgu, iki tablo arasındaki ilişkiyi tanımlayan `ON` yan tümcesiyle tamamlanır.

`ON` yan tümcesinde, tabloların nasıl ilişkili olduğunu açıkça belirtmek için `table1.column = table2.column` yapısını kullanırsınız.

Bu bölüm, `table1` ve `table2` satırlarının bu sütunlardaki değerler eşit olduğunda eşleştirilmesini söyler.

Tipik olarak bu sütunlardan biri bir tabloda primary key, diğer tabloda foreign key’dir.

Bu anahtar sütunlardaki eşleşen değerler üzerinden veri doğru şekilde birleştirilir.

---

## ✅ Özet

Bu videoda, SQL’de `JOIN` yan tümcelerinin amacını ve türlerini öğrendiniz.

`JOIN`’lar, ilişkisel veritabanlarıyla çalışırken kritiktir. Tablolar arasındaki ilişkilere dayanarak birden fazla tablodan veriyi birleştirmenizi sağlar.

Farklı `JOIN` türlerini, primary ve foreign key’lerin önemini ve `JOIN` sözdizimini anlayarak; verinizi daha etkili sorgulayabilir ve daha karmaşık soruları yanıtlayabilirsiniz.

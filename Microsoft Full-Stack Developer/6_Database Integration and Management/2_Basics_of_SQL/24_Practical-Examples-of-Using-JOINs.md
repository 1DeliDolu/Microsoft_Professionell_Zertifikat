## 🧩 `JOIN` Kullanımına Dair Pratik Örnekler

Şirketin farklı departmanlarından gelen verilerle çalıştığınızı hayal edin: müşteri bilgileri bir tabloda, sipariş detayları başka bir tabloda. Farklı kutulardan çıkan parçalarla bir yapboz tamamlamaya çalışıyor gibi hissedebilirsiniz. Hepsini nasıl anlamlı hâle getirirsiniz? İşte burada SQL `JOIN`’lar devreye girer.

`JOIN`’lar, ayrı tablolardaki verileri birbirine bağlamanıza olanak tanır; böylece daha büyük resmi görür ve birleştirilmiş veriye dayanarak daha bilinçli kararlar alabilirsiniz.

Bu videoda, birleştirilmiş veri almak için farklı `JOIN` türlerini kullanarak SQL sorguları yazacağız.

---

## 🧱 Bir `JOIN` İfadesinin Genel Sözdizimi

Örnekleri inceleyip `JOIN` ile sorgular yazmadan önce, bir `JOIN` ifadesinin genel sözdizimini tekrar edelim.

Bir `JOIN`’un temel yapısı `SELECT` ifadesiyle başlar; burada istediğiniz sütunları seçersiniz.

Ardından `FROM` yan tümcesi gelir; burada ilk tabloyu adlandırırsınız. Bu tablo, `JOIN` içinde genellikle **left table** olarak adlandırılır.

Sonra `JOIN` anahtar kelimesi gelir ve ikinci tablo adı yazılır; bu tablo da `JOIN` içinde **right table** olarak anılır.

Son olarak, `ON` yan tümcesiyle bitiririz; bu kısım SQL’e iki tablonun nasıl ilişkili olduğunu söyler.

Her tablodan sütunları eşleştirirsiniz; örneğin `table1.column = table2.column` gibi.

Tipik olarak bu sütunlardan biri bir tabloda  **primary key** , diğeri ilişkili tabloda  **foreign key** ’dir.

Bu ilişki, `JOIN`’un anahtar sütunlardaki eşleşen değerlere göre veriyi doğru şekilde birleştirmesini sağlar.

---

## 🧾 Örnek Tablolar: `Customers` ve `Orders`

Artık temel `JOIN` sözdizimini ele aldığımıza göre, bunu uygulamaya dökelim.

İki tabloyla çalışacağız: **Customers** ve  **Orders** .

Her `JOIN` türünü tartışırken, veriyi farklı şekillerde nasıl birleştirdiklerini göreceksiniz.

**Customers** tablosunda şu sütunlar bulunur: `Customer ID`, `Name` ve `Date of First Order`.

Bu tabloda dört satır vardır:

* İlk satır: Customer001, adı John. İlk sipariş tarihi 05-17.
* İkinci satır: Customer002, adı Anissa. İlk sipariş tarihi 06-01.
* Üçüncü satır: Customer003, adı Mark. İlk sipariş tarihi verilmemiş.
* Dördüncü satır: Customer004, adı Penelope. İlk sipariş tarihi 06-24.

**Orders** tablosunda şu sütunlar bulunur: `Order ID`, `Customer ID` ve `Order Amount`.

Bu tabloda da dört satır vardır:

* İlk satır: Order0102, Customer001 tarafından verilmiş, `Order Amount` 20.
* İkinci satır: Order0103, Customer008 tarafından verilmiş, `Order Amount` 40.
* Üçüncü satır: Order0104, Customer002 tarafından verilmiş, `Order Amount` 22.
* Dördüncü satır: Order0105, Customer004 tarafından verilmiş, `Order Amount` 30.

Şimdi bu tabloları ileri düzey `JOIN` örneklerinde kullanalım.

---

## ✅ `INNER JOIN`: Satın Alma Yapan Müşterileri Bulma

Diyelim ki satın alma yapan tüm müşterileri bulmak istiyorsunuz.

Bunu yapmak için **Customers** ve **Orders** tabloları arasında bir `INNER JOIN` kullanırsınız.

`INNER JOIN`, yalnızca her iki tabloda da eşleşme olan satırları döndürür.

`SELECT` ifadesiyle başlayın; `Customers.Name` ve `Orders.OrderID` sütunlarını virgülle ayırarak listeleyin.

Ardından `FROM` ile **Customers** tablosundan veri çekin ve sonra `INNER JOIN Orders` ekleyin.

`ON` yan tümcesiyle `Customers.CustomerID` ile `Orders.CustomerID`’yi bağlayın.

Bu sorgu, sipariş vermiş tüm müşterileri ve karşılık gelen sipariş ID’lerini döndürür.

Sonuçta üç müşteri görürüz: John, Anissa ve Penelope.

* John (CustomerID 001), OrderID 0102 olan siparişi vermiştir.
* Anissa (CustomerID 002), OrderID 0104 olan siparişi vermiştir.
* Penelope (CustomerID 004), OrderID 0105 olan siparişi vermiştir.

CustomerID’si 003 olan Mark sonuçta görün이고, çünkü Orders tablosunda onunla eşleşen bir kayıt yoktur; yani hiç sipariş vermemiştir.

Benzer şekilde, geçerli bir CustomerID’ye bağlı olmayan siparişler (ör. CustomerID 008’e sahip OrderID 0103) da dışlanır; çünkü Customers tablosunda eşleşen bir kayıt yoktur.

---

## ⬅️ `LEFT JOIN`: Sipariş Vermeyenleri de Dahil Etme

Peki ya satın alma yapmamış olanlar dahil tüm müşterileri istiyorsanız?

Bu durumda, sol tablodaki (bu örnekte Customers) tüm satırları döndürmek için `LEFT JOIN` kullanırsınız.

Sözdizimi `INNER JOIN` ile aynıdır; sadece `JOIN` kısmını `LEFT JOIN` ile değiştirirsiniz.

Sözdizimi: `SELECT Customers.CustomerName, ORDERS.OrderID FROM Customers THEN LEFT JOIN ORDERS ON Customers.CustomerID == ORDER.CustomerID.`

Bu, sipariş vermemiş müşterilerin de sonuçlara dahil edilmesini sağlar; eksik sipariş bilgileri `NULL` olarak görünür.

Sonuçta dört müşteri görürüz: John, Anissa, Penelope ve Mark.

* John, OrderID 0102.
* Anissa, OrderID 0104.
* Penelope, OrderID 0105.
* Mark sonuçta görünür; ancak sipariş vermediği için OrderID alanı `NULL` olur.

Bu, `LEFT JOIN`’un temel farkıdır: Mark, eşleşen sipariş olmamasına rağmen dahil edilir.

Ancak OrderID 0103 gibi geçerli müşteriye bağlı olmayan siparişler yine dışarıda kalır; çünkü `LEFT JOIN` customers tablosunu önceliklendirir.

---

## ➡️ `RIGHT JOIN`: Müşterisi Olmayan Siparişleri de Dahil Etme

Şimdi tersini yapalım.

Eğer tüm siparişlere odaklanmak ve eşleşen müşterisi olmayan siparişleri de dahil etmek istiyorsanız, `RIGHT JOIN` kullanırsınız.

`LEFT JOIN` gibi, sözdizimi neredeyse aynıdır; sadece `LEFT` yerine `RIGHT` yazarsınız.

Sözdizimi: `SELECT Customers.CustomerName, ORDERS.OrderID FROM Customers, then RIGHT JOIN ORDERS on Customers.CustomerID equals ORDERS.CustomerID.`

Bu sorgu, eşleşen müşterisi olmayanlar dahil tüm siparişleri döndürür.

Sonuçta 4 sipariş görürüz: 3’ü müşterilerle ilişkili, 1’i değil.

* John, OrderID 0102.
* Anissa, OrderID 0104.
* Penelope, OrderID 0105.
* OrderID 0103 de görünür. Customers tablosunda CustomerID 008’e karşılık gelen bir kayıt olmadığı için bu siparişte `CustomerName` `NULL` olur.

CustomerID’si 003 olan Mark ise sonuçta görünmez; çünkü sipariş vermemiştir ve `RIGHT JOIN` yalnızca ilgili siparişi olan müşterileri getirir.

---

## 🌐 `FULL OUTER JOIN`: Her Şeyi Getirme

Peki ya her şeyi almak isterseniz; yani eşleşsin ya da eşleşmesin tüm müşteriler ve tüm siparişler?

Bunun için `FULL OUTER JOIN` kullanırsınız.

Bu `JOIN`, müşterileri veya siparişleri kaçırmamanızı sağlar; doğrudan ilişkili olmasalar bile.

Sözdizimi diğerleriyle aynı; sadece `JOIN` kısmını `FULL OUTER JOIN` ile değiştirirsiniz.

Sözdizimi: `SELECT CUSTOMERS.CustomerName, ORDERS.OrderID from Customers, then FULL OUTER JOIN ORDERS on Customers.CustomerID equals ORDERS.CustomerID.`

Bu sorgu, ilişkili olmasalar bile tüm müşterileri ve tüm siparişleri döndürür; eksik bilgi `NULL` ile doldurulur.

Sonuçta 4 müşteri ve 4 sipariş görürüz.

* John (CustomerID 001), OrderID 0102 siparişini vermiştir.
* Anissa (CustomerID 002), OrderID 0104 siparişini vermiştir.
* Penelope (CustomerID 004), OrderID 0105 siparişini vermiştir.
* Mark (CustomerID 003) sonuçta yer alır; ancak sipariş vermediği için `OrderID` ve `OrderAmount` `NULL` olur.
* CustomerID 008’e sahip OrderID 0103 de dahil edilir; ancak eşleşen müşteri olmadığı için müşteri bilgileri `NULL` görünür.

`FULL OUTER JOIN`, iki tabloda da karşılığı olmasa bile hem müşterilerin hem de siparişlerin sonuçta yer almasını garanti eder.

---

## ✅ Özet

Bu videoda, birleştirilmiş veri almak için farklı `JOIN` türlerini kullanarak SQL sorgularının nasıl yazılacağını öğrendiniz.

İster müşteriler ve siparişler gibi verilerle çalışıyor olun ister başka sektörlerdeki bilgileri ele alıyor olun; SQL `JOIN`’ları, ilişkili veriyi verimli biçimde birleştirmenize ve analiz etmenize olanak tanır.

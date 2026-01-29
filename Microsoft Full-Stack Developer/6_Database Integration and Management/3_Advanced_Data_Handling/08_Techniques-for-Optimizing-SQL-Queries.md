## 🛠️ SQL Sorgularını Optimize Etme Teknikleri

SQL sorgularını optimize etmek, bir motoru ayarlamak gibidir. Doğru yapıldığında, özellikle yüksek trafikli sistemlerde performansı ciddi biçimde artırabilir. Bu videoda, performansı artırmak için SQL sorgularını optimize etme tekniklerini açıklayacağız.

---

## 🧱 İndeksleme ile Optimizasyon

SQL optimizasyon tekniklerinden indekslemeyi inceleyerek başlayalım.

İndeksleme, bir tablonun bir veya daha fazla sütunu üzerinde bir veri yapısı oluşturan bir tekniktir; böylece veritabanı, tüm tabloyu taramadan belirli satırları hızlıca bulabilir.

Örneğin, benzersiz çalışan kimlikleri ( *unique employee IDs* ) içeren bir sütunu indekslerseniz, veritabanı veriyi yapılandırılmış bir şekilde çekebilir ve taraması gereken satır sayısını en aza indirir.

Birden fazla indeks türü vardır, ancak iki yaygın türe odaklanalım.

---

## 🧷 Tek Sütunlu ve Bileşik İndeksler

Tek sütunlu indeks ( *single-column index* ), yalnızca bir sütun üzerinde çalışır; örneğin bir ID veya tarih sütunu. Tek bir değere göre arama yapmanız gerektiğinde çok etkilidir.

Bileşik indeks ( *composite index* ), birden fazla sütunu kapsar ve birden fazla alana göre filtreleme yapan sorguları optimize etmeye yardımcı olur.

Örneğin, bir sorgu hem departmana hem de lokasyona göre arama yapıyorsa, bu iki sütun üzerinde oluşturulan bileşik indeks, her bir sütuna ayrı ayrı indeks oluşturmaktan daha fazla performans artışı sağlayacaktır.

---

## 🧠 Query Planning ve Execution Plan

İndekslemenin ötesinde, veritabanının sorgunun tamamını nasıl organize ettiğini ve çalıştırmayı nasıl planladığını anlamak, performansı optimize etmek için kritiktir. İşte burada sorgu planlama ( *query planning* ) devreye girer.

SQL Optimizer’ın bir *execution plan* (çalıştırma planı) oluşturduğunu hatırlayın. Bu plan, veritabanının bir sorguyu yürütmek için izlediği adımlar dizisidir.

Çalıştırma planını inceleyerek, veritabanının verimli bir yol seçip seçmediğini veya iyileştirme alanı olup olmadığını değerlendirebiliriz.

---

## 🔍 Scan Efficiency

Execution plan’lar veritabanına göre değişir, ancak yaygın bir unsur “scan efficiency” (tarama verimliliği) içerir.

Scan efficiency, veritabanının veri çekmek için bir tabloyu ne kadar etkili taradığını ifade eder; bu tarama genellikle iki şekilde yapılır:

* *full table scan* (tam tablo taraması)
* *index scan* (indeks taraması)

İndeks olmadığında veritabanı, tablodaki her satırı kontrol ederek tam tablo taramasına dayanır; bu da özellikle büyük veri setlerinde daha yavaştır.

İndekslerin taranması veya değiştirilmesi sonucunda *index scan* ortaya çıkar ve tarama verimliliğini artırabilir. Index scan ile veritabanı doğrudan ilgili veriye gidebilir.

---

## 🔗 Join Efficiency

Scan efficiency ile birlikte, execution plan’lar yapılan join’lerin verimliliğini de iyileştirir.

Join efficiency, veritabanının birden fazla tablodan gelen veriyi ne kadar etkili biçimde birleştirdiğidir.

Join işlemleri execution plan’da gösterilir ve maliyeti yüksek join’ler, join verimliliğini artırmak için bir fırsata işaret edebilir.

Join’leri yeniden yapılandırmak veya yeniden sıralamak — örneğin önce daha küçük tabloları işlemek — veritabanının aynı anda ele aldığı veri miktarını azaltır ve genel sorgu performansını artırır.

---

## 🧩 Diğer Pratik Optimizasyon Stratejileri

İndeksleme ve query planning güçlü optimizasyon teknikleri olsa da, sorguları optimize etmek için başka pratik stratejiler de vardır. En etkili olanlardan birkaçını inceleyelim.

Bazen bir sorguyu az da olsa yeniden yazmak büyük fark yaratabilir. Örneğin, alt sorgu ( *subquery* ) yerine join kullanmak yürütme süresini azaltabilir.

Alternatif olarak, ilişkili bir tabloda değer kontrolü yaparken `IN` yerine `EXISTS` anahtar sözcüğünü kullanmak işlemleri hızlandırabilir.

---

## 🎯 Gereksiz Hesaplamalardan Kaçınmak

Sorguları yeniden yazmanın yanında, gereksiz hesaplama veya koşullardan kaçınmak da performansı artırabilir.

Örneğin, `SELECT *` kullanmak yerine yalnızca ihtiyacınız olan sütunları listelemek, işlenen veri miktarını azaltır.

Ayrıca, sonuçları filtrelemek için sorgunuza mutlaka `WHERE` ifadeleri ekleyin. Bu, veritabanının iş yükünü azaltır ve veri çekmeyi hızlandırır.

---

## 📄 Büyük Veri Setlerinde Pagination

Son olarak, büyük veri setleri için yalnızca gerekli olanı çekmek kritik önem taşır. Bu, pagination (sayfalama) kullanılarak veri çekmenin sınırlandırılmasıyla yapılır.

Pagination, büyük bir sonuç kümesini daha küçük, yönetilebilir sayfalara bölerek veri çekmeyi sınırlar ve sorgu performansını artırır.

Örneğin, bir SQL sorgusunda `LIMIT` ve `OFFSET` anahtar sözcüklerini kullanmak, her seferinde daha az sayıda kaydı çekmenize olanak tanır.

Bu, uygulamalarda veriyi görüntülerken özellikle faydalıdır; çünkü binlerce sonucu tek seferde almak yerine sayfa başına 100 sonuçla çalışmak daha verimlidir.

---

## ✅ Kapanış

Bu videoda, performansı artırmak için SQL sorgularını optimize etme tekniklerini öğrendiniz.

SQL sorgularını optimize etmek, veritabanlarımızı duyarlı tutmamıza ve uygulamalarımızın sorunsuz çalışmasına yardımcı olur. İndeksleme kullanarak, sorgu planlarını anlayarak ve sorgu yeniden yazımı ile pagination gibi akıllı optimizasyon stratejileri uygulayarak sorgu performansında önemli iyileştirmeler yapabiliriz.

Bu tekniklerle, daha büyük veri setlerini verimli biçimde ele almaya hazırsınız.

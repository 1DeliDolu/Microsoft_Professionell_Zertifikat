## 🗄️ İlişkisel Veritabanlarının Temel Yapısı

Çok büyük miktarda veri gerektiren bir proje hayal edin ve bu veriyi kolayca arayabileceğiniz, güncelleyebileceğiniz ve analiz edebileceğiniz şekilde düzenlemenin bir yoluna ihtiyacınız olduğunu düşünün. İşte bu noktada **ilişkisel veritabanları** devreye girer. Her tür bilgiyi yönetmek için mantıklı ve verimli bir sistem sunarlar.

Bu videoda, tablolar, satırlar ve sütunlar dâhil olmak üzere ilişkisel veritabanlarının temel yapısını açıklayacağız. İlişkisel veritabanları, veriyi yönetmek için yapılandırılmış ve düzenli bir yaklaşım sundukları için programcıların en sık çalıştığı veritabanları arasındadır.

İlişkisel veritabanları birkaç temel unsurdan oluşur:  **tablolar** , **satırlar** ve  **sütunlar** . Önce tabloların ne olduğuna bakalım.

---

## 📋 Tablolar

Bir veritabanı tablosu, satırlar ve sütunlar hâlinde düzenlenmiş yapılandırılmış bir veri koleksiyonudur. Tablolar, ilişkisel veritabanlarının yapı taşlarıdır.

Örneğin, bir şirketin çalışanlar için bir tablosu, departmanlar için başka bir tablosu ve projeler için üçüncü bir tablosu olabilir. Her tablo, kendi konusu hakkında bilgi içerir.

Şimdi verinin tablolar içinde sütunlar ve satırlar aracılığıyla nasıl düzenlendiğini inceleyelim.

---

## 🧱 Sütunlar

Sütunlar, bir tablodaki veri kümesinin belirli niteliklerini saklayan veri alanlarını temsil eder.

Örneğin, bir **employees** tablosunda şu sütunlar olabilir:

* *employee ID*
* *first name*
* *department ID*
* *salary*

Her sütun aynı türde veri saklar. Örneğin, çalışan maaşlarını içeren bir sütunda yalnızca sayılar bulunurken, çalışanların adını içeren bir sütunda yalnızca harfler bulunur ve sayı olmaz.

---

## 🧾 Satırlar

Satırlar, sütunlardan farklı olarak, bir tablodaki tekil girişlerdir; tüm sütunlar boyunca bir veri kaydını içerir.

Örneğin, **employees** tablosundaki bir satır şu bilgileri içerebilir:

* *employee ID* değeri **001**
* *first name* değeri **John**
* *department ID* değeri **marketing**
* *project* değeri **summer campaign**

Her satır, bir çalışanın tam kaydıdır.

---

## 🧩 Şemalar

Şimdi farklı tabloları yönetmenin ve birbirine bağlamanın bir yolunu inceleyelim. İşte burada **şemalar** devreye girer.

Bir şema, tabloların yapısını ve birbirleriyle nasıl ilişkilendirildiklerini tanımlayan veritabanı için bir **plan** ( *blueprint* ) niteliğindedir. Şemalar, organizasyonda tutarlılık sağlamaya yardımcı olur.

Örneğin, şema her tablodaki sütunları tanımlar. Ayrıca bir tablodaki verinin (örneğin  **employees** ) başka bir tablodaki veriye (örneğin  **departments** ) nasıl bağlanabileceğini de tanımlar.

Tabloları bir şema kullanarak bağlamak için **primary key** ve **foreign key** kullanırız.

---

## 🔑 Primary Key

Bir  **primary key** , bir tabloda her satırı benzersiz şekilde tanımlayan ve o anahtar için iki satırın aynı değere sahip olamayacağını garanti eden özel bir sütundur; bazen sütunların bir kombinasyonu da olabilir.

Örneğin, **employees** tablosunda *employee ID* primary key olabilir. Bu, tabloda **PK** olarak etiketlenir.

Her çalışanın benzersiz bir kimliği olduğu için onları tanımlamak kolaydır. Bu nedenle  *employee ID* ’yi primary key olarak kullanabiliriz.

---

## 🔗 Foreign Key

Şimdi, tabloları birbirine bağlamaya yardımcı olan **foreign key** kavramına geçelim.

Bir  **foreign key** , başka bir tablonun primary key’ine referans vererek iki tablo arasında bağlantı oluşturan bir sütundur.

Örneğin, **employees** tablosunda bulunan *department ID* sütunu, her çalışanı **departments** tablosundaki bir departmana bağlayan bir foreign key’dir.

Bu, tablolarımızda **FK** olarak etiketlenir. *department ID* sütunu aynı zamanda **departments** tablosu için primary key’dir.

Primary key ve foreign key birlikte çalışarak tablolar arasındaki ilişkileri zorunlu kılar. Yalnızca veriyi organize etmeye yardımcı olmakla kalmaz, aynı zamanda tablolar arasındaki bağlantıların doğru ve tutarlı kalmasını sağlarlar.

Veri bütünlüğünü koruyarak ve tekrarları önleyerek, primary key ve foreign key ilişkisel veritabanı boyunca verinin verimli şekilde yönetilmesini ve alınmasını sağlar.

---

## 🧾 Kapanış

Bu videoda, tablolar, satırlar ve sütunlar dâhil olmak üzere ilişkisel veritabanlarının temel yapısını öğrendiniz.

Bu yapıyı anlamak, ilişkisel veritabanları kullanarak arka uç geliştirme için temel bir yapı taşıdır.

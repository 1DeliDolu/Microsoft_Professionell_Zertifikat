## ➕ `INSERT` İfadeleri ile Veri Ekleme

Canlı bir veritabanıyla çalışırken, yeni bilgileri hızlı ve doğru şekilde eklemek kritik öneme sahiptir. İster kullanıcı verilerini, ister ürün envanterlerini, ister işlem kayıtlarını yönetin; yeni kayıtları sorunsuz şekilde eklemeyi bilmek temel bir beceridir.

Bu videoda, `INSERT` ifadelerini kullanarak bir veritabanına yeni kayıtların nasıl ekleneceğini açıklayacağız.

---

## 🧩 `INSERT` İfadesi Nedir?

`INSERT` ifadesi, bir veritabanındaki tabloya yeni satırlar eklemek için kullanılan bir SQL komutudur. Uygulamaların yeni bilgileri depolamasına olanak tanıyan ve organizasyonların verilerini güncel ve düzenli tutmasına yardımcı olan, veri yönetiminin temel araçlarından biridir.

`INSERT` ifadesi; verinin ekleneceği tabloyu ve sütunları belirtir, ardından eklenecek değerleri sağlar.

---

## 🧱 Temel Sözdizimi

Temel sözdizimi, veri kaydı eklediğiniz tablonun adıyla birlikte `INSERT INTO` ile başlar.

Sonrasında, değer ekleyeceğiniz sütunları belirtirsiniz.

Ardından `VALUES` anahtar kelimesini kullanır ve eklemek istediğiniz gerçek verileri sağlarsınız.

Her değer, aynı sıradaki sütuna karşılık gelir.

---

## 1️⃣ Tek Satır Ekleme Örneği

Tek bir satır ekleme örneğiyle başlayalım.

**Customers** adlı bir tablomuz olduğunu varsayalım. Müşteri kimliği 1 olan **John Doe** adlı yeni bir müşteriyi eklemek için bir `INSERT` ifadesi kullanırız.

Bu ifade, veriyi eklediğimiz tablonun adı olan `Customers` ile birlikte `INSERT INTO` ile başlar.

Sonrasında, `First Name`, `Last Name` ve `Customer ID` sütun adlarını parantez içinde listeleriz.

Ardından `VALUES` anahtar kelimesi gelir ve eklemek istediğimiz gerçek verileri parantez içinde yazarız: `First Name` için John, `Last Name` için Doe ve `Customer ID` için 1.

Metin değerlerinin tek tırnak içinde yazıldığını, sayıların ise tırnaksız olarak yazıldığını fark edin.

Bu yaklaşım, tabloya tek bir kayıt eklememizi sağlar.

---

## 2️⃣ Aynı Anda Birden Fazla Satır Ekleme

Peki ya aynı anda birden fazla satır eklemek istersek?

Birden çok `INSERT` ifadesi kullanmak yerine, SQL tek bir ifadede birden fazla satır eklemenize izin verir; bu da performansı önemli ölçüde artırabilir.

Birden fazla satır ekleme süreci, tek satır eklemeye benzer; ancak tek bir değer kümesi vermek yerine, virgülle ayrılmış birden fazla değer kümesi ekleriz.

İki müşteri ekleme örneğini parçalayalım: **Jane Smith** ve  **Mike Brown** .

İfade `INSERT INTO` ve tablo adı `Customers` ile başlar.

Sonra sütun adlarını parantez içinde listeleriz: `First Name`, `Last Name` ve `Customer ID`.

Ardından `VALUES` anahtar kelimesini kullanırız ve iki değer kümesi sağlarız; her küme parantez içindedir ve aralarında virgül vardır.

Jane Smith için değerler: `First Name` için Jane, `Last Name` için Smith ve `Customer ID` için 2.

Mike Brown için değerler: `First Name` için Mike, `Last Name` için Brown ve `Customer ID` için 3.

Yine, metin değerleri tek tırnak içinde yazılırken, sayılar tırnaksız yazılır.

Bu yöntem, iki satırı tek bir ifadede ekler ve her kayıt için ayrı `INSERT` ifadeleri kullanmaktan daha verimli bir işlem sağlar.

---

## 🔗 Foreign Key İçeren Tabloya Veri Ekleme

Şimdi daha karmaşık bir örneğe geçelim.

Çoğu zaman, yabancı anahtar ( *foreign key* ) içeren bir tabloya veri eklemeniz gerekir; bu durumda verinin foreign key kısıtlarıyla uyumlu olması gerekir.

Bunu göstermek için foreign key içeren bir örnek kullanalım.

Bu örnekte, **ORDERS** tablosuna veri ekliyoruz. Bu tabloda, **Customer ID** sütunu bir foreign key olarak görev yapar; yani **Customers** tablosuna bağlanır.

Yeni bir sipariş eklemek için, **ORDERS** tablosundaki `Customer ID`, **Customers** tablosunda mevcut olan bir müşteriye karşılık gelmelidir.

Örneğin, `Customer ID` 1’in John Doe’ya ait olduğunu biliyorsak, onun için bir sipariş ekleyebiliriz.

`INSERT` ifadesi, `INSERT INTO` ve tablo adı `ORDERS` ile başlar.

Sonrasında, `ORDER ID`, `CUSTOMER ID`, `PRODUCT` ve `QUANTITY` sütun adlarını parantez içinde listeleriz.

`VALUES` anahtar kelimesinin altında eklemek istediğimiz değerleri veririz: `ORDER ID` 102, John Doe için `CUSTOMER ID` 1, sipariş edilen `PRODUCT` (bu örnekte SMARTPHONE) ve `QUANTITY` 3.

Foreign key kısıtı, referans verdiğimiz `CUSTOMER ID` değerinin yeni sipariş eklenmeden önce **CUSTOMERS** tablosunda zaten var olmasını zorunlu kılar.

Eğer **CUSTOMERS** tablosunda var olmayan bir `CUSTOMER ID` ile bir sipariş eklemeye çalışırsak, veritabanı işlemi engelleyen bir **ERROR** döndürür.

Bu hata, tablolar arasındaki ilişkilerin eksik veya yanlış olduğu kayıtları önlemek için bir güvenlik mekanizması görevi görür ve her siparişin geçerli bir CUSTOMER referansına sahip olmasını sağlar.

---

## ✅ Özet

Bu videoda, `INSERT` ifadelerini kullanarak bir veritabanına yeni kayıtların nasıl ekleneceğini öğrendiniz.

İster tek bir kayıt ekliyor olun, ister birden fazla; `INSERT` ifadesi veritabanınıza yeni veri eklemeyi kolaylaştırır.

Bu örnekleri pratik edin; yakında herhangi bir tabloya veri ekleme konusunda rahat hissedeceksiniz.

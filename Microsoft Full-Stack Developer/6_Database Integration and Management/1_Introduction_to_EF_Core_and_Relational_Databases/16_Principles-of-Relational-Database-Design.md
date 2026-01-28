## 🧠 İlişkisel Veritabanı Tasarımının Prensipleri

Büyük veritabanlarının boyut ve karmaşıklık arttıkça bile nasıl düzenli ve verimli kaldığını hiç merak ettiniz mi? İlişkisel veritabanı tasarımının arkasındaki prensipleri anlamak, ölçeklenebilir ve sürdürülebilir sistemler oluşturmanın anahtarıdır.

Bu videoda, ilişkisel veritabanı tasarımının temel prensiplerini açıklayacağız.

---

## 🧩 Üç Temel Prensip

İlişkisel veritabanı tasarımı üç temel prensip içerir:  **ilişkiler** , **normalizasyon** ve **kısıtlar** ( *constraints* ).

---

## 🔗 İlişkiler

İlişkiler, bir veritabanındaki farklı tabloların birbirine nasıl bağlandığını tanımlar. Üç yaygın ilişki türü vardır: **bire bir** ( *one-to-one* ), **bire çok** ( *one-to-many* ) ve **çoğa çok** ( *many-to-many* ).

Şimdi her birini daha ayrıntılı inceleyelim.

### 1️⃣ Bire Bir ( *One-to-One* )

Bire bir ilişki, bir tablodaki her kaydın başka bir tabloda tam olarak bir kayda karşılık gelmesi anlamına gelir.

Örneğin, her özel baskının belirli bir kitaba benzersiz şekilde ait olduğu özel baskı kopyalarını takip etseydik, **Special Editions** adlı bir tablo oluşturabilirdik.

**Books** tablosundaki her kayıt, **Special Editions** tablosunda bir eşleşen kayda sahip olurdu; bu da onu bire bir ilişki yapardı.

### 2️⃣ Bire Çok ( *One-to-Many* )

Bire çok ilişki daha yaygındır. Bir yazar birçok kitap yazabilir; ancak her kitap genellikle yalnızca bir birincil yazara sahiptir.

Bu durumda **Authors** tablosu ile **Books** tablosu, bir foreign key olan *authorid* aracılığıyla bire çok ilişkiyle bağlanır.

Bu, her yazarın ayrıntılarını bir kez saklamamıza ve birden fazla kitapta referans vermemize yardımcı olur.

### 3️⃣ Çoğa Çok ( *Many-to-Many* )

Çoğa çok ilişkide, bir tablodaki birden fazla kayıt, başka bir tablodaki birden fazla kayıtla ilişkilidir.

Kitap veritabanımızda, birçok kitap birçok yazar tarafından yazılabilir ve birçok yazar birden fazla kitap yazabilir.

Bunu temsil etmek için genellikle **junction table** olarak adlandırılan üçüncü bir tablo oluştururuz; örneğin **book authors** gibi.

 **Junction table** , iki ya da daha fazla tablo arasındaki çoğa çok ilişkiyi temsil etmek için kullanılan bir veritabanı tablosudur.

Bu junction table, hangi tabloların birleştirildiğinin açık olması için **authors books** olarak adlandırılır.

 **Authors books** , **Books** ve **Authors** tablolarını birbirine bağlar.

**Books Authors** tablosundaki her kayıt, bir yazarın bir kitaba yaptığı katkıyı temsil eder; bu da hangi yazarın hangi kitabı yazdığını takip etmeyi mümkün kılar.

---

## 🧼 Normalizasyon

İlişkilerin tabloları nasıl bağladığını anladığımıza göre, ilişkisel veritabanı tasarımında **normalizasyon** prensibini inceleyelim.

Normalizasyon, fazlalığı ( *redundancy* ) azaltmak ve veri bütünlüğünü ( *data integrity* ) artırmak için veriyi tablolara, sütunlara ve ilişkilere göre düzenleme sürecidir.

Veritabanı tasarımında genellikle **normal formlar** ( *normal forms* ) olarak adlandırılan üç ana normalizasyon aşamasını takip ederiz.

### 🥇 Birinci Normal Form (1NF)

Birinci normal form ( **1NF** ), bir tablodaki her sütunun atomik ( *atomic* ), yani bölünemez değerler içermesini gerektirir; yani aynı alanda tekrarlayan veri olmaz.

Kitap veritabanımızda normalizasyonun 1NF ile nasıl çalıştığını görelim: **Books** tablosunda tek bir alanda birden fazla yazar saklamak yerine, satır başına yalnızca bir yazar saklarız.

### 🥈 İkinci Normal Form (2NF)

İkinci normal form ( **2NF** ), kısmi bağımlılıkları ( *partial dependencies* ) ortadan kaldırır; yani primary key olmayan niteliklerin ( *attributes* ) primary key’e tam bağımlı olmasını sağlar.

Kitap veritabanımızda 2NF’ye ulaşmak için ayrı bir **Authors** tablosu oluşturur ve yazar adını buraya taşırız.

Daha sonra kitapları yazarlar tablosuna bağlamak için *authorid* gibi bir foreign key kullanırız.

### 🥉 Üçüncü Normal Form (3NF)

Üçüncü normal form ( **3NF** ), bir tabloda bulunan her bilginin yalnızca primary key’e bağlı olmasını sağlayarak fazlalığı daha da azaltır.

Bu, tablonun ana konusuyla doğrudan ilişkili olmayan detayları saklamayı önler.

Örneğin, yazar hakkında biyografi veya doğum tarihi gibi ek bilgileri **Books** tablosunda saklıyor olsaydık, bu detayları **Authors** tablosuna taşırdık.

Bu şekilde, yazara özgü tüm bilgiler **Authors** tablosunda saklanır ve **Books** tablosunda yalnızca *author ID* tutulur; böylece anahtar olmayan nitelikler arasında geçişli bağımlılıklar ( *transitive dependencies* ) olmaz.

Başka bir deyişle, bu; bilgilerin net bir şekilde ayrılmasını sağlar ve fazlalığı önler.

---

## ✅ Kısıtlar ( *Constraints* )

Veri artık ilişkiler ve normalizasyon aracılığıyla verimli şekilde düzenlendiğine göre, doğruluğunu sağlamak için kısıtlar uygulamamız gerekir.

Kısıtlar, verinin doğru kalmasını ve belirli kurallara uymasını sağlamak için veriye uygulanan kurallardır.

En yaygın kısıt türlerine bakalım; ilk olarak  **NOT NULL** .

### 🚫 NOT NULL

**NOT NULL** kısıtı, belirli alanların boş bırakılamamasını sağlar.

Kitap veritabanımızda *ISBN* sütununa NOT NULL uygulamak, geçerli bir ISBN olmadan hiçbir kitabın eklenemeyeceği anlamına gelir.

### 🆔 UNIQUE

**UNIQUE** kısıtı, belirli bir sütundaki tüm değerlerin farklı olmasını sağlar.

Kitap veritabanımızda UNIQUE kısıtı, iki kitabın aynı ISBN’e sahip olmasını engeller.

### ✅ CHECK

**CHECK** kısıtı, bir sütundaki verinin belirli koşulları sağlamasını zorunlu kılar.

Örneğin, kitapların yayın yılı için bir CHECK kısıtı kullanarak yayın yılının her zaman **1500’den büyük** olmasını sağlayabiliriz.

Bu, veritabanına geçersiz yılların girilmemesini garanti eder.

### 🧾 DEFAULT

**DEFAULT** kısıtı, bir sütuna değer girilmediğinde otomatik bir varsayılan değer atamak için kullanılır.

Örneğin, bir kitabın fiyatı belirtilmemişse, DEFAULT kısıtı ile fiyatı otomatik olarak **$10** olarak ayarlayabiliriz; böylece fiyat sütununda her zaman bir değer olur.

Bu kısıtlar veri bütünlüğünü korumaya yardımcı olur; verinin güvenilir olmasını ve tanımladığımız kuralları takip etmesini sağlar.

Kısıtları uygulayarak yanlış veya eksik verinin veritabanına girmesini engeller, her şeyi tutarlı ve geçerli tutarız.

---

## 🧾 Kapanış

İlişkisel veritabanı tasarım prensipleri olan  **ilişkiler** , **normalizasyon** ve  **kısıtlar** , verinin verimli saklanmasını, fazlalığın azaltılmasını ve doğruluğun korunmasını sağlar.

Bu kavramları anlamak, büyüdükçe düzenli kalan ve veri bütünlüğünü koruyan ölçeklenebilir veritabanları oluşturmanıza imkân verir.

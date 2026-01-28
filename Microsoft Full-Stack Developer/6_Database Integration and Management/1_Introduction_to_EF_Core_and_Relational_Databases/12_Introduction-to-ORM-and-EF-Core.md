## 🧩 ORM ve EF Core’a Giriş

Bir uygulamada veriyi manuel olarak yönetmek kısa sürede bunaltıcı hâle gelebilir. Veriyi her kaydetmeniz, güncellemeniz veya geri almanız gerektiğinde, tekrarlayan kodlar yazmanız ve her işlemi dikkatle tek tek yönetmeniz gerekir.

Uygulamanız ölçeklendikçe bu yaklaşım verimsizleşir ve hataya açık hâle gelir; en küçük değişiklikler bile önemli bir iş hâline gelir. İşte bu noktada **nesne-ilişkisel eşleme** ( *object-relational mapping* ) yani  **ORM** ’lar devreye girer.

Bu videoda, nesne-ilişkisel eşleme kavramını ve bir ORM aracı olarak  **EF Core** ’un rolünü açıklayacağız.

---

## 🗄️ İlişkisel Veritabanlarını Tanımlayalım

ORM’ları konuşmadan önce, nesne-ilişkisel eşlemenin önemli bir parçası olan ilişkisel veritabanlarını tanımlayalım.

İlişkisel veritabanı; her tablonun satır ve sütunlardan oluştuğu tablolara göre düzenlenmiş, yapılandırılmış bir veri koleksiyonudur.

Tablolar, tanımlayıcılar aracılığıyla birbirleriyle ilişkilidir; bu da **structured query language** kullanılarak verinin verimli biçimde alınmasını, düzenlenmesini ve saklanmasını sağlar.

**Structured Query Language** ya da  **SQL** , ilişkisel veritabanlarıyla iletişim kurmak ve onları yönetmek için kullanılan bir bilgisayar dilidir. SQL’i, veritabanlarıyla etkileşim kurmak için konuştuğunuz dil gibi düşünün.

Örneğin, bir kütüphane veritabanındaki bir tabloda kitap adları, yazarlar ve kitabın yayımlandığı yıl için sütunlar olabilir; satırlar ise tek tek kitapları temsil eder.

İlk satırda, Harper Lee tarafından yazılmış ve 1960 yılında yayımlanmış *To Kill a Mockingbird* yer alabilir. Bu satır ve sütun yapısı, ilişkisel veritabanlarını veriyi verimli şekilde yönetmek için güçlü araçlar hâline getirir.

---

## 🧱 Nesne Yönelimli Kod ve Veritabanı Yapısı Arasındaki Uyumsuzluk

Ancak, C Sharp gibi nesne yönelimli programlama dillerinde genellikle kodu nasıl yazdığımızı düşünelim.

Bu dillerde veriyi **nesneler** olarak temsil ederiz. C Sharp’ta veriyi sınıflar ve nesneler kullanarak temsil ederiz.

Örneğin, C Sharp’ta  *title* , *author* ve *publication* gibi özelliklere sahip bir **book** sınıfımız olabilir.

Bunu bir nesne olarak temsil etmek için, *title* değeri  *To Kill a Mockingbird* , *author* değeri *Harper Lee* ve *publication year* değeri *1960* olan **Book 1** adlı bir nesnemiz olabilir.

Bu, veriyi kodda nesneler olarak yapılandırma biçimimiz ile veritabanlarının veriyi tablolar olarak saklama biçimi arasında bir uyumsuzluk oluşturur.

Bir veritabanındaki verilere erişmek veya veriyi saklamak için normalde bu iki format arasında manuel çeviri yapmak adına birçok SQL sorgusu yazmamız gerekir; bu da zaman alıcı ve hataya açık olabilir.

---

## 🌉 ORM’lar Devreye Giriyor

İşte burada **nesne-ilişkisel eşleme** ( *ORM* ) devreye girer.

ORM’lar, C Sharp gibi nesne yönelimli programlama dilleri ile ilişkisel veritabanları arasında veri dönüştüren bir programlama tekniğidir.

Bu, geliştiricilerin ham SQL yazmak yerine veritabanıyla kodlarında **nesneler** üzerinden etkileşim kurmasını sağlar.

ORM’lar kodunuz ile veritabanı arasında bir köprü görevi görür; kodunuzdaki nesneler ile veritabanı tablosundaki kayıtlar arasındaki çeviriyi otomatik olarak yönetir.

---

## ⚙️ EF Core’u Keşfedelim

Artık ORM’ları anladığımıza göre, .net ekosisteminde yaygın olarak kullanılan bir araç olan **entity Framework Core** ya da  **EF Core** ’u inceleyelim.

EF Core, geliştiricilerin SQL sorguları yerine C Sharp nesneleri kullanarak ilişkisel veritabanlarıyla etkileşim kurmasını sağlayan, açık kaynaklı bir nesne-ilişkisel eşleme aracıdır.

Esnekliği ve verimliliğiyle bilinir; **CSRP** ile çalışan geliştiriciler için veritabanı etkileşimlerini sadeleştirir.

Örneğin, *title* değeri  *Charlotte's Web* , *author* değeri *EB White* ve *publication year* değeri *1952* olan **Book 2** adlı yeni bir book nesnesi oluşturmak istediğinizi düşünün.

EF Core bunu otomatik olarak veritabanına kaydeder.

Aynısı veri alma işlemi için de geçerlidir. EF Core, perde arkasındaki sequel’i yönetir ve sonuçları kodunuzda bir nesne olarak döndürür.

---

## 🧠 EF Core’un Temel Özellikleri

EF Core’un sunduğu bazı temel özellikleri inceleyelim; ilk olarak dil ile bütünleşik sorgular.

**Language-integrated queries** ya da  **LINQ** , geliştiricilerin veritabanı sorgularını doğrudan C sharp içinde yazmasına olanak tanır; böylece sorgular tip güvenli ( *type-safe* ), daha okunabilir ve uygulamanın mantığına entegre hâlde olur.

Ayrıca, otomatik veritabanı geçişleri ( *automatic database migrations* ), uygulamanız büyüdükçe veritabanınızı geliştirmeyi sağlar; örneğin tablo eklemek veya mevcut tabloları değiştirmek gibi.

Son olarak, EF Core’un **change tracking** özelliği, nesnelerin yaşam döngüsü boyunca yapılan değişiklikleri otomatik olarak izler; gerektiğinde bu değişikliklerle veritabanını güncelleme sürecini basitleştirir.

---

## ✅ EF Core Kullanmanın Avantajları

EF Core kullanımı, kullanım kolaylığı gibi pek çok avantaj sağlar. EF Core, veritabanlarıyla çalışmayı kolaylaştırır; çünkü karmaşık SQL sorguları yazmanıza gerek kalmaz.

Yalnızca nesneler ve C sharp ile çalışırsınız. Bu, yazmanız ve bakımını yapmanız gereken kod miktarını azaltır.

Bir diğer avantaj, sürdürülebilirliktir ( *maintainability* ). SQL, EF Core tarafından üretildiği için SQL kodunuzdaki küçük hatalar konusunda endişelenmenize gerek kalmaz.

Bunu sizin yerinize o yönetir.

Son olarak EF Core esnektir.  **SQL Server** , **PostgreSQL** ve **SQLite** gibi farklı veritabanı türlerini destekler; bu da hangi ilişkisel veritabanı kullanılırsa kullanılsın aynı ORM çerçevesini kullanabileceğiniz anlamına gelir.

---

## 🧾 Kapanış

Bu videoda, nesne-ilişkisel eşleme kavramını ve bir ORM aracı olarak EF Core’un rolünü öğrendiniz.

Arka uç geliştirici olarak çalışmalarınıza ORM ve EF Core’u dâhil etmek zaman kazandırır, karmaşıklığı azaltır ve kodunuzun daha sürdürülebilir olmasına yardımcı olur.

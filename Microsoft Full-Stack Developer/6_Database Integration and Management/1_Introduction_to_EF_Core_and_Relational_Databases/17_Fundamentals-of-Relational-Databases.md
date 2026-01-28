## 🗄️ İlişkisel Veritabanlarının Temelleri

---

## 🧾 Giriş

İlişkisel veritabanları, arka uç geliştirmede temel araçlardır ve verinin verimli, yapılandırılmış şekilde yönetilmesini sağlar. Büyük miktarda veriyi düzenli, tutarlı ve erişilebilir tutmak için tablolar, ilişkiler ve kısıtlar ile yapılandırılmış bir yaklaşım kullanırlar.

Tablo yapıları, ilişkiler ve normalizasyon gibi temel prensipler, güvenilir veri sistemlerinin temelini oluşturur.

---

## 🧱 İlişkisel Veritabanlarının Yapısı

İlişkisel veritabanları, veriyi satırlar (tekil kayıtlar) ve sütunlardan (nitelikler) oluşan tablolara düzenler. Tablolar, belirli konular etrafında tasarlanır (örneğin **"Employees"** veya  **"Departments"** ) ve ilişkisel veritabanlarının yapı taşlarını oluşturur.

Sütunlar belirli veri türlerini saklar (ör. maaşlar veya isimler), satırlar ise her tablo içinde tam kayıtları temsil eder. Bu tablo tabanlı yapı, ilişkisel veritabanlarının merkezindedir ve verinin verimli şekilde organize edilmesini ve alınmasını sağlar.

---

## 🔑 Anahtarlar ve Şemalar

### 🆔 Primary Key

Her satırı bir tabloda benzersiz şekilde tanımlar; tekrarları önler ve her kayda güvenilir biçimde erişilmesini sağlar.

### 🔗 Foreign Key

Başka bir tablodaki primary key’e referans vererek tabloları birbirine bağlar, ilişkileri kurar ve veri bütünlüğünü ( *data integrity* ) korur.

### 🧩 Şemalar ( *Schemas* )

Veritabanının yapısını, ilişkilerini ve organizasyonunu tanımlayan birer plan ( *blueprint* ) görevi görür. Tabloların birbirleriyle nasıl ilişkili olduğunu haritalandırarak veritabanı genelinde tutarlılığı sağlar.

---

## 🔄 Veritabanı İlişkileri

İlişkiler, tablolar arasında bağlantılar kurarak verinin farklı konular arasında ilişkilendirilmesini sağlar:

### 1️⃣ Bire Bir ( *One-to-One* )

Bir tablodaki her kayıt, başka bir tablodaki tek bir kayda karşılık gelir; örneğin tek bir çalışanın belirli bir kimlik kartına bağlanması gibi.

### 2️⃣ Bire Çok ( *One-to-Many* )

Bir tablodaki tek bir kayıt, başka bir tabloda birden çok kayda bağlanır. Örneğin, tek bir yazarın birden fazla kitapla ilişkilendirilebilmesi.

### 3️⃣ Çoğa Çok ( *Many-to-Many* )

Birleştirme tablosu ( *junction table* ) üzerinden yönetilir; bir tablodaki birden fazla kaydı başka bir tablodaki birden fazla kayda bağlar. Örneğin, yazarlar ve kitaplar; her yazar birden çok kitap yazabilir ve her kitabın birden çok yazarı olabilir.

---

## 🧼 Normalizasyon

Normalizasyon, bilgiyi giderek daha rafine aşamalarda düzenleyerek veri fazlalığını ( *redundancy* ) azaltır ve veri bütünlüğünü sağlar:

### 🥇 Birinci Normal Form (1NF)

Her sütunun atomik, bölünemez değerler içermesini sağlar; alanlar içindeki yinelenen veriyi ortadan kaldırır.

### 🥈 İkinci Normal Form (2NF)

Kısmi bağımlılıkları kaldırır; primary olmayan niteliklerin primary key’e tamamen bağlı olmasını sağlar.

### 🥉 Üçüncü Normal Form (3NF)

Tüm bilginin tablodaki primary key ile doğrudan ilişkili olmasını sağlayarak fazlalığı daha da azaltır ve ilişkili verinin gereksiz tekrarını önler.

---

## ✅ Kısıtlar ( *Constraints* )

Kısıtlar, verinin doğru ve tutarlı kalmasını sağlamak için veri üzerinde kurallar uygular:

### 🚫 NOT NULL

Kritik alanların boş bırakılmasını engeller; örneğin tüm kayıtların geçerli bir ID’ye sahip olmasını zorunlu kılmak gibi.

### 🆔 UNIQUE

Bir sütunda yinelenen değerleri engeller; örneğin her kitap kaydı için benzersiz ISBN’ler sağlamak gibi.

### ✅ CHECK ve 🧾 DEFAULT

Tutarlılığı korumak ve hatalı girişleri önlemek için belirli koşullar veya varsayılan değerler tanımlar; örneğin yayın yılı için geçerli yıl aralığı şartı koymak gibi.

---

## 🧾 Sonuç

İlişkisel veritabanı prensipleri, veriyi yönetmek için yapılandırılmış, ölçeklenebilir ve güvenilir bir temel oluşturur.

Tabloları, anahtarları, ilişkileri, normalizasyonu ve kısıtları anlamak; arka uç geliştiriciler için büyüdükçe veri bütünlüğünü koruyan, verimli ve düzenli sistemler tasarlamanın temelidir.

Bu unsurlar birlikte, her tür uygulama için kritik olan sağlam ve erişilebilir veritabanlarının geliştirilmesini mümkün kılar.

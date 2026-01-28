## 🧩 Entity Framework Core (EF Core)

---

## 🧾 Giriş

Bu okuma, **Nesne-İlişkisel Eşleme** ( *Object-Relational Mapping - ORM* )’nin nesne yönelimli programlamayla ilişkisel veritabanları arasında nasıl köprü kurduğunu açıklar ve .NET uygulamaları için güçlü bir ORM aracı olarak  **Entity Framework Core (EF Core)** ’u öne çıkarır.

---

## 🗝️ Temel Kavramlar

### 🗄️ İlişkisel Veritabanları ve SQL

İlişkisel veritabanları veriyi, satır ve sütunlardan oluşan yapılandırılmış tablolar içinde düzenler ve **SQL** ( *Structured Query Language* ) bu veriyi verimli bir şekilde yönetmek ve almak için kullanılır.

### 🧱 Nesne Yönelimli Programlama ve Veri Uyumsuzluğu

Nesne yönelimli dillerde veri **nesneler** olarak temsil edilir; veritabanları ise veriyi **tablolar** içinde saklar. Bu durum bir uyumsuzluk yaratır.  **ORM** , kod içindeki nesneleri ilişkisel tablolara bağlayarak bu sorunu çözer ve manuel SQL sorgusu yazma ihtiyacını azaltır.

### 🌉 ORM

 **ORM** , veriyi nesne yönelimli kod ile ilişkisel veritabanları arasında otomatik olarak çeviren bir tekniktir. Geliştiricilerin SQL yazmak yerine veriyi **nesneler** olarak düzenlemesini sağlar; böylece hata riski ve veri yönetiminin karmaşıklığı azalır.

---

## ⚙️ EF Core’un Genel Görünümü ve Özellikleri

### 🧰 EF Core

 **EF Core** , .NET ekosisteminde yer alan açık kaynaklı bir ORM aracıdır. Geliştiricilerin ilişkisel veritabanlarıyla **C# nesneleri** kullanarak etkileşim kurmasını sağlar ve doğrudan SQL sorgularını ortadan kaldırarak kodu sadeleştirir.

### ✨ EF Core’un Temel Özellikleri

#### 🧠 LINQ ( *Language Integrated Query* )

Sorgu yazma yeteneklerini doğrudan C# koduna entegre eder; sorguları **tip güvenli** ( *type-safe* ) ve **okunabilir** hâle getirir.

#### 🏗️ Veritabanı Geçişleri ( *Database Migrations* )

Veritabanı şemasının uygulama geliştirme süreciyle birlikte evrilmesini sağlar; tablo ekleme veya mevcut tabloları değiştirme gibi güncellemeleri destekler.

#### 🔄 Değişiklik Takibi ( *Change Tracking* )

Nesnelerde yapılan değişiklikleri otomatik olarak izler; veri değiştiğinde veritabanını güncelleme sürecini kolaylaştırır.

---

## ✅ EF Core’un Avantajları

EF Core; kullanım kolaylığı, esneklik ve sürdürülebilirlik ( *maintainability* ) sunar. Veritabanı etkileşimlerini C# nesneleri üzerinden mümkün kılar, SQL karmaşıklığını azaltır, birden çok veritabanını (örneğin  **SQL Server** , **PostgreSQL** ve  **SQLite** ) destekler ve ölçeklenebilirliği artırır.

---

## 🧾 Sonuç

ORM teknikleri ve EF Core, daha akıcı veritabanı etkileşimleri sağlayarak, kod karmaşıklığını azaltarak ve uygulama büyümesini destekleyerek arka uç geliştirmeyi kolaylaştırır.

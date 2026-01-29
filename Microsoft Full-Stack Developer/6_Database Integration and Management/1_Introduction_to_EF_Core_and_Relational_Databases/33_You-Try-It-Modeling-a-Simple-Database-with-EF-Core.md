## 🎯 You Try It! EF Core ile Basit Bir Veritabanı Modelleme

### 🧾 Amaç

Bu etkinliğin sonunda, .NET uygulamasında EF Core kullanarak basit bir veritabanı oluşturmak için veri modelleme tekniklerini uygulayabileceksiniz.

---

## 🧰 Adım 1

EF Core projeniz için ortamınızı kurun, gerekli bağımlılıkları yükleyin ve yeni bir console application oluşturun.

### ✅ Talimatlar

* EF Core tools’u global olarak yükleyin.
* **EFCoreModelApp** adlı yeni bir console application oluşturun ve proje dizinine gidin.
* EF Core **SQLite** ve **tools** paketlerini yükleyin.
* Kurulumun doğru olduğundan emin olmak için uygulamayı çalıştırın.

---

## 🧱 Adım 2

Veritabanınızdaki tabloları temsil edecek **Employee** ve **Department** entity class’larını tanımlayın.

### ✅ Talimatlar

* Proje dizininizde **Models** adlı bir klasör oluşturun.
* **Models** klasörü içinde employee kayıtlarını temsil etmek için **Employee** class’ı oluşturun.
* Department kayıtlarını temsil etmek için **Department** class’ı oluşturun.
* Employee’nin, ilişkili olduğu Department için bir **navigation property** içerdiğinden emin olun.

---

## 🧩 Adım 3

Entity’ler arasındaki ilişkileri ve veritabanı bağlantılarını yönetmek için **HRDbContext** class’ını oluşturun.

### ✅ Talimatlar

* Projenizin root dizininde **HRDbContext.cs** adlı bir dosya oluşturun.
* HRDbContext içinde **Employee** ve **Department** için `DbSet` property’leri tanımlayın.
* `OnConfiguring` metodunda bir **SQLite** veritabanı bağlantısı kurun.
* `OnModelCreating` metodunda Employee ve Department arasındaki ilişkileri tanımlayın.
* Employees ve departments için başlangıç verilerini ( *seed* ) ekleyin.

---

## 🧬 Adım 4

Veritabanı şemasını oluşturun ve SQLite veritabanınıza uygulayın.

### ✅ Talimatlar

* Mevcut model durumunu yakalamak için bir **initial migration** ekleyin.
* Migration’ı uygulayarak veritabanını ve tabloları oluşturun.

---

## ✅ Adım 5

Veritabanı üzerinde CRUD işlemlerini test etmek için bir program yazın ve çalıştırın.

### ✅ Talimatlar

* **Program.cs** dosyasını, employee verilerini department adlarıyla birlikte alacak ve gösterecek şekilde değiştirin.
* **HR** departmanına ait employee’leri göstermek için bir sorgu ekleyin.
* Yeni bir employee kaydı oluşturup kaydedecek bir işlevsellik ekleyin.
* Veritabanı işlemlerinin doğru çalıştığını doğrulamak için uygulamayı çalıştırın.

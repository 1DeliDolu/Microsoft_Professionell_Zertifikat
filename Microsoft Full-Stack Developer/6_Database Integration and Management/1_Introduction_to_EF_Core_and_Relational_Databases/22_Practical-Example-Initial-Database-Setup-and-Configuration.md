## 🧪 Pratik Örnek: İlk Veritabanı Kurulumu ve Yapılandırma

Ham veriyi iyi yapılandırılmış ve işlevsel bir veritabanına dönüştürmek için neler gerekir? Bir ilişkisel veritabanı kurma sürecini anlamak, organize ve anlamlı bilgi sistemleri oluşturmanın ilk adımıdır.

Bu videoda, bir ilişkisel veritabanının ilk kurulumunu ve yapılandırmasını göstereceğiz.

---

## 🧭 Kurulum Süreci: 3 Ana Faz

Bir veritabanı yönetim sistemini ( **DBMS** ) seçtikten sonra, kurulum süreci üç ana faza ayrılabilir:

1. **Faz 1:** DBMS’i yüklemek
2. **Faz 2:** Sistemi yapılandırmak
3. **Faz 3:** Asıl veritabanını oluşturmak

İlk faz olan DBMS kurulumuyla başlayalım.

---

## 💾 Faz 1: DBMS Kurulumu

Öncelikle DBMS yazılımını sağlayıcının web sitesinden indirin.

Ardından işletim sisteminize uygun sürümü seçin; Windows, macOS veya Linux.

İndirdikten sonra DBMS’i kurmak için yükleme dosyasını çalıştırın. Bu, dosyayı açıp süreci başlatmak için istemleri ( *prompts* ) takip etmeyi içerir.

Kurulum sırasında, kurulum dizinlerini ve bileşenleri seçme adımlarında yönlendirileceksiniz. Varsayılan seçenekler genellikle önceden seçilidir ve kurulumda yeniyseniz bunları kullanmak güvenlidir.

Kurulum tamamlandıktan sonra, DBMS servisinin çalıştığını doğrulayın. Çoğu sistem, bunu yönetmek için bir araç içerir; böylece ileri yapılandırma için gereken servisleri başlatabilir veya durdurabilirsiniz.

---

## ⚙️ Faz 2: DBMS Yapılandırması

DBMS’i kurduktan sonra, kullanım için yapılandırmanız gerekir.

Sistemi yapılandırırken üç temel alana odaklanmalısınız; ilk olarak kullanıcı hesapları.

---

## 👤 Kullanıcı Hesapları

Kullanıcı hesaplarını ayarlamak temel bir güvenlik önlemidir.

İlk kullanıcı hesabı genellikle **admin** veya **root** kullanıcısıdır. Bu kullanıcı veritabanı sistemi üzerinde tam kontrole sahiptir; bu yüzden bu hesap için güçlü bir parola oluşturmak istersiniz.

Ayrıca erişime ihtiyaç duyabilecek diğer personel için de kullanıcı hesapları oluşturmak isteyebilirsiniz; örneğin belirli departmanların yöneticileri gibi.

---

## 🔐 Güvenlik Ayarları: Roller, İzinler ve Ağ Güvenliği

Kullanıcıları ayarlarken, ardından iki önemli güvenlik ayarını yapılandırırsınız:

* **Roller ve izinler**
* **Ağ düzeyinde güvenlik**

### 🧾 Roller ve İzinler

Roller ve izinler, kimin veritabanına erişebileceğini ve hangi eylemleri gerçekleştirebileceğini tanımlar.

Örneğin, bir proje yöneticisinin proje ayrıntılarına erişmesi gerekir; ancak hassas finansal veya çalışan verilerine erişmemesi gerekir.

Uygun roller ve izinler atamak, kullanıcıların görevlerini verimli şekilde yapmasına izin verirken güvenliği korumaya yardımcı olur.

### 🌐 Ağ Güvenliği

Roller ve izinlere ek olarak ağ güvenliğini de yapılandırmanız gerekir.

Ağ güvenliği, veritabanına erişimi şirketin iç ağıyla veya belirli sunucu kümeleriyle sınırlar; böylece yalnızca organizasyon içindeki yetkili kullanıcıların bağlanmasını sağlar.

---

## 🗃️ Depolama Seçenekleri

DBMS’in güvenlik ayarlarını yapılandırdıktan sonra depolama seçenekleri üzerinde çalışırsınız; veritabanınızın veriyi nasıl ve nerede saklayacağını belirlersiniz.

Çoğu sistem, veritabanı dosyalarının kaydedileceği dizinleri veya sürücüleri seçmenize izin verir.

Ayrıca veritabanınıza ne kadar depolama alanı ayrılacağını da yapılandırırsınız; bu, zamanla büyümesini bekliyorsanız önemlidir.

---

## 🏗️ Faz 3: İlk Veritabanını Oluşturma

DBMS’iniz kuruldu ve yapılandırıldıktan sonra son adım ilk veritabanınızı oluşturmaktır.

Yeni bir veritabanı oluştururken, açık ve tutarlı adlandırma kurallarını takip etmek önemlidir.

Veritabanınızın adı, amacını açıklamalı ve boşluk veya özel karakter içermemelidir.

Bir şirket veritabanı için, daha sonra kolayca referans verebilmek adına **CompanyDB** gibi bir isim kullanırsınız.

---

## 🧩 Şema ( *Schema* ) ve Yapının Planlanması

Veritabanını adlandırdıktan sonra, şemasını düşünmeniz gerekir.

Şemanın, veritabanınızın nasıl yapılandırıldığının bir planı ( *blueprint* ) olduğunu hatırlayın.

Şema; tabloların, ilişkilerin ve veritabanının diğer öğelerinin nasıl organize edildiğini tanımlar.

Bir şirket veritabanı için; çalışanlar, departmanlar ve projeler için tablolar içeren bir şema oluşturursunuz.

Şema, bu veri parçalarının birbirleriyle nasıl ilişkili olduğunu, yani nasıl eşlendiğini ( *map* ) yansıtır.

Örneğin, bir departmanda birden fazla çalışan olabilir ve birden fazla departman birden fazla projeyle ilişkili olabilir.

Tablolar arasındaki dallanmalar bu ilişkileri gösterebilir.

Her departmanın birçok projesi vardır ve her proje birden fazla departmana sahip olabilir.

Bu ilişkileri açıkça tanımlamak, verinin düzenli ve erişilebilir kalması için önemlidir.

---

## 📋 Tablo Yapılarını Oluşturma

Son olarak, tablo yapılarını kurmaya başlarsınız.

İlişkisel veritabanlarının tablolardan oluştuğunu ve her tablonun satır ve sütunlardan oluştuğunu hatırlayın.

Şirket veritabanımızı kurarken, her kategori için bir tablo tanımlarız:  **employees** , **departments** ve  **projects** .

**Employees** tablomuz şu sütunları içerir:

* **EmployeeID**
* **FirstName**
* **DepartmentID**

**Departments** tablosu şunları içerir:

* **DepartmentID**
* **DepartmentName**
* **CostCenter**

**Projects** tablosu ise şu sütunlara sahiptir:

* **ProjectID**
* **ProjectName**
* **DepartmentID**

---

## ✅ Oluşturulan Sistem Özeti

Artık **CompanyDB** adlı bir veritabanını başarıyla oluşturdunuz ve üç temel tablo içeren bir şema tasarladınız:  **Employees** , **Departments** ve  **Projects** ; ayrıca aralarındaki ilişkileri de eşlediniz.

Çalışanlar departmanlara bağlıdır, departmanlar projeleri yönetir ve çalışanlar birden fazla projede çalışabilir.

Son olarak, her tabloyu **Employees** tablosunda *EmployeeID* ve **Projects** tablosunda *ProjectID* gibi ilgili sütunlarla yapılandırdınız; böylece veritabanınız veriyi verimli şekilde almak ve yönetmek için organize edilmiş olur.

Veritabanını adlandırmaktan tablolar arasındaki ilişkileri tanımlamaya kadar, veriyi verimli şekilde saklayabilen, organize edebilen ve geri alabilen tam bir sistem kurdunuz.

Bu videoda, bir ilişkisel veritabanının nasıl kurulacağını ve yapılandırılacağını öğrendiniz.

Artık projenizi ileri taşıyabilecek yapılandırılmış veriyi şekillendirmek için gereken araçlara sahipsiniz.

İster ekip yönetimi ister kaynak yönetimi için olsun, iyi yapılandırılmış bir veritabanı oluşturma beceriniz, etkili veri yönetiminin temelidir.

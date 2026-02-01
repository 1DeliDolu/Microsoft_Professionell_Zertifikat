## 👥 ASP.NET Identity’de Kullanıcı Rollerine Giriş

Her uygulamada kullanıcılara, neye erişebileceklerini belirleyen belirli izinler atanır.  **ASP.NET Identity** ’de bu kontrollü erişim, kullanıcı rolleri üzerinden yönetilir.

Bu videoda,  **ASP.NET Identity** ’de rol tabanlı erişim kontrolü sistemini açıklayacak ve rollerin kullanıcılara nasıl atandığını anlatacağız.

---

## 🛡️ Rol Tabanlı Erişim Kontrolü

Rol tabanlı erişim kontrolü ( **RBAC** ), bir organizasyon içindeki rollerine göre yetkili kullanıcılara sistem erişimini kısıtlayan bir kontrol mekanizmasıdır.

 **RBAC** , sistem içinde kullanıcılara farklı roller atar. Bu rol, uygulamanın hangi bölümlerine erişebileceklerini belirler.

Örneğin, bir okul bilgisayar sistemini düşünün. Kullanıcıların notları güncellemesine izin verilirken, öğrenciler yalnızca kendi kişisel kayıtlarına erişebilir.

---

## 🎛️ Bir Rolün Uygulama İçinde Kontrol Edebilecekleri

Şimdi, bir rolün uygulama içinde neleri kontrol edebileceğine bakalım.

 **ASP.NET Identity** ’de `RoleManager` sınıfı, rollerin oluşturulmasını ve kullanıcılara atanmasını yönetir.

`RoleManager`,  *admin* , *user* veya *editor* gibi roller oluşturmayı ve bunları farklı kullanıcılara atamayı kolaylaştırır.

Örneğin bir **CMS** içinde sistem, her kullanıcının neye erişebileceğini belirlemek için rolleri kullanır.

* **admin** , sistem üzerinde tam kontrole sahiptir; kullanıcı hesaplarını oluşturma, silme ve güncelleme izinlerine sahiptir.
* **editor** , makaleler yazabilir ve yayımlayabilir.
* **user** , yayımlanmış makalelere yalnızca salt okunur erişimle sınırlı olur.

Bu rol tabanlı yapı, her kullanıcının atanmış sorumluluklarına göre uygun erişim seviyesine sahip olmasını sağlar.

`RoleManager` kullanarak bu rolleri oluşturup yönetebilir ve kimin hangi izinleri alacağını belirleyebilirsiniz.

---

## 🗄️ Veritabanında Depolama

Roller oluşturulduktan sonra, **IdentityDB Context** kullanılarak **ASP.NET Roles** tablosuna kaydedilir.

**ASP.NET Roles** tablosu, rol bilgilerini takip etmek için özel olarak tasarlanmıştır ve  **IdentityDB Context** , rol atamalarının ve ilgili verilerin veritabanında doğru şekilde işlenmesini ve kaydedilmesini sağlar.

---

## 🛒 RBAC’in Çalışmasına Bir Örnek

RBAC’in nasıl çalıştığını gösteren bir uygulama örneğine bakalım.

Bir e-ticaret sitesini düşünün.

* `RoleManager`, ürünleri yönetmek, fiyatları güncellemek ve tüm müşteri siparişlerini yönetmek için **admin** erişimi sağlar. Ayrıca kullanıcı hesapları oluşturma ve roller tanımlama gibi temel yönetim görevlerini de içerir; bu da verimli sistem yönetimini sağlar.
* Bir  **editor** , ürün açıklamalarını yazabilir ancak fiyatları güncelleyemez.
* Bir  **user** , yalnızca ürünlere göz atabilir ve satın alma yapabilir.

Bir **admin** giriş yaptığında, sistem **IdentityDB Context** kullanarak veritabanında atanmış rolünü kontrol eder. Rol **admin** olarak belirlenirse, ürünleri, fiyatları ve müşteri siparişlerini yönetebileceği  **admin dashboard** ’a erişim verilir.

Ek olarak, admin’ler kullanıcı hesapları oluşturma ve rol atama gibi temel görevleri yerine getirerek sorunsuz sistem yönetimini sağlar.

Kullanıcılar giriş yaptığında, sistem atanmış rolleri doğrulamak için  **IdentityDB Context** ’i kullanır. Doğrulamadan sonra yalnızca ürünlere göz atma ve satın alma yapma gibi alışveriş özelliklerine erişim elde ederler.

Bu rol tabanlı sistem, uygulamayı güvenli tutar ve herkesin yalnızca ihtiyaç duyduğu şeye erişmesini sağlar.

---

## ✅ Özet

Bu videoda,  **ASP.NET Identity** ’de rol tabanlı erişim kontrolü sistemini ve kullanıcı rollerinin nasıl atandığını öğrendiniz.

 **ASP.NET Identity** ’de erişim kontrollerini anlamak, güvenli uygulamalar oluşturmak için kritik öneme sahiptir.

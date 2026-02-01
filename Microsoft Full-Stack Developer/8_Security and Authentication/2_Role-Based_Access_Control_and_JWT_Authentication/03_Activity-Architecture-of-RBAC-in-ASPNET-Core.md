## 🏗️ Etkinlik: ASP.NET Core’da RBAC Mimarisi

## 🧩 Rol Tabanlı Erişim Denetimi (RBAC) Sistemleri Tasarlama

### 🎯 Amaç

Gerçek dünya uygulamaları için Rol Tabanlı Erişim Denetimi ( *RBAC* ) mimarisini; rolleri tanımlayarak, izinleri atayarak ve güvenli erişim denetimini sağlayarak geliştirmek ve ifade etmek. Sistem gereksinimlerini analiz etme ve belirli senaryolara uyarlanmış RBAC tasarımları oluşturma pratiği kazanmak.

---

## 🏥 Örnek 1: Sağlık Yönetim Sistemi

### 📌 Senaryo

Bir sağlık sistemi, aşağıdaki roller için erişimi güvenli şekilde yönetmelidir:

* **Sistem Yöneticisi (System Admin):** Sistemi, kullanıcıları ve ayarları yönetir.
* **Doktor (Doctor):** Atanmış hastalar için hasta bakımını yönetir (ör. ilaç yazma, kayıtları görüntüleme).
* **Hemşire (Nurse):** Doktorlara, hasta vital değerlerini güncelleyerek yardımcı olur ancak reçetelere veya test sonuçlarına erişemez.
* **Hasta (Patient):** Yalnızca kendi tıbbi kayıtlarını ve test sonuçlarını görüntüler.

### ✅ Göreviniz

Bu sağlık platformu için bir RBAC sistemi tasarlayın. Özellikle:

* Rolleri tanımlayın ve sorumluluklarını açıklayın.
* Her role izinleri atayın ve her iznin neden gerekli olduğunu açıklayın.
* Rollerin ve izinlerin bağlantısını göstermek için tasarımı bir tabloda özetleyin.

---

## 🧭 Adım Adım Açıklamalı Yol Haritası

### 1) 👥 Rolleri ve Sorumluluklarını Belirleyin

**Sistem Yöneticisi (System Admin):**
Bu rol, genel sistemi yönetmek için gereklidir. Admin’ler kullanıcı eklemekten, roller atamaktan ve sistemi yapılandırmaktan sorumlu olduğundan tüm kaynaklara sınırsız erişime ihtiyaç duyarlar.

**Doktor (Doctor):**
Doktorların doğrudan hasta bakımı sağlaması gerekir. Bunu etkili şekilde yapabilmek için atanmış hastaların kayıtlarına erişebilmeleri ve bu kayıtları güncelleyebilmeleri, test sonuçlarını görüntüleyebilmeleri ve ilaç yazabilmeleri gerekir.

**Neden Yalnızca Atanmış Hastalarla Sınırlı?**
Yalnızca atanmış hastalara erişim, özel bilgilerin gereksiz yere açığa çıkma riskini azaltır.

**Hemşire (Nurse):**
Hemşireler, vital değerleri kaydederek ve güncelleyerek doktorlara yardımcı olur. Test sonuçları veya reçeteler gibi hassas bilgilere ihtiyaç duymazlar; bunlar doktorlar tarafından yönetilir. Erişimi sınırlamak, olası hataları veya yetkisiz işlemleri azaltır.

**Hasta (Patient):**
Hastalar, sağlık durumları hakkında bilgi sahibi olmak için kendi kayıtlarına erişmelidir. Yalnızca kendi verileriyle sınırlandırmak gizlilik ve güvenliği sağlar.

---

### 2) 🔐 Her Role İzin Atayın

**Sistem Yöneticisi (System Admin):**
Tüm sistem kaynaklarına tam erişim; kullanıcı yönetimi ve hasta kayıtları dahil.

**Neden?**
Admin’lerin sistemin işlevselliğini ve güvenliğini kapsamlı biçimde sürdürmesi gerekir.

**Doktor (Doctor):**

* Atanmış hasta kayıtlarını görüntüleme ve güncelleme
* Atanmış hastalar için test sonuçlarını görüntüleme
* Atanmış hastalar için ilaç yazma

**Neden?**
Doktorlar, hasta bakımını etkili şekilde sunmak için bu izinlere ihtiyaç duyar; aynı zamanda yalnızca sorumlu oldukları hastalarla etkileşime girmeleri sağlanır.

**Hemşire (Nurse):**

* Hastalar için vital değerleri görüntüleme ve güncelleme

**Neden?**
Hemşirelerin sorumlulukları, doktorlara temel tıbbi verilerle destek olmakla sınırlıdır.

**Hasta (Patient):**

* Kendi tıbbi kayıtlarını görüntüleme

**Neden?**
Hastaların yalnızca kendi verilerini görmesi gerekir; bu, gizliliği sağlar ve başkalarının bilgilerine erişimi engeller.

---

### 3) 📋 RBAC Tasarımını Bir Tabloda Özetleyin

| Rol                               | İzinler                                                                                                    |
| --------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| Sistem Yöneticisi (System Admin) | Tüm sistem kaynaklarına tam erişim, kullanıcı yönetimi, hasta kayıtları.                            |
| Doktor (Doctor)                   | Atanmış hasta kayıtlarını görüntüleme/güncelleme, test sonuçlarını görüntüleme, ilaç yazma. |
| Hemşire (Nurse)                  | Hastalar için vital değerleri görüntüleme/güncelleme.                                                 |
| Hasta (Patient)                   | Kendi tıbbi kayıtlarını görüntüleme.                                                                 |

---

## 🧠 Tasarım Sürecinin Açıklaması

### 👥 Roller Nasıl Tanımlandı?

Roller, tipik bir sağlık iş akışındaki farklı sorumluluklara karşılık gelir. Admin’ler sistemi denetler, doktorlar bakım sunar, hemşireler destek sağlar ve hastalar kişisel verilerine erişir.

### 🔐 İzinler Neden Bu Şekilde Atandı?

Her izin, rolün işini etkili şekilde yapması için ihtiyaç duyduğu yetkiye bağlıdır ve gereksiz veya hassas verilere erişimi en aza indirir. Bu, en az ayrıcalık ( *principle of least privilege* ) ilkesini takip ederek güvenlik risklerini azaltır.

### 🛡️ Bu Sistem Veriyi Nasıl Korur?

Her rolün izinlerini temel sorumluluklarıyla sınırlayarak sistem, hassas hasta verilerinin yalnızca ihtiyaç duyan kişilerce erişilebilir olmasını sağlar; böylece ihlal riski azaltılır.

---

## 🔁 Sıra Sizde

Bu örneğe dayanarak bir Öğrenme Yönetim Sistemi ( *LMS* ) için bir RBAC sistemi tasarlamayı deneyin:

* LMS’deki rolleri belirleyin (ör. Admin, Instructor, Student).
* Her rol için gerekli izinleri tanımlayın (ör. dersleri yönetme, ödevleri notlandırma).
* Tasarımınızı bir tabloda özetleyin.

---

## 🛒 Örnek 2: E-Ticaret Platformu

### 📌 Senaryo

Bir e-ticaret platformu, aşağıdaki roller için erişimi güvenli şekilde yönetmelidir:

* **Süper Admin (Super Admin):** Kullanıcıları, envanteri ve siparişleri yönetir.
* **Depo Personeli (Warehouse Staff):** Envanter ve sevkiyatla ilgilenir ancak müşteri verilerine erişemez.
* **Müşteri Hizmetleri Temsilcisi (Customer Service Agent):** Müşteri siparişlerini ve iletişimini yönetir.
* **Müşteri (Customer):** Ürünlere göz atar, sipariş verir ve sipariş geçmişini görüntüler.

### ✅ Göreviniz

Bu e-ticaret platformu için bir RBAC sistemi tasarlayın. Özellikle:

* Rolleri tanımlayın ve sorumluluklarını açıklayın.
* Her role izinleri atayın ve her iznin neden gerekli olduğunu açıklayın.
* Rollerin ve izinlerin bağlantısını göstermek için tasarımı bir tabloda özetleyin.

---

## 🧭 Adım Adım Açıklamalı Yol Haritası

### 1) 👥 Rolleri ve Sorumluluklarını Belirleyin

**Süper Admin (Super Admin):**
Bu rol, kullanıcılar, envanter ve siparişler dahil tüm platformu denetler. Operasyonları yönetmek için sınırsız erişime ihtiyaç duyarlar.

**Depo Personeli (Warehouse Staff):**
Depo personeli envanter güncellemelerini ve sevkiyat lojistiğini yönetir. Hassas müşteri verilerine erişmeleri gerekmez; bu da özel bilgilerin açığa çıkma riskini azaltır.

**Müşteri Hizmetleri Temsilcisi (Customer Service Agent):**
Müşteri hizmetleri temsilcileri müşterilerle etkileşime girer, siparişleri yönetir ve sorunları çözer. Envanteri değiştirmeleri veya arka uç verilerine erişmeleri gerekmez.

**Müşteri (Customer):**
Müşteriler ürünlere göz atar, sipariş verir ve kendi sipariş geçmişlerini görüntüler. Erişimi sınırlamak, diğer kullanıcıların verilerinin görüntülenmesini veya değiştirilmesini engeller.

---

### 2) 🔐 Her Role İzin Atayın

**Süper Admin (Super Admin):**
Kullanıcı, envanter ve sipariş yönetimi için tam izinler.

**Neden?**
Süper Admin’ler platformun tüm yönlerini denetler ve operasyonları sürdürmek için sınırsız erişime ihtiyaç duyar.

**Depo Personeli (Warehouse Staff):**
Envanteri güncelleme ve sevkiyatı yönetme.

**Neden?**
Sorumlulukları stok ve lojistikle ilgili arka uç operasyonlarıyla sınırlıdır; müşteri verilerine erişmemeleri sağlanır.

**Müşteri Hizmetleri Temsilcisi (Customer Service Agent):**
Siparişleri görüntüleme/yönetme, müşteri iletişimlerine erişim.

**Neden?**
Müşteri sorunlarını etkili şekilde çözmek için sipariş ve iletişim erişimi gerekir; izinleri sınırlamak envanteri ve müşteri verilerini korur.

**Müşteri (Customer):**
Ürünlere göz atma, sipariş verme, kişisel sipariş geçmişini görüntüleme.

**Neden?**
Müşteriler yalnızca kendi verileriyle etkileşime girer; bu, gizliliği korur ve riskleri azaltır.

---

### 3) 📋 RBAC Tasarımını Bir Tabloda Özetleyin

| Rol                                                      | İzinler                                                                            |
| -------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| Süper Admin (Super Admin)                               | Kullanıcılar, envanter ve siparişler üzerinde tam erişim.                      |
| Depo Personeli (Warehouse Staff)                         | Envanteri güncelleme, sevkiyatı yönetme.                                         |
| Müşteri Hizmetleri Temsilcisi (Customer Service Agent) | Siparişleri görüntüleme/yönetme, müşteri iletişimlerine erişim.            |
| Müşteri (Customer)                                     | Ürünlere göz atma, sipariş verme, kişisel sipariş geçmişini görüntüleme. |

---

## 🧠 Tasarım Sürecinin Açıklaması

### 👥 Roller Nasıl Tanımlandı?

Roller, bir e-ticaret platformundaki temel operasyonları yansıtır: admin’ler sistemi yönetir, depo personeli stoğu yönetir, müşteri hizmetleri temsilcileri müşteri sorunlarını çözer ve müşteriler platformla etkileşime girer.

### 🔐 İzinler Neden Bu Şekilde Atandı?

İzinler, her rolün sorumluluklarıyla eşleşir ve gereksiz erişimi en aza indirir. Bu, hassas verileri korur ve operasyonların sorunsuz yürütülmesini sağlar.

### 🛡️ Bu Sistem Veriyi Nasıl Korur?

Rol ve izinleri belirli görevlere sınırlamak, müşteri verilerini güvence altına alır, ihlal riskini azaltır ve yetkisiz işlemleri önler.

---

## ✅ Görev 1: Öğrenme Yönetim Sistemi (LMS) için RBAC Tasarlayın

### 📌 Senaryo

Bir LMS, aşağıdaki roller için erişimi güvenli şekilde yönetmelidir:

* **Admin:** Kullanıcıları, dersleri ve ayarları yönetir.
* **Eğitmen (Instructor):** Kendi derslerini yönetir, ödevleri notlandırır ve kayıtlı öğrencileri görüntüler.
* **Öğrenci (Student):** Kayıtlı olduğu dersleri, ödevleri ve notları görüntüler.
* **Misafir (Guest):** Genel ders bilgilerini görüntüler ancak kayıt olamaz veya özel verilere erişemez.

### ✅ Göreviniz

* Bu LMS’deki rolleri tanımlayın ve sorumluluklarını açıklayın.
* Her rolün yapması gereken işlere göre gerekli izinleri atayın.
* Roller ile izinler arasındaki ilişkiyi gösteren bir tabloda RBAC tasarımınızı özetleyin.

---

## ✅ Görev 2: Perakende Banka için RBAC Tasarlayın

### 📌 Senaryo

Bir perakende banka, aşağıdaki roller için erişimi güvenli şekilde yönetmelidir:

* **Admin:** Hesapları, işlemleri ve müşteri verilerini yönetir.
* **Veznedar (Teller):** İşlemleri gerçekleştirir ancak tam hesap geçmişlerine erişemez.
* **Denetçi (Auditor):** Sistem günlüklerini ve işlemleri inceler, hassas müşteri ayrıntılarına erişmeden.
* **Müşteri (Customer):** Kendi hesap ayrıntılarını ve işlem geçmişini görüntüler.

### ✅ Göreviniz

* Bu perakende bankadaki rolleri tanımlayın ve sorumluluklarını açıklayın.
* Her rolün görevlerine göre gerekli izinleri atayın.
* Roller ile izinler arasındaki ilişkiyi gösteren bir tabloda RBAC tasarımınızı özetleyin.

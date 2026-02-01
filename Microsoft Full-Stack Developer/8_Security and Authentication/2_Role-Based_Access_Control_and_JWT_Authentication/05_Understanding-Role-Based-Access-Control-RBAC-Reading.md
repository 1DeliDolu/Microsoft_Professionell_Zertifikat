## 🛡️ Rol Tabanlı Erişim Denetimini (RBAC) Anlamak

## 📌 Giriş

Rol Tabanlı Erişim Denetimi ( *RBAC* ), önceden tanımlanmış erişim seviyelerine sahip rolleri atayarak kullanıcı izinlerini yönetmek için kullanılan bir güvenlik modelidir. Bu yaklaşım, erişim yönetimini basitleştirir ve kullanıcıların yalnızca rollerine uygun kaynaklara erişebilmesini sağlar.

## 🧠 Temel Noktalar

### 🧩 Tanım ve İşleyiş

RBAC, kullanıcı rollerine (ör.  *Admin* ,  *Manager* ,  *Customer* ) göre sistemlere, verilere veya kaynaklara erişimi kısıtlar. Roller, benzer sorumlulukları ve izinleri gruplar; böylece her kullanıcıya tek tek izin atama ihtiyacını ortadan kaldırır.

### 🔐 JSON Web Token (JWT) Kullanımı

RBAC, kullanıcı rollerini ve izinlerini güvenli biçimde iletmek için  *JWT* ’lerden yararlanır. Kimlik doğrulamasından sonra sunucu, gelecekteki kullanıcı isteklerine dahil edilen rol metaverisini içeren bir JWT üretir. Bu yaklaşım hem verimliliği hem de güvenliği artırır.

### ⚖️ Claims-Tabanlı Erişim ile Karşılaştırma

RBAC, izinleri roller içinde gruplarken, claims-tabanlı erişim daha ayrıntılı ve kullanıcıya özel kontrol sağlar. RBAC daha basit ve ölçeklenebilir olsa da claims-tabanlı modellere göre daha az esnektir.

### 🧰 ASP.NET Core’da RoleManager

 *RoleManager* , rol oluşturmayı ve yönetmeyi kolaylaştırır. Kullanıcı giriş yaptığında *RoleManager* rolleri atar ve izinleri yansıtan JWT’ler üretir; bu sayede erişim denetimi ayarlamaları anında uygulanabilir.

## ✅ Sonuç

RBAC, izinleri rollerde gruplayarak ve güvenli, verimli kimlik doğrulama için  *JWT* ’leri kullanarak güvenliği artırır ve erişim yönetimini basitleştirir. Bu model, özellikle birden fazla kullanıcı kategorisi bulunan uygulamalar için oldukça etkilidir.

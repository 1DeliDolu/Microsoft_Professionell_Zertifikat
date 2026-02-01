## 🔐 ASP.NET Core’ta JSON Web Token (JWT) Oluşturma ve Kullanma

## 🧭 Giriş

JSON Web Token’lar ( *JWT* ), kullanıcı bilgilerini kompakt, kendi içinde taşınabilen token’lar olarak güvenli biçimde iletmek için yaygın şekilde kullanılır. Uygulamalarda veri bütünlüğünü ve doğruluğunu ( *authenticity* ) sağlamada kritik öneme sahiptir.

---

## 🧱 JWT Yapısını Anlamak

Bir JWT üç ana bileşenden oluşur:

### 🧾 Header

Token türünü ( *JWT* ) ve imzalama algoritmasını (ör.  *HS256* ) tanımlar.

### 📦 Payload

Kullanıcı ID’si, rol ve isteğe bağlı sona erme zamanı ( *exp* ) gibi  *claim* ’leri veya kullanıcıyla ilgili verileri içerir. Örneğin, bir payload şu bilgileri belirtebilir:
`{ "name": "John Doe", "role": "admin" }`

### 🖊️ Signature

Header ve payload’u bir gizli anahtar ( *secret key* ) ile kodlayarak veri bütünlüğünü sağlar. Herhangi bir kurcalama ( *tampering* ), imzayı geçersiz kılar.

Bu bileşenler tek bir string olarak encode edilir; bu da JWT’leri kompakt ve iletimi kolay hâle getirir.

---

## ✅ Kimlik Doğrulama ve Yetkilendirmede JWT’ler

JWT’ler, kullanıcı kimlik doğrulaması ( *authentication* ) ve erişim denetiminde ( *authorization* ) merkezi bir rol oynar. Başarılı bir girişten sonra sunucu, kullanıcıya özel claim’ler içeren bir JWT üretir. Örneğin, *admin* olan bir kullanıcı, yükseltilmiş ayrıcalıklar veren bir token alabilir.

Korunan kaynaklara erişirken istemciler, isteklerine JWT’yi ekler; böylece sunucu oturum durumunu ( *session state* ) tutmadan kimliği ve izinleri doğrulayabilir.

---

## 🛡️ İmzalama ve Doğrulama ile Güvenlik

JWT’leri korumak için sunucular onları bir gizli anahtar ile imzalar; bu, yetkisiz değişiklikleri engeller. Bir istek JWT içerdiğinde, sunucu imzayı kontrol ederek token’ın doğruluğunu doğrular. Payload veya header üzerinde oynama yapılmışsa doğrulama başarısız olur ve token reddedilir.

Ek güvenlik için token’lar genellikle geçerlilik süresini sınırlamak amacıyla bir sona erme claim’i ( *exp* ) içerir. Süre dolduğunda sunucu otomatik olarak erişimi reddeder; bu da olası riskleri daha da azaltır.

---

## 🌍 Gerçek Dünya Kullanım Alanları

JWT’ler modern uygulamalarda vazgeçilmez hâle gelmiştir:

### 🌐 Web Uygulamaları

Kullanıcıları doğrulamak ve rol tabanlı erişim sağlamak için kullanılır. Örneğin, “editor” rolündeki bir kullanıcı içerik yönetebilir ancak kullanıcı hesaplarını değiştiremez.

### 🔒 API Güvenliği

Uç noktaları ( *endpoints* ) korur; yalnızca geçerli JWT’ye sahip doğrulanmış kullanıcıların servislere erişebilmesini sağlar.

### 🧠 Oturum Yönetimi

Geleneksel oturum saklamanın aksine JWT’ler stateless kimlik doğrulama sağlar ve sunucu tarafı yükünü azaltır.

---

## 🧾 Sonuç

JWT’ler, web uygulamalarında kimlik doğrulama ve yetkilendirmeyi yönetmek için güvenli ve verimli bir yol sunar. Yapılarını anlayarak ve en iyi uygulamaları benimseyerek geliştiriciler, hassas verileri koruyan ve kullanıcı güvenini artıran sağlam sistemler inşa edebilir.

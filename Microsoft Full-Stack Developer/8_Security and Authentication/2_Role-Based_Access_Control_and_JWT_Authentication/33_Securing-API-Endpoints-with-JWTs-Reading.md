## 🔐 JWT’lerle API Uç Noktalarını Güvenceye Alma

## 🧭 Giriş

JSON Web Token’lar (JWT), kimlik doğrulama ( *authentication* ) ve yetkilendirmeyi ( *authorization* ) sağlayarak API endpoint’lerini güvenceye almada kritik öneme sahiptir. Bu yaklaşım, kullanıcı kimliğini doğrular, hassas verileri korur ve rol tabanlı erişim kontrolünü ( *RBAC* ) uygular.

---

## 🛡️ API Uç Noktalarını Güvenceye Almak için Temel Faktörler

### 1) ✅ JWT Doğrulaması

* Token’ın kurcalanmadığından emin olmak için imzasını ( *signature* ) doğrulayın.
* Süresi dolmuş token’larla erişimi engellemek için token’ın sona erme zamanını ( *expiration* ) kontrol edin.
* Her istek için bu doğrulamaları otomatikleştirmek adına JWT middleware kullanın.

---

### 2) 👥 Rol Tabanlı Erişim Kontrolü (RBAC)

* Kullanıcılara roller (örn.  *Admin* ,  *Instructor* ,  *Student* ) atayın ve bunları JWT içine claim olarak gömün.
* Kullanıcı rollerine göre API route’larına erişimi kısıtlayan policy’ler tanımlayın.
* Bu policy’leri middleware pipeline içinde uygulayarak sorunsuz bir enforcement sağlayın.

---

### 3) 🧩 En İyi Uygulamalar

* JWT_KEY gibi hassas anahtarları environment variable’larda saklayın.
* Token imzalama için güçlü kriptografik yöntemler kullanın (örn.  *HMAC-SHA256* ).
* Yetkisiz erişimi önlemek için controller seviyesinde rol tabanlı yetkilendirme uygulayın.

---

## 🔎 Token Doğrulaması ve RBAC’in Önemi

### ✅ Token Doğrulaması

Yalnızca meşru ve süresi dolmamış token’ların API endpoint’lerine erişebilmesini sağlayarak güvenlik açıklarını azaltır.

### 👥 Rol Tabanlı Erişim Kontrolü

Kullanıcıların sadece rollerine uygun kaynaklara ve işlevlere erişmesine izin vererek uygulama güvenliğini artırır. Bu, hassas verilerin yetkisiz kişilere açılmasını minimize eder.

---

## 🏁 Sonuç

JWT doğrulamasını rol tabanlı erişim kontrolüyle birleştirerek API’ler hassas verileri koruyabilir ve kullanıcıların yalnızca yetkili oldukları kaynaklarla etkileşime girmesini sağlayabilir.

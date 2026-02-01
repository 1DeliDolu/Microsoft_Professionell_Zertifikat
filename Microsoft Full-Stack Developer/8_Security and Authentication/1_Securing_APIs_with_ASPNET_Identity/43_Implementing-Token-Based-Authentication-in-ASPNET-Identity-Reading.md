## 🔐 ASP.NET Identity’de Token Tabanlı Kimlik Doğrulama Uygulama

### 📌 Giriş

Bu rehber, API endpoint’lerini güvence altına almak için token’ların etkili şekilde  **oluşturulması** , **doğrulanması** ve **kullanılması** sürecini adım adım açıklar.

---

## 🧩 Token Tabanlı Kimlik Doğrulama Nasıl Uygulanır?

### ✅ 1. Kullanıcı Kimlik Doğrulamasını Kurun

Giriş işlemini yönetmek için kimlik doğrulama sisteminizi (örn. **ASP.NET Identity** veya başka bir framework) yapılandırın.

Giriş bilgilerinin (kullanıcı adı ve parola) güvenli şekilde iletildiğinden ve doğrulandığından emin olun.

---

### ✅ 2. Token Üretin

Başarılı girişten sonra bir **JSON Web Token (JWT)** oluşturun.

Token payload’ına claim olarak temel kullanıcı bilgilerini (örn. kullanıcı ID’si ve roller) ekleyin.

Token’ı özgünlüğünü doğrulamak için güvenli bir anahtar veya algoritma ile imzalayın (örn.  **HMAC SHA256** ).

---

### ✅ 3. Token’ı İstemciye Gönderin

Token’ı login response içinde istemciye döndürün.

Token’ı bir JSON nesnesi olarak gönderebilir veya güvenliği artırmak için **HTTP-only cookie** olarak ayarlayabilirsiniz.

---

### ✅ 4. API İsteklerinde Token’ı Dahil Edin

İstemci uygulamasını, her API isteğinde token’ı `Authorization` header’ında gönderecek şekilde yapılandırın:

```text
Authorization: Bearer <token>
```

---

### ✅ 5. Sunucuda Token’ı Doğrulayın

Token doğrulamasını yönetecek middleware veya filter’lar ekleyin.

Token’ı decode edip doğrulayın:

* İmzayı secret key ile doğrulayın.
* Token’ın süresinin dolup dolmadığını kontrol edin.
* Rol ve izin gibi claim’leri doğrulayın.

---

### ✅ 6. API Endpoint’lerini Koruyun

Hassas API endpoint’lerini kimlik doğrulama gerektirecek şekilde işaretleyin.

Token doğrulamasına ve claim’lerde tanımlanan kullanıcı izinlerine göre erişimi kısıtlayın.

---

### ✅ 7. Token Süresi Dolmasını Yönetin

Token çalınırsa yetkisiz erişimi sınırlamak için token expiration uygulayın.

Kullanıcıların kimlik bilgilerini yeniden girmeden yeni token alabilmesi için **refresh token** mekanizması ekleyin.

---

### ✅ 8. Token’ı Güvenli Şekilde Saklayın

İstemci tarafında token’ları güvenli şekilde saklayın:

* İsteklerle otomatik gönderim için **HTTP-only cookie** kullanın.
* Local/session storage kullanılıyorsa XSS’e karşı ek korumalar uygulayın.

---

## ✅ Sonuç

Bu adımları izleyerek token tabanlı kimlik doğrulamayı güvenli şekilde uygulayabilir ve API endpoint’lerinin yalnızca kimliği doğrulanmış kullanıcılar tarafından erişilebilir olmasını sağlayabilirsiniz. Token üretimi, doğrulama ve saklama için en iyi uygulamaları kullanarak uygulama güvenliğini sürdürebilirsiniz.

## 🧩 ASP.NET Identity’ye Giriş

### 📌 Giriş

 **ASP.NET Identity** , güvenli **ASP.NET** uygulamalarında kullanıcı kimlik doğrulama ( *authentication* ), yetkilendirme ( *authorization* ) ve kullanıcı rollerini yönetmek için tasarlanmış bir üyelik sistemidir. Özellikleri, kimlikle ilgili görevleri verimli biçimde yönetmek için sağlam bir çerçeve sunar.

---

## 🧠 Temel Özellikler ve İşlevler

### 🔐 Kullanıcı Kimlik Doğrulama

Erişim izni vermeden önce kullanıcı kimliğini doğrular.

Gelişmiş güvenlik için  **çok faktörlü kimlik doğrulama (MFA)** , parola kurtarma ve e-posta doğrulamasını destekler.

---

### 🧑‍⚖️ Yetkilendirme ve Rol Yönetimi

Kimliği doğrulanmış kullanıcıların rollerine veya izinlerine göre neler yapabileceğini tanımlamak için yetkilendirme ( **"AuthZ"** ) kullanır.

Roller, izinleri daha kolay yönetim için gruplar (ör. **"Admin"** vs.  **"User"** ).

---

### 🧩 Entegrasyon ve Modülerlik

**ASP.NET Core** ile entegre olur ve OAuth 2.0 desteği sayesinde Google veya Facebook gibi harici oturum açma sağlayıcıları için dış giriş ( *external login* ) desteği sunar.

---

### 🗄️ Entity Framework ile Veri Depolama

Parolalar ve roller dâhil kullanıcı verilerini ilişkisel veritabanlarında güvenli şekilde depolamak için  **Entity Framework** ’ü kullanır.

Karmaşık SQL sorguları yerine **C#** kodu kullanarak veritabanı etkileşimlerini basitleştirir.

---

### 🏗️ Ölçeklenebilir Mimari

 **UserManager** , **SignInManager** ve **RoleManager** gibi bileşenler; hesap işlemlerini, kimlik doğrulamayı ve rol atamayı kolaylaştırır.

 **IdentityDbContext** , kullanıcı, rol ve *claim* verilerinin veritabanında güvenli şekilde saklanmasını sağlar.

---

## ✅ Sonuç

 **ASP.NET Identity** , veri güvenliğini sağlarken kimlik doğrulama ve yetkilendirme yönetimi için geliştiricilere entegre bir çözüm sunar. Modüler ve ölçeklenebilir yaklaşımı, sorunsuz uygulama geliştirmeyi ve kullanıcı yönetimini destekler.

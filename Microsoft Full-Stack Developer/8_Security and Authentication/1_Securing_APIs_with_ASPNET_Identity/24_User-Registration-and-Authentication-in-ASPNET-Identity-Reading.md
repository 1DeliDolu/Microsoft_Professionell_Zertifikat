## 🔐 ASP.NET Identity’de Kullanıcı Kaydı ve Kimlik Doğrulama

### 📌 Giriş

 **ASP.NET Identity** , web uygulamalarında kullanıcı güvenliğini yönetmek için sağlam bir çerçevedir. Parola hash’leme ve oturum yönetimi gibi en iyi uygulamalardan yararlanarak güvenli kullanıcı kaydı ve kimlik doğrulama süreçlerini kolaylaştırır.

---

## 🧾 Kullanıcı Kayıt Süreci

Kullanıcı kaydı, bir kullanıcının e-posta ve parola gibi temel bilgileri bir forma girmesiyle başlar. Gönderimden sonra sistem bu ayrıntıları güvenli şekilde işler.

Bu süreçteki kritik bir adım  **parola hash’lemedir** ; düz metin parola, algoritmalar kullanılarak okunamaz bir formata dönüştürülür. Bu, veritabanı ele geçirilse bile parolanın tersine mühendislikle çözülememesini sağlar.

Kullanıcı kimliğini doğrulamak için bir **e-posta doğrulama** adımı eklenmelidir. Kullanıcıların kayıtlı e-posta adreslerine gönderilen doğrulama bağlantısına tıklamaları gerekir; bu, sahte veya yetkisiz hesap riskini azaltır.

Doğrulama tamamlandıktan sonra, hash’lenmiş parola ve e-posta durumu dâhil kullanıcı bilgileri, **Entity Framework** kullanılarak **IdentityDbContext** içinde güvenli şekilde saklanır.

---

## 🔑 Kullanıcı Kimlik Doğrulama Süreci

Kimlik doğrulama, kullanıcının bir giriş formu üzerinden kimlik bilgilerini göndermesiyle başlar. Bu bilgiler sunucuda işlenir; parola hash’lenir ve doğrulama için saklanan hash ile karşılaştırılır.

Kimlik bilgileri doğruysa sistem, kullanıcının ziyaret boyunca kimliği doğrulanmış durumunu geçici olarak koruyan bir **oturum (session)** oluşturur.

Kullanıcılar ek kolaylık için **“Remember Me”** özelliğini seçebilir. Bu özellik, giriş durumunu kalıcı hâle getirmek için  **cookie** ’leri kullanır ve kullanıcıların birden fazla oturum boyunca giriş yapmış kalmasını sağlar.

Oturumlar geçicidir ve hareketsizlikten sonra süresi dolar; buna karşılık cookie’ler, daha uzun süreli ve kesintisiz bir giriş deneyimi sağlar.

---

## ✅ Sonuç

 **ASP.NET Identity** ’de kayıt ve kimlik doğrulama süreçleri, güvenli ve kullanıcı dostu bir deneyim sağlar. Geliştiriciler; parola hash’leme, e-posta doğrulaması ve oturum yönetimi gibi önlemleri uygulayarak güvenilir ve güvenli sistemler oluşturabilir.

## 🔐 Kullanıcı Kimlik Doğrulama Süreci

Bir web sitesine giriş yapmak için her parola girdiğinizde, bilgilerinizi korumak amacıyla arka planda bir dizi adım çalışır. Bu adımların nasıl işlediğini anlayarak geliştiriciler, kullanıcıların kimlik bilgilerini güvende tutan güvenli sistemler oluşturabilir.

Bu videoda,  **ASP.NET Identity** ’de kullanıcı kimlik doğrulamasında yer alan adımları; kimlik bilgisi gönderimi, parola doğrulama ve oturum yönetimi dâhil olmak üzere açıklayacağız.

---

## 📨 Kimlik Bilgisi Gönderimi

İlk adımı, kullanıcıların giriş yaparken kimlik bilgilerini nasıl gönderdiğini inceleyerek başlayalım.

Kimlik bilgisi gönderimi, kullanıcıların bir giriş formuna kullanıcı adı ve parolasını girdiği aşamadır. Gönderildiğinde sunucu bu ayrıntıları doğrulama için alır.

Örneğin, giriş yapmak için e-posta ve parolanızı her girdiğinizde kimlik bilgilerinizi göndermiş olursunuz.

---

## 🧾 Parola Doğrulama

Kimlik bilgileriniz gönderildikten sonra sunucu bir sonraki adıma geçer:  **parola doğrulama** .

Bir kullanıcı parola gönderdiğinde, sunucu parolayı hash’ler ve veritabanında saklanan hash ile karşılaştırarak doğrular.

Parolaların hash olarak saklanması, düz metin parolaların açığa çıkmasını önleyerek güvenliği artırır. Bu süreç parolalarınızı korur; böylece biri veritabanına erişim sağlasa bile orijinal parolanızı göremez veya kullanamaz.

---

## 🕒 Oturum Oluşturma

Parola doğrulandıktan sonra bir sonraki adım  **oturum oluşturmadır** .

Oturum ( *session* ), kullanıcının bir web sitesindeki ziyareti boyunca oturum açmış durumunu güvenli şekilde sürdüren geçici bir durumdur.

Örneğin bir oturum, web sitesinin farklı bölümlerini gezerken giriş yapmış kalmanızı sağlar. Oturum olmadan site, her bölümden sonra sizi “unutur” ve gezinmeyi zorlaştırır.

Oturumlar belirli bir süre boyunca geçerlidir ve etkinlik olmazsa süresi dolabilir; bu durumda yeniden giriş yapmanız gerekir. Bu, erişiminizi korumak için güvenlik eklerken aynı zamanda gezinme deneyiminizi iyileştirir.

---

## 🍪 Cookie ve “Remember Me” Seçeneği

Bazen kullanıcılar tarayıcılarını kapattıktan sonra bile oturumlarının açık kalmasını ister. İşte bu noktada, genellikle **Remember Me** seçeneği aracılığıyla  **cookie** ’ler devreye girer.

Cookie, oturumlar arasında yapılandırmaları hatırlamak için bir web sitesinin tarayıcınıza kaydettiği küçük bir veri parçasıdır.

Etkinleştirildiğinde cookie’ler, giriş bilgilerini cihazınızda saklayarak birden fazla ziyarette oturumunuzun açık kalmasını sağlar.

Oturumlardan farklı olarak cookie’ler cihazınızda kalıcıdır; bu nedenle siteye her döndüğünüzde yeniden giriş yapmanız gerekmez.

---

## ✅ Özet

Bu videoda,  **ASP.NET Identity** ’de kullanıcı kimlik doğrulama adımlarını; kimlik bilgisi gönderimi, parola doğrulama ve oturum yönetimi dâhil olmak üzere öğrendiniz.

Bu adımları anlayarak daha güvenli ve daha güvenilir web uygulamaları geliştirebilirsiniz.

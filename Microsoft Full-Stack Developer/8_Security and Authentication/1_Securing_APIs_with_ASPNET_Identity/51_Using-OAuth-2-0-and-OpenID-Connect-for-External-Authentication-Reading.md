## 🌐 OAuth 2.0 ve OpenID Connect ile Harici Kimlik Doğrulama

## 🧭 Giriş

Bu genel bakış, harici kimlik doğrulama sağlayıcılarının **ASP.NET Identity** ile entegrasyonunu vurgular ve bunların oturum açmayı basitleştirme ve uygulama güvenliğini artırmadaki rolünü öne çıkarır.

---

## 🧠 Temel Kavramlar

**Tanım:** (Google, Facebook ve Microsoft gibi), **OAuth 2.0** ve **OpenID Connect** gibi protokolleri kullanarak kullanıcı kimlik doğrulamasını güvenli şekilde yöneten üçüncü taraf servislerdir.

**OAuth 2.0:** Bu protokol, uygulamanın parola saklamasına gerek kalmadan güvenli token’lar üzerinden sınırlı erişim yetkilendirmesi yapar.

**OpenID Connect:** **OAuth 2.0** üzerine inşa edilmiştir ve bir kimlik doğrulama katmanı ekleyerek kullanıcı claim’lerinin güvenli biçimde doğrulanmasını sağlar.

---

## ✅ Faydalar

**Basitleştirilmiş Girişler:** Kullanıcılar mevcut hesaplarıyla giriş yapabilir; yeni kimlik bilgileri oluşturma ihtiyacı ortadan kalkar.

**Geliştirilmiş Güvenlik:** Güvenli token kullanımı ve iki faktörlü kimlik doğrulama desteği genel güvenliği artırır.

**Artan Güven:** Güvenilir sağlayıcıların kullanılması, kullanıcıların uygulamaya duyduğu güveni yükseltir.

---

## 🔁 Protokollerin Uygulamadaki Rolü

 **OAuth 2.0** , uygulamanın hassas kimlik bilgilerini doğrudan işlemeden kullanıcı erişimini doğrulamasına olanak tanıyarak *yetkilendirmeyi* yönetir.

 **OpenID Connect** , kimlikleri doğrulayarak kullanıcıların iddia ettikleri kişi olduklarını güvenli bir mekanizma ile teyit eder.

---

## 🏁 Sonuç

Harici kimlik doğrulama sağlayıcılarının **ASP.NET Identity** ile entegrasyonu, kullanıcı deneyimini kolaylaştırır, güvenliği güçlendirir ve yaygın olarak tanınan güvenli üçüncü taraf platformlara dayanarak güveni artırır.

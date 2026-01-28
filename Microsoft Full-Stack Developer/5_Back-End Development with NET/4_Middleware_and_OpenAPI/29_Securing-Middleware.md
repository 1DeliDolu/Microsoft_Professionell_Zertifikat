## 🛡️ Securing Middleware

Her uygulama her gün sayısız istek ( *request* ) alır; ancak bunların arasında güvenlik açıklarını istismar etmeye çalışan kötü niyetli denemeler gizli olabilir. Güçlü güvenlik önlemleri olmadan, tek bir ihlal bile tüm sisteminizi tehlikeye atabilir. Güvenlik yalnızca saldırıları engellemek değildir; uygulamanızı, kullanıcılarınızı ve verilerinizi zarar vermek isteyenlere karşı korumaktır.

Bu videoda, ASP.NET Core’da middleware’i güvenli hâle getirmek için en iyi uygulamaları ( *best practices* ) belirleyeceğiz.

Middleware, uygulamanızdaki istek akışını kontrol eder. Güvenli değilse saldırganlar açıkları kullanarak veri çalabilir veya sisteminize zarar verebilir. Middleware’i güvenli hâle getirmek, yalnızca güvenilir isteklerin geçmesini sağlar ve uygulamanızı risklerden korur.

Middleware güvenliğinin neden kritik olduğunu anladığımıza göre, şimdi middleware’inizi güvenli ve sağlam tutmak için pratik en iyi uygulamalara bakalım.

---

## ✅ Input Validation ve Sanitization

İlk olarak input’ları doğrulayın ( *validate* ) ve temizleyin ( *sanitize* ).

Saldırganlar genellikle request içine zararlı veri enjekte etmeye çalışır; örneğin kötü amaçlı script’ler veya komutlar.

* **Validation** , verinin doğru formatta olup olmadığını doğrular.
* **Sanitization** , tehlikeli olabilecek içerikleri temizler.

Örneğin, kullanıcı girdisi işliyorsanız, onu temizlemek zararlı script’lerin uygulamanıza zarar vermesini engeller.

---

## 🔒 HTTPS’i Zorunlu Kılın

Güvenli iletişim için HTTPS’i zorunlu hâle getirmek önemlidir.

HTTPS, uygulamanız ile kullanıcı arasında iletilen veriyi şifreler ( *encrypt* ), böylece saldırganların hassas bilgileri ele geçirmesi zorlaşır.

Kullanıcılar giriş yaptığında, HTTPS; parolalarının ve kişisel bilgilerinin korunmasını sağlar.

---

## 🍪 Cookie ve Session Verisini Güvence Altına Alın

HTTPS’i zorunlu kıldıktan sonra, cookie’ler ve session verisi de güvene alınmalıdır.

Cookie’leri **HttpOnly** gibi attribute’larla ayarlayarak tarayıcıda çalışan script’lerin cookie’lere erişmesini engellersiniz.

Bu, kötü amaçlı script’lerin session cookie’lerini çalıp kullanıcıyı taklit etmeye çalıştığı **cross-site scripting (XSS)** saldırı riskini azaltır.

---

## 🧭 Authentication ve Authorization’ı Pipeline’ın Başında Yapın

Middleware pipeline’ının erken aşamalarında authentication ve authorization kontrollerini yapmak önemlidir.

Bu sayede yetkisiz kullanıcılar, uygulamanızın kısıtlı alanlarına ulaşmadan durdurulur.

Örneğin biri gerekli kimlik bilgileri olmadan bir dashboard’a erişmeye çalışırsa, istek daha en başta engellenir; bu hem uygulamanızı güvenli tutar hem de verimliliği artırır.

---

## 📝 Security Event Logging Yapın (Ama Hassas Veriyi Loglamayın)

Authentication’ı erken ele aldıktan sonra, security event’lerini loglamak şüpheli aktiviteleri takip etmek için gereklidir.

Ancak parolalar gibi hassas detayları loglamamak çok önemlidir.

Örneğin, bir kullanıcı birden fazla kez başarısız giriş denemesi yaparsa, denemelerin zamanını ve IP adresini takip edebilirsiniz; fakat parolayı kaydetmezsiniz.

Bu, tehditleri tespit etmenize yardımcı olurken özel veriyi korur.

---

## 🚫 Hata Yönetiminde Fazla Bilgi Açığa Çıkarmayın

Hatalar, kullanıcılara çok fazla teknik detay gösterecek şekilde ele alınmamalıdır.

Teknik hata ayrıntıları saldırganlara uygulamanız hakkında ipucu verebilir.

Bunun yerine, bu detayları ekibiniz için saklayın ve kullanıcıya “ **Something went wrong** ” gibi basit, genel bir mesaj gösterin.

Bu, sisteminizi güvenli tutarken ekibinizin problemi arka planda inceleyebilmesini sağlar.

---

## ✅ Kapanış

Bu videoda ASP.NET Core’da middleware’i güvenli hâle getirmek için temel uygulamaları öğrendiniz.

* input validation
* HTTPS’i zorunlu kılma
* cookie ve session verisini güvence altına alma
* authentication’ı erken ele alma
* security event’lerini dikkatli loglama
* hassas bilgi sızdırmadan hata yönetimi

Bu en iyi uygulamaları takip etmek, uygulamanızı ve kullanıcılarınızı potansiyel tehditlere karşı korumaya yardımcı olur.

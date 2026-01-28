## 🛡️ Securing Middleware

---

## 📌 Introduction

Bu rehber, ASP.NET Core uygulamalarında middleware’i güvenli hâle getirmek için gerekli temel adımları açıklar. Bu uygulamaları takip etmek, uygulamanızı ve kullanıcılarınızı yaygın güvenlik tehditlerine karşı daha iyi korur.

---

## 🔐 How to Secure Middleware in ASP.NET Core

---

## ✅ Validate and Sanitize Inputs

Verinin doğru formatta olduğundan emin olmak için input validation uygulayın ve zararlı içerikleri temizlemek için sanitization yapın. Bu, *injection* ve kötü amaçlı script’leri engellemeye yardımcı olur.

---

## 🔒 Enforce HTTPS for Secure Communication

Middleware yapılandırmanızda HTTPS’i zorunlu kılmak için **`app.UseHttpsRedirection()`** ekleyin. Bu, kullanıcılarla sunucunuz arasında taşınan verinin şifrelenmesini sağlar.

---

## 🍪 Secure Cookies and Session Data

Cookie’leri **HttpOnly** ve **Secure** attribute’larıyla ayarlayın (**`Cookie.HttpOnly = true`** ve  **`Cookie.SecurePolicy = CookieSecurePolicy.Always`** ) ki tarayıcı script’leri cookie’lere erişemesin. Bu, **cross-site scripting (XSS)** açıklarını azaltır.

---

## 🧭 Perform Authentication and Authorization Early

Yetkisiz erişimi en başta engellemek için **`app.UseAuthentication()`** ve **`app.UseAuthorization()`** bileşenlerini middleware pipeline’ının başına yerleştirin.

---

## 📝 Log Security Events Carefully

Giriş denemeleri ve erişim reddi gibi güvenlik olaylarını, hassas detayları kaydetmeden loglayın. Logging araçları genellikle zaman damgası ( *timestamp* ), IP adresi ve genel olay açıklamaları gibi temel bilgileri kaydeder.

---

## 🚫 Handle Errors Securely

Hata yönetimini kullanıcıya genel bir mesaj gösterecek şekilde yapılandırın; detaylı bilgileri ise geliştiriciler için loglayın. Teknik bilgileri açığa çıkarmadan hata yanıtlarını yönetmek için **ExceptionHandlerMiddleware** kullanın.

---

## ✅ Conclusion

Bu uygulamalar ASP.NET Core’da middleware güvenliğini güçlendirir ve uygulamanızı yaygın tehditlere karşı korur. Yeni açıklar ve zafiyetler ortaya çıkabileceği için bu yapılandırmaları düzenli olarak gözden geçirip güncelleyin.

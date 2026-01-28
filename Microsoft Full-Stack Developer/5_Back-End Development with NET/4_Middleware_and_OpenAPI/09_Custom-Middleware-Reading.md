## 🧩 Custom Middleware

---

## 📌 Introduction

Bu rehber, ASP.NET Core’da **custom middleware** oluşturmayı ve uygulamayı kapsar;  *request logging* , *response timing* ve *API key validation* gibi örneklere odaklanır.

---

## 🧩 Key Points

---

## 🧠 Middleware Fundamentals

 *Middleware* , ASP.NET Core’un  *pipeline* ’ı üzerinden istekleri ( *requests* ) ve yanıtları ( *responses* ) işleme sürecinin merkezindedir.

**`app.Use()`** fonksiyonu, istekleri sıralı olarak işleyen bir *request delegate* tanımlayarak custom middleware oluşturmayı sağlar.

---

## 🧰 Examples of Custom Middleware

---

## 🧾 Logging Middleware

Her isteğin öncesinde ve sonrasında **`Console.WriteLine`** kullanarak request path’lerini ve response status code’larını loglar.

---

## ⏱️ Timing Middleware

Bir sonraki delegate çalışmadan önce başlangıç zamanını kaydederek ve tamamlandıktan sonra süreyi hesaplayarak request süresini ölçer.

---

## 🧩 Conditional Middleware with `UseWhen()`

 *Middleware* , **`UseWhen()`** kullanılarak GET olmayan istekler gibi belirli kriterlere bağlı şekilde koşullu çalıştırılabilir.

*API keys* ile erişim kontrolü örneklenir; geçerli bir API key ile gelen istekler kabul edilirken, geçersiz key için **`401 Unauthorized`** yanıtı döndürülür.

---

## ✅ Conclusion

Bu middleware uygulamaları,  *logging* , *timing* ve erişim kontrolü ( *access control* ) için temel bir yaklaşım sağlar ve ASP.NET Core’un yeteneklerinin nasıl genişletilebileceğini gösterir.

## 🛡️ Hata Yönetimi ve Loglama

### 📝 Introduction

 *ASP.NET Core* ’da hata yönetimi ve loglama, sağlam ve güvenilir uygulamalar geliştirmek için gereklidir. Bu ders, beklenmeyen hataları yönetmeye ve uygulama stabilitesi, güvenlik ve yüksek performans için kapsamlı loglar tutmaya yönelik en iyi uygulamaları kapsar. Bu stratejiler uygulandığında, geliştiriciler user experience’ı iyileştirebilir ve web uygulamalarında troubleshooting’i kolaylaştırabilir.

---

## 🧯 ASP.NET Core’da Temel Error Handling Teknikleri

### 🧩 Try-Catch Blocks

 *Try-catch blocks* , uygulamayı crash ettirmeden belirli exception’ları yönetmek için kullanılır. Try-catch blocks, bilinen hataları zarif şekilde handle eder; geliştiricilerin custom response tanımlamasına izin verir. Örneğin, sıfıra bölme durumunda uygulamanın crash olmasına izin vermek yerine kullanıcıya bir hata mesajı gösterilebilir.

---

### 🌍 Global Exception Handling

 *ASP.NET Core* ’da middleware, uygulama genelindeki handle edilmemiş exception’ları yakalayarak merkezi error management sağlar. Bu yaklaşım, tutarlı loglama ve kullanıcı mesajlamasına izin verir (ör. “An unexpected error occurred”). Bu, özellikle third-party servislerden gelen sorunları veya beklenmeyen failure’ları yönetmek için önemlidir.

---

## 🪵 Etkili İzleme İçin Logging Best Practice’leri

### 🎯 Logging’in Amacı

Logging, uygulama event’lerinin ve davranışlarının kaydıdır; issue teşhisi, performance izleme ve güvenliğin sürdürülmesi için gereklidir. Kapsamlı log’lar, geliştiricilerin sorunları kullanıcıları etkilemeden önce öngörmesine ve ele almasına yardımcı olur.

---

### 🎚️ Log Level’larını Configure Etmek

Uygun log level’ları (ör. `error`, `warning`, `information`) ayarlamak, loglanan veri miktarını kontrol etmeye yardımcı olur ve kritik detayları filtrelemek için faydalıdır. Production ortamları yalnızca error log’larını tutabilirken, development ortamlarında detaylı debug bilgileri de dahil edilebilir.

---

### 🧱 Tutarlı Log Formatı

Timestamp, log level ve ilgili identifier’ları içeren net ve tutarlı log format’ları, log okunabilirliğini artırır ve kritik bilgiyi hızlıca bulmayı kolaylaştırır.

---

### 🧭 Log Scope Kullanımı

Log scope’ları, user request’leri veya transaction’lar gibi birden fazla adımdan oluşan süreçlerde ilişkili log entry’lerini organize etmeye yardımcı olur. Log’ları belirli aksiyonlara veya workflow’lara göre gruplamak, karmaşık senaryolarda pattern’leri belirlemeyi ve issue teşhisini kolaylaştırır.

---

## ⚙️ ASP.NET Core’da Logging Konfigürasyonu

 *ASP.NET Core* , logging’i `appsettings.json` üzerinden veya `Program.cs` içinde programmatically configure etmeye olanak tanır. Bu kurulum; log output destination’larını belirleyebilir, log level’larını ayarlayabilir ve gelişmiş yetenekler için third-party logging framework’lerini etkinleştirebilir. Doğru konfigürasyon, log’ların real-time monitoring ve historical analysis için erişilebilir lokasyonlarda saklanmasını sağlar.

---

## ✅ Conclusion

 *ASP.NET Core* ’da error handling ve logging, stabil ve resilient uygulamalar oluşturmak için hayati öneme sahiptir. Try-catch blocks, global exception handling ve logging best practice’leri kullanılarak geliştiriciler uygulama güvenilirliğini sürdürebilir, sistem sağlığını izleyebilir ve sorunları proaktif şekilde çözebilir. Bu stratejiler, tutarlı bir user experience sağlarken debugging ve maintenance süreçlerini de geliştiriciler için daha verimli hâle getirir.

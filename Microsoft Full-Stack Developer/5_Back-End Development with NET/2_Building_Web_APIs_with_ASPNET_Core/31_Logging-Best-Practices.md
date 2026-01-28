## 🪵 Logging En İyi Uygulamaları

Bir uygulamada işler ters gittiğinde, ilk başta bunun fark edilmesi her zaman kolay değildir. Sessiz hatalar, siz fark etmeden performansı bozabilir. İşte bu noktada logging devreye girer. Bu videoda,  *ASP.NET Core* ’da logging best practice’lerini açıklayacağız.

---

## 🧾 Logging Nedir?

 *Logging* , bir uygulamanın veya sistemin davranışı hakkında mesajların ya da verilerin kaydedilmesi sürecidir. Logging, uygulamanın sağlığını izlemenize ve sorunlar büyümeden önce yakalamanıza yardımcı olur. Sistem, kullanıcı etkileşimlerini ve çeşitli süreçlerin çıktısını takip ederek birçok kullanım senaryosu için değerli içgörüler sağlar.

Örneğin, logging; hataları veya eksik verileri gerçek zamanlı yakalayarak geliştiricilerin yanlış sonuçlar gibi sorunları teşhis etmesine yardımcı olur.

Logging ayrıca performans izleme için de faydalıdır; log’lar sistem metriklerini zaman içinde takip ederek verimsizlikleri belirleyebilir.

Logging, security auditing için de gereklidir. Aktivite ve sistem değişikliklerini kaydetmek için kullanılabilir; şüpheli davranışları veya yetkisiz erişimi tespit etmeye yardımcı olur.

Error tracking’de, log’lar crash veya failure hakkında ayrıntılı bilgi yakalar; bu da root cause’u bulmayı kolaylaştırır.

Son olarak, log’lar user behavior pattern’lerini takip edebilir; işletmelerin tercihleri ve aksiyonları anlayarak user experience’ı geliştirmesine yardımcı olur.

Logging’in etkili şekilde kullanılabileceği senaryoları belirlemek kritiktir.

---

## ✅ Logging Best Practice’leri

Logging yaparken best practice’leri kullanmak da önemlidir. Şimdi yaygın bazı logging best practice’lerini inceleyelim.

---

## 🎚️ Detay Seviyesi

Önce detay seviyesini düşünün.

Çok fazla bilgi loglamak, doğru detayları bulmayı zorlaştırabilir.

Log level filter’ları ayarlayarak neyin loglanacağına karar verebilirsiniz.

Production ortamında sadece *error* ve *warning* mesajlarını loglamak isteyebilirsiniz.

Development ortamında ise daha fazla içgörü için *information* ve *debug* log’larını da dahil edebilirsiniz.

---

## 🧱 Tutarlı Log Formatı

Log level’ları ayarladıktan sonra, log’ların tutarlı şekilde formatlandığından emin olmalısınız.

Tutarlı formatlama, log’ları okumayı ve analiz etmeyi kolaylaştırır.

Bir sorun çıktığında ihtiyacınız olan bilgiyi hızlıca bulmanızı sağlar.

İyi formatlanmış bir log; timestamp, log level ve kritik detayları içerebilir.

Örneğin, bu metin log’u 25 Eylül 2024’te saat 10’da user ID `1234` için oluşan bir hatayı kaydeder.

Ödemenin `payment timeout exception` nedeniyle başarısız olduğunu belirtir.

---

## 🧭 Log Scopes

Son olarak, log scope’larını düşünmelisiniz.

 *Log scope* ’ları, ilişkili log’ları organize edip gruplamanın bir yoludur ve ekstra bilgi eklemenize izin verir.

Bu, özellikle user request’leri veya aynı anda birden fazla operasyon gibi karmaşık süreçlerde ilgili olayları takip etmenizi sağlar.

Böylece daha büyük resmi görmeyi ve sorunları daha hızlı debug etmeyi kolaylaştırır.

Örneğin, bir siparişi işlerken, order ID, order’ın user ID’si ve yapılan aksiyonlar ile karşılaşılan hataları takip etmek için bir scope kullanabilirsiniz.

---

## ⚙️ ASP.NET Core Projesinde Logging Konfigürasyonu

Bu best practice’leri akılda tutarak, *ASP.NET Core* projenizde logging’i nasıl configure edeceğinizi inceleyelim.

Bu genellikle built-in logging provider’ları veya third-party logging framework’leri kullanılarak yapılır.

Aşağıdaki adımları takip ederek .NET uygulamasında log’ları oluşturup saklamak için logging’i kurabilirsiniz.

---

## 📌 1) Log’ların Nereye Gideceğini Belirleyin

Önce log’ları nereye göndereceğinize karar verin:

* Console
* File
* External service (ör. database veya cloud platform)

---

## 📉 2) Minimum Log Level’larını Ayarlayın

İkinci olarak minimum log level’larını ayarlayın:

* `information`
* `warning`
* `error`

Ne kadar detay loglanacağını belirlemek için bunlar tanımlanmalıdır.

Bu, hem application-specific log’ları hem de external library log’larını kapsar.

---

## 🗂️ 3) Logging’i Configure Etme Yöntemleri

Logging, `appsettings.json` dosyasında configure edilebilir; burada provider’ları ve log level’larını tanımlarsınız.

Bu declarative yaklaşım, code değiştirmeden ayarları kolayca düzenlemenizi sağlar.

Alternatif olarak logging, `Program.cs` içinde programmatically configure edilebilir; burada Logging Builder kullanarak logging provider’larını ve log level’larını doğrudan code içinde belirtirsiniz.

Her iki durumda da:

* Log output location’larını kontrol edebilirsiniz
* Log level’larını kontrol edebilirsiniz
* Environment-specific behavior’ı customize edebilirsiniz

---

## 🔌 4) Third-Party Framework Kullanımı

*Serilog* veya *Nlog* gibi third-party bir framework kullanıyorsanız, gerekli NuGet package’larını yükleyin.

Ardından framework’ü `appsettings.json` içinde veya kendi config dosyalarında configure edin.

Output target’ları, log formatting ve rolling log file’lar gibi ayarları ihtiyaca göre tanımlayın.

---

## 🧾 5) Log Üretme ve Kaydetme

Logging configure edildikten sonra, log üretmeye başlayabilirsiniz.

Log’lar `logInformation`, `logWarning`, `logError` gibi method’lar çağrılarak oluşturulur.

Bu method’lar log entry’lerini otomatik üretir ve belirlediğiniz output’a (console veya file gibi) kaydeder.

Konfigürasyonunuza bağlı olarak log’lar file’lara veya database’lere yazılabilir ya da cloud service’lere gönderilebilir.

---

## 🧪 6) Logging’i Test Etme ve İzleme

Son olarak, logging sistemini uygulamayı çalıştırarak test edin ve log’ların beklenen lokasyonlarda oluştuğunu doğrulayın.

Log’ları düzenli olarak izleyin; kritik bilgilerin yakalandığından emin olun.

Gerektiğinde log level’larını veya log destination’larını ince ayar yapın; aşırı loglamayı veya önemli detayların kaçmasını önleyin.

---

## ✅ Kapanış

Bu videoda, logging’in *ASP.NET Core* uygulamasını izleme ve sürdürmede; error, performance ve security takibinde nasıl yardımcı olduğunu öğrendiniz.

Bu pratiklerle, uygulamanızı etkili şekilde izlemeye ve optimize etmeye hazırsınız.

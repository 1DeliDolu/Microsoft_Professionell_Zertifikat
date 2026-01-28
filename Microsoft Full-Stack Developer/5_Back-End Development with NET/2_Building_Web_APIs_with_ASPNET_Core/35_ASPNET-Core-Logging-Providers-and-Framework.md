## 🧩 ASP.NET Core Logging Provider’ları ve Framework’ler

Logging provider’lar, bir uygulamanın nasıl çalıştığına dair kritik bilgileri yakalamamıza ve organize etmemize yardımcı olur. Farklı logging provider’ları kullanarak log’ları ortama göre uyarlayabiliriz; böylece uygulamanın sağlığını etkili şekilde izleyebilir, teşhis edebilir ve sürdürebiliriz. Bu videoda, *ASP.NET Core* built-in logging provider’larını ve third-party framework’leri açıklayacağız.

---

## 🧰 ASP.NET Core Built-in Logging Provider’ları

 *ASP.NET Core* ; ekstra bir kurulum gerektirmeden kolayca log yakalamanızı sağlayan  *Console* , *Debug* ve *Event Log* gibi çeşitli built-in logging provider’ları sunar. Her provider, çalıştığınız ortama bağlı olarak belirli bir amaca hizmet eder.

---

### 🖥️ Console Provider

 *Console provider* , özellikle development sırasında faydalıdır.

Log mesajlarını doğrudan Console penceresine gönderir ve uygulamanızın davranışı hakkında anında geri bildirim sağlar.

Bu, hızlı debugging için yararlıdır; çünkü hata veya warning’leri, file aramak veya karmaşık log sistemleri kullanmak zorunda kalmadan gerçekleştiği anda fark edebilirsiniz.

---

### 🐞 Debug Provider

*Debug provider* da development environment’ları için idealdir.

Log mesajlarını aktif debugging output’una gönderir; bu sayede uygulamanızı debug ederken log’ları izleyebilirsiniz.

Bu özellikle kod içinde step-by-step ilerlerken faydalıdır; çünkü log output’u ile code execution’ı eşleştirerek issue’ları daha kolay yakalayabilirsiniz.

Ayrıca log’ları severity’e göre (ör.  *error* ,  *warning* ,  *information* ) filtreleyerek en ilgili detaylara odaklanabilirsiniz.

---

### 🪟 Event Log Provider

Production’da logging gereksinimleri değiştiğinde *Event Log provider* en kullanışlı hale gelir; çünkü log’ları doğrudan Windows event log’una yazar.

Bu, log’ların daha structured ve secure bir şekilde yönetilmesini ve izlenmesini kolaylaştırır.

System administrator’lar built-in araçları kullanarak log’ları search, filter ve analyze edebilir; böylece live environment’da sistem stabilitesini koruyabilir, security’yi izleyebilir ve issue’ları troubleshoot edebilirler.

Ancak *Event Log provider* sadece Windows’ta kullanılabilir.

Cross-platform uygulamalar için production ortamında daha robust logging framework’lerine yönelmek gerekir.

---

## 🧱 Third-Party Logging Framework’leri

Built-in logging provider’lar faydalıdır; ancak bazen uygulamanızın daha advanced özelliklere ihtiyacı olur:

* structured data
* persistent logging
* cloud support

İşte burada *Serilog* gibi third-party framework’ler devreye girer.

*Serilog* ve *Nlog* gibi framework’ler; structured logging ve cloud integration gibi daha gelişmiş özellikler sunar.

---

### 🧾 Serilog

 *Serilog* , structured data, scalability ve modern log management platform’larıyla integration kritik olduğunda öne çıkan güçlü bir logging library’sidir.

Debugging’i, performance monitoring’i ve system analysis’i iyileştirmek için detaylı ve context-rich logging’e ihtiyaç duyan uygulamalar için mükemmel bir seçimdir.

Örneğin, user ID’leri ve transaction time’ları gibi bilgileri structured bir formatta loglayabilirsiniz; bu da sonradan search ve analyze etmeyi kolaylaştırır.

---

### ⚡ Nlog

Bir diğer third-party framework  *Nlog* ’dur.

 *Nlog* , geniş bir application yelpazesi için uygun, versatile ve efficient bir logging library’sidir.

Kurulumunun basit olması, yüksek performansı ve esnek target seçenekleri; güvenilir bir logging çözümü isteyen geliştiriciler için onu güçlü bir tercih haline getirir.

Ayrıca centralized log management ve data analysis’ten tam anlamıyla faydalanmanıza izin verir; bu da daha hızlı troubleshooting ve daha etkili application monitoring sağlar.

*Serilog* structured logging’de detaylı, property-based log query gerektiren senaryolarda öne çıkarken, *Nlog* performance ve configuration kolaylığına odaklanır.

Bu da onu, logging speed ve esnekliğin kritik olduğu high-throughput environment’lar için ideal kılar.

Örneğin *Nlog* ile error code’lar ve stack trace’ler gibi error detaylarını structured formatta loglayabilirsiniz.

Bu structured data daha sonra *ElastiSearch* veya *Logstash* gibi platformlarda kolayca search ve analyze edilebilir; böylece recurring issue’ları hızlıca belirleyebilir ve zaman içinde uygulama stabilitesi hakkında içgörü kazanabilirsiniz.

---

## ✅ Kapanış

Logging provider’lar, uygulamalarımızı etkili şekilde izlememizi ve sürdürmemizi sağlayan temel araçlardır.

Development sırasında built-in provider’ları kullanmak ya da production’da advanced framework’lerden faydalanmak fark etmeksizin, sağlam bir logging stratejisine sahip olmak uygulamanın sağlığını ve stabilitesini korumak için kritiktir; böylece uygulamanız sorunsuz ve verimli şekilde çalışır.

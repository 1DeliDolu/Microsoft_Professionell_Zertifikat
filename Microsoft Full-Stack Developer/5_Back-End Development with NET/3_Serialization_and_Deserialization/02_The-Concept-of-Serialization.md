## 🧠 Serialization Kavramı

Serialization, yazılım geliştirmede temel bir kavramdır ve nesnelerin kolayca **depolanabilecek** veya **iletilebilecek** bir formata dönüştürülmesini sağlar. Bu videoda serialization’ı ve .NET’teki önemini tanımlayacağız.

---

## 📌 Serialization Nedir?

Serialization, bir nesnenin kolayca depolanabilecek veya iletilebilecek bir formata dönüştürülmesi sürecidir.

---

## 🧩 .NET’te Neden Önemlidir?

.NET’te şu nedenlerle önemlidir:

1. Nesne verilerini kaydetmeyi ve geri almayı kolaylaştırır.
2. Dağıtık bir sistemin farklı bölümleri arasında nesnelerin kolayca paylaşılmasını sağlayarak iletişimi güçlendirir.
3. .NET,  *binary* , *XML* ve *JSON* gibi çeşitli serialization formatlarını destekler.

---

## 🎯 Serialization’ın Amaçları

Serialization birden fazla amaca hizmet eder:

1. **Veri depolama:** Serialization, karmaşık nesneleri dosyalar veya veritabanları gibi ortamlarda kolayca geri alınıp kullanılabilecek formatlara kaydetmenizi sağlar.
2. **İletim ve yeniden oluşturma:** Nesneleri ağlar üzerinden (ör. veri gönderirken web sunucuları arasında) iletmenizi ve yeniden oluşturmanızı sağlar.
3. **Durumun korunması:** Bir nesnenin durumunu farklı oturumlar veya uygulama odaları boyunca korur.
4. **Farklı teknolojiler arasında iletişim:** Farklı teknolojiler kullanan sistemler arasındaki iletişimi de kolaylaştırır.

---

## 🧾 .NET’te Yaygın Serialization Formatları

.NET’te yaygın olarak kullanılan birkaç serialization formatı vardır ve her biri; veri boyutu, okunabilirlik, birlikte çalışabilirlik (interoperability) ve performans gibi faktörlere bağlı olarak farklı senaryolara uygundur. İşte bu yaygın serialization formatlarının her birini ne zaman kullanacağınıza dair bir rehber; *binary serialization* ile başlayalım.

---

## ⚙️ Binary Serialization

Binary serialization, nesneleri kompakt bir ikili (binary) formata dönüştürür; bu da depolama ve iletim açısından verimli olmasını sağlar. İnsan tarafından okunabilir olmasa da, yüksek performans ve minimum veri boyutuna ihtiyaç duyduğunuz durumlar için idealdir; özellikle insan tarafından okunabilirliğin isteğe bağlı olduğu senaryolarda.

---

## 🧬 XML Serialization

XML serialization, nesneleri insan tarafından okunabilir bir XML formatına dönüştürür. Güçlü yapısı ve öznitelikler (attributes) ile karma içerik (mixed content) desteği nedeniyle XML, özellikle kurumsal (enterprise) ortamlarda veri alışverişi için yaygın biçimde kullanılır. XML serialization; legacy sistemler ve karmaşık veri yapıları gibi, biraz ayrıntılı (verbose) olsa bile katı, belge tabanlı bir formatın gerekli olduğu senaryolar için idealdir.

---

## 🌐 JSON Serialization

XML serialization’ı anladıktan sonra, daha sade ve hafif bir formatı düşünmenin zamanı geldi. Şimdi JSON’un farklı platformlarda veriyle nasıl verimli çalıştığını inceleyelim.

JSON serialization, nesneleri modern web uygulamaları için ideal olan hafif ve insan tarafından okunabilir bir formata dönüştürür ve platformlar arasında yaygın şekilde desteklenir. Web API’leri, çapraz platform veri alışverişi ve okunabilirlik ile verimliliğin önemli olduğu senaryolar için kullanın. Çoğu modern ortamda üzerinde çalışması kolaydır.

---

## ✅ Video Özeti

Bu videoda serialization’ı, yazılım geliştirmedeki önemini ve .NET’teki pratik uygulamasını öğrendiniz. Serialization’ın nesneleri  *JSON* , *XML* ve *binary* gibi formatlara dönüştürerek depolamayı, iletmeyi ve farklı sistemler arasında paylaşmayı nasıl kolaylaştırdığını inceledik. Bu da projelerinizde her birini ne zaman ve neden kullanacağınızı anlamanıza yardımcı olur.

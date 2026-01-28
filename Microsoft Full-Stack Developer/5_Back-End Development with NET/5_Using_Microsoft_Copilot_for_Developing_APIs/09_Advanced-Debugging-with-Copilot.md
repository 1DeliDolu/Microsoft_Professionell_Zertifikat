## Advanced Debugging with Copilot (Pratik “Playbook”)

Copilot “doğrudan fix” üretemediğinde hedef değişiyor: **Copilot’u çözüm motoru değil, sistematik debug koçu** gibi kullanıyorsun. Aşağıdaki teknikler tam olarak bu senaryolar için.

---

## 1) Copilot’u “Debug Koçu” Moduna Al

### Amaç

Copilot’tan *çözüm* istemek yerine **tanı koyduracak adımları** istemek.

**Prompt şablonu**

> “Bu bug’ı Copilot’un fixlemesini istemiyorum. Bana adım adım bir debug planı ver:
>
> 1. hangi hipotezleri test edeyim,
> 2. hangi logları ekleyeyim,
> 3. hangi breakpoint’leri koyayım,
> 4. hangi değişkenleri Watch’a ekleyeyim,
> 5. hangi request/response detaylarını karşılaştırayım.”

Bu, “tıkandım” anlarında seni tekrar hareket ettirir.

---

## 2) “Rubber Ducking 2.0”: Kodu Çalışma Sırasıyla Açıklat

Copilot’tan şunu iste:

* “Bu endpoint çağrılınca kod hangi sırayla çalışıyor?”
* “Hangi koşulda 200 döner ama body boş kalır?”
* “Bu kodda `return`/`await next()` akışı nerede kırılıyor?”

**Neden işe yarıyor?**
Kendi varsayımlarını netleştiriyorsun ve Copilot “beklenen davranış” modelini kurarken çelişkileri yakalıyor.

---

## 3) Hipotez-Tabanlı Debug: “3 Olasılık + Test”

Copilot’a bug’ı şöyle çerçevele:

> “Semptom: 200 OK geliyor ama response body boş.
> 3 olası root-cause üret ve her biri için minimum doğrulama testi öner.”

Tipik root-cause seti:

1. Serialization/DTO mismatch (property isimleri, `record`/`class`, `required`, null)
2. Yanlış endpoint’e hit / routing / base path karışıklığı
3. Response yazılmadan pipeline biter (erken `return`, `Response.HasStarted`, stream kapanması, exception swallow)

---

## 4) Log Enjeksiyonu: “Kritik Kavşaklara Log Eklet”

Copilot’a şunu yaptır:

* Request girişinde: method/path/query/header
* Handler öncesi/sonrası: “entered/exited”
* Response çıkışında: status code + content-type + content-length
* Exception yakalanıyorsa: **tek yerde** log (global exception handler)

**Prompt**

> “Bu kodda kritik junction’lara Console.WriteLine logları ekle. Her log benzersiz bir tag içersin (e.g., MW1, MW2, ENDPOINT1) ki akışı terminalde takip edebileyim.”

Bu sayede “hangi middleware/handler çalıştı çalışmadı” netleşir.

---

## 5) Breakpoint Stratejisi: “Nereye Koymalıyım?”

Copilot’u kullanarak breakpoint yerlerini seç:

* Endpoint handler’ın **ilk satırı**
* Her `if/return` bloğunun **hemen önü**
* `await next()` satırı (middleware’de)
* Response yazma satırı (`WriteAsync`, `Results.Ok`, `return Ok(...)`)
* Serialization gerçekleşen yer (controller return / minimal api Results)

**Prompt**

> “Aşağıdaki kod için 5 kritik breakpoint noktası öner. Her biri için hangi değişkenlere bakacağımı söyle.”

---

## 6) “Data Bug” Avı: Gerçek Veriyi Kopyala

Copilot bazen koda değil **data’ya** ihtiyaç duyar:

* Request payload örneği
* Response örneği
* Swagger örneği
* DB kaydı / mock data

**Prompt**

> “Bu request ile bu response’u alıyorum (ekli). Beklenen bu. Data’da veya modelde mismatch var mı?”

Çoğu “boş obje” bug’ı burada çözülür (property casing, null, enum parse, JSON shape farklılığı).

---

## 7) Refactor ile Debug: “Sorunu çözmeden daha okunur yap”

Bazen bug, “anlaşılmazlık”tan gelir.

**Prompt**

> “Bu kodu davranışı değiştirmeden refactor et: daha okunur, daha test edilebilir, side-effect’leri izole. Sonra olası bug noktalarını işaretle.”

Refactor sonrası bug hâlâ varsa:

* Ya gerçekten dış bağımlılık kaynaklıdır
* Ya da mantıksal hata derindir (state, concurrency, timing)

---

## 8) Unit Test / Integration Test ile “Repro’yu Sabitle”

Copilot’a bunu yaptır:

* Semptomu üreten **tek bir failing test**
* Sonra fix’i doğrulayan test

**Prompt**

> “Bu endpoint için minimal bir integration test yaz (WebApplicationFactory). Şu koşulda response boş geliyor; bunu yakalayan bir failing test üret.”

Bu, “bug bazen oluyor” türü hataları deterministik hale getirir.

---

## 9) IDE Araçları: VS Code’da “Watch / Call Stack / Exception Settings”

Copilot’tan VS Code özelinde adım adım yardım al:

* Debug paneli
* Watch expressions
* Call stack
* Exception break (first-chance)
* Conditional breakpoint

**Prompt**

> “VS Code kullanıyorum. Bu bug için Watch’a hangi ifadeleri eklemeliyim? Conditional breakpoint’i hangi koşulla kurmalıyım?”

---

## 10) Copy/Paste Yoksa: Screenshot + “Bu görüntüyü analiz et”

* Hata popup’ı + ilgili kod + stack trace tek karede
* Copilot görselden okuyup teşhis edebilir

---

# Kısa Özet: “Copilot Fixleyemiyorsa Ne Yapacağım?”

1. **Expected behavior** açıklat (rubber ducking)
2. **3 hipotez + test** iste
3. **Logging tags** eklet
4. **Breakpoint + Watch planı** al
5. **Gerçek request/response/data** paylaş
6. **Failing test** yazdır
7. Gerekirse **refactor** ile görünür kıl

---

İstersen bir sonraki adım olarak şunu yapabiliriz:
Sen bana *tek bir* gerçek örnek ver (kod parçası + aldığın response + beklenen response). Ben sana **Copilot’a atacağın en iyi “advanced debugging prompt”u** ve **log/breakpoint planını** doğrudan çıkarayım.

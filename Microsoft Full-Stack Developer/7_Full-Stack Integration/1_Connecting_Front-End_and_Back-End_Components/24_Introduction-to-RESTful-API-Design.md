## 🛒 Introduction to RESTful API Design

Yoğun bir pazaryerini hayal edin: satıcılar ve müşteriler sorunsuz biçimde etkileşir.  **RESTful API** , iyi organize edilmiş bir pazaryeri gibidir; front-end (müşteri) back-end’den (satıcı) ürünleri ya da veriyi kolayca talep edebilir. Bu verimli alışveriş, akıcı bir alışveriş deneyimi sağlar—ya da web uygulamaları bağlamında sorunsuz bir kullanıcı deneyimi.

Bu videoda, RESTful API’lerin yapısını ve front-end ile back-end arasında veri alışverişini nasıl kolaylaştırdığını açıklayacağız.

---

## 🧾 RESTful API Nedir?

Önce RESTful API’lerin ne olduğunu tanımlayalım.

RESTful API’ler, paylaşılan kuralları izleyerek uygulamaların internet üzerinden iletişim kurmasını sağlar.  **REST** , *Representative State Transfer* ifadesinin kısaltmasıdır.

RESTful API’ler, kullanıcıların etkileşim kurduğu front-end ile uygulamanın veriyi sakladığı ve yönettiği back-end arasında verinin nasıl akacağını tanımlar. Bu tanımlı sistem, uygulamaların düzenli ve duyarlı (responsive) kalmasına yardımcı olur.

---

## 🧩 RESTful API’nin Temel Bileşenleri

RESTful API’leri anladığımıza göre, işlevselliğini sağlayan temel bileşenlere bakalım.

---

## 📍 Endpoints

 **Endpoint** ’ler, API’lerin istek aldığı ve yanıt döndürdüğü URL’lerdir.

RESTful API’de endpoint’ler, bir apartmandaki posta kutuları gibidir. Her posta kutusunun (ya da endpoint’in) mesaj veya veri gönderip alabileceğiniz belirli bir adresi (URL) vardır.

Bunu; postayı incelemek, eklemek ya da silmek gibi farklı eylemlerle yaparsınız. Tıpkı her posta kutusunun bir sakine ait belirli bilgileri tutması gibi, her API endpoint’i belirli bir kaynağa (resource) veya veri kümesine erişim sağlar.

Örneğin bir endpoint, back-end’den mevcut ürünlerin listesini istemek için `\products` gibi bir URL olabilir.

---

## 🌐 HTTP Methods

Şimdi, HTTP method’larının API’ye her endpoint’te hangi eylemi yapacağını nasıl söylediğini inceleyelim.

HTTP method’ları, API’ye bir endpoint’te hangi aksiyonun gerçekleştirileceğini söyleyen talimatlardır. Bu method’lar şunları içerir:  **get** ,  **post** , **put** ve  **delete** .

Sırayla işlevlerine bakalım:

### 📥 GET

Sunucudan veri almak (retrieve) için kullanılır ve verinin kendisini değiştirmez. Sadece istenen bilgiyi getirir.

### 📤 POST

Sunucuya veri göndermek için kullanılır; çoğunlukla yeni bir kaynak (resource) oluşturur veya bilgi gönderir ve genellikle sunucuda değişiklikle sonuçlanır.

### ♻️ PUT

Mevcut bir kaynağı güncellemek veya değiştirmek için kullanılır; bazı durumlarda, kaynak yoksa oluşturabilir.

### 🗑️ DELETE

Adından da anlaşılacağı gibi, sunucudan bir kaynağı tamamen kaldırmak için kullanılır.

---

## 🛍️ Örnek: E-Ticaret Uygulamasında HTTP Method’ları

Şimdi bunları bir örnekte birleştirelim.

Bir e-ticaret uygulamasında her HTTP method’u, ürün API’sinin belirli endpoint’lerdeki veriyle nasıl etkileşeceğini tanımlar:

* **GET** : Görüntülemek için ürün listesini getirir.
* **POST** : Sepete ürün ekler.
* **PUT** : Ürünün detaylarını günceller.
* **DELETE** : Sepetten bir ürünü kaldırır.

---

## 🧾 Status Codes

Uygulama bir eylem talep ettikten sonra, API bunun nasıl gittiğini uygulamaya bildirmek için yanıt verir.

API’nin uygulamaya  **status code** ’lar aracılığıyla nasıl yanıt verdiğini inceleyelim.

Status code’lar, istenen eylemin sonucu hakkında API’den geri bildirim sağlar. Hem uygulamanın hem de kullanıcının süreçte ne olduğunu anlamasına yardımcı olmak için sayısal kodlar kullanırlar.

Birkaç yaygın HTTP koduna bakalım:

### ✅ 200

**Başarı** anlamına gelir. İstek doğru şekilde işlendi; her şey beklendiği gibi gitti.

### 🔎 404

**Not found** anlamına gelir. İstenen kaynak mevcut değildir; kullanıcı sunucuda bulunmayan bir şeye erişmeye çalıştığında görülür.

### ⚠️ 500

**Server error** anlamına gelir. İstek işlenmeye çalışılırken sunucu tarafında bir şeyler ters gitmiştir.

Status code’lar, geliştiricilerin sorunları teşhis etmesini ve yanıtları verimli biçimde yönetmesini sağlar. Örneğin, var olmayan bir ürün sayfasına erişmeye çalışırsanız 404 hatası alabilirsiniz. Bu, sorunun kaynağını anlayarak geliştiricinin hatayı hızlıca teşhis etmesine de yardımcı olur.

---

## 📦 Payloads

İncelememiz gereken RESTful API bileşenlerinden sonuncusu  **payload** ’dır.

Payload, bir API çağrısı sırasında uygulamanın gönderdiği veya aldığı gerçek veridir. Uygulama bu veriyi, front-end ve back-end’in her ikisinin de anlayabileceği bir biçimde formatlar; örneğin  **JSON** .

Örneğin, internette bir ürünü incelediğinizde payload; ürünün adı, fiyatı ve açıklaması gibi tüm detayları içerir. Front-end’in ürünü size gösterebilmesi için ihtiyaç duyduğu bilgiler bunlardır.

---

## ✅ Kapanış

Bu videoda, RESTful API’lerin yapısını ve bileşenlerini; ayrıca front-end ile back-end arasında veri alışverişini nasıl kolaylaştırdığını öğrendiniz.

RESTful API’leri anlayarak, her uygulama etkileşimini güçlendiren akıcı ve verimli veri alışverişleri oluşturma potansiyelinin kilidini açarsınız.

İzlediğiniz için teşekkürler. Umarız bu videoyu beğenmişsinizdir. Beğendiyseniz lütfen kanalımıza like atın, yorum yapın ve abone olun.

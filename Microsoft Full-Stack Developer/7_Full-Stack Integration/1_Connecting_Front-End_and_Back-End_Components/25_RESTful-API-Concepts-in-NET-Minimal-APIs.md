## 🌐 RESTful API Concepts in .NET Minimal APIs

API’ler, dijital servislerin gizli temelidir; yazılımların sorunsuz biçimde etkileşime girmesini ve veri alışverişi yapmasını sağlar. Günümüzde mobil uygulamalardan e-ticaret platformlarına kadar her şeyde vazgeçilmezdir.

Bu videoda, **.NET Minimal API Framework** içinde RESTful API’lerin yapısını ve amacını açıklayacağız.

---

## 🧩 RESTful API’lerin Özelliği: Stateless Olmaları

API’lerin farklı türleri vardır. RESTful API’ler, belirli kuralları takip etmeleri ve **stateless** olmaları nedeniyle benzersizdir.

 *Stateless* , bir istemcinin (client) API’ye yaptığı her isteğin bağımsız olması anlamına gelir. Bu tasarım, RESTful API’leri ölçeklenebilir (scalable) ve verimli (efficient) hâle getirir.

---

## 📍 Endpoints

Şimdi RESTful API’lerin temel bileşenlerini, endpoint’lerden başlayarak inceleyelim.

Endpoint’lerin, API’lerin istek aldığı ve yanıt döndürdüğü URL’ler olduğunu hatırlayın. Endpoint’ler belirli görevler için adresler gibidir.

Örneğin:

* `https://mydomain.com/products` satıştaki ürünleri listeleyebilir
* `https://mydomain.com/orders` yeni siparişleri işleyebilir

Bu organizasyon, API’leri açık ve öngörülebilir hâle getirir.

---

## 🌐 HTTP Methods

Endpoint’leri kullanarak veri göndermek veya almak için geliştiriciler **HTTP methods** kullanır.

HTTP methods, bir API endpoint’ine yapılan çağrının hangi eylemi gerçekleştireceğini belirtir. Dört temel HTTP method’u şunlardır:  **GET** ,  **POST** , **PUT** ve  **DELETE** .

Bu standart eylemler, geliştiricilerin API endpoint’leri üzerinden bilgiyle etkileşime girmesini sağlar.

---

## 📥 GET: Bilgi Alma

Bir uygulama, sunucudan bilgi almak için **GET** method’unu kullanır.

Örneğin, bir client uygulaması `mydomain.com/products` endpoint’ine istek yaptığında, sunucu uygulaması bu isteği **GET** eylemine yönlendirir ve veriyi değiştirmeden ürün listesini getirir.

---

## 📤 POST: Yeni Veri Ekleme

Yeni veriyi bir veri deposuna eklemek için **POST** eylemi kullanılır.

Örneğin, `mydomain.com/orders` endpoint’ine bir sipariş gönderildiğinde bu istek **POST** eylemine yönlendirilir ve sipariş bilgisi sunucuya kaydedilir.

---

## ♻️ PUT: Mevcut Veriyi Güncelleme

 **PUT** , mevcut veriyi günceller.

Örneğin, `mydomain.com/orders?order=1` üzerinden bir siparişin miktarını değiştirmek, sunucudaki *order ID’si 1 olan* kaydı günceller.

Soru işaretiyle belirtilen parametre, order ID’yi endpoint’e gönderir; böylece PUT eylemi hangi siparişin güncelleneceğini bilir.

---

## 🗑️ DELETE: Veriyi Silme

**DELETE** method’u veriyi kaldırır.

Bir siparişi iptal ederseniz, uygulama `mydomain.com/remove?order=1` endpoint’ini çağırabilir ve bu, siparişi sistemden siler.

PUT endpoint’inde olduğu gibi, client uygulaması URL’de order ID’yi belirtmek zorundadır; böylece DELETE endpoint’i hangi siparişin silineceğini bilir.

---

## 🧾 Status Codes

Bir API ile etkileşim kurduktan sonra, isteğin düzgün biçimde tamamlanıp tamamlanmadığını doğrulamak faydalıdır; burada  **status code** ’lar devreye girer.

Status code’lar, bir API isteğinin sonucunu belirten sayısal kodlardır.  **200** , **404** ve  **500** , çağıran uygulamaya API çağrısının başarılı olup olmadığını veya süreçte bir yerde hata oluşup oluşmadığını bildirir.

### ✅ 200

Bir isteğin başarılı olduğunu doğrular.

Örneğin ürünleri getirirken, sunucu veriyi ve client uygulamaya **200** kodunu sağlar.

### 🔎 404

İstenen kaynağın eksik olduğunu veya bulunamadığını belirtir.

Bir client, var olmayan bir kaynağı (örneğin var olmayan bir web sayfası veya API) istediğinde sunucu **404** döndürür. Client uygulama bu kodu dinleyip uygun aksiyonu alabilir.

### ⚠️ 500

Sunucunun isteği işlerken bir sorunla karşılaştığını ifade eder.

Bu hatanın nedeni çok geniş bir problem aralığı olabileceği için, client uygulama nedenini tam olarak bilmese bile düzgün (graceful) şekilde yanıt vermelidir.

---

## 📦 Payloads

Şimdi, .NET Minimal API içinde RESTful API’lerin nasıl çalıştığında kritik bir yeri olan payload’lara bakalım.

Payload, client ile server arasında değiş tokuş edilen veridir ve genellikle **JSON** formatında olur.

Başka bir deyişle, bir HTTP isteği bir endpoint’e gönderildiğinde API bunu işler ve bir status code ile birlikte istenen veya güncellenen veriyi yanıt olarak döndürür.

Sipariş gönderirken ürün ID ve miktar gibi detaylar payload içinde yer alır. Örneğin, product ID’si **5** olan bir sipariş quantity **2** içerebilir.

Uygulamalar **JSON** formatını kullanır; bu, veriyi okumayı ve işlemeyi kolaylaştırır.

Sunucu da client’a JSON formatında bir payload geri gönderebilir.

---

## 🧩 Dependency Injection

Son olarak, geliştiricilerin API’leri uygulamanın ihtiyaç duyduğu tüm görevleri gerçekleştirecek şekilde nasıl yapılandırdığını inceleyelim:  **dependency injection** .

 **Dependency injection (DI)** , bir nesnenin bağımlılıklarını kendisinin oluşturması yerine, bu bağımlılıkların nesneye sağlanmasını içeren bir programlama desenidir.

Bu, nesneler arasında gevşek bağlılığı (loose coupling) teşvik eder; kodu daha modüler, test edilebilir (testable) ve sürdürülebilir (maintainable) hâle getirir.

Dependency injection, yeniden kullanılabilir servisleri otomatik biçimde sağlayarak geliştirmeyi kolaylaştırır.

Örneğin DI kullanarak bir geliştirici, API etkinliğini takip etmek için bir logging servisini yeniden kullanabilir; geliştiricilerin aynı servisi tekrar tekrar oluşturmasını gerektirmez.

---

## ✅ Kapanış

Bu videoda, .NET Minimal API framework içinde RESTful API’lerin yapısını ve amacını öğrendiniz.

RESTful API’ler; sistemler arasında verimli bağlantılar oluşturmak için  **endpoints** ,  **HTTP methods** ,  **status codes** , **payloads** ve **dependency injection** bileşenlerine dayanır.

## 🌐 RESTful APIs: Concepts and Implementation

---

## 👋 Introduction

RESTful API’ler oluşturmak, full-stack bir uygulamada front-end ve back-end bileşenlerini bağlamanın temel bir parçasıdır. RESTful API’ler; endpoint’ler, HTTP method’ları ve status code’lar gibi iyi tanımlanmış prensipleri kullanarak sorunsuz veri alışverişi sağlar.

---

## 🧠 Key Concepts

### 📍 Endpoints

API’lerin istek aldığı ve yanıt döndürdüğü URL’lerdir. Örneğin `/products`, ürün listesini çekebilir.

### 🌐 HTTP Methods

Endpoint’lerde gerçekleştirilen eylemlerdir ve şunları içerir:

* **GET** : Veriyi almak için
* **POST** : Yeni veri eklemek için
* **PUT** : Mevcut veriyi güncellemek için
* **DELETE** : Veriyi silmek için

### 🧾 Status Codes

API işlemleri için geri bildirim göstergeleridir:

* **200** (Success)
* **404** (Not Found)
* **500** (Server Error)

### 📦 Payload

API çağrıları sırasında değiş tokuş edilen veridir; genellikle **JSON** formatında olur ve front-end ile back-end sistemleri arasında uyumluluğu sağlar.

---

## 🧩 Practical Implementation

### ⚙️ Setting Up

Bir sunucu başlatın; örneğin Node.js içinde **Express.js** kullanarak.

### 🔌 Defining Endpoints

`/users` ve `/orders` gibi belirli URL’ler oluşturun.

### 🧪 Testing

API yanıtlarını doğrulamak için **Postman** gibi araçlar kullanın.

---

## ✅ Conclusion

RESTful API’ler veri alışverişini organize eder ve yönetir; verimli uygulama geliştirmenin omurgasını oluşturur. Bileşenlerinde ustalaşmak, front-end ve back-end sistemleri arasında sağlam (robust) entegrasyon sağlar.

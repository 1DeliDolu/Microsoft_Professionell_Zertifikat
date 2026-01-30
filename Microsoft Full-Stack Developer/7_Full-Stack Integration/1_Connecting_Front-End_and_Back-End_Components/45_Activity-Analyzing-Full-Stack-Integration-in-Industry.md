
## 🏭 Gerçek Dünya Full-Stack Entegrasyon Senaryolarını Analiz Etme

### 🎯 Objective

Blazor, .NET Minimal API’ler ve SQL Server gibi teknolojiler kullanarak gerçek dünya uygulamalarında front-end ve back-end bileşenlerinin nasıl birlikte çalıştığını anlamanıza ve analiz etmenize yardımcı olmak. Bu etkinlik; pratik kullanım senaryolarını inceleyerek ve benzer bir senaryoyu bağımsız analiz ederek bilgiyi pekiştirir.

---

## 🛒 Case Study: E-Commerce System Integration

Bir e-ticaret platformunun ürün arama, kullanıcı girişi ve sipariş verme gibi özelliklerinin entegrasyonunu analiz etmekle görevlisiniz. Her bileşenin nasıl birlikte çalıştığı aşağıdaki gibidir:

---

## 🔎 1) Product Search Integration

### 🖥️ Front-End

Kullanıcı, Blazor’da oluşturulmuş bir input field üzerinden ürün arar. Arama isteği, `HttpClient` kullanarak bir API call tetikler.

### 🛠️ Back-End

Minimal API isteği işler ve SQL Server veritabanında eşleşen ürünleri bulmak için sorgu çalıştırır. Sonuçlar JSON formatına dönüştürülür ve front-end’e gönderilir.

### 🔁 Data Flow

Search query (front-end) → Minimal API (back-end)
SQL query execution → JSON response → Results rendered on the front-end

---

## 🔐 2) User Login Integration

### 🖥️ Front-End

Blazor formu login credential’larını toplar ve API request ile sunucuya gönderir.

### 🛠️ Back-End

Minimal API, credential’ları SQL Server üzerinden doğrular. Başarılıysa, gelecekteki authentication için client’a bir session token döndürülür.

### 🔁 Data Flow

Credentials input → API → Validation in SQL Server
Token generation → Front-end receives token for secure session management

---

## 🧾 3) Order Placement Integration

### 🖥️ Front-End

Kullanıcı ürünleri sepete ekler ve “Place Order” tıklar. Cart detayları back-end’e gönderilir.

### 🛠️ Back-End

Minimal API, SQL Server veritabanını günceller; bir order kaydı oluşturur ve inventory’yi ayarlar. Ardından bir confirmation front-end’e gönderilir.

### 🔁 Data Flow

Cart data → API → Database update
Confirmation → Front-end displays order summary

---

## 🧠 Explanation

### 🖥️ Front-End Tools (Blazor)

Blazor, C# ile interaktif UI’lar oluşturmak için güçlü bir yol sunar. `HttpClient`, API tüketimi (consume) ve back-end ile entegrasyon için kritiktir.

### 🛠️ Back-End Tools (Minimal APIs)

.NET Minimal API’ler server-side logic’i yönetir ve etkileşim için endpoint’leri tanımlar. Routing’i basitleştirir ve SQL Server ile kolayca entegre olur.

### 🔁 Data Flow

Veri, front-end’den (`HttpClient` üzerinden) back-end’e (API’ler üzerinden) akar ve SQL Server’da işlenir. Sonuçlar JSON formatında render edilmek üzere geri gönderilir.

### 🧪 API Testing and Debugging

Postman veya Swagger gibi araçlar endpoint’leri test etmek ve veri alışverişinin beklendiği gibi çalıştığını doğrulamak için kullanılır.

---

## 📱 Task: Social Media Platform Entegrasyonunu Analiz Etme

### 🧩 Scenario

Bir sosyal medya platformunu analiz ediyorsunuz. Kullanıcılar:

* Hesaplarına giriş yapar.
* Yeni bir status update paylaşır.
* Status update’lerden oluşan bir feed görüntüler.

---

## 🔐 1) Log in to their accounts

### 🖥️ Front-End (Blazor)

* Kullanıcı login formuna credential girer.
* Form submit edildiğinde Blazor `HttpClient` ile back-end’e API çağrısı yapar.
* Başarılı olursa token client tarafında saklanır (gelecek isteklerde kullanılmak üzere).

### 🛠️ Back-End (Minimal API + SQL Server)

* Login endpoint’i (ör. `POST /auth/login`) request’i alır.
* SQL Server’da kullanıcı kaydı bulunur ve credential doğrulaması yapılır.
* Başarılıysa session token üretilir ve JSON response olarak döndürülür.

### 🔁 Data Flow

Credentials input → API (login endpoint) → SQL validation
Token generation → JSON response → Front-end token’ı alır ve session yönetir

### 🧩 Reflection

Front-end input toplar ve iletir; back-end doğrular, token üretir; SQL Server kullanıcı verisini sağlar.

---

## 📝 2) Post a new status update

### 🖥️ Front-End (Blazor)

* Kullanıcı status text girer ve “Post” tıklar.
* Blazor `HttpClient` ile status içeriğini back-end’e gönderir.
* Request ile birlikte token gönderilir (kimlik doğrulama için).

### 🛠️ Back-End (Minimal API + SQL Server)

* Endpoint (ör. `POST /posts`) isteği alır.
* Token doğrulanır; user bilgisi belirlenir.
* SQL Server’a yeni status kaydı eklenir.
* Oluşturulan kaydın detayları JSON response olarak döndürülür.

### 🔁 Data Flow

Status input → API → Token validation → SQL insert
JSON response → Front-end UI günceller (ör. feed’e yeni post ekler)

### 🧩 Reflection

Front-end veriyi gönderir ve UI’yı günceller; back-end auth + kayıt işlemini yönetir; SQL Server kalıcı depolama sağlar.

---

## 📰 3) View a feed of status updates

### 🖥️ Front-End (Blazor)

* Feed sayfası açıldığında `OnInitializedAsync` ile API çağrısı yapılır.
* `HttpClient` ile feed endpoint’inden data çekilir.
* JSON response deserialize edilir ve UI’da render edilir.

### 🛠️ Back-End (Minimal API + SQL Server)

* Endpoint (ör. `GET /feed` veya `GET /posts`) isteği alır.
* Token doğrulanır (gerekliyse).
* SQL Server’dan post’lar sorgulanır (sıralama + filtreleme).
* JSON listesi döndürülür.

### 🔁 Data Flow

Feed request → API → SQL query → JSON response
Deserialize → Results rendered on the front-end

### 🧩 Reflection

Front-end yalnızca görüntüler; back-end doğru veri setini üretir; SQL Server sorgu ve performans tarafını taşır.

---

## ✅ Genel Reflection: Bileşenler Nasıl Birlikte Çalışır?

* **Blazor (Front-End)** : UI, form input, kullanıcı etkileşimi ve `HttpClient` ile API tüketimi.
* **Minimal APIs (Back-End)** : Endpoint tanımı, routing, auth, business logic ve JSON response üretimi.
* **SQL Server (Database)** : Kalıcı veri saklama (users, posts, likes, feed), sorgulama ve bütünlük.
* **API’ler** : Front-end ile back-end arasında standardize iletişim ve veri akışı.

---

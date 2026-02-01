## 🧩 Etkinlik: JWT Yapısı

## 🔎 JSON Web Token’ların (JWT) Yapısını Analiz Etme

### 🎯 Amaç

Bir JSON Web Token’ın ( *JWT* ) yapısını;  **Header** , **Payload** ve **Signature** bileşenlerini analiz ederek ve her bir parçanın güvenli veri iletimine nasıl katkı sağladığını açıklayarak anlamak.

---

## 🧪 Örnek 1: Temel JWT Analizi

### 📌 Senaryo

Analiz edilmesi için bir JWT sağlanmıştır. Bu token, yönetici ayrıcalıklarına sahip bir kullanıcıyı kimlik doğrulamak için kullanılır.

### 🔑 Sağlanan JWT

```text
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.  

eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwicm9sZSI6ImFkbWluIiwiZXhwIjoxNjE2MjM5MDIyfQ.  

SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c
```

### ✅ Göreviniz

JWT’yi analiz ederek şunları belirleyin:

* Header’da belirtilen algoritma ve token türü.
* Payload’da yer alan claim’ler (ör. kullanıcı bilgileri ve sona erme süresi).
* Signature’ın token’ı kurcalamaya ( *tampering* ) karşı nasıl koruduğu.

---

## 🧭 Adım Adım Açıklamalı Yol Haritası

### 🧾 Header’ı Analiz Etme

JWT, *Base64URL* ile kodlanmış bir string’dir. JWT’yi, aralarında nokta (“.”) bulunan 3 bölüme ayırarak çözümlemek için bir fonksiyon kullanabilirsiniz.

#### ✅ Çözümlenmiş Header

```json
{
  "alg": "HS256",
  "typ": "JWT"
}
```

#### 🧠 Açıklama

* **alg:** Token’ı imzalamak için kullanılan algoritmayı belirtir ( *HS256* ,  *HMAC-SHA256* ).
* **typ:** Token’ı bir JSON Web Token ( *JWT* ) olarak tanımlar.

**Neden Önemli?** Header, sunucuya token’ın imzasını nasıl doğrulayacağını söyler.

---

### 📦 Payload’u Analiz Etme

#### ✅ Çözümlenmiş Payload

```json
{
  "sub": "1234567890",
  "name": "John Doe",
  "role": "admin",
  "exp": 1616239022
}
```

#### 🧠 Açıklama

* **sub:** Kullanıcı ID’si ( *1234567890* ).
* **name:** Kullanıcının adı ( *John Doe* ).
* **role:** Kullanıcının rolü ( *admin* ), belirli kaynaklara erişim sağlayabilir.
* **exp:** Sona erme zamanı ( *1616239022* ), token’ın geçerliliğini sınırlar.

**Neden Önemli?** Payload, kullanıcıyı tanımlamak ve izinlerini belirlemek için kullanılan claim’leri içerir.

---

### 🖊️ Signature’ı Analiz Etme

#### 🔐 Kodlanmış Signature

```text
SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c
```

#### 🧠 Açıklama

Signature, header ve payload’un bir gizli anahtar ( *secret key* ) ile kodlanıp birleştirilmesiyle üretilir.

**Neden Önemli?** Signature, token’ın bütünlüğünü sağlar. Payload değiştirilirse (ör. rolü *admin* olarak değiştirmek gibi), signature artık eşleşmez ve sunucu token’ı reddeder.

---

## 📊 Bulguların Özeti

| Bileşen  | Çözümlenmiş İçerik                                                          | Açıklama                                                   |
| --------- | --------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| Header    | `{"alg": "HS256", "typ": "JWT"}`                                                | İmzalama algoritmasını ve token türünü belirtir.       |
| Payload   | `{"sub": "1234567890", "name": "John Doe", "role": "admin", "exp": 1616239022}` | Kullanıcı ID’si, ad, rol ve sona erme zamanını içerir. |
| Signature | `SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c`                                   | Token bütünlüğünü sağlar ve kurcalamayı engeller.    |

---

## ⏳ Örnek 2: Sona Erme Süreli JWT

### 📌 Senaryo

Standart bir kullanıcı için, bir saat sonra sona erecek bir token içeren bir JWT sağlanmıştır.

### 🔑 Sağlanan JWT

```text

```

### ✅ Göreviniz

JWT’yi analiz ederek şunları belirleyin:

* Payload’da belirtilen rol ve sona erme zamanı.
* Sona erme zamanının ( **exp** ) token geçerliliğini nasıl etkilediği.
* Signature’ın token’ın güvenli kalmasını nasıl sağladığı.

---

## 🧭 Adım Adım Açıklamalı Yol Haritası

### 🧾 Header’ı Analiz Etme

#### ✅ Çözümlenmiş Header

```json
{
  "alg": "HS256",
  "typ": "JWT"
}
```

#### 🧠 Açıklama

İlk örnekle aynıdır — imzalama algoritmasını ve token türünü tanımlar.

---

### 📦 Payload’u Analiz Etme

#### ✅ Çözümlenmiş Payload

```json
{
  "sub": "1234567890",
  "name": "User Smith",
  "role": "user",
  "exp": 1650948000
}
```

#### 🧠 Açıklama

* **sub:** Kullanıcı ID’si ( *1234567890* ).
* **name:** Kullanıcının adı ( *User Smith* ).
* **role:** Kullanıcının rolü ( *user* ).
* **exp:** Sona erme zamanı ( *1650948000* ), token verildikten bir saat sonrasına ayarlanmıştır.

**Neden Önemli?** Sona erme, token’ın yalnızca kısa bir süre geçerli olmasını sağlar ve kötüye kullanım riskini azaltır.

---

### 🖊️ Signature’ı Analiz Etme

#### 🔐 Kodlanmış Signature

```text
CvcKLb3uT9yAA12KLrM9JnByEF0AfiyZpa7FukG5HhU
```

#### 🧠 Açıklama

İlk örnekle aynıdır — token’ın kurcalanmadığını garanti eder.

---

## 📊 Bulguların Özeti

| Bileşen  | Çözümlenmiş İçerik                                                           | Açıklama                                                   |
| --------- | ---------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| Header    | `{"alg": "HS256", "typ": "JWT"}`                                                 | İmzalama algoritmasını ve token türünü belirtir.       |
| Payload   | `{"sub": "1234567890", "name": "User Smith", "role": "user", "exp": 1650948000}` | Kullanıcı ID’si, ad, rol ve sona erme zamanını içerir. |
| Signature | `CvcKLb3uT9yAA12KLrM9JnByEF0AfiyZpa7FukG5HhU`                                    | Token bütünlüğünü sağlar ve kurcalamayı engeller.    |

---

## 🧑‍🎓 Öğrenci Görevi

## 🛒 Görev 1: E-Ticaret Sistemi için Bir JWT’yi Analiz Etme

### 📌 Senaryo

Bir e-ticaret platformunda bir kullanıcı için bir JWT sağlanmıştır. Bu token, kullanıcının ID’sini, rolünü ve token’ın geçerliliğini 24 saatle sınırlayan sona erme zamanını içerir.

### 🔑 Sağlanan JWT

```text
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.  

eyJzdWIiOiI1Njc4OTAiLCJyb2xlIjoidXNlciIsImV4cCI6MTY5MjIzMDAwfQ.  

Hx73oTzVZj5lfZlyyRcAJo3hH9M3VBB9-LD9ACBRUjk
```

### ✅ Göreviniz

* Header’ı analiz ederek imzalama algoritmasını belirleyin.
* Payload’u çözümleyerek kullanıcının ID’sini, rolünü ve sona erme zamanını çıkarın.
* Signature’ın token’ı nasıl koruduğunu açıklayın.
* Bulgularınızı, verilen örneklere benzer bir tabloda özetleyin.

---

## 🏥 Görev 2: Sağlık Uygulaması için Bir JWT’yi Analiz Etme

### 📌 Senaryo

Bir sağlık uygulamasında bir doktor için bir JWT sağlanmıştır. Token, doktorun ID’sini, rolünü ve geçerliliğini 12 saatle sınırlayan sona erme zamanını içerir.

### 🔑 Sağlanan JWT

```text
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.  

eyJzdWIiOiIxMjM0NTUwIiwicm9sZSI6ImRvY3RvciIsImV4cCI6MTY4MjQ2NjAwMH0.  

dsg5KlRsdpQZn1uvKjMf2M3Kw8E3ljUlShVlxVc43F4
```

### ✅ Göreviniz

* Header’ı analiz ederek kullanılan algoritmayı belirleyin.
* Payload’u çözümleyerek kullanıcının ID’sini, rolünü ve sona erme zamanını çıkarın.
* Signature’ın token güvenliğini nasıl sağladığını açıklayın.
* Bulgularınızı bir tabloda özetleyin.

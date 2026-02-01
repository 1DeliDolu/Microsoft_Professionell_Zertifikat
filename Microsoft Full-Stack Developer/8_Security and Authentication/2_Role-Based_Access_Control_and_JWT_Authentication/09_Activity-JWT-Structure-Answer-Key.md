## 🧩 Etkinlik: JWT Yapısı – Cevap Anahtarı

## 🛒 Görev 1: E-Ticaret Sistemi için JWT Analizi (Cevap Anahtarı)

### 🔑 Sağlanan JWT

```text
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.  

eyJzdWIiOiI1Njc4OTAiLCJyb2xlIjoidXNlciIsImV4cCI6MTY5MjIzMDAwfQ.  

Hx73oTzVZj5lfZlyyRcAJo3hH9M3VBB9-LD9ACBRUjk
```

### 🧾 Header Analizi

#### ✅ Çözümlenmiş Header

```json
{
  "alg": "HS256",
  "typ": "JWT"
}
```

#### 🧠 Açıklama

* **alg:** Token, *HMAC-SHA256* algoritması ( *HS256* ) ile imzalanmıştır.
* **typ:** Bunun bir JSON Web Token ( *JWT* ) olduğunu belirtir.

---

### 📦 Payload Analizi

#### ✅ Çözümlenmiş Payload

```json
{
  "sub": "567890",
  "role": "user",
  "exp": 1692230000
}
```

#### 🧠 Açıklama

* **sub:** Kullanıcı ID’si ( *567890* ).
* **role:** Kullanıcının normal kullanıcı ( *user* ) olduğunu belirtir.
* **exp:** Sona erme zamanı ( *1692230000* ), token’ın geçerliliğini 24 saatle sınırlar.

---

### 🖊️ Signature Analizi

#### 🔐 Kodlanmış Signature

```text
Hx73oTzVZj5lfZlyyRcAJo3hH9M3VBB9-LD9ACBRUjk
```

#### 🧠 Açıklama

İmza, kodlanmış header ve payload’un bir gizli anahtar ( *secret key* ) ile birleştirilmesiyle oluşturulur.

**Amaç:** Token’ın bütünlüğünü sağlar. Payload değiştirilirse (ör. rolü *admin* yapmak gibi), imza artık eşleşmez ve sunucu token’ı reddeder.

---

### 📊 Bulguların Özeti

| Bileşen  | Çözümlenmiş İçerik                                 | Açıklama                                                   |
| --------- | -------------------------------------------------------- | ------------------------------------------------------------ |
| Header    | `{"alg": "HS256", "typ": "JWT"}`                       | İmzalama algoritmasını ve token türünü belirtir.       |
| Payload   | `{"sub": "567890", "role": "user", "exp": 1692230000}` | Kullanıcı ID’sini, rolü ve sona erme zamanını içerir. |
| Signature | `Hx73oTzVZj5lfZlyyRcAJo3hH9M3VBB9-LD9ACBRUjk`          | Token bütünlüğünü sağlar ve kurcalamayı engeller.    |

---

## 🏥 Görev 2: Sağlık Uygulaması için JWT Analizi (Cevap Anahtarı)

### 🔑 Sağlanan JWT

```text
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.  

eyJzdWIiOiIxMjM0NTUwIiwicm9sZSI6ImRvY3RvciIsImV4cCI6MTY4MjQ2NjAwMH0.  

dsg5KlRsdpQZn1uvKjMf2M3Kw8E3ljUlShVlxVc43F4
```

### 🧾 Header Analizi

#### ✅ Çözümlenmiş Header

```json
{
  "alg": "HS256",
  "typ": "JWT"
}
```

#### 🧠 Açıklama

* **alg:** Token’ı imzalamak için *HMAC-SHA256* algoritması ( *HS256* ) kullanılır.
* **typ:** Bunun bir JSON Web Token ( *JWT* ) olduğunu belirtir.

---

### 📦 Payload Analizi

#### ✅ Çözümlenmiş Payload

```json
{
  "sub": "1234550",
  "role": "doctor",
  "exp": 1682466000
}
```

#### 🧠 Açıklama

* **sub:** Kullanıcı ID’si ( *1234550* ).
* **role:** Kullanıcının doktor ( *doctor* ) olduğunu belirtir.
* **exp:** Sona erme zamanı ( *1682466000* ), token’ı 12 saatlik bir ömürle sınırlar.

---

### 🖊️ Signature Analizi

#### 🔐 Kodlanmış Signature

```text
dsg5KlRsdpQZn1uvKjMf2M3Kw8E3ljUlShVlxVc43F4
```

#### 🧠 Açıklama

İmza, kodlanmış header, payload ve gizli anahtarın ( *secret key* ) birleştirilmesiyle oluşturulur.

**Amaç:** Token’ı kurcalamaya karşı korur. Header veya payload’un herhangi bir kısmı değiştirilirse, imza artık doğrulanamaz ve sunucu token’ı reddeder.

---

### 📊 Bulguların Özeti

| Bileşen  | Çözümlenmiş İçerik                                    | Açıklama                                                   |
| --------- | ----------------------------------------------------------- | ------------------------------------------------------------ |
| Header    | `{"alg": "HS256", "typ": "JWT"}`                          | İmzalama algoritmasını ve token türünü belirtir.       |
| Payload   | `{"sub": "1234550", "role": "doctor", "exp": 1682466000}` | Kullanıcı ID’sini, rolü ve sona erme zamanını içerir. |
| Signature | `dsg5KlRsdpQZn1uvKjMf2M3Kw8E3ljUlShVlxVc43F4`             | Token bütünlüğünü sağlar ve kurcalamayı engeller.    |

## 🛡️ Etkinlik: API Uç Noktaları için Güvenlik Planlama – Cevap Anahtarı

## ✅ Görev 1: Sosyal Medya Platformu için API Güvenlik Planı

### 📌 Senaryo Özeti

Bir sosyal medya platformunda aşağıdaki API route’ları vardır:

* `GET /users/{id}`: Belirli bir kullanıcının profil bilgisini döndürür.
* `POST /posts`: Yeni bir gönderi oluşturur.
* `DELETE /posts/{id}`: Belirli bir gönderiyi siler.

---

### 🔐 JWT Doğrulaması Gereken Route’lar

* `GET /users/{id}`: Bu route kullanıcı profil bilgilerini döndürür. Kişisel verileri korumak için yalnızca kimliği doğrulanmış kullanıcılarla sınırlandırılmalıdır.
* `POST /posts`: Bu route kullanıcıların yeni gönderi oluşturmasına izin verir. Kullanıcının gerçek bir kullanıcı olduğunu doğrulamak için kimlik doğrulama gerekir.
* `DELETE /posts/{id}`: Bu route gönderileri siler. Yalnızca yetkili kullanıcıların kendi gönderilerini silebilmesini sağlamak için kimlik doğrulama gerekir.

---

### 🧩 Erişim için Gerekli Roller / Claim’ler

#### `GET /users/{id}`

* **Roller:** `user`
* **Claim’ler:** İstek yapanın profile erişmeye yetkili olduğunu doğrulamak için **user ID** içermelidir.

#### `POST /posts`

* **Roller:** `user`
* **Claim’ler:** Gönderiyi ilgili hesaba bağlamak için **user ID** içermelidir.

#### `DELETE /posts/{id}`

* **Roller:** `user`
* **Claim’ler:** Yalnızca gönderi sahibinin silebilmesi için **post ID** ve **user ID** içermelidir.

---

### 🧠 Neden Bu Kısıtlamalar Gerekli?

* JWT doğrulaması, yalnızca kimliği doğrulanmış kullanıcıların verilere erişmesini veya verileri değiştirmesini sağlar.
* Rol tabanlı erişim (`user`), eylemleri yalnızca meşru kullanıcılarla sınırlar.
* Claim’ler ek bir güvenlik katmanı sağlar; kullanıcıların yalnızca kendi verileriyle etkileşime girebilmesini garanti eder (ör. kendi profili veya kendi gönderileri).

---

### 📊 Bulguların Özeti

| Route                  | JWT Doğrulaması | Roller   | Claim’ler                                        |
| ---------------------- | ----------------- | -------- | ------------------------------------------------- |
| `GET /users/{id}`    | Gerekli           | `user` | **user ID**içermelidir.                    |
| `POST /posts`        | Gerekli           | `user` | **user ID**içermelidir.                    |
| `DELETE /posts/{id}` | Gerekli           | `user` | **user ID**ve**post ID**içermelidir. |

---

## ✅ Görev 2: Öğrenme Yönetim Sistemi (LMS) için API Güvenlik Planı

### 📌 Senaryo Özeti

Bir LMS’de aşağıdaki API route’ları vardır:

* `GET /courses`: Mevcut tüm kursları listeler.
* `POST /assignments`: Yeni bir ödev oluşturur.
* `GET /grades/{id}`: Belirli bir öğrencinin notlarını döndürür.

---

## 🧭 Adım Adım Ayrıntılandırma

### 🔐 JWT Doğrulaması Gereken Route’lar

* `GET /courses`: Bu route herkese açık kurs bilgisini listeler. Veri kamuya açık olduğu için JWT doğrulaması gerekmez.
* `POST /assignments`: Bu route eğitmenlerin ödev oluşturmasına izin verir. Kullanıcının meşru bir eğitmen olduğunu doğrulamak için kimlik doğrulama gerekir.
* `GET /grades/{id}`: Bu route hassas not bilgilerini döndürür. Öğrenci gizliliğini korumak için JWT doğrulaması gerekir.

---

### 🧩 Erişim için Gerekli Roller / Claim’ler

#### `GET /courses`

* **Roller:** Yok
* **Claim’ler:** Yok

#### `POST /assignments`

* **Roller:** `instructor`
* **Claim’ler:** Ödevin doğru kursla ilişkilendirilebilmesi için **course ID** içermelidir.

#### `GET /grades/{id}`

* **Roller:** `student`, `instructor`
* **Claim’ler:**
  * **Öğrenciler:** Yalnızca kendi notlarına erişebilmek için **student ID** içermelidir.
  * **Eğitmenler:** Kendi kurslarındaki öğrencilerin notlarını görebilmek için **course ID** içermelidir.

---

### 🧠 Neden Bu Kısıtlamalar Gerekli?

* Kamuya açık veriler (ör. kurs listeleri) kimlik doğrulama gerektirmez.
* JWT doğrulaması ve rol tabanlı erişim, yalnızca yetkili kullanıcıların ödev oluşturabilmesini veya notları görüntüleyebilmesini sağlar.
* Claim’ler, kullanıcıların yalnızca yetkili oldukları verilere erişebilmesini sağlar; örneğin öğrencinin sadece kendi notlarını görmesi.

---

### 📊 Bulguların Özeti

| Route                 | JWT Doğrulaması | Roller                     | Claim’ler                                                                            |
| --------------------- | ----------------- | -------------------------- | ------------------------------------------------------------------------------------- |
| `GET /courses`      | Gerekli değil    | Yok                        | Yok                                                                                   |
| `POST /assignments` | Gerekli           | `instructor`             | **course ID**içermelidir.                                                      |
| `GET /grades/{id}`  | Gerekli           | `student`,`instructor` | Öğrenci:**student ID**içermelidir. Eğitmen:**course ID**içermelidir. |

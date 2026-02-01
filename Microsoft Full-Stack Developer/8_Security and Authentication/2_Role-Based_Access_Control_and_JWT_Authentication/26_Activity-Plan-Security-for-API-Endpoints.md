## 🛡️ Etkinlik: API Uç Noktaları için Güvenlik Planlama

## 🔐 JWT Doğrulaması ile API Uç Noktaları Güvenliğini Planlama

### 🎯 Amaç

JWT doğrulaması gerektiren route’ları belirleyerek ve erişim için gerekli rollerin veya claim’lerin neler olduğunu tanımlayarak API endpoint’leri için güvenlik planlayın.

---

## 🧑‍🎓 Görev 1: Sosyal Medya Platformu için API Güvenlik Planı

### 📌 Senaryo

Bir sosyal medya platformunda şu API route’ları vardır:

* `GET /users/{id}`: Belirli bir kullanıcının profil bilgisini döndürür.
* `POST /posts`: Yeni bir gönderi oluşturur.
* `DELETE /posts/{id}`: Belirli bir gönderiyi siler.

### ✅ JWT Doğrulaması Gereken Route’lar

* `GET /users/{id}`: Profil bilgisi içerdiği için **JWT doğrulaması gerekli** (en azından detaylı profil verileri için).
* `POST /posts`: İçerik üretimi olduğu için  **JWT doğrulaması gerekli** .
* `DELETE /posts/{id}`: Silme işlemi kritik olduğu için  **JWT doğrulaması gerekli** .

### 🧩 Gerekli Roller / Claim’ler

* `GET /users/{id}`
  * **Roller:** user
  * **Claim’ler:** Kullanıcının görüntüleme yetkisini doğrulamak için *userId* (kendi profili veya herkese açık profil mantığına göre).
* `POST /posts`
  * **Roller:** user
  * **Claim’ler:** *userId* (gönderiyi doğru kullanıcıyla ilişkilendirmek için)
* `DELETE /posts/{id}`
  * **Roller:** user, admin
  * **Claim’ler:** *postId* ve *userId* (kullanıcının yalnızca kendi gönderisini silebilmesi için); admin için ek yetki.

### 📊 Özet Tablo

| Route                  | JWT Doğrulaması | Roller      | Claim’ler                       |
| ---------------------- | ----------------- | ----------- | -------------------------------- |
| `GET /users/{id}`    | Gerekli           | user        | userId (erişim kontrolü için) |
| `POST /posts`        | Gerekli           | user        | userId                           |
| `DELETE /posts/{id}` | Gerekli           | user, admin | postId, userId                   |

---

## 🧑‍🎓 Görev 2: Öğrenme Yönetim Sistemi (LMS) için API Güvenlik Planı

### 📌 Senaryo

Bir LMS’de şu API route’ları vardır:

* `GET /courses`: Mevcut tüm kursları listeler.
* `POST /assignments`: Yeni bir ödev oluşturur.
* `GET /grades/{id}`: Belirli bir öğrencinin notlarını döndürür.

### ✅ JWT Doğrulaması Gereken Route’lar

* `GET /courses`: Kurs kataloğu herkese açıksa  **JWT gerekli değil** , kullanıcıya özel kurs listesi gerekiyorsa  **JWT gerekli** .
* `POST /assignments`: Ödev oluşturma işlemi yetkili kişilerce yapılacağı için  **JWT doğrulaması gerekli** .
* `GET /grades/{id}`: Notlar hassas veri olduğu için  **JWT doğrulaması gerekli** .

### 🧩 Gerekli Roller / Claim’ler

* `GET /courses`
  * **Roller:** None (public ise) / student, instructor (kişiye özel ise)
  * **Claim’ler:** None / userId (kişiye özel listeleme için)
* `POST /assignments`
  * **Roller:** instructor, admin
  * **Claim’ler:** courseId (hangi kurs için ödev oluşturulduğunu doğrulamak için)
* `GET /grades/{id}`
  * **Roller:** student, instructor, admin
  * **Claim’ler:** studentId (öğrenci sadece kendi notuna erişebilmeli); instructor için courseId doğrulaması gerekebilir.

### 📊 Özet Tablo

| Route                 | JWT Doğrulaması                               | Roller                     | Claim’ler                                   |
| --------------------- | ----------------------------------------------- | -------------------------- | -------------------------------------------- |
| `GET /courses`      | Public ise gerekmez / kişiye özel ise gerekli | None / student, instructor | None / userId                                |
| `POST /assignments` | Gerekli                                         | instructor, admin          | courseId                                     |
| `GET /grades/{id}`  | Gerekli                                         | student, instructor, admin | studentId (kendi notu), courseId (gerekirse) |

## 🗝️ Activity: Analyzing Full-Stack Integration in Industry – Answer Key

---

## 🔐 1) User Login Integration

**Front-End:** Bir Blazor formu username ve password bilgilerini toplar ve `HttpClient` kullanarak sunucuya gönderir.

**Back-End:** Minimal API, credential’ları SQL Server veritabanına karşı doğrular. Geçerliyse bir session token üretir ve front-end’e geri döndürür.

**Data Flow:**

Credentials input → API → SQL validation.

Token generation → Response to front-end.

---

## 📝 2) Posting a Status Update

**Front-End:** Kullanıcı bir text field içine status update yazar ve “Post” tıklar. Bu, status text’i içeren bir POST request’ini back-end’e gönderir.

**Back-End:** API, status’u SQL Server veritabanına timestamp ve user ID ile birlikte kaydeder.

**Data Flow:**

Status text → API → Database entry.

Confirmation → Front-end updates UI to display the new status.

---

## 📰 3) Viewing the Feed

**Front-End:** Feed sayfası yüklendiğinde Blazor, recent status update’leri çekmek için bir GET request tetikler.

**Back-End:** API, SQL Server veritabanından recent status’leri sorgular ve bunları JSON array olarak döndürür.

**Data Flow:**

GET request → API → Database query.

JSON response → Feed rendered on the front-end.

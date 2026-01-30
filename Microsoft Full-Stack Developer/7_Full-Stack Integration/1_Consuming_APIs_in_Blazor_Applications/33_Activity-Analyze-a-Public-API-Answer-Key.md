## 🧾 Etkinlik: Public API Analizi - Cevap Anahtarı

---

## 🌐 Örnek API: GitHub API

### ⛔ Rate Limits

GitHub API, kimlik doğrulama olmadan saatte **60** isteğe izin verir. Kimlik doğrulaması (authenticated) yapılan isteklerde limit saatte **5.000** isteğe çıkar. Bunu Blazor’da yönetmek için **authentication token** kullanın ve kullanım limitlerini izleyerek istek sayısını kontrol edin.

### 🗃️ Caching Policies

Repository bilgileri gibi yanıtlar cache’lenebilir. Tekrarlanan API çağrılarını azaltmak için Blazor’da **MemoryCache** kullanarak repository verisini geçici olarak saklayın.

### 🔐 Security Features

Kimlik doğrulama, **Personal Access Token (PAT)** ile yönetilir. PAT’i Blazor’un güvenli yapılandırma alanında saklayın ve  **client-side kodda asla açığa çıkarmayın** .

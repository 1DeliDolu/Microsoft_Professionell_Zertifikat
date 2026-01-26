## 🧩 Etkinlik: Problem Ayrıştırma - Cevap Anahtarı

### ✅ Cevap Anahtarı

---

## 🏋️ Problem 1: Fitness Takip Uygulaması

**Ana Hedef:** Antrenmanları, diyeti ve sağlık içgörülerini izlemek için bir fitness takip uygulaması geliştirmek.

### 🏗️ Top-Down Yaklaşımı

* **Antrenman Takibi:** Farklı türde antrenmanları kaydetmek.
* **Diyet İzleme:** Günlük yiyecek tüketimini ve kaloriyi takip etmek.
* **Sağlık İçgörüleri:** Antrenman ve diyet verilerine dayalı geri bildirim sağlamak.

### 🧩 Daha Küçük Bileşenlere Ayırma

**Antrenman Takibi:**

* Bir antrenman günlüğü özelliği uygulamak.
* Farklı antrenman kategorileri eklemek (örn. kardiyo, kuvvet antrenmanı).
* Antrenman süresi ve yoğunluğunu takip etmek.

**Diyet İzleme:**

* Bir yemek günlüğü özelliği oluşturmak.
* Kullanıcıların yaygın yiyecekleri ve besin değerlerini aramasına izin vermek.
* Yaygın yiyecekler ve besin değerleri için bir veritabanı eklemek.
* Kullanıcıların özel (custom) yiyecek öğeleri eklemesine izin vermek.

**Sağlık İçgörüleri:**

* Antrenman ve diyet verilerini analiz etmek.
* Günlük, haftalık ve aylık sağlık raporları sağlamak.
* Fitness’ı iyileştirmek için ipuçları önermek.

### 🧩 Modülerleştirme

Her ana bileşen için ayrı modüller oluşturmak:

* **Antrenman Takibi Modülü:** Farklı antrenman rutinlerini takip etmeye yönelik özellikleri yönetir.
* **Diyet İzleme Modülü:** Kalori alımı ve öğün planlamasıyla ilgili özellikleri yönetir.
* **Sağlık İçgörüleri Modülü:** Kullanıcı sağlık analizi, kullanıcı sağlık içgörüleri ve öneriler sunmaya yönelik özellikleri yönetir.

---

## 🎓 Problem 2: Çevrim İçi Öğrenme Platformu Oluşturma

**Ana Hedef:** Kurs oluşturmayı, kaydı (enrollment), içerik sunumunu ve ilerleme takibini desteklemek için bir çevrim içi öğrenme platformu geliştirmek.

### 🏗️ Top-Down Yaklaşımı

* **Kurs Oluşturma:** Eğitmenlerin kursları oluşturmasına ve yönetmesine izin vermek.
* **Kullanıcı Kaydı (Enrollment):** Öğrencilerin kurslara kaydolmasını sağlamak.
* **İçerik Sunumu:** Öğrencilere kurs materyallerine erişim sağlamak.
* **İlerleme Takibi:** Öğrenci ilerlemesini izlemek ve raporlamak.

### 🧩 Daha Küçük Bileşenlere Ayırma

**Kurs Oluşturma:**

* Kurs oluşturma araçlarını uygulamak (metin, video, quizler).
* Kurs düzenleme ve yayımlama özellikleri sağlamak.
* Kurs kategorilerini ve etiketlemeyi (tagging) yönetmek.

**Kullanıcı Kaydı (Enrollment):**

* Bir kayıt (registration) sistemi geliştirmek.
* Ücretli kurslar için ödeme işleme (payment processing) uygulamak.
* Öğrenci kaydını ve erişim kontrolünü yönetmek.

**İçerik Sunumu:**

* Bir içerik yönetim sistemi oluşturmak.
* Video derslerin akış (streaming) şeklinde sunulmasını etkinleştirmek.
* İndirilebilir materyaller sağlamak.

**İlerleme Takibi:**

* Quiz puanlarını ve ödevleri takip etmek.
* Kurs tamamlama yüzdelerini göstermek.
* İlerleme raporları üretmek.

### 🧩 Modülerleştirme

* Kurs Oluşturma, Kullanıcı Kaydı (Enrollment), İçerik Sunumu ve İlerleme Takibi için bağımsız modüller geliştirmek.

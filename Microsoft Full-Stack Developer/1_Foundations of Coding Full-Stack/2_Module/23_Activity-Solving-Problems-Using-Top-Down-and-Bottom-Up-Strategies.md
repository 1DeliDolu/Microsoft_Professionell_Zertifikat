## 🧩 Top-Down ve Bottom-Up Yaklaşımlarıyla Problem Ayrıştırma

### 🎯 Amaç

Hem *top-down* hem de *bottom-up* yaklaşımlarını kullanarak karmaşık problemleri daha küçük parçalara ayırma pratiği yapmak. Bu, öğrenenlerin problemin doğasına ve mevcut bilgi düzeyine göre hangi yaklaşımın ne zaman kullanılacağını anlamasına yardımcı olur.

### 📝 Açıklama

Bu etkinlikte, karmaşık problemleri *top-down* ve *bottom-up* yaklaşımlarıyla daha küçük parçalara ayıracaksınız. Bu süreç, problemin niteliğine ve eldeki bilgiye bağlı olarak hangi yaklaşımı kullanmanız gerektiğini anlamayı destekler.

---

## ✅ Örnek 1: Top-Down Yaklaşımı – Kütüphane Yönetim Sistemi Oluşturma

### 🧩 Problem Tanımı

Kullanıcıların kitap ödünç alıp iade edebildiği, kitap arayabildiği ve kullanıcı hesaplarının yönetilebildiği bir kütüphane yönetim sistemi geliştirmeniz gerekiyor.

### 🧠 Top-Down Yaklaşımını Uygulama

#### Genel Hedefi Tanımla

Amaç, bir kütüphane yönetim sistemi oluşturmaktır.

### 🏗️ Top-Down Yaklaşımı

#### Adım 1: Ana Fonksiyonları Belirle

Kütüphaneyi yönetme genel hedefinden başlayın ve gerekli temel özellikleri tanımlayın:

* **Kitap Yönetimi** (Ödünç Alma, İade, Arama)
* **Kullanıcı Yönetimi** (Hesap Oluşturma, Kimlik Doğrulama)
* **Kütüphane Yönetimi/İdari İşlemler** (Katalog Yönetimi, Rapor Oluşturma)

#### Adım 2: Ana Fonksiyonları Daha Spesifik Görevlere Böl

Her ana fonksiyonu daha ayrıntılı görevlere ayrıştırın:

**Kitap Yönetimi:**

* **Kitap Ödünç Alma:** Kullanıcılar kütüphaneden kitap ödünç alabilmelidir.
* **Kitap İade:** Kullanıcılar kitapları iade edebilmelidir.
* **Kitap Arama:** Başlık, yazar veya türe göre kitap arama işlevi.

**Kullanıcı Yönetimi:**

* **Hesap Oluşturma:** Kullanıcılar hesap oluşturup yönetebilmelidir.
* **Kimlik Doğrulama:** Güvenli giriş ve çıkış işlevselliği.

**Kütüphane Yönetimi/İdari İşlemler:**

* **Katalog Yönetimi:** Kitap bilgisi ekleme, silme veya güncelleme.
* **Rapor Oluşturma:** Kitap uygunluğu, ödünç alınan kitaplar vb. raporlar üretme.

### 🛠️ Top-Down Yaklaşımını Uygulama

* Genel sistem yapısını tasarlayarak ve bileşenler arası arayüzleri tanımlayarak başlayın.
* Her bileşeni daha küçük görevlere veya modüllere ayırın.
* Her modülü bağımsız geliştirin ve test edin; genel sistem tasarımıyla uyumlu olduklarından emin olun.

### ✅ Neden Top-Down Yaklaşımı?

Top-down yaklaşımı burada uygundur; çünkü kütüphane yönetim sisteminin genel yapısı nettir ve onu daha küçük görevlere ayırmak geliştirme sürecini organize etmeye yardımcı olur. Geliştiricilerin büyük resimle başlayıp her bileşeni kademeli olarak rafine etmesini sağlar.

---

## ✅ Örnek 2: Bottom-Up Yaklaşımı – Akıllı Ev Sistemi Oluşturma

### 🧩 Problem Tanımı

Aydınlatma kontrolü, güvenlik özellikleri ve sıcaklık yönetimini içeren bir akıllı ev sistemi geliştirmeniz isteniyor.

### 🧠 Bottom-Up Yaklaşımını Uygulama

#### Küçük, Yönetilebilir Parçalarla Başla

Her akıllı özelliği bağımsız bir modül olarak geliştirmeye odaklanın:

* **Aydınlatma Kontrol Modülü:** Işıkları uzaktan kontrol etme, parlaklık ayarlama ve zamanlama oluşturma.
* **Güvenlik Modülü:** Kapı kilitleri, güvenlik kameraları ve hareket algılama.
* **Sıcaklık Yönetimi Modülü:** Isıtma/soğutma sistemlerini kontrol etme, sıcaklık tercihlerini ayarlama ve enerji kullanımını izleme.

#### Her Modülü Bağımsız Geliştir

* **Aydınlatma Kontrolü:** Uzaktan kontrol ve zamanlamayı içeren aydınlatma işlevselliğini geliştirin.
* **Güvenlik Özellikleri:** Güvenli kapı kilidi kontrolü, kameralarla entegrasyon ve hareket sensörlerinin kurulumu.
* **Sıcaklık Yönetimi:** HVAC sistemleriyle iletişim kurabilen ve gerçek zamanlı sıcaklık ayarlamaları sağlayan sistem.

#### Modülleri Tam Bir Sisteme Entegre Et

* Her modül bağımsız geliştirilip test edildikten sonra, bunları birleşik bir akıllı ev sistemi oluşturacak şekilde entegre edin.
* Tüm modüllerin sorunsuz etkileşmesi için ortak iletişim protokolleri kullanın.

### ✅ Neden Bottom-Up Yaklaşımı?

Bottom-up yaklaşımı burada idealdir; çünkü her özellik (aydınlatma, güvenlik, sıcaklık) tüm sistemin eksiksiz anlaşılmasını gerektirmeden bağımsız olarak geliştirilebilir. Bu yaklaşım esneklik ve artımlı geliştirme sağlar; özellik ekleme veya değiştirme süreçlerini kolaylaştırır.

---

## 📌 Problem 1: Proje Yönetimi

### 🧩 Problem Tanımı

Görev takibi, ekip iş birliği ve raporlama özellikleri içeren bir proje yönetim aracının geliştirilmesini ayrıştırın. Hangi yaklaşımın (*top-down* veya  *bottom-up* ) daha uygun olduğuna karar verin ve nedenini açıklayın.

### 🧭 Yönergeler

* Aracın ana hedefini belirleyin.
* Problem gereksinimlerine göre top-down veya bottom-up yaklaşımını seçin.
* Sistemi özelliklere ve görevlere ayırın.
* Seçilen yaklaşımın neden uygun olduğunu açıklayın.

---

## ❤️ Problem 2: Çevrim İçi Sağlık İzleme Sistemi

### 🧩 Problem Tanımı

Fiziksel aktiviteyi, uykuyu ve kalp atış hızını takip eden bir çevrim içi sağlık izleme sisteminin oluşturulmasını ayrıştırın. Hangi yaklaşımın (*top-down* veya  *bottom-up* ) daha uygun olduğuna karar verin ve nedenini açıklayın.

### 🧭 Yönergeler

* Sistemin ana hedefini belirleyin.
* Problem gereksinimlerine göre top-down veya bottom-up yaklaşımını seçin.
* Sistemi özelliklere ve görevlere ayırın.
* Seçilen yaklaşımın neden uygun olduğunu açıklayın.

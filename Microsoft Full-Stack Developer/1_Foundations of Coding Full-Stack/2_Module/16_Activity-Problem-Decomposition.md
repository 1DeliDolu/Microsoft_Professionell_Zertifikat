## 🧩 Top-Down Yaklaşımı ve Modülerleştirme Kullanarak Problem Ayrıştırma

### 🎯 Amaç

Karmaşık programlama görevlerini yönetilebilir bileşenlere ayırmak için *top-down yaklaşımı* ve *modülerleştirme* tekniklerini kullanarak problem ayrıştırma uygulamak.

### 📝 Açıklama

Bu etkinlikte, karmaşık problemleri *top-down yaklaşımı* ile daha küçük görevlere ayıracaksınız. İki örneği inceledikten sonra, aynı yöntemi bir fitness takip uygulaması ve bir çevrim içi öğrenme platformu geliştirmek için uygulayacaksınız. Odak noktası; ana özellikleri belirlemek, bunları yönetilebilir görevlere bölmek ve çözümü modülerleştirmektir.

---

## ✅ Tam Örnek 1: Yapılacaklar Listesi Uygulaması Oluşturma

### 🧩 Problem Tanımı

Basit bir yapılacaklar listesi uygulaması oluşturmakla görevlendirildiğinizi hayal edin. Uygulama, kullanıcıların görev eklemesine, görev listesini görüntülemesine, görevleri tamamlandı olarak işaretlemesine ve görevleri silmesine izin vermelidir.

### 🧠 Problem Ayrıştırma Uygulaması

#### Genel Hedefi Tanımla

Ana amaç, görevleri etkili şekilde yöneten işlevsel bir yapılacaklar listesi uygulaması oluşturmaktır.

### 🏗️ Top-Down Yaklaşımı

#### Adım 1: Ana Fonksiyonları Belirle

Uygulamanın yerine getirmesi gereken temel fonksiyonları belirleyerek başlayın. Bu örnekte:

* Görev Yönetimi (Görev ekleme, görüntüleme, işaretleme, silme)
* Kullanıcı Etkileşimi (Kullanıcıların görevlerle etkileşim kuracağı arayüz)

#### Adım 2: Ana Fonksiyonları Parçalara Böl

Bu ana fonksiyonları daha spesifik görevlere veya işlemlere ayrıştırın:

**Görev Yönetimi:**

* Görev Ekle: Listeye yeni görev ekleme işlevi sağla.
* Görevleri Görüntüle: Mevcut tüm görevlerin listesini göster.
* Görevi Tamamlandı Olarak İşaretle: Kullanıcıların görevleri tamamlandı olarak işaretlemesini sağla.
* Görev Sil: Kullanıcıların listeden görev kaldırmasını sağla.

**Kullanıcı Etkileşimi:**

* Kullanıcı Arayüzü (UI): Ekleme, görüntüleme, işaretleme ve silme için düğmeler veya seçenekler içeren sezgisel bir UI oluştur.

### 🧩 Modülerleştirme

Her temel fonksiyon ayrı bir modül olarak geliştirilebilir:

* Görev Ekle Modülü: Görev oluşturmayı yönetir.
* Görevleri Görüntüleme Modülü: Görevlerin gösterimini yönetir.
* Görev İşaretleme Modülü: Görevleri tamamlandı olarak işaretleme işlevini sağlar.
* Görev Silme Modülü: Görevlerin kaldırılmasını yönetir.
* Görev Depolama Modülü: Görev verilerini saklamak ve geri almak için merkezi bir merkez

Bu modüller daha sonra ana uygulamaya entegre edilebilir. Bu modüler yaklaşım, uygulamanın her parçasının belirli bir göreve odaklanmasını sağlar ve geliştirmeyi ile hata ayıklamayı kolaylaştırır.

### 🧾 Adım Adım Açıklama

* Geniş hedefle başlayın: Uygulamanın görev yönetimi için tasarlandığını anlayın. “Görev yönetimi”nin ne içerdiğini parçalayın.
* Ana özellikleri belirleyin: Top-down yaklaşımıyla gerekli temel özellikleri belirleyin (ekleme, görüntüleme, işaretleme, silme).
* Özellikleri daha küçük görevlere bölün: Her özellik, bağımsız ele alınabilecek daha küçük görevlere ayrılır.
* Her görevi modülerleştirin: Her küçük görevi bir modül gibi ele alın. Entegrasyondan önce bu modülleri bağımsız geliştirip test edin.

### 🔎 İnceleme ve Yansıtma

Top-down yaklaşımıyla problemi yönetilebilir hâle getiririz. Modülerleştirme, özelliklerin bağımsız geliştirilmesini ve test edilmesini sağlar; böylece sistematik ve düzenli bir yaklaşım oluşur.

---

## ✅ Tam Örnek 2: Temel Bir E-Ticaret Sitesi Geliştirme

### 🧩 Problem Tanımı

Temel bir e-ticaret sitesi geliştirmeniz isteniyor. Site; ürünleri gezme, ürünleri sepete ekleme, ödeme adımı ve ödeme işlemlerini gerçekleştirme gibi özellikleri içermelidir.

### 🧠 Problem Ayrıştırma Uygulaması

#### Genel Hedefi Tanımla

Çevrim içi alışverişi mümkün kılan tamamen işlevsel bir e-ticaret sitesi oluşturmak.

### 🏗️ Top-Down Yaklaşımı

#### Adım 1: Ana Bileşenleri Belirle

Sitenin ana bölümlerini belirleyin:

* Ürün Kataloğu: Ürünleri göster ve yönet.
* Alışveriş Sepeti: Kullanıcının satın almak istediği ürünleri yönet.
* Ödeme Süreci: Satın alma işlemini tamamlama adımlarını yönet.
* Ödeme İşleme: İşlemleri güvenli biçimde gerçekleştir.

#### Adım 2: Bileşenleri Parçalara Böl

Her bileşeni daha spesifik görevlere ayrıştırın:

**Ürün Kataloğu:**

* Ürünleri görseller ve detaylarla göster.
* Belirli ürünleri bulmak için arama ve filtreleme seçenekleri.

**Alışveriş Sepeti:**

* Sepete ürün ekle.
* Adet güncelle veya ürün kaldır.
* Sepet toplamını göster.

**Ödeme Süreci:**

* Kullanıcının teslimat bilgilerini topla.
* Sipariş detaylarını onayla.

**Ödeme İşleme:**

* Bir ödeme altyapısı (payment gateway) ile entegre et.
* Ödemeleri güvenli biçimde işle.
* Kullanıcılara sipariş onayı gönder.

### 🧩 Modülerleştirme

Her ana bileşen için ayrı modüller oluşturun:

* Ürün Kataloğu Modülü: Ürünle ilgili tüm özellikleri yönetir.
* Sepet Modülü: Sepetin işlevlerini yönetir.
* Ödeme (Checkout) Modülü: Kullanıcı bilgileri ve sipariş onayını yönetir.
* Ödeme (Payment) Modülü: Güvenli işlemleri sağlar.

Modüler geliştirme, farklı ekip üyelerinin eşzamanlı çalışmasını sağlayarak verimliliği artırır.

### 🧾 Adım Adım Açıklama

* Geniş hedefle başlayın: Site çevrim içi alışverişi mümkün kılmalıdır. Bunun hangi özellikleri gerektirdiğini parçalayın.
* Ana bileşenleri belirleyin: Ürün Kataloğu, Sepet, Checkout, Payment.
* Bileşenleri görevlere bölün: Her ana bileşeni daha küçük işlere bölün.
* Her bileşeni modülerleştirin: Her bileşeni ayrı modül olarak geliştirin; yönetim, test ve ölçeklenebilirlik kolaylaşır.

### 🔎 İnceleme ve Yansıtma

Problem ayrıştırma ile gerekli tüm özellikleri ve görevleri belirler, hiçbir şeyin gözden kaçmamasını sağlarız. Modülerleştirme; paralel geliştirme, verimli test ve kolay güncellemeleri destekler.

---

## 🏋️ Problem 1: Fitness Takip Uygulaması

### 🧩 Problem 1 Tanımı

Kullanıcıların antrenmanlarını takip edebilen, beslenmelerini izleyebilen ve sağlık içgörüleri sunan bir fitness takip uygulamasının geliştirilmesini ayrıştırın.

### 🧭 Yönergeler

#### Genel Hedefi Tanımla

Uygulamanın ana hedefi:

Kullanıcıların antrenmanlarını takip etmelerini, diyetlerini izlemelerini ve sağlık içgörüleri almalarını sağlayan bir fitness takip uygulaması geliştirmek.

### 🏗️ Top-Down Yaklaşımı

#### Adım 1: Ana Özellikleri Belirle

* Antrenman Takibi
* Diyet Takibi
* Sağlık İçgörüleri

#### Adım 2: Her Özelliği Daha Küçük Görevlere Böl

**Antrenman Takibi:**

* Antrenman türlerini kaydetme
* Süre, tekrar, set gibi verileri girme
* Antrenman geçmişini görüntüleme
* Antrenman hedefleri belirleme

**Diyet Takibi:**

* Öğün ekleme (kahvaltı/öğle/akşam/atıştırma)
* Kalori ve makro takibi (protein/karbonhidrat/yağ)
* Su tüketimi takibi
* Beslenme geçmişini görüntüleme

**Sağlık İçgörüleri:**

* Haftalık/aylık performans özetleri
* Kalori dengesi analizi
* Antrenman ve beslenme trendleri
* Kullanıcıya öneriler üretmek için metrik hesaplama

### 🧩 Modülerleştirme Fırsatları

* Antrenman Modülü
* Diyet Modülü
* İçgörü/Analiz Modülü
* Kullanıcı Profili Modülü
* Veri Depolama Modülü
* Bildirim Modülü (hedef hatırlatıcıları vb.)

---

## 🎓 Problem 2: Çevrim İçi Öğrenme Platformu

### 🧩 Problem 2 Tanımı

Kurs oluşturmayı, kullanıcı kaydını (enrollment), içerik sunumunu ve ilerleme takibini destekleyen bir çevrim içi öğrenme platformu oluşturmayı ayrıştırın.

### 🧭 Yönergeler

#### Genel Hedefi Tanımla

Platformun ana hedefi:

Kurs oluşturmayı, kullanıcıların kurslara kaydolmasını, içeriklerin sunulmasını ve ilerlemenin izlenmesini sağlayan bir çevrim içi öğrenme platformu geliştirmek.

### 🏗️ Top-Down Yaklaşımı

#### Adım 1: Ana Özellikleri Belirle

* Kurs Oluşturma
* Kullanıcı Kaydı (Enrollment)
* İçerik Sunumu
* İlerleme Takibi

#### Adım 2: Her Özelliği Daha Küçük Görevlere Böl

**Kurs Oluşturma:**

* Kurs başlığı/açıklaması oluşturma
* Modül ve ders ekleme
* İçerik yükleme (video/doküman/quiz)
* Kurs yayımlama ve güncelleme

**Kullanıcı Kaydı (Enrollment):**

* Kullanıcı hesabı oluşturma / giriş
* Kurslara kayıt olma
* Kayıtlı kursları listeleme
* Kurs erişim yetkilerini kontrol etme

**İçerik Sunumu:**

* Ders oynatıcı/sunum arayüzü
* Dosya indirme veya görüntüleme
* Quiz ve ödev teslimi
* İçerik sıralaması ve gezinme

**İlerleme Takibi:**

* Tamamlanan dersleri işaretleme
* Quiz sonuçlarını kaydetme
* İlerleme yüzdesi hesaplama
* Sertifika/rozet gibi çıktılar üretme

### 🧩 Modülerleştirme Fırsatları

* Kurs Yönetimi Modülü
* Kullanıcı ve Kimlik Doğrulama Modülü
* Enrollment Modülü
* İçerik Dağıtım Modülü
* Değerlendirme (Quiz/Ödev) Modülü
* İlerleme ve Raporlama Modülü
* Bildirim Modülü (hatırlatmalar, kurs güncellemeleri)

---

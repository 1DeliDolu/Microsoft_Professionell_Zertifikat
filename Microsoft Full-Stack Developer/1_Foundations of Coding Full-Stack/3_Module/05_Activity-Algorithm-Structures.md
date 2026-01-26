## 🎯 Koşullu ve İkili Karar Yapılarını Uygulama

### 🧭 Amaç

Geliştiricilerin programlamada seçimleri yönetmek ve yönlendirmek için koşullu ( *if/then* ) ve ikili karar yapılarını nasıl kullanabileceğini göstermek.

---

## 📝 Açıklama

Bu etkinlik, senaryoları analiz etmeyi, uygun algoritma yapılarını seçmeyi ve ardından bu yapıları uygulamak için sözde kod yazmayı içerir. İki tamamen çözülmüş örnekle başlayacağız ve ardından sizin bağımsız olarak tamamlayacağınız bir görevle devam edeceğiz.

---

## ✅ Örnek 1: Oy Kullanma Uygunluğunu Kontrol Etme

### 📌 Problem İfadesi

Bir kişinin oy kullanmaya uygun olup olmadığını kontrol eden bir program geliştirin. Yaşı 18 veya daha büyükse program **"You are eligible to vote."** yazdırmalıdır. Aksi halde **"You are not eligible to vote yet."** yazdırmalıdır.

### 🔎 Süreç

#### 1) Problemi Tanımla

Seçim tarihinde kişinin yaşı 18 veya daha büyükse **"You are eligible to vote."** yazdırılmalı; değilse **"You are not eligible to vote yet."** yazdırılmalıdır.

#### 2) Temel Süreçleri Belirle

* **Kişinin yaşını gir:** Programın karar verebilmesi için seçim tarihindeki yaşı bilmesi gerekir. Bu nedenle ilk temel süreç, kullanıcıdan yaş bilgisini almaktır.
* **Yaş koşulunu kontrol et:** Karar, yaşın 18 veya daha büyük olup olmamasına bağlıdır. Bu yüzden yaşın en az 18 olma koşuluna göre kontrol edilmesi gerekir.
* **Yaşa göre mesaj yazdır:** Yaş kontrolünün sonucuna göre programın belirli bir mesaj yazdırması gerekir. İki olası sonuç vardır; bu nedenle temel süreç uygun mesajı seçmektir.

#### 3) Açıklama

Bu süreçler, oy kullanma uygunluğuna karar verme gereksinimine dayanarak belirlenmiştir. Yaş girdisi zorunludur çünkü kararın verildiği veridir. Yaşı koşulla karşılaştırmak doğrudan problemin gereksinimini karşılar ve mesaj yazdırma kullanıcı için gerekli çıktıyı sağlar.

#### 4) Algoritma Yapısını Seç

Aşağıdaki soruları dikkate alın:

* Kontrol edilecek birden fazla koşul var mı? Hayır, yalnızca bir koşul var: yaşın 18 veya daha büyük olup olmadığı.
* Karar iki sonuç arasında mı? Evet, uygun veya uygun değil.
* Problem birden fazla kategoriye sınıflandırma içeriyor mu? Hayır, yalnızca iki olasılık var.

**Seçilen Yapı:** Bu değerlendirmelere göre koşullu ifade ( *if/then* ) uygundur. Bu yapı, bir koşulun doğru/yanlış olmasını kontrol etmek ve buna göre karar vermek için idealdir.

#### 5) Sözde Kod Oluşturma Adımları

* **Adım 1:** Kullanıcının girdisini (yaş) saklamak için değişkeni tanımla.
* **Adım 2:** Yaşın 18 veya daha büyük olup olmadığını kontrol etmek için *if* kullan.
* **Adım 3:** Koşul doğruysa uygunluk mesajını göster.
* **Adım 4:** Koşul yanlışsa *else* ile uygun olmama mesajını göster.

### 🧾 Sözde Kod

```text
Create variable age and set it to the value of the user input for "Enter your age on the date of the election:"
IF age is greater than or equal to 18 THEN
        Display to user "You are eligible to vote."
Otherwise
        Display to user "You are not eligible to vote yet."
```

---

## ✅ Örnek 2: Festival Katılımcılarını Kategorize Etme

### 📌 Problemi Tanımla

Bir açık hava festivali için katılımcıları yaşa göre kategorize edin: 21 veya daha büyükse **"Adult"** bilekliği; aksi halde **"Minor"** bilekliği verilir.

### 🔎 Temel Süreçleri Belirle

* **Kişinin yaşını gir:** Karar vermek için gerekli temel bilgi yaştır.
* **Yaş koşulunu kontrol et:** Yaşın 21 veya daha büyük olup olmadığı kontrol edilir.
* **Mesaj yazdır:** Koşula göre bileklik türü çıktısı verilir.

### 🧠 Açıklama

Bu süreçler, ilk örneğe benzer; ancak koşul 21 yaşa göre değişir. Hangi bilekliğin verileceği bu girdiye bağlıdır. Girdi alma, koşul kontrolü ve çıktı üretme süreçleri doğrudan gereksinimlerden türetilmiştir.

### 🧭 Algoritma Yapısını Seç

* Kontrol edilecek birden fazla koşul var mı? Hayır, yalnızca bir koşul var: 21 veya daha büyük olup olmadığı.
* Karar ikili mi? Evet, **"Adult"** veya **"Minor."**
* Karmaşık sınıflandırma var mı? Hayır, basit bir kontroldür.

**Seçilen Yapı:** Burada ikili karar yapısı idealdir çünkü iki sonucu verimli şekilde yönetir. *If/else* ile kolayca uygulanabilir.

### 🧾 Sözde Kod

```text
Create variable age and set it to the value of the user input for "Enter your age:"
IF age is greater than or equal to 21 THEN
        Display to user "Adult wristband."
Otherwise
        Display to user "Minor wristband."
```

---

## ✅ Örnek 3: Notlandırma Sistemi

### 📌 Problemi Tanımla

Bir öğrencinin notunu girdi olarak alan bir program yazın. Not 90 veya üzeriyse not  **"A."** ; 80 ile 89 arasındaysa  **"B."** ; 70 ile 79 arasındaysa  **"C."** ; aksi halde **"F."** olmalıdır.

### 🔎 Temel Süreçleri Belirle

* **Öğrencinin notunu gir:** Notu belirlemek için girdi alınmalıdır.
* **Not aralığını kontrol et:** Doğru notu belirlemek için birden fazla aralık kontrol edilmelidir (90+, 80–89, 70–79, 70 altı).
* **Uygun notu yazdır:** Aralığa göre doğru not çıktısı verilmelidir.

### 🧠 Açıklama

Temel süreçler, bir girdi alma (not), doğru notu belirlemek için birden fazla koşul kontrol etme ve ardından notu çıktı olarak verme gereksiniminden doğar. Bu, notları birden fazla kategoriye ayırmayı gerektirir.

### 🧭 Algoritma Yapısını Seç

* Kontrol edilecek birden fazla koşul var mı? Evet, birden fazla aralık var.
* Karar ikili mi? Hayır, ikiden fazla sonuç var (A, B, C, F).
* Birden fazla kategoriye sınıflandırma var mı? Evet, iki kategoriden fazlası var.

**Seçilen Yapı:** Bir koşul ifadeleri dizisi ( *if/else if/else* ) uygundur. Koşullar sırayla kontrol edilir ve biri doğru olana kadar devam eder; bu, birden fazla olası sonucu verimli şekilde yönetir.

### 🧾 Sözde Kod

```text
Create variable score and set it to the value of the input for "Enter the student's score:"
IF score greater than or equal to 90 THEN
        Display to user "Grade A."
Otherwise IF score greater than or equal to 80 THEN
        Display to user "Grade B."
Otherwise IF score greater than or equal to 70 THEN
        Display to user "Grade C."
Otherwise
        Display to user "Grade F."
```

---

## 🧪 Problem 1: İndirim Uygunluğu

### 📌 Senaryo

Bir müşterinin indirim için uygun olup olmadığını belirleyen bir program oluşturmakla görevlendirildiniz. Program, müşterinin toplam harcama tutarını kontrol etmeli ve indirim alıp almayacağına karar vermelidir.

### 🧾 Talimatlar

* Toplam harcama tutarını girdi olarak alan bir program yazın.
* Müşteri **100$ veya daha fazla** harcadıysa **"10% discount applied."** yazdırın.
* Müşteri **100$’dan az** harcadıysa **"No discount."** yazdırın.

---

## 📚 Problem 2: Kitap Kategorilendirme

### 📌 Senaryo

Bir kütüphanenin kitapları türlerine göre kategorize etmesi gerekiyor. Her kitabı doğru şekilde kategorize etmeye yardımcı olacak bir program geliştirmeniz gerekiyor.

### 🧾 Talimatlar

* Bir kitabın türünü girdi olarak alan bir program yazın.
* Tür **"Fiction"** ise **"Category: Fiction."** yazdırın.
* Tür **"Non-Fiction"** ise **"Category: Non-Fiction."** yazdırın.
* Tür **"Science Fiction"** ise **"Category: Science Fiction."** yazdırın.
* Tür bunlardan hiçbirine uymuyorsa **"Category: Unknown."** yazdırın.

---

## 🔢 Problem 3: Çift mi Tek mi?

### 📌 Senaryo

Verilen bir sayının çift mi yoksa tek mi olduğunu belirleyen bir program oluşturmanız gerekiyor.

### 🧾 Talimatlar

* Bir sayıyı girdi olarak alan bir program yazın.
* Sayı çiftse **"Even number."** yazdırın.
* Sayı tekse **"Odd number."** yazdırın.

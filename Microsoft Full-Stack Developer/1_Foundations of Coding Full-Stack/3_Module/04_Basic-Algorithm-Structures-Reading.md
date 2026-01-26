## 🧩 Temel Algoritma Yapıları

### 🧠 Temel Algoritma Yapılarına Giriş

Algoritmalar, programlamada problemleri çözen veya görevleri yerine getiren yapılandırılmış talimat kümeleridir. Farklı algoritma yapı türlerini anlamak, verimli kod yazmak için kritik öneme sahiptir.

---

## 🧭 Koşullu İfadeler

Koşullu ifadeler, bir koşulun doğru ya da yanlış olmasına bağlı olarak programın karar vermesine ve eylemleri çalıştırmasına olanak tanır.

### 📌 Koşullu İfadelerin Türleri

* *if/then* ifadeleri: belirli bir koşul doğruysa bir kod bloğunu çalıştırır.
* *switch* ifadeleri: bir değişkeni değerlendirir ve değere göre farklı kod bloklarını çalıştırır.

### 🗳️ Örnek: Oy Kullanma Uygunluğunu Kontrol Etme

**Sözde Kod:**

```text
IF age >= 18 THEN
  PRINT "You are eligible to vote."
ELSE
  PRINT "You are not eligible to vote yet."
```

Bu kod, yaşın 18 veya daha büyük olup olmadığını kontrol eder. Doğruysa **"Oy kullanmaya uygunsunuz"** yazdırır; aksi halde **"Henüz oy kullanmaya uygun değilsiniz"** yazdırır.

---

## 🗂️ Kategorik İfadeler

Kategorik ifadeler, verileri belirli ölçütlere göre sınıflandırır ve gruplar; böylece daha kolay işleme ve karar verme için düzenlemeye yardımcı olur.

### 🎪 Örnek: Etkinlik Katılımcılarını Yaşa Göre Gruplama

**Sözde Kod:**

```text
Boş gruplar oluştur: Children, Teens, Adults
Liste içindeki her Age için:
  IF Age < 13 THEN
    Children grubuna ekle
  ELSE IF Age 13 AND 19 ARASINDAYSA THEN
    Teens grubuna ekle
  ELSE
    Adults grubuna ekle
RETURN Children, Teens, Adults
```

Bu kod, katılımcıları yaşlarına göre kategorilere ayırır.

---

## ⚖️ İkili Yapılar

İkili yapılar, evet/hayır veya doğru/yanlış gibi yalnızca iki olası sonucu olan kararları içerir ve kodda hızlı, verimli seçimler yapmanın temelidir.

### 🔞 Örnek: Yaş Sınırlı Etkinlikler İçin Katılımcıları Kategorize Etme

**Sözde Kod:**

```text
İki grup oluştur: "21 or older", "under 21"
Liste içindeki her age için:
  IF age >= 21 THEN
    "21 or older" grubuna ekle
  ELSE
    "under 21" grubuna ekle
RETURN "21 or older", "under 21"
```

Algoritma, katılımcıları 21 yaşında veya daha büyük olup olmamalarına göre iki gruba ayırır.

---

## ✅ Sonuç

Bu temel algoritma yapılarına—koşullu, kategorik ve ikili—hakim olarak geliştiriciler, programlamada karmaşık problemleri çözen açık, verimli ve etkili kodlar oluşturabilir.

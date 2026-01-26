## 📦 C#’ta Değişken Bildirimi

### 🧾 C#’ta Değişkenler

Değişkenler, geliştiricilerin veriyi verimli biçimde depolamasına, işlemesine ve yönetmesine olanak tanıyan C# programlamasında temel unsurlardır. Bu okuma, farklı değişken türlerini, nasıl bildirileceklerini ve sağlam kod yazmada *mutability* ile *immutability* kavramlarının rolünü ele alır.

---

## 🧠 Değişkenleri Anlamak

Değişkenler, bir programın belleğinde veriyi saklamak için kullanılan adlandırılmış depolama konumlarıdır. Program çalışırken gerektiğinde güncellemeye ve manipülasyona izin vererek geliştiricilerin dinamik veriyi yönetmesini sağlar. Değişkenler, kullanıcı girdileri, hesaplama sonuçları veya yapılandırma ayarları gibi verileri yönetmenin bir yolunu sunarak her C# uygulamasının temelini oluşturur.

---

## 🧩 Temel Değişken Türleri

* **Integer (int):** Tam sayıları saklar, örn. `int count = 10;`.
* **Double (double):** Ondalıklı sayısal değerleri tutar, örn. `double price = 19.99;`.
* **String (string):** Metin verisi için kullanılır, örn. `string name = "Alice";`.
* **Boolean (bool):** Doğru/yanlış değerlerini temsil eder, örn. `bool isValid = true;`.
* **Array:** Aynı türden değerlerin koleksiyonunu saklar, örn. `int[] scores = {10, 20, 30};`.

Her tür belirli amaçlara hizmet eder ve değişkenlerin tutarlı şekilde kullanılmasını sağlayarak kodda netlik ve hassasiyeti destekler.

---

## 🛠️ Değişkenleri Bildirme ve Başlatma

C#’ta bir değişken bildirmek, türünü belirtmeyi, ardından adını yazmayı ve isteğe bağlı olarak başlangıç değerini vermeyi içerir. Örneğin:

```csharp
int age = 25;
string message = "Hello, World!";
```

C# *type-safe* bir dildir; yani her değişken belirli bir veri türüyle bildirilmelidir. Bu, hataları önlemeye yardımcı olur ve kod okunabilirliğini artırır.

---

## 🔁 Mutable ve 🔒 Immutable Değişkenler

### 🔁 Mutable Değişkenler

Bildirimden sonra değeri değişebilen değişkenlerdir. Örneğin, `int counter = 1;` bildirimi, kodun ilerleyen kısmında `counter = 2;` şeklinde değiştirilebilir.

### 🔒 Immutable Değişkenler

Bir kez ayarlandıktan sonra değişemeyen değişkenlerdir. **const** anahtar kelimesiyle (derleme zamanı sabitleri için) veya **readonly** ile (çalışma zamanında atanan değerler için) bildirilir.

Örneğin:

```csharp
const double PI = 3.14159;
readonly int maxAttempts;
```

Bu anahtar kelimeler, değişken değerlerinin program çalışması boyunca tutarlı kalmasını sağlar.

---

## ✅ Değişken Yönetimi İçin En İyi Uygulamalar

* **Açıklayıcı isimler kullanın:** Kod okunabilirliğini artırmak için anlamlı isimler seçin. Örneğin, `x` yerine `userAge` kullanın.
* **Adlandırma kurallarını takip edin:** C#’ta yerel değişkenler ve metot parametreleri için *camelCase* kullanın (örn. `totalAmount`).
* **Doğru veri türlerini kullanın:** Değişkenin tutacağı veriye uygun veri türünü seçin. Bir *integer* değişkene *string* atamak gibi yanlış tür atamaları derleme zamanı hatası üretir.

---

## ✅ Sonuç

Değişkenleri doğru belirlemek ve etkili şekilde yönetmek, C# programlamasında kritik bir beceridir. Değişken türlerinde, *mutability* kavramında ve en iyi uygulamalarda ustalaşarak geliştiriciler; farklı senaryolarda güvenilir çalışan, daha anlaşılır, daha verimli ve hatasız kod yazabilirler.

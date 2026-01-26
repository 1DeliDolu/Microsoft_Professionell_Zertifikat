## 🧩 C#’ta Değişken Bildirme, Başlatma ve Atama

### 🎯 Amaç

C#’ta değişken bildirme, başlatma ve atama konusundaki anlayışı; uygun söz dizimiyle kod bloklarını tamamlayarak ve farklı veri türlerine değer atayarak pekiştirmek.

---

## 📝 Açıklama

Bu etkinlikte, C#’ta değişken bildirme ve başlatma pratiği yapacaksınız.  *Integer* ,  *string* , *double* ve *boolean* gibi farklı veri türleriyle çalışacaksınız. Amaç; bir ürün fiyatını veya bir kullanıcının admin olup olmadığını saklama gibi pratik örnekler üzerinden değişken bildirimi ve atamayı güçlendirmektir.

---

## ✅ Örnek 1: Integer Değişken Bildirme ve Başlatma

**Problem İfadesi:**
Bir sınıftaki öğrenci sayısını saklayacak bir değişken bildirmemiz ve ona 25 başlangıç değerini atamamız gerekiyor.

### 1) Açıklama

* **Adım 1: Veri türünü seçme:** Öğrenci sayısı tam sayı olduğu için *int* uygundur.
* **Adım 2: Değişkeni bildirme:** C#’ta veri türü + değişken adı yazılır: `int numberOfStudents`
* **Adım 3: Değişkeni başlatma:** Bildirim sırasında `=` ile 25 değeri atanır.

### 2) Kod Örneği

```csharp
int numberOfStudents = 25;
```

### 3) Kod Açıklaması

* `int` veri türünü belirtir.
* `numberOfStudents` değişken adıdır.
* `=` atama operatörüdür.
* `25` değişkene atanan değerdir.

---

## ✅ Örnek 2: String Değişken Bildirme ve Başlatma

**Problem İfadesi:**
Bir dersin adını saklayacak bir değişken oluşturup başlangıç değerini **"Introduction to Programming"** olarak atamamız gerekiyor.

### 1) Açıklama

* **Adım 1: Veri türünü seçme:** Ders adı metin olduğu için *string* uygundur.
* **Adım 2: Değişkeni bildirme:** `string courseName`
* **Adım 3: Değişkeni başlatma:** Metin değerleri çift tırnak içinde yazılır.

### 2) Kod Örneği

```csharp
string courseName = "Introduction to Programming";
```

### 3) Kod Açıklaması

* `courseName` değişken adıdır.
* `string` veri türünü belirtir.
* `=` atama operatörüdür.
* `"Introduction to Programming"` çift tırnak içinde olduğu için string değerdir.

---

## 🧪 Problem 1: Double Değişken Bildirme ve Başlatma

**Problem İfadesi:**
Bir ürünün fiyatını saklayacak bir değişken bildirin ve başlangıç değeri olarak 49.99 atayın.

### 2) Değişkeni Kodlayın

```csharp
double productPrice = 49.99;
```

---

## 🧪 Problem 2: Boolean Değişken Bildirme ve Başlatma

**Problem İfadesi:**
Bir kullanıcının admin olup olmadığını belirten bir bayrağı saklayacak bir değişken bildirin ve başlangıç değerini true yapın.

### 2) Kod Çözümünüz

```csharp
bool isAdmin = true;
```

## 🧩 Using Parameters in Methods

### 📝 Introduction

Metotlardaki parametreler, metot içine veri ( *arguments* ) geçirilmesine izin vererek esneklik sağlar. Bu, metotların farklı girdiler üzerinde çalışmasına olanak tanır; böylece kod daha yeniden kullanılabilir ve daha uyarlanabilir hâle gelir.

---

## ❓ What Are Parameters?

Parametreler, bir metodun imzası ( *signature* ) içinde tanımlanan ve metodun hangi girdileri kabul edebileceğini belirten değişkenlerdir. Metot çağrıldığında metoda geçirilecek değerler (argümanlar) için yer tutucu ( *placeholder* ) görevi görürler.

Bu durum metotları daha esnek hâle getirir; çünkü metot, farklı girdilere göre belirli görevleri yerine getirebilir ve metodu yeniden yazmaya gerek kalmaz.

---

## 🧱 Types of Parameters

### 🟦 Value Parameters

* Argümanın bir kopyasını alır.
* Metot içinde parametre üzerinde yapılan değişiklikler, orijinal argümanı etkilemez.

### 🟨 Reference Parameters

* Orijinal argümana bir referans alır.
* Metot içinde yapılan değişiklikler, orijinal değeri etkiler.

---

## 📥 How to Pass Data into Methods

Metot imzası parametreleri tanımlar ve metot çağrıldığında, parametre türleriyle eşleşen argümanlar geçirilir.

---

## 👤 Example: Single Parameter

```csharp
public void GreetUser(string userName) {
    MessageBox.Show("Hello, " + userName + "!");
}
GreetUser("Alice");
```

**Output:** `"Hello, Alice!".`

---

## 🧾 Example: Multiple Parameters

```csharp
public void GreetUser(string userName, int lastLogin) {
    MessageBox.Show("Hello, " + userName + "! It's been " + lastLogin + " days since you last logged in.");
}
GreetUser("Alice", 2);
```

**Output:** `"Hello, Alice! It's been 2 days since you last logged in".`

---

## 🏁 Conclusion

Parametreler, metotların çeşitli girdileri işlemesini sağlayarak daha esnek ve yeniden kullanılabilir kod oluşturur. Parametreleri nasıl tanımlayacağınızı ve nasıl geçireceğinizi anlamak, uyarlanabilir metotlar oluşturmanın temelidir.

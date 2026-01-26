## 🧩 Metot Çağırmanın Pratik Uygulaması

### 📝 Introduction

C#’ta metot çağırmak, kodu yeniden kullanmanızı sağlar; böylece programlarınız daha verimli olur ve yönetmesi daha kolay hâle gelir. Bu özet; C#’ta metotları tanımlamayı, çağırmayı ve kullanmayı; ayrıca dönüş değerlerini yönetmeyi ve argüman geçirmeyi kapsar.

---

## 📞 Basics of Calling Methods

Bir metot, bir görevi yerine getirmek için tasarlanmış yeniden kullanılabilir bir kod bloğudur. Metot; adını, dönüş türünü ve parametrelerini tanımlayan bir *header* ile asıl kodu içeren bir  *body* ’den oluşur. Bir metodu çağırmak için, adını yazıp ardından parantez ekleyin; gerekiyorsa argümanları geçin:

```csharp
int result = AddNumbers(5, 10);
```

Bu örnek, **AddNumbers** metodunu çağırır; argüman olarak **5** ve **10** geçirir ve sonucu **result** değişkeninde saklar.

---

## ↩️ Method Return Values

Metotlar çoğu zaman dönüş değerleri döndürür ve bu değerler header’daki *return type* ile tanımlanır. Eğer bir metot hiçbir şey döndürmüyorsa **void** kullanır. Örneğin, aşağıdaki **GetNumber** metodu *integer* olarak **42** döndürür:

```csharp
public int GetNumber() {
    return 42;
}
```

**return** ifadesi bu değeri, metodu çağıran koda geri gönderir.

---

## 📥 Passing Arguments to Methods

Metotlar, argümanlar aracılığıyla giriş verisi kabul edebilir. Bu argümanların, metotta tanımlanan parametrelerle eşleşmesi gerekir. Örneğin, **CalculateSum** metoduna iki *integer* argüman geçirilir:

```csharp
int sum = CalculateSum(5, 10);
```

Bu metot, iki sayının toplamını döndürür.

---

## 🧪 Practical Examples of Calling Methods

### 👋 Displaying a Welcome Message

```csharp
public void DisplayWelcomeMessage() {
    MessageBox.Show("Welcome to GreenWay!");
}
```

Bu metot argümansız çağrılır ve bir karşılama mesajı görüntüler.

---

### ➕ Calculating a Sum

```csharp
public int CalculateSum(int a, int b) {
    return a + b;
}
```

Bu metot iki sayıyı toplar ve sonucu döndürür.

---

### 🔞 Validating User Age

```csharp
public bool IsUserOldEnough(int age) {
    return age >= 18;
}
```

Bu metot, bir kullanıcının belirli özelliklere erişmek için yeterince büyük olup olmadığını kontrol eder ve **true** veya **false** döndürür.

---

## 🏁 Conclusion

C#’ta metot çağırmada ustalaşmak, modüler ve verimli kod yazmanızı sağlar. Metotları tanımlamayı, argüman geçirmeyi ve dönüş değerlerini yönetmeyi anlamak; sürdürülebilir ve yeniden kullanılabilir programlar geliştirmek için gereklidir.

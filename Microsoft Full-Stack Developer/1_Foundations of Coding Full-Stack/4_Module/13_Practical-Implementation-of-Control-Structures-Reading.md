## 🛠️ Practical Implementation of Control Structures

Bu okuma, *iç içe (nested)* ve *zincirleme (chained) if-else ifadelerinin* ileri kullanımlarını, *karmaşık switch ifadelerini* ve bunların gerçek dünya senaryolarındaki uygulamalarını kapsar.

---

## 🧱 Nested If-Else Statements

 *İç içe if-else ifadeleri* , bir if-else’in başka bir if-else’in içine yerleştirilmesiyle karmaşık kararları yönetir. Bu yaklaşım, eylemler birden fazla koşula bağlı olduğunda faydalıdır.

Örneğin, bir mağaza toplam satın alma tutarı ve müşteri üyeliğine göre indirim sunabilir. Program önce satın alma tutarını kontrol eder; bir eşiği karşılıyorsa, ek indirim uygulamak için üyeliği kontrol eder.

Ancak, iç içe if-else ifadelerinin aşırı kullanımı, bakımı zor *"spaghetti code"* oluşturabilir. Bunları yalnızca bağımlı koşulları yönetmek için gerekli olduğunda kullanın.

---

## 🔗 Chained If-Else Statements

 *Zincirleme if-else ifadeleri* , birbirini dışlayan (mutually exclusive) birden fazla koşul için daha uygundur. Her koşulu sırayla kontrol eder ve kodu okunabilir ve düzenli tutar.

Örneğin, konuma göre kargo maliyetini hesaplayan bir program önce konumun `"local"` olup olmadığını, sonra `"domestic"` olup olmadığını vb. kontrol eder. Bu yöntem, koşullar bağımsız olduğunda verimlidir.

---

## 🍝 Spaghetti Code’dan Kaçınma İpuçları

* Koşulları daha küçük parçalara ayırarak basitleştirin.
* Mantığı fonksiyonlar içinde kapsülleyin.
* Her koşulun amacını açıklamak için yorumlar ekleyin.

---

## 🎛️ Complex Switch Statements

 *Switch ifadeleri* , tek bir değişkenin değerine göre birden fazla koşulu verimli şekilde ele alır; bu da onları çok sayıda olası sonucun olduğu durumlar için ideal kılar.

---

## 🧩 Birden Fazla Case’i Birleştirme

Farklı case’ler aynı eylemi gerektirdiğinde (örneğin `"Monday"` ve `"Wednesday"` aynı yemek önerisini paylaşıyorsa), tekrarları azaltmak için bir switch ifadesinde birleştirilebilirler:

```csharp
switch (day) {
    case "Monday":
    case "Wednesday":
        Console.WriteLine("Eat cereal");
        break;
}
```

---

## 🧬 Pattern Matching

Switch ifadeleri, belirli kriterleri karşılayan girdileri ele almak için *pattern matching* kullanabilir; örneğin bir string’in `"jazz"` veya `"rock"` içerip içermediğini kontrol edip buna göre yanıt vermek gibi.

---

## 🧯 Default Case

 *Default case* , belirtilen case’lerle eşleşmeyen herhangi bir girdiyi yönetir ve programın beklenmedik değerleri zarif biçimde ele almasını sağlar; örneğin hiçbir konum önceden tanımlanmış değerlerle eşleşmiyorsa standart kargo uygulamak gibi.

---

## 🌍 Gerçek Dünya Senaryolarındaki Uygulamalar

*If-else ifadeleri* ve *switch case’ler* gibi kontrol yapıları, pratik programlama görevleri için kritik öneme sahiptir:

---

## 📦 Inventory Management

Stok seviyelerine göre bir ürünü yeniden sipariş edip etmeyeceğine karar vermek için if-else kullanın:

```csharp
if (stockLevel < reorderThreshold) {  
    reorderProduct();
} else {
    maintainCurrentStock();
}
```

---

## 🚚 Order Processing

Müşteri konumuna göre kargo yöntemini belirlemek için switch kullanın:

```csharp
switch (location) {
    case "local": 
        applyLocalShipping(); 
        break;
    case "domestic": 
        applyDomesticShipping(); 
        break;
    case "international": 
        applyInternationalShipping(); 
        break;
    default: 
        applyStandardShipping(); 
        break;
}
```

---

## 💳 Discount Application

Satın alma tutarı ve üyeliğe göre indirim uygulamak için iç içe if-else kullanın:

```csharp
if (totalAmount > 100) {
    if (isMember) applyMemberDiscount();
    else applyRegularDiscount();
} else {
    applyNoDiscount();
}
```

---

## ✅ Conclusion

*İç içe ve zincirleme if-else* ile *karmaşık switch ifadeleri* gibi gelişmiş koşullu ifadeler, karmaşık programlama mantığını yönetmek için gereklidir.

Bu yapıları etkili biçimde uygulayarak geliştiriciler, kodun verimli, okunabilir ve bakımı kolay kalmasını sağlar.

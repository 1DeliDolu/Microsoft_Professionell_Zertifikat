## 🧩 Algoritmaları C# Koduna Çevirme

### 🎯 Amaç

Yapılandırılmış örnekleri takip ederek ve problemleri çözerek sözde kod ( *pseudocode* ) hâlindeki algoritmaları çalışan C# koduna çevirmek.

---

## 📝 Açıklama

Bu etkinlikte, algoritmaları uygulayarak sözde kodu işlevsel C# koduna çevireceksiniz. Bir dizideki en büyük sayıyı bulma ve bir sayının tek mi çift mi olduğunu kontrol etme gibi örneklerle pratik yapacaksınız. Ardından, bir dizinin toplamını hesaplama ve bir string içindeki sesli harfleri sayma gibi problemleri çözmek için bu becerileri uygulayacaksınız.

---

## ✅ Örnek 1: Bir Dizideki En Büyük Sayıyı Bulma

### Problem İfadesi

Verilen bir *integer* dizisindeki en büyük sayıyı bulmak için bir algoritma yazın.

---

### 1) Sözde Kod ( *Pseudocode* )

Start
Create variable largest and set it to the first number in the array
For each number in the array
    If number is greater than largest
        Set variable largest to number
End For
Display to user value of variable largest
End

---

### 2) Çeviri ( *Translation* )

* **Başlatma:** `numbers` dizisi bazı tamsayı değerlerle tanımlanır ve `largest` dizinin ilk elemanına eşitlenir.
* **Döngü:** Dizideki her elemanı dolaşmak için `foreach` döngüsü kullanılır.
* **Karşılaştırma:** `if` ifadesi, mevcut sayının `largest`’tan büyük olup olmadığını kontrol eder. Büyükse `largest` güncellenir.
* **Çıktı:** Döngü bittiğinde en büyük sayı yazdırılır.

---

### 3) C# Kodu

```csharp
// Initialize an array of integers
int[] numbers = { 5, 8, 3, 4, 2 };
int largest = numbers[0];

// Loop through each number in the array
foreach (int number in numbers)
{
    // Check if the current number is greater than the largest
    if (number > largest)
    {
        largest = number;
    }
}

// Output the largest number
Console.WriteLine("The largest number is: " + largest);
```

---

## ✅ Örnek 2: Bir Sayının Tek mi Çift mi Olduğunu Kontrol Etme

### Problem İfadesi

Verilen bir sayının tek mi çift mi olduğunu kontrol etmek için bir algoritma yazın.

---

### 1) Sözde Kod ( *Pseudocode* )

Start
Ask user for number
If remainder of number divided by 2 is equal to 0
    Display "Number is even"
Otherwise
    Display "Number is odd"
End

---

### 2) Çeviri ( *Translation* )

* **Başlatma:** `number` değişkeni 42 olarak ayarlanır.
* **Koşul Kontrolü:** `if` ifadesi, `%` (modulus) operatörüyle sayının 2’ye bölümünden kalanının 0 olup olmadığını kontrol eder.
* **Çıktı:** Sonuca göre `"The number is even."` veya `"The number is odd."` yazdırılır.

---

### 3) C# Kodu

```csharp
// Declare and initialize a number
int number = 42;

// Check if the number is even or odd
if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}
```

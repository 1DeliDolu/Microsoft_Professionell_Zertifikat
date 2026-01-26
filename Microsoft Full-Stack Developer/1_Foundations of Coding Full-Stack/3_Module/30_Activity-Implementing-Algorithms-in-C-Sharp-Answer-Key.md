## 🧾 Etkinlik: C#’ta Algoritmaları Uygulama - Cevap Anahtarı

---

## ➕ Problem 1: Bir Dizinin Toplamını Hesaplama

```csharp
// Initialize an array of integers
int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

// Loop through each number in the array
foreach (int number in numbers)
{
    // Add each number to the sum
    sum += number;
}

// Output the sum
Console.WriteLine("The sum of the array is: " + sum);
```

---

## 🔤 Problem 2: Bir String İçindeki Sesli Harf Sayısını Sayma

```csharp
// Initialize a string
string text = "Hello World";
int vowelCount = 0;

// Loop through each character in the string
foreach (char c in text.ToLower())
{
    // Check if the character is a vowel
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    {
        vowelCount++;
    }
}

// Output the number of vowels
Console.WriteLine("The number of vowels is: " + vowelCount);
```

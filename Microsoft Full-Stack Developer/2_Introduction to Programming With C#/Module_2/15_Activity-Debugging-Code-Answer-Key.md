## 🧩 Etkinlik: Kodda Hata Ayıklama - Cevap Anahtarı

### ✅ Problem 1: İndirim Hesaplama

#### 🔎 Hatayı Belirleme

Kod, indirim yüzdesini doğrudan fiyattan çıkarıyor; indirim tutarını yüzde olarak hesaplamıyor.

#### ✅ Düzeltilmiş Kod

```csharp
using System;
public class Program
{
    // Method to calculate the final price after a discount
    public static double ApplyDiscount(double price, double discountPercentage)
    {
        double discountAmount = price * (discountPercentage / 100);
        return price - discountAmount;
    }

    public static void Main()
    {
        double finalPrice = ApplyDiscount(1000, 15);
        Console.WriteLine("The final price is: " + finalPrice);
    }
}
```

---

### ✅ Problem 2: Dizideki En Büyük Sayıyı Bulma

#### 🔎 Hatayı Belirleme

Kod, `max` değişkenini `0` ile başlatıyor. Dizideki tüm sayılar negatif olduğunda bu durum hatalı sonuç üretir.

#### ✅ Düzeltilmiş Kod

```csharp
public class Program
{
    public static int FindMax(int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static void Main()
    {
        int[] myNumbers = { -5, -10, -3, -8, -2 };
        int maxNumber = FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
}
```

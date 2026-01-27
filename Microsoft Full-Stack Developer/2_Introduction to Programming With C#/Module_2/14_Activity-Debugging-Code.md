## 🐞 Kodda Hata Ayıklama

### 🎯 Amaç

Breakpoint ayarlama, değişken değerlerini inceleme ve kodda adım adım ilerleme gibi temel hata ayıklama tekniklerini ve araçlarını kullanarak hataları tespit etmeyi ve düzeltmeyi göstermek.

---

## 🧾 Açıklama

Bu etkinlik, C# kodunda hata ayıklama sürecinde katılımcılara rehberlik edecektir; hataları belirleme, nedenlerini anlama ve düzeltmeleri uygulama adımlarını kapsar. İki adet tamamen hata ayıklanmış örnekle başlayacak, ardından öğrenenlerin çözmesi için iki ek hata ayıklama problemi sunacaktır.  *Sözdizimi (syntax)* , *çalışma zamanı (runtime)* ve *mantıksal (logical)* hatalar gibi yaygın hata türleri ele alınacaktır.

---

## ⚙️ Ortamınızı Kurun

* Kursun başında oluşturduğunuz **Visual Studio Code** konsol uygulamasını kullanın.
* Konsol uygulamanızdaki `Program.cs` dosyasındaki mevcut kodları kaldırın.
* Bu etkinlikteki kodu `Program.cs` dosyasına kopyalayıp düzenleyerek adımları tamamlayın.

---

## ➗ Örnek 1: İki Sayıyı Bölme

### 🧩 Problem

Aşağıdaki kod iki sayıyı bölüp sonucu yazdırmak içindir. Ancak payda `0` olduğunda bir çalışma zamanı ( *runtime* ) hatası oluşur.

```csharp
// Method to divide two numbers
using System;
public class Program
{
public static int DivideNumbers(int numerator, int denominator)
{
    int result = numerator / denominator;
    return result;
}

public static void Main()
{
    // Attempt to divide 10 by 0
    int result = DivideNumbers(10, 0);
    Console.WriteLine("The result is: " + result);
}
}
```

### 🧭 Debug Adımları

* **Hata Tespiti:** Kodu çalıştırınca, sıfıra bölme mümkün olmadığı için çalışma zamanı hatası oluşur ve “infinity” benzeri bir değer veya çökme meydana gelir.
* **Breakpoint Koy:** Bölme satırına breakpoint koy: `int result = numerator / denominator;`
* **Değişkenleri İncele:** Debugger ile `denominator` değerinin `0` olup olmadığını kontrol et. Eğer `0` ise hatanın nedeni budur.
* **Hata Yönetimi Ekle:** Bölme işleminden önce `0` kontrolü yap; hata mesajı veya alternatif bir değer döndür.

### ✅ Düzeltilmiş Kod

```csharp
// Method to divide two numbers with error handling
using System;
public class Program
{
public static double DivideNumbers(double numerator, double denominator)
{
    if (denominator == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
        return double.NaN; // Return "Not a Number" to indicate an error
    }
  
    double result = numerator / denominator;
    return result;
}

public static void Main()
{
    // Attempt to divide 10 by 0
    double result = DivideNumbers(10, 0);
    Console.WriteLine("The result is: " + result);
}
}
```

### ✅ Kodu Test Et

Programı tekrar çalıştırın ve sıfıra bölmenin artık çökme olmadan doğru şekilde ele alındığını doğrulayın.

---

## 📊 Örnek 2: Dizinin Ortalama Değerini Hesaplama

### 🧩 Problem

Aşağıdaki kod, bir sayı dizisinin ortalamasını hesaplar. Ancak dizi boş olduğunda çalışma zamanı hatası oluşur.

```csharp
using System;
public class Program
{
// Method to calculate the average of an array
public static double CalculateAverage(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum / numbers.Length;
}

public static void Main()
{
    int[] numbers = {}; // Empty array
    double average = CalculateAverage(numbers);
    Console.WriteLine("The average is: " + average);
}
}
```

### 🧭 Debug Adımları

* **Hata Tespiti:** `numbers.Length` boş dizide `0` olacağı için `sum / numbers.Length` satırında sıfıra bölme hatası oluşur.
* **Breakpoint Koy:** `return sum / numbers.Length;` satırına breakpoint koy.
* **Değişkenleri İncele:** `numbers.Length` değerini kontrol et. `0` ise hata nedeni budur.
* **Hata Yönetimi Ekle:** `numbers.Length == 0` kontrolüyle uygun bir mesaj ver ve uygun bir değer döndür.

### ✅ Düzeltilmiş Kod

```csharp
using System;
public class Program
{
// Method to calculate the average of an array with error handling
public static double CalculateAverage(int[] numbers)
{
    if (numbers.Length == 0)
    {
        Console.WriteLine("Error: Cannot calculate the average of an empty array.");
        return double.NaN; // Return "Not a Number" to indicate an error
    }

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return (double)sum / numbers.Length;
}

public static void Main()
{
    int[] numbers = {}; // Empty array
    double average = CalculateAverage(numbers);
    Console.WriteLine("The average is: " + average);
}
}
```

### ✅ Kodu Test Et

Programı tekrar çalıştırın ve boş dizi durumunun artık çökmeden düzgün şekilde ele alındığını doğrulayın.

---

## 🧩 Tamamlanacak Problemler

## 💸 Problem 1: İndirim Hesaplama

### 🧾 Problem Açıklaması

Aşağıdaki kod, bir ürüne indirim uyguladıktan sonra nihai fiyatı hesaplamayı amaçlar. Ancak mantıksal bir hata nedeniyle doğru çıktı üretmez.

```csharp
public class Program
{
// Method to calculate the final price after a discount
public static double ApplyDiscount(double price, double discountPercentage)
{
    return price - discountPercentage;
}

public static void Main()
{
    double finalPrice = ApplyDiscount(1000, 15);
    Console.WriteLine("The final price is: " + finalPrice);
}
}
```

### 📌 Talimatlar

* `ApplyDiscount` metodundaki hatayı belirleyin.
* Debugger ile değerleri inceleyerek neden çıktının yanlış olduğunu anlayın.
* İndirimi, orijinal fiyatın yüzdesi olarak hesaplayacak şekilde kodu düzeltin.

---

## 🔝 Problem 2: Dizideki En Büyük Sayıyı Bulma

### 🧾 Problem Açıklaması

Aşağıdaki kod, bir dizideki en büyük sayıyı bulmaya çalışır. Ancak tüm sayılar negatif olduğunda yanlış sonuç üretmesine neden olan mantıksal bir hata içerir.

```csharp
public class Program
{
    public static int FindMax(int[] numbers)
    {
        int max = 0;
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

### 📌 Talimatlar

* `FindMax` metodunun negatif sayılardan oluşan dizide neden başarısız olduğunu belirleyin.
* Breakpoint ve değişken inceleme ile sorunu bulun.
* Tüm sayılar negatif olsa bile en büyük değeri doğru bulacak şekilde kodu düzeltin.

## 🚀 Introduction to Functions in Programming

### 🎯 Objective

Fonksiyonları kullanarak yeniden kullanılabilir kod blokları oluşturmak.

---

## 🧩 Example 1: Writing a Function to Calculate the Area of a Rectangle

### 📝 Problem Statement

Bir dikdörtgenin alanını hesaplayan bir fonksiyon yazın. Fonksiyon, iki giriş parametresi kabul etmelidir: dikdörtgenin *length* ve *width* değerleri. Program kullanıcıdan bu değerleri isteyecek, alanı hesaplamak için fonksiyonu kullanacak ve ardından sonucu görüntüleyecektir.

---

## 🧱 Step-by-Step Code Construction

### 🧩 Step 1: Define the Function to Calculate the Rectangle's Area

*length* ve *width* olmak üzere iki parametre alan ve dikdörtgenin alanını döndüren bir fonksiyon yazın.

**Code:**

```csharp
double CalculateRectangleArea(double length, double width)
{
    return length * width;
}
```

### 📝 Explanation

**double CalculateRectangleArea:** Bu satır, *double* türünde bir değer döndüren bir fonksiyon tanımlar. Fonksiyonun adı  **CalculateRectangleArea** ’dır. Parantezlerin içinde iki parametre tanımlarız: **length** ve  **width** . Bu parametreler, dikdörtgenin uzunluğunu ve genişliğini temsil eder ve fonksiyon çağrıldığında fonksiyona geçirilir.

**return length * width:** Bu satır, *length* ile *width* çarpımını döndürür; bu da dikdörtgenin alanını hesaplar.

---

## 📞 Step 2: Call the Rectangle Area Function

Kullanıcıdan dikdörtgenin uzunluğunu ve genişliğini girmesini isteyin, **CalculateRectangleArea** fonksiyonunu çağırın ve alanı yazdırın.

**Code:**

```csharp
Console.WriteLine("Enter the length of the rectangle:");double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the width of the rectangle:");double width = Convert.ToDouble(Console.ReadLine());

double area = CalculateRectangleArea(length, width);
Console.WriteLine("The area of the rectangle is: " + area);
```

### 📝 Explanation

**Convert.ToDouble(Console.ReadLine()):** Bu, kullanıcının girişini bir *string* olarak okur ve bunu  *double* ’a dönüştürür; böylece matematiksel hesaplamalar yapabiliriz.

**CalculateRectangleArea(length, width):** Bu, kullanıcı girişleriyle **CalculateRectangleArea** fonksiyonunu çağırır. Fonksiyon dikdörtgenin alanını hesaplar ve sonucu döndürür.

**Console.WriteLine("The area of the rectangle is: " + area):** Bu, hesaplanan alanı konsola yazdırır.

---

## 🧾 Step Statement: Full Code for Rectangle Area Calculation

Artık fonksiyonu tanımladığımıza ve nasıl çağıracağımızı öğrendiğimize göre, dikdörtgen alanı hesaplaması için tam kod bloğunu birlikte çalıştırabiliriz. Bu blok; kullanıcı girdisini, fonksiyon tanımını ve konsola çıktıyı içerir.

---

## 🧩 Full Code Block: Rectangle Area Function

### 1. Dikdörtgenin alanını hesaplamak için fonksiyonu oluşturun:

```csharp
double CalculateRectangleArea(double length, double width)
{
    return length * width;
}
```

### 2. Kullanıcıdan uzunluk ve genişlik girmesini isteyin:

```csharp
Console.WriteLine("Enter the length of the rectangle:");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the width of the rectangle:");
double width = Convert.ToDouble(Console.ReadLine());
```

### 3. Alanı hesaplamak için fonksiyonu çağırın:

```csharp
double area = CalculateRectangleArea(length, width);
```

### 4. Sonucu ekrana yazdırın:

```csharp
Console.WriteLine("The area of the rectangle is: " + area);
```

---

## 🧪 Kodu Çalıştırma

Kodunuzu doğrudan **Dot Net Fiddle** üzerinde taslak olarak hazırlayıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin düzenleyici de kullanabilirsiniz, ancak **DotNetFiddle** kodunuzu hızlıca test etmek ve çalıştırmak için harikadır.

Aşağıdaki kodu çalıştırmak isterseniz,  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodu sol tarafa yapıştırın ve **run** seçeneğini seçin.

---

## 💻 Full Program Code

```csharp
using System;

class Program
{
    // Function to calculate the area of a rectangle
    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    static void Main(string[] args)
    {
        // Prompt the user to input the length and width
        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateRectangleArea(length, width);

        // Output the result
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}
```

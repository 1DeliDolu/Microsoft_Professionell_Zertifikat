## 🧩 Activity: Introduction to Functions in Programming - Answer Key

---

## 🟠 Problem 1: Creating a Function for Circle Area Calculation

### 🧱 1. Dairenin Alanını Hesaplayan Fonksiyonu Oluşturun

```csharp
double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}
```

---

### 📝 2. Kullanıcıdan Yarıçap Değerini Girmesini İsteyin

```csharp
Console.WriteLine("Enter the radius of the circle:");
double radius = Convert.ToDouble(Console.ReadLine());
```

---

### 📞 3. Alanı Hesaplamak İçin Fonksiyonu Çağırın

```csharp
double area = CalculateCircleArea(radius);
```

---

### 🖨️ 4. Sonucu Yazdırın

```csharp
Console.WriteLine("The area of the circle is: " + area);
```

---

### 🧪 Tam Kod Bloğunu Çalıştırma

Tam kod bloğunu çalıştırmak isterseniz,  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, aşağıdaki kodu sol tarafa yapıştırın ve **run** seçeneğini seçin.

```csharp
using System;

public class Program
{
    // Function to calculate the area of a circle
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static void Main()
    {
        // Prompt the user to input the radius
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateCircleArea(radius);

        // Output the result
        Console.WriteLine("The area of the circle is: " + area);
    }
}
```

---

## 🟦 Problem 2: Trapezoid Area Calculation

### 🧱 1. Yamuk Alanını Hesaplayan Fonksiyonu Oluşturun

```csharp
double CalculateTrapezoidArea(double a, double b, double height)
{
    return (a + b) / 2 * height;
}
```

---

### 📝 2. Kullanıcıdan Paralel Kenar Uzunluklarını ve Yüksekliği Girmesini İsteyin

```csharp
Console.WriteLine("Enter the length of the first parallel side (a):");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the length of the second parallel side (b):");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the height of the trapezoid:");
double height = Convert.ToDouble(Console.ReadLine());
```

---

### 📞 3. Alanı Hesaplamak İçin Fonksiyonu Çağırın

```csharp
double area = CalculateTrapezoidArea(a, b, height);
```

---

### 🖨️ 4. Sonucu Yazdırın

```csharp
Console.WriteLine("The area of the trapezoid is: " + area);
```

---

### 🧪 Tam Kod Bloğunu Çalıştırma

Tam kod bloğunu çalıştırmak isterseniz,  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, aşağıdaki kodu sol tarafa yapıştırın ve **run** seçeneğini seçin.

```csharp
using System;

public class Program
{
    // Function to calculate the area of a trapezoid
    static double CalculateTrapezoidArea(double a, double b, double height)
    {
        return (a + b) / 2 * height;
    }

    public static void Main()
    {
        // Prompt the user to input the length of the first parallel side (a)
        Console.WriteLine("Enter the length of the first parallel side (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the length of the second parallel side (b)
        Console.WriteLine("Enter the length of the second parallel side (b):");
        double b = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the height of the trapezoid
        Console.WriteLine("Enter the height of the trapezoid:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateTrapezoidArea(a, b, height);

        // Output the result
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}
```

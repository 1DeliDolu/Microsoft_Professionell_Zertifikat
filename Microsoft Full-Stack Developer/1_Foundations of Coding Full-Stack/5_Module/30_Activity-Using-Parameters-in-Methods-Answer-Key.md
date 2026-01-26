## 🧩 Activity: Using Parameters in Methods - Answer Key

---

## 🟣 Problem 1: Calculate the Volume of a Rectangular Box

```csharp
using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the length of the box:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the box:");
        int width = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter the height of the box:");
        int height = int.Parse(Console.ReadLine());

        int volume = CalculateVolume(length, width, height);
        Console.WriteLine("The volume of the rectangular box is: " + volume);
    }
    public static int CalculateVolume(int length, int width, int height)
    {
        int volume = length * width * height;
        return volume;
    }
}
```

---

## 🟤 Problem 2: Calculate the Average of Three Numbers

```csharp
using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter third number:");
        int num3 = int.Parse(Console.ReadLine());

        int average = CalculateAverage(num1, num2, num3);
        Console.WriteLine("The average is: " + average);
    }
    public static int CalculateAverage(int num1, int num2, int num3)
    {
        int average = (num1 + num2 + num3) / 3;
        return average;
    }
}
```

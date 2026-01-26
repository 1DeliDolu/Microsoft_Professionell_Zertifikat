## 🧩 Activity: Methods in C# - Answer Key

---

## 🟠 Problem 1: Creating a Function for Circle Area Calculation

```csharp
using System;
class Program {
    static void Main() {
        // Prompt the user for the radius of the circle
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area and store the result in 'area'
        double area = CalculateCircleArea(radius);

        // Output the result
        Console.WriteLine("The area of the circle is: " + area);
    }

    // Define the method to calculate the circle's area
    static double CalculateCircleArea(double radius) {
        return Math.PI * radius * radius;
    }
}
```

---

## 🟦 Problem 2: Trapezoid Area Calculation

```csharp
using System;

public class Program {
    public static void Main() {
        // Prompt the user for the lengths of the two parallel sides and the height
        Console.WriteLine("Enter the length of the first parallel side (a):");
        decimal a = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the length of the second parallel side (b):");
        decimal b = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Call the function to calculate the area and store the result in 'area'
        decimal area = CalculateTrapezoidArea(a, b, height);

        // Output the result
        Console.WriteLine("The area of the trapezoid is: " + area);
    }

    // Define the method to calculate the trapezoid's area
    static decimal CalculateTrapezoidArea(decimal a, decimal b, decimal height) {
        return (a + b) / 2 * height;
    }
}
```

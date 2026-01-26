## 🧩 Using Parameters in Methods

### 🎯 Objective

C#’ta metotlar ve parametreleri kullanarak temel hesaplamalar yapan yeniden kullanılabilir kod blokları oluşturmak.

---

## 🟦 Example 1: Basic Method – Calculating the Area of a Rectangle

### 📝 Problem Statement

C#’ta bir dikdörtgenin alanını hesaplayan bir metot yazmanız gerekiyor. Metot iki *integer* parametre kabul etmelidir: **length** ve  **width** . Metot, iki parametrenin çarpımı olan alanı döndürmelidir.

---

## 🧱 Step 1: Define the Method with Parameters

```csharp
public static int CalculateArea(int length, int width)
{
// Code to calculate area
}
```

### 📝 Explanation

* **public:** Metot, sınıfının dışından erişilebilir.
* **static:** Metot veya değişken, herhangi bir sınıf örneğine değil sınıfın kendisine aittir.
* **int:** Metodun bir *integer* değer döndüreceğini belirtir.
* **CalculateArea:** Metodun adıdır ve işlevini tanımlar.
* **int length, int width:** Bunlar metodun parametreleridir. Metot çağrılırken **length** ve **width** değerlerini geçirmenizi sağlar.

---

## 🧮 Step 2: Implement the Logic to Calculate the Area

```csharp
public static int CalculateArea(int length, int width)
{
int area = length * width;
return area;
}
```

### 📝 Explanation

* **int area = length * width;:** Bu satır, **length** ve **width** parametrelerini çarpar ve sonucu **area** adlı bir değişkende saklar.
* **return area;:** Bu satır, hesaplanan alanı metoda çağıran koda geri döndürür.

---

## ▶️ Step 3: Use the Method in the Main Program

```csharp
using System;

public class Program
{
    // The Main method: Entry point of the program
    public static void Main()
    {
        // Prompt the user for the length of the rectangle
        Console.WriteLine("Enter the length of the rectangle:");
        int length = int.Parse(Console.ReadLine());

        // Prompt the user for the width of the rectangle
        Console.WriteLine("Enter the width of the rectangle:");
        int width = int.Parse(Console.ReadLine());

        // Call the function to calculate the area and store the result in 'area'
        int area = CalculateArea(length, width);

        // Output the result
        Console.WriteLine("The area of the rectangle is: " + area);
    }

    // Define the method to calculate the rectangle's area
    public static int CalculateArea(int length, int width)
    {
        int area = length * width; 
        return area;
    }
}
```

### 📝 Explanation

* **Console.WriteLine("Enter the length of the rectangle:");:** Kullanıcıdan girdi ister.
* **int length = int.Parse(Console.ReadLine());:** Kullanıcı girdisini okur ve  *integer* ’a dönüştürür.
* **int area = CalculateArea(length, width);:** Kullanıcı girdilerini argüman olarak geçirerek **CalculateArea** metodunu çağırır.
* **Console.WriteLine("The area of the rectangle is: " + area);:** Sonucu ekrana yazdırır.

Kodu çalıştırmak için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, yukarıdaki kodu sol tarafa yapıştırın ve **run** seçeneğini seçin.

---

## 🟠 Example 2: Advanced Method – Calculating the Perimeter of a Rectangle

### 📝 Problem Statement

C#’ta bir dikdörtgenin çevresini hesaplayan bir metot yazın. Metot iki *integer* parametre kabul etmelidir: **length** ve  **width** . Metot çevreyi şu formülle hesaplayıp döndürmelidir:

**Perimeter = 2 * (length + width)**

---

## 🧱 Step 1: Define the Method with Parameters

```csharp
public static int CalculatePerimeter(int length, int width)
{
// Code to calculate perimeter
}
```

### 📝 Explanation

* **public:** Metot diğer sınıflardan erişilebilir.
* **static:** Metot veya değişken, sınıf örneğine değil sınıfın kendisine aittir.
* **int:** Metodun *integer* değer döndüreceğini belirtir.
* **CalculatePerimeter:** Metodun adıdır.
* **int length, int width:** Metot çağrılırken uzunluk ve genişlik değerlerini almasını sağlar.

---

## 🧮 Step 2: Implement the Logic to Calculate the Perimeter

```csharp
public static int CalculatePerimeter(int length, int width)
{
int perimeter = 2 * (length + width);
return perimeter;
}
```

### 📝 Explanation

* **int perimeter = 2 * (length + width);:** Uzunluk ve genişliği toplar ve sonucu 2 ile çarparak çevreyi hesaplar.
* **return perimeter;:** Hesaplanan çevreyi çağıran koda döndürür.

---

## ▶️ Step 3: Use the Method in the Main Program

```csharp
using System;

public class Program

{
    public static void Main()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        int width = int.Parse(Console.ReadLine());

        int perimeter = CalculatePerimeter(length, width);

        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }

    public static int CalculatePerimeter(int length, int width)
    {
        return 2 * (length + width);
    }
}
```

### 📝 Explanation

* **Console.WriteLine("Enter the length of the rectangle:");:** Kullanıcıdan uzunluk girmesini ister.
* **int length = int.Parse(Console.ReadLine());:** Girdiyi okur ve  *integer* ’a dönüştürür.
* **int perimeter = CalculatePerimeter(length, width);:** **CalculatePerimeter** metodunu çağırır.
* **Console.WriteLine("The perimeter of the rectangle is: " + perimeter);:** Çevreyi konsola yazdırır.

Kodu çalıştırmak için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, yukarıdaki kodu sol tarafa yapıştırın ve **run** seçeneğini seçin.

---

## 🟣 Problem 1: Calculate the Volume of a Rectangular Box

### 📝 Problem Statement

Bir dikdörtgenler prizmasının hacmini hesaplayan bir metot yazın. Metot üç *integer* parametre kabul etmelidir:  **length** , **width** ve  **height** . Metot hacmi şu şekilde hesaplayıp döndürmelidir:

**Volume = length * width * height**

Kodunuzu doğrudan **Dot Net Fiddle** üzerinde taslak olarak hazırlayıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin düzenleyici de kullanabilirsiniz, ancak DotNetFiddle kodunuzu hızlıca test etmek ve çalıştırmak için harikadır.

Kodu çalıştırmak için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve **run** seçeneğini seçin.

---

## 🟤 Problem 2: Calculate the Average of Three Numbers

### 📝 Problem Statement

Üç *integer* sayının ortalamasını hesaplayan bir metot yazın. Metot üç parametre kabul etmelidir:  **num1** , **num2** ve  **num3** . Metot ortalamayı *integer* olarak döndürmelidir.

Kodunuzu doğrudan **Dot Net Fiddle** üzerinde taslak olarak hazırlayıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin düzenleyici de kullanabilirsiniz, ancak DotNetFiddle kodunuzu hızlıca test etmek ve çalıştırmak için harikadır.

Kodu çalıştırmak için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve **run** seçeneğini seçin.

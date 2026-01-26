## 🧩 Activity: Methods in C#

### 🎯 Objective

C#’ta metotları kullanın: tanım, sözdizimi ve kullanım senaryoları.

---

## 🧩 Example 1: Defining a Method to Add Two Numbers

### 📝 Problem Statement

İki sayıyı toplayan ve sonucu döndüren bir metot yazın. Metot iki adet *integer* parametre almalıdır.

---

## 🧱 Step 1: Define the Method to Add Two Numbers

**Code:**

```csharp
public int AddNumbers(int a, int b) {
     return a + b;
}
```

### 📝 Line-by-Line Explanation

**public:** *Access Modifier* - Metodun diğer sınıflardan erişilebilir olduğunu belirtir. Metodun görünürlüğünü tanımlar.

**int:** *Return Type* - Metodun bir *integer* değer döndürdüğünü belirtir. Bu, metodun hangi türde çıktı üreteceğini tanımlamak açısından kritiktir.

**AddNumbers:** *Method Name* - Metodun adıdır. Açıklayıcı olmalı ve metodun ne yaptığını belirtmelidir.

**(int a, int b):** *Parameters* - Metoda giren girdilerdir. **a** ve  **b** , metoda geçirilecek değerler için yer tutucudur. İkisi de **int** türündedir.

**{ return a + b; }:** *Method Body* - Metodun mantığını içerir.  **return a + b;** , **a** ile  **b** ’nin toplamını hesaplar ve sonucu çağırana döndürür.

---

## 🧪 Step 2: Implement and Test the Method

**Code:**

```csharp
using System;
public class Program {
	public static void Main() {


Console.WriteLine("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = AddNumbers(num1, num2);

Console.WriteLine("The sum of the numbers is: " + result);

}
	static int AddNumbers(int a, int b) {
		return a + b;
	}
}
```

```csharp
using System;
public class Program {
   public static void Main() {
        Console.WriteLine("Enter the original price:");
        decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");
        decimal discountRate = Convert.ToDecimal(Console.ReadLine());

        decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
        return originalPrice * (1 - discountRate);
    }
}
```

---

## 🧩 Example 2: Creating a Method to Calculate the Discount on a Product

### 📝 Problem Statement

Bir üründe indirimi hesaplayan bir metot yazın. Metot iki parametre almalıdır: *original price* ve  *discount rate* ; indirimi uyguladıktan sonraki *final price* değerini döndürmelidir.

---

## 🧱 Step 1: Define the Method to Calculate Discount

**Code:**

```csharp
public decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
return originalPrice * (1 - discountRate);
}
```

### 📝 Line-by-Line Explanation

**public:** *Access Modifier* - Metodu diğer sınıflardan erişilebilir hâle getirir.

**decimal:** *Return Type* - Metodun *decimal* türünde bir değer döndürdüğünü belirtir. Bu, hassasiyet gerektiren finansal hesaplamalar için uygundur.

**CalculateDiscount:** *Method Name* - Metodun adıdır ve işlevini tanımlar.

**(decimal originalPrice, decimal discountRate):** *Parameters* - **originalPrice** ve  **discountRate** , metoda giren girdilerdir ve ikisi de **decimal** türündedir.

**{ return originalPrice * (1 - discountRate); }:** *Method Body* - İndirim sonrası son fiyatı hesaplar.  **1 - discountRate** , indirimin uygulanmasından sonra kalan fiyat oranını verir.

---

## 🧪 Step 2: Implement and Test the Method

**Code:**

```csharp
using System;
public class Program {
   public static void Main() {
        Console.WriteLine("Enter the original price:");
        decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");
        decimal discountRate = Convert.ToDecimal(Console.ReadLine());

        decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
        return originalPrice * (1 - discountRate);
    }
}
```

### 📝 Line-by-Line Explanation

**using System;:** *Namespace Import* - Konsol işlemleri için gerekli namespace’i içe aktarır.

**class Program {:** *Class Definition* - **Program** adlı bir sınıf tanımlar.

**static void Main() {:** *Main Method* - Uygulamanın giriş noktasıdır.

**Console.WriteLine("Enter the original price:");:** *Prompt for Input* - Kullanıcıdan original price girmesini ister.

**decimal originalPrice = Convert.ToDecimal(Console.ReadLine());:** *Read and Convert Input* - Kullanıcı girdisini okur ve  *decimal* ’a dönüştürür.

**Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");:** *Prompt for Input* - Kullanıcıdan discount rate girmesini ister.

**decimal discountRate = Convert.ToDecimal(Console.ReadLine());:** *Read and Convert Input* - Discount rate girdisini okur ve  *decimal* ’a dönüştürür.

**decimal finalPrice = CalculateDiscount(originalPrice, discountRate);:** *Call Method* - Kullanıcıdan alınan değerlerle **CalculateDiscount** metodunu çağırır.

**Console.WriteLine("The final price after discount is: " + finalPrice);:** *Display Result* - İndirim sonrası final price değerini yazdırır.

**static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {:** *Method Definition* - **CalculateDiscount** metodunu tanımlar.

**return originalPrice * (1 - discountRate);:** *Return Statement* - İndirim sonrası fiyatı hesaplar ve döndürür.

---

## ▶️ Step 3: Run the code

Artık tam kodu oluşturduğumuza göre, aşağıdaki kodu çalıştırmak isterseniz  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, aşağıdaki kodu sol tarafa yapıştırın ve **run** seçeneğini seçin.

```csharp
using System;
public class Program {
   public static void Main() {
        Console.WriteLine("Enter the original price:");
        decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");
        decimal discountRate = Convert.ToDecimal(Console.ReadLine());

        decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
        return originalPrice * (1 - discountRate);
    }
}
```

---

## 🟠 Problem 1: Creating a Function for Circle Area Calculation

### 📝 Problem Statement

Bir dairenin alanını hesaplamak için bir metot yazın. Metot bir giriş parametresi kabul etmelidir: dairenin yarıçapı. Program kullanıcıdan bu değeri istemeli, alanı hesaplamak için metodu kullanmalı ve ardından sonucu görüntülemelidir.

**Formula:** Bir dairenin alanı, yarıçapı **r** olmak üzere **π * r^2** ile verilir.

Kodunuzu doğrudan **Dot Net Fiddle** üzerinde taslak olarak hazırlayıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin düzenleyici de kullanabilirsiniz, ancak DotNetFiddle kodunuzu hızlıca test etmek ve çalıştırmak için harikadır.

Kodu çalıştırmak için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve **run** seçeneğini seçin.

---

## 🟦 Problem 2: Creating a Function for Trapezoid Area Calculation

### 📝 Problem Statement

Bir yamuk alanını hesaplamak için bir metot yazın. Metot üç giriş parametresi kabul etmelidir: iki paralel kenarın uzunluğu (**a** ve  **b** ) ve yükseklik. Program kullanıcıdan bu değerleri istemeli, alanı hesaplamak için metodu kullanmalı ve ardından sonucu görüntülemelidir.

**Formula:** Bir yamuk alanı, **(a + b) / 2 * height** ile verilir.

Kodunuzu doğrudan **Dot Net Fiddle** üzerinde taslak olarak hazırlayıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin düzenleyici de kullanabilirsiniz, ancak DotNetFiddle kodunuzu hızlıca test etmek ve çalıştırmak için harikadır.

Kodu çalıştırmak için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve **run** seçeneğini seçin.

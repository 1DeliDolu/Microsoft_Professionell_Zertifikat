## 🧩 You Try It! Practical Application of Calling Methods - Answer Key

---

## 🧱 Step 1: Defining and Calling a Simple Method

```csharp
using System;

public class Program
{
	public static void Main() {
		// Method Definition
		static void DisplayWelcomeMessage() {
			Console.WriteLine("Welcome to our Program!");
		}

		// Call the method
		DisplayWelcomeMessage();
	}
}
```

---

## 📥 Step 2: Creating a Method with Parameters

```csharp
using System;

public class Program
{
	public static void Main() {
		// Method Definition
		static void GreetUser(string name) {
			Console.WriteLine("Hello " + name + "!");
		}

		// Call the method
		GreetUser("Alice");
	}
}
```

---

## ↩️ Step 3: Using Methods with Return Values

```csharp
using System;

public class Program
{
	public static void Main() {
		// Method Definition
		static int CalculateSum(int a, int b) {
			return a + b;
		}

		// Call the method and store the result
		int sum = CalculateSum(5, 7);
		Console.WriteLine("The sum is: " + sum);
	}
}
```

---

## ✅ Step 4: Combining Methods and Conditional Logic

```csharp
using System;

public class Program
{
	public static void Main() {
		// Call the method
		int number = -3;
		bool result = IsPositive(number);

		if (result) {
			Console.WriteLine("The number is positive.");
		} else {
			Console.WriteLine("The number is not positive.");
		}
	}

	static bool IsPositive(int number) {
		if (number > 0) {
			return true;
		} else {
			return false;
		}
	}
}
```

---

## 🚗 Step 5: Practical Application – User Age Validation

```csharp
using System;

public class Program
{
	public static void Main() {
		// Call the method
		Console.WriteLine("Enter your age: ");
		int age = int.Parse(Console.ReadLine());

		bool canDrive = IsOldEnoughToDrive(age);

		if (canDrive) {
			Console.WriteLine("You are old enough to drive.");
		} else {
			Console.WriteLine("You are not old enough to drive.");
		}
	}

	// Method Definition
	static bool IsOldEnoughToDrive(int age) {
		if (age >= 18) {
			return true;
		} else {
			return false;
		}
	}
}
```

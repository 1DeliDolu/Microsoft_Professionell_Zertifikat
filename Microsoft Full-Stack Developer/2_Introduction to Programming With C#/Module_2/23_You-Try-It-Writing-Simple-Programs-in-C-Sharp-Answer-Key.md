
## 🧪 Deneyin! C# ile Basit Programlar Yazma - Cevap Anahtarı

### 🧮 Adım 1: Basit Bir Hesap Makinesi Oluşturma

```csharp
public class Calculator
{
    public static int number1;
    public static int number2;

    public static int Add()
    {
        return number1 + number2;
    }
}
```

---

### ▶️ Adım 2: Hesap Makinesi Programını Çalıştırma

```csharp
using System;
public class Calculator
{
    public static int number1 = 5;
    public static int number2 = 10;

    public static int Add()
    {
        return number1 + number2;
    }

    public static void Main(string[] args)
    {
        int result = Add();
        Console.WriteLine("The sum is: " + result);
    }
}
```

---

### 🔁 Adım 3: Sayıları Görüntülemek İçin Döngü Oluşturma

```csharp
using System;
public class NumberDisplay
{
    public static void DisplayNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Main(string[] args)
    {
        DisplayNumbers();
    }
}
```

---

### ⌨️ Adım 4: Kullanıcı Girdisi Alma

```csharp
using System;
public class UserInput
{
    public static void GreetUser()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static void Main(string[] args)
    {
        GreetUser();
    }
}
```

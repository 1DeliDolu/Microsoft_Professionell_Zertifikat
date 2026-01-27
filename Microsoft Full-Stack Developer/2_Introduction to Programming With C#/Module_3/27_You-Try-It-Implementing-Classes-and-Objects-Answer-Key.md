## 🗝️ You Try It! Sınıflar ve Nesneleri Uygulamak - Cevap Anahtarı

---

## 👤 Adım 2: Temel Bir Sınıf Oluşturma

```csharp
public class Person
{
    // Define the Name property
    public string Name { get; set; }

    // Define the Age property
    public int Age { get; set; }
}
```

---

## 🧍 Adım 3: Nesneler Oluşturma

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Create the first Person object
        Person friend = new Person();
        friend.Name = "John Doe";
        friend.Age = 30;

        // Create the second Person object
        Person colleague = new Person();
        colleague.Name = "Jane Smith";
        colleague.Age = 25;
    }
}
```

---

## ⚙️ Adım 4: Metot Oluşturma

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Define the Greet method
    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }
}
```

---

## 🔗 Adım 5: Nesnelerde Metot Kullanma

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Create the first Person object
        Person friend = new Person();
        friend.Name = "John Doe";
        friend.Age = 30;

        // Create the second Person object
        Person colleague = new Person();
        colleague.Name = "Jane Smith";
        colleague.Age = 25;

        // Call the Greet method on each object
        friend.Greet(); // Output: Hello, my name is John Doe
        colleague.Greet(); // Output: Hello, my name is Jane Smith
    }
}
```

### ✅ Beklenen Çıktı

Hello, my name is John Doe
Hello, my name is Jane Smith

---

## 👥 Adım 6: Birden Fazla Nesne ile Pratik

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Create the first Person object
        Person friend = new Person();
        friend.Name = "John Doe";
        friend.Age = 30;

        // Create the second Person object
        Person colleague = new Person();
        colleague.Name = "Jane Smith";
        colleague.Age = 25;

        // Create the third Person object
        Person newPerson = new Person();
        newPerson.Name = "Mike Johnson";
        newPerson.Age = 35;

        // Call the Greet method on each object
        friend.Greet(); // Output: Hello, my name is John Doe
        colleague.Greet(); // Output: Hello, my name is Jane Smith
        newPerson.Greet(); // Output: Hello, my name is Mike Johnson
    }
}
```

### ✅ Beklenen Çıktı

Hello, my name is John Doe
Hello, my name is Jane Smith
Hello, my name is Mike Johnson

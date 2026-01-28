## 🧪 You Try It! .NET’te Serialization Tekniklerini Uygulamak - Cevap Anahtarı

---

## 🗃️ Adım 2: Binary Serialization

```csharp
using System;
using System.IO;

public class Person
{
    public string UserName { get; set; }
    public int UserAge { get; set; }
}

class Program
{
    static void Main()
    {
        Person samplePerson = new Person { UserName = "Alice", UserAge = 30 };
        // Binary serialization
        using (FileStream fs = new FileStream("person.dat", FileMode.Create))
        {
            BinaryWriter writer = new BinaryWriter(fs);
            writer.Write(samplePerson.UserName);
            writer.Write(samplePerson.UserAge);
        }
        Console.WriteLine("Binary serialization complete.");
    }
}
```

---

## 🧾 Adım 3: XML Serialization

```csharp
using System;
using System.IO;
using System.Xml.Serialization;

public class Person
{
    public string UserName { get; set; }
    public int UserAge { get; set; }
}

class Program
{
    static void Main()
    {
        Person samplePerson = new Person { UserName = "Alice", UserAge = 30 };
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

        using (StreamWriter writer = new StreamWriter("person.xml"))
        {
            xmlSerializer.Serialize(writer, samplePerson);
        }

        Console.WriteLine("XML serialization complete.");
    }
}
```

---

## 🧩 Adım 4: JSON Serialization

```csharp
using System;
using System.IO;
using System.Text.Json;

public class Person
{
    public string UserName { get; set; }
    public int UserAge { get; set; }
}

class Program
{
    static void Main()
    {
        Person samplePerson = new Person { UserName = "Alice", UserAge = 30 };
        string jsonString = JsonSerializer.Serialize(samplePerson);

        File.WriteAllText("person.json", jsonString);

        Console.WriteLine("JSON serialization complete.");
    }
}
```

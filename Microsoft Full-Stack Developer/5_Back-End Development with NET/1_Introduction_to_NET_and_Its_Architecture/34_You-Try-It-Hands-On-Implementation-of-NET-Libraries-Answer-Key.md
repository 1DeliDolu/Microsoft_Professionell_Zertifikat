## 🧪 You Try It! .NET Kütüphanelerinin Uygulamalı Kullanımı – Cevap Anahtarı

---

## 🥇 Adım 1 Kodu

Yeni bir C# console uygulaması başlatma komutu:

```bash
dotnet new console -n JsonExample
```

Projeyi Visual Studio Code’da açmak için:

```bash
cd JsonExample
code .
```

Projeyi çalıştırınca beklenen çıktı:

```text
Hello World!
```

---

## 📦 Adım 3 Kodu

Komut satırı ile `Newtonsoft.Json` paketini yüklemek için:

```bash
dotnet add package Newtonsoft.Json
```

`csproj` dosyasını kontrol ettiğinizde buna benzer bir giriş görürsünüz:

```xml
<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
```

---

## 🔄 Adım 4 Kodu

Adım 2’den sonra oluşan tam C# kodu:

```csharp
using System;
using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
```

Adım 4 için beklenen çıktı:

```text
Name: John Doe, Age: 30
```

---

## 🔁 Adım 5 Kodu

Serialization eklenmiş nihai kod:

```csharp
using System;
using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Deserialize JSON to Person object
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Serialize Person object to JSON
        Person newPerson = new Person { Name = "Ping Jeong", Age = 25 };
        string newJson = JsonConvert.SerializeObject(newPerson);
        Console.WriteLine($"Serialized JSON: {newJson}");
    }
}
```

Adım 5 için beklenen çıktı:

```text
Name: John Doe, Age: 30
Serialized JSON: {"Name":"Ping Jeong","Age":25}
```

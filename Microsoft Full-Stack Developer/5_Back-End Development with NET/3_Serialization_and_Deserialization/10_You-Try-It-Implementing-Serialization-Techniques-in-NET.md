## You Try It: Implementing Serialization Techniques in .NET (Adim Adim)

Bu calismada `SerializationDemo` adli bir console uygulamasinda binary, XML ve JSON serialization uygulandi. Yapilan islemler ve kodlar:

1) Proje olusturma
- Terminalde ilgili klasore gidildi.
- `dotnet new console -o SerializationDemo` calistirildi.
- `cd SerializationDemo` ile proje klasorune girildi.

2) Person sinifini ekleme
- `Program.cs` icine `Person` sinifi eklendi.

```csharp
public sealed class Person
{
    public string UserName { get; set; } = string.Empty;
    public int UserAge { get; set; }
}
```

3) Binary serialization (manuel)
- `using System.IO;` eklendi.
- `Person` nesnesi orneklendi.
- `FileStream` ve `BinaryWriter` ile `person.dat` olusturuldu.

```csharp
using System.IO;

var person = new Person
{
    UserName = "Alice",
    UserAge = 30
};

using var fileStream = new FileStream("person.dat", FileMode.Create, FileAccess.Write);
using var writer = new BinaryWriter(fileStream);
writer.Write(person.UserName);
writer.Write(person.UserAge);

Console.WriteLine("Binary serialization completed.");
```

4) XML serialization
- `using System.Xml.Serialization;` eklendi.
- `XmlSerializer` ile `person.xml` dosyasina yazildi.

```csharp
using System.Xml.Serialization;

var xmlSerializer = new XmlSerializer(typeof(Person));
using var xmlStream = new FileStream("person.xml", FileMode.Create, FileAccess.Write);
xmlSerializer.Serialize(xmlStream, person);

Console.WriteLine("XML serialization completed.");
```

5) JSON serialization
- `using System.Text.Json;` eklendi.
- `JsonSerializer.Serialize` ile JSON string olusturuldu ve `person.json` dosyasina kaydedildi.

```csharp
using System.Text.Json;

var jsonString = JsonSerializer.Serialize(person);
File.WriteAllText("person.json", jsonString);

Console.WriteLine("JSON serialization completed.");
```

6) Tam Program.cs (toplu gorunum)

```csharp
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

var person = new Person
{
    UserName = "Alice",
    UserAge = 30
};

using var fileStream = new FileStream("person.dat", FileMode.Create, FileAccess.Write);
using var writer = new BinaryWriter(fileStream);
writer.Write(person.UserName);
writer.Write(person.UserAge);
Console.WriteLine("Binary serialization completed.");

var xmlSerializer = new XmlSerializer(typeof(Person));
using var xmlStream = new FileStream("person.xml", FileMode.Create, FileAccess.Write);
xmlSerializer.Serialize(xmlStream, person);
Console.WriteLine("XML serialization completed.");

var jsonString = JsonSerializer.Serialize(person);
File.WriteAllText("person.json", jsonString);
Console.WriteLine("JSON serialization completed.");

public sealed class Person
{
    public string UserName { get; set; } = string.Empty;
    public int UserAge { get; set; }
}
```

7) Calistirma ve cikti kontrolu
- `dotnet run` ile uygulama calistirildi.
- Olusan dosyalar:
  - `person.dat` (binary)
  - `person.xml` (XML)
  - `person.json` (JSON)
- Dosya boyutlari ve okunabilirlik karsilastirildi:
  - Binary en kucuk ama okunabilir degil.
  - JSON kucuk ve okunabilir.
  - XML en buyuk ama en acik/yapilandirilmis format.

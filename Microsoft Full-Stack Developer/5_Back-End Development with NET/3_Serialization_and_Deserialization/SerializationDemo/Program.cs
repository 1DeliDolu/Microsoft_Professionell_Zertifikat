using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

// See https://aka.ms/new-console-template for more information
var person = new Person { UserName = "Alice", UserAge = 30 };
var person1 = new Person { UserName = "Bob", UserAge = 25 };
var person2 = new Person { UserName = "Charlie", UserAge = 35 };

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

using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

// Binary deserialization
var binaryStopwatch = Stopwatch.StartNew();

using var fileStream = new FileStream("person.dat", FileMode.Open, FileAccess.Read);
using var reader = new BinaryReader(fileStream);

var binaryPerson = new Person
{
    UserName = reader.ReadString(),
    UserAge = reader.ReadInt32()
};

binaryStopwatch.Stop();
Console.WriteLine(
    $"Binary -> UserName: {binaryPerson.UserName}, UserAge: {binaryPerson.UserAge} (" +
    $"{binaryStopwatch.ElapsedMilliseconds} ms)"
);

// XML deserialization
var xmlPerson = new Person
{
    UserName = "Alice",
    UserAge = 30
};

var xmlSerializer = new XmlSerializer(typeof(Person));
string xmlData;
using (var stringWriter = new StringWriter())
{
    xmlSerializer.Serialize(stringWriter, xmlPerson);
    xmlData = stringWriter.ToString();
}

var xmlStopwatch = Stopwatch.StartNew();
using var xmlReader = new StringReader(xmlData);
var xmlDeserialized = xmlSerializer.Deserialize(xmlReader) as Person;
xmlStopwatch.Stop();

if (xmlDeserialized is not null)
{
    Console.WriteLine(
        $"XML -> UserName: {xmlDeserialized.UserName}, UserAge: {xmlDeserialized.UserAge} (" +
        $"{xmlStopwatch.ElapsedMilliseconds} ms)"
    );
}
else
{
    Console.WriteLine("XML deserialization failed.");
}

// JSON deserialization
var jsonPerson = new Person
{
    UserName = "Bob",
    UserAge = 25
};

var jsonData = JsonSerializer.Serialize(jsonPerson);
var jsonStopwatch = Stopwatch.StartNew();
var jsonDeserialized = JsonSerializer.Deserialize<Person>(jsonData);
jsonStopwatch.Stop();

if (jsonDeserialized is not null)
{
    Console.WriteLine(
        $"JSON -> UserName: {jsonDeserialized.UserName}, UserAge: {jsonDeserialized.UserAge} (" +
        $"{jsonStopwatch.ElapsedMilliseconds} ms)"
    );
}
else
{
    Console.WriteLine("JSON deserialization failed.");
}

public sealed class Person
{
    public string UserName { get; set; } = string.Empty;
    public int UserAge { get; set; }
}

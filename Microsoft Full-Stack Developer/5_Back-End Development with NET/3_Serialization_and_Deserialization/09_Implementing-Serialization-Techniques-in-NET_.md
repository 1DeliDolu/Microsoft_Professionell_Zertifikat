```
using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

public class Project
{
    public class Person
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
    }

    static void Main()
    {
        Person samplePerson = new Person
        {
            UserName = "Alice",
            UserAge = 30
        };

        // -----------------------------
        // 1. Binary Serialization
        // -----------------------------
        using (FileStream fs = new FileStream("person.dat", FileMode.Create))
        {
            BinaryWriter writer = new BinaryWriter(fs);
            writer.Write(samplePerson.UserName);
            writer.Write(samplePerson.UserAge);
        }

        Console.WriteLine("Binary serialization complete.");

        // -----------------------------
        // 2. XML Serialization
        // -----------------------------
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

        using (StreamWriter writer = new StreamWriter("person.xml"))
        {
            xmlSerializer.Serialize(writer, samplePerson);
        }

        Console.WriteLine("XML serialization complete.");

        // -----------------------------
        // 3. JSON Serialization
        // -----------------------------
        string jsonString = JsonSerializer.Serialize(samplePerson);
        File.WriteAllText("person.json", jsonString);

        Console.WriteLine("JSON serialization complete.");
    }
}

```

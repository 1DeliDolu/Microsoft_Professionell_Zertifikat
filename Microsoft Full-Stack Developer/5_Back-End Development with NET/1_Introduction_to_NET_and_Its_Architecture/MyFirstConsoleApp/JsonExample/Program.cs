using System;
using System.Text.Json;


namespace JsonExample;

public class Program
{
    public static void Main(string[] args)
    {
        // JSON string representing a Person
        string json = "{\"Name\":\"Alice\",\"Age\":30}";

        // Deserialize using System.Text.Json
        Person person = JsonSerializer.Deserialize<Person>(json)!;

        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Create a new Person and serialize back to JSON
        Person bob = new Person("Bob", 42);
        string bobJson = JsonSerializer.Serialize(bob);
        Console.WriteLine($"Serialized JSON: {bobJson}");
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person() { }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
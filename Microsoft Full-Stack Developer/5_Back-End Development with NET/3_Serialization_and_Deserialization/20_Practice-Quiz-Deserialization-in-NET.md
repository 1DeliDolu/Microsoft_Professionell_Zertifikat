### 1.

Question 1

When working with .NET applications, data often needs to be restored from saved states. What is the primary role of deserialization in this process?

[ ]To improve the performance of data storage

[ ]To encrypt objects before storing them

[ ]To convert serialized data back into usable objects

[ ]To remove unused properties from an object


### 2.

Question 2

A developer is working on a .NET application that receives user profiles in JSON format from a web API. The application successfully converts the JSON into C# objects without requiring manual parsing. What feature of .NET enables this automatic deserialization?

[ ]The XML deserialization feature in .NET

[ ]The ability of C# objects to store any type of data automatically

[ ]A background process that manually reads and assigns values from JSON

[ ]The built-in deserialization methods in .NET's JSON libraries


### 3.

Question 3

A developer is working on a .NET API that deserializes incoming JSON requests into C# objects. They send a request containing an extra field not defined in the Person class. What will happen if default .NET settings are used?

[ ]The extra field will be stored in a separate property of the object

[ ]The extra field will be removed from the original JSON before deserialization

[ ]The extra field will be ignored, and deserialization will proceed normally

[ ]The deserialization process will fail, and an exception will be thrown



### 1.

Question 1

When working with .NET applications, data often needs to be restored from saved states. What is the primary role of deserialization in this process?

[ ]To improve the performance of data storage
[ ]To encrypt objects before storing them
[X]To convert serialized data back into usable objects

That is correct! Deserialization is the process of converting serialized data back into objects, making it usable within an application.
[ ]To remove unused properties from an object

---

### 2.

Question 2

A developer is working on a .NET application that receives user profiles in JSON format from a web API. The application successfully converts the JSON into C# objects without requiring manual parsing. What feature of .NET enables this automatic deserialization?

[ ]The XML deserialization feature in .NET
[ ]The ability of C# objects to store any type of data automatically
[ ]A background process that manually reads and assigns values from JSON
[X]The built-in deserialization methods in .NET's JSON libraries

That is correct! .NET provides built-in deserialization features that automatically convert JSON data into objects when the structure matches the expected type.

---

### 3.

Question 3

A developer is working on a .NET API that deserializes incoming JSON requests into C# objects. They send a request containing an extra field not defined in the Person class. What will happen if default .NET settings are used?

[ ]The extra field will be stored in a separate property of the object
[ ]The extra field will be removed from the original JSON before deserialization
[X]The extra field will be ignored, and deserialization will proceed normally

That is correct! By default, .NET’s JSON deserializer ignores unmapped properties unless configured otherwise.
[ ]The deserialization process will fail, and an exception will be thrown

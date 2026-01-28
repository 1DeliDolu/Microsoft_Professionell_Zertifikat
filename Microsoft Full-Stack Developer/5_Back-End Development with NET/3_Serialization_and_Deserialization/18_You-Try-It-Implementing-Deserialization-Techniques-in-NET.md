
# Instructions

### Lab instructions


Step 1: Prepare for the Application

You’ll create a new .NET console application using Visual Studio Code. This program will help users deserialize data from different formats (binary, XML, and JSON) into objects.

1. Set up the Console Application:
   • Open Visual Studio Code.
   • Create a new .NET console project if one isn’t already set up.
   • Delete any existing code in the Program.cs file.
2. Add the necessary libraries for working with serialization, including System.Text.Json for JSON and System.Xml.Serialization for XML.


Step 2: Implement Binary Deserialization (Using BinaryWriter and BinaryReader)

You’ll implement binary deserialization by reading binary data and converting it back into a Person object.

1. Create a class Person with properties UserName (string) and UserAge (integer).
2. Use BinaryWriter to serialize a Person object as binary data into a file named person.dat.
3. Use BinaryReader to read the binary data from person.dat and convert it back into a Person object.
4. Output the deserialized data to confirm that the deserialization works as expected.


Step 3: Implement XML Deserialization

In this step, you’ll implement XML deserialization to convert XML-formatted data back into a Person object.

1. Use XmlSerializer to handle XML data conversion for the Person class.
2. Read XML data from a stream or string and deserialize it into a Person object.
3. Test XML Deserialization:
   a. Create an XML-formatted string representing a Person.
   b. Deserialize the XML data and output the Person details to verify the deserialization process.


Step 4: Implement JSON Deserialization

Now, you’ll implement JSON deserialization to handle data conversion from JSON format to a Person object.

1. Use System.Text.Json.JsonSerializer to handle JSON deserialization.
2. Read JSON data and deserialize it directly into a Person object.
3. Test JSON Deserialization:
   a. Define a JSON string representing a Person.
   b. Deserialize the JSON and output the details to confirm the data integrity of the deserialized object.


Step 5: Verify Integrity of Deserialized Data

1. Verify that all required properties are deserialized correctly and not left as null.
2. Add error handling to each deserialization process to manage issues like missing data or type mismatches.
3. For each format (binary, XML, JSON), print a message indicating whether the deserialized data is complete and valid.

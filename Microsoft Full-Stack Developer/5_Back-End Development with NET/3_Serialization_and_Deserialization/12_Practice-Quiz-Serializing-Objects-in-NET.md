### 1.

Question 1

Which of the following describes a key benefit of JSON serialization in .NET?

[ ]It transforms objects into text with extensive metadata for debugging

[ ]It optimizes serialization for high-performance scenarios where human readability is unnecessary

[ ]It ensures compatibility with older systems through a structured format

[ ]It creates a lightweight, human-readable format ideal for web APIs


### 2.

Question 2

When using the JsonSerializer.Serialize method in .NET, what is the expected output?

[ ]An XML document representing the object

[ ]A binary data stream for high-performance applications

[ ]A JSON string representation of the object

[ ]A text object with embedded metadata


### 3.

Question 3

You are developing an application that exchanges user data between a client and server. The data must be lightweight and human-readable. Which steps would you take to serialize an object into JSON using the JsonSerializer class?

[ ]Manually write a JSON string for each object property and save it to a file

[ ]Use JsonSerializer.Serialize to convert the object to JSON, then transmit or store the resulting string

[ ]Apply a Serializable attribute to the object and use BinaryFormatter.Serialize to produce a JSON string

[ ]Use JsonDocument to directly convert the object into a JSON-compatible format


### 1.

Question 1

Which of the following describes a key benefit of JSON serialization in .NET?

[ ]It transforms objects into text with extensive metadata for debugging
[ ]It optimizes serialization for high-performance scenarios where human readability is unnecessary
[ ]It ensures compatibility with older systems through a structured format
[X]It creates a lightweight, human-readable format ideal for web APIs

That’s correct! JSON serialization is lightweight and human-readable, making it perfect for web APIs where simplicity and speed are critical.

---

### 2.

Question 2

When using the JsonSerializer.Serialize method in .NET, what is the expected output?

[ ]An XML document representing the object
[ ]A binary data stream for high-performance applications
[X]A JSON string representation of the object

That’s correct! The JsonSerializer.Serialize method produces a JSON string that can be stored or transmitted in a lightweight, readable format.
[ ]A text object with embedded metadata

---

### 3.

Question 3

You are developing an application that exchanges user data between a client and server. The data must be lightweight and human-readable. Which steps would you take to serialize an object into JSON using the JsonSerializer class?

[ ]Manually write a JSON string for each object property and save it to a file
[X]Use JsonSerializer.Serialize to convert the object to JSON, then transmit or store the resulting string

That’s correct! The JsonSerializer.Serialize method converts an object into a JSON string, ready for storage or transmission in web applications.
[ ]Apply a Serializable attribute to the object and use BinaryFormatter.Serialize to produce a JSON string
[ ]Use JsonDocument to directly convert the object into a JSON-compatible format

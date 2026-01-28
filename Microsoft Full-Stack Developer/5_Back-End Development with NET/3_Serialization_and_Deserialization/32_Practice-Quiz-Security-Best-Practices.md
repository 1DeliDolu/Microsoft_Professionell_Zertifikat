### 1.

Question 1

Which of the following is a common security risk associated with serialization?

[ ]Serialization only involves simple data types

[ ]Using encrypted serialized data prevents all attacks

[ ]Deserialization attacks can lead to code execution

[ ]Serialization guarantees data integrity



### 2.

Question 2

What is a recommended best practice to secure serialized data during transmission?

[ ]Ignore data integrity checks for performance

[ ]Skip encryption for internal data

[ ]Allow all serialized data to pass through the system

[ ]Use encryption to protect sensitive serialized data


### 3.

Question 3

What is a critical strategy to prevent deserialization vulnerabilities in .NET?

[ ]Limit the types allowed during deserialization to known, safe types

[ ]Automatically deserialize data from external sources

[ ]Trust all libraries used for deserialization

[ ]Disable exception handling during deserialization


### 4.

Question 4

What is a critical step to ensure security when deserializing data from external sources?

[ ]Validate and sanitize all input data before deserialization

[ ]Use deprecated serialization libraries

[ ]Allow all data types to be deserialized for flexibility

[ ]Skip validation if the data source is trusted


### 1.

Question 1

Which of the following is a common security risk associated with serialization?

[ ]Serialization only involves simple data types
[ ]Using encrypted serialized data prevents all attacks
[X]Deserialization attacks can lead to code execution

That’s correct! Deserialization attacks occur when untrusted data is deserialized, potentially allowing attackers to execute malicious code.
[ ]Serialization guarantees data integrity

---

### 2.

Question 2

What is a recommended best practice to secure serialized data during transmission?

[ ]Ignore data integrity checks for performance
[ ]Skip encryption for internal data
[ ]Allow all serialized data to pass through the system
[X]Use encryption to protect sensitive serialized data

That’s correct! Encrypting sensitive data ensures that even if it is intercepted, it cannot be accessed without the appropriate decryption key.

---

### 3.

Question 3

What is a critical strategy to prevent deserialization vulnerabilities in .NET?

[X]Limit the types allowed during deserialization to known, safe types

That's correct! Restricting the types that can be deserialized prevents malicious objects from being injected into the application.
[ ]Automatically deserialize data from external sources
[ ]Trust all libraries used for deserialization
[ ]Disable exception handling during deserialization

---

### 4.

Question 4

What is a critical step to ensure security when deserializing data from external sources?

[X]Validate and sanitize all input data before deserialization

That’s correct! Validating and sanitizing input ensures the data matches expected formats and removes any harmful elements, reducing the risk of deserialization attacks.
[ ]Use deprecated serialization libraries
[ ]Allow all data types to be deserialized for flexibility
[ ]Skip validation if the data source is trusted

### 1.

Question 1

Which of the following would most negatively impact CPU usage during serialization?

[ ]A simple object that contains five fields of data

[ ]An object that needs special formats like binary or JSON for processing

[ ]A large object which consumes more network bandwidth during transmission

[ ]A complex object that has multiple layers or nested attributes that increase processing demands


### 2.

Question 2

Which best practice can optimize serialization performance in .NET?

[ ]Include detailed metadata to enhance object descriptions

[ ]Use XML serialization for all datasets, regardless of size

[ ]Serialize every property of an object to ensure accuracy

[ ]Simplify data structures by removing unnecessary details


### 3.

Question 3

How does choosing a binary format for serialization impact performance compared to JSON?

[ ]Binary serialization is faster and produces smaller output than JSON

[ ]Binary serialization is slower but produces more human-readable output than JSON

[ ]The performance is the same for both binary and JSON serialization

[ ]JSON serialization is always faster and more efficient than binary serialization


### 1.

Question 1

Which of the following would most negatively impact CPU usage during serialization?

[ ]A simple object that contains five fields of data
[ ]An object that needs special formats like binary or JSON for processing
[ ]A large object which consumes more network bandwidth during transmission
[X]A complex object that has multiple layers or nested attributes that increase processing demands

That’s correct! Complex objects with multiple layers or attributes require significant CPU power, as each layer or attribute must be processed during serialization.

---

### 2.

Question 2

Which best practice can optimize serialization performance in .NET?

[ ]Include detailed metadata to enhance object descriptions
[ ]Use XML serialization for all datasets, regardless of size
[ ]Serialize every property of an object to ensure accuracy
[X]Simplify data structures by removing unnecessary details

That’s correct! Simplifying data structures reduces the complexity of serialized objects, improving performance by decreasing processing time.

---

### 3.

Question 3

How does choosing a binary format for serialization impact performance compared to JSON?

[X]Binary serialization is faster and produces smaller output than JSON

That’s correct! Binary serialization is more efficient in speed and size, making it a good choice for performance-critical applications.
[ ]Binary serialization is slower but produces more human-readable output than JSON
[ ]The performance is the same for both binary and JSON serialization
[ ]JSON serialization is always faster and more efficient than binary serialization

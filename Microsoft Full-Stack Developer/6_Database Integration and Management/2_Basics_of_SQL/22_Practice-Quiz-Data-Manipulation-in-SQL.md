
### 1. Question 1

Which SQL statement syntax is used to insert a new record into a table named Customers with columns CustomerID, FirstName, and LastName?

* [X] INSERT INTO Customers (CustomerID, FirstName, LastName) VALUES (1, 'John', 'Doe');

That’s correct! This syntax specifies the table and columns followed by the values for each column.

* [ ] ADD INTO Customers VALUES ('John', 'Doe', 1);
* [ ] INSERT INTO Customers (CustomerID, FirstName, LastName) VALUES 'John', 'Doe', 1;
* [ ] UPDATE Customers SET (CustomerID, FirstName, LastName) VALUES (1, 'John', 'Doe');

---

### 2. Question 2

How would you update a Product table to set the Price of a product named "Laptop" to 1200?

* [X] UPDATE Product SET Price = 1200 WHERE Name = 'Laptop';

That’s correct! This UPDATE statement correctly specifies the column, new value, and a condition to target the right record.

* [ ] UPDATE Product VALUES (Price = 1200) WHERE Name = 'Laptop';
* [ ] CHANGE Product SET Price = 1200 WHERE Name = 'Laptop';
* [ ] MODIFY Product VALUES (Price = 1200) WHEN Name = 'Laptop';

---

### 3. Question 3

What SQL statement would you use to delete a record in the Orders table for an OrderID of 105?

* [ ] DELETE * FROM Orders WHERE OrderID = 105;
* [ ] REMOVE FROM Orders WHERE OrderID = 105;
* [ ] DELETE Orders SET OrderID = 105;
* [X] DELETE FROM Orders WHERE OrderID = 105;

---

### 4. Question 4

A new product named "Tablet Pro" needs to be added to the Product table with a Price of 500. Additionally, the Price of the product "Laptop" needs to be updated to 1200, and the product "Old Phone" needs to be removed from the database. What sequence of SQL statements would you use to accomplish these tasks?

* [ ] ADD INTO Product (Name, Price) VALUES ('Tablet Pro', 500);CHANGE Product SET Price = 1200 WHERE Name = 'Laptop';REMOVE FROM Product WHERE Name = 'Old Phone';
* [ ] INSERT INTO Product (Name, Price) VALUES ('Tablet Pro', 500);UPDATE Product Price = 1200 WHERE Name = 'Laptop';DELETE FROM Product Name 'Old Phone';
* [ ] INSERT INTO Product VALUES ('Tablet Pro', 500);SET Product Price = 1200 WHERE Name = 'Laptop';DELETE Product Name = 'Old Phone';
* [X] INSERT INTO Product (Name, Price) VALUES ('Tablet Pro', 500);UPDATE Product SET Price = 1200 WHERE Name = 'Laptop';DELETE FROM Product WHERE Name = 'Old Phone';

That’s correct! This DELETE statement specifies the table and conditions for safely removing a record.

---

### 5. Question 5

Your task is to correct the following database records: Insert a new customer "Anna Green" with a CustomerID of 7 into the Customers table, update the LastName of the customer with CustomerID 4 to "Brown," and delete the customer with CustomerID 5. Which SQL statements correctly accomplish these tasks?

* [ ] ADD INTO Customers (CustomerID, FirstName, LastName) VALUES (7, 'Anna', 'Green');UPDATE Customers SET LastName 'Brown' WHERE CustomerID = 4;REMOVE FROM Customers WHERE CustomerID = 5;
* [ ] INSERT INTO Customers (CustomerID, FirstName, LastName) VALUES (7, 'Anna', 'Green');UPDATE Customers SET LastName = 'Brown' WHERE CustomerID = 4;DELETE Customers WHERE CustomerID = 5;
* [ ] INSERT INTO Customers VALUES (7, 'Anna', 'Green');SET Customers LastName = 'Brown' WHERE CustomerID = 4;DELETE Customers WHERE CustomerID = 5;
* [X] INSERT INTO Customers (CustomerID, FirstName, LastName) VALUES (7, 'Anna', 'Green');UPDATE Customers SET LastName = 'Brown' WHERE CustomerID = 4;DELETE FROM Customers WHERE CustomerID = 5;

That’s correct! This sequence of statements uses the correct syntax for INSERT, UPDATE, and DELETE operations to manipulate data in the Product table.

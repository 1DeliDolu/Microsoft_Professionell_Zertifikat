
### 1. Question 1

Which SQL statement would you use to retrieve all columns from the Customers table?

* [X] SELECT * FROM Customers;

That’s correct! SELECT * retrieves all columns from the specified table.

* [ ] SELECT Customers FROM *;
* [ ] SELECT FROM Customers *;
* [ ] SHOW * FROM Customers;

---

### 2. Question 2

How would you retrieve employees in the Sales department sorted by their last names in ascending order?

* [ ] SELECT * FROM Employees ORDER BY LastName WHERE Department = 'Sales';
* [ ] SHOW Employees WHERE Department = 'Sales' ORDER LastName ASC;
* [X] SELECT * FROM Employees WHERE Department = 'Sales' ORDER BY LastName ASC;

That’s correct! This query filters for employees in Sales and orders them by last name in ascending order.

* [ ] SELECT LastName FROM Employees ORDER BY Department = 'Sales' ASC;

---

### 3. Question 3

If you want to retrieve the Names and Emails of customers only from the USA, which SQL query would you use?

* [ ] SELECT Name, Email FROM Customers;
* [ ] SELECT Name Email FROM Customers IN 'USA';
* [X] SELECT Name, Email FROM Customers WHERE Country = 'USA';

That’s correct! This query selects Name and Email from Customers where Country is USA.

* [ ] SHOW Name, Email IN Customers WHERE Country = 'USA';

---

### 4. Question 4

Which part of an SQL query specifies the table from which data is retrieved?

* [ ] ORDER BY
* [ ] WHERE
* [X] FROM

That’s correct! The FROM clause specifies the table in a SELECT statement.

* [ ] SELECT


### 1. Question 1

You need a query that retrieves all HR department employees with salaries above 80,000 and lists them by salary, highest to lowest. Which query would you use?

* [ ] SELECT * FROM Employees WHERE Salary > 80000 ORDER BY Department = 'HR';
* [ ] SELECT * FROM Employees WHERE Department = 'HR' OR Salary > 80000 ORDER BY Salary DESC;
* [ ] SELECT Department, Salary FROM Employees ORDER BY Department = 'HR' AND Salary DESC;
* [X] SELECT * FROM Employees WHERE Department = 'HR' AND Salary > 80000 ORDER BY Salary DESC;

That’s correct! This query filters HR employees earning more than 80,000 and orders them by salary in descending order.

---

### 2. Question 2

The company is onboarding two new employees: Emma (ID 502, Sales) and Liam (ID 503, HR). How can you add both records to the Employees table using one query?

* [ ] INSERT Employees VALUES ('Emma', 'Sales', 502), ('Liam', 'HR', 503);
* [ ] INSERT INTO Employees (502, 'Emma', 'Sales', 503, 'Liam', 'HR');
* [ ] ADD INTO Employees VALUES (502, 'Emma', 'Sales', 503, 'Liam', 'HR');
* [X] INSERT INTO Employees (EmployeeID, FirstName, Department) VALUES (502, 'Emma', 'Sales'), (503, 'Liam', 'HR');

That’s correct! This query inserts two records into the Employees table in a single statement.

---

### 3. Question 3

You are tasked with increasing the price of all products in the Electronics category by 10%. How would you write this query?

* [ ] UPDATE Products SET Price = Price + 10% WHERE Category = 'Electronics';
* [ ] UPDATE Products SET Price = Price * 10 WHERE Category = 'Electronics';
* [X] UPDATE Products SET Price = Price * 1.10 WHERE Category = 'Electronics';

That’s correct! This query updates the price for all products in the Electronics category by increasing it by 10%.

* [ ] MODIFY Products SET Price = Price * 1.10 WHERE Category = 'Electronics';

---

### 4. Question 4

How would you delete a single employee record with EmployeeID 404 from the Employees table?

* [ ] DELETE Employees SET EmployeeID = 404;
* [ ] DELETE * FROM Employees WHERE EmployeeID = 404;
* [X] DELETE FROM Employees WHERE EmployeeID = 404;

That’s correct! This query deletes the employee with EmployeeID 404.

* [ ] REMOVE Employees WHERE EmployeeID = 404;

---

### 5. Question 5

How would you retrieve a list of customers and their orders, ensuring only customers who have placed orders are included?

* [ ] SELECT Customers.CustomerName, Orders.OrderID WHERE CustomerID = OrderID;
* [ ] SELECT * FROM Customers JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
* [X] SELECT Customers.CustomerName, Orders.OrderID FROM Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;

That’s correct! This query retrieves customer and order information using an INNER JOIN.

---

### 6. Question 6

You are tasked with finding all employees with salaries above 70,000, sorted by department and then by salary in descending order. Which query accomplishes this?

* [ ] SELECT * FROM Employees WHERE Department ORDER BY Salary DESC AND Salary > 70000;
* [X] SELECT * FROM Employees WHERE Salary > 70000 ORDER BY Department, Salary DESC;

That’s correct! This query filters employees earning above 70,000 and sorts them by department and descending salaries.

* [ ] SELECT Employees.Department WHERE Salary > 70000 ORDER Department, Salary DESC;
* [ ] SELECT * FROM Employees WHERE Salary > 70000 SORT Department, Salary DESC;

---

### 7. Question 7

You want to calculate the total sales revenue for all orders placed in 2023. Which query should you use?

* [ ] SUM(TotalAmount) SELECT FROM Orders WHERE OrderDate = '2023';
* [X] SELECT SUM(TotalAmount) FROM Orders WHERE OrderDate >= '2023-01-01' AND OrderDate <= '2023-12-31';

That’s correct! This query calculates the total revenue for orders in 2023.

* [ ] SELECT SUM(TotalAmount) FROM Orders WHERE OrderDate >= '2023';
* [ ] SELECT TotalAmount FROM Orders SUM WHERE OrderDate >= '2023-01-01' AND OrderDate <= '2023-12-31';

---

### 8. Question 8

How would you calculate the average order value for all orders placed in the last 6 months?

* [ ] AVG(OrderAmount) SELECT FROM Orders WHERE OrderDate >= '6 months';
* [X] SELECT AVG(OrderAmount) FROM Orders WHERE OrderDate >= DATEADD(MONTH, -6, GETDATE());

That’s correct! This query calculates the average order value for the last 6 months.

* [ ] SELECT AVG(OrderAmount) FROM Orders WHERE OrderDate = '6 months';
* [ ] SELECT OrderAmount AVG WHERE OrderDate >= '6 months ago';

---

### 9. Question 9

You want to create a new column combining the first and last names of all employees. Which query would you use?

* [X] SELECT CONCAT(FirstName, ' ', LastName) AS FullName FROM Employees;

That’s correct! This query combines first and last names into a new column named FullName.

* [ ] SELECT CONCAT(FirstName, LastName) FullName FROM Employees;
* [ ] SELECT FirstName + LastName AS FullName FROM Employees;
* [ ] SELECT Employees CONCAT(FirstName, LastName) AS FullName;

---

### 10. Question 10

How would you group all orders by customer and calculate the total order amount for each customer?

* [ ] SELECT CustomerID, SUM(OrderAmount) FROM Orders GROUP CustomerID;
* [ ] SUM(OrderAmount) SELECT CustomerID GROUP BY TotalAmount FROM Orders;
* [X] SELECT CustomerID, SUM(OrderAmount) AS TotalAmount FROM Orders GROUP BY CustomerID;

That’s correct! This query groups orders by customer and calculates their total order amount.

* [ ] SELECT SUM(OrderAmount) GROUP CustomerID AS TotalAmount FROM Orders;


### 1.

**Question 1**

A new feature in your application requires you to display **the first order** where the total amount exceeds $500. What EF Core method allows you to efficiently retrieve this record?

[x] Use the FirstOrDefault method with a condition.
[ ] Use the Find method with a filter condition.
[ ] Use the Remove method to reduce rows.
[ ] Use the Update method to filter rows.

---

### 2.

**Question 2**

Your company database has a Department entity, and each department contains multiple employees. To model this relationship in EF Core, what should you include in the Department entity?

[x] Add a navigation property in the Department entity that points to a list of Employee entities.
[ ] Apply the Update method to establish the connection.
[ ] Create a foreign key without navigation properties.
[ ] Use the Find method to link employees to departments.

---

### 3.

**Question 3**

A new employee’s details are stored in a C# object called newEmployee. To insert this record into the Employees table in your HR database, what steps should you follow using EF Core?

[ ] Use the FirstOrDefault method to add the employee record.
[x] Add the newEmployee object to the DbSet and call SaveChanges.
[ ] Call Remove to insert the employee into the table.
[ ] Use the Update method and skip SaveChanges.

---

### 4.

**Question 4**

A database column named customer_email must be mapped to the Email property of the Customer entity in your EF Core project. How can you achieve this?

[ ] Call Update to set the property name.
[ ] Use the Find method to define the mapping.
[x] Apply the [Column("customer_email")] attribute to the Email property.
[ ] Use the Add method to enforce the mapping.

---

### 5.

**Question 5**

Your application must fetch the first Order record where the total amount exceeds $500. Which EF Core method is appropriate for this operation?

[ ] Use the Update method to filter the records.
[ ] Use the Find method to retrieve the record.
[x] Use the FirstOrDefault method with a condition.
[ ] Apply the ToList method to fetch the record.

---

### 6.

**Question 6**

You are developing an inventory management application. A product’s quantity is updated in memory when an order is processed, but the change is not yet saved to the database. How can EF Core ensure this change is detected and persisted when SaveChanges is called?

[ ] Foreign key constraints
[ ] Manual SQL queries
[ ] The Update method
[x] Change Tracking

---

### 7.

**Question 7**

A product in the Products table needs to be removed from the database. The product object has already been retrieved. How can you delete this record?

[ ] Use the Find method to remove the product.
[ ] Apply the Update method to delete the product.
[ ] Call the Add method to delete the product.
[x] Use the Remove method on the product object and call SaveChanges.

---

### 8.

**Question 8**

In a library management system, a Book entity needs to have a one-to-many relationship with a Borrower entity. How would you define this relationship using Fluent API?

[ ] Use the ToList method to define the relationship.
[ ] Apply the Remove method to create the connection.
[ ] Use the Find method to set up the relationship.
[x] Configure the relationship in the OnModelCreating method of the DbContext.

---

### 9.

**Question 9**

In an employee management system, the salary of an Employee entity is modified but not yet saved. How does EF Core ensure this update is detected and ready to persist?

[ ] Foreign key updates
[ ] Reattaching entities
[ ] Manual SQL queries
[x] Change Tracking

---

### 10.

**Question 10**

A developer needs to define a default schema for all tables in a retail management database using EF Core. Where should they apply this configuration?

[x] In the OnModelCreating method of the DbContext.
[ ] Configure the schema using ToList.
[ ] Use the [Column] attribute on each table property.
[ ] Use the Find method to set the schema.

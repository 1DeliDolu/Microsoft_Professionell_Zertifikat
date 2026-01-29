
### 1. Question 1

An e-commerce platform stores customer data, including email addresses and passwords. To ensure data security during storage and transmission, what is the best approach?

* [ ] Apply database normalization
* [ ] Use indexes to organize sensitive data
* [ ] Use WHERE clauses to restrict sensitive data
* [X] Encrypt the data

That’s correct! Encryption protects sensitive data by ensuring it is only readable by authorized parties during storage and transmission.

---

### 2. Question 2

Which transaction property ensures that a system crash does not affect committed changes in a database?

* [ ] Isolation
* [X] Durability

That’s correct! Durability ensures that once changes are committed, they remain permanent even in the event of a system crash.

* [ ] Atomicity
* [ ] Consistency

---

### 3. Question 3

During a multi-step transaction, you want to create a recovery point to which you can roll back without undoing the entire transaction. What command allows this?

* [ ] ABORT
* [ ] ROLLBACK
* [ ] COMMIT
* [X] SAVEPOINT

That’s correct! The SAVEPOINT command creates a named point within a transaction, enabling partial rollbacks without canceling the entire transaction.

---

### 4. Question 4

A query on a customer database frequently uses a column containing ZIP codes to filter results. How can you improve the query’s performance?

* [ ] Apply a HAVING clause
* [ ] Normalize the database
* [ ] Use SELECT * to include all columns
* [X] Create an index on the ZIP code column

That’s correct! Indexing the ZIP code column improves retrieval speed for queries that frequently filter by this field.

---

### 5. Question 5

A large e-commerce platform experiences slow performance when retrieving product details based on SKU searches. How would you optimize this query?

* [ ] Add more memory to the server
* [ ] Denormalize the table
* [X] Add an index to the SKU column

That’s correct! Indexing the SKU column improves query performance by enabling efficient data retrieval.

---

### 6. Question 6

Which SQL performance technique involves creating a structure on one or more columns for faster data retrieval?

* [ ] Clustering
* [ ] Sharding
* [ ] Partitioning
* [X] Indexing

That’s correct! Indexing creates a structure that helps SQL queries retrieve data quickly by reducing full table scans.

---

### 7. Question 7

A warehouse database tracks inventory. The management wants to automate monthly inventory reconciliation by encapsulating a set of SQL commands into a reusable structure. What should you use?

* [X] Stored procedure

That’s correct! Stored procedures allow you to encapsulate SQL logic for automation and reuse.

* [ ] View
* [ ] Function
* [ ] Trigger

---

### 8. Question 8

Which transaction property ensures that changes remain even after a system failure once a transaction is complete?

* [ ] Logging
* [X] Durability

That’s correct! Durability ensures that changes from a completed transaction persist even if the system fails.

* [ ] Reconciliation
* [ ] Replication

---

### 9. Question 9

You want to prevent non-repeatable reads in a multi-user environment but allow phantom reads for improved performance. Which isolation level should you use?

* [X] Repeatable read

That’s correct! The repeatable read isolation level ensures that data read during a transaction does not change, preventing non-repeatable reads, though phantom reads may still occur.

* [ ] Read committed
* [ ] Read uncommitted
* [ ] Serializable

---

### 10. Question 10

A retail database allows customers to input text to search for products. How can you prevent SQL injection attacks through this feature?

* [ ] Implement data caching for queries
* [ ] Add a WHERE clause to filter input
* [X] Use parameterized queries

That’s correct! Parameterized queries prevent SQL injection by treating user input strictly as data, not executable code.

* [ ] Use SELECT * to limit query scope


### 1. Question 1

Which statement best explains the difference between subqueries and Common Table Expressions (CTEs) in SQL?

* [ ] Subqueries improve query performance, but CTEs add clarity by combining all results into a single table.
* [ ] Subqueries are reusable across multiple queries, whereas CTEs can only be used in specific clauses.
* [ ] Subqueries always return scalar values, while CTEs return tabular data only.
* [X] Subqueries are nested within another query and run once for each use, while CTEs are temporary result sets that can be referenced multiple times in a query.

That’s correct! Subqueries are single-use within a query, while CTEs improve query readability by being reusable within the same query.

---

### 2. Question 2

Which SQL operator is most suitable for finding employee names that start with "John"?

* [ ] WHERE ONLY
* [X] LIKE

That’s correct! The LIKE operator is used for pattern matching in text, such as finding names that begin with "John" when combined with the % wildcard.

* [ ] CASE
* [ ] IN

---

### 3. Question 3

A query needs to calculate the average sales per region and then display only regions with an average sales value above $1,000. Which SQL structure would best simplify this task?

* [X] A Common Table Expression (CTE)

That’s correct! CTEs improve readability by calculating the average sales in one step and filtering regions with averages above $1,000 in the main query.

* [ ] A join with another table containing regional averages
* [ ] A subquery in the SELECT clause
* [ ] The WHERE clause with the HAVING operator

---

### 4. Question 4

A company needs to find all departments with a total employee salary exceeding $500,000. Which SQL structure would you use to calculate this aggregate and filter the results?

* [ ] The WHERE clause
* [ ] A subquery in the FROM clause
* [X] The HAVING clause

That’s correct! The HAVING clause is used to filter aggregated results, such as total salaries, after the aggregation step.

* [ ] The GROUP BY clause

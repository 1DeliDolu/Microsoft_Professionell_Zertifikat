### 1.

Question 1

Compare a switch statement and a nested if-else structure for a program that processes commands (play, pause, stop). Which would be more efficient and why?

[ ]A nested if-else structure, because it allows handling multiple cases in a single condition

[ ]A nested if-else statement, because it supports combining ranges and conditions

[ ]Both are equally efficient for handling specific commands

[ ]A switch statement, because it provides better readability and avoids excessive nesting when handling discrete cases

1 point

### 2.

Question 2

A program requires validating a user’s age input to ensure it is between 18 and 60. Which control structure is most effective?

[ ]A switch statement, because it simplifies handling ranges

[ ]An if-else statement, because it allows checking ranges and providing feedback for invalid inputs

[ ]A for loop, because it iterates through possible age values

[ ]A while loop, because it keeps checking until the input is valid

1 point

### 3.

Question 3

Analyze the performance of different loop structures. Which loop would you use to iterate through an array when the number of elements is known in advance?

[ ]A for loop, because it provides a concise structure for iterating through a known range of elements

[ ]A do-while loop, because it ensures at least one iteration regardless of the condition

[ ]A while loop, because it offers better flexibility for unknown conditions

[ ]A nested loop, because it can handle multi-dimensional arrays more efficiently

1 point

### 4.

Question 4

You need to sum all the even numbers between 1 and 100. Analyze the options and select the best loop structure for this task.

[ ]A do-while loop, because it ensures the loop runs at least once

[ ]A for loop, because it can iterate efficiently while checking and summing only even numbers

[ ]A switch statement, because it simplifies decision-making for even numbers

[ ]A while loop, because it repeatedly evaluates the sum condition dynamically

1 point

### 5.

Question 5

How would you use nested loops to calculate the sum of elements in a two-dimensional array?

[ ]Use a single while loop to dynamically adjust to array dimensions

[ ]Use a do-while loop to process the array elements at least once

[ ]Use two for loops: the outer loop iterates through rows, and the inner loop iterates through columns, adding each element to the sum

[ ]Use a switch statement to manage each row and column

1 point

### 6.

Question 6

How would you validate a user’s age input to ensure it falls within a valid range (0-120)?

[ ]Use a switch statement to handle each possible age value

[ ]Use a while loop to check input continuously until valid

[ ]Use recursion to validate the age range dynamically

[ ]Use an if-else statement to check if the age is between 0 and 120 and prompt for re-entry if invalid

1 point

### 7.

Question 7

Analyze the following scenario: A program needs to count down from 10 to 1. Which loop structure is the best choice and why?

[ ]A recursive function, because it simplifies the countdown process

[ ]A while loop, because it can handle any condition.

[ ]A do-while loop, because it ensures the condition is checked after execution

[ ]A for loop, because it clearly defines the starting value, condition, and increment/decrement in one line – perfect when you know the exact range (like 10 to 1).

1 point

### 8.

Question 8

Which approach would you use to find all pairs of numbers in a one-dimensional array that add up to a specific target value without using nested loops?

[ ]Use a single loop and if-else statements to check for matching pairs

[ ]Use a single loop and a hash map (or dictionary) to store and check for the complement of each element

[ ]Use a while loop to iterate through each element and validate conditions dynamically

[ ]Use recursion to evaluate all combinations of numbers in the array

1 point

### 9.

Question 9

How would you combine loops and if-else statements to create a guessing game where a user guesses a number between 1 and 10?

[ ]Use a for loop to limit the number of guesses allowed

[ ]Use a do-while loop to keep prompting the user for guesses until correct, and an if-else statement to validate each guess

[ ]Use a switch statement to handle all possible guesses

[ ]Use recursion to handle each guess dynamically

1 point

### 10.

Question 10

Analyze the following scenario: A program processes orders in a queue and checks if the order amount exceeds $100. Which of the following correctly combines a loop and if-else statement to handle this task?

[ ]decimal[] orders = {50, 75};
do {
Console.WriteLine("Processing order.");
} while (false);

[ ]decimal[] orders = {100, 200};
for (int i = 0; i < orders.Length; i++) {
if (orders[i] < 50) {
Console.WriteLine("Small order: " + orders[i]);
}
}

[ ]int i = 0;
while (i < 3) {
i++;
if (i == 2) break;
}
Console.WriteLine("Orders completed.");

[ ]decimal[] orders = {50, 150, 30};
foreach (var order in orders) {
if (order > 100) {
Console.WriteLine("Large order: " + order);
} else {
Console.WriteLine("Small order: " + order);
}
} 



### 1) Doğru cevap

**A switch statement, because it provides better readability and avoids excessive nesting when handling discrete cases**

---

### 2) Doğru cevap

**An if-else statement, because it allows checking ranges and providing feedback for invalid inputs**

---

### 3) Doğru cevap

**A for loop, because it provides a concise structure for iterating through a known range of elements**

---

### 4) Doğru cevap

**A for loop, because it can iterate efficiently while checking and summing only even numbers**

---

### 5) Doğru cevap

**Use two for loops: the outer loop iterates through rows, and the inner loop iterates through columns, adding each element to the sum**

---

### 6) Doğru cevap

**Use an if-else statement to check if the age is between 0 and 120 and prompt for re-entry if invalid**

---

### 7) Doğru cevap

**A for loop, because it clearly defines the starting value, condition, and increment/decrement in one line – perfect when you know the exact range (like 10 to 1).**

---

### 8) Doğru cevap

**Use a single loop and a hash map (or dictionary) to store and check for the complement of each element**

---

### 9) Doğru cevap

**Use a do-while loop to keep prompting the user for guesses until correct, and an if-else statement to validate each guess**

---

### 10) Doğru cevap

**decimal[] orders = {50, 150, 30}; foreach (var order in orders) { if (order > 100) { Console.WriteLine("Large order: " + order); } else { Console.WriteLine("Small order: " + order); } }**

### 1.

Question 1

Which statement best describes the use of loops with control structures in programming?

[ ]Loops handle repetition, while control structures make decisions during each loop iteration

[ ]Loops and control structures repeat indefinitely without changing program flow

[ ]Control structures repeat code, while loops decide based on conditions

[ ]Loops and control structures should not be combined due to inefficiency


### 2.

Question 2

Which type of loop is best suited for a scenario where the number of iterations is known in advance?

[ ]The recursive function is best suited for repeating tasks where loops fail

[ ]The While loop is best suited for situations where the iterations are known

[ ]The For loop is best suited when the number of iterations is known beforehand

[ ]The Do-While loop is best suited to check the condition after executing



### 3.

Question 3

Which technique is recommended to optimize the performance of loops in a program?

[ ]The technique involves adding more conditional checks to every loop iteration

[ ]The technique involves increasing complexity and adding additional nested conditions

[ ]The technique involves using recursive functions in all cases instead of loops

[ ]The technique minimizes iterations and avoids nested loops when possible



### 4.

Question 4

Which of the following C# code snippets will iterate the most times?

[ ]for (int i = 0; i < 10; i++)

{
    Console.WriteLine("Number: " + i);
}

[ ]for (int i = 5; i > 0; i--)

{
    Console.WriteLine("Number: " + i);
}

[ ]int i = 0;

while (i < 10)
{
    Console.WriteLine("Number: " + i);
    break;
}

[ ]for (int i = 0; i < 10; i++)

{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine("Number: " + i);
}


### 1) Doğru cevap

**Loops handle repetition, while control structures make decisions during each loop iteration**

---

### 2) Doğru cevap

**The For loop is best suited when the number of iterations is known beforehand**

---

### 3) Doğru cevap

**The technique minimizes iterations and avoids nested loops when possible**

---

### 4) Doğru cevap

**for (int i = 0; i < 10; i++) { Console.WriteLine("Number: " + i); }**

Gerekçe (kısa):

* 1. seçenek 0’dan 9’a kadar **10 kez** yazar.
* 2. seçenek 5’ten 1’e **5 kez** yazar.
* 3. seçenek `break` nedeniyle **1 kez** çalışır.
* 4. seçenek `i == 5` olduğunda kırıldığı için **5 kez** yazar (0–4).

```csharp


using System;

class Program
{
    static void Main()
    {
        // 1) Create Variables for Books (up to five titles)
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        while (true) // 5) Loop Indefinitely
        {
            Console.WriteLine();
            Console.WriteLine("=== Library Management (Max 5 Books) ===");
            DisplayBooks(book1, book2, book3, book4, book5);

            Console.WriteLine();
            Console.Write("Choose an action (add / remove / exit): ");
            string action = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

            if (action == "exit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else if (action == "add")
            {
                // 7) Conditional Actions: Only allow adding if there are empty slots
                if (!HasEmptySlot(book1, book2, book3, book4, book5))
                {
                    Console.WriteLine("Library is full. No more books can be added.");
                    continue;
                }

                // 2) Add a Book
                Console.Write("Enter a book title to add: ");
                string titleToAdd = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(titleToAdd))
                {
                    Console.WriteLine("Invalid title. Please enter a non-empty book title.");
                    continue;
                }

                if (TryAddBook(ref book1, ref book2, ref book3, ref book4, ref book5, titleToAdd))
                {
                    Console.WriteLine($"Added: {titleToAdd}");
                }
                else
                {
                    // This should be rare due to HasEmptySlot check, but kept for safety
                    Console.WriteLine("Library is full. No more books can be added.");
                }
            }
            else if (action == "remove")
            {
                // 7) Conditional Actions: Only allow removing if there are books
                if (!HasAnyBook(book1, book2, book3, book4, book5))
                {
                    Console.WriteLine("Library is empty. There are no books to remove.");
                    continue;
                }

                // 3) Remove a Book
                Console.Write("Enter the exact title of the book to remove: ");
                string titleToRemove = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(titleToRemove))
                {
                    Console.WriteLine("Invalid title. Please enter a non-empty book title.");
                    continue;
                }

                if (TryRemoveBook(ref book1, ref book2, ref book3, ref book4, ref book5, titleToRemove))
                {
                    Console.WriteLine($"Removed: {titleToRemove}");
                }
                else
                {
                    Console.WriteLine("Book not found. Please check the title and try again.");
                }
            }
            else
            {
                // 6) Handle Invalid Inputs
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }
        }
    }

    // 4) Display the List of Books: show only non-empty slots
    static void DisplayBooks(string b1, string b2, string b3, string b4, string b5)
    {
        Console.WriteLine("Current books:");

        int count = 0;

        if (!string.IsNullOrWhiteSpace(b1)) { Console.WriteLine($"- {b1}"); count++; }
        if (!string.IsNullOrWhiteSpace(b2)) { Console.WriteLine($"- {b2}"); count++; }
        if (!string.IsNullOrWhiteSpace(b3)) { Console.WriteLine($"- {b3}"); count++; }
        if (!string.IsNullOrWhiteSpace(b4)) { Console.WriteLine($"- {b4}"); count++; }
        if (!string.IsNullOrWhiteSpace(b5)) { Console.WriteLine($"- {b5}"); count++; }

        if (count == 0)
            Console.WriteLine("(no books in library)");
    }

    static bool HasEmptySlot(string b1, string b2, string b3, string b4, string b5)
    {
        return string.IsNullOrWhiteSpace(b1)
            || string.IsNullOrWhiteSpace(b2)
            || string.IsNullOrWhiteSpace(b3)
            || string.IsNullOrWhiteSpace(b4)
            || string.IsNullOrWhiteSpace(b5);
    }

    static bool HasAnyBook(string b1, string b2, string b3, string b4, string b5)
    {
        return !string.IsNullOrWhiteSpace(b1)
            || !string.IsNullOrWhiteSpace(b2)
            || !string.IsNullOrWhiteSpace(b3)
            || !string.IsNullOrWhiteSpace(b4)
            || !string.IsNullOrWhiteSpace(b5);
    }

    // Adds to the first empty slot (uses ONLY string variables, no arrays/lists)
    static bool TryAddBook(ref string b1, ref string b2, ref string b3, ref string b4, ref string b5, string title)
    {
        if (string.IsNullOrWhiteSpace(b1)) { b1 = title; return true; }
        if (string.IsNullOrWhiteSpace(b2)) { b2 = title; return true; }
        if (string.IsNullOrWhiteSpace(b3)) { b3 = title; return true; }
        if (string.IsNullOrWhiteSpace(b4)) { b4 = title; return true; }
        if (string.IsNullOrWhiteSpace(b5)) { b5 = title; return true; }
        return false;
    }

    // Removes by matching title (case-insensitive)
    static bool TryRemoveBook(ref string b1, ref string b2, ref string b3, ref string b4, ref string b5, string title)
    {
        if (TitlesMatch(b1, title)) { b1 = ""; return true; }
        if (TitlesMatch(b2, title)) { b2 = ""; return true; }
        if (TitlesMatch(b3, title)) { b3 = ""; return true; }
        if (TitlesMatch(b4, title)) { b4 = ""; return true; }
        if (TitlesMatch(b5, title)) { b5 = ""; return true; }
        return false;
    }

    static bool TitlesMatch(string existingTitle, string userTitle)
    {
        if (string.IsNullOrWhiteSpace(existingTitle)) return false;
        return string.Equals(existingTitle.Trim(), userTitle.Trim(), StringComparison.OrdinalIgnoreCase);
    }
}
```


### **Part 1: Write C# Code Using Microsoft Copilot**

**Objective:**

You will create a simple library management system that stores up to five book titles using string variables. The system will allow users to add new books, remove a book, and display the list of available books.

**Problem Statement:**

Imagine you're a librarian managing a small collection of five books. You need a program that allows you to:

* Add books to the collection.
* Remove a book by its title.
* Display the current list of books available in the library.

With the help of Microsoft Copilot, you will build this program using string variables, conditional statements, and loops.

**Steps**

Create a C# console application that manages a small library of books. The program should:

1. **Create Variables for Books**:

   Set up five string variables to store the book titles.
2. **Add a Book**:

   Prompt the user to input a book title.

   Check which book variable is empty and store the new book in that variable.

   If all book slots are full, inform the user that no more books can be added.
3. **Remove a Book**:

   Ask the user to input the title of the book they want to remove.

   Check if the title exists in the collection and, if found, clear the corresponding variable.
4. **Display the List of Books**:

   Print out the list of books currently in the library, showing only the non-empty book slots.
5. **Loop Indefinitely:**

   Continuously prompt the user to choose whether they want to add or remove a book, or exit the program.

   If the user chooses to exit, break the loop and end the program.
6. **Handle Invalid Inputs**:

   If the user enters an invalid action (neither "add" nor "remove"), inform them and prompt again.
7. **Conditional Actions**:

   Only allow adding books if there are empty slots.

   Only allow removing books if there are books in the library.

**When completed, save your code. You will use this code to complete the final project in this course. **

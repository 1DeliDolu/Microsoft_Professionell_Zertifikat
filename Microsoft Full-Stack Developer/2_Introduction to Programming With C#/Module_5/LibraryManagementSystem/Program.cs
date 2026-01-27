using System;

class Program
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        bool book1CheckedOut = false;
        bool book2CheckedOut = false;
        bool book3CheckedOut = false;
        bool book4CheckedOut = false;
        bool book5CheckedOut = false;

        const int borrowLimit = 3;
        int borrowedCount = 0;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=== Library Management (Max 5 Books) ===");
            DisplayBooks(
                book1, book2, book3, book4, book5,
                book1CheckedOut, book2CheckedOut, book3CheckedOut, book4CheckedOut, book5CheckedOut);
            Console.WriteLine($"Borrowed books: {borrowedCount}/{borrowLimit}");

            Console.WriteLine();
            Console.Write("Choose an action (add / remove / search / checkout / checkin / exit): ");
            string action = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

            if (action == "exit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else if (action == "add")
            {
                if (!HasEmptySlot(book1, book2, book3, book4, book5))
                {
                    Console.WriteLine("Library is full. No more books can be added.");
                    continue;
                }

                Console.Write("Enter a book title to add: ");
                string titleToAdd = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(titleToAdd))
                {
                    Console.WriteLine("Invalid title. Please enter a non-empty book title.");
                    continue;
                }

                if (TryAddBook(
                    ref book1, ref book2, ref book3, ref book4, ref book5,
                    ref book1CheckedOut, ref book2CheckedOut, ref book3CheckedOut, ref book4CheckedOut, ref book5CheckedOut,
                    titleToAdd))
                {
                    Console.WriteLine($"Added: {titleToAdd}");
                }
                else
                {
                    Console.WriteLine("Library is full. No more books can be added.");
                }
            }
            else if (action == "remove")
            {
                if (!HasAnyBook(book1, book2, book3, book4, book5))
                {
                    Console.WriteLine("Library is empty. There are no books to remove.");
                    continue;
                }

                Console.Write("Enter the exact title of the book to remove: ");
                string titleToRemove = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(titleToRemove))
                {
                    Console.WriteLine("Invalid title. Please enter a non-empty book title.");
                    continue;
                }

                if (TryRemoveBook(
                    ref book1, ref book2, ref book3, ref book4, ref book5,
                    ref book1CheckedOut, ref book2CheckedOut, ref book3CheckedOut, ref book4CheckedOut, ref book5CheckedOut,
                    titleToRemove, ref borrowedCount))
                {
                    Console.WriteLine($"Removed: {titleToRemove}");
                }
                else
                {
                    Console.WriteLine("Book not found. Please check the title and try again.");
                }
            }
            else if (action == "search")
            {
                Console.Write("Enter a book title to search for: ");
                string titleToSearch = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(titleToSearch))
                {
                    Console.WriteLine("Invalid title. Please enter a non-empty book title.");
                    continue;
                }

                bool isCheckedOut;
                if (TryFindBook(
                    book1, book2, book3, book4, book5,
                    book1CheckedOut, book2CheckedOut, book3CheckedOut, book4CheckedOut, book5CheckedOut,
                    titleToSearch, out isCheckedOut))
                {
                    if (isCheckedOut)
                    {
                        Console.WriteLine("Book found, but it is currently checked out.");
                    }
                    else
                    {
                        Console.WriteLine("Book found and it is available.");
                    }
                }
                else
                {
                    Console.WriteLine("Book not found in the collection.");
                }
            }
            else if (action == "checkout")
            {
                if (!HasAnyBook(book1, book2, book3, book4, book5))
                {
                    Console.WriteLine("Library is empty. There are no books to check out.");
                    continue;
                }

                Console.Write("Enter the exact title of the book to check out: ");
                string titleToCheckOut = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(titleToCheckOut))
                {
                    Console.WriteLine("Invalid title. Please enter a non-empty book title.");
                    continue;
                }

                string message;
                if (TryCheckOut(
                    ref book1, ref book2, ref book3, ref book4, ref book5,
                    ref book1CheckedOut, ref book2CheckedOut, ref book3CheckedOut, ref book4CheckedOut, ref book5CheckedOut,
                    titleToCheckOut, ref borrowedCount, borrowLimit, out message))
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            else if (action == "checkin")
            {
                if (!HasAnyBook(book1, book2, book3, book4, book5))
                {
                    Console.WriteLine("Library is empty. There are no books to check in.");
                    continue;
                }

                Console.Write("Enter the exact title of the book to check in: ");
                string titleToCheckIn = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(titleToCheckIn))
                {
                    Console.WriteLine("Invalid title. Please enter a non-empty book title.");
                    continue;
                }

                string message;
                if (TryCheckIn(
                    ref book1, ref book2, ref book3, ref book4, ref book5,
                    ref book1CheckedOut, ref book2CheckedOut, ref book3CheckedOut, ref book4CheckedOut, ref book5CheckedOut,
                    titleToCheckIn, ref borrowedCount, out message))
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'search', 'checkout', 'checkin', or 'exit'.");
            }
        }
    }

    static void DisplayBooks(
        string b1, string b2, string b3, string b4, string b5,
        bool c1, bool c2, bool c3, bool c4, bool c5)
    {
        Console.WriteLine("Current books:");

        int count = 0;

        if (!string.IsNullOrWhiteSpace(b1)) { Console.WriteLine(FormatBookLine(b1, c1)); count++; }
        if (!string.IsNullOrWhiteSpace(b2)) { Console.WriteLine(FormatBookLine(b2, c2)); count++; }
        if (!string.IsNullOrWhiteSpace(b3)) { Console.WriteLine(FormatBookLine(b3, c3)); count++; }
        if (!string.IsNullOrWhiteSpace(b4)) { Console.WriteLine(FormatBookLine(b4, c4)); count++; }
        if (!string.IsNullOrWhiteSpace(b5)) { Console.WriteLine(FormatBookLine(b5, c5)); count++; }

        if (count == 0)
        {
            Console.WriteLine("(no books in library)");
        }
    }

    static string FormatBookLine(string title, bool isCheckedOut)
    {
        return isCheckedOut ? $"- {title} (checked out)" : $"- {title}";
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

    static bool TryAddBook(
        ref string b1, ref string b2, ref string b3, ref string b4, ref string b5,
        ref bool c1, ref bool c2, ref bool c3, ref bool c4, ref bool c5,
        string title)
    {
        if (string.IsNullOrWhiteSpace(b1)) { b1 = title; c1 = false; return true; }
        if (string.IsNullOrWhiteSpace(b2)) { b2 = title; c2 = false; return true; }
        if (string.IsNullOrWhiteSpace(b3)) { b3 = title; c3 = false; return true; }
        if (string.IsNullOrWhiteSpace(b4)) { b4 = title; c4 = false; return true; }
        if (string.IsNullOrWhiteSpace(b5)) { b5 = title; c5 = false; return true; }
        return false;
    }

    static bool TryRemoveBook(
        ref string b1, ref string b2, ref string b3, ref string b4, ref string b5,
        ref bool c1, ref bool c2, ref bool c3, ref bool c4, ref bool c5,
        string title, ref int borrowedCount)
    {
        if (TitlesMatch(b1, title)) { b1 = ""; if (c1) { c1 = false; borrowedCount--; } return true; }
        if (TitlesMatch(b2, title)) { b2 = ""; if (c2) { c2 = false; borrowedCount--; } return true; }
        if (TitlesMatch(b3, title)) { b3 = ""; if (c3) { c3 = false; borrowedCount--; } return true; }
        if (TitlesMatch(b4, title)) { b4 = ""; if (c4) { c4 = false; borrowedCount--; } return true; }
        if (TitlesMatch(b5, title)) { b5 = ""; if (c5) { c5 = false; borrowedCount--; } return true; }
        return false;
    }

    static bool TryFindBook(
        string b1, string b2, string b3, string b4, string b5,
        bool c1, bool c2, bool c3, bool c4, bool c5,
        string title, out bool isCheckedOut)
    {
        if (TitlesMatch(b1, title)) { isCheckedOut = c1; return true; }
        if (TitlesMatch(b2, title)) { isCheckedOut = c2; return true; }
        if (TitlesMatch(b3, title)) { isCheckedOut = c3; return true; }
        if (TitlesMatch(b4, title)) { isCheckedOut = c4; return true; }
        if (TitlesMatch(b5, title)) { isCheckedOut = c5; return true; }

        isCheckedOut = false;
        return false;
    }

    static bool TryCheckOut(
        ref string b1, ref string b2, ref string b3, ref string b4, ref string b5,
        ref bool c1, ref bool c2, ref bool c3, ref bool c4, ref bool c5,
        string title, ref int borrowedCount, int limit, out string message)
    {
        if (borrowedCount >= limit)
        {
            message = $"Borrowing limit reached ({limit}). Return a book first.";
            return false;
        }

        if (TitlesMatch(b1, title))
        {
            if (c1) { message = "That book is already checked out."; return false; }
            c1 = true; borrowedCount++; message = $"Checked out: {b1}";
            return true;
        }
        if (TitlesMatch(b2, title))
        {
            if (c2) { message = "That book is already checked out."; return false; }
            c2 = true; borrowedCount++; message = $"Checked out: {b2}";
            return true;
        }
        if (TitlesMatch(b3, title))
        {
            if (c3) { message = "That book is already checked out."; return false; }
            c3 = true; borrowedCount++; message = $"Checked out: {b3}";
            return true;
        }
        if (TitlesMatch(b4, title))
        {
            if (c4) { message = "That book is already checked out."; return false; }
            c4 = true; borrowedCount++; message = $"Checked out: {b4}";
            return true;
        }
        if (TitlesMatch(b5, title))
        {
            if (c5) { message = "That book is already checked out."; return false; }
            c5 = true; borrowedCount++; message = $"Checked out: {b5}";
            return true;
        }

        message = "Book not found. Please check the title and try again.";
        return false;
    }

    static bool TryCheckIn(
        ref string b1, ref string b2, ref string b3, ref string b4, ref string b5,
        ref bool c1, ref bool c2, ref bool c3, ref bool c4, ref bool c5,
        string title, ref int borrowedCount, out string message)
    {
        if (TitlesMatch(b1, title))
        {
            if (!c1) { message = "That book is not checked out."; return false; }
            c1 = false; borrowedCount--; message = $"Checked in: {b1}";
            return true;
        }
        if (TitlesMatch(b2, title))
        {
            if (!c2) { message = "That book is not checked out."; return false; }
            c2 = false; borrowedCount--; message = $"Checked in: {b2}";
            return true;
        }
        if (TitlesMatch(b3, title))
        {
            if (!c3) { message = "That book is not checked out."; return false; }
            c3 = false; borrowedCount--; message = $"Checked in: {b3}";
            return true;
        }
        if (TitlesMatch(b4, title))
        {
            if (!c4) { message = "That book is not checked out."; return false; }
            c4 = false; borrowedCount--; message = $"Checked in: {b4}";
            return true;
        }
        if (TitlesMatch(b5, title))
        {
            if (!c5) { message = "That book is not checked out."; return false; }
            c5 = false; borrowedCount--; message = $"Checked in: {b5}";
            return true;
        }

        message = "Book not found. Please check the title and try again.";
        return false;
    }

    static bool TitlesMatch(string existingTitle, string userTitle)
    {
        if (string.IsNullOrWhiteSpace(existingTitle)) return false;
        return string.Equals(existingTitle.Trim(), userTitle.Trim(), StringComparison.OrdinalIgnoreCase);
    }
}

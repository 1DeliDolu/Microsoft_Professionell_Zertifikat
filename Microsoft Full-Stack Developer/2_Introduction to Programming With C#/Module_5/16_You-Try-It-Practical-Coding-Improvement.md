## 🔎 Overview

### 🎯 Amaç

Çalışan ancak optimize edilmemiş bir *Library Management System* sürümünü alacak ve Microsoft Copilot kullanarak kalitesini ve verimliliğini artıracaksınız. Kodu daha okunabilir, daha kısa ve daha verimli olacak şekilde *refactor* edeceksiniz.

---

## 🧩 Bölüm 3: Microsoft Copilot ile Kod Kalitesini ve Verimliliğini Artırma

### 📝 Problem Tanımı

*Library Management System* çalışıyor, ancak optimize edilebilir. Microsoft Copilot’u kullanarak kodun okunabilirliğini artırın, tekrarları azaltın ve daha verimli hâle getirin. Şunları yapacaksınız:

* Kod tekrarını kaldırın
* Girdi doğrulamasını iyileştirin
* Kitap ekleme ve silmede büyük/küçük harf duyarlılığı sorunlarını giderin

---

## 🧪 Copilot’a Girilecek Başlangıç Kodu

```csharp
class LibraryManager
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";
        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine().ToLower();
            if (action == "add")
            {
                if (!string.IsNullOrEmpty(book1) && !string.IsNullOrEmpty(book2) && !string.IsNullOrEmpty(book3) && !string.IsNullOrEmpty(book4) && !string.IsNullOrEmpty(book5))
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to add:");
                    string newBook = Console.ReadLine();
                    if (string.IsNullOrEmpty(book1))
                    {
                        book1 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book2))
                    {
                        book2 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book3))
                    {
                        book3 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book4))
                    {
                        book4 = newBook;
                    }
                    else if (string.IsNullOrEmpty(book5))
                    {
                        book5 = newBook;
                    }
                }
            }
            else if (action == "remove")
            {
                if (string.IsNullOrEmpty(book1) && string.IsNullOrEmpty(book2) && string.IsNullOrEmpty(book3) && string.IsNullOrEmpty(book4) && string.IsNullOrEmpty(book5))
                {
                    Console.WriteLine("The library is empty. No books to remove.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to remove:");
                    string removeBook = Console.ReadLine();
                    if (removeBook == book1)
                    {
                        book1 = "";
                    }
                    else if (removeBook == book2)
                    {
                        book2 = "";
                    }
                    else if (removeBook == book3)
                    {
                        book3 = "";
                    }
                    else if (removeBook == book4)
                    {
                        book4 = "";
                    }
                    else if (removeBook == book5)
                    {
                        book5 = "";
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }
            // Display the list of books
            Console.WriteLine("Available books:");
            if (!string.IsNullOrEmpty(book1)) Console.WriteLine(book1);
            if (!string.IsNullOrEmpty(book2)) Console.WriteLine(book2);
            if (!string.IsNullOrEmpty(book3)) Console.WriteLine(book3);
            if (!string.IsNullOrEmpty(book4)) Console.WriteLine(book4);
            if (!string.IsNullOrEmpty(book5)) Console.WriteLine(book5);
        }
    }
}
```

---

## 🧭 Kod Kalitesini İyileştirme Adımları

### ✅ Programı Çalıştırarak İşlevselliği Test Edin

Kursun başında oluşturduğunuz Visual Studio Code konsol uygulamasını kullanın. Konsol uygulamanızın *Program.cs* dosyasındaki mevcut kodu kaldırın ve bu dosyaya **Copilot’a Girilecek Başlangıç Kodu**nu ekleyip çalıştırın.

Uygulamanın işlevselliğini doğrulayın.

---

### 🤖 Copilot’tan İyileştirme Önerileri Alın

Kod tekrarını azaltmak ve okunabilirliği artırmak için Microsoft Copilot’tan öneriler isteyin.

Örneğin, Copilot kitap ekleme veya silme gibi tekrarlayan işleri ele almak için bir metot kullanmayı önerebilir.

---

### 🧹 Kodu Basitleştirin

Copilot’un sağladığı önerileri kullanarak programı basitleştirin. Bu şunları içerebilir:

* Yardımcı metotlar oluşturma
* Değişken adlarını iyileştirme
* Kodun işlevini netleştirmek için yorum satırları ekleme

---

### 🧪 Basitleştirilmiş Programı Test Edin

Visual Studio Code konsol uygulamanızı kullanın. *Program.cs* dosyasındaki mevcut kodu kaldırın ve tüm güncellenmiş kodu bu dosyaya ekleyin.

Refactor işleminden sonra programı çalıştırın ve daha temiz ve verimli kodla aynı şekilde çalıştığını doğrulayın.

Tamamlandıktan sonra kodunuzu kaydedin. Bu kodu kursun final projesini tamamlamak için kullanacaksınız.

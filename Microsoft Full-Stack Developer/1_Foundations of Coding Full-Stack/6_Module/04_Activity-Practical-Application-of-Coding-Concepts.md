## 🧾 Boolean Mantık ve Koşullarla Bir Görev Yöneticisi Oluşturma

### 🎯 Amaç

En fazla üç görevi *ayrı string değişkenlerde* saklayan ve görevlerin tamamlanma durumunu *Boolean bayraklarla* izleyen basit bir görev yöneticisi programı oluşturacaksınız. Program, hangi görevlerin tamamlandığını ve hangilerinin beklemede olduğunu gösterecek.

---

## 🧩 Problem Tanımı

Küçük bir yapılacaklar listesi yöneten bir mühendis olduğunuzu hayal edin. Üç görev içeren basit bir program istiyorsunuz ve şunları yapabilmelisiniz:

* Bir görev eklemek
* Görevleri tamamlandı olarak işaretlemek
* Her görevin durumunu göstermek (*Completed* veya  *Pending* )

Kısıt: En fazla üç görev yönetebilirsiniz ve henüz *array* kullanmayı öğrenmediniz. Ancak bildiklerinizle bunu yine de yapabilirsiniz:  *değişkenler* , *if-else ifadeleri* ve  *döngüler* .

---

## 🧱 Adımlar

### 1) 🧾 Görevler ve Durumları İçin Değişkenler Oluşturma

* Üç adet `string` değişken oluşturun (görev metinlerini tutacak).
* Üç adet `bool` değişken oluşturun (her görevin tamamlanma durumunu takip edecek).

---

### 2) ➕ Kullanıcıdan Görev Alma

* Kullanıcıdan bir görev girmesini isteyin.
* Hangi görev değişkeni boşsa, yeni görevi o değişkene kaydedin.
* Üç görev slotu doluysa, kullanıcıya daha fazla görev eklenemeyeceğini söyleyin.

---

### 3) ✅ Bir Görevi Tamamlandı Olarak İşaretleme

* Kullanıcıya hangi görevi (1, 2 veya 3) tamamlandı olarak işaretleyeceğini sorun.
* `if-else` koşulları ile ilgili `bool` değişkenini `true` yapın.
* `if-else` koşulları ile görev durumunu güncelleyin ve kullanıcıya bir onay mesajı gösterin.
* Geçersiz bir seçim yapılırsa, hata mesajı gösterin.

---

### 4) 📋 Görevleri ve Durumlarını Gösterme

* Her görevi ve durumunu yazdırın (*Completed* veya  *Pending* ).
* `if-else` ile `bool` değerini kontrol ederek uygun durumu gösterin.

---

## 💻 C# Örnek Kod

Aşağıdaki kod, *array kullanmadan* (yalnızca değişkenler, if-else ve döngü ile) istenen senaryoyu çalıştırır:

```csharp
using System;

class Program
{
    static void Main()
    {
        // Task variables (up to 3 tasks)
        string task1 = "";
        string task2 = "";
        string task3 = "";

        // Completion flags
        bool task1Completed = false;
        bool task2Completed = false;
        bool task3Completed = false;

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Task Manager ---");
            Console.WriteLine("1) Add a task");
            Console.WriteLine("2) Mark a task as completed");
            Console.WriteLine("3) Display tasks");
            Console.WriteLine("4) Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter a task: ");
                string newTask = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newTask))
                {
                    Console.WriteLine("Error: Task cannot be empty.");
                }
                else if (task1 == "")
                {
                    task1 = newTask;
                    task1Completed = false;
                    Console.WriteLine("Task added to slot 1.");
                }
                else if (task2 == "")
                {
                    task2 = newTask;
                    task2Completed = false;
                    Console.WriteLine("Task added to slot 2.");
                }
                else if (task3 == "")
                {
                    task3 = newTask;
                    task3Completed = false;
                    Console.WriteLine("Task added to slot 3.");
                }
                else
                {
                    Console.WriteLine("No more tasks can be added. All slots are full.");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Which task number do you want to mark completed (1, 2, or 3)?: ");
                string taskNumber = Console.ReadLine();

                if (taskNumber == "1")
                {
                    if (task1 == "")
                    {
                        Console.WriteLine("Task 1 is empty. Add a task first.");
                    }
                    else
                    {
                        task1Completed = true;
                        Console.WriteLine("Task 1 marked as completed.");
                    }
                }
                else if (taskNumber == "2")
                {
                    if (task2 == "")
                    {
                        Console.WriteLine("Task 2 is empty. Add a task first.");
                    }
                    else
                    {
                        task2Completed = true;
                        Console.WriteLine("Task 2 marked as completed.");
                    }
                }
                else if (taskNumber == "3")
                {
                    if (task3 == "")
                    {
                        Console.WriteLine("Task 3 is empty. Add a task first.");
                    }
                    else
                    {
                        task3Completed = true;
                        Console.WriteLine("Task 3 marked as completed.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid task number. Please choose 1, 2, or 3.");
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("\n--- Current Tasks ---");

                // Task 1
                if (task1 == "")
                {
                    Console.WriteLine("1) [Empty]");
                }
                else
                {
                    if (task1Completed)
                        Console.WriteLine("1) " + task1 + " - Completed");
                    else
                        Console.WriteLine("1) " + task1 + " - Pending");
                }

                // Task 2
                if (task2 == "")
                {
                    Console.WriteLine("2) [Empty]");
                }
                else
                {
                    if (task2Completed)
                        Console.WriteLine("2) " + task2 + " - Completed");
                    else
                        Console.WriteLine("2) " + task2 + " - Pending");
                }

                // Task 3
                if (task3 == "")
                {
                    Console.WriteLine("3) [Empty]");
                }
                else
                {
                    if (task3Completed)
                        Console.WriteLine("3) " + task3 + " - Completed");
                    else
                        Console.WriteLine("3) " + task3 + " - Pending");
                }
            }
            else if (choice == "4")
            {
                running = false;
                Console.WriteLine("Exiting Task Manager...");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1, 2, 3, or 4.");
            }
        }
    }
}
```

---

## 🧪 Dot Net Fiddle’da Çalıştırma

Kodunuzu doğrudan **Dot Net Fiddle** üzerinde yazıp çalıştırabilirsiniz:

* Dot Net Fiddle’a gidin
* Sayfadaki mevcut kodu silin
* Yukarıdaki kodu sol taraftaki editöre yapıştırın
* **Run** seçeneğine tıklayın

İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak hızlı test için Dot Net Fiddle oldukça uygundur.

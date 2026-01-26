## 🗝️ Etkinlik: Kodlama Kavramlarının Pratik Uygulaması – Cevap Anahtarı

```csharp
using System;

public class TaskManager
{
     public static string task1 = "";
     public static string task2 = "";
     public static string task3 = "";
    
     public static bool task1Completed = false;
     public static bool task2Completed = false;
     public static bool task3Completed = false;

    public static void Main() 
    {
        // kullanıcı çıkana kadar çalışan bir döngü oluşturuyoruz
        Console.WriteLine("Seçenek seçin - (1)=Görev Ekle, (2)=Tamamlandı İşaretle, (3)=Görevleri Göster, (4)=Çık: ");
        string option = Console.ReadLine();

        while (option != "4") 
        {
            if (option == "1")
                EnterTask();
            else if (option == "2")
                MarkCompleted();
            else if (option == "3")
                DisplayTasks();
        
            if (option != "4") 
            {
                Console.WriteLine("Seçenek seçin - (1)=Görev Ekle, (2)=Tamamlandı İşaretle, (3)=Görevleri Göster, (4)=Çık: ");
                option = Console.ReadLine();
            }
        }
    }

    public static void EnterTask() 
    {
        Console.WriteLine("Görevinizi ekleyin: ");
        string newTask = Console.ReadLine();

        if (string.IsNullOrEmpty(task1)) 
        {
            task1 = newTask;
        }
        else if (string.IsNullOrEmpty(task2)) 
        {
            task2 = newTask;
        }
        else if (string.IsNullOrEmpty(task3)) 
        {
            task3 = newTask;
        }
        else 
        {
            Console.WriteLine("Görev listeniz dolu.");
        }
    }

    public static void MarkCompleted() 
    {
        Console.WriteLine("Hangi görevi tamamlandı olarak işaretlemek istersiniz (1, 2 veya 3)?");
        int taskToComplete = int.Parse(Console.ReadLine());

        if (taskToComplete == 1 && !string.IsNullOrEmpty(task1)) 
        {
            task1Completed = true;
            Console.WriteLine("1. görev tamamlandı olarak işaretlendi.");
        }
        else if (taskToComplete == 2 && !string.IsNullOrEmpty(task2)) 
        {
            task2Completed = true;
            Console.WriteLine("2. görev tamamlandı olarak işaretlendi.");
        }
        else if (taskToComplete == 3 && !string.IsNullOrEmpty(task3)) 
        {
            task3Completed = true;
            Console.WriteLine("3. görev tamamlandı olarak işaretlendi.");
        }
        else 
        {
            Console.WriteLine("Geçersiz görev seçimi.");
        }
    }

    public static void DisplayTasks() 
    {
        Console.WriteLine("Görevleriniz:");

        if (!string.IsNullOrEmpty(task1)) 
        {
            Console.WriteLine(task1Completed 
                ? "Görev 1: " + task1 + " [Tamamlandı]" 
                : "Görev 1: " + task1 + " [Beklemede]");
        }

        if (!string.IsNullOrEmpty(task2)) 
        {
            Console.WriteLine(task2Completed 
                ? "Görev 2: " + task2 + " [Tamamlandı]" 
                : "Görev 2: " + task2 + " [Beklemede]");
        }

        if (!string.IsNullOrEmpty(task3)) 
        {
            Console.WriteLine(task3Completed 
                ? "Görev 3: " + task3 + " [Tamamlandı]" 
                : "Görev 3: " + task3 + " [Beklemede]");
        }
    }
}
```

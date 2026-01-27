
## 🧪 Deneyin! Küçük Bir Proje Oluşturma ve Programı Debug Etme - Cevap Anahtarı

### 📦 Adım 2: Görev Listesini Oluşturma

```csharp
public class ToDoList
{
    // Array to hold up to 10 tasks
    public static string[] tasks = new string[10];

    // Variable to count the number of tasks
    public static int taskCount = 0;
}
```

---

### ➕ Adım 3: Görev Ekleme

```csharp
public static void AddTask()
{
    Console.WriteLine("Enter a new task:");
    tasks[taskCount] = Console.ReadLine();
    taskCount++;
}
```

---

### 👀 Adım 4: Görevleri Görüntüleme

```csharp
public static void ViewTasks()
{
    for (int i = 0; i < taskCount; i++)
    {
        Console.WriteLine((i + 1) + ". " + tasks[i]);
    }
}
```

---

### ✅ Adım 5: Görevi Tamamlandı Olarak İşaretleme

```csharp
public static void CompleteTask()
{
    Console.WriteLine("Enter the number of the task to mark as complete:");
    int taskNumber = int.Parse(Console.ReadLine()) - 1;

    if (taskNumber >= 0 && taskNumber < taskCount)
    {
        tasks[taskNumber] = tasks[taskNumber] + " (Completed)";
        Console.WriteLine("Task marked as complete.");
    }
    else
    {
        Console.WriteLine("Invalid task number.");
    }
}
```

---

## ▶️ Adım 6: Programı Çalıştırma

```csharp
public class ToDoList
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;

    public static void AddTask()
    {
        Console.WriteLine("Enter a new task:");
        tasks[taskCount] = Console.ReadLine();
        taskCount++;
    }

    public static void ViewTasks()
    {
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }
    }

    public static void CompleteTask()
    {
        Console.WriteLine("Enter the number of the task to mark as complete:");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;

        if (taskNumber >= 0 && taskNumber < taskCount)
        {
            tasks[taskNumber] = tasks[taskNumber] + " (Completed)";
            Console.WriteLine("Task marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark a task as complete");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
```

---

### 🐛 Adım 7: Debugging Teknikleri

```csharp
public static void CompleteTask()
{
    Console.WriteLine("Enter the number of the task to mark as complete:");
    int taskNumber = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Task number is: " + taskNumber); // Debugging line

    if (taskNumber >= 0 && taskNumber < taskCount)
    {
        tasks[taskNumber] = tasks[taskNumber] + " (Completed)";
        Console.WriteLine("Task marked as complete.");
    }
    else
    {
        Console.WriteLine("Invalid task number. Please try again.");
    }
}
```

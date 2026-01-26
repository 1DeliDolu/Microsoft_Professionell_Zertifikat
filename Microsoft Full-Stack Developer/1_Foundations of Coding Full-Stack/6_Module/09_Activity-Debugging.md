## 🐞 Bir Görev Yöneticisi Programında Debugging: Mantık Hatalarını Belirleme ve Düzeltme

## 🎯 Amaç

Bu etkinlikte, önceden var olan bir görev yöneticisi programında debugging yapacaksınız. Görev ekleme ve tamamlama fonksiyonlarındaki mantık hatalarını belirleyip düzeltecek, görevlerin doğru şekilde saklandığından, tamamlandı olarak işaretlendiğinden ve doğru biçimde görüntülendiğinden emin olacaksınız.

---

## 🧩 Kod

```csharp
using System;
using System.Collections.Generic;

class TaskManager
{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Completed");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Exit");
Console.WriteLine("What would you like to do? (choose 1-4)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter task description:");
        string task = Console.ReadLine();
        tasks.Add(task);
        taskStatus.Add(false);  // Marking as not completed by default
        Console.WriteLine("Task added successfully.");
    }

    static void CompleteTask()
    {
        Console.WriteLine("Enter task number to mark as completed:");
        int taskNumber = int.Parse(Console.ReadLine());

        if (taskNumber < 0 || taskNumber >= tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }

        taskStatus[taskNumber] = true;
        Console.WriteLine($"Task '{tasks[taskNumber]}' marked as completed.");
    }

    static void ViewTasks()
    {
        Console.WriteLine("Tasks:");
        for (int i = 0; i <= tasks.Count; i++)
        {
            string status = taskStatus[i] ? "Completed" : "Pending";
            Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
        }
    }
}
```

---

## 🪜 Adımlar

### 🧱 Adım Adım Kod Oluşturma

### 1) 📚 Liste Kullanımındaki Hataları Belirleyin

Kod, görevleri ve tamamlanma durumlarını saklamak için listeler kullanır. Listelere aşina değilseniz, onları birden fazla değer tutabilen koleksiyonlar (dizilere benzer) olarak düşünebilirsiniz. Görevlerin ve durumlarının doğru şekilde erişilip erişilmediğini kontrol edin.

* Görevlerin listeye nasıl eklendiğini gözden geçirin.
* Bir döngü kullanarak listeyi dolaşıp görevleri doğru şekilde görüntüleyebildiğinizden emin olun.
* Liste indekslemesi veya listeye görev ekleme ile ilgili sorunları debug edin.

---

### 2) 🔢 Görev Numaraları İçin Kullanıcı Girdisini Doğrulayın

Program, kullanıcıların görev seçmek için sayı girmesini ister. Girdinin doğru şekilde doğrulandığından ve ayrıştırıldığından emin olmanız gerekir.

* Kullanıcı girdisinin geçerli bir sayı olduğundan emin olmak için `int.TryParse` kullanın.
* Kodun geçersiz girdileri (sayısal olmayan veya aralık dışı değerler) doğru şekilde ele aldığını kontrol edin.
* Görevlere yalnızca geçerli numaralarla (1 ile mevcut görev sayısı arasında) erişildiğinden emin olun.

*İpucu:* Girdi yanlış olduğunda kullanıcıları dostça bir hata mesajıyla yönlendirebilirsiniz.

---

### 3) 🧭 Menü ve Kontrol Akışını Debug Edin

Program, ana menüde gezinmek için bir `switch` ifadesi kullanır. Her seçeneğin doğru çalıştığından emin olun:

* Her menü seçeneğinin (ör. görevleri görüntüleme, görevi tamamlandı işaretleme) doğru işlevselliğe yönlendirdiğini kontrol edin.
* Her işlem tamamlandıktan sonra programın ana menüye döndüğünden emin olun.

*İpucu:* `"Exit"` seçeneğinin programdan düzgün şekilde çıktığını da doğrulamalısınız.

---

### 4) 🔁 Görevleri Görüntüleme ve Tamamlama Döngü Mantığını Kontrol Edin

Kodda görevleri görüntülemek ve görevleri tamamlandı olarak işaretlemek için döngüler bulunur. Döngülerin her görevi nasıl işlediğiyle ilgili problemleri debug edin.

* Görevleri görüntülerken döngünün listedeki her görevi doğru şekilde dolaştığından emin olun.
* Bir görevi tamamlandı olarak işaretlemenin görevin durumunu doğru şekilde güncellediğini doğrulayın.

---

### 5) 🧪 Sınır Durumlarını Test Edin

Program farklı durumları ele alabilmelidir, örneğin:

* Hiç görev yokken ne olur?
* Kullanıcı var olmayan bir görevi tamamlandı olarak işaretlemeye çalışırsa ne olur?

---

### 6) 🛡️ Çökmeden ve Yanlış Sonuç Üretmeden Yönetildiğinden Emin Olun

Kodun bu senaryoları çökmeden veya yanlış sonuç üretmeden doğru şekilde ele aldığından emin olun.

---

### 7) ✅ Son Testler

Debug işleminden sonra, işlevselliği test etmek için programı birden fazla kez çalıştırın. Kodu çalıştırmak için  *Dot Net Fiddle* ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve **run** seçeneğini seçin.

* Birkaç görev ekleyin ve görüntüleyin.
* Görevleri tamamlandı olarak işaretleyin ve durumun doğru güncellenip güncellenmediğini kontrol edin.
* Geçersiz girdileri (sayısal olmayan, negatif sayılar, çok büyük sayılar) deneyin ve programın bunları zarif biçimde ele aldığından emin olun.

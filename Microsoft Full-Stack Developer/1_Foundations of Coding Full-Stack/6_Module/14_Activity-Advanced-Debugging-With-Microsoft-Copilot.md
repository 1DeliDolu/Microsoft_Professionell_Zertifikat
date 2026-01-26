## 🚀 Microsoft Copilot ile Gelişmiş Debugging

### 🎯 Amaç

Microsoft Copilot’u kullanarak bir kod bloğundaki gelişmiş sorunları tespit etmeye ve düzeltmeye yardımcı olacaksınız. Bu görev, *AI destekli debugging* ile problem çözme becerilerinizi güçlendirecek; özellikle  *döngü optimizasyonu* , *girdi doğrulama* ve *edge-case yönetimi* gibi alanlara odaklanacaktır.

---

## 🧭 Adım Adım Kod Oluşturma

### 1) 🔍 Kodun İlk İncelemesi

Önce verilen kodu inceleyin. Kodda:

* Döngü verimsizlikleri
* Eksik girdi doğrulaması
* Edge-case’lerin yanlış ele alınması

gibi problemler bulunur. Değişiklik yapmadan önce, olası problem alanlarını manuel olarak analiz edin.

---

### 2) 🧠 Copilot ile Mantık Hatalarını Belirleme

* Microsoft Copilot’u aktif edin ve kodu IDE’nize yükleyin.
* Copilot’tan kodu iyileştirmeye yönelik öneriler isteyin: verimsiz döngüler, doğrulama eksikleri, gereksiz işlemler vb.
* Copilot’un önerilerini kullanarak kaçırmış olabileceğiniz hataları bulun; özellikle listede item işleme ve döngü mantığına odaklanın.

**Örnek prompt:**

```text
Copilot, suggest improvements for this loop to handle all task scenarios.
```

---

### 3) ⚡ Copilot ile Döngü Optimizasyonu

* Copilot önerisi geldikten sonra döngü yapısına odaklanın.
* Loop’u yeniden yazarak tüm item’ları doğru ve gereksiz iterasyon olmadan işlemesini sağlayın.
* Boş liste veya sınır durumlarında döngünün verimli çalıştığından emin olun.

**Örnek prompt:**

```text
How can I optimize this loop for better performance?
```

---

### 4) 🛡️ Girdi Doğrulamasını Güçlendirme

Bu kodda girdi doğrulama daha sağlam hâle getirilebilir:

* Sayısal olmayan girişler
* Aralık dışı sayılar
* Boş string gibi edge-case’ler

Copilot’tan zayıf noktaları göstermesini isteyin; önerilerini uygulayın ve farklı senaryolarda test edin.

**Örnek prompt:**

```text
Can you suggest how to strengthen this input validation block?
```

---

### 5) 🧩 Edge-Case’leri Yönetme

Kod, sıra dışı kullanıcı davranışlarında kırılabilir. Örneğin:

* Hiç görev yokken “tamamla” seçilmesi
* Var olmayan bir görevi tamamlandı işaretleme
* Programdan beklenmedik çıkışlar

Copilot’tan bu edge-case’leri zarif şekilde ele almayı önermesini isteyin; önerileri uygulayın.

---

### 6) ✅ Son Test ve Doğrulama

Copilot önerilerini uyguladıktan sonra çoklu test yapın:

* Geçerli ve geçersiz girişler
* Küçük ve büyük veri setleri
* Boş liste ve boundary senaryoları

Girdi doğrulamasının çökme veya yanlış davranışı engellediğini doğrulayın.

---

## 🧱 Copilot ile Debugging Yapılacak Kod Bloğu

```csharp
using System;
using System.Collections.Generic;  // Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Display tasks
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        break;

                    case 2:
                        Console.Write("Enter the task: ");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("Task added.");
                        break;

                    case 3:
                        Console.WriteLine("Enter the task number to mark complete: ");
                        int taskNumber;
                        if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                        {
                            tasks[taskNumber - 1] += " [Complete]";
                            Console.WriteLine("Task marked as complete.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
```

---

## 🧠 Ek Yönlendirme

### 🧾 Copilot’tan Açıklama İsteyin

Copilot’un sadece “fix” üretmesini değil, *neden* bu öneriyi yaptığını da açıklamasını isteyin. Bu, ileri seviye debugging ve optimizasyon mantığını anlamanıza yardımcı olur.

### 🔁 Alternatif Çözümler Deneyin

Copilot önerileri sonrası alternatif yaklaşımlar deneyerek *okunabilirlik* ve *performans* farklarını karşılaştırın.

### 📝 Süreci Değerlendirin

Debugging tamamlandıktan sonra Copilot’un iyi yaptığı şeyleri ve sizin daha çok müdahale ettiğiniz noktaları not alın.

---

Bu süreçte Microsoft Copilot’u kullanarak yalnızca hataları düzeltmekle kalmayacak, aynı zamanda kodunuzun verimliliğini ve dayanıklılığını artırmak için yapay zekâdan nasıl faydalanacağınızı da öğreneceksiniz.

## 🧪 Etkinlik: Pratik Asenkron Çözümler Oluşturma — Cevap Anahtarı

---

## 1️⃣ Problem 1: Dosyaları Asenkron Olarak İndirme

```csharp
public async Task DownloadFilesAsync()
{
    // Start downloading "File1.txt" and "File2.txt" concurrently
    var downloadTask1 = DownloadFileAsync("File1.txt");
    var downloadTask2 = DownloadFileAsync("File2.txt");

    // Wait for both downloads to complete
    await Task.WhenAll(downloadTask1, downloadTask2);

    Console.WriteLine("All downloads completed.");
}

public static async Task Main(string[] args)
{
    Program program = new Program();
    await program.DownloadFilesAsync();
}
```

### 📝 Açıklama

**DownloadFileAsync Metodu:** Bu metot, 3 saniye duraklayarak bir dosyanın indirilmesini simüle eder. Bu metodu değiştirmenize gerek yoktur.

**DownloadFilesAsync Metodu:** Bu metodu, `DownloadFileAsync`’i iki kez çağırarak iki dosyayı eşzamanlı indirmeyi başlatacak şekilde tamamlamanız gerekir. Her iki indirmenin de devam etmeden önce tamamlandığından emin olmak için `Task.WhenAll` kullanın.

**Kodu Çalıştırma:** **Main** metodunu çalıştırdığınızda, indirmelerin başladığını ve bittiğini belirten mesajları görmeli, ardından tüm indirmelerin tamamlandığını söyleyen son bir mesaj almalısınız.

---

## 2️⃣ Problem 2: Veri Parçalarını Asenkron Olarak İşleme

```csharp
public async Task ProcessLargeDatasetAsync(int numberOfChunks)
{
    var tasks = new List<Task>();

    // Start processing each chunk concurrently
    for (int i = 1; i <= numberOfChunks; i++)
    {
        tasks.Add(ProcessDataChunkAsync(i));
    }

    // Wait for all tasks to complete
    await Task.WhenAll(tasks);

    Console.WriteLine("All data chunks processed.");
}

public static async Task Main(string[] args)
{
    Program program = new Program();
    await program.ProcessLargeDatasetAsync(5); // Process 5 chunks
}
```

### 📝 Açıklama

**ProcessDataChunkAsync Metodu:** Bu metot, tek bir veri parçasının işlenmesini simüle eder. Bu metodu değiştirmenize gerek yoktur.

**ProcessLargeDatasetAsync Metodu:** Bu metodu, birden fazla parçayı eşzamanlı olarak işlemeyi başlatacak şekilde tamamlamanız gerekir. Döngüyle her parça için bir task oluşturun, listeye ekleyin ve tüm task’lerin bitmesini sağlamak için `Task.WhenAll` kullanın. Ardından tamamlandığını belirten bir mesaj yazdırın.

**Kodu Çalıştırma:** **Main** metodunu çalıştırdığınızda, her parça için “işleniyor” ve “tamamlandı” mesajlarını, en son da tüm veri parçalarının işlendiğini belirten bir mesajı görmelisiniz.

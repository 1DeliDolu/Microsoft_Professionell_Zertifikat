## 🧪 Sen Deneyin! C#’ta `async` ve `await` Kullanımı — Cevap Anahtarı

---

## 2️⃣ Adım: Asenkron Bir Metot Oluşturma

```csharp
public class Program
{
	public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }
}
```

---

## 3️⃣ Adım: Birden Fazla Asenkron Metot Çalıştırma

```csharp
public class Program
{
	public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }
    public static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.DownloadDataAsync();
        Console.WriteLine("Main method completed.");
    }
}
```

---

## 4️⃣ Adım: Birden Fazla Asenkron Metodu Paralel Çalıştırma

```csharp
public class Program
{
	public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }
    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        await Task.Delay(2000);
        Console.WriteLine("Download 2 completed.");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All downloads completed.");
    }
}
```

---

## 5️⃣ Adım: Asenkron Metotlarda İstisna Yönetimi

```csharp
public class Program
{

    public async Task DownloadDataAsync()
    {
        try
        {
            Console.WriteLine("Download started...");
            throw new InvalidOperationException("Simulated download error.");
            await Task.Delay(3000);
            Console.WriteLine("Download completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        await Task.Delay(2000);
        Console.WriteLine("Download 2 completed.");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All downloads completed.");
    }
}
```

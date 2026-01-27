## 🧩 Etkinlik: Pratik Asenkron Çözümler Oluşturma

### 🎯 Amaç

Bu etkinlik, veri çekme ve birden fazla asenkron görevi yönetme gibi pratik senaryolarda **async** ve **await** kullanımını gösteren kod örnekleri sunar. Örnekler, asenkron programlamada en iyi uygulamaları ( *best practices* ) sergiler ve bu tekniklerin kullanıcı deneyimini nasıl iyileştirebileceğini gösterir. Örnekleri inceledikten sonra, öğrenenler bu kavramları ek problemleri çözmek için uygular.

---

### 📝 Açıklama

Bu etkinlik, veri çekme ve birden fazla asenkron görevi yönetme gibi pratik senaryolarda **async** ve **await** kullanımını gösteren kod örnekleri sunar. Örnekler, asenkron programlamada en iyi uygulamaları ( *best practices* ) sergiler ve bu tekniklerin kullanıcı deneyimini nasıl iyileştirebileceğini gösterir. Örnekleri inceledikten sonra, öğrenenler bu kavramları ek problemleri çözmek için uygular.

---

## 🧰 Ortamınızı Kurun

Kursun başında oluşturduğunuz Visual Studio Code konsol uygulamasını kullanın. Konsol uygulamanızın **Program.cs** dosyasındaki mevcut tüm kodları kaldırın.

Bu etkinlikteki kodu **Program.cs** dosyasına kopyalayıp düzenleyerek adımları tamamlayın.

---

## 🧪 Örnek 1: Ürün Verisini Asenkron Olarak Getirme

### ❓ Problem

Bir uygulamanın uzak bir sunucudan bir ürün listesini çektiği bir senaryoyu simüle edin. Getirme işlemi zaman aldığı için ana iş parçacığını ( *main thread* ) bloklamamak adına asenkron yapılmalıdır.

```csharp
public class Product
{
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

public class Program
{
    // Asynchronous method to fetch product data
    public async Task<List<Product>> FetchProductsAsync()
    {
        await Task.Delay(2000); // Simulating a 2-second delay for data fetching
        return new List<Product>
        {
            new Product("Eco Bag"),
            new Product("Reusable Straw")
        };
    }

    // Asynchronous method to display product data
    public async Task DisplayProductsAsync()
    {
        List<Product> products = await FetchProductsAsync();
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }
    }

    // Main entry point
    public static async Task Main(string[] args)
    {
        // Calling the asynchronous method
        Program program = new Program();
        await program.DisplayProductsAsync();
    }
}
```

### 🧭 Adımların Açıklaması

**Asenkron Bir Metot Tanımlama (FetchProductsAsync):**

* Metot öncesindeki **async** anahtar sözcüğü, metodun asenkron olduğunu belirtir.
* `Task.Delay(2000)`, 2 saniye süren bir API çağrısını simüle eder.
* Metot, **Product** nesnelerinden oluşan bir liste döndürür.

**DisplayProductAsync için asenkron bir metot tanımlama:**

* **await** anahtar sözcüğü, devam etmeden önce `FetchProductsAsync` tamamlanana kadar bekler.
* Ana iş parçacığı veri çekilirken duyarlı kalır.
* Veri çekildikten sonra, metot `foreach` döngüsüyle ürün listesini dolaşır ve her ürünün adını konsola yazdırır.

**Main içinde Asenkron Metodu Çağırma:**

* `await program.DisplayProductsAsync()` programın çıkmadan önce verinin görüntülenmesini beklemesini sağlar.
* `Program program = new Program();` **Program** sınıfından bir örnek oluşturur.

---

## 🧪 Örnek 2: Birden Fazla Asenkron Görevi Eşzamanlı Çalıştırma

### ❓ Problem

Önceki örneği genişleterek hem ürünleri hem de yorumları asenkron şekilde çekin; bir uygulamanın aynı anda birden fazla veri kaynağını yönetmesi gereken bir senaryoyu simüle edin.

```csharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Product
{
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

public class Review
{
    public string Content { get; set; }

    public Review(string content)
    {
        Content = content;
    }
}

public class Program
{
    // Asynchronous method to fetch product data
    public async Task<List<Product>> FetchProductsAsync()
    {
        await Task.Delay(2000); // Simulating a 2-second delay for fetching products
        return new List<Product> { new Product("Eco Bag"), new Product("Reusable Straw") };
    }

    // Asynchronous method to fetch review data
    public async Task<List<Review>> FetchReviewsAsync()
    {
        await Task.Delay(3000); // Simulating a 3-second delay for fetching reviews
        return new List<Review>
        {
            new Review("Great product!"),
            new Review("Good value for the money."),
        };
    }

    // Asynchronous method to display both products and reviews
    public async Task FetchDataAsync()
    {
        // Start fetching products and reviews concurrently
        Task<List<Product>> productsTask = FetchProductsAsync();
        Task<List<Review>> reviewsTask = FetchReviewsAsync();

        // Wait for both tasks to complete
        await Task.WhenAll(productsTask, reviewsTask);

        // Get the results
        List<Product> products = await productsTask;
        List<Review> reviews = await reviewsTask;

        // Display the results
        Console.WriteLine("Products:");
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }

        // Display fetched reviews
        Console.WriteLine("\nReviews:");
        foreach (Review review in reviews)
        {
            Console.WriteLine(review.Content);
        }
    }

    // Main entry point
    public static async Task Main(string[] args)
    {
        // Calling the asynchronous method to fetch and display products and reviews
        Program program = new Program();
        await program.FetchDataAsync();
    }
}
```

### 🧭 Adımların Açıklaması

**Review Sınıfını Tanımlama:**

* **Product** sınıfına benzer şekilde yeni bir **Review** sınıfı eklenir.
* İçinde, yorum içeriğini temsil eden tek bir özellik olan **Content** bulunur.

**Birden Fazla Async Metodu Çalıştırma (FetchProductAsync ve FetchReviewAsync):**

* Her birinin sıralı şekilde bitmesini beklemeden iki görevi eşzamanlı başlatın.
* Sonuçları işlemeden önce her iki görevin de tamamlanmasını sağlamak için `Task.WhenAll` kullanın.

**Asenkron Görevlerin Sonuçlarına Erişme:**

* Her iki görev de bittikten sonra veriyi almak için `.Result` özelliğini kullanın.

**Veriyi Görüntüleme:**

* Çekilen ürünleri ve yorumları konsola yazdırın.

---

## 🧩 Tamamlanacak Problemler

## 1️⃣ Problem 1: Dosyaları Asenkron Olarak İndirme

### 🧠 Problem Açıklaması

Verilen kodda, C#’ta asenkron programlamayla ilgili bazı anahtar sözcükler kaldırılmıştır. Göreviniz, kodun doğru çalışması için boşlukları `(_____)` doğru **async** veya **await** anahtar sözcükleriyle doldurmaktır.

* Bir metodun asenkron olduğunu belirtmeniz gereken yerde **async** kullanın.
* Bir asenkron işlemin tamamlanmasını beklemeniz gereken yerde **await** kullanın.

Şunları unutmayın:

* **Task** veya **Task** döndüren metotlar **async** ile işaretlenmelidir.
* Beklenmesi gereken ( *await* ) işlemlerin önüne **await** gelmelidir.

Alıştırmayı tamamladıktan sonra kod, iki dosyayı eşzamanlı indirecek ve her indirme için başlangıç ve tamamlanma mesajlarını yazdıracaktır.

### 🧩 Başlangıç Kodu

```csharp
public class Program
{
public _____ Task<string> DownloadFileAsync(string fileName)
{
    Console.WriteLine($"Starting download of {fileName}...");
    _____ Task.Delay(3000); // Simulate a 3-second download time
    Console.WriteLine($"Completed download of {fileName}.");
    return $"{fileName} content";
}

public _____ Task DownloadFilesAsync()
{
    // Start downloading "File1.txt" and "File2.txt" concurrently
    var downloadTask1 = DownloadFileAsync("File1.txt");
    var downloadTask2 = DownloadFileAsync("File2.txt");


    // Wait for both downloads to complete
    _____ Task.WhenAll(downloadTask1, downloadTask2);
    Console.WriteLine("All downloads completed.");
}

public static _____ Task Main(string[] args)
{
    Program program = new Program();
    _____ program.DownloadFilesAsync();
}
}
```

---

## 2️⃣ Problem 2: Veri Parçalarını Asenkron Olarak İşleme

### 🧠 Görev

Verilen kodda asenkron programlama anahtar sözcüklerinin bazıları kaldırılmıştır. Göreviniz, bağlama uygun şekilde **async** veya **await** kullanarak `(_____)` boşluklarını doğru biçimde doldurmaktır.

* Asenkron işlemler yapacak ve **Task** döndürecek bir metot tanımlarken **async** kullanın.
* Kodun devam etmeden önce bir asenkron işlemin tamamlanmasını beklemesi gereken yerde **await** kullanın.

Boşlukları doldurduğunuzda kod, veri parçalarını eşzamanlı olarak asenkron biçimde işleyecek ve her parça başladığında ve bittiğinde mesaj yazdıracaktır.

### 🧩 Başlangıç Kodu

```csharp
public class Program
{
    public _____ Task ProcessDataChunkAsync(int chunkNumber)
    {
        Console.WriteLine($"Processing chunk {chunkNumber}...");
        _____ Task.Delay(1000); // Simulate processing time
        Console.WriteLine($"Completed processing of chunk {chunkNumber}.");
    }


    public _____ Task ProcessLargeDatasetAsync(int numberOfChunks)
    {
        var tasks = new List<Task>();

        // Start processing each chunk concurrently
        for (int i = 1; i <= numberOfChunks; i++)
        {
            tasks.Add(ProcessDataChunkAsync(i));
        }

        // Wait for all tasks to complete
        _____ Task.WhenAll(tasks);

        Console.WriteLine("All data chunks processed.");
    }

    public static _____ Task Main(string[] args)
    {
        Program program = new Program();
        _____ program.ProcessLargeDatasetAsync(5); // Process 5 chunks
    }
}
```

## 🎯 You Try It! EF Core’da CRUD İşlemlerini Uygulama

### 🧾 Amaç

Bu etkinliğin sonunda, Linux Ubuntu sisteminde bir .NET console application içinde MySQL Server ile Entity Framework Core ( **EF Core** ) kullanarak temel CRUD ( **Create, Read, Update, Delete** ) işlemlerini gerçekleştirebileceksiniz.

---

## ✅ You Try It! EF Core’da CRUD İşlemlerini Uygulama – Cevap Anahtarı

---

## 🧱 Adım 2: Product Modeli (Models/Product.cs)

```csharp
namespace CRUDWithMySQL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
```

---

## 🧩 Adım 3: Database Context (Models/ApplicationDbContext.cs)

```csharp
using Microsoft.EntityFrameworkCore;
using CRUDWithMySQL.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=ProductDB;User=root;Password=yourpassword;", new MySqlServerVersion(new Version(8, 0, 26)));
    }
}
```

---

## 🔄 Adım 5: CRUD İşlemleri (Program.cs)

```csharp
using CRUDWithMySQL.Models;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var context = new ApplicationDbContext();

        // Create
        var newProduct = new Product { Name = "Laptop", Price = 1200.99m };
        context.Products.Add(newProduct);
        context.SaveChanges();

        // Read
        var allProducts = context.Products.ToList();
        Console.WriteLine("All Products:");
        allProducts.ForEach(p => Console.WriteLine($"{p.Id}: {p.Name} - ${p.Price}"));

        var singleProduct = context.Products.Find(1);
        Console.WriteLine($"Product Found: {singleProduct.Name} - ${singleProduct.Price}");

        // Update
        singleProduct.Price = 1100.99m;
        context.SaveChanges();

        // Delete
        context.Products.Remove(singleProduct);
        context.SaveChanges();
    }
}
```

## ✅ You Try It! EF Core ile Basit Bir Veritabanı Modelleme – Cevap Anahtarı

---

## 🧰 Adım 1: Gerekli Araçları Yükleme ve Yeni Console Uygulaması Oluşturma

```bash
# Install EF Core tools globally
dotnet tool install --global dotnet-ef

# Create a new console application
dotnet new console -n EFCoreModelApp
cd EFCoreModelApp

# Install EF Core SQLite and tools
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools

# Test the setup
dotnet run
```

---

## 🧱 Adım 2: Entity Sınıflarını Oluşturma ve Yapılandırma

### 👤 Employee.cs

```csharp
using System;

namespace EFCoreModelApp
{
    public class Employee
    {
        public int EmployeeID { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public int DepartmentID { get; set; } // Foreign Key
        public Department Department { get; set; } // Navigation Property
    }
}
```

### 🏢 Department.cs

```csharp
using System.Collections.Generic;

namespace EFCoreModelApp
{
    public class Department
    {
        public int DepartmentID { get; set; } // Primary Key
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } // Navigation Property
    }
}
```

---

## 🧩 Adım 3: DbContext Kurulumu

### 🗃️ HRDbContext.cs

```csharp
using Microsoft.EntityFrameworkCore;

using EFCoreModelApp;

namespace EFCoreModelApp
{
    public class HRDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Data Source=HRApp.db")
                .ConfigureWarnings(warnings =>
                    warnings.Ignore(RelationalEventId.PendingModelChangesWarning)
                );
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                entity
                    .HasOne(e => e.Department)
                    .WithMany(d => d.Employees)
                    .HasForeignKey(e => e.DepartmentID);
            });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 1, Name = "HR" },
                new Department { DepartmentID = 2, Name = "Engineering" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Aiko",
                    LastName = "Tanaka",
                    HireDate = DateTime.Now,
                    DepartmentID = 1
                },
                new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Zainab",
                    LastName = "Al-Farsi",
                    HireDate = DateTime.Now,
                    DepartmentID = 2
                }
            );
        }
    }
}
```

---

## 🧬 Adım 4: Migration Ekleme ve Uygulama

```bash
# Add initial migration
dotnet ef migrations add InitialCreate

# Apply the migration to create the database
dotnet ef database update
```

---

## ✅ Adım 5: Uygulamayı Test Etme

### 🧾 Program.cs

```csharp
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EFCoreModelApp;

class Program
{
    static void Main()
    {
        using (var context = new HRDbContext())
        {
            var allEmployees = context.Employees.Include(e => e.Department).ToList();
            foreach (var emp in allEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.Department?.Name ?? "N/A"}");
            }

            var hrEmployees = context.Employees
                                      .Include(e => e.Department)
                                      .Where(e => e.Department.Name == "HR")
                                      .ToList();
            Console.WriteLine("HR Department Employees:");
            foreach (var emp in hrEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }

            var newEmployee = new Employee
            {
                FirstName = "New",
                LastName = "Employee",
                HireDate = DateTime.Now,
                DepartmentID = 2
            };
            context.Employees.Add(newEmployee);
            context.SaveChanges();

            Console.WriteLine("New employee added.");
        }
    }
}
```

---

## 📌 Beklenen Çıktı

* Tüm çalışanları ve departmanlarını listeler.
* **"HR"** departmanındaki çalışanları görüntüler.
* Yeni bir çalışanın eklendiğini doğrular.

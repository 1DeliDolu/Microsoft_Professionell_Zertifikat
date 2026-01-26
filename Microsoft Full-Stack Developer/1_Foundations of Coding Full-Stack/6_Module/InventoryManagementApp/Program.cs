using System;
using System.Collections.Generic;
using System.Globalization;

namespace InventoryManagementApp
{
    class Product
    {
        public string Name { get; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void AdjustStock(int delta)
        {
            Quantity += delta;
        }

        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;
        }
    }

    class Program
    {
        private static readonly List<Product> Inventory = new List<Product>();

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                string choice = Console.ReadLine() ?? "";
                switch (choice.Trim())
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        ViewProducts();
                        break;
                    case "4":
                        RemoveProduct();
                        break;
                    case "5":
                        UpdatePrice();
                        break;
                    case "0":
                        Console.WriteLine("Cikis yapiliyor...");
                        return;
                    default:
                        Console.WriteLine("Gecersiz secim.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("=== Inventory Management ===");
            Console.WriteLine("1) Urun ekle");
            Console.WriteLine("2) Stok guncelle (satis / stok ekleme)");
            Console.WriteLine("3) Urunleri listele");
            Console.WriteLine("4) Urun sil");
            Console.WriteLine("5) Fiyat guncelle");
            Console.WriteLine("0) Cikis");
            Console.Write("Secim: ");
        }

        static void AddProduct()
        {
            string name = ReadRequiredString("Urun adi: ");
            if (FindProductByName(name) != null)
            {
                Console.WriteLine("Bu isimde urun zaten var.");
                return;
            }

            decimal price = ReadDecimal("Fiyat: ");
            int qty = ReadInt("Stok miktari: ");
            Inventory.Add(new Product(name, price, qty));
            Console.WriteLine("Urun eklendi.");
        }

        static void UpdateStock()
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Envanter bos.");
                return;
            }

            string name = ReadRequiredString("Stogu guncellenecek urun adi: ");
            Product product = FindProductByName(name);
            if (product == null)
            {
                Console.WriteLine("Urun bulunamadi.");
                return;
            }

            Console.WriteLine("1) Satis (stok dusur)");
            Console.WriteLine("2) Stok ekle");
            Console.Write("Secim: ");
            string action = Console.ReadLine() ?? "";
            int qty = ReadInt("Miktar: ");

            switch (action.Trim())
            {
                case "1":
                    if (qty > product.Quantity)
                    {
                        Console.WriteLine("Yetersiz stok. Mevcut: " + product.Quantity);
                        return;
                    }
                    product.AdjustStock(-qty);
                    Console.WriteLine("Satis kaydedildi. Yeni stok: " + product.Quantity);
                    break;
                case "2":
                    product.AdjustStock(qty);
                    Console.WriteLine("Stok guncellendi. Yeni stok: " + product.Quantity);
                    break;
                default:
                    Console.WriteLine("Gecersiz secim.");
                    break;
            }
        }

        static void UpdatePrice()
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Envanter bos.");
                return;
            }

            string name = ReadRequiredString("Fiyati guncellenecek urun adi: ");
            Product product = FindProductByName(name);
            if (product == null)
            {
                Console.WriteLine("Urun bulunamadi.");
                return;
            }

            decimal price = ReadDecimal("Yeni fiyat: ");
            if (price <= 0)
            {
                Console.WriteLine("Fiyat sifirdan buyuk olmali.");
                return;
            }

            product.UpdatePrice(price);
            Console.WriteLine("Fiyat guncellendi.");
        }

        static void ViewProducts()
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Envanter bos.");
                return;
            }

            Console.WriteLine("No | Urun | Fiyat | Stok");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Product p = Inventory[i];
                Console.WriteLine($"{i + 1}. {p.Name} | {p.Price:F2} | {p.Quantity}");
            }
        }

        static void RemoveProduct()
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Envanter bos.");
                return;
            }

            string name = ReadRequiredString("Silinecek urun adi: ");
            Product product = FindProductByName(name);
            if (product == null)
            {
                Console.WriteLine("Urun bulunamadi.");
                return;
            }

            Inventory.Remove(product);
            Console.WriteLine("Urun silindi.");
        }

        static Product FindProductByName(string name)
        {
            foreach (Product p in Inventory)
            {
                if (string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return p;
                }
            }

            return null;
        }

        static string ReadRequiredString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Bos birakilamaz.");
            }
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value) && value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Gecerli bir sayi girin (0 veya daha buyuk).");
            }
        }

        static decimal ReadDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal value) && value >= 0)
                {
                    return value;
                }

                if (decimal.TryParse(input, out value) && value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Gecerli bir fiyat girin (0 veya daha buyuk).");
            }
        }
    }
}

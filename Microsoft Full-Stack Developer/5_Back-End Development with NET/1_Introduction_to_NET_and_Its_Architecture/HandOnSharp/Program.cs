using System;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<string> Tags { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {
        string json = "{\"Name\":\"Laptop\",\"Price\":999.99,\"Tags\":[\"Electronics\",\"Computers\"]}";
        Product product = System.Text.Json.JsonSerializer.Deserialize<Product>(json);
        Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Tags: {string.Join(", ", product.Tags)}");

        Product newProduct = new Product
        {
            Name = "Smartphone",
            Price = 499.99m,
            Tags = new List<string> { "Electronics", "Mobile" }
        };
    }
}
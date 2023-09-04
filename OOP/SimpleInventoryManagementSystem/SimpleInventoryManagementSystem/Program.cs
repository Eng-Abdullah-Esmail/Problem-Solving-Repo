using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockLevel { get; set; }
    public DateTime LastStocked { get; set; }

    public Product(string name, decimal price, int stockLevel, DateTime lastStocked)
    {
        Name = name;
        Price = price;
        StockLevel = stockLevel;
        LastStocked = lastStocked;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: {0}, Price: {1:C}, Stock Level: {2}, Last Stocked: {3}", Name, Price, StockLevel, LastStocked.ToString("dd/MM/yyyy"));
    }

    public bool IsLowStock()
    {
        return StockLevel < 10;
    }
}

class InventoryManagementSystem
{
    private List<Product> products;

    public InventoryManagementSystem()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("{0} has been added to the inventory system.", product.Name);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
        Console.WriteLine("{0} has been removed from the inventory system.", product.Name);
    }

    public void UpdateStock(Product product, int newStockLevel)
    {
        int oldStockLevel = product.StockLevel;
        product.StockLevel = newStockLevel;
        product.LastStocked = DateTime.Today;
        Console.WriteLine("{0}'s stock level has been updated from {1} to {2}.", product.Name, oldStockLevel, newStockLevel);
    }

    public List<Product> GetLowStockProducts()
    {
        List<Product> lowStockProducts = new List<Product>();
        foreach (Product product in products)
        {
            if (product.IsLowStock())
            {
                lowStockProducts.Add(product);
            }
        }
        return lowStockProducts;
    }

    public Product GetProductByName(string name)
    {
        foreach (Product product in products)
        {
            if (product.Name == name)
            {
                return product;
            }
        }
        return null;
    }

    public void PrintProducts()
    {
        Console.WriteLine("Product Details:");
        foreach (Product product in products)
        {
            product.PrintDetails();
        }
    }

    public void PrintLowStockReport()
    {
        Console.WriteLine("Low Stock Report:");
        Console.WriteLine("-----------------");

        List<Product> lowStockProducts = GetLowStockProducts();
        if (lowStockProducts.Count == 0)
        {
            Console.WriteLine("No products are currently low in stock.");
        }
        else
        {
            foreach (Product product in lowStockProducts)
            {
                Console.WriteLine("{0} is low in stock with a stock level of {1}.", product.Name, product.StockLevel);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new inventory management system object
        InventoryManagementSystem ims = new InventoryManagementSystem();

        // Add some products to the system
        ims.AddProduct(new Product("Apple", 0.50M, 100, DateTime.Today.AddDays(-10)));
        ims.AddProduct(new Product("Banana", 0.25M, 5, DateTime.Today.AddDays(-5)));
        ims.AddProduct(new Product("Orange", 0.75M, 50, DateTime.Today.AddDays(-2)));

        // Print the product details
        ims.PrintProducts();

        // Update the stock level of a product
        Product productToUpdate = ims.GetProductByName("Apple");
        ims.UpdateStock(productToUpdate, 200);

        // Print the modified product details
        ims.PrintProducts();

        // Print a low stock report
        ims.PrintLowStockReport();

        // Remove a product and print the modified product details
        Product productToRemove = ims.GetProductByName("Banana");
        ims.RemoveProduct(productToRemove);
        ims.PrintProducts();

        Console.ReadKey();
    }
}
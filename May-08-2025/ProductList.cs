using System;
using System.Collections;
using System.Collections.Generic;

class Product
{
    public int Id;
    public string Name;
    public double Price;
}


class Program
{
    public  static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product{Id = 1, Name = "Laptop", Price = 55000.0},
            new Product{Id = 2, Name = "iphone", Price = 60000.0},
            new Product{Id = 3, Name = "Headset", Price = 2000.0},
            new Product{Id = 4, Name = "Smartwatch", Price = 4500.0},
            new Product{Id = 5, Name = "Airconditioner", Price = 40000.0}
        };

        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Id} NAME: {product.Name} PRICE: {product.Price}");
        }

        Product Highest = products[0];
        Console.WriteLine("\nproduct with highest price is");
        Console.WriteLine($"ID: {Highest.Id} Name: {Highest.Name} Price: {Highest.Price}");
    }
}
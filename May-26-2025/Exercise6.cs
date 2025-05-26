using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
           
            List<Item> inventory = new List<Item>
        {
            new Item { Name = "Laptop", Type = "Electronics", Stock = 10, Price = 1000 },
            new Item { Name = "Mouse", Type = "Electronics", Stock = 3, Price = 25 },
            new Item { Name = "Keyboard", Type = "Electronics", Stock = 7, Price = 45 },
            new Item { Name = "Chair", Type = "Furniture", Stock = 2, Price = 150 },
            new Item { Name = "Desk", Type = "Furniture", Stock = 4, Price = 300 },
            new Item { Name = "Notebook", Type = "Stationery", Stock = 20, Price = 2 },
            new Item { Name = "Pen", Type = "Stationery", Stock = 50, Price = 1 },
            new Item { Name = "Pencil", Type = "Stationery", Stock = 0, Price = 0.5m },
            new Item { Name = "Monitor", Type = "Electronics", Stock = 5, Price = 200 },
            new Item { Name = "Cabinet", Type = "Furniture", Stock = 1, Price = 400 },
            new Item { Name = "Paper Ream", Type = "Stationery", Stock = 8, Price = 5 },
            new Item { Name = "Tablet", Type = "Electronics", Stock = 2, Price = 800 },
            new Item { Name = "Stapler", Type = "Stationery", Stock = 3, Price = 6 },
            new Item { Name = "Couch", Type = "Furniture", Stock = 1, Price = 1000 },
            new Item { Name = "Lamp", Type = "Furniture", Stock = 6, Price = 60 }
        };

           
            var result = inventory
                .Where(item => item.Stock < 5)
                .GroupBy(item => item.Type)
                .Select(group => new
                {
                    Type = group.Key,
                    HighestPricedItem = group
                        .OrderByDescending(item => item.Price)
                        .First()
                });

           
            Console.WriteLine("Highest Priced Low Stock Items by Type:");
            foreach (var group in result)
            {
                var item = group.HighestPricedItem;
                Console.WriteLine($"\nType: {group.Type}");
                Console.WriteLine($"{item.Name}, Price: ${item.Price}, Stock: {item.Stock}");
            }
        }
    }
}

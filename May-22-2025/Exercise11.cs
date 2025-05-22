using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
     class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int Id , string Name, decimal Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(100,"Mouse" , 300),
                new Product(101,"Monitor" , 600),
                new Product(102,"SmartPhone" , 13000),
                new Product(103,"Keyboard" , 1000),
                new Product(104,"Laptop" , 30000)
            };

            var sortedProducts = products.OrderByDescending(p => p.Price);

            Console.WriteLine("product after sorting in descending order:");
            Console.WriteLine("{0,-5} {1,-10} {2,-10}","Id" , "Name" ,"Price");
            Console.WriteLine(new string('-', 33));
            foreach(var product in sortedProducts)
            {
                Console.WriteLine("{0,-5} {1,-10} {2,-10}" , product.Id , product.Name , product.Price);
            }

        }
    }
}

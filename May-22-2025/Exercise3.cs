using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class ProductsList
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public ProductsList(string ProductName, double ProductPrice)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
        }
       
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<ProductsList> products = new List<ProductsList>
            {
                new ProductsList("Mouse" , 300),
                new ProductsList("Monitor" , 600),
                new ProductsList("SmartPhone" , 13000),
                new ProductsList("Keyboard" , 1000),
                new ProductsList("Laptop" , 30000)
            };

            var ProductsQuery = from p in products
                                where ( p.ProductPrice > 500)
                                select p;

            Console.WriteLine("products with price greater than 500 are ;");
            foreach (var product in ProductsQuery)
            {
                Console.WriteLine($"{product.ProductName} : {product.ProductPrice}");
                    
            }
        }
    }
}

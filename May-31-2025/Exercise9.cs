using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
  
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
        }

       
        public interface IPrintable
        {
            void Print();
        }

        
        public abstract class Invoice : IPrintable
        {
            public List<Product> Products { get; set; } = new List<Product>();
            public abstract double CalculateTotal();
            public abstract void Print();
        }

        
        public class RetailInvoice : Invoice
        {
            public override double CalculateTotal()
            {
                double subtotal = Products.Sum(p => p.Price * p.Quantity);
                double tax = subtotal * 0.10;
                double discount = subtotal * 0.05;
                return subtotal + tax - discount;
            }

            public override void Print()
            {
                Console.WriteLine(" Retail Invoice");
                PrintDetails();
            }

            private void PrintDetails()
            {
                Console.WriteLine("{0,-15} {1,8} {2,8} {3,10}", "Product", "Price", "Qty", "Total");
                foreach (var p in Products)
                {
                    Console.WriteLine("{0,-15} {1,8} {2,8} {3,10}", p.Name, p.Price, p.Quantity, p.Price * p.Quantity);
                }

                double subtotal = Products.Sum(p => p.Price * p.Quantity);
                Console.WriteLine($"\nSubtotal:   {subtotal}");
                Console.WriteLine($"Tax (10%):  {subtotal * 0.10}");
                Console.WriteLine($"Discount:   {subtotal * 0.05}");
                Console.WriteLine($"Total:      {CalculateTotal()}");
            }
        }

        
        public class WholesaleInvoice : Invoice
        {
            public override double CalculateTotal()
            {
                double subtotal = Products.Sum(p => p.Price * p.Quantity);
                double tax = subtotal * 0.15;
                return subtotal + tax;
            }

            public override void Print()
            {
                Console.WriteLine(" Wholesale Invoice");
                PrintDetails();
            }

            private void PrintDetails()
            {
                Console.WriteLine("{0,-15} {1,8} {2,8} {3,10}", "Product", "Price", "Qty", "Total");
                foreach (var p in Products)
                {
                    Console.WriteLine("{0,-15} {1,8} {2,8} {3,10}", p.Name, p.Price, p.Quantity, p.Price * p.Quantity);
                }

                double subtotal = Products.Sum(p => p.Price * p.Quantity);
                Console.WriteLine($"\nSubtotal:   {subtotal}");
                Console.WriteLine($"Tax (15%):  {subtotal * 0.15}");
                Console.WriteLine($"Total:      {CalculateTotal()}");
            }
        }

        
        class Program
        {
            static void Main()
            {
                List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 800, Quantity = 1 },
                new Product { Name = "Mouse", Price = 20, Quantity = 2 },
                new Product { Name = "Keyboard", Price = 40, Quantity = 1 }
            };

                Invoice retailInvoice = new RetailInvoice { Products = products };
                retailInvoice.Print();

                Console.WriteLine("\n----------------------------------------\n");

                
                Invoice wholesaleInvoice = new WholesaleInvoice { Products = products };
                wholesaleInvoice.Print();
            }
        }
    
}

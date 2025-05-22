using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal GetTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }

    class ShoppingCart
    {
        private List<CartItem> items = new List<CartItem>();

        public void AddItem(Product product, int quantity)
        {
            var existingItem = items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveItem(int productId)
        {
            items.RemoveAll(i => i.Product.Id == productId);
        }

        public decimal GetCartTotal()
        {
            return items.Sum(i => i.GetTotalPrice());
        }

        public void PrintCart()
        {
            
            Console.WriteLine("{0,-5} {1,-15} {2,8} {3,12} {4,14}", "ID", "Product", "Qty", "Price", "Total Price");
            Console.WriteLine("------------------------------------------------------");

            foreach (var item in items)
            {
                Console.WriteLine("{0,-5} {1,-15} {2,8} {3,12} {4,14:}",
                    item.Product.Id,
                    item.Product.Name,
                    item.Quantity,
                    item.Product.Price,
                    item.GetTotalPrice());
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("{0,45} {1,14:C}", "Total:", GetCartTotal());
        }
    }

    
    class Program
    {
        static void Main()
        {
            
            Product p1 = new Product { Id = 1, Name = "Laptop", Price = 70000 };
            Product p2 = new Product { Id = 2, Name = "Mouse", Price = 800 };
            Product p3 = new Product { Id = 3, Name = "Keyboard", Price = 1200 };

            ShoppingCart cart = new ShoppingCart();

            // Add items to the cart
            cart.AddItem(p1, 1); 
            cart.AddItem(p2, 2); 
            cart.AddItem(p3, 1);

            cart.PrintCart();
        }
    }
}
    


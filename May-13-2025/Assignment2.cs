using System;

namespace Linq_Project
{
    interface IOrder
    {
        void PlaceOrder();
        void CancelOrder();
    }

    class DineInOrder : IOrder
    {
        public void PlaceOrder()
        {
            Console.WriteLine("placing dine-in order for item");
        }

        public void CancelOrder()
        {
            Console.WriteLine("canceling dine-in order for item");
        }
    }

    class TakeAwayOrder : IOrder
    {
        public void PlaceOrder()
        {
            Console.WriteLine("placing takeaway order for item");
        }

        public void CancelOrder()
        {
            Console.WriteLine("canceling takeaway rder for item");
        }

    }

    class Program
    {
        public static void Main()
        {
            IOrder order;

            order = new DineInOrder();
            order.PlaceOrder();
            order.CancelOrder();

            order = new TakeAwayOrder();
            order.PlaceOrder();
            order.CancelOrder();
        }
    }

}
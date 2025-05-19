using System;

namespace ConsoleApp4
{
    abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);
        public void ShowPaymentMethod(string method)
        {
            Console.WriteLine($"payment method is : {method}");
        }
    }

    class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"processing credit card payment of {amount}");

        }
    }

    class UPIPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"processing UPI payment of {amount}");

        }
    }

    class Program
    {
        public static void Main()
        {
            PaymentMethod payment;
            payment = new CreditCardPayment();
            payment.ShowPaymentMethod("credit card payment");
            payment.ProcessPayment(60000);

            Console.WriteLine();
            payment = new UPIPayment();
            payment.ShowPaymentMethod("UPI payment");
            payment.ProcessPayment(80000);
        }
            
    }
}

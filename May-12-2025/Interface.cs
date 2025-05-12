using System;

namespace ConsoleApp2
{
    interface Ipayments
    {
        void ProcessPayment(decimal amount);
    }

    class CreditCardPayment1 : Ipayments
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"processing creditcard payment of {amount}");
        }
    }

    class PayPalPayment1 : Ipayments
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"processing paypal payment of  {amount}");
        }
    }

    class Program
    {
        static void Main()
        {
            Ipayments payment;

            payment = new CreditCardPayment1();
            payment.ProcessPayment(50000);

            payment = new PayPalPayment1();
            payment.ProcessPayment(60000);


         }

    }
}
using System;

namespace ConsoleApp2
{
     class Payment
    {
        public double Amount;
        public string Currency;

        public virtual void ProcessPayment(double Amount)
        {
            Console.WriteLine($"Amount is : {Amount}");
        }

        public virtual void ProcessPayment(double Amount, string Currency)
        {
            Console.WriteLine($"Amount is : {Amount}");
            Console.WriteLine($"Currency is : {Currency}");

        }
    }

    class CreditCardPayment : Payment
    {
        public int CardNumber;

        public override void ProcessPayment(double Amount)
        {
            Console.WriteLine($"Amount is : {Amount} ");
        }
    }

    class PayPalPayment : Payment
    {
        public string email;

        public  override void ProcessPayment(double Amount, string Currency)
        {
            Console.WriteLine($"Amount is : {Amount} ");
            Console.WriteLine($"Currency is : {Currency}");
        }
    }

    class Program
    {
        static void Main()
        {
            CreditCardPayment creditcard = new CreditCardPayment();
            Console.WriteLine("CREDITCARD PAYMENT DETAILS");
            creditcard.ProcessPayment(50000);

            PayPalPayment paypal = new PayPalPayment();
            Console.WriteLine("\nPAYPAL PAYMENT DETAILS");
            paypal.ProcessPayment(60000,"INR");

        }
    }
}

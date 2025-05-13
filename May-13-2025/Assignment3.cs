using System;

namespace Linq_Project
{
    abstract class PaymentGateWay
    {
       public  abstract void ProcessPayment(double Amount);

        public void ShowGateWay()
        {
            Console.WriteLine("processing payment through gateway");
        }
    }

    class Stripe : PaymentGateWay
    {
        public override void ProcessPayment(double Amount)
        {
            Console.WriteLine($"processing payment through stripe of amount {Amount}");
        }
    }

    class PayPal : PaymentGateWay
    {
        public override void ProcessPayment(double Amount)
        {
            Console.WriteLine($"processing payment through paypal of amount {Amount}");
        }
    }

    class Program
    {
        public static void Main()
        {
            PaymentGateWay payment;

            payment = new Stripe();
            payment.ShowGateWay();
            payment.ProcessPayment(60000);

            payment = new PayPal();
            payment.ShowGateWay();
            payment.ProcessPayment(85000);

        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    abstract class PaymentGateeway
    {
        public string GatewayName { get; set; }

        public PaymentGateeway(string GatewayName)
        {
            this.GatewayName = GatewayName;
        }
        public void Validate()
        {
            Console.WriteLine($"validating payment gateway {GatewayName}");
        }
    }

    class RazorPay : PaymentGateeway, IPaymentProcessor
    {
        public RazorPay() : base("RazorPay") { }

        public void ProcessPayment(double amount)
        {
            Validate();
            Console.WriteLine($"Processing payment of {amount} through Razorpay ");
        }
        
    }

    class PayPal : PaymentGateeway, IPaymentProcessor
    {
        public PayPal() : base("PayPal") { }

        public void ProcessPayment(double amount)
        {
            Validate();
            Console.WriteLine($"Processing payment of {amount} through PayPal ");
        }

    }

    class Stripe : PaymentGateeway, IPaymentProcessor
    {
        public Stripe() : base("Stripe") { }

        public void ProcessPayment(double amount)
        {
            Validate();
            Console.WriteLine($"Processing payment of {amount} through Stripe ");
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<IPaymentProcessor> payments = new List<IPaymentProcessor>
            {
                new RazorPay(),
                new PayPal(),
                new Stripe()
            };

            double[] amounts = { 1000.0, 1500.0, 500.0 };

            for(int i=0; i<payments.Count; i++)
            {
                payments[i].ProcessPayment(amounts[i]);
                Console.WriteLine();
            }

        }
    }
}

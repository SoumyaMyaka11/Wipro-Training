using System;

namespace Linq_Project
{
    interface IBankAccount
    {
        void Deposit(double amount);
        void WithDrawl(double amount);
        void CheckBalance();
    }

    class  SavingsAccount : IBankAccount
    {
        public void Deposit(double amount)
        {
            Console.WriteLine($"deposited amount {amount}");
        }

        public void WithDrawl(double amount)
        {
            Console.WriteLine(($"withdrawl amount {amount}"));
        }

        public void CheckBalance()
        {
            Console.WriteLine("prints balance amount");
        }
    }

    class CuurentAccount : IBankAccount
    {
        public void Deposit(double amount)
        {
            Console.WriteLine($"deposited amount {amount}");
        }

        public void WithDrawl(double amount)
        {
            Console.WriteLine(($"withdrawl amount {amount}"));
        }

        public void CheckBalance()
        {
            Console.WriteLine("prints balance amount");
        }
    }

    class Program
    {
        public static void Main()
        {
            IBankAccount account;

            account = new SavingsAccount();
            account.Deposit(50000);
            account.WithDrawl(30000);
            account.CheckBalance();

            account = new CuurentAccount();
            account.Deposit(60000);
            account.WithDrawl(40000);
            account.CheckBalance();
                
        }
    }
}

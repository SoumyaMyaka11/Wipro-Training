using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp7
{
        public class Transaction
        {
            public DateTime Date { get; set; }
            public string Type { get; set; } 
            public decimal Amount { get; set; }

            public override string ToString()
            {
                return $"{Date}|{Type}|{Amount}";
            }

            public static Transaction FromString(string line)
            {
                var parts = line.Split('|');
                return new Transaction
                {
                    Date = DateTime.Parse(parts[0]),
                    Type = parts[1],
                    Amount = decimal.Parse(parts[2])
                };
            }
        }

        public class BankAccount
        {
            private const string FilePath = "transactions.txt";
            private List<Transaction> transactions = new List<Transaction>();
            public decimal Balance { get; private set; }

            public BankAccount()
            {
                LoadTransactions();
            }

            public void Deposit(decimal amount)
            {
                AddTransaction("Deposit", amount);
            }

            public void Withdraw(decimal amount)
            {
                if (Balance >= amount)
                {
                    AddTransaction("Withdraw", amount);
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }

            private void AddTransaction(string type, decimal amount)
            {
                var tx = new Transaction
                {
                    Date = DateTime.Now,
                    Type = type,
                    Amount = amount
                };

                transactions.Add(tx);
                Balance += (type == "Deposit") ? amount : -amount;

                File.AppendAllText(FilePath, tx + Environment.NewLine);
            }

            private void LoadTransactions()
            {
                if (!File.Exists(FilePath)) return;

                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var tx = Transaction.FromString(line);
                    transactions.Add(tx);
                    Balance += (tx.Type == "Deposit") ? tx.Amount : -tx.Amount;
                }
            }

            public void ShowSummary()
            {
                Console.WriteLine("\n Transaction Summary:");
                foreach (var tx in transactions)
                {
                    Console.WriteLine($"{tx.Date:G} - {tx.Type} - {tx.Amount}");
                }
                Console.WriteLine($"\n Current Balance: {Balance}");
            }
        }

        public class Program
        {
            public static void Main()
            {
                var account = new BankAccount();

                Console.WriteLine(" Welcome back!");
                account.ShowSummary();

                Console.WriteLine("\n Performing new transactions...");

                account.Deposit(20000);
                account.Withdraw(1000);
                account.Withdraw(99999); 

                account.ShowSummary();
            }
        }
    
}

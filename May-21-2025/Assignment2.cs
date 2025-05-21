using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
     class GreedyAlgotithm
    {
        public static void CoinChange(int[] denominations, int amount)
        {
            //int[] denominations = {1, 2,5,10,20,50,100,200,500
            //sort the array in descending order for optimal solution

            Array.Sort(denominations);
            Array.Reverse(denominations);

            //define a list for what type of coins used to achieve the target value

            List<int> coins = new List<int>();
            int totalCoins = 0;

            foreach (int coin in denominations)
            {
                while(amount >= coin)
                {
                    amount = amount - coin;
                    coins.Add(coin);
                    totalCoins++;
                }
            }

            Console.WriteLine("Coins used : " + string.Join(",", coins));
            Console.WriteLine("Minimum number of coins used : " + totalCoins);
            
        }

        public static void Main()
        {
            int[] denominations = { 1, 2, 3, 5, 10, 20, 50, 100, 200, 500 };

            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            CoinChange(denominations, amount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
     class EvenOdd
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 9, 2, 8, 3, 7, 4, 6, 5, 10 };

            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

            Console.WriteLine("EVE NUMBERS : "+string.Join(',', evenNumbers));
            Console.WriteLine("ODD NUMBERS : " + string.Join(',', oddNumbers));
        }

    }
}

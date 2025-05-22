using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
     class NumbersList
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 4, 3, 2, 2, 5, 6, 3, 4, 1, 4, 1, 8, 1, 10 };

            var duplicates = numbers.GroupBy(n => n)
                                    .Where(c => c.Count() > 1)
                                    .Select(c => c.Key);

            Console.WriteLine("Duplicate numbers :");
            foreach (var num in duplicates)
            {
                Console.WriteLine(num);
            }

       }                          
    }
}

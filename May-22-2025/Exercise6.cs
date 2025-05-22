using System;
using System.Linq;

namespace ConsoleApp5
{
     class String
    {
        public  static void Main(string[] args)
        {
            string str = "C# is great and c# is fun";
            string[] words = str.Split(' ');

            var wordFrequency = from word in words
                                group word.ToLower() by word.ToLower() into WordGroup
                                select new { word = WordGroup.Key, Count = WordGroup.Count() };

            Console.WriteLine("Frequency of words in the string");
            foreach (var entry in wordFrequency)
            {
                Console.WriteLine($"{entry.word} : {entry.Count}");
            }
        }
    }
}

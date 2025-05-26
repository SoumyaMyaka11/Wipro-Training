using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
     class WordFrequency
    {
        public static void Main(string[] args)
        {
            string paragrapgh = @"This is a Test.This test is only a test. In the event of an actual emergency the word test would appear more often.";

            var words = Regex.Split(paragrapgh.ToLower(), @"\W+").Where(w => !string.IsNullOrWhiteSpace(w));

            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if(frequency.ContainsKey(word))
                {
                    frequency[word]++;
                }
                else
                {
                    frequency[word] = 1;
                }
            }

            var frqWords = frequency.OrderByDescending(f => f.Value).Take(5);

            foreach (var keyvalue in frqWords)
            {
                Console.WriteLine($"{keyvalue.Key} : {keyvalue.Value}");
            }
                                     
        }
    }
}

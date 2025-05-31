using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp9
{
    class WordAnalyzer
    {
        public static void Main()
        {
            Console.WriteLine("Enter a paragraph");
            string str = Console.ReadLine();

            List<string> words = Regex.Split(str.ToLower(), @"\W+").Where(w => !string.IsNullOrWhiteSpace(w)).ToList();

            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (freq.ContainsKey(word))
                    freq[word]++;
                else
                    freq[word] = 1;
            }

            Console.WriteLine("frequency of words");
            foreach (var pair in freq.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            int vowels = 0, consonants = 0;
            foreach (char c in str)
            {
                if(char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }
            Console.WriteLine("\n Number of vowels : " + vowels);
            Console.WriteLine("Number of consonants : " + consonants);

            string longestWord = words.OrderByDescending(w => w.Length).First();
            string smallestWord = words.OrderBy(W => W.Length).First();

            Console.WriteLine($"Longest word : {longestWord}");
            Console.WriteLine($"Smallest word : {smallestWord}");
        }
    }
}

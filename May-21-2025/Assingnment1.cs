using System;
using System.Collections.Generic;


namespace ConsoleApp5
{
    class Hashing
    {
        public static char FirstNonRepeatingChar(string str)
        {
            str = str.ToLower();
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charFrequency.ContainsKey(c))
                    charFrequency[c]++;
                else
                    charFrequency[c] = 1;
            }

            foreach (char c in str)
            {
                if (charFrequency[c] == 1)
                    return c;
            }
            return '\0';

        }

        public static void Main()
        {
            string str = "swwiiss";
            char result = FirstNonRepeatingChar(str);

            if (result != '\0')
                Console.WriteLine($"First non -repeating character is : {result}");
            else
                Console.WriteLine("No non-repeating character found in the given string");
        }
    }
}

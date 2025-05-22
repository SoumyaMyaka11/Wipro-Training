using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class String1
    {
        public static void Main(string[] arg)
        {
            List<string> names = new List<string>
            {
                "Krishna","Arjun","Keerthi","Ishaa","Ayat" , "Harshika", "Omkar","deepika","Seetha","Harshu"
            };

            var vowels = new[] { 'A', 'E', 'I', 'O', 'U' };

            var vnames = names.Where(name => vowels.Contains(char.ToUpper(name[0]))).ToList();

            Console.WriteLine("Names starting with a vowel");
            foreach (var name in vnames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

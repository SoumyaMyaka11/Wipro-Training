using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    class Dictionary
    {
        public static void Main()
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>
            { 
                   {"Harshika" , new List<int> {80, 95, 88, 76} },
                   {"Bhnanu" , new List<int> {83, 79, 75, 86} },
                   {"Deepika" , new List<int> {70, 64, 89, 73} },
                   {"Keerthi" , new List<int> {80, 85, 81, 72} },
                   {"Harshu" , new List<int> {80, 75, 80, 71} },

            };

            Console.WriteLine("student performance summary ");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("{0,-10} {1,6} {2,6} {3,7} ", "Name", "Average", "Maximum Mark", "Minimum Mark");
            Console.WriteLine(new string('-', 50));

            foreach (var student in dict)
            {
                var name = student.Key;
                var marks = student.Value;
                double avg = marks.Average();
                int max = marks.Max();
                int min = marks.Min();

                Console.WriteLine("{0,-10} {1,6} {2,10} {3,10} ",name,  avg, max, min);
            }

            var top3 = dict.Select(s => new
            {
                Name = s.Key,
                Average = s.Value.Average()
            }).OrderByDescending(s => s.Average).Take(3);

            Console.WriteLine("\nstudents with top 3 scores");
            foreach (var student in top3)
            {
                Console.WriteLine($"{student.Name} Average : {student.Average}");
            }
        }
    }
}

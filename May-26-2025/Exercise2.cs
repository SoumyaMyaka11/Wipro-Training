using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
     class Student
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public decimal Marks { get; set; }

        public Student(string Name, string Grade, decimal Marks)
        {
            this.Name = Name;
            this.Grade = Grade;
            this.Marks = Marks;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Keerthi", "A", 80),
                new Student("Harshu", "B", 85),
                new Student("Harshika", "C", 70),
                new Student("Deepika", "B", 90),
                new Student("Ramya", "C", 83),
                new Student("Likhitha", "A", 60),
                new Student("Akhila", "A", 80),
                new Student("Varshitha", "B", 92),
                new Student("Meghana", "C", 75),
                new Student("Mounika", "B", 76)
            };

            var StudentQuery = students.OrderByDescending(s => s.Marks).Take(3)
                                       .GroupBy(s => s.Grade)
                                       .Select(g => new
                                       {
                                           Grade = g.Key,
                                           students = g.Select(s => new { s.Name, s.Marks })
                                       });

            Console.WriteLine("Top 3 students grouped by grade are");
            foreach (var group in StudentQuery)
            {
                Console.WriteLine($"\nGrade {group.Grade}");
                foreach (var student in group.students)
                {
                    Console.WriteLine($"{student.Name} : {student.Marks}");
                }
            }

        }
    }
}

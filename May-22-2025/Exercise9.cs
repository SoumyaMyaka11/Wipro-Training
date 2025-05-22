using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Student1
    {
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student1(string Name, double Marks)
        {
            this.Name = Name;
            this.Marks = Marks;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Student1> students = new List<Student1>
            {
                new Student1("krishna", 90),
                new Student1("Arjun", 80),
                new Student1("Bheem", 75),
                new Student1("Ashwathama", 60),
                new Student1("Abimanyu", 85),
                new Student1("Beeshma", 83)
            };

            double average = students.Average(s => s.Marks);
            Console.WriteLine($"Average Marks : {average:F2}");

            
            int count = students.Count(s => s.Marks > average);
            Console.WriteLine("Number of students who scored above average marks : "+count);
            
        }

    }
}

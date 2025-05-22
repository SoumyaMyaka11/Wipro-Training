using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
     class Student
    {
        public string Name { get; set; }
        public decimal Marks { get; set; }

        public Student(string Name , decimal Marks)
        {
            this.Name = Name;
            this.Marks = Marks;

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("krishna", 90),
                new Student("Arjun", 80),
                new Student("Bheem", 75),
                new Student("Ashwathama", 60),
                new Student("Abimanyu", 85),
                new Student("Beeshma", 83)
            };

            var HighestMarks = students.OrderByDescending(s => s.Marks).Take(3);

            Console.WriteLine("top 3 students with highest marks");
            foreach (var student in HighestMarks)
            {
                Console.WriteLine($"{student.Name} : {student.Marks}");
            }
        }
    }
}

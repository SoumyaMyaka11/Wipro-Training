using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string Name , string Department)
        {
            this.Name = Name;
            this.Department = Department;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Swetha", "IT"),
                new Employee("Ayat", "Sales"),
                new Employee("Seetha", "IT"),
                new Employee("Keerthu", "Finance"),
                new Employee("Harshika", "Sales"),
                new Employee("Harshitha", "Finance")
            };

            var groupByDept = from emp in employees
                              group emp by emp.Department into deptGroup
                              select deptGroup;

            Console.WriteLine("employees categorize by deparments are:");
            foreach (var group in groupByDept)
            {
                Console.WriteLine($"\nDepartment : {group.Key}");
                 foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.Name}");
                }
            }
        }
    }
}

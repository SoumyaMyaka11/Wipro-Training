using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    class Employee
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(int Id, string Name, string Department, double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Department = Department;
            this.Salary = Salary;
        }
    }

    class Program
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1,"Keerthi","IT",60000),
                new Employee(1,"Harshika","Sales",65000),
                new Employee(1,"Harshu","Finanace",50000),
                new Employee(1,"Krishna","IT",40000),
                new Employee(1,"Bhanu","Finance",68000),
                new Employee(1,"Deepika","Sales",70000),
            };

            var GroupByDept = employees.Where(e => e.Department == "IT");
            foreach (var emp in GroupByDept)
            {
                Console.WriteLine($"{emp.Name} and {emp.Salary}");
            }

            var sortBySalary = employees.OrderByDescending(e => e.Salary);
            Console.WriteLine("\nemployees sorted by salaary are");
            foreach (var emp in sortBySalary)
            {
                Console.WriteLine($"{ emp.Name} : { emp.Salary}");
            }

            var avgSalaryByDept = employees.GroupBy(e => e.Department)
                                           .Select(g => new
                                           {
                                               Department = g.Key,
                                               AvgSalary = g.Average(e => e.Salary),
                                           });

            Console.WriteLine("\nAverage salary by department");
            foreach (var dept in avgSalaryByDept)
            {
                Console.WriteLine($"{dept.Department} : {dept.AvgSalary}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }

        public Employee(int EmpID, string EmpName, decimal Salary)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.Salary = Salary;

        }
    }

    class Program
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1,"Keerthi", 60000),
                new Employee(2,"Arjun", 65000),
                new Employee(3,"Harshika", 75000),
                new Employee(4,"Harshitha", 80000),
                new Employee(5,"Krishna", 60000),
            };


            Employee HighestSalary = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine("Employee with highest salary");
            Console.WriteLine($"EmployeeName: {HighestSalary.EmpName}, EmployeeSlary : {HighestSalary.Salary}");

            Dictionary<int, string> empDic = new Dictionary<int, string>();
            foreach (var emp in employees)
            {
                empDic[emp.EmpID] = emp.EmpName;
            }

            Console.WriteLine("\nEmployee Dictionary ");
            foreach (var item in empDic)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }

}
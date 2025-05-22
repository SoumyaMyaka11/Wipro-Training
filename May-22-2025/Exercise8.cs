using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Employeee
    {
        public static void Main(string[] args)
        {
            Dictionary<int, decimal> employees = new Dictionary<int, decimal>();

            employees.Add(1, 50000);
            employees.Add(2, 53000);
            employees.Add(3, 60000);
            employees[4] = 40000;
            employees[5] = 65000;

            Console.WriteLine("Enter employee ID");
            int empid = Convert.ToInt32(Console.ReadLine());

            if (employees.ContainsKey(empid))
                Console.WriteLine($"Employee ID : {empid} , Salary : {employees[empid]}");
            else
                Console.WriteLine("Employee Id not found");

        }

    } 
    
}

using System;

namespace Linq_Project
{
    abstract class Employee
    {
        public abstract void CaluculateSalary();
        public void ShowBasicInfo()
        {
            Console.WriteLine("Employee salary info :");
        }

    }

    class FullTimeEmployee : Employee
    {
        public override void CaluculateSalary()
        {
            Console.WriteLine("TotalSalary : (BasicSalary + Allowance)");
        }
    }

    class ParTimeEmployee: Employee
    {
        public override void CaluculateSalary()
        {
            Console.WriteLine("TotalSalary : (Hourlyrate * Hours worked)");
        }
    }

    class Program
    {
        public static void Main()
        {
            Employee emp;

            emp = new FullTimeEmployee();
            emp.ShowBasicInfo();
            emp.CaluculateSalary();

            emp = new ParTimeEmployee();
            emp.ShowBasicInfo();
            emp.CaluculateSalary();
        }
    }
}

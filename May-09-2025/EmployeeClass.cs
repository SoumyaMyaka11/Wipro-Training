using System;
class Employee
{
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        public void PrintDeetails()
        {
            Console.WriteLine($"EmployeeId : {EmployeeID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Salary : {Salary}");
        }

        public void  UpdateSalary(double Salary)
        {
            this.Salary = Salary;
            Console.WriteLine("updated salary :" + Salary);
        }

        public void AnnualSalary()
        {
            double AnnualSal = Salary * 12;
            Console.WriteLine("AnnualSalary is : " + AnnualSal);
        }
 }

using System;
//using ConsoleApp2;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee { EmployeeID = 101, Name = "Harshu", Salary = 50000.0, Department = "IT" };

            employee1.PrintDeetails();
            employee1.UpdateSalary(60000.0);
            employee1.AnnualSalary();
        } 
    }
}



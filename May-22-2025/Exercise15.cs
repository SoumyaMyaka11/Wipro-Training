using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    interface IAttendance
    {
        void MarkAttendance();
    }
    abstract class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Staff(int Id , string Name, string Department)
        {
            this.Id = Id;
            this.Name = Name;
            this.Department = Department;

        }

        public abstract decimal CalculateSalary();
    }

    class PermanentStaff : Staff, IAttendance
    {
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }

        public PermanentStaff(int id, string name, string department, decimal basicPay, decimal allowance)
            : base(id, name, department)
        {
            BasicSalary = basicPay;
            Allowance = allowance;
        }

        public override decimal CalculateSalary()
        {
            return BasicSalary + Allowance;
        }

        public void MarkAttendance()
        {
            Console.WriteLine($"{Name} (Permanent) attendance marked.");
        }
    }

    
    class ContractStaff : Staff, IAttendance
    {
        public int HoursWorked { get; set; }
        public decimal RatePerHour { get; set; }

        public ContractStaff(int id, string name, string department, int hoursWorked, decimal ratePerHour)
            : base(id, name, department)
        {
            HoursWorked = hoursWorked;
            RatePerHour = ratePerHour;
        }

        public override decimal CalculateSalary()
        {
            return HoursWorked * RatePerHour;
        }

        public void MarkAttendance()
        {
            Console.WriteLine($"{Name} (Contract) attendance marked.");
        }
    }

    
    class Program
    {
        static void Main()
        {
            List<Staff> staffList = new List<Staff>
        {
            new PermanentStaff(1, "Krishna", "HR", 30000, 5000),
            new ContractStaff(2, "Ram", "IT", 120, 200),
            new PermanentStaff(3, "Arjun", "Finance", 40000, 8000),
            new ContractStaff(4, "Bheem", "CustomerSupport", 100, 180)
        };

            foreach (Staff s in staffList)
            {
                Console.WriteLine("Id: " + s.Id);
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Department: " + s.Department);
                Console.WriteLine("Salary: " + s.CalculateSalary());
                if (s is IAttendance a)
                    a.MarkAttendance();
                Console.WriteLine();
            }
        }
    }
}

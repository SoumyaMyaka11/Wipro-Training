using System;
using System.Collections.Generic;

class Employee
{
    public int EmpID { get; set; }
    public string EmpName { get; set; }
}

class Program
{
    public  static void Main(string[] args)
    {
   
         List<Employee> employees = new List<Employee>
        {
            new Employee{EmpID = 1, EmpName = "Keerthi"},
            new Employee{EmpID = 2, EmpName = "Harshika"},
            new Employee{EmpID = 3, EmpName = "Harshitha"}
        };

        //adding data using Add method
        employees.Add(new Employee { EmpID = 4, EmpName = "soumya" });
        employees.Add(new Employee { EmpID = 5, EmpName = "Ramya" });

        //Remove method
        employees.Remove(new Employee {EmpID =4, EmpName = "soumya" });

        //check if a particular employee exists
        if (employees.Contains(new Employee { EmpID = 3, EmpName = "Harshitha"}))
            Console.WriteLine("Employee exists");
        else
            Console.WriteLine("Employee not exists");

        foreach (var emp in employees)
        {
            Console.WriteLine($"EMPID: {emp.EmpID} and EMPNAME: {emp.EmpName}");
        }
        Console.Read();
        
          
    }
}
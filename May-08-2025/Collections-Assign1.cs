using System;
using System.Collections.Generic;

public record Employee(int EmpID, string EmpName);

class Program
{
    public  static void Main(string[] args)
    {
   
         List<Employee> employees = new List<Employee>
        {
            new Employee( 1, "Keerthi"),
            new Employee(2, "Harshika"),
            new Employee( 3, "Harshitha"),
        };

        //adding data using Add method
        employees.Add(new Employee( 4,  "soumya" ));
        employees.Add(new Employee (  5, "Ramya" ));

        //Remove method
        employees.Remove(new Employee (4, "soumya" ));

        //check if a particular employee exists
        if (employees.Contains(new Employee  (3,"Harshitha")))
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
using System;
using System.Collections;

public class  Employee
{
    public int EmpID { get; set; }
    public string EmpName { get; set; }
    public int Age { get; set; }
}

class Program
{
    public static void Main()
    {
        Employee[] EmployeeArray = 
        {
            new Employee() {EmpID = 1, EmpName = "John", Age  = 18},
            new Employee() {EmpID = 2, EmpName = "Steve", Age  = 21},
            new Employee() {EmpID = 3, EmpName = "Bill", Age  = 25},
            new Employee() {EmpID = 4, EmpName = "Ram", Age  = 20},
            new Employee() {EmpID = 5, EmpName = "Arjun", Age  = 31},
            new Employee() {EmpID = 6, EmpName = "Bheem", Age  = 17},
            new Employee() {EmpID = 7, EmpName = "Krishna", Age  = 19},
        };

        
        Employee[] employee = new Employee[10];

        int i = 0;
        foreach (Employee emp in EmployeeArray)
        {
            if(emp.Age > 12 && emp.Age <20)
            {
                employee[i] = emp;
                Console.WriteLine(emp.EmpName);
                i++;
            }
        }

        Employee[] teenemployees = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

        foreach (Employee e in teenemployees)
        {
            Console.WriteLine(e.EmpName);

        }

        Employee bill = EmployeeArray.Where(s => s.EmpName == "bill").FirstOrDefault();
        if (bill != null)
            Console.WriteLine("bill found");
        else
            Console.WriteLine("not found");

         Employee e5 = EmployeeArray.Where(s => s.EmpID == 5).FirstOrDefault();
        if (e5 != null)
            Console.WriteLine("ID is present in array");
        else
            Console.WriteLine("Id not found");



    }
}

using System;


namespace ConsoleApp2
{
    class Employeee
    {
        public virtual void Work()
        {
            Console.WriteLine("employee is working");
        }
    }

    class Manager : Employeee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is supervising");
        }
    }
}

using System;
using ConsoleApp2;

class Program
{
    static void Main()
    {
        Manager manager = new Manager();
        manager.Work();

        Employeee emp = new Employeee();
        emp.Work();

        Employeee employ = new Manager();
        employ.Work();



    }
 }
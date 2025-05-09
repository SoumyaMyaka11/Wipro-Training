using System;


namespace ConsoleApp2
{
     class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Add(double  x , double y)
        {
            return x + y;
        }
    }
}


using System;
using ConsoleApp2;

class Program
{
        static void Main()
        {
            Calculator cal = new Calculator();

            Console.WriteLine($"ADDITION OF 2 INTEGERS : {cal.Add(2, 4)}");

            Console.WriteLine($"ADDITION OF 3 INTEGERS : {cal.Add(2, 4,6)}");

            Console.WriteLine($"ADDITION OF 2 DOUBLES : {cal.Add(2.2, 4.2)}");
        } 
 }


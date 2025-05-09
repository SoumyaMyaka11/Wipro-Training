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

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public double Sub(double x, double y)
        {
           return x - y;
        }

        public int Sub(int x, int y, int z)
        { 
           return x - y - z;
         }
         public int Mul(int x , int y)
         {
             return x * y;
         }

        public double Mul(double x, double y)
        {
             return x * y;
         }

        public int Mul(int x, int y, int z)
         {
           return x * y * z;
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
            Console.WriteLine("ADDITION");
            Console.WriteLine($"ADDITION OF 2 INTEGERS : {cal.Add(2, 4)}");
            Console.WriteLine($"ADDITION OF 3 INTEGERS : {cal.Add(2, 4,6)}");
            Console.WriteLine($"ADDITION OF 2 DOUBLES : {cal.Add(2.2, 4.2)}\n");

            Console.WriteLine("SUBTRACTION");
            Console.WriteLine($"SUBTRACTION OF 2 INTEGERS : {cal.Sub(10, 4)}");
            Console.WriteLine($"SUBTRACTION OF 3 INTEGERS : {cal.Sub(10, 2, 6)}");
            Console.WriteLine($"SUBTRACTION  OF 2 DOUBLES : {cal.Sub(6.3, 4.2)}\n");

            Console.WriteLine("MULTIPLICATION");
            Console.WriteLine($"MULTIPLICATION OF 2 INTEGERS : {cal.Mul(2, 4)}");
            Console.WriteLine($"MULTIPLICATION OF 3 INTEGERS : {cal.Mul(2, 4, 6)}");
            Console.WriteLine($"MULTIPLICATION OF 2 DOUBLES : {cal.Mul(2.2, 4.2)}\n");
        } 
 }


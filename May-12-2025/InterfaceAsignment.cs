using System;

namespace ConsoleApp2
{
    interface ICalculator
    {
        int  Add(int x, int y);
        int Sub(int x, int y);
        int   Mul(int x, int y);
        double Div(double x, double y);
    }

    class SimpleCalculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;

        }

        public double Div(double x, double y)
        {
            return x/y;
        }

    }

    class Program
    {
        static void Main()
        {
            ICalculator cal;

            cal = new SimpleCalculator();
            Console.WriteLine($"ADDITION : { cal.Add(2,4)}");

            Console.WriteLine($"SUBTRACTION : {cal.Sub(10, 2)}");

            Console.WriteLine($"MULTIPLICATION: {cal.Mul(5, 4)}");

            Console.WriteLine($"DIVISION : {cal.Div(24, 4)}");


         }

    }
}

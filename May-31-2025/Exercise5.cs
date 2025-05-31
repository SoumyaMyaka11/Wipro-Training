using System;

namespace ConsoleApp9
{
    class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static float Add(float a, float b) => a + b;
        public static double Add(double a, double b) => a + b;

        public static int Sub(int a, int b) => a - b;
        public static float Sub(float a, float b) => a - b;
        public static double Sub(double a, double b) => a - b;

        public static int Mul(int a, int b) => a * b;
        public static float Mul(float a, float b) => a * b;
        public static double Mul(double a, double b) => a * b;

    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter operation(add, sub or mul");
            string operation = Console.ReadLine().ToLower();

            Console.WriteLine("enter data type(int, float, doublr)");
            string datatype = Console.ReadLine().ToLower();

            Console.WriteLine("enter first number");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter second number");
            string str2 = Console.ReadLine();

            switch (datatype)
            {
                case "int":
                    int i1 = int.Parse(str1);
                    int i2 = int.Parse(str2);
                    PerformOperation(operation, i1, i2);
                    break;

                case "float":
                    float f1 = float.Parse(str1);
                    float f2 = float.Parse(str2);
                    PerformOperation(operation, f1, f2);
                    break;

                case "double":
                    double d1 = double.Parse(str1);
                    double d2 = double.Parse(str2);
                    PerformOperation(operation, d1, d2);
                    break;

                default:
                    Console.WriteLine("unsupported datatype");
                    break;
            }
        }

        public static void PerformOperation(string op, int a, int b)
        {
            switch (op)
            {
                case "add": Console.WriteLine("Result: " + Calculator.Add(a, b)); break;
                case "subtract": Console.WriteLine("Result: " + Calculator.Sub(a, b)); break;
                case "multiply": Console.WriteLine("Result: " + Calculator.Mul(a, b)); break;
                default: Console.WriteLine("Invalid operation."); break;
            }
        }

        public static void PerformOperation(string op, float a, float b)
        {
            switch (op)
            {
                case "add": Console.WriteLine("Result: " + Calculator.Add(a, b)); break;
                case "subtract": Console.WriteLine("Result: " + Calculator.Sub(a, b)); break;
                case "multiply": Console.WriteLine("Result: " + Calculator.Mul(a, b)); break;
                default: Console.WriteLine("Invalid operation."); break;
            }
        }

        public static void PerformOperation(string op, double a, double b)
        {
            switch (op)
            {
                case "add": Console.WriteLine("Result: " + Calculator.Add(a, b)); break;
                case "subtract": Console.WriteLine("Result: " + Calculator.Sub(a, b)); break;
                case "multiply": Console.WriteLine("Result: " + Calculator.Mul(a, b)); break;
                default: Console.WriteLine("Invalid operation."); break;
            }
        }
    }
}

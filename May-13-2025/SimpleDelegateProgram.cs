using System;

namespace Linq_Project
{
    class SimpleDelegate
    {

        public delegate int SomeOperation(int i, int j);

        class Program
        {
            static int Sum(int x, int y)
            {
                return x + y;
            }

            public static void ConsolePrint(int x)
            {
                Console.WriteLine($"consoleprints: {x}");
            }

            public static void PrinterPrint(int x)
            {
                Console.WriteLine($"printerprints : {x} ");
            }


            static void Main()
            {
                SomeOperation Add;

                Add = Sum;

                int res = Add(4, 3);
                Console.WriteLine(res);

                //another /latest way to represent a delegate
                Func<int, int, int> Add = Sum;

                int res = Add(15, 10);
                Console.WriteLine(res);  

                Action<int> printconsole = ConsolePrint;
                Action<int> printprinter = PrinterPrint;

                printconsole(10);
                printconsole(19);          
            }
        }
    }
}


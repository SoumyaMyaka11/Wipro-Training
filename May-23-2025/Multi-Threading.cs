using System;
using System.Threading;

namespace ConsoleApp7
{
    class ThreadDemo
    {
        static void PrintNumbers()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Thread : {i}");
                if (i == 3)
                {
                    Console.WriteLine("method went to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Method woke up");
                }
            }
        }

        static void Main()
        {
            Thread t = new Thread(PrintNumbers);
            t.Start();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                if (i == 2)
                {
                    Console.WriteLine("Main went to sleep");
                    Thread.Sleep(500);
                    Console.WriteLine("Main woke up");
                }
            }

        }
    }
}

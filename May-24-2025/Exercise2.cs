using System;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {

        static void PrintTask()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($" Printing {i}");
                Thread.Sleep(300); 
            }
            Console.WriteLine("PrintTask Finished.");
        }

        static void ComputeTask()
        {
            long sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += i;
            }
            Console.WriteLine($" Computation done. Sum = {sum}");
        }

        static void WaitTask()
        {
            Console.WriteLine(" Waiting for 2 seconds...");
            Thread.Sleep(2000);
            Console.WriteLine(" Done waiting.");
        }


        static void Main()
        {
            Thread printThread = new Thread(PrintTask);
            Thread computeThread = new Thread(ComputeTask);
            Thread waitThread = new Thread(WaitTask);

            Console.WriteLine(" Starting threads...");

            printThread.Start();
            printThread.Join();

            computeThread.Start();
            computeThread.Join();

            waitThread.Start();
            waitThread.Join();

            Console.WriteLine(" All tasks done.");
        }
    }
}

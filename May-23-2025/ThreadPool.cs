using System;
using System.Threading;

namespace ConsoleApp7
{
     class ThreadPoolDemo
    {
        static void DoWork(object state)
        {
            Console.WriteLine($"ThreadPool:Task Started - {state}");
            Thread.Sleep(1000);
            Console.WriteLine($"ThreadPool:Task finished - {state}");

        }

        static void Main()
        {
            for(int i=1; i<=5; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, $"Task {i}");
            }

            Console.WriteLine("Main thread cotinuess..");
            Thread.Sleep(3000);
            Console.WriteLine("Main thread ens");
        }
    }
}

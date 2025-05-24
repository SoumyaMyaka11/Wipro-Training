using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
 

    class Program
    {

        static void ProcessItem(object item)
        {
            int id = (int)item;
            Console.WriteLine($" Starting item {id} on Thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(500); 
            Console.WriteLine($" Finished item {id}");
        }

        static void Main()
        {
            Console.WriteLine(" Queuing 5 lightweight tasks to the ThreadPool...");

            for (int i = 1; i <= 5; i++)
            {
                int itemNumber = i; 
                ThreadPool.QueueUserWorkItem(ProcessItem, itemNumber);
            }

            
            Thread.Sleep(3000);
            Console.WriteLine("All tasks finished");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp7
{ 

    public class Program
    {
        private static Queue<string> workQueue = new Queue<string>();
        private static object lockObject = new object();
        private static bool workCompleted = false;

        public static void Main(string[] args)
        {
            Thread workerThread = new Thread(ProcessTasks);
            workerThread.Start();

            
            for (int i = 1; i <= 5; i++)
            {
                lock (lockObject)
                {
                    workQueue.Enqueue($"Task {i}");
                    Console.WriteLine($" Enqueued Task {i}");
                }
                Thread.Sleep(500); 
            }

            
            workCompleted = true;

           
            workerThread.Join();
            Console.WriteLine(" All tasks processed. Exiting.");
        }

        private static void ProcessTasks()
        {
            while (true)
            {
                string task = null;

                lock (lockObject)
                {
                    if (workQueue.Count > 0)
                    {
                        task = workQueue.Dequeue();
                    }
                    else if (workCompleted)
                    {
                        break; 
                    }
                }

                if (task != null)
                {
                    Console.WriteLine($" Processing {task}");
                    Thread.Sleep(1000); 
                }
                else
                {
                    Thread.Sleep(100); 
                }
            }
        }
    }
}

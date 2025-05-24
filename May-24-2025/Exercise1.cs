using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    using System;
    using System.Threading;

    class ControlledThread
    {
        private Thread thread;
        private bool pause = false;
        private bool stop = false;
        private readonly object lockObj = new object();

        public void Start()
        {
            thread = new Thread(Run);
            thread.Start();
            Console.WriteLine($"[Start] Thread state: {thread.ThreadState}");
        }

        private void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                lock (lockObj)
                {
                    while (pause)
                    {
                        Monitor.Wait(lockObj); 
                    }
                    if (stop)
                    {
                        Console.WriteLine("[Stop] Exiting thread loop.");
                        break;
                    }
                }

                Console.WriteLine($"[Run] {i}");
                Thread.Sleep(100); 
            }

            Console.WriteLine("[Run] Thread finished.");
        }

        public void Pause()
        {
            lock (lockObj)
            {
                pause = true;
                Console.WriteLine("[Pause] Thread is paused.");
            }
        }

        public void Resume()
        {
            lock (lockObj)
            {
                pause = false;
                Monitor.Pulse(lockObj); // Wake the thread
                Console.WriteLine("[Resume] Thread resumed.");
            }
        }

        public void Stop()
        {
            lock (lockObj)
            {
                stop = true;
                pause = false; // In case it's waiting
                Monitor.Pulse(lockObj);
                Console.WriteLine("[Stop] Stop signal sent.");
            }
        }

        public ThreadState GetThreadState()
        {
            return thread?.ThreadState ?? ThreadState.Unstarted;
        }
    }

    class Program
    {
        static void Main()
        {
            ControlledThread ct = new ControlledThread();

            ct.Start();

            Thread.Sleep(1500);
            ct.Pause();
            Console.WriteLine($"[Main] Thread state: {ct.GetThreadState()}");

            Thread.Sleep(2000);
            ct.Resume();
            Console.WriteLine($"[Main] Thread state: {ct.GetThreadState()}");

            Thread.Sleep(2000);
            ct.Stop();
            Console.WriteLine($"[Main] Thread state: {ct.GetThreadState()}");

            Thread.Sleep(2000);
            Console.WriteLine($"[Main] Final Thread state: {ct.GetThreadState()}");
        }
    }
}

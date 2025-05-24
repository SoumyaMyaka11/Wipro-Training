using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp7
{ 
    class Program
    {
        static async Task SimulateWorkAsync(string name, int delay)
        {
            Console.WriteLine($"{name} - delay {delay}ms");
            await Task.Delay(delay);
            Console.WriteLine($"{name} completed");
        }

        static async Task Main()
        {
            Console.WriteLine("Comparing Sequential vs Parallel Execution...\n");

            // SEQUENTIAL EXECUTION
            Stopwatch swSeq = Stopwatch.StartNew();

            await SimulateWorkAsync("Task A", 2000);
            await SimulateWorkAsync("Task B", 1500);
            await SimulateWorkAsync("Task C", 1000);

            swSeq.Stop();
            Console.WriteLine($"\n Sequential time: {swSeq.ElapsedMilliseconds} ms");

            // PARALLEL EXECUTION
            Stopwatch swPar = Stopwatch.StartNew();

            Task t1 = SimulateWorkAsync("Task A", 2000);
            Task t2 = SimulateWorkAsync("Task B", 1500);
            Task t3 = SimulateWorkAsync("Task C", 1000);

            await Task.WhenAll(t1, t2, t3);

            swPar.Stop();
            Console.WriteLine($"\n Parallel time: {swPar.ElapsedMilliseconds} ms");
        }
    }
}

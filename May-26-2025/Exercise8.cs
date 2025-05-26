using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    public class Program
    {
        public static async Task Main()
        {
            Console.WriteLine(" Starting parallel tasks...\n");

            var tasks = new List<Task>
        {
            SimulateWorkAsync("Task1", 500),
            SimulateWorkAsync("Task2", 700, throwError: true),
            SimulateWorkAsync("Task3", 400),
            SimulateWorkAsync("Task4", 600, throwError: true),
            SimulateWorkAsync("Task5", 300)
        };

            try
            {
                await Task.WhenAll(tasks);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("AggregateException caught:");
                foreach (var inner in ex.InnerExceptions)
                {
                    Console.WriteLine($" - {inner.Message}");
                }
            }

            Console.WriteLine("\nAll tasks attempted. Summary complete.");
        }

        static async Task SimulateWorkAsync(string taskName, int delayMs, bool throwError = false)
        {
            await Task.Delay(delayMs);
            if (throwError)
            {
                throw new InvalidOperationException($"{taskName} failed after {delayMs}ms");
            }
            Console.WriteLine($"{taskName} completed after {delayMs}ms");
        }
    }
}

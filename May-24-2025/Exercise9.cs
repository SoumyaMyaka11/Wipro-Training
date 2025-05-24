using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{ 

    class Program
    {
        static async Task RiskyTaskAsync(string name, bool shouldFail)
        {
            Console.WriteLine($" {name}");
            await Task.Delay(1000);

            if (shouldFail)
            {
                throw new InvalidOperationException($"{name} failed due to some error.");
            }

            Console.WriteLine($"{name} completed successfully.");
        }

        static async Task Main()
        {
            Console.WriteLine(" Starting risky tasks...\n");

            Task t1 = RiskyTaskAsync("Task A", false);
            Task t2 = RiskyTaskAsync("Task B", true);
            Task t3 = RiskyTaskAsync("Task C", false);

            try
            {
                await Task.WhenAll(t1, t2, t3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Caught exception: {ex.Message}");


                if (ex is AggregateException aggEx)
                {
                    foreach (var inner in aggEx.InnerExceptions)
                    {
                        Console.WriteLine($" Inner: {inner.Message}");
                    }
                }
            }

            Console.WriteLine("\n All tasks attempted.");
        }

    }
}

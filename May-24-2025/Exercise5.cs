using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{


    class Program
    {

        static async Task<string> DelayedTask(string name, int delay)
        {
            await Task.Delay(delay);
            Console.WriteLine($" {name} completed after {delay}ms");
            return name;
        }

        static async Task Main()
        {
            Console.WriteLine(" Starting 3 tasks with different delays...");

            var task1 = DelayedTask("Task 1", 3000);
            var task2 = DelayedTask("Task 2", 1000);  
            var task3 = DelayedTask("Task 3", 2000);

            Task<string> firstCompleted = await Task.WhenAny(task1, task2, task3);

            Console.WriteLine($" First completed: {firstCompleted.Result}");
        }
    }
}

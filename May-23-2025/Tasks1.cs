using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class TaskDemo2
    {
        static async Task Main()
        {
            Console.WriteLine("starting all tasks");

            Task task1 = DoWorkAsync("Task 1", 2000);
            Task task2 = DoWorkAsync("Task 2", 3000);
            Task task3 = DoWorkAsync("Task 3", 1000);

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("ALL tasks are Completed");
        }

        static async Task DoWorkAsync(string name, int delay)
        {
            Console.WriteLine($"{name} started ");
            await Task.Delay(delay);
            Console.WriteLine($"{name} completed after {delay} ms");
        }
    }
}

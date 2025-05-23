using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class TaskDemo
     {
        static async Task Main(string[] args)
        {
            Console.WriteLine("work  started");

            await DoAsyncWork();

            Console.WriteLine("work completed");
        }

        static async Task DoAsyncWork()
        {
            Console.WriteLine("working asynchronously");

            await Task.Delay(2000);

            Console.WriteLine("work done");
        }
     }.
}
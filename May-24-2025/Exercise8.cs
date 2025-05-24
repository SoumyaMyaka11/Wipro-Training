using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class Program
    {

        static async Task DoWorkAsync(CancellationToken token)
        {
            Console.WriteLine(" Starting long-running work...");

            for (int i = 1; i <= 10; i++)
            {
                token.ThrowIfCancellationRequested(); 

                Console.WriteLine($" Working... step {i}");
                await Task.Delay(500); 
            }

            Console.WriteLine(" Work completed.");
        }

        static async Task Main()
        {
            Console.WriteLine( "Starting cancellable work...\n");

            CancellationTokenSource cts = new CancellationTokenSource();

            Task workTask = DoWorkAsync(cts.Token);

            
            await Task.Delay(2000);
            Console.WriteLine("Requesting cancellation...");
            cts.Cancel();

            try
            {
                await workTask;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine(" Task was canceled successfully.");
            }
            finally
            {
                cts.Dispose();
            }
        }
    }
}


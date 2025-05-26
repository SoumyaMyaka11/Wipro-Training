using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    public class Program
    {

        private static async Task<string> ServerResponseAsync(string serverName, CancellationToken token)
        {
            int delay = new Random().Next(1000, 3000);
            try
            {
                await Task.Delay(delay, token);
                return $"{serverName} responded in {delay}ms";
            }
            catch (TaskCanceledException)
            {
                return $"{serverName} was cancelled after {delay}ms";
            }
        }
        public static async Task Main()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            var serverTasks = new[]
            {
            ServerResponseAsync("Server1", token),
            ServerResponseAsync("Server2", token),
            ServerResponseAsync("Server3", token)
        };

            Task<Task<string>> fastestTask = Task.WhenAny(serverTasks);
            Task<string> winner = await fastestTask;

            Console.WriteLine($" Fastest response: {await winner}");

            
            cts.Cancel();

            try
            {
                await Task.WhenAll(serverTasks); 
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine(" Remaining tasks were cancelled.");
            }
        }

        
    }
}

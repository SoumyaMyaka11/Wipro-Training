using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class AsyncTasks
    {
        static async Task DownloadFileAsync(string Filename , int delayms)
        {
            Console.WriteLine($"Starting Download :  {Filename}");
            await Task.Delay(delayms);
            Console.WriteLine($"Download completed of {Filename} ({delayms}ms)");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Stating all downloads...");

            Task file1 = DownloadFileAsync("file1.pdf", 3000);
            Task file2 = DownloadFileAsync("file2.jpg", 2000);
            Task file3 = DownloadFileAsync("file3.zip", 4000);

            await Task.WhenAll(file1, file2, file3);

            Console.WriteLine("All downloads are completed");
        }
    }
}

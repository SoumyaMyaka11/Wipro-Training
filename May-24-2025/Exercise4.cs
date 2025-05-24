using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp7
{

    class Program
    {
        

        static async Task DownloadFileAsync(string fileName, int delay)
        {
            Console.WriteLine($" Starting download of {fileName}  ");
            await Task.Delay(delay); 
            Console.WriteLine($" {fileName} downloaded ({delay}ms)");
        }

        static async Task Main()
        {
            Console.WriteLine(" Starting parallel downloads...");

            Stopwatch stopwatch = Stopwatch.StartNew();

            
            Task t1 = DownloadFileAsync("file1.txt", 2000);
            Task t2 = DownloadFileAsync("file2.txt", 3000);
            Task t3 = DownloadFileAsync("file3.txt", 1500);

            await Task.WhenAll(t1, t2, t3);

            stopwatch.Stop();

            Console.WriteLine($" All downloads completed in {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main()
        {
            
            List<string> images = new List<string>();
            for (int i = 1; i <= 20; i++)
            {
                images.Add($"image_{i}.jpg");
            }

            int total = images.Count;
            int processed = 0;

            Console.WriteLine("Starting batch image processing...\n");

            
            await Parallel.ForEachAsync(images, async (image, token) =>
            {
                await Task.Delay(200); 
                int current = Interlocked.Increment(ref processed);
                double percent = (current / (double)total) * 100;
                Console.WriteLine($" Processed {image} - {percent:0}% complete");
            });

            Console.WriteLine("\n All images processed.");
        }
    }
}

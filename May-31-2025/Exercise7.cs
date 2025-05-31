using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp9
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Fetching weather data for 3 cities...\n");

            Stopwatch stopwatch = Stopwatch.StartNew();

            
            Task<string> city1 = GetWeatherAsync("Hyderabad", 3000);
            Task<string> city2 = GetWeatherAsync("Delhi", 2000);
            Task<string> city3 = GetWeatherAsync("Chennai", 4000);

            
            var results = await Task.WhenAll(city1, city2, city3);

            stopwatch.Stop();

            
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine($"\nAll data fetched in {stopwatch.ElapsedMilliseconds} ms.");
        }

        
        static async Task<string> GetWeatherAsync(string city, int delay)
        {
            await Task.Delay(delay); 
            return $"{city}: {new Random().Next(15, 35)}°C (after {delay} ms)";
        }
    }
}

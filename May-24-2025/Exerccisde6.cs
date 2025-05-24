using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
       
        static async Task<int> GetTemperatureAsync(string city)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int delay = rand.Next(1000, 3000);
            int temperature = rand.Next(30,50);

            Console.WriteLine($" Fetching temperature {city} (delay: {delay}ms)...");
            await Task.Delay(delay);

            Console.WriteLine($" Done with {city}");
            return temperature;
        }

        static async Task Main()
        {
            Console.WriteLine(" Getting temperatures for 3 cities...\n");

            Task<int> t1 = GetTemperatureAsync("Munbai");
            Task<int> t2 = GetTemperatureAsync("Delhi");
            Task<int> t3 = GetTemperatureAsync("Hyderabad");

            int temp1 = await t1;
            int temp2 = await t2;
            int temp3 = await t3;

            Console.WriteLine($"\n🌡️ Temperatures:");
            Console.WriteLine($"Mumbai: {temp1}°C");
            Console.WriteLine($"Delhi:   {temp2}°C");
            Console.WriteLine($"Hyderabad:    {temp3}°C");
        }

    }
}

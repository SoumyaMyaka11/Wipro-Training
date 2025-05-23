using System;
using System.Threading;

class Program
{

    static void Main(string[] aargs)
    {
        int a = 3;
        int b = 5;

        Thread thread = new Thread(() =>
        {
            Console.WriteLine($"Sum is : {a + b}");
        });

        thread.Start();
    }
}

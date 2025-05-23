using System;
using System.Threading;

class Program
{
    static void PrintMessage(object Message)
    {
        string msge = (string)Message;
        Console.WriteLine($"Message : {msge}");
    }

    static void Main()
    {
        Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        thread.Start("Hello from thread");
    }
}
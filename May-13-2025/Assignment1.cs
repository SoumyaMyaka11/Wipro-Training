using System;

namespace Linq_Project
{
    interface ITransport
    {
        void Start();
        void Stop();
    }

    class Bus : ITransport
    {
        public void Start()
        {
            Console.WriteLine("bus is starting");
        }

        public void Stop()
        {
            Console.WriteLine("bus is stopping");
        }
    }

    class Train : ITransport
    {
        public void Start()
        {
            Console.WriteLine("train is starting");
        }

        public void Stop()
        {
            Console.WriteLine("train is stopping");
        }
    }

    class Program
    {
        public static void Main()
        {
            ITransport transport;

            transport = new Bus();
            transport.Start();
            transport.Stop();

            transport = new Train();
            transport.Start();
            transport.Stop();
        }
    }
}

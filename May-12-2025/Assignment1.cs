using System;

namespace ConsoleApp2
{
    interface IDeviceControl
    {
        void TurnOn();
        void TurnOff();
    }

    class SmartTV : IDeviceControl
    {
        public void TurnOn()
        {
            Console.WriteLine("SmartTV is now on");
        }

        public void TurnOff()
        {
            Console.WriteLine("SmartTV is now off");
        }
    }

    class Speaker : IDeviceControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Speaker is now on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Speaker is now off");
        }
    }

    class Program
    {
        static void Main()
        {
            IDeviceControl device;

            device = new SmartTV();
            device.TurnOn();
            device.TurnOff();

            device = new Speaker();
            device.TurnOn();
            device.TurnOff();

        }

    }

}
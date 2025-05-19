using System;

namespace ConsoleApp4
{

     interface IRemoteControl
    {
        void IncreaseVolume();
        void DecreaseVolume();
    }
    abstract class SmartDevice 
    {
        public abstract void TurnOn();
        public void ShowStatus()
        {
            Console.WriteLine("device status is Active");
        }
    }
    

    class SmartLight : SmartDevice,IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("smartlight turned on");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("Lights do not support volume control");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("Lights do not support volume control");
        }

    }

    class SmartSpeaker : SmartDevice, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("smartspeaker turned on");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("volume is increased");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("volume is decreased");
        }

    }

    class Program
    {
        public static void Main()
        {
            SmartDevice device;
            IRemoteControl remote;

            Console.WriteLine("SMARTLIGHT:");
            device = new SmartLight();
            remote = new SmartLight();
            device.ShowStatus();
            device.TurnOn();
            remote.IncreaseVolume();
            remote.DecreaseVolume();

            Console.WriteLine("\nSMARTSPEAKER:");
            device = new SmartSpeaker();
            remote = new SmartSpeaker();
            device.ShowStatus();
            device.TurnOn();
            remote.IncreaseVolume();
            remote.DecreaseVolume();


        }
    }

}

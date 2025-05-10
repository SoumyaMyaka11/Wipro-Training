using System;

namespace ConsoleApp2
{
    class SmartDevice
    {
        public string DeviceName;
        public bool PowerStatus;
        
        public void TogglePower()
        {
            Console.WriteLine($"Power status changed from {PowerStatus} to {!PowerStatus}");
        }
    }

    class SmartLight : SmartDevice
    {
        public int Brightness;

        public void ChangeBrigthness(int Brightness)
        {
            this.Brightness = Brightness;
            Console.WriteLine($"The brigthness is changed to : {Brightness}");
        }
    }

    class SmartThermostat : SmartLight
    {
        public double Temperature;

        public void ChangeTemperature(double Temperature)
        {
             this.Temperature = Temperature;
            Console.WriteLine($"The temperature is changed to : {Temperature} ");
        }
    }
     
    class Program
    {
        static void Main()
        {
        
           SmartThermostat smartthermo = new SmartThermostat();
           smartthermo.TogglePower();
           smartthermo.ChangeBrigthness(65);
            smartthermo.ChangeTemperature(43.5);

        }
    }
}

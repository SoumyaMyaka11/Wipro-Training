using System;

namespace ConsoleApp2
{
    class Appliance
    {
        public virtual void Operate()
        {
            Console.WriteLine("Appliance performing operation");
        }
    }

    class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("WashingMachine in  operation");
        }
    }

    class Program
{
    static void Main()
    {
        WashingMachine machine = new WashingMachine();
        machine.Operate();

        Appliance appliance = new Appliance();
        appliance.Operate();

        Appliance app = new WashingMachine();
        app.Operate();

    }

        
}

using System;


namespace ConsoleApp3
{
    internal interface IMaintainance
    {

        void Service();
        void Repair();
    }

    class CarMaintainance : IMaintainance
    {
        public void Service()
        {
            Console.WriteLine("car is being serviced");
        }

        public void Repair()
        {
            Console.WriteLine("car is being repaired");
        }
    }

    class BikeMaintainance : IMaintainance
    {
        public void Service()
        {
            Console.WriteLine("bike is being serviced");
        }

        public void Repair()
        {
            Console.WriteLine("bike is being repaired");
        }
    }

    class program
    {
        public static void Main()
        {
            IMaintainance maintainance;

            maintainance = new CarMaintainance();
            maintainance.Service();
            maintainance.Repair();

            maintainance = new BikeMaintainance();
            maintainance.Service();
            maintainance.Repair();
        }
    }
}

using System;


namespace ConsoleApp2
{
    class Vehicle
    {
        public string Make;
        public string Model;

        public void DisplayVehicle()
        {
            Console.WriteLine($"Make : {Make}");
            Console.WriteLine($"Model : {Model}");
        }
    }

    class Car : Vehicle
    {
        public string FuelType;

        public void DisplayCar()
        {
            Console.WriteLine($"FuelType : {FuelType}");
        }
    }
}

using System;
//using ConsoleApp2;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car();
            car1.Make = "Mahindra";
            car1.Model = "Mahindra XUV 3XO";
            car1.FuelType = "Petrol";

            car1.DisplayVehicle();

            car1.DisplayCar();
        } 
    }
}

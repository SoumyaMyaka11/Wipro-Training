using System;

namespace ConsoleApp5
{
    abstract class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand { get; set; }
        public decimal RatePerDay { get; set; }

        public Vehicle(string VehicleNumber, string Brand ,decimal RatePerDay)
        {
            this.VehicleNumber = VehicleNumber;
            this.Brand = Brand;
            this.RatePerDay = RatePerDay;
        }

        public virtual decimal CalculateRent(int days)
        {
            return RatePerDay * days;
        }
    }

    class Car : Vehicle
    {
        public Car(string VehicleNuber, string Brand, decimal RatePerDay) : base(VehicleNuber, Brand, RatePerDay) { }

        public override decimal CalculateRent(int days)
        {
            return base.CalculateRent(days) + 300;
        }
    }

    class Bike : Vehicle
    {
        public Bike(string VehicleNuber, string Brand, decimal RatePerDay) : base(VehicleNuber, Brand, RatePerDay) { }

        public override decimal CalculateRent(int days)
        {
            return base.CalculateRent(days) + 100;
        }
    }

    class Truck : Vehicle
    {
        public Truck(string VehicleNuber, string Brand, decimal RatePerDay) : base(VehicleNuber, Brand, RatePerDay) { }

        public override decimal CalculateRent(int days)
        {
            return base.CalculateRent(days) + 200;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("CAR004", "BMW",3000),
                new Bike("BIKE004", "pulser",1000),
                new Truck("Truck004", "Mahindhra",3500)
            };

            Console.WriteLine("Enter number of days");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}", "Type", "Brand", "VehicleNo", "Rate/Day", "TotalRent");
            Console.WriteLine("----------------------------------------------------------------------");

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}",
                                      vehicle.GetType().Name,
                                      vehicle.Brand,
                                      vehicle.VehicleNumber,
                                      vehicle.RatePerDay,
                                      vehicle.CalculateRent(n) );                   
            }
        }
    }

}
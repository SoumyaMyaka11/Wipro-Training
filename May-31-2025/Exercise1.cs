using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
     interface IRentable
    {
        void Rent(int days);
    }

    abstract class Vehicle :IRentable
    {
        public string Name { get; set; }
        public double RentPerDay { get; set; }

        public Vehicle(string Name , double RentPerDay )
        {
            this.Name = Name;
            this.RentPerDay = RentPerDay;
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name} and RentPerDay : {RentPerDay} ");

        }
        public abstract void Rent(int days);
    }

    class Car : Vehicle
    {
        public Car(string Name, double RentPerDay) : base(Name, RentPerDay) { }

        public override void Rent(int days)
        {
            Console.WriteLine($"Car {Name} rented for {days} days and cost for renting is  {RentPerDay * days}");
        }
    }

    class Bike : Vehicle
    {
        public Bike(string Name, double RentPerDay) : base(Name, RentPerDay) { }

        public override void Rent(int days)
        {
            Console.WriteLine($"Bike {Name} rented for {days} days and cost for renting is {RentPerDay * days}");
        }
    }

    class Truck : Vehicle
    {
        public Truck(string Name, double RentPerDay) : base(Name, RentPerDay) { }

        public override void Rent(int days)
        {
            Console.WriteLine($"Truck {Name} rented for {days} days and cost for renting is {RentPerDay * days}");
        }
    }

    class Program
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("DEFENDER",50),
                new Bike("Yamaha R15",25),
                new Truck("Volvo X26",30)
            };

            /*foreach (Vehicle v in vehicles)
            {
                Console.WriteLine("Enter no of days for renting");
                int num = Convert.ToInt32(Console.ReadLine());
                v.Display();
                v.Rent(num);
                Console.WriteLine();
            }*/
            //OR

            for(int i=0; i<vehicles.Count; i++)
            {
                Console.Write($"{i + 1} ");
                vehicles[i].Display();
            }

            while(true)
            {
                Console.WriteLine("\nenter vehicle number to rent and 0 TO Exit");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                    break;
                if(num <1 || num > vehicles.Count)
                {
                    Console.WriteLine("Invalid choice .Try again");
                    continue;
                }

                Console.WriteLine("Enter no of days to rent");
                int r = Convert.ToInt32(Console.ReadLine());

                vehicles[num - 1].Display();
                vehicles[num - 1].Rent(r);
            }
        }
    }
}

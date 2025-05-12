using System;

namespace ConsoleApp2
{
    interface IAnimalActions
    {
        void Eat();
        void Sleep();
    }

    class Lion : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("lion is eating meat");        
        }
        public void Sleep()
        {
            Console.WriteLine("Lion is Sleeping");
        }
    }

    class Elephant : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("Elephant is eating meat");
        }
        public void Sleep()
        {
            Console.WriteLine("Elephant is Sleeping");
        }
    }
  
    class Program
    {
        public static void Main()
        {
            IAnimalActions action;

            action = new Lion();
            action.Eat();
            action.Sleep();

            action = new Elephant();
            action.Eat();
            action.Sleep();
        }
    }

}
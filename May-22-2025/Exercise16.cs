using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public abstract void MakeSound();

        public void Feed()
        {
            Console.WriteLine("Feeding the Animal");
        }
    }

     class Lion :Animal
    {
        public Lion(string Name, int Age) : base(Name, Age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the lion roars!!");
        }
    }

    class Elephant : Animal
    {
        public Elephant(string Name, int Age) : base(Name, Age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the lion trumpets!!");
        }
    }

    class Monkey : Animal
    {
        public Monkey(string Name, int Age) : base(Name, Age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the lion chatters!!");
        }
    }

    class Zoo
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void AnimalRoutine()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
                animal.MakeSound();
                animal.Feed();
                Console.WriteLine();
            }
        }

        
        static void Main()
        {
            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Lion("Simba", 5));
            zoo.AddAnimal(new Elephant("Dumbo", 10));
            zoo.AddAnimal(new Monkey("George", 3));

            zoo.AnimalRoutine();
        }
    }
}

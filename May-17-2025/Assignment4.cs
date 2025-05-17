using System;

namespace ConsoleApp3
{
    abstract  class Animal
    {
        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat makes sound as Meowww");
        }
    }

    class Program
    {
        public static void Main()
        {
            Animal animal;

            animal = new Dog();
            animal.Eat();
            animal.MakeSound();

            animal = new Cat();
            animal.Eat();
            animal.MakeSound();
        }
    }
}

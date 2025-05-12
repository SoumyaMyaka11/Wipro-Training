using System;

namespace ConsoleApp2
{
    abstract class Shape2
    {
        public abstract void Draw();

        public void Display()
        {
            Console.WriteLine("This is a shape");
        }
    }

    class Rectangle : Shape2
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle is drawn");
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

        }
    }

}
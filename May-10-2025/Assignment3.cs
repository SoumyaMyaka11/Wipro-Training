using System;

namespace ConsoleApp2
{
     class AreaCalculation
    {
        public int Area(int length, int breadth)
        {
            return length * breadth;
        }

        public double Area(double radius)
        {
            return 3.14 * radius * radius;
        }

        public double   Area(double basev , int height)
        {
            return (basev * height) / 2;
        }
    }

class Program
{
    static void Main()
    {
        AreaCalculation area = new AreaCalculation();

        Console.WriteLine($"Area of Rectangle is : {area.Area(4, 5)}");

        Console.WriteLine($"Area of Circle is : {area.Area(3.2)}");

        Console.WriteLine($"Area of Triangle is : {area.Area(4.0, 6)}");
    }
}



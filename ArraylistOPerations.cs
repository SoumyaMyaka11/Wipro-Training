using System;
using System.Collections;

class Program
{
    public  static void Main(string[] args)
    {

        ArrayList list = new ArrayList() { 10, 19, 11, 25, 38, 45, 13, 21, 3, 50 };

        list.Sort();

        Console.WriteLine("Maximum element in the list is " + list[9]);

        Console.WriteLine("Minimum element in the list is " + list[0]);

        double sum = 0;
        foreach(int x in list)
        {
            sum = sum + x;
        }
        Console.WriteLine("Average of elements in the list is " + (sum / 10));
    }
}
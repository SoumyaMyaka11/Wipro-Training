using System;
using System.Collections;

class Program
{
    public  static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 4, 3, 5, 6, 2, 3, 4, 1, };

        HashSet<int> uniquenums = new HashSet<int>(numbers);

        int count = uniquenums.Count;
        Console.WriteLine("unique numbers count is " + count);

        Console.WriteLine("unique numbers in the list are");
        foreach (int num in uniquenums)
        {
            Console.Write(num + " ");
        }
    }
}
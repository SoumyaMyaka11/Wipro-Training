using System;
using System.Collections.Generic;



class Program
{
    public  static void Main(string[] args)
    {

        Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 1,"Ell"},
            {2,"Missy" },
            {3,"Harry" }
        };

        students[2] = "Keerthi";
          

        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Key} and NAME: {s.Value}");
        }
        Console.Read();
        
          
    }
}
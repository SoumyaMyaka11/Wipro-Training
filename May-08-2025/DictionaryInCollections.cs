using System;
using System.Collections.Generic;



class Program
{
    public  static void Main(string[] args)
    {

        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Keerthi");
        students.Add(2, "soumya");
        students.Add(3, "Harshika");

        Console.WriteLine($"student with ID 2: {students[2]}");
          

        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Key} and NAME: {s.Value}");
        }
        Console.Read();
        
          
    }
}
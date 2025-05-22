using System;
using System.Collections.Generic;


namespace ConsoleApp5
{
     class ListStudents
    {
       public static void Main()
        {
            List<string> students = new List<string>() { "keerthi" ,"harshika"};

            students.Add("Harshitha");
            students.Add("Ramya");
            students.Add("deepika");

            Console.WriteLine("student names before sorting :");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }

            students.Sort();

            Console.WriteLine("\nstudent names after sorting:");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
        }
    }
}

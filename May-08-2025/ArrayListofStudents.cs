using System;
using System.Collections;




class Program
{
    public  static void Main(string[] args)
    {

        ArrayList students = new ArrayList();

        students.Add("Swetha");
        students.Add("Asiya");
        students.Add("Yamini");
        students.Add("Ayat");
        students.Add("Ramya");

        students.Remove("Ayat");

        foreach (var name in students)
        {
            Console.WriteLine(name);
        }

        if (students.Contains("Swetha"))
            Console.WriteLine("exists in the student list");
        else
            Console.WriteLine("not exists in the student list");
    }
}
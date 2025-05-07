using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("keerthi");
        list.Add("soumya");
        list.Add("harshika");
        list.Add("harshitha");
        list.Add("ramya");

        if (list.Contains("soumya"))
            Console.WriteLine("element is present in the list");
        else
            Console.WriteLine("element not present");

        list.RemoveAt(1);


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        Console.Read();
    }
}
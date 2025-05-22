using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
     class PhoneDictionary
    {
        public static void Main()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            contacts.Add("keerthi", "9976543217");
            contacts.Add("harshika", "8883888234");
            contacts["deepika"] = "987345234";

            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name : {contact.Key} contac : {contact.Value}");
            }

            Console.WriteLine("\nenter name to display contact number");
            string name = Console.ReadLine();

            if (contacts.ContainsKey(name))
                Console.WriteLine($"contact number of {name} : {contacts[name]}");
            else
                Console.WriteLine("contact number not found");

        }
        
    }
}

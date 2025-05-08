using System;
using System.Collections.Generic;



class Program
{
    public  static void Main(string[] args)
    {

        Queue<string> queue = new Queue<string>();

        queue.Enqueue("keerthi");
        queue.Enqueue("harshika");
        queue.Enqueue("soumya");
        queue.Enqueue("harshitha");

        Console.WriteLine("queue elements are");
            foreach (var name in queue)
            {
                Console.WriteLine(name);
            }

        Console.WriteLine("\ndequeued: " + queue.Dequeue());

        Console.WriteLine("\npeek:" + queue.Peek());
        
          
    }
}
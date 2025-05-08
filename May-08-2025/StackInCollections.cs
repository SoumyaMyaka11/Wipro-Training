using System;
using System.Collections.Generic;



class Program
{
    public  static void Main(string[] args)
    {

       Stack<string> books = new Stack<string>();

        books.Push("Layla");
        books.Push("the palace of illusions");
        books.Push("bagavadh gita");
        books.Push("c# programming");


        Console.WriteLine("books in stack");
        foreach(var book in books)
        {
            Console.WriteLine(book);
        }

        //rading and removing element
        Console.WriteLine("\n books popped:" + books.Pop());

        Console.WriteLine("peek : " + books.Peek());
    }
}
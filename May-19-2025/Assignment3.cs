using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
        public override string ToString()
        {
            return $"{Title} : {Author}";
        }
    }

    class Program
    {
        public static void Main()
        {
            //QUEUE
            Queue<Book> books = new Queue<Book>();
            books.Enqueue(new Book("The Golden Gate", "Vikram Seth"));
            books.Enqueue(new Book("The Pride and Prjudice", "Jane Austin"));
            books.Enqueue(new Book("The Palace of Illusions", "Chitra Banerjee Divakaruni"));
            books.Enqueue(new Book("The Inheritance of Loss", "Kiran Desai"));
            books.Enqueue(new Book("The Girl in the Room 105", "Chetan Bhagata"));

            Console.WriteLine("The book that has to be returned is :");
            Console.WriteLine(books.Peek());
            Console.WriteLine(books.Dequeue()+"\n");

            //STACK

            Stack<Book> stackBooks = new Stack<Book>();
            stackBooks.Push(new Book("The Silent Patient", "Alex"));
            stackBooks.Push(new Book("Layla", "ColleenHoover"));
            stackBooks.Push(new Book("Atomic Habits", "Jamws Clear"));

            Console.WriteLine("last book purchase");
            Console.WriteLine(stackBooks.Peek());
            stackBooks.Pop();

            Console.WriteLine("\n Remaining Books in Queue:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }


            Console.WriteLine("\nRemaining books in Stack:");
            foreach (Book book in stackBooks)
            {
                Console.WriteLine(book);
            }

        }
    }
}

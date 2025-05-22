using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{ 
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string author, bool isAvailable)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
        }

        public void PrintBooks(List<Book> bookList)
        {
            foreach (var book in bookList)
            {
                Console.WriteLine("Id: " + book.Id);
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Available: " + (book.IsAvailable ? "Yes" : "No"));
                Console.WriteLine();
            }
        }
    }

    
    class Program
    {
        static void Main()
        {
            Library library = new Library();

            
            library.AddBook(new Book(2, "The Hobbit", "J.R.R. Tolkien", true));
            library.AddBook(new Book(3, "Harry Potter and the Sorcerer's Stone", "J.K. Rowling", false));
            library.AddBook(new Book(4, "The Power of Now", "Eckhart Tolle", true));
            

          
            Console.WriteLine("Search results for author 'Paulo Coelho':");
            var authorResults = library.SearchByAuthor("Paulo Coelho");
            library.PrintBooks(authorResults);

            Console.WriteLine("Search results for title containing 'the':");
            var titleResults = library.SearchByTitle("the");
            library.PrintBooks(titleResults);
        }
    }
}

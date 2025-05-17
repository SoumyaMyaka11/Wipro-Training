using System;

namespace ConsoleApp3
{
    abstract class Document
    {
        public abstract void PrintContent();
        public void ShowDocumentType(string type)
        {
            Console.WriteLine($"Document Type : {type}");
        }
    }

    class WordDocument : Document
    {
        public override void PrintContent()
        {
            Console.WriteLine("Printing WordDocument");
        }
    }

    class PDFDocument : Document
    {
        public override void PrintContent()
        {
            Console.WriteLine("Printing PDFDocument");
        }
    }

    class Program
    {
        public static void Main()
        {
            Document doc;

            doc = new WordDocument();
            doc.ShowDocumentType("WordDocument");
            doc.PrintContent();

            doc = new PDFDocument();
            doc.ShowDocumentType("PDFDocument");
            doc.PrintContent();
                
        }
    }
}

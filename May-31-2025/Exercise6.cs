using System;
using System.IO;
using System.Threading;

namespace ConsoleApp9
{
    class FileProcessor
    {
        static int totalLines = 0;
        static readonly object lockObj = new object();

        static void ReadFile(string filePath)
        {
            int lineCount = 0;
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                
                lock (lockObj)
                {
                    totalLines += lineCount;
                    Console.WriteLine($"Finished reading {filePath}, Lines: {lineCount}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file {filePath}: {ex.Message}");
            }
        }

        static void Main()
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string file3 = "file3.txt";

           
            Thread t1 = new Thread(() => ReadFile(file1));
            Thread t2 = new Thread(() => ReadFile(file2));
            Thread t3 = new Thread(() => ReadFile(file3));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine($"\nTotal lines in all files: {totalLines}");
        }
    }
}

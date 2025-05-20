using System;
using System.Diagnostics;
namespace ConsoleApp5
{
     class SearchingAlgorithms
    {
        public static int LinearSearch(int[] arr, int search, out int comparisions)
        {
            comparisions = 0;
            int index = -1;
            for(int i=0; i<arr.Length; i++)
            {
                comparisions++;
                if(arr[i] == search)
                {
                    return i;
                }

            }
            return index;
        }

        public static int BinarySearch(int[] arr, int search, out int comparisions)
        {
            comparisions = 0;
            int[] sortedarray = (int[])arr.Clone();
            Array.Sort(sortedarray);
            int left = 0;
            int right = sortedarray.Length - 1;
            while(left <= right)
            {
                int mid = (left + right)/2;
                comparisions++;

                if (sortedarray[mid] == search)
                    return mid;
                else if (search > sortedarray[mid])
                    left = mid + 1;
                else 
                    right = mid - 1;
            }
            return -1;
        }

        public static int[] RandomArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(min, max + 1);
            }
            return arr;
        }

        public static void Main()
        {
            int[] arr = RandomArray(50, 1, 200);
            Random rand = new Random();

            Console.WriteLine("generated array is");
            Console.WriteLine(string.Join(",", arr));

            //linear search
            int search = arr[rand.Next(arr.Length)];
            Console.WriteLine("search element is : " + search);

            Stopwatch swlinear = Stopwatch.StartNew();
            int linear = LinearSearch(arr, search, out int linearComparisions);
            swlinear.Stop();

            Console.WriteLine("\nLINEAR SEARCH");
            if (linear != -1)
                Console.WriteLine($"array element {search} found at position : {linear}");
            else
                Console.WriteLine("array element not found");

             Console.WriteLine($"comparisions : {linearComparisions}");
            Console.WriteLine($"Time : {swlinear.ElapsedTicks} ticks ({swlinear.Elapsed.TotalMilliseconds} ms)");


            //binary search

            int[] arr1 = RandomArray(50, 1, 200);
            Random rand1 = new Random();

            Console.WriteLine("\ngenerated array is");
            Console.WriteLine(string.Join(",", arr1));
            int search1 = arr1[rand1.Next(arr1.Length)];
            Console.WriteLine("search element is : " + search1);
            Stopwatch swbinary = Stopwatch.StartNew();
            int binary = BinarySearch(arr1, search1, out int binaryComparisions);
            swbinary.Stop();

            Console.WriteLine("BINARY SEARCH");
            if (binary != -1)
                Console.WriteLine($"array element {search1} found at position : {binary}");
            else
                Console.WriteLine("array element not found");

            Console.WriteLine($"comparisions : {binaryComparisions}");
            Console.WriteLine($"Time : {swbinary.ElapsedTicks} ticks ({swbinary.Elapsed.TotalMilliseconds} ms)");

        }
    }
}

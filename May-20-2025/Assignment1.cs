using System;
using System.Diagnostics;

namespace ConsoleApp5
{ 
    class SortingAlgorithms
    {
        public static int[] BubbleSort(int[] arr)
        {
            for(int i=0; i<arr.Length-1; i++)
            {
                for(int j=0; j<arr.Length-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j ] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            for(int i=0; i<arr.Length-1; i++)
            {
                int min = i;
                for(int j = min+1; j<arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;

            }
            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for(int i=1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j >=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        public static int[] RandomArray(int size,int min , int max)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for(int i =0; i<size; i++)
            {
                arr[i] = rand.Next(min, max + 1);
            }
            return arr;
        }
        public static void PrintArray(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        class Program
        {
            public static void Main(string[] args)
            {
                int[] arr =  RandomArray(20, 1, 100);
                Console.WriteLine("BUBBLE SORT:");
                Console.WriteLine("befor sorting array :");
                PrintArray(arr);
                Console.WriteLine("after sorting array :");
                int[] bubbleresult = BubbleSort(arr);
                PrintArray(bubbleresult);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                BubbleSort(arr);
                sw.Stop();
                Console.WriteLine("Time taken: " + sw.Elapsed.TotalMilliseconds + " ms");


                int[] arr1 = RandomArray(20, 1, 100);
                Console.WriteLine("\nSELECTION SORT:");
                Console.WriteLine("befor sorting array :");
                PrintArray(arr1);
                Console.WriteLine("after sorting array :");
                int[] selectionresult = SelectionSort(arr1);
                PrintArray(selectionresult);
                Stopwatch sw1 = new Stopwatch();
                sw1.Start();
                SelectionSort(arr);
                sw1.Stop();
                Console.WriteLine("Time taken: " + sw1.Elapsed.TotalMilliseconds + " ms");


                int[] arr2 = RandomArray(20, 1, 100);
                Console.WriteLine("\nINSERTION SORT:");
                Console.WriteLine("befor sorting array :");
                PrintArray(arr2);
                Console.WriteLine("after sorting array :");
                int[] insertionres = InsertionSort(arr2);
                PrintArray(insertionres);
                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                InsertionSort(arr);
                sw2.Stop();
                Console.WriteLine("Time taken: " + sw2.Elapsed.TotalMilliseconds + " ms");

                /*insertion sort is efficient for small or nearly sorted arrays
                 * selection sort is consistent but less efficient due to constant comparisions
                 * bubble sort is generally the leat efficient of three */


            }
        }
    }
}

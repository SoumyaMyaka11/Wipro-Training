using System;

public class Methods
{
   static void printArray(int[] arr)
   {
       for(int i=arr.Length-1; i>=0; i--)
       {
           Console.WriteLine($"Element {i+1}: {arr[i]}");
       }
   }
   
   static void Main()
   {
       int[] arr = {10,20,30,40,50};
       printArray(arr);

   }
   
}
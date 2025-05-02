using System;

public class Program
{
   static int[] Bubblesort(int[] a)
   {
       for(int x=0; x<a.Length-1; x++)
       {
           for(int y=0; y<a.Length-1; y++)
           {
               if(a[y]>a[y+1])
               {
                   int temp = a[y];
                   a[y] = a[y+1];
                   a[y+1] = temp;
               }
           }
       }
       return a;
   }
   
   
   static void Main()
   {
       int[] arr = {50, 10,30, 20,40,60,70};
       
       Console.WriteLine("array before bubble sort");
       for (int i=0; i<arr.Length; i++)
           Console.Write(arr[i]+" ");
          
        Console.WriteLine(); 
        int[] res  = Bubblesort(arr);   
        Console.WriteLine("array after bubble sort");
        for (int j=0; j<res.Length; j++)
           Console.Write(res[j]+" ");
       
   }
}
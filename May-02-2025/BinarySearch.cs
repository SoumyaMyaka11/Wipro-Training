using System;

public class Program
{
   static int[] sort(int[] a)
   {
       for(int x=0; x<a.Length-1; x++)
       {
           for(int y=x+1; y<a.Length; y++)
           {
               if(a[x]>a[y])
               {
                   int temp = a[x];
                   a[x] = a[y];
                   a[y] = temp;
               }
           }
       }
       return a;
   }
   static int BinarySearch(int[] arr , int target)
   {
       int left = 0;
       int right = arr.Length-1;
       while(left<=right)
       {
           int mid = (left+right)/2;
           if(target == arr[mid])
                return mid;
           else if(target < arr[mid])
               right = mid-1;
           else 
               left = mid+1;
       }
       return -1;
   }
   
   static void Main()
   {
       int[] arr = {50, 10,30, 20,40,60,70};
       int target = 40;
       int[] arr1 = sort(arr);
       int result = BinarySearch(arr1 , target);
       if(result!=-1)
           Console.WriteLine($"Element {target} found at index {result}");
       else
           Console.WriteLine($"Element {target} not found in array");
           
        
   }
}
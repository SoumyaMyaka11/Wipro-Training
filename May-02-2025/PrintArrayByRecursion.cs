using System;

public class Recursion
{
    static void PrintArray(int[] arr , int index)
    {
        if(index>arr.Length-1)
        {
            return;
        }
        else
        {
            Console.Write(arr[index]+" ");
             PrintArray(arr,index+1);
        }
    }
    
    static void Main()
    {
        int[] arr = {1,2,3,4,5};
        Console.WriteLine("array elements are:");
        PrintArray(arr,0);
    }
}

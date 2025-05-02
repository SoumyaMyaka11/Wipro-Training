 using System;

public class Recursion
{
    static int SumOfArray(int[] arr, int index,int sum)
    {
        if(index>arr.Length-1)
        {
            return sum;
        }
        else
        {
            sum  = sum + arr[index];
            return SumOfArray(arr, index+1, sum);
        }
    }
    
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6,7,8,9,10};
        Console.WriteLine($"Sum  of array by recursion is {SumOfArray(arr,0,0)}");
    }
}
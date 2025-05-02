using System;

public class Recursion
{
    static int Factorial(int[] arr, int index,int fact)
    {
        if(index<0)
        {
            return fact;
        }
        else
        {
            fact = fact*arr[index];
            return Factorial(arr, index-1, fact);
        }
    }
    
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6,7};
        int index = arr.Length-1;
        Console.WriteLine($"factorial of array is {Factorial(arr,index,1)}");
    }
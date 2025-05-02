using System;

public class PairSum
{
    static void FindPairsWithSum(int[] arr , int target)
    {
        for(int x=0; x<arr.Length; x++)
        {
            for(int y=x+1; y<arr.Length; y++)
            {
                if(arr[x] + arr[y] == target)
                    Console.WriteLine($"{arr[x]} + {arr[y]} = {target}" );
            }
        }
    }
    
    static void Main()
    {
        int[] arr = {2, 4, 3,5,7};
        int target = 7;
        FindPairsWithSum(arr, target);
    
    }
}
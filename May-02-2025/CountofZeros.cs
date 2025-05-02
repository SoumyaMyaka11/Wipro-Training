using System;

public class Recursion
{
    static int CountOfZeros(int num , int count)
    {
        if(num==0)
        {
            return count;
        }
        else
        {
            int rem = num%10;
            if(rem == 0)
                count++;
            return CountOfZeros(num/10, count);
        }
    }
    
    static void Main()
    {
        int num = 2004350510, temp = num;
        Console.WriteLine($"Number of zeros in {temp} is {CountOfZeros(num, 0)}");
    }
}

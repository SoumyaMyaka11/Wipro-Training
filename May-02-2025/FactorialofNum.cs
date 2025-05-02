using System;

public class Recursion
{
    static int Factorial(int num , int start,int fact)
    {
        if(start>num)
        {
            return fact;
        }
        else
        {
            fact = fact*start;
            return Factorial(num, start+1, fact);
        }
    }
    
    static void Main()
    {
        int num = 5;
        Console.WriteLine($"factorial of {num} is {Factorial(num,1,1)}");
    }
}
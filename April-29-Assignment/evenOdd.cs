using System;

public class EvenOdd
{
    static string evenOdd(int num)
    {
        if(num%2==0)
            return "EVEN";
        else
            return "ODD";
    }
   
    static void Main(string[] args)
    {
        int num = 10;
        Console.WriteLine(evenOdd(num));
        
        
    }
}
using System;

public class Grade
{
    public static void Main(string[] args)
    {
        for(int i=1; i<=10; i++)
        {
           int square = i*i;
            if(square>100)
                 break;
            Console.WriteLine("square of "+i+" is "+square);
                 
        }
    }
}
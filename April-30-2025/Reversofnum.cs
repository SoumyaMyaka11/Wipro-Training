using System;

public class Grade
{
    public static void Main(string[] args)
    {
        int num =123,temp = num,rev=0;
        while(num!=0)
        {
            int rem = num%10;
            rev = rev*10 + rem;
            num = num/10;
        }
        Console.WriteLine("reverse of "+temp+" is "+rev);
    }
}
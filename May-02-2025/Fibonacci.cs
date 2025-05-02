using System;

public class Recursion
{
    static int Fibonacci(int num,int a, int b,int c)
    {
        if(num<1)
        {
            return num;
        }
        else
        {
            Console.Write(a+" ");
            c = a+b;
            a=b;
            b=c;
            return Fibonacci(num-1,a, b,c);
        }
    }
    
    static void Main()
    {
        int num = 10;
        Fibonacci(num,0,1,0);
    }
}
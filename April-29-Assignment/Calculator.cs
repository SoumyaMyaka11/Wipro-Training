using System;

public class Calculate
{
    static int add(int num1, int num2)
    {
        return num1+num2;
    }
    static int sub(int num1, int num2)
    {
        return num1-num2;
    }
    static int mul(int num1, int num2)
    {
        return num1*num2;
    }
    static int div(int num1, int num2)
    {
        return num1/num2;
    }
    static void Main(string[] args)
    {
        int num1 = 20;
        int num2 = 10;
        Console.WriteLine("Addition: "+add(num1,num2));
        Console.WriteLine("Subtraction: "+sub(num1,num2));
        Console.WriteLine("Multiplicaataion: "+mul(num1, num2));
        Console.WriteLine("Division:"+div(num1,num2));
        
    }
}
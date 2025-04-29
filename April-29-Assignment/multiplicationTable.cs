using System;

public class MulTable
{
    static void tableMul(int num)
    {
        for(int start=1; start<=10; start++)
        {
            int fact =1;
            fact = num*start;
            Console.WriteLine(num+" x "+start+" = "+fact);
        }
    }
   
    static void Main(string[] args)
    {
        int num = 5;
        tableMul(num);
        
        
    }
}
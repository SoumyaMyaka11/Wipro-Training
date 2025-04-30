using System;

public class Grade
{
    public static void Main(string[] args)
    {
          int num = 123,temp=num;
          int sum = 0;
          while(num!=0)
          {
              int rem = num%10;
              sum+=rem;
              num= num/10;
          }
          Console.WriteLine("sum of digits of "+temp+" is "+sum);
    }
}
using System;

public class Grade
{
    public static void Main(string[] args)
    {
       int month=13;
       switch(month)
       {
           case 1:
               Console.WriteLine("JANUARY");
               break;
           case 2:
               Console.WriteLine("FEBRAUARY");
               break;
           case 3:
               Console.WriteLine("MARCH");
               break;
           case 4:
               Console.WriteLine("APRIL");
               break;
           case 5:
               Console.WriteLine("MAY");
               break;
           case 6:
               Console.WriteLine("JUNE");
               break;
           case 7:
               Console.WriteLine("JULY");
               break;
           case 8:
               Console.WriteLine("AUGUST");
               break;
           case 9:
               Console.WriteLine("SEPTEMBER");
               break;
           case 10:
               Console.WriteLine("OCTOBER");
               break;
           case 11:
               Console.WriteLine("NOVEMBER");
               break;
           case 12:
               Console.WriteLine("DECEMBER");
               break;
          default:
               Console.WriteLine("INVALID MONTH");
               break;
           
       }
    }
}
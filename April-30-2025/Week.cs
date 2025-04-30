using System;

public class Grade
{
    public static void Main(string[] args)
    {
       int day = 3;
      switch(day)
      {
          case 1:
               Console.WriteLine("MONDAY");
               break;
          case 2:
               Console.WriteLine("TUESDAY");
               break;
          case 3:
               Console.WriteLine("WEDNESDAY");
               break;
          case 4:
               Console.WriteLine("THURSAY");
               break;
          case 5:
               Console.WriteLine("FRIDAY");
               break;
          case 6:
               Console.WriteLine("SATURDAY");
               break;
          case 7:
               Console.WriteLine("SUNDAY");
               break;
          default:
               Console.WriteLine("INVALID INPUT");
               break;
                
      }
    }
}
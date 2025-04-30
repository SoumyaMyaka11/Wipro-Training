using System;

public class Methods
{
   static int linearSearch(int[] arr, int search)
   {
      int index = -1;
      for(int i=0; i<arr.Length; i++)
      {
          if(arr[i]==search)
          {
              index = i;
          }
      }
      return index;
   }
   
    static void Main()
    {
        int[] arr = {3,5,7,2,9,10};
        int search = 7;
        int result =linearSearch(arr, search);
        if(result!= -1)
            Console.WriteLine($"index of {search} is {result}");
        else
            Console.WriteLine("element not fount");
    }
   
}
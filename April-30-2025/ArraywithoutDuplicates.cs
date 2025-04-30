using System;
 
 public class FrequencyOfEle
 {
     static void arrayFrequency(int[] arr)
     {
         int[] b = new int[arr.Length];
         for(int x=0; x<arr.Length; x++)
         {  
            int count =1;
            if(b[x]==1)
               continue;
            for(int y=x+1; y<arr.Length; y++)
            {
                if(arr[x]==arr[y])
                {
                    count++;
                    b[y]=1;
                }
            }
            if(count==1 || count >1)
               Console.Write(arr[x]+" ");
         }
        
     }
     static void Main()
     {
         int[] arr = {1,2,3,2,4,1};
         arrayFrequency(arr);
     }
 }
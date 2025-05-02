using System;

public class Program
{
    static string Palindrome(string input1)
    {
        char[] c = input1.ToCharArray();
        string rev ="";
        for(int x=0; x<c.Length; x++)
        {
            rev =  c[x] + rev;
        }
        return rev;
    }
    
    static void Main()
    {
        string input = "madam";
        string input1 = input.ToLower();
        string res = Palindrome(input1);
        if(res==input1)
            Console.WriteLine($"{input} is palindrome");
        else
            Console.WriteLine($"{input} is not palindrome");
    }
}
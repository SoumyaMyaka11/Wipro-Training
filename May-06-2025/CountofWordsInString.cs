class Program
{
    public static void Main(string[] args)
    {
        string str = "Learning c# is fun";
        Console.WriteLine($"number of words in {str} is {CountWordOfString(str)}");
    }

    static int CountWordOfString(string str)
    {
        string[] str1 = str.Split(" ");
        return str1.Length;
    }
}
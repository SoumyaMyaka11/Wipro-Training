class Program
{
    public static void Main(string[] args)
    {

        string str = "learning c# is really interesting";
        Console.WriteLine(MaxLenOfWordInString(str));
    }

    static string MaxLenOfWordInString(string str)
    {
        string[] str1 = str.Split(" ");
        int max_length = 0;
        string result = "";
        for (int x=0; x<str1.Length; x++)
        {
            if (str1[x].Length > max_length)
            {
                max_length = str1[x].Length;
                result = result + str1[x];
            }
            else if (str1[x].Length >= max_length)
            {
                result = result + " " +str1[x] ;
            }
        }
        return result;
    }
}
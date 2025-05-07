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
        foreach (String str2 in str1)
        {
            int length = str2.Length;
            if(length >= max_length)
            {
                if(length > max_length)
                {
                    max_length = length;
                    result = str2;

                }
                else if(length >= max_length)
                {
                    max_length = length;
                    result = result + " " + str2;
                }
            }
        }
        return result;
    }

    

    
}

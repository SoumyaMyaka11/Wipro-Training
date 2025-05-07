class Program
{
    public static void Main(string[] args)
    {

        string str = "this is a test and this test is fun";
          DuplicatesInString(str);
    }

    static void DuplicatesInString(string str)
    {
        str = str.ToLower();
        string[] str1 = str.Split(" ");
        string res = "";
        for(int x=0; x<str1.Length; x++)
        {
            if (str.IndexOf(str1[x]) != str.LastIndexOf(str1[x]))
            {
                if (res.IndexOf(str1[x]) == -1)
                {
                    res = res + str1[x] + " ";
                }
            }
        }
        if (res !="")
            Console.WriteLine(res);
        else
            Console.WriteLine("There are no duplicates in the given string");
        
    }
}
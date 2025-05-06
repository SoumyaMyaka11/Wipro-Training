class Program
{
    public static void Main(string[] args)
    {
        int rows = 4;
        PrintPattern(rows);
    }

    static void PrintPattern(int rows)
    {
       for(int i=1; i<=rows; i++)
       {
            for(int j=1; j<=i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();

       }
    }
}
class Program
{
    public static void Main(string[] args)
    {

        int[] arr = { 1,2,3,2,4,3,4,4};
        ArrayEleFrequency(arr);
    }

    static void ArrayEleFrequency(int[] arr)
    {
        int[] b = new int[arr.Length];
        for(int x=0; x<arr.Length; x++)
        {
            int count = 1;
            if (b[x] == 1)
                continue;
            for(int y=0; y<arr.Length; y++)
            {
                if (arr[x] == arr[y])
                {
                    count++;
                    b[y] = 1;
                }
            }
            Console.WriteLine($"{arr[x]} occurs {count} times");
        }
    }

    
}

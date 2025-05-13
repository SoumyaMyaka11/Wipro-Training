using System;

namespace Linq_Project
{
    class SimpleDelegate
    {

        public delegate int SomeOperation(int i, int j);

        class Program
        {
            static int Sum(int x, int y)
            {
                return x + y;
            }

            static void Main()
            {
                SomeOperation Add;

                Add = Sum;

                int res = Add(4, 3);
                Console.WriteLine(res);

                //another /latest way to represent a delegate
                Func<int, int, int> Add = Sum;

                int res = Add(15, 10);
                Console.WriteLine(res);     
            }
        }
    }
}


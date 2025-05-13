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
            }
        }
    }
}


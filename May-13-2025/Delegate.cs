using System;

namespace Linq_Project
{

    delegate void CustomDel(string s);
    class TestClass
    {
        //define two methods that have same signature as CustomDel
        static void Hello(string s)
        {
            Console.WriteLine($"Hello, {s}");
        }

        static void GoodBye(string s)
        {
            Console.WriteLine($"Hello , {s}");
        }


        static void Main()
        {
            //create an instance of custom delegate
            CustomDel hiDel, byeDel, multiDel, multiMinusDel;

            hiDel = Hello;

            byeDel = GoodBye;

            multiDel = hiDel + byeDel;

             multiMinusDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel");
            hiDel("A");

            Console.WriteLine("Invoking delegate byeDel");
            byeDel("B");

            Console.WriteLine("Invoking delegate multiDel");
            multiDel("C");

            Console.WriteLine("Invoking delgate multiMinusDel");
            multiMinusDel("D");
        }
    }
}

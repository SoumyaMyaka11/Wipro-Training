using System;

namespace ConsoleApp5
{
    class Algorithm
    {
        //recurssive method to solve tower of hanoi
        public static void TowerOfHanoi(int n, char from, char to,char aux)
        {
            if(n == 1)
            {
                Console.WriteLine($"Move disk 1 from {from} to {to}");
                return;
            }

            //if n>1 then move top n-1 disks from source to auxiliary
            TowerOfHanoi(n - 1, from, aux, to);

            //move nth or last disk from source to destination
            Console.WriteLine($"Move disk {n} from {from} to {to}");

            //move n-1 disks from auxiliary to destination
            TowerOfHanoi(n - 1, aux, to, from);

        }

        public static void Main()
        {
            Console.WriteLine("Enter number of disks:");
            int n = Convert.ToInt32(Console.ReadLine());

            //method call with rods A(source), C(destination), B(auxiliary)
            TowerOfHanoi(n, 'A', 'C', 'B');
        }
    }
}

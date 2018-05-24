using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the number of disk on rod A.");
            var numStacks = Console.ReadLine();

            var n = Convert.ToInt32(numStacks);

            Tower(n, 'A', 'C', 'B');
            //Console.WriteLine("Enter the number of Disk.");
        }

        //method?
        static void Tower(int n, char A_rod, char C_rod, char B_rod)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk " + n + " from rod " + A_rod + " to rod " + C_rod);
                return;
            }
            Tower(n-1, A_rod, B_rod, C_rod);
            Console.WriteLine("Move disk " + n + " from rod " + A_rod + " to rod " + C_rod);
            Tower(n-1, B_rod, C_rod, A_rod);
        }

    }

    
}//End of TowersOfHanoi

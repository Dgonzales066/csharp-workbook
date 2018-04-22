using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            //Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            //hand1 = "rock";
            //if (hand2 == "scissors")
            //{
            //    Console.WriteLine("Hand One Wins!");
            //}
            //else if (hand2 == "paper")
            //{
            //    Console.WriteLine("Hand Two Wins!");
            //}
            switch (hand1 == "rock")
            {
            case (hand2 = "scissors")
                return ("Hand One Wins!");
            }



            return hand1 + " " + hand2;
        }
    }
}

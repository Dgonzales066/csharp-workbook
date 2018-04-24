using System;

namespace RockPaperScissors
{
    class Program
    {
        
        public static void Main()
        {
            bool keepPlaying = true;
            while(keepPlaying)
            {
                Console.WriteLine();
                Console.WriteLine("Choose between rock, paper, or scissors.");
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
                Console.WriteLine("Enter hand 2:");
                string hand2 = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine(CompareHands(hand1, hand2));

                Console.WriteLine("New game? [yes or no]");
                string answer = "";
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    keepPlaying = true;
                }
                else
                {
                    keepPlaying = false;
                }
            }
            // leave this command at the end so your program does not close automatically
            //Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            string playerOne = hand1;
            string playerTwo = hand2;

            if (playerOne == "rock")
            {
                if (playerTwo == "rock")
                {
                    Console.WriteLine("It's a tie.");
                }
                else if (playerTwo == "paper")
                {
                    Console.WriteLine("Hand One - You lose.");
                }
                else 
                {
                    Console.WriteLine("Hand One - You win!");
                }
            }
            else if (playerOne == "paper")
            {
                if (playerTwo == "rock")
                {
                    Console.WriteLine("Hand One - You win!");
                }
                else if (playerTwo == "paper")
                {
                    Console.WriteLine("It's a tie");
                }
                else 
                {
                    Console.WriteLine("Hand One - You lose.");
                }
            }
            else //(playerOne == "scissors")
            {
                if (playerTwo == "rock")
                {
                    Console.WriteLine("Hand One - You lose.");
                }
                else if (playerTwo == "paper")
                {
                    Console.WriteLine("Hand One - You win.");
                }
                else 
                {
                    Console.WriteLine("It's a tie.");
                }
            }
            return playerOne + " vs. " + playerTwo;

            // string playerOne = "rock";

            // switch (playerOne)
            // {
            //     case "rock":
            //         Console.WriteLine("Its a tie.");
            //         break;

            //     case "paper":
            //         Console.WriteLine("You lose");
            //         break;

            //     default :
            //         Console.WriteLine("You win");
            //         break;
            // }

            // // string playerOne = "";
            // // string playerTwo = (playerOne == "rock") ? "its a tie." : "you lose.";
            // // Console.WriteLine("Player One {0}", playerOne);
            // //playerOne = (playerTwo == "paper") ? "you lose." : "you win." ;
            // //hand1 = (hand2 == "scissors") ? "you win";
            
            // //hand1 = "rock";
            // //if (hand2 == "scissors")
            // //{
            // //    Console.WriteLine("Hand One Wins!");
            // //}
            // //else if (hand2 == "paper")
            // //{
            // //    Console.WriteLine("Hand Two Wins!");
            // //}
            // // switch (hand1 == "rock")
            // // {
            // // case (hand2 = "scissors")
            // //     return ("Hand One Wins!");
            // // }

            // //return playerOne + " " + playerTwo;
            //return " ";
        }
    }
}

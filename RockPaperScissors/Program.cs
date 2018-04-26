using System;

namespace RockPaperScissors
{
    class Program
    {
        public static int playerOneScore = 0;

        public static int playerTwoScore = 0;
        
        public static void Main()
        {
            //bool keepPlaying = true;
            //while(keepPlaying)
            while(playerOneScore < 3 && playerTwoScore < 3)
            {
                Console.WriteLine();
                Console.WriteLine("It's time to play rock, paper, or scissors.");
                Console.WriteLine("The best two out of three wins!");
                Console.WriteLine("Enter hand Player One:");
                string hand1 = Console.ReadLine().ToLower();
                Console.WriteLine("Enter hand Player Two:");
                string hand2 = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine(CompareHands(hand1, hand2));
                Console.WriteLine("Player one has {0} points and Player Two has {1} points", playerOneScore, playerTwoScore);

                // Console.WriteLine("Player One has" + (Points(hand1)) + "points");
                // Console.WriteLine("Player Two has" + (Points(hand2)) + "points");

                

                // Console.WriteLine("New game? [yes or no]");
                // string answer = "";
                // answer = Console.ReadLine();
                // if (answer == "yes")
                // {
                //     keepPlaying = true;
                // }
                // else
                // {
                //     keepPlaying = false;
                // }
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
                    return "It's a tie.";
                }
                else if (playerTwo == "paper")
                {
                    playerTwoScore++;
                    return "Hand Two Wins";
                }
                else if (playerTwo == "scissors")
                {
                    playerOneScore++;
                    return "Hand One Wins!";
                }
                else
                {
                    return "You must choose rock, paper, or scissors. No winner.";
                }
            }
            else if (playerOne == "paper")
            {
                if (playerTwo == "rock")
                {
                    playerOneScore++;
                    return "Hand One Wins!";
                }
                else if (playerTwo == "paper")
                {
                    return "It's a tie";
                }
                else if (playerTwo == "scissors")
                {
                    playerTwoScore++;
                    return "Hand Two Wins.";
                }
                else
                {
                    return "You must choose rock, paper, or scissors. No winner.";
                }
            }
            else //(playerOne == "scissors")
            {
                if (playerTwo == "rock")
                {
                    playerTwoScore++;
                    return "Hand Two Wins.";
                }
                else if (playerTwo == "paper")
                {
                    playerOneScore++;
                    return "Hand One Wins.";
                }
                else if (playerTwo == "scissors")
                {
                    return "It's a tie.";
                }
                else
                {
                    return "You must choose rock, paper, or scissors.";
                }

            }
            // return playerOne + " vs. " + playerTwo;

        }

        // public static string Points(int playerOne, int playerTwo)
        // {

        //     int firstPlayer = 0;
        //     int secondPlayer = 0;

        //     if (playerOne > playerTwo)
        //     {
        //         firstPlayer++;
        //     }
        //     else
        //     {
        //         secondPlayer++;
        //     }
        //     return "Player One has" + (firstPlayer) + "points and Player Two has" + (secondPlayer);
        // }
    }
}
 
using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    number++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are " + (number.ToString()) + " numbers divisible by 3 in a string of 100 numbers.");

            Console.WriteLine();
            Console.WriteLine("Enter a number to calculate the sum of all previous numbers before the number you entered or type ok to exit.");
            int numEntered = int.Parse(Console.ReadLine());

            int firstNumber = 1;
            int answer = 0;

            for (int i=firstNumber; i <= numEntered; i++)
            {
                answer += i;
            }
            Console.WriteLine();
            Console.WriteLine("The answer is " + (answer));
            Console.WriteLine();

            Console.WriteLine("Let's multiply numbers together.");
            Console.WriteLine("Enter a number and we will multiply it by all it's previous numbers.");
            int numMultiply = int.Parse(Console.ReadLine());

            //int firstNum = 1;
            int finalAnswer = 1;

            for (int i = 1; i <= numMultiply; i++)
            {
                finalAnswer *= i;
            }
            Console.WriteLine();
            Console.WriteLine((numMultiply.ToString()) + "! = " + (finalAnswer));
            Console.WriteLine();

            Console.WriteLine("Ok, lets see if you're a good guesser.");
            Console.WriteLine("I'm thinking of a number between one and ten.");
            Console.WriteLine("I'll give you three chances to guess what I'm thinking.");
            Console.WriteLine();

            Random rnd = new Random();
            int numThink = rnd.Next(1, 11);
            //Console.WriteLine(numThink);

            int guessNumber = 0;

            while (guessNumber != numThink)
            {
                for (int i = 1; i < 4; i++)
                {
                    guessNumber = int.Parse(Console.ReadLine());

                    if (guessNumber != numThink)
                    {
                        Console.WriteLine("That was guess number {0}.", (i));
                    }
                    else if (guessNumber == numThink)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good guess!! You win!");
                        Console.WriteLine();
                        return;
                    } 
                }
                Console.WriteLine();
                Console.WriteLine("You Lose!!! The correct answer was {0}.", (numThink));
                Console.WriteLine();
                return;
            }


            // for (int i = 1; i < 4; i++)
            // {
            //     Guess = int.Parse(Console.ReadLine());

            //     if (Guess != numThink)
            //     {
            //         Console.WriteLine("Guess again.");
            //     }
            //     else if (Guess == numThink)
            //     {
            //         Console.WriteLine("you won");
            //     }
            //     else
            //     {
            //         Console.WriteLine("You lose.");
            //     }
            // }

        }

    }
}

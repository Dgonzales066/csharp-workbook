using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 - Checkpoint 1 /////////////////////////////
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


            //Part 2 - Checkpoint 1 /////////////////////////////
            Console.WriteLine("Enter a number and keep entering numbers to calculate all entered numbers together.");
            Console.WriteLine("Type 'ok' to get the answer.");

            var answer = 0;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a number.");
                var numEntered = Console.ReadLine();

                if (numEntered == "ok")
                    break;
                
                var givenNum = Convert.ToInt32(numEntered);

                answer += givenNum;
            }

            Console.WriteLine();
            Console.WriteLine("The answer is " + (answer));
            Console.WriteLine();


            //Part 3 - Checkpoint 1 /////////////////////////////
            Console.WriteLine("Ok, let's multiply numbers together.");
            Console.WriteLine("Enter a number and we will multiply it by all it's previous numbers.");
            int numMultiply = int.Parse(Console.ReadLine());

            int finalAnswer = 1;

            for (int i = 1; i <= numMultiply; i++)
            {
                finalAnswer *= i;
            }
            Console.WriteLine();
            Console.WriteLine((numMultiply.ToString()) + "! = " + (finalAnswer));
            Console.WriteLine();


            //Part 4 - Checkpoint 1 /////////////////////////////
            Console.WriteLine("Ok, lets see if you're a good guesser.");
            Console.WriteLine("I'm thinking of a number between one and ten.");
            Console.WriteLine("I'll give you three chances to guess what I'm thinking.");
            Console.WriteLine("Please enter a number.");
            Console.WriteLine();
            var numThink = GenerateRandomNum();
            //Console.WriteLine(numThink);
            TryToGuess(numThink);


            //Part 5 - Checkpoint 1 /////////////////////////////
            Console.WriteLine("Ok now let me guess the highest numer you can write.");
            Console.WriteLine("Write a series of numbers separating each number by a comma.");
            Console.WriteLine("For example: 1, 2, 3");
            Console.WriteLine("I'll guess the largest number you write.");
            Console.WriteLine();

            var input = Console.ReadLine();
            var numbersEnter = SeriesOfNumbers(input);
            var maxValue = numbersEnter.Max();

            Console.WriteLine("The largest number is: " + maxValue);
            Console.WriteLine();
            
        }

        private static int GenerateRandomNum()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }

        private static void TryToGuess(int numThink)
        {
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
        }

        private static IEnumerable<int> SeriesOfNumbers(string input)
        {
            return input?.Split(',').Select(numbersEnter => Convert.ToInt32(numbersEnter.Trim())).ToList();
        }

    }
}

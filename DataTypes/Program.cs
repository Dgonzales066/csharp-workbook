using System;
using System.Threading;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Thread.Sleep (1000);
            Console.WriteLine("Let's play: Choose your own adventure.");
            Console.WriteLine("Today's adventure is:  The Thing in the Dark");

            Thread.Sleep (4000);
            
            //int playerOne = 3;
            
            Console.WriteLine();
            Console.WriteLine("You enter a subterrean passage out of curiosity. It's very dark and you can only make out a small stick on the floor.");
            Console.WriteLine();
            Console.WriteLine("Do you take it? [yes or no]: ");
                        
            string stick = "";
            
            stick = Console.ReadLine();		
            
            if (stick == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("You now have a stick with you. Long and pointy you figure it will help you on your adventure.");
            }
            else if (stick == "no")
            {
                Console.WriteLine();
                Console.WriteLine("You continue to walk in the dark until you reach an opening.");
            }

            Thread.Sleep (6000);
            Console.WriteLine();		
            Console.WriteLine("As you continue forward you enter a large cavern and make out a glowing object in the center of the room.");
            Console.WriteLine();
            Thread.Sleep (5000);
            Console.WriteLine("Do you approach the glowing object? [yes or no]: ");

            string approach = "";

            approach = Console.ReadLine();

            if (approach == "yes")
            {
                Console.WriteLine();
                Thread.Sleep (4000);
                Console.WriteLine("As you move closer you see that the glowing object is an enourmous eye.");
                Console.WriteLine();
                Thread.Sleep (5000);
                Console.WriteLine("The eye belongs to gigantic spider!");
            }
            else if (approach == "no")
            {
                Console.WriteLine();
                Console.WriteLine("Nervously you slowly back away from the glowing object but knock over a stone causing a loud noise.");
                Console.WriteLine();
                Thread.Sleep (3000);
                Console.WriteLine("The glowing object turns to you! You realize you're staring into the eye of a gigantic spider!");
            }

            Console.WriteLine();
            Thread.Sleep (5000);
            Console.WriteLine("The spider lunges at you! What do you do? [run or fight]");
			
				
            string doing = "";

            doing = Console.ReadLine();

            if (doing == "fight")
            {
                Random r = new Random();
                int number = r.Next(1, 10);

                //System.Console.WriteLine(number);
                //Console.ReadKey();

                if (number < 4)
                {
                    Console.WriteLine("You died. THE END.");
                    Console.WriteLine();
                }
                else if (number == 5)
                    Console.WriteLine("You hit it but your strike is weak and the spider kills you. THE END");
                else if (number == 6)
                    Console.WriteLine("You hit it with the stick but it's only a stick and the spider becomes angry. It leaps forward and kills you. THE END.");
                else if (number == 7)
                    Console.WriteLine("You hit it as hard as you could but its a giant spider and you only have a stick. The spider jumps on top of you and kills you. THE END.");
                else if (number == 8)
                    Console.WriteLine("You hit it and do just enough damage that the spider runs away in terror.");
                else 
                    Console.WriteLine("You've killed it.");
                    Console.WriteLine();
            }
            else if (doing == "run")
            {
                Console.WriteLine();
                Console.WriteLine("The spider sees you and jumps on your back. You feel its fangs sink deep into you as you slowly die.");
                Console.WriteLine();
                Console.WriteLine("The End!");
                Console.WriteLine();
            }
            




        }
    }
}

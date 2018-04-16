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

            Thread.Sleep (3000);
            
            //int playerOne = 3;
            
            Console.WriteLine();
            Console.WriteLine("You enter a subterrean passage out of curiosity. It's very dark but you think you see a light just ahead of you in the tunnel.");
            Thread.Sleep (5000);
            Console.WriteLine();
            Console.WriteLine("You steady yourself and with walking stick in hand, you go further into the passage.");
            Thread.Sleep (5000);
            Console.WriteLine();
            Console.WriteLine("As you make your way down your foot kicks a small metal sign which reads: Turn Around. Only Death awaits you in the dark.");
            Thread.Sleep (6000);
            Console.WriteLine();
            Console.WriteLine("Do you want to proceed? [yes or no]: ");
                        
            string proceed = "";
            
            proceed = Console.ReadLine();		
            
            if (proceed == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("You continue to walk in the dark until you reach an opening.");
            }
            else if (proceed == "no")
            {
                Console.WriteLine();
                Console.WriteLine("You realize: What the hell am I doing?! I have cable TV and cold beers at home — forget this shit! I am outta here. THE END.");
                Environment.Exit(0);
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
                    Console.WriteLine("You died cause it's a giant spider and you're food. THE END.");
                    Environment.Exit(0);
                    Console.WriteLine();
                }
                //else if (number == 5)
                //{
                //    Console.WriteLine("You hit the spider but your strike is weak so the spider kills you. THE END");
                //    Environment.Exit(0);
                //}
                //else if (number == 6)
                //{
                //    Console.WriteLine("You hit it with the stick but it's only a stick —what were you thinking?! The spider leaps forward and kills you. THE END.");
                //    Environment.Exit(0);
                //}
                //else if (number == 7)
                //{
                //    Console.WriteLine("You swing as hard as you can but it's a giant spider and easily avoids your clumsy attack. The spider jumps on top of you and kills you. THE END.");
                //    Environment.Exit(0);
                //}
                else 
                    Console.WriteLine("You've kill it. Who's the man?? U da man!!");
                    Console.WriteLine();
            }
            else if (doing == "run")
            {
                Console.WriteLine();
                Thread.Sleep (3000);
                Console.WriteLine("The spider sees you and jumps on your back. You feel its fangs sink deep into you as you slowly die.");
                Thread.Sleep (2000);
                Console.WriteLine();
                Console.WriteLine("The End!");
                Console.WriteLine();
                Environment.Exit(0);
            }

            Thread.Sleep (4000);
            Console.WriteLine("You stand triumphanty over the dead spider. Ha! I am a bad ass! you tell yourself.");
            Console.WriteLine();
            Thread.Sleep (3000);
            Console.WriteLine("But you soon realize the gigantic spider had thousands of baby spiders and it was trying to feed them with your corpse.");
            Console.WriteLine();
            Thread.Sleep (4000);
            Console.WriteLine("Thousand of baby spiders begin moving towards you. What do you do? [run or fight]");

            string doing2 = "";

            doing2 = Console.ReadLine();

            if (doing2 == "run")
            {
                Console.WriteLine();
                Console.WriteLine("You're smart! There's too many and by running as fast as you can you make it up the passage and avoid a certain death.");
                Console.WriteLine();
                Thread.Sleep (2000);
                Console.WriteLine("THE END.");
            }
            else if (doing2 == "fight")
            {
                Console.WriteLine();
                Thread.Sleep (3000);
                Console.WriteLine("Bad move, my friend! The millions of spiders overwhelm you and you are forever mummified in their lair");
                Console.WriteLine("feeding the next generation of souless monsters who are waiting for someone else not to run when given a choice.");
                Thread.Sleep (2000);
                Console.WriteLine("THE END");

            }


            




        }
    }
}

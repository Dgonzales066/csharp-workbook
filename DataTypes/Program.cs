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
                Console.WriteLine("You now have a stick with you. Long and pointy you figure it will help you if you get into a fight.");
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
            Thread.Sleep (2000);
            Console.WriteLine("Do you approach the glowing object?");

            string approach = "";

            approach = Console.ReadLine();

            if (approach == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("As you move closer you see that the glowing object is an enourmous eye.");
                Console.WriteLine();
                Thread.Sleep (5000);
                Console.WriteLine("The eye belongs to gigantic spider!");
            }
            else if (approach == "no")
            {
                Console.WriteLine();
                Console.WriteLine("Nervously you slowly back away from the glowing object but knock over a stone causing a loud noise.");
                Thread.Sleep (3000);
                Console.WriteLine("The glowing object turns to you! You realize you're staring into the eyes of a gigantic spider!");
            }
			
				
            
            




        }
    }
}

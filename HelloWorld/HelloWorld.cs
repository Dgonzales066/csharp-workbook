using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, David!");

            string name = "";
            int age = 0;
            int year = 0;
            string movie = "";
            string school = "";
            int yeartwo = 0;
            string secret = "";
            
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please tell me the name of your favorite movie.");
            movie = Console.ReadLine();
            Console.WriteLine("Tell me the name of your high school.");
            school = Console.ReadLine();
            Console.WriteLine("What year did you graduate?");
            yeartwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me a secret.");
            secret = Console.ReadLine();
            
            Console.WriteLine("Hello! My name is {0} and I am {1} years old. I was born in {2}. My favorite movie is {3}. I went to {4} and graduated in {5}. {6}.", name, age, year-age, movie, school, yeartwo, secret);
        }
    }
}

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {   
                if (i % 15 == 0)//numbers divisible by 3 and 5 (or 15) print FizzBuzz
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)//number divisible by 3 print Fizz
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)//number divisible by 5 pirnt Buzz
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);//number not divisible by either 3 or 5
                }
            }
        }
    }
}

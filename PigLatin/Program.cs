using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here

            // leave this command at the end so your program does not close automatically

            Console.WriteLine("Lets write in Pig Latin.");
            Console.WriteLine("Enter a word or a sentence.");

            string firstWord = "";


            {
            firstWord = Console.ReadLine();
            
            int vowelIndex = firstWord.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

            string firstLetter = firstWord.Substring(0, 1);
            string newWord = firstWord.Substring(1);
            string pigLatin = newWord + firstLetter + "ay";
            Console.WriteLine(pigLatin);

            }
             
        }//End Main Function
        
    }//End Class Program

}//End Name Space

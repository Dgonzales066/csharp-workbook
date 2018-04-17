using System;

namespace PigLatin
{
    class Program
    {
        public static void Main(string [] args)
        {
            
            Console.WriteLine("Lets write in Pig Latin.");
            Console.WriteLine("Enter a word.");

            bool bkTop = true;    

            while(bkTop)
            {
            string firstWord = "";
            
            firstWord = Console.ReadLine();
            
            string firstLetter = firstWord.Substring(0, 1);
            string newWord = firstWord.Substring(1);
            string pigLatin = newWord + "ay" + firstLetter;
            Console.WriteLine(pigLatin);

            }
             
            bkTop = false;

        }//End Main Function
        
    }//End Class Program

}//End Name Space

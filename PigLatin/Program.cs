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
            Console.WriteLine();
            string enterWords = Console.ReadLine();
            Console.WriteLine(TranslateWord(enterWords));
        }

        public static string TranslateWord(string firstWord)
        {
            int firstVowelIndex = firstWord.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

            string firstLetter = firstWord.Substring(0, firstVowelIndex);
            string newWord = firstWord.Substring(firstVowelIndex);
            return newWord + firstLetter + "ay";
        }

        
    }

}

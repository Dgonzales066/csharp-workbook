﻿using System;

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
            Console.WriteLine("");//blank space
            string enterWords = Console.ReadLine();
            Console.WriteLine(LowerCaseWords (TranslateWord(enterWords)));
            Console.WriteLine("");//blank Space
        }

        public static string TranslateWord(string firstWord)
        {
            int firstVowelIndex = firstWord.IndexOfAny(new char[] {'A', 'E', 'I', 'O', 'U','a', 'e', 'i', 'o', 'u'});

            string firstLetter = firstWord.Substring(0, firstVowelIndex);
            string newWords = firstWord.Substring(firstVowelIndex);

            if (firstVowelIndex == 0)
            {
                return newWords + "yay";
            }
            else
            {
                return newWords + firstLetter + "ay";
            }

        }

        public static string LowerCaseWords(string newWords)
        {
            return newWords.ToLower();
        }

        //return newWords + firstLetter + "ay";
        //return firstWord.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

        
    }

}

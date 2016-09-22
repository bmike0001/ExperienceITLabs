using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Piglatin
{
    class Program
    {
        const string extension = "ay";
        static void Main(string[] args)
        {
            Console.WriteLine("Time to play Pig Latin - input a word");



            string translation = "";
            string input = Console.ReadLine();
            string[] tempInput = input.Split(' ');

            for (int i = 0; i < tempInput.Length; i++)
            {
                translation += getPigLatin(tempInput[i]);
            }
            Console.WriteLine(translation);
        }
        private static string getPigLatin(string input)
        {
            string piglatin = "";
            string word = "";
            string firstLetter = "";
            if (input.Length >1 )
            {

                firstLetter = input.Substring(0, 1);
                word = input.Substring(1);


                if (!isVowel(firstLetter))
                {
                    piglatin = word + firstLetter + "ay";
                }
                else {
                    piglatin = input + "way";
                }
            }
            return piglatin;

            Console.WriteLine("Translate another line? (y/n)");
            Console.ReadLine();
        }

        private static bool isVowel(string test)
        {
            test = test.ToLower();
            if (test == "a" || test == "e" || test == "i" || test == "o" || test == "u")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 1};
            List<string> wordList = new List<string> { "ham", "corn", "windy", "california", "it", "a", "crams" };

            Console.WriteLine("Enter a word length: ");
            string numInput = Console.ReadLine();
            int numChars = int.Parse(numInput);

            // Call the method to print out list words of the chosen length:
            printXLetterWords(wordList, numChars);


            static void printXLetterWords(List<string> wordlist, int length)
            {
                foreach (string word in wordlist)
                {
                    if (word.Length == length)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            Console.WriteLine(sumEven(numList));

        }

        static int sumEven(List<int> numList)
        {
            int total = 0;
            foreach (int integer in numList)
            {
                if (integer % 2 == 0)
                {
                    total += integer;
                }
            }
            return total;
        }

        static void printFiveLetterWords(List<string> wordlist)
        {
            foreach (string word in wordlist)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }

    }
}

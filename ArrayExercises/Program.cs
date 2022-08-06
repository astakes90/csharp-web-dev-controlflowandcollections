using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 1, 2, 3, 5, 8 };

            foreach (int number in numArray)
            {
                if (number % 2 == 1)
                {
                    Console.WriteLine(number);
                }
                else
                {
                }
            }
        }
    }
}
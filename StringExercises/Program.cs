using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string docSuess = "I would not, could not, in a box. I would not, could not with a fox." + "\n" +
                "I will not eat them in a house. I will not eat them with a mouse.";
            string[] splitDocSuess = docSuess.Split(".");
            Console.WriteLine(splitDocSuess[0]);
            Console.WriteLine(string.Join(",", splitDocSuess));
        }
    }
}

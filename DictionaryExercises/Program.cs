using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            int idNum;

            Console.WriteLine("Enter your student ID number (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("ID number: ");
                string input = Console.ReadLine();
                int changeInputToNum = int.Parse(input);
                idNum = changeInputToNum;

                if (!Equals(idNum, ""))
                {
                    Console.WriteLine("Name of Student: ");
                    string input2 = Console.ReadLine();
                    string nameOfStudent = input2;

                    students.Add(idNum, nameOfStudent);

                    // Read in the newline before looping back
                    
                }

            } while (!Equals(idNum, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
            }
        }
    }
}

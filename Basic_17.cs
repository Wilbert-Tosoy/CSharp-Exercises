using System;
using static System.Console;

namespace BasicExercise_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;

            Write("Enter a string: ");
            word = Convert.ToString(ReadLine());

            string firstLetter = word.Substring(0, 1);
            WriteLine($"{firstLetter}{word}{firstLetter}");
            ReadKey();
        }
    }
}

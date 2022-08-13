using System;
using static System.Console;

namespace BasicExercise_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Write("Enter a sentence: ");
            str = ReadLine();

            WriteLine(str.ToLower());

            ReadKey();
        }
    }
}

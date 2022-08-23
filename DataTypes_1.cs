using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[3];

            for (int i = 0; i < letters.Length; i++)
            {
                Write("Enter letter: ");
                letters[i] = ToChar(ReadLine());
            }

            Array.Reverse(letters);
            for (int i = 0; i < letters.Length; i++)
            {
                Write($"{letters[i]} ");
            }

            ReadKey();
        }
    }
}

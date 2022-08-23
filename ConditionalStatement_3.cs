using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Write("Enter a number: ");
            number = ToInt32(ReadLine());

            if (number > 0)
            {
                WriteLine($"{number} is a positive number.");
            }
            else if (number < 0)
            {
                WriteLine($"{number} is a negative number.");
            }
            else
            {
                WriteLine($"{number} is a zero.");
            }

            ReadKey();
        }
    }
}

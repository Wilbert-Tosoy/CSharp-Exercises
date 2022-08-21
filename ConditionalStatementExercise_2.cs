using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Write("Enter a number: ");
            number = ToInt32(ReadLine());

            if (number % 2 == 0)
            {
                WriteLine($"{number} is an even number.");
            }
            else
            {
                WriteLine($"{number} is an odd number.");
            }

            ReadKey();
        }
    }
}

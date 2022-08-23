using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Write("Enter first number: ");
            x = ToInt32(ReadLine());
            Write("Enter second number: ");
            y = ToInt32(ReadLine());

            if (x == y)
            {
                WriteLine($"{x} and {y} are equal.");
            }
            else
            {
                WriteLine($"{x} and {y} are not equal.");
            }

            ReadKey();
        }
    }
}

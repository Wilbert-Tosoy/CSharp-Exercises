using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            Write("Enter the value of m: ");
            m = ToInt32(ReadLine());

            if (m > 0)
            {
                n = 1;
                WriteLine($"The value of n = {n}");
            }
            else if (m < 0)
            {
                n = -1;
                WriteLine($"The value of n = {n}");
            }
            else
            {
                n = 0;
                WriteLine($"The value of n = {n}");
            }

            ReadKey();
        }
    }
}

using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;

            Write("Enter Year: ");
            year = ToInt32(ReadLine());

            string leap = year % 4 == 0 ? ($"{year} is a leap year") : ($"{year} is a not a leap year");
            WriteLine(leap);

            ReadKey();
        }
    }
}

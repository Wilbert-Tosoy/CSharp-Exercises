using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercises_10
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

            if (x % 2 == 0 && y % 2 == 0)
            {
                Write("True");
            }
            else
            {
                Write("False");
            }

            ReadKey();
        }
    }
}

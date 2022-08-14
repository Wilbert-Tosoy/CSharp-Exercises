using System;
using static System.Console;
using static System.Convert;

namespace BasicExercise_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0;

            Write("Enter a number: ");
            x = ToInt32(ReadLine());

            while (x != 0)
            {
                sum += (x % 10);
                x /= 10;
            }

            WriteLine($"Sum of the digits: {sum}");

            ReadKey();
        }
    }
}

using System;
using static System.Console;

namespace BasicExercise_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int counter = 0;
            int number = 2;

            while (counter < 500)
            {
                if (PrimeChecker(number))
                {
                    sum += number;
                    counter++;
                }
                number++;
            }

            WriteLine($"Sum of the first 500 prime numbers: {sum}");

            ReadKey();
        }

        public static bool PrimeChecker(int number)
        {
            int x = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= x; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

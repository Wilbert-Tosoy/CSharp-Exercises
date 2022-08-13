using System;
using static System.Console;
using static System.Convert;

namespace BasicExercise_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Write("Enter a number: ");
            x = ToInt32(ReadLine());

            if (Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20)
            {
                WriteLine(true);
            }
            else
            {
                WriteLine(false);
            }

            ReadKey();
        }
    }
}

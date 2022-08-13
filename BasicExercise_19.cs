using System;
using static System.Console;

namespace BasicExercise_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Write("Enter the first number: ");
            x = Convert.ToInt32(ReadLine());
            Write("Enter the second number: ");
            y = Convert.ToInt32(ReadLine());

            if (x == y)
            {
                WriteLine(((x + y) * 3));
            }
            else
            {
                WriteLine(x + y);
            }

            ReadKey();
        }
    }
}

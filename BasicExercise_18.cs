using System;
using static System.Console;
using static System.Convert;

namespace BasicExercise_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Write("Enter the first number: ");
            x = ToInt32(ReadLine());
            WriteLine(x);
            

            Write("Enter the second number: ");
            y = ToInt32(ReadLine());

            if ((x < 0 && y > 0) || (x > 0 && y < 0))
            {
                WriteLine($"Check if one is negative and one is positive: {((x < 0 && y > 0) || (x > 0 && y < 0))}");
            } 
            else
            {
                WriteLine($"Check if one is negative and one is positive: {((x < 0 && y > 0) || (x > 0 && y < 0))}");
            }

            ReadKey();
        }
    }
}

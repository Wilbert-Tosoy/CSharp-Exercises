using System;
using static System.Console;

namespace BasicExercise_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    WriteLine(i);
                }               
            }

            ReadKey();
        }
    }
}

using System;
using static System.Console;
using static System.Convert;

namespace ArrayExercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            // Read the inputs.
            WriteLine("Enter 10 elements in the array.");
            for (int i = 0; i < array.Length; i++)
            {
                Write($"Element - [0] : ");
                array[i] = ToInt32(ReadLine());
            }

            // Print the inputs.
            for (int i = 0; i < array.Length; i++)
            {
                WriteLine($"[0] - {array[i]}");
            }

            ReadKey();
        }
    }
}

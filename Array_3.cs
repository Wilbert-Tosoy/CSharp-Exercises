using System;
using static System.Console;
using static System.Convert;

namespace ArrayExercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Write("Number of elements to be stored in the array: ");
            int number = ToInt32(ReadLine());

            int[] array = new int[number];

            // Read the array elements.
            WriteLine($"Input {number} number in the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Write($"Element - {i} : ");
                array[i] = ToInt32(ReadLine());
                sum += array[i];
            }

            WriteLine($"Sum of all elements : {sum}");

            ReadKey();
        }
    }
}

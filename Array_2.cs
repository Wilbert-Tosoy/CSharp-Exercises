using System;
using static System.Console;
using static System.Convert;

namespace ArrayExercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Number of elements to store in the array: ");
            int number = ToInt32(ReadLine());

            int[] array = new int[number];

            // Read the inputs.
            WriteLine($"Input {number} number of elements in the array.");
            for (int i = 0; i < array.Length; i++)
            {
                Write("Element - [0] : ");
                array[i] = ToInt32(ReadLine());
            }

            // Prints the values in right order.
            WriteLine("The values store into the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Write($"{array[i]} ");
            }

            // Print the inputs in reverse.
            Array.Reverse(array);
            WriteLine($"\nThe values store into the array in reverse are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Write($"{array[i]} ");
            }

            ReadKey();
        }
    }
}

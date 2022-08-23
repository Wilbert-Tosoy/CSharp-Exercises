using System;
using static System.Console;
using static System.Convert;

namespace ArrayExercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Write("Number of elements to be stored in the array: ");
            number = ToInt32(ReadLine());

            int[] array1 = new int[number];
            int[] array2 = new int[number];

            // Read the elements of array1.
            WriteLine($"Input {number} elements in the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Write($"Element - {i} : ");
                array1[i] = ToInt32(ReadLine());
            }

            // Print the elements of array1.
            WriteLine("The elements stored in the first array are: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Write($"{array1[i]} ");
            }

            // Copy the elements of array1 to array2.
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }

            // Print the elements of array2.
            WriteLine("\nThe elements copied into the second array are: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Write($"{array2[i]} ");
            }

            ReadKey();
        }
    }
}

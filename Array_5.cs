using System;
using static System.Console;
using static System.Convert; 

namespace ArrayExercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Write("Number of elements: ");
            int number = ToInt32(ReadLine());

            int[] array1 = new int[number];
            int[] array2 = new int[number];
            int[] array3 = new int[number];

            // Read the elements.
            for (int i = 0; i < array1.Length; i++)
            {
                Write($"Element - {i} : ");
                array1[i] = ToInt32(ReadLine());
            }

            // Copy the elements to the other arrays.
            Array.Copy(array1, array2, array1.Length);
            Array.Clear(array3, 0, array3.Length);

            // Check for duplicates.
            for (int i = 0; i < array1.Length; i++)
            {
                int duplicates = 1;

                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        array3[j] = duplicates;
                        duplicates++;
                    }
                }
                
            }

            // Count the total number of duplicates.
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] == 2)
                {
                    counter++;
                }
            }

            Write($"The number of duplicate elements is: {counter}");

            ReadKey();
        }
    }
}

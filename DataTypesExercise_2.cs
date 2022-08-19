using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width, height, number;

            Write("Enter a number: ");
            number = ToInt32(ReadLine());

            Write("Enter the desired width: ");
            width = ToInt32(ReadLine());

            height = width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Write(number);
                }
                WriteLine("");
                width--;
            }

            ReadKey();
        }
    }
}

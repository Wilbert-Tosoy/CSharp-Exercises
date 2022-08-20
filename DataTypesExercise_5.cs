using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Write("Enter radius: ");
            radius = ToDouble(ReadLine());

            WriteLine($"Circumference: {2 * Math.PI * radius:F2}");

            ReadKey();
        }
    }
}

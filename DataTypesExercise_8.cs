using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Write("Enter radius: ");
            radius = ToDouble(ReadLine());

            WriteLine($"Volume: {(4.00/3.00) * Math.PI * Math.Pow(radius, 3)}");
            WriteLine($"Area: {4.00 * Math.PI * Math.Pow(radius, 2)}");

            ReadKey();
        }
    }
}

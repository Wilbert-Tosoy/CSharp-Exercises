using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height;

            Write("Enter height in cm: ");
            height = ToDouble(ReadLine());

            if (height >= 165.00 && height <= 195.00)
            {
                WriteLine("The person is taller.");
            }
            else if (height >= 150.00 && height <= 165.00)
            {
                WriteLine("The person is average height.");
            }
            else if (height < 150.00)
            {
                WriteLine("The person is dwarf.");
            }
            else
            {
                WriteLine("Abnormal height.");
            }

            ReadKey();
        }
    }
}

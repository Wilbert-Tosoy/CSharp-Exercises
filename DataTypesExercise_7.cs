using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance, hours, minutes, seconds;

            Write("Enter the distance in meters: ");
            distance = ToDouble(ReadLine());
            Write("Enter the hours: ");
            hours = ToDouble(ReadLine());
            Write("Enter the minutes: ");
            minutes = ToDouble(ReadLine());
            Write("Enter the seconds: ");
            seconds = ToDouble(ReadLine());

            double timePerSeconds = ((hours * 3600) + (minutes * 60) + seconds);

            WriteLine($"meters/second : {distance/timePerSeconds:F2}");
            WriteLine($"Kilometers/seconds : {distance/1000.00/(timePerSeconds/3600.00):F2}");
            WriteLine($"Miles/seconds : {((distance / 1000.00) / (timePerSeconds / 3600.00)) / 1.609:F2}");

            ReadKey();
        }
    }
}

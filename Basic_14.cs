using System;

namespace BasicExercise_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius;

            Console.Write("Enter the amount of Celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Kelvin: {celsius + 273:F2}");
            Console.WriteLine($"Fahrenheit: {celsius * 18 / 10 + 32:F2}");
            Console.ReadKey();
        }
    }
}

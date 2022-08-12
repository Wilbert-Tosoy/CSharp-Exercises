using System;

namespace BasicExercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Result of specified numbers {a}, {b} and {c}," +
                $"(a + b)c is {((a + b) * c):F2}" +
                $" and ((a * b) + (b * c)) is {((a * b) + (b * c)):F2}");
            Console.ReadKey();
        }
    }
}

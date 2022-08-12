using System;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace BasicExercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            Console.Write("Enter the First number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Fourth number: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: {(a + b + c + d) / 4:F2}");
            Console.ReadKey();
        }
    }
}

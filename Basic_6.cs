using System;

namespace MultiplicationOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{a} x {b} x {c} = {a * b * c:F2}");
            Console.ReadKey();
        }
    }
}

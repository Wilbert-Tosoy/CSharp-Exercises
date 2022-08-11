using System;

namespace AddingSubtractingMultiplyingDividingOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b:F2}\n" +
                $"{a} - {b} = {a - b:F2}\n" +
                $"{a} * {b} = {a * b:F2}\n" +
                $"{a} % {b} = {a / b:F2}");

            Console.ReadKey();
        }
    }
}

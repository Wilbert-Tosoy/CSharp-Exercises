using System;

namespace DivideTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Quotient: {first / second:F2}");
            Console.ReadKey();
        }
    }
}

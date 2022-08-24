using System;

namespace SwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping: a = {a}, b = {b}");

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"After Swapping: a = {a}, b = {b}");
            Console.ReadKey();
        }
    }
}

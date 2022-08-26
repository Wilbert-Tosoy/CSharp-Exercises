using System;

namespace NumberMultplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            Console.ReadKey();
        }
    }
}

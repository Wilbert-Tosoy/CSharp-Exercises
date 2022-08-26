using System;

namespace BasicExercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a digit: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(number);
                    }
                    Console.WriteLine();
                } 
                else
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}

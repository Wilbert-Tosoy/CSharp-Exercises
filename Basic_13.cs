using System;

namespace BasicExercise_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a digit: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > 0 && i < 9)
                    {
                        if (j != 0 && j != 9)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(number);
                        }
                    } 
                    else
                    {
                        Console.Write(number);
                    }
                }
                Console.WriteLine();    
            }
            Console.ReadKey();
        }
    }
}

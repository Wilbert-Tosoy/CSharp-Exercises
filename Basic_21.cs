using System;
using static System.Console;
using static System.Convert;

namespace BasicExercise_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            do
            {
                Write("Enter the first number: ");
                x = ToInt32(ReadLine());
                if (x == 20)
                {
                    WriteLine(x == 20);
                    break;
                }

                Write("Enter the second number: ");
                y = ToInt32(ReadLine());
                if (y == 20)
                {
                    WriteLine(y == 20);
                    break;
                }

                if (x + y == 20)
                {
                    WriteLine(x + y == 20);
                    break;
                }
                else
                {
                    WriteLine(x + y == 20);
                    break;
                }
 
            } while (true);

            ReadKey();
        }
    }
}

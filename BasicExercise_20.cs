using System;
using static System.Console;
using static System.Convert;

namespace BasicExercise_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Write("Enter the first number: ");
            x = ToInt32(ReadLine());
            Write("Enter the second number: ");
            y = ToInt32(ReadLine());

            if (x > y)
            {
                Absolute(x, y);
            } 
            else
            {
                WriteLine(Math.Abs(x - y));
            }

            ReadKey();
        }

        public static void Absolute(int x, int y)
        {
            WriteLine(Math.Abs((x - y) * 2));
            
        }
    }
}

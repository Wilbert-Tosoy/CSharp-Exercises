using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Write("Enter the value of the first number: ");
            a = ToInt32(ReadLine());
            Write("Enter the value of the second number: ");
            b = ToInt32(ReadLine());
            Write("Enter the value of the third number: ");
            c = ToInt32(ReadLine());

            if (a > b && a > c)
            {
                WriteLine("The 1st number is the greatest among three.");
            } 
            else if (b > a && b > c)
            {
                WriteLine("The 2nd number is the greatest among three.");
            }
            else
            {
                WriteLine("The 3rd number is the greates among three.");
            }

            ReadKey();
        }
    }
}

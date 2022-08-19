using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            char operation;

            Write("Enter the first number: ");
            x = ToDouble(ReadLine());

            Write("Enter operation: ");
            operation = ToChar(ReadLine());

            Write("Enter the second number: ");
            y = ToDouble(ReadLine());

            switch (operation)
            {
                case '+':
                    WriteLine($"{x} + {y} = {x + y}");
                    break;
                case '-':
                    WriteLine($"{x} - {y} = {x - y}");
                    break;
                case '*':
                    WriteLine($"{x} * {y} = {x * y}");
                    break;
                case '/':
                    WriteLine($"{x} / {y} = {x / y}");
                    break;
                default:
                    WriteLine("Syntax Error!");
                    break;
            }

            ReadKey();
        }
    }
}

using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x_coordinate, y_coordinate;

            Write("Enter the value of X coordinate: ");
            x_coordinate = ToInt32(ReadLine());
            Write("Enter the value of Y coordinate: ");
            y_coordinate = ToInt32(ReadLine());

            if (x_coordinate > 0 && y_coordinate > 0)
            {
                WriteLine($"The coordinate point ({x_coordinate}, {y_coordinate}) " +
                    $"lies in the First Quadrant.");
            }
            else if (x_coordinate > 0 && y_coordinate < 0)
            {
                WriteLine($"The coordinate point ({x_coordinate}, {y_coordinate}) " +
                    $"lies in the Second Quadrant.");
            }
            else if (x_coordinate < 0 && y_coordinate < 0)
            {
                WriteLine($"The coordinate point ({x_coordinate}, {y_coordinate}) " +
                    $"lies in the Third Quadrant.");
            }
            else if (x_coordinate < 0 && y_coordinate > 0)
            {
                WriteLine($"The coordinate point ({x_coordinate}, {y_coordinate}) " +
                    $"lies in the Fourth Quadrant.");
            } 
            else
            {
                WriteLine($"The coordinate point ({x_coordinate}, {y_coordinate}) " +
                    $"lies at the origin.");
            }

            ReadKey();
        }
    }
}

using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;
            string answer;
            int num;

            Write("Enter a number: ");
            answer = ReadLine();

            num = ToInt32(answer);
            result = "";

            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                WriteLine(result);
                num /= 2;
            }

            result = Convert.ToString(num) + result;
            WriteLine($"Binary: {result}");

            ReadKey();
        }
    }
}

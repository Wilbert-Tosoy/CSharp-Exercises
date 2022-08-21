using System;
using static System.Console;
using static System.Convert;

namespace ConditionalStatementExercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Write("Enter age: ");
            age = ToInt32(ReadLine());

            WriteLine(age >= 18 ? "Congratulations! You are elegible for casting your vote" : 
                "Sorry, You are not elegible for casting your vote.");

            ReadKey();
        }
    }
}

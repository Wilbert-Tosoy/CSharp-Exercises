using System;

namespace BasicExercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You look older than {age}");
            Console.ReadKey();
        }
    }
}

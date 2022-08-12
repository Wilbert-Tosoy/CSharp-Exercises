using System;

namespace BasicExercise_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("Enter a string: ");
            str = Convert.ToString(Console.ReadLine());

            if (str.Length > 1)
            {
                Console.WriteLine(str);
                Console.WriteLine($"{str.Substring(str.Length - 1)}{str.Substring(1, str.Length - 2)}{str.Substring(0, 1)}");
            }
            else
            {
                Console.WriteLine(str); 
            }

            Console.ReadKey();
        }
    }
}
using System;

namespace Hello___Name__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {name}!");

            Console.ReadKey();
        }
    }
}

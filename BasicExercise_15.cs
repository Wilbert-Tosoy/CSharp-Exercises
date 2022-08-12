using System;

namespace BasicExercise_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int index;

            Console.Write("Enter a word: ");
            word = Convert.ToString(Console.ReadLine());
            Console.WriteLine(word);

            Console.Write("Letter-index to be remove: ");
            index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{word.Remove(index, index)}");
            Console.ReadKey();
        }
    }
}

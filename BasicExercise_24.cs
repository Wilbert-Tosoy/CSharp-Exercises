using System;
using static System.Console;

namespace BasicExercise_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Write("Enter a sentence: ");
            str = ReadLine();

            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            WriteLine(word);

            ReadKey();
        }
    }
}

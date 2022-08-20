using System;
using static System.Console;
using static System.Convert;

namespace DataTypesExercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x;

            Write("Enter a symbol: ");
            x = ToChar(ReadLine());

            if (Char.IsLower(x))
            {
                if ((x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'))
                {
                    WriteLine("It is a lowercase vowel.");
                } 
                else
                {
                    WriteLine("Is is a lowercase consonant.");
                }
            }
            else if (Char.IsUpper(x))
            {
                if ((x == 'A') || (x == 'E') || (x == 'I') || (x == 'O') || (x == 'U'))
                {
                    WriteLine("It is an uppercase vowel.");
                }
                else
                {
                    WriteLine("Is is an uppercase consonant.");
                }
            }
            else if (Char.IsNumber(x))
            {
                WriteLine("It is a number.");
            }
            else
            {
                WriteLine("It is another symbol.");
            }

            ReadKey();
        }
    }
}

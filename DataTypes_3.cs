using System;
using static System.Console;

namespace DataTypesExercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userID, password;
            int success = 0;
            int failedCounter = 0;

            // Username and password is : "username" and "password".

            do
            {
                Write("Enter username: ");
                userID = ReadLine();

                Write("Enter password: ");
                password = ReadLine();

                if (userID == "username" && password == "password")
                {
                    success = 1;
                    failedCounter = 3;
                }
                else
                {
                    failedCounter++;
                    WriteLine("\nIncorrect!\n");
                }
            } while ((userID != "username" || password != "password") && (failedCounter != 3));

            if (success == 1)
            {
                WriteLine("\nEntered Successfully!");
            } 
            else
            {
                WriteLine("\nLogin Failed.");
            }

            ReadKey();
        }
    }
}

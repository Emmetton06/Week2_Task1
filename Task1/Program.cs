/*
 * Practical 1
 * Information: Methods demo
 * Version 1
 * Author: Emmett O'Neill
 * Date: September
 */

using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            // Declare option outside the loop so the while condition can see it
            int option;

            do
            {
                // 1 Display the menu options
                PrintMenu();

                // 2 Get option from user
                option = InputOption();

                // 3 Pass integer option to determine the language string phrase
                string phase = GetMessage(option);

                // 4 Display the returned string message
                Console.WriteLine($"\nResult: {phase}\n");

            } while (option != 0);

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
        
        static void PrintMenu()
        {
            Console.WriteLine("Please enter a valid option from below:");
            Console.WriteLine("1. Hello in French?");
            Console.WriteLine("2. Hello in Spanish?");
            Console.WriteLine("3. Hello in German?");
            Console.WriteLine("4. Hello in Italian?");
            Console.WriteLine("0. Exit application");
        }

        static int InputOption()
        {
            try
            {
                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);
                return choice;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n[CRASH PREVENTED] Invalid character entered.");
                Console.WriteLine($"Helpful Information: You typed letters/symbols instead of a number digit. \nDetails: {ex.Message}");
                return -1;
            }
        }
        // New GetMessage Method
        static string GetMessage(int language)
        {

            switch (language)
            {
                case 0:
                    return "Goodbye";
                case 1:
                    return "Bonjour";
                case 2:
                    return "Ola"; // Written exactly as requested by your assignment sheet
                case 3:
                    return "Hallo";
                case 4:
                    return "Ciao";
                default:
                    return "Please enter a valid option";
            }
        }
    }
}
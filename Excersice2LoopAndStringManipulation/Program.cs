using System;
using System.ComponentModel.Design;

namespace Excersice2LoopAndStringManipulation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu();  
        }

        private static void Menu()
        {
            // Huvudmeny
            Console.WriteLine("\nWelcome to Your Little Cinema Theater!\n\n");
            Console.WriteLine("1. Cinema ticket price.");
            Console.WriteLine("2. Repeat word 10 times.");
            Console.WriteLine("3. Split sentence.");

            Console.WriteLine("You navigate by chosing one of the options:\n\n1, 2, 3 or 0 to quit the program.");
            Console.WriteLine("\n\n\n");
        }
        private static void TicketPrice()
        {
            // Variable declaration
            string number;
            int age;
            // options
            Console.WriteLine("1. Please enter you age:");
            number = Console.ReadLine();
            age = int.Parse(number);
        }

    }
}

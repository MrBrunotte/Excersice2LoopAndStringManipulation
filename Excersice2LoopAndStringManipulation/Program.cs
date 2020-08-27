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
            Console.WriteLine("Q. Quit.");
            Console.WriteLine("\n");

            switch (Console.ReadLine())
            {
                case "1:":
                    TicketPrice();
                    break;
                case "2":
                    //RepeatWord();
                    break;
                case "3":
                    //SplitSentence();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    break;    
            }
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

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
            Console.WriteLine("\n########## Main Menu!##########\n");
            Console.WriteLine("\tChoose a number (or Q to exit.)");
            Console.WriteLine("\n\t1. Cinema ticket price.");
            Console.WriteLine("\t2. Repeat word 10 times.");
            Console.WriteLine("\t3. Split sentence.");
            Console.WriteLine("\n\tQ. Quit.\n");

            // Switch statement to call correct method according to user choice.
            switch (Console.ReadLine())
            {
                case "1":
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
            // user enters age
            // age is converted to int

            Console.WriteLine("##### Welcome to the Cineama! #####");
            Console.Write("1. Please enter you age: ");
            number = Console.ReadLine();
            age = int.Parse(number);

            // if statement to give user correct ticket price
            if (age < 20)
            {
                Console.WriteLine("\nYou are under 20 years old! \nYour ticket price is: 80 kr.");
                Menu();
            }
            if (age > 64)
            {
                Console.WriteLine("\nYou are a senior over 64 years! \nYour ticket price is: 90 kr.");
                Menu();
            }
            else
            {
                Console.WriteLine("\nSince you are not a senior or youth! \nYour ticket price is: 120 kr.");
                Menu();
            }
                


        }

    }
}

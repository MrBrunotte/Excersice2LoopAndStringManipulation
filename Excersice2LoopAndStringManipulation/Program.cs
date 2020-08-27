using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
                    // If user uses Q to quit
                    Environment.Exit(0);
                    break;
                case "q":
                    // If user uses q to quit
                    Environment.Exit(0);
                    break;
                default:
                    break;    
            }
        }
        private static void TicketPrice()
        {
            // Method for first exercise
            Console.WriteLine("##### Welcome to the Cineama! #####");
            Console.WriteLine("\t1. Buy one single ticket.");
            Console.WriteLine("\t2. Buy two or more tickets.");

            // Switch statement to chose from the two options.
            // Each options has its own method
            switch (Console.ReadLine())
            {
                case "1":
                    OneTicket();
                    break;
                case "2":
                    MoreTickets();
                    break;
                default:
                    break;
            }
        }

        private static void MoreTickets()
            // Method when user wants to buy 2 or more tickets. 
            // The method checks for how many tickets to buy and the age of each person.
            // It then calculates the total amount and displays how many tickets and total price.
        {
            // declaring variables and some starting values
            string strNumber, strTickets;
            int age, tickets;
            int i = 0;
            int youth = 0;
            int adult = 0;
            int senior = 0;
            int totaltickets = 0;

            // input from user and parsing it to correct format: int
            Console.Write("\tHow many ticket's do you want to buy?\t");
            strTickets = Console.ReadLine();
            tickets = int.Parse(strTickets);

            // do statement that checks the age to get correct price and also how 
            // many tickets to buy. 
            do
            {
                Console.Write("Please enter your age: ");
                strNumber = Console.ReadLine();
                age = int.Parse(strNumber);
                Console.WriteLine("", i);

                if (age < 20)
                    youth += 80;
                else if (age > 64)
                    adult += 90;
                else if (age > 20 && age < 64) 
                    senior += 120;
                else
                    Console.WriteLine("Something went wrong! Did you really enter a digit number?");
                
                i++;
                // breaks the do loop when number of tickets are filled.
            } while (i < tickets);

            // sums up the tickets and prints it out in the console.
            totaltickets = youth + adult + senior;
            Console.WriteLine("\tYou get a total of " + tickets + " tickets.");
            Console.WriteLine("\tYour total ticket price is: " + totaltickets +"kr\n");

            // directs the user back to the main menu
            Menu();
        }


        private static void OneTicket()
        {
            // Method to buy one ticket
            // Checks age and get correct price
            string number;
            int age;
            Console.Write("Please enter your age: ");
            number = Console.ReadLine();
            age = int.Parse(number);

            // if statement to give user correct ticket price
            if (age < 20)
                Console.WriteLine("\nYou are under 20 years old! \nYour ticket price is: 80 kr.");
            if (age > 64)
                Console.WriteLine("\nYou are a senior over 64 years! \nYour ticket price is: 90 kr.");
            if (age > 20 && age < 64)
                Console.WriteLine("\nSince you are not a senior or youth! \nYour ticket price is: 120 kr.");
            else
                Console.WriteLine("\nSomething went wrong! Did you really enter a digit number?");

            // directs the user back to the main menu
            Menu();
        }
    }
}

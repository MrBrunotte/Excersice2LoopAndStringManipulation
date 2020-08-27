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
            Console.WriteLine("##### Welcome to the Cineama! #####");
            Console.WriteLine("1. Buy one single ticket.");
            Console.WriteLine("2. Buy two or more tickets.");

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
        {
            string strNumber, strTickets;
            int age, tickets;
            int i = 0;
            int ticket = 0;
            int youth = 0;
            int adult = 0;
            int senior = 0;
            int totaltickets = 0;


            Console.WriteLine("How many ticket's do you want to buy?");
            strTickets = Console.ReadLine();
            tickets = int.Parse(strTickets);

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
            } while (i < tickets);

            totaltickets = youth + adult + senior;
            Console.WriteLine("You get a total of " + tickets + " tickets.");
            Console.WriteLine("Your total ticket price is: " + totaltickets +"kr");
            


            

            // if statement to give user correct ticket price
            
            //Menu();

        }


        private static void OneTicket()
        {
            string number;
            int age;
            int ticket;
            Console.Write("Please enter your age: ");
            number = Console.ReadLine();
            age = int.Parse(number);

            // if statement to give user correct ticket price
            if (age < 20)
            {
                Console.WriteLine("\nYou are under 20 years old! \nYour ticket price is: 80 kr.");
            }
            if (age > 64)
            {
                Console.WriteLine("\nYou are a senior over 64 years! \nYour ticket price is: 90 kr.");
                
            }
            if (age > 20 && age < 64)
            {
                Console.WriteLine("\nSince you are not a senior or youth! \nYour ticket price is: 120 kr.");
                
            }
            else
            {
                Console.WriteLine("\nSomething went wrong! Did you really enter a digit number?");
                
            }
            Menu();
        }
    }
}

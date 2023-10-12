using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        string choice = "0";
        public List<Journal> newJournal = new List<Journal>();

        while (choice != "4")
        {
            //Journal Menu
            Console.WriteLine("Welcome to your journal! What would you like to do today?");
            Console.WriteLine("");
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. New Journal Entry.");
            Console.WriteLine("2. Save Journal.");
            Console.WriteLine("3. Display Journal Entry.");
            Console.WriteLine("4. Quit.");

            string choice = Console.ReadLine();

            // Condition to add new journal entry
            if (choice == "1")
            {
                //Display the journal prompt
                
                JournalPrompt journalPrompt = new JournalPrompt{};
                journalPrompt._prompt.DisplayPrompt();

                //Get the user to add an entry to the journal
                Console.WriteLine("Your entry: ");
                string response = Console.ReadLine();


            }

            // Condition to save journal entry to file
            else if (choice == "2")
            {
                
                SaveToFile(newJournal);   
            }

            //Condition to display journal entries
            else if (choice == "3")
            {
                Display(newJournal);
            }

            // User wants to exit the program, display thank you message
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the journal today!");

            }

            // Invalid entry, display message to user to try again
            else ()
            {
                Console.WriteLine("Invalid input. Please look at the menu and try again.");
            }

        }
        


    }

}
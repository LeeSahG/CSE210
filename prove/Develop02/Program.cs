using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Entry newEntry = new Entry();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to your journal!");
        int choice = 0;

        while (choice != 5)
        {

            //Displaying journal Menu
            Console.WriteLine("");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("");
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. New Journal Entry.");
            Console.WriteLine("2. Save Journal.");
            Console.WriteLine("3. Display Journal.");
            Console.WriteLine("4. Load Journal.");
            Console.WriteLine("5. Quit.");
            Console.WriteLine(">");
            choice = int.Parse(Console.ReadLine());

            // Make a journal entry
            if (choice == 1)
            {
                newEntry.NewEntry();
            }

            // Save journal to file
            else if (choice == 2)
            {
                journal.SaveToFile();
            }

            else if (choice == 3)
            {
                journal.DisplayJournal();
            }

            else if (choice == 4)
            {
                journal.LoadFile();
            }

            else if (choice == 5)
            {
                Console.WriteLine("Thank you for your inout today. Hope to hear from you again.");
            }
        }
    }


        

    
}
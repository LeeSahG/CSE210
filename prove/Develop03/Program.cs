using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        private List<Scripture> scriptures = new List<Scripture>();
        Program program = new Program();

        // Adding scriptures to list
        program.AddScriptures("Alma", 32, 31, 31, "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        program.AddScriptures("Proverbs", 3, 5, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding");
        program.AddScriptures("Doctrine and Covenants", 82, 10, 10, "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");

        // Foreach loop to go through scriptures
        foreach (scripture in program.scriptures)
        {
            while (!scripture.finish)
            {
                Console.Clear();
                
            }
        }

        public void AddScriptures(string book, int chapter, int firstVerse, int secondVerse, string text)
        {
            Reference reference = new Reference(book, chapter, firstVerse, secondVerse);
            Scripture scripture = new Scripture(reference, text);
            // Calling function
            scriptures.Add(scripture);
        }


        
        
    }
}

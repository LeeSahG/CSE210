using System;

class Program
{

// if selected "new entry, have prompt asking if want to save the entry"
Console.Write("5. Quit.");
    static void Main(string[] args)
    {
    
    public class Choice
    {
        public void ShowPrompts()
        {
            // Display journal menu
            Console.WriteLine("Journal Menu");
            Console.Write("1. New Journal Entry.");
            Console.Write("2. Display Journal.");
            Console.Write("3. Delete Journal Entry.");
            Console.Write("4. Save Journal Entry.");

            choice = Console.ReadLine();jyh7 rtvf

            if (choice == "1")
            {
                journal.AddEntry();
            }
        }
    }

    public void AddEntry()
    {
        DateTime currentTome = DateTime.Now;
        string dateText = currentTime

        // Prompt questions for journal entry
        List<string> questions = new List<string>();
        questions.Add("What are you most grateful for today?");
        questions.Add("What is your favorite moment of the day?");
        questions.Add("Did you do something new today?");
        questions.Add("What emotion would you like to re-visit today?");
        questions.Add("How were you a disciple today?");

        //Use of random generator to pick prompt for the day
         Random randomGenerator = new Random();
         int randomNumber = randomGenerator.Next(questions.Count)

         
    }
    
    }
}
/********************************************************
ENTRY
This is an Entry class for user to enter their response
*********************************************************/

public class Entry
{
    // Attributes / Member variables to store date, entry and prompt
    public string _prompt;
    public string _date;
    public string _entry;

    // METHODS (Behaviors)
    // Actions that the class can do
    
    public void DisplayPrompt()
    {
        // Create object of Entry class
        List<Entry> _entries = new List<Entry>();

        // Create integer list
        string[] prompts = 
        {   "What are you most grateful for today?", 
            "What is your favorite moment of the day?",
            "Did you do something new today? If yes, what? If no, what would you have liked to do?",
            "What emotion would you like to re-visit today?",
            "How were you a disciple of Christ today?"
        };

        // Create object of Random class
        Random prompt = new Random();

        // Generate random index
        int index = prompt.Next(prompts.Length);

        string randomPrompt = prompts[index];

        // Creating new instance
        Entry newEntry = new Entry();
        newEntry._prompt = randomPrompt;

        _entries.Add(newEntry);

    } 

    // User wants to add a new entry to journal
    public void NewEntry()
    {
        // Create object of Entry class
        List<Entry> _entries = new List<Entry>();

        // Create integer list
        string[] prompts = 
        {   "What are you most grateful for today?", 
            "What is your favorite moment of the day?",
            "Did you do something new today? If yes, what? If no, what would you have liked to do?",
            "What emotion would you like to re-visit today?",
            "How were you a disciple of Christ today?"
        };

        // Create object of Random class
        Random prompt = new Random();

        // Generate random index
        int index = prompt.Next(prompts.Length);

        string randomPrompt = prompts[index];

        // Creating new instance
        Entry newEntry = new Entry();
        newEntry._prompt = randomPrompt;
        
        // Setting the current time
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToString();
        
        // Print the prompt for the user
        Console.WriteLine($"Date: {dateText} | Your prompt: {randomPrompt}");
        Console.WriteLine("Enter your thoughts here: ");
        Console.WriteLine(">");

        string response = Console.ReadLine();

        Console.WriteLine("Thank you for your response! Can't wait to hear from you again!");

        newEntry._date = dateText;
        newEntry._entry = response;

        // Merge entries to Entry class

        _entries.Add(newEntry);
    
    }

}
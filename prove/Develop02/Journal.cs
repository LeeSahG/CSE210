/*********************************
* JOURNAL
* This class represents a journal
**********************************/

class Journal
{
    // Journal entry Attributes 
    // Noun that describes the class or something
    // that it has
    public string _date = DateTime.Now;
    public string _prompt;
    public string _entry;

    // Methods - Member functions
    // Verbs or actions that the class (the journal) can perform.

    //Method displaying journal prompt
    public string DisplayPrompt()
    {
        
        // Use random generator to display a question for the user to answer
        // Will pick random prompt from the list 
        public List<string> _prompt = new List<string>()
        {"What are you most grateful for today?" , 
        "What is your favorite moment of the day?" ,
        "Did you do something new today? If yes, what? If no, what would you have liked to do?" ,
        "What emotion would you like to re-visit today?",
        "How were you a disciple of Christ today?"};

        // Use of random generator to pick out random question for the day
        Random randomPrompt = new Random();
        // This line of code gives you a random number
        //Variable name randomInteger
        int randomInteger = randomPrompt.Next(prompts.Count);

        return _prompt[randomInteger];
    }

    // Method asking the user to type in their answer to prompt
    public void NewEntry()
    {
        Console.WriteLine("");
        Console.WriteLine("Please write your journal entry here: ");
        Console.WriteLine("> ");
        string _entry = Console.ReadLine();

        return _entry;
    }

    // Show previous journal entries
    public void Display()
    {
        Console.WriteLine($"Date: {_date} | Question of the day: {_prompt}");
        _entry.NewEntry();
    }

    /***********
    SaveToFile Method
    ************/

    public static void SaveToFile(List<Journal> newJournal)
    {
        Console.WriteLine("Enter the filename you would like to save your file to.");
        
        string filename = Console.ReadLine();

        Console.WriteLine("Saving file...");

        using (StreamWriter outputFile = new StreamWrite(filename))
        {
        foreach (Journal j in newJournal)
        {
            outputFile.WriteLine($"(Date: {j._date} | Prompt: {j.prompt} | Entry: {j._entry}");

        }
        }
    }

    public static List<Journal> ReadFromFile()
    {
        // To see that program is reading from file
        Console.WriteLine("Reading from file...");

        Console.WriteLine("Enter the filename you would like to read from: ");
        List<Journal> newJournal = new List<Journal>();
        string filename = Console.ReadLine();

        // Read whole file once and put into string array, iterate through
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return newJournal;

    }

}


/*******************************
JOURNAL
This class represents a journal
********************************/

using System.Runtime.CompilerServices;

public class Journal
{
    // Attributes
    // Creates object of the Entry class
    public List<Entry> _entries = new List<Entry>();
    
    // METHODS
    // Behaviors of the journal
    
    // Saving journal out to a file
    
    public void SaveToFile()
    {

        Console.WriteLine("Enter the filename you would like to save your file to.");
        Console.WriteLine(">");
        
        string filename = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Saving file...");

        // StreamWriter object created
        using (StreamWriter outputFile = new StreamWriter(filename))
        { 
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"Date: {e._date} | Prompt: {e._prompt}");
                outputFile.WriteLine($"Entry: {e._entry}");

            }
        }
    }

    // Displaying journal to user
    public void DisplayJournal()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e);
            /** Console.WriteLine($"Date: {_date} | Question of the day: {_prompt}");
            Console.WriteLine($"Your response: {_entry}"); **/
        }
        
    }

    public void LoadFile()
    {
        Console.WriteLine("Reading entries from file...");
        List<Entry> _entries = new List<Entry>();
        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            string[] parts = line.Split("|");

            string _date = parts[0];
            string _prompt = parts[1];
            string _entry = parts[2];
        }
    }
}

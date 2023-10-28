/****************************************
SCRIPTURES
This is a Scripture class.
*****************************************/

public class Scripture
{
    // Attributes of scripture
    // What the scripture has
    private Reference _reference;
    private List<Word> _words;
    private int hiddenWordCount = 0;
    public bool finish { get; private set; }

    public bool AllWordsHidden => hiddenWordCount == words.Count;
    
    // METHODS - Behaviors of the class
    // Keep track of reference and text, and hide words

    // Scripture method
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
        this.finsih = false;
    }

    // Display method controlling displayed words
    public void Display()
    {
        Console.WriteLine(reference);
        
        foreach (var word in words)
        {
            if (word.IsHidden)
            {
                Console.Write("___");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
    }

    // HideWords method controlling hidden words
    public void HideWords(int count)
    {
        if (AllWordsHidden)
        {
            finish = true;
            return;
        }

        Random random = new Random();
        List<Word> wordsToHide = words.Where(word => !word.IsHidden).OrderBy(_ => random.Next()).FirstOrDefault();

        foreach (var word in wordsToHide)
        {
            word.Hide();
            hiddenWordCount++;
        }
    }

    // Reavel method controlling revealing hidden word in scripture
    public void ShowWord()
    {
        if (hiddenWordCount < words.Count)
        {
            Random random = new Random();
            Word wordToShow = words.Where(word => word.IsHidden).OrderBy(_ => random.Next()).FirstOrDefault();

            if (wordToShow != null)
            {
                wordToShow.Show();
                hiddenWordCount--;
            }
        }

    }

}
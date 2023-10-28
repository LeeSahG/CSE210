/*************************************
WORDS
This is a Words class.
**************************************/

public class Word
{
    // Attributes
    // What the class has
    public string Text {get; }
    public bool IsHidden { get; private set; }
    
    // METHODS - Behaviors of the class
    // Keep track of single word and whether it
    // is hidden or shown

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }

}
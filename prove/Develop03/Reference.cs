/*******************************************
REFERENCE
This class keeps track of the book, chapter,
and verse information.
********************************************/

public class Reference
{
    // Attributes describing what reference does
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _secondVerse;

    // METHODS - Behaviors of the class
    // Keeps track of book, chapter, and verse info

    // Scriptures method will accept parameters 
    public void AddScriptures(string _book, int _chapter, int _firstVerse, int _secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = secondVerse;   
    }

    public string Display()
    {
        // Accommodating scriptures with multiple scriptures
        if (_firstVerse == _secondVerse)
        {
            return $"{_book} {_chapter}: {_firstVerse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_firstVerse} - {_secondVerse}";
        }
    }
    
}
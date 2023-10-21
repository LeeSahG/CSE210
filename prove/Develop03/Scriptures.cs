/****************************************
SCRIPTURES
This class represents scriptures
*****************************************/

class Scriptures
{
    public void HideWord()
    {
        int index = random.Next(_words.Count);

        while ( _words[index].GetStatus()) // Check if word is already hidden
        {
            index = random.Next(_words);
        }

        // Hiding a single word
    }

}
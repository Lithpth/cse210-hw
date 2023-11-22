class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference Reference, string text)
    {
        _reference=Reference;
        _words=new List<Word>();
        
        // this will make the text have each word as an individual object
        string[] wordArray=text.Split(' ');
        foreach (var wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        //Random generator
        Random random = new Random();

        //this itterates through each word, and randomly uses .Hide() to make a word isHidden
        for (int i=0;i<numberToHide;i++)
        {
            int r = random.Next(_words.Count);
            if(!_words[r].IsHidden())
            {
            _words[r].Hide(); 
            }
            else
            {
                //if already hiden decrement the count to retry
                i--;
            }
        }

    }
    // Display all the words
    public string GetDisplayText()
    {
        List<string> displayWords=new List<string>();

        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    // Check if all the words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            //if it is not "IsHidden"
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
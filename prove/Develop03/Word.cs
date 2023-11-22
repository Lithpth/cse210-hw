class Word
{
    private string _text;
    private bool _isHidden;

    public string Text { get => _text; set => _text = value; }

    public Word(string text)
    {
        Text = text;
    }

    public void Hide()
    {
        _isHidden=true;
    }
    public void Show()
    {
        _isHidden=false;
    }
    // This will tell the other classes if the word is hidden 
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "*****";
        }
        else
        {
            return Text;
        }
    }
}

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text, bool IsHidden)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }   

    public string GetText()
    {
        return _isHidden ? "_____" : _text;
    }

    public bool IsAllHidden()
    {
        return _isHidden;
    }
}


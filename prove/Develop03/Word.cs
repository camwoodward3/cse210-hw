public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetText()
    {
        return _isHidden ? "_____" : _text;
    }
}


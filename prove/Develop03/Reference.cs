public class Reference

{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, string chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = -1;
    }

    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public bool IsRange()
    {
        return _endVerse >= 0;
    }

    public string GetDisplay()
    {
        return IsRange()
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}"
            : $"{_book} {_chapter}:{_startVerse}";
    }
}

public class Book
{
    
    public string _title;
    public string _author;
    public int _pageCount;

    public string GetSummary()
    {
        return ($"The book summary is {_title} -- {_author} -- {_pageCount}");
    }
}
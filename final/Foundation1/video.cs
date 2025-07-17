using System;
using System.Runtime.CompilerServices;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    private List<Comments> _comments;

    public Video(string title, string author, int length, List<Comments> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void DisplayComments()
    {

        foreach (Comments comment in _comments)
        {
            Console.WriteLine($"{comment.getName()}: {comment.getText()}");
        }
    }
    public int GetCommentCount()
    {
        return _comments.Count();
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title} by {_author}, {_length} minutes.");
    }
}
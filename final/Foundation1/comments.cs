using System;

public class Comments
{
    private string _name;
    private string _text;

    public Comments(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string getName()
    {
        return _name;
    }

    public string getText()
    {
        return _text;
    }

}
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }



    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        List<Word> visible = _words.FindAll(w => !w.GetIsHidden());
    }


    public string DisplayScripture()
    {
        List<string> output = new List<string>();

        foreach (Word word in _words)
        {
            output.Add(word.GetText());
        }

        return $"{_reference.DisplayReference()} {string.Join(" ", output)}";
    }

    public bool IsAllHidden() {
        return _words.TrueForAll(w => w.GetIsHidden());
    }
}
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
        List<Word> visible = _words.FindAll(w => !w.IsHidden());

        for (int i = 0; i < count && visible.Count > 0; i++)
        {
            int index = rand.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        List<string> output = new List<string>();

        foreach (Word word in _words)
        {
            output.Add(word.GetText());
        }

        return $"{_reference.GetDisplay()} {string.Join(" ", output)}";
    }
}

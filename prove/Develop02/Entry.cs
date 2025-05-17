using System;

public class Entry
{

    public DateTime _theCurrentTime = DateTime.Now;

    public string _question;
    public string _answer;

    public Entry(DateTime theCurrentTime, string question, string answer)
    {
        _theCurrentTime = theCurrentTime;
        _question = question;
        _answer = answer;
    }

    public void StoreInputInto(string fileName)
    {
        Console.WriteLine($"{_theCurrentTime}{_question} {_answer}");
        using (StreamWriter writeToFile = new StreamWriter(fileName))
        {
            writeToFile.WriteLine($"{_theCurrentTime.ToShortDateString()}|{_question}|{_answer}\n");
        }
    }
    




       
}
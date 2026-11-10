
using System;

public class Entry
{
    // These variables store information about one journal entry.
    private string _date;
    private string _prompt;
    private string _response;

    // Constructor: creates a new journal entry.
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Displays the journal entry.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    // Returns the information needed to save the entry.
    public string GetEntryData()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}

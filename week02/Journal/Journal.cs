
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    // Constructor initializes an empty journal.
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Adds a new entry to the journal.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all entries in the journal.
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves all journal entries to a file.
    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add(entry.GetEntryData());
        }

        File.WriteAllLines(filename, lines);

        Console.WriteLine("Journal saved successfully!");
    }

    // Loads journal entries from a file.
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        // Replace existing entries with the loaded entries.
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|', 3);

            if (parts.Length == 3)
            {
                Entry entry = new Entry(
                    parts[0],
                    parts[1],
                    parts[2]
                );

                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}

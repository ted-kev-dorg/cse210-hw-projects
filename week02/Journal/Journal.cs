using System.IO;
using System.Collections.Generic;
using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {

        if(_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outPutFile = new StreamWriter(file))
        {
            foreach ( Entry entry in _entries)
            {
                outPutFile.WriteLine($"{entry._date}~{entry._entryText}~{entry._mood}~{entry._promptText}");
            }
            Console.WriteLine($"Journal successfully save to {file}.");  
        }
    }

    public void LoadFromFile (string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            if (parts.Length == 4)
            {
                // Creeate an empty entry first
                Entry loadEntry = new Entry();

                // manually fill in each variable one by on
                loadEntry._date = parts[0];
                loadEntry._entryText = parts[1];
                loadEntry._mood = parts[2];
                loadEntry._promptText = parts[3];

                _entries.Add(loadEntry);

            }  
        }
        Console.WriteLine($"Jornal successfully load from {file}");
    }

}
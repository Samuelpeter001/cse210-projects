using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; private set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void LoadJournal()
    {
        Console.Write("Enter a file name: ");
        string fileName = Console.ReadLine();
        Entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            Entry currentEntry = null;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date; "))
                {
                    DateTime date = DateTime.Parse(line.Substring(6));
                    currentEntry = new Entry(date, null, null);
                }
                else if (line.StartsWith("prompt: ") && currentEntry != null)
                {
                    currentEntry.Prompt = line.Substring(8);
                }
                else if (line.StartsWith("reply: ") && currentEntry != null)
                {
                    currentEntry.Reply = line.Substring(9);
                    Entries.Add(currentEntry);
                }
            }
        }
    }
}

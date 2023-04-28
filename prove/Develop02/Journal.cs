using System;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournalToFile(string fileName)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }
    }

    public void LoadJournalFromFile(string fileName)
    {
        using (System.IO.StreamReader file = new System.IO.StreamReader(fileName))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                DateTime date = DateTime.Parse(fields[0]);
                string prompt = fields[1];
                string response = fields[2];
                Entry entry = new Entry(date, prompt, response);
                _entries.Add(entry);
            }
        }
    }
}
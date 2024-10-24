public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.LoadJournal();
        
        foreach (var entry in journal.Entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Reply: {entry.Reply}");
        }
    }
}

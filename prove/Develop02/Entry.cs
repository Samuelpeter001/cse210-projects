public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Reply { get; set; }

    public Entry(DateTime date, string prompt, string reply)
    {
        Date = date;
        Prompt = prompt;
        Reply = reply;
    }
}

public class ListingActivity : Assignment
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 30)
    {
        _count = 0;
        _prompts = new List<string>()
        {
            "Who are people that you appreciate? ",
            "What are personal strengths of yours? ",
            "Who are people that you have helped this week? ",
            "When have you felt the Holy Ghost this month? ",
            "Who are some of your personal heroes? "
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public void GetListFromUser()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        string reply = Console.ReadLine();
        while (reply != "")
        {
            Console.WriteLine("Next response:");
            reply = Console.ReadLine();
        }
    }
}
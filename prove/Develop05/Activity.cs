public class Assignment
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Assignment(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}\n {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}. Thank you for participating");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\rLoading...");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r           ");
            System.Threading.Thread.Sleep(100);
            Console.Write("\rLoading...");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
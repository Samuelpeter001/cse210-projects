public class BreathActivity : Assignment
{
    public BreathActivity() : base("Breathing Activities", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 30)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Breathe in...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Breathe out...");
        System.Threading.Thread.Sleep(2000);
        DisplayEndingMessage();
    }
}
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 30)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(_duration);
        Console.WriteLine("Breathe in...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Breathe out...");
        System.Threading.Thread.Sleep(2000);
        DisplayEndingMessage();
    }
}
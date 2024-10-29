using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowCountDown(_duration);
        GetListFromUser ();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public void GetListFromUser ()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        
        List<string> responses = new List<string>();
        string reply = Console.ReadLine();

        while (!string.IsNullOrWhiteSpace(reply))
        {
            responses.Add(reply);
            Console.WriteLine("Next response (or press Enter to finish):");
            reply = Console.ReadLine();
        }

        Console.WriteLine("\nYour responses:");
        foreach (var response in responses)
        {
            Console.WriteLine($"- {response}");
        }
    }
}
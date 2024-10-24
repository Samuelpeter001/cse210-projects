public class ReflectionActivity : Activity
{
    private list<string> _prompt;
    private list<string> _question;
    public ReflectionActivity : base("Reflection Activity", "This activity will help you reflet on times in your life where you have shown strength and resilience. This will help you recognise the power you have and how you can use it in other aspect of life." 30)
    {
        prompt = new list<string>()
        {
            "Think of a time when you stood up for someone else."
            "Think of a time when you did something really difficult."
            "Think of a time when you helped someone in need."
            "Think of a time when you did something really selfless"
        }
        question = new list<string>()
        {
            "Why was this experience meaningful to you?"
            "Have you ever done anythong like this before?"
            "How did you get started?"
            "How did you feel when it was completed?"
            "What made this time different than other times when you were not as succesful?"
            "What is your favorite thing about this experience?"
            "What could learn from this experience that applies to other situations?"
            "What did you learn about yourself through this experience?"
            "How can you keep this experience in mind in the future?"
        }
    }
    public void Run()
    {
        DisplayStartingMessage()
        DisplayEndingMessage()
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompt[random.Next(prompt.count)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        string question = _question[random.Next(question.count)];
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {
        
    }
}
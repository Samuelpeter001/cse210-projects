class Program
{
    static void Main(string[] args)
    {
        Assignment assign = new Assignment("Sam", "Love");       
        Console.WriteLine(assign.GetSummary());

        MathAssignment mathAssign = new MathAssignment("Section 2", "Problem 21", "Sam", "Love");
        Console.WriteLine(mathAssign.GetHomeworkList());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string percentage = Console.ReadLine();
        int input = int.Parse(percentage);
        string grade = "";

        if (input < 60)
        {
            grade = "F";
        }
        else if (input >= 60 && input < 70)
        {
            grade = "D";
        }
        else if (input >= 70 && input < 80)
        {
            grade = "C";
        }
        else if (input >= 80 && input < 90)
        {
            grade = "B";
        }
        else if (input >= 90)
        {
            grade = "A";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}");


        if (grade >= 70)
        {
        Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You can do better next time!");
            
    }
}

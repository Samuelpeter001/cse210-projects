using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = DisplayName();
        int userNumber = FavoriteNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, SquaredNumber);
    }
        
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }    
    static string DisplayName(string userName)
    {
        Console.Writeline("Please enter your name: ");
        string name = console.Readline();
        return name;
    }
    static int FavoriteNumber(int number);
    {
        Console.Writeline("Enter your favourite number: ");
        number = int.Parse(console.Readline());
        return number;
    }
    static int SquareNumber (integer)
    {
        int square = integer * integer;
        return square;
    }
    static DisplayResult (int square, string name)
    {
    result = Console.Writeline($"Brother {name, the square of your number is {square}. ");
    }
}
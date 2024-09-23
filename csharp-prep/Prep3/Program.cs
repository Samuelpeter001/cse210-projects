using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("what is the magic number? ");
       // int number = int.Parse(Console.Readline));
        int number = randomGenerator.Next(1, 99);

        int guess = -10;
        while (guess != number)
        {   
            Console.Writeline("What is your guess? ")
            int guess = int.Parse(Console.Readline));
        
            if (guess > number)
            {
                Console.Writeline("Try Lower");
            }
            if (guess < number)
            {
                Console.Writeline("Try Higher");
            }
            else
            {
                Console.Writeline("You guessed it!")
            }

        }
    }
}
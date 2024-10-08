using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference(psalm, 23, 1);
        var word = new List<word>
        {
            new word("The"),
            new word("Lord"),
            new word("is"),
            new word("my"),
            new word("shepard;"),
            new word("I"),
            new word("shall"),
            new word("not"),
            new word("want."),
        };

        var scripture = new Scriture(reference, word);
        Console.WriteLine("Scripture Text");
        Console.WriteLine(scripture.GetDisplayText());

        scripture.HideRandomWords(3);

        Console.WriteLine("After hiding");
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Is scripture completely hidden?" + scripture.IsCompletelyHidden());
        Console.WriteLine("Reference Text:");
        Console.WriteLine(reference.GetDisplayText());

        Console.ReadLine();
    }

}
using System;
public class Adress
{
    private string Street {get; set;}
    private string City {get; set;}
    private string State {get; set;}
    private string Country {get; set;}
    public bool InUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"Street: {Street}/ City: {City}/ State: {State}/ Country: {Country}";
    }
}
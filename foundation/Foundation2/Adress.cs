using System;
public class Adress
{
    public string Street {get; set;}
    public string City {get; set;}
    public string State {get; set;}
    public string Country {get; set;}
    public bool InUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"Street: {Street}/ City: {City}/ State: {State}/ Country: {Country}";
    }
}
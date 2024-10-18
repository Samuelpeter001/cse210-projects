using System;
public class Customer
{
    public string Name {get; set;}
    public Adress CustomerAdress {get; set;}
    public bool USABased()
    {
        return CustomerAdress.InUSA();
    }

    internal bool InUSA()
    {
        throw new NotImplementedException();
    }
}
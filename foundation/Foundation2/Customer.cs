using System;
public class Customer
{
    private string Name {get; set;}
    public Adress CustomerAdress {get; set;}
    public bool USABased()
    {
        return CustomerAdress.InUSA();
    }
}
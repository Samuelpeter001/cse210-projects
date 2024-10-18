using System;
public class Products
{
    public string name {get; set;}
    public int productId {get; set;}
    public int price {get; set;}
    public int quantity {get; set;}
    public int total {get; set;}

    public Products(String Name, int ProductId, int Price, int Quantity)
    {
        name = Name;
        productId = ProductId;
        price = Price;
        quantity = Quantity;
    }
    public decimal TotalCost()
    {
        return (decimal)price * quantity;
    }
}
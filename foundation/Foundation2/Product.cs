using System;
public class Products
{
    private string name;
    private int productId;
    private int price;
    private int quantity;
    private int total;

    public Products(String Name, int ProductId, int Price, int Quantity)
    {
        name = Name;
        productId = ProductId;
        price = Price;
        quantity = Quantity;
    }
    public decimal TotalCost()
    {
        total = price * quantity;
        return total;
    }
}
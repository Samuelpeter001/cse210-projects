using System;
using System.Collections.Generic;
public class Order
{
    public List<Product> Product {get; set;} = new List<Product>();
    public Customer Order_Customer {get; set;}
    private const decimal USA_Cost = 5;
    private const decimal International_Cost = 35;
    public decimal TotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in Product)
        {
            totalCost += product.TotalCost();
        }
        decimal shippingCost;
        if (Order_Customer.InUSA())
        {
            shippingCost = USA_Cost;
        }
        else
        {
            shippingCost = International_Cost;
        }
        return totalCost + shippingCost;
    }
        public string PackingLabel()
        {
            var Label = " ";
            foreach (var product in Product)
            {
                Label += $"{product.Name}, ID: {product.ProductId}/n";
            }
            return Label;
        }

        public string ShippingLabel()
        {
        return $"Shipping Label:\n{Order_Customer.Name}\n{Order_Customer.CustomerAdress}";
        }

    }

internal class Product
{
    public string Name { get; internal set; }
    public int ProductId { get; internal set; }
    public double Price { get; internal set; }
    public int Quantity { get; internal set; }

    internal decimal TotalCost()
    {
        throw new NotImplementedException();
    }
}
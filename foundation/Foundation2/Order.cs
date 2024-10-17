using System;
public class Order
{
    private List<Product> Products {get; set;} = new List<Product>();
    private Customer Order_Customer {get; set;}
    private const decimal USA_Cost = 5;
    private const decimal International_Cost = 35;
    public decimal TotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
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
        public packingLabel()
        {
            var Label = " ";
            foreach (var product in Products)
            {
                Label =+ $"{product.Name}, ID: {product.ID}";
                return Label;
            }
        }

        public string ShippingLabel()
        {
        return $"Shipping Label:\n{Order_Customer.Name}\n{Order_Customer.CustomerAddress}";
        }

    }
}

using System;
public class Program
{
    public static void Main()
    {
        var adress = new Adress
        {
            Street = "18 Brave Street",
            City = "Villa",
            State = "Los Angeles",
            Country = "USA"
        };
        var customer = new Customer
        {
            Name = "John Doe",
            CustomerAdress = adress
        };
        var product1 = new Product { Name = "KenLouis", ProductId = 1952, Price = 30.00, Quantity = 5 };
        var product2 = new Product { Name = "Wristwatch", ProductId = 2115, Price = 10.00, Quantity = 2 };

        var order = new Order
        {
            Order_Customer = customer
        };
        order.Product.Add(product1);
        order.Product.Add(product2);

        Console.WriteLine(order.PackingLabel());
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order.TotalCost()}");
    }
}

using System;

public class OrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine("Saving order to database...");
    }

    public Order Load(int orderId)
    {
        Console.WriteLine("Loading order from database...");
        return new Order { Id = orderId };
    }
}

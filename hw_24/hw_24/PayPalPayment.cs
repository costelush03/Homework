using System;

public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing PayPal payment...");
    }
}

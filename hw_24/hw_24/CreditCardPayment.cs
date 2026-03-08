using System;

public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

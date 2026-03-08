using System;

public class BankTransferPayment : IPaymentProcessor
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing bank transfer payment...");
    }
}

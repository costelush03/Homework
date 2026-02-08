using System;
using System.Diagnostics;
using System.Threading.Tasks;

public class OrderProcessor
{
    private readonly Random _rand = new Random();

    public async Task ProcessOrderAsync(int orderId)
    {
        int delay = _rand.Next(2000, 5001); // 2–5 sec
        var sw = Stopwatch.StartNew();

        await Task.Delay(delay);

        sw.Stop();
        Console.WriteLine($"Order {orderId} processed in {sw.ElapsedMilliseconds} ms.");
    }
}



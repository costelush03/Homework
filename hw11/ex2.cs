using System;
using System.Threading.Tasks;

public static class Ex2
{
    public static void Run()
    {
        var acc1 = new BankAccount(1, 500);
        var acc2 = new BankAccount(2, 300);

        var t1 = Task.Run(() => Transfer(acc1, acc2, 100));
        var t2 = Task.Run(() => Transfer(acc2, acc1, 50));

        Task.WaitAll(t1, t2);

        Console.WriteLine($"Final balances: Acc1={acc1.Balance}, Acc2={acc2.Balance}");
    }

    static void Transfer(BankAccount from, BankAccount to, decimal amount)
    {
        var firstLock = from.Id < to.Id ? from : to;
        var secondLock = from.Id < to.Id ? to : from;

        lock (firstLock.GetLock())
        {
            lock (secondLock.GetLock())
            {
                from.Withdraw(amount);
                to.Deposit(amount);
                Console.WriteLine($"Transfer {amount} from {from.Id} to {to.Id}");
            }
        }
    }
}


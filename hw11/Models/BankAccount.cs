public class BankAccount
{
    public int Id { get; }
    public decimal Balance { get; private set; }
    private readonly object _lock = new object();

    public BankAccount(int id, decimal initialBalance)
    {
        Id = id;
        Balance = initialBalance;
    }

    public void Withdraw(decimal amount) => Balance -= amount;
    public void Deposit(decimal amount) => Balance += amount;

    public object GetLock() => _lock;
}



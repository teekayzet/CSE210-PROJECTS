public class Account
{
    public int AccountNumber { get; set; }
    public string PIN { get; set; }
    public decimal Balance { get; set; }

    public decimal GetBalance()
    {
        return Balance;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    internal void GetAccountDetails(Database database, Error error)
    {
        throw new NotImplementedException();
    }
}

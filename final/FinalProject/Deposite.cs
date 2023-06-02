public class Deposit : Transaction
{
    public decimal Amount { get; set; }

    public Deposit(string transactionID, string accountNumber, string transactionType, decimal amount)
        : base(transactionID, transactionType)
    {
        Amount = amount;
    }

    public void ProcessTransaction(Account account)
    {
        account.Balance += Amount;
        Console.WriteLine("Transaction successful! Your new balance is: {0:C}", account.Balance);
    }
}

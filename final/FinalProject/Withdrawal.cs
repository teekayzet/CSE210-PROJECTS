public class Withdrawal : Transaction
{
    public decimal Amount { get; set; }

    public Withdrawal(string transactionID, string accountNumber, string transactionType, decimal amount)
        : base(transactionID, transactionType)
    {
        Amount = amount;
    }

    public void ProcessTransaction(Account account)
    {
        if (Amount > account.Balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            account.Balance -= Amount;
            Console.WriteLine("Transaction successful! Your new balance is: {0:C}", account.Balance);
        }
    }
}
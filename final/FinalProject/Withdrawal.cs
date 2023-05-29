public class Withdrawal : Transaction
{
    internal double transactionFee;

    public Withdrawal(double amount)
    {
        Amount = amount;
    }

    public override void LogTransaction()
    {
        // TODO: Implement this method
    }

    public override IEnumerable<object> GetTransactionDetails()
    {
        try
        {
            // Get the transaction details from the database
            var results = Database.GetWithdrawalTransactionDetails(AccountNumber, Amount);

            // Return the results
            return results;
        }
        catch (Exception)
        {
            // Handle the exception
            // ...

            // Return an empty sequence
            return Enumerable.Empty<object>();
        }
    }

    internal void ProcessTransaction(Account account, Database database, Authentication authentication, Error error)
    {
        throw new NotImplementedException();
    }

    public double TransactionFee
    {
        get
        {
            return Amount * 0.01;
        }
    }
}

public class Deposit : Transaction
{
    public Deposit(int accountNumber, double amount)
    {
        AccountNumber = accountNumber;
        Amount = amount;
    }

    public override void LogTransaction()
    {
        // TODO: Implement this method
    }

    public override IEnumerable<object> GetTransactionDetails()
    {
        // Get the transaction details from the database
        var results = Database.GetDepositTransactionDetails(AccountNumber, Amount);

        // Return the results
        return results;
    }
}
public abstract class Transaction
{
    public int TransactionID { get; set; }
    public int AccountNumber { get; set; }
    public string TransactionType { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }

    public abstract void LogTransaction();

    public virtual IEnumerable<object> GetTransactionDetails()
    {
        try
        {
            // Get the transaction details from the database
            var results = Database.GetTransactionDetails(TransactionID);

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
}